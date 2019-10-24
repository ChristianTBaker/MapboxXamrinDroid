using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.MemoryMappedFiles;
using System.Linq.Expressions;
using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.Graphics;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

using Com.Mapbox.Mapboxsdk;
using Com.Mapbox.Mapboxsdk.Maps;
using Com.Mapbox.Mapboxsdk.Geometry;
using Com.Mapbox.Mapboxsdk.Utils;
using Com.Mapbox.Mapboxsdk.Style.Sources;
using Com.Mapbox.Mapboxsdk.Annotations;
using Com.Mapbox.Mapboxsdk.Camera;
using Com.Mapbox.Mapboxsdk.Plugins.Annotation;
using Com.Mapbox.Mapboxsdk.Utils;
using Java.Security;
using Java.Util;

namespace MapboxAndroidSandbox
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnMapReadyCallback, Style.IOnStyleLoaded
    {

        public static string MARKER = "marker";

        private MapView mapView;
        private MapboxMap mapboxMap;
        private LatLng pickupPoint;
        private LatLng delivertPoint;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            Mapbox.GetInstance(this, "pk.eyJ1IjoiYmFrZXJjdDkwIiwiYSI6ImNrMGd2d3cyeDA4cW4zaGpzcXF1M2lja2kifQ.wtDY8EI3PAceA-C-HI4c0A");
            SetContentView(Resource.Layout.content_main);
            mapView = (MapView)FindViewById(Resource.Id.mapView);
            mapView.OnCreate(savedInstanceState);

            mapView.GetMapAsync(
                this
                );

        }

        //Implements the IOnMapReadyCallback interface
        public void OnMapReady(MapboxMap map)
        {
            mapboxMap = map;

            // This will refer to OnStyleLoaded
            map.SetStyle(Style.MapboxStreets, this);
            var title1 = "Chicago";
            var lat1 = 41.897627;
            var lng1 = -87.643526;
            var title2 = "St.Louis";
            var lat2 = 38.742291;
            var lng2 = -90.064928;

            pickupPoint = new LatLng(lat1, lng1);
            delivertPoint = new LatLng(lat2, lng2);


            var plotList = CreatePlotList(lat1, lng1, lat2, lng2);
            var yList = plotList[0];
            var xList = plotList[1];
            var latList = ConvertToLats(yList);
            var lngList = ConvertToLngs(xList);
            var points = ConvertToPoints(latList, lngList);
            CreateDashedLine(points);

            var marker1 = new MarkerOptions();
            var marker2 = new MarkerOptions();
            marker1.SetPosition(pickupPoint);
            marker1.SetTitle(title1);
            marker2.SetPosition(delivertPoint);
            marker2.SetTitle(title2);
            map.AddMarker(marker1);
            map.AddMarker(marker2);

        }


        //implements the IOnStyleLoaded Interface
        public void OnStyleLoaded(Style p0)
        {
            //place style changes (annotations) here
/*            var lineManager = new LineManager(mapView, mapboxMap, p0);
            var title1 = "Chicago";
            var lat1 = 41.907627;
            var lng1 = -87.643526;
            var title2 = "St.Louis";
            var lat2 = 38.742291;
            var lng2 = -90.074928;
            var latLng1 = new LatLng(lat1, lng1);
            var latLng2 = new LatLng(lat2, lng2);
            var points = new List<LatLng>() { latLng1, latLng2, latLng1 };
            var lineOptions = new LineOptions()
                .WithLatLngs(points)
                .WithLineColor(Com.Mapbox.Mapboxsdk.Utils.ColorUtils.ColorToRgbaString(Color.Red))
                .WithLineWidth(5.0f);
            lineManager.Create(lineOptions);*/

            var latLngBounds = new LatLngBounds.Builder().Include(pickupPoint).Include(delivertPoint).Build();

            mapboxMap.EaseCamera(CameraUpdateFactory.NewLatLngBounds(latLngBounds, 200), 3000);

        }



        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnStart()
        {
            base.OnStart();
            mapView.OnStart();
        }

        private List<List<double>> CreatePlotList(double lat1, double lng1, double lat2, double lng2)
        {
            double x1;
            double x2;

            var y1 = 90.0 + lat1;
            var y2 = 90.0 + lat2;

            if (lng1 < 0)
            {
                x1 = 360.0 + lng1;
            }
            else
            {
                x1 = lng1;
            }

            if (lng2 < 0)
            {
                x2 = 360.0 + lng2;
            }
            else
            {
                x2 = lng2;
            }

            var yList = new List<double>();
            yList.Add(y1);
            var xList = new List<double>();
            xList.Add(x1);

            var yDiff = y2 - y1;
            var xDiff = x2 - x1;

            var yIncrement = yDiff / 31;
            var xIncrement = xDiff / 31;

            var currentY = y1;
            var currentX = x1;

            for (var i = 0; i < 30; i++)
            {
                currentY += yIncrement;
                currentX += xIncrement;

                yList.Add(currentY);
                xList.Add(currentX);
            }

            return new List<List<double>>() { yList, xList };
        }

        private List<double> ConvertToLngs(List<double> xList)
        {
            var lngList = new List<double>();

            foreach (double x in xList)
            {
                if (x > 180)
                {
                    lngList.Add(x - 360.0);
                }
                else
                {
                    lngList.Add(x);
                }
            }

            return lngList;
        }

        private List<double> ConvertToLats(List<double> yList)
        {
            var latList = new List<double>();

            foreach (double y in yList)
            {
                latList.Add(y - 90.0);
            }

            return latList;
        }

        private List<LatLng> ConvertToPoints(List<double> latList, List<double> lngList)
        {
            var points = new List<LatLng>();

            if (latList.Count == lngList.Count)
            {
                for (var i = 0; i < latList.Count; i++)
                {
                    points.Add(new LatLng(latList[i], lngList[i]));
                }
            }

            return points;
        }

        private void CreateDashedLine(List<LatLng> points)
        {
            for (var i = 0; i < (points.Count - 1); i += 2)
            {
                var nextLine = new ArrayList();
                nextLine.Add(points[i]);
                nextLine.Add(points[i + 1]);
                var polyline = new PolylineOptions();
                polyline.AddAll(nextLine);
                polyline.InvokeWidth(2);
                polyline.InvokeColor(Color.Gray);
                mapboxMap.AddPolyline(polyline);
            }
        }
    }
}
