using System;
using System.IO.MemoryMappedFiles;
using System.Linq.Expressions;
using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
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
        public void OnMapReady(MapboxMap p0)
        {
            // This will refer to OnStyleLoaded
            p0.SetStyle(Style.MapboxStreets, this);
            var title1 = "Chicago";
            var lat1 = 41.897627;
            var lng1 = -87.643526;
            var title2 = "St.Louis";
            var lat2 = 38.742291;
            var lng2 = -90.064928;
            var latLng1 = new LatLng(lat1, lng1);
            var latLng2 = new LatLng(lat2, lng2);
            var points = new ArrayList();
            points.Add(latLng1);
            points.Add(latLng2);
            points.Add(latLng1);

            var polyline = new PolylineOptions();
            polyline.AddAll(points);
            polyline.InvokeWidth(2);
            polyline.InvokeColor(Color.Blue);
            p0.AddPolyline(polyline);

            var marker1 = new MarkerOptions();
            var marker2 = new MarkerOptions();
            marker1.SetPosition(latLng1);
            marker1.SetTitle(title1);
            marker2.SetPosition(latLng2);
            marker2.SetTitle(title2);
            p0.AddMarker(marker1);
            p0.AddMarker(marker2);

        }


        //implements the IOnStyleLoaded Interface
        public void OnStyleLoaded(Style p0)
        {
            //place style changes (annotations) here

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


    }
}
