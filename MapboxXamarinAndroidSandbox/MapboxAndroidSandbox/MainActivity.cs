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

            bool crossesMeridianOrDateline;

            if ((lng1 > 0.0 && lng2 < 0.0) || (lng1 < 0.0 && lng2 > 0.0))
            {
                crossesMeridianOrDateline = true;
            }
            else
            {
                crossesMeridianOrDateline = false;
            }

            var xDiffPrimeMeridianZero = FindXDiffPrimeMeridianZero(lng1, lng2);
            var xDiffDatelineZero = FindXDiffDatelineZero(lng1, lng2);

            List<double> xList;
            List<double> lngList;

            if ((Math.Abs(xDiffDatelineZero) > Math.Abs(xDiffPrimeMeridianZero)) && crossesMeridianOrDateline == true)
            {
                var latCenter = (lat1 + lat2) / 2.0;

                // Find center coordinate here
                var x1 = FindXPrimeMeridianZero(lng1);
                var xCenter = x1 + (xDiffPrimeMeridianZero / 2.0);
                double lngCenter;

                if (x1 > 180.0)
                {
                    lngCenter = xCenter - 360.0;
                }
                else
                {
                    lngCenter = xCenter;
                }

                var cameraCenter = new CameraPosition.Builder().Target(new LatLng(latCenter, lngCenter)).Zoom(1.5).Build();

                map.AnimateCamera(CameraUpdateFactory.NewCameraPosition(cameraCenter));

                xList = CreateXList(xDiffPrimeMeridianZero, x1);
                lngList = ConvertToLngsPrimeMeridianZero(xList);
            }
            else
            {
                // find max/min lat/lng here
                // use those to determine the initialBounds

                var latDict = FindLowHigh(lat1, lat2);
                var latHigh = latDict["high"];
                var latLow = latDict["low"];
                var lngDict = FindLowHigh(lng1, lng2);
                var lngHigh = lngDict["high"];
                var lngLow = lngDict["low"];

                var latBuffer = (latHigh - latLow) / 4.0;
                var lngBuffer = (lngHigh - lngLow) / 10.0;

                var swLat = latLow - latBuffer;
                var swLng = lngLow - lngBuffer;
                var neLat = latHigh + latBuffer;
                var neLng = lngHigh + lngBuffer;

                var swPoint = new LatLng(swLat, swLng);
                var nePoint = new LatLng(neLat, neLng);

                var latLngBounds = new LatLngBounds.Builder()
                    .Include(nePoint) // Northeast
                    .Include(swPoint) // Southwest
                    .Build();

                mapboxMap.EaseCamera(CameraUpdateFactory.NewLatLngBounds(latLngBounds, 0));

                xList = CreateXList(xDiffDatelineZero, FindXDatelineZero(lng1));
                lngList = ConvertToLngsDatelineZero(xList);
            }

            var yList = CreateYList(lat1, lat2);

            var latList = ConvertToLats(yList);
            var coords = ConvertToCoords(latList, lngList);
            CreateDashedLine(coords);

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

/*            var latLngBounds = new LatLngBounds.Builder()
                .Include(pickupPoint) // Northeast
                .Include(delivertPoint) // Southwest
                .Build();

            mapboxMap.EaseCamera(CameraUpdateFactory.NewLatLngBounds(latLngBounds, 200), 3000);*/

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


        private List<double> CreateXList(double xDiff, double x1)
        {

            var xList = new List<double>();
            xList.Add(x1);

            var xIncrement = xDiff / 31;

            var currentX = x1;

            for (var i = 0; i < 30; i++)
            {
                currentX += xIncrement;

                xList.Add(currentX);
            }

            return xList;
        }

        public double FindXDiffPrimeMeridianZero(double lng1, double lng2)
        {
            var x1 = FindXPrimeMeridianZero(lng1);
            var x2 = FindXPrimeMeridianZero(lng2);

            var xDiff = x2 - x1;

            return xDiff;
        }

        public double FindXPrimeMeridianZero(double lng)
        {
            double x;

            if (lng < 0.0)
            {
                x = 360.0 + lng;
            }
            else
            {
                x = lng;
            }

            return x;
        }

        public double FindXDiffDatelineZero(double lng1, double lng2)
        {
            var x1 = FindXDatelineZero(lng1);
            var x2 = FindXDatelineZero(lng2);

            var xDiff = x2 - x1;

            return xDiff;
        }

        public double FindXDatelineZero(double lng)
        {
            return 180.0 + lng;
        }

        private List<double> CreateYList(double lat1, double lat2)
        {
            var y1 = 90.0 + lat1;
            var y2 = 90.0 + lat2;

            var yDiff = y2 - y1;

            var yList = new List<double>();
            yList.Add(y1);

            var yIncrement = yDiff / 31;

            var currentY = y1;

            for (var i = 0; i < 30; i++)
            {
                currentY += yIncrement;

                yList.Add(currentY);
            }

            return yList;
        }

        private List<double> ConvertToLngsPrimeMeridianZero(List<double> xList)
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

        private List<double> ConvertToLngsDatelineZero(List<double> xList)
        {
            var lngList = new List<double>();

            foreach (double x in xList)
            {
                lngList.Add(x - 180.0);
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

        private List<LatLng> ConvertToCoords(List<double> latList, List<double> lngList)
        {
            var coords = new List<LatLng>();

            if (latList.Count == lngList.Count)
            {
                for (var i = 0; i < latList.Count; i++)
                {
                    coords.Add(new LatLng(latList[i], lngList[i]));
                }
            }

            return coords;
        }

        private void CreateDashedLine(List<LatLng> coords)
        {
            for (var i = 0; i < (coords.Count - 1); i += 2)
            {
                var nextLine = new ArrayList();
                nextLine.Add(coords[i]);
                nextLine.Add(coords[i + 1]);
                var polyline = new PolylineOptions();
                polyline.AddAll(nextLine);
                polyline.InvokeWidth(2);
                polyline.InvokeColor(Color.Gray);
                mapboxMap.AddPolyline(polyline);
            }
        }

        private Dictionary<string, double> FindLowHigh(double num1, double num2)
        {
            double low;
            double high;

            if (num1 >= num2)
            {
                high = num1;
                low = num2;
            }
            else
            {
                high = num2;
                low = num1;
            }

            return new Dictionary<string, double>()
            {
                {"low", low },
                {"high", high }
            };
        }
    }
}
