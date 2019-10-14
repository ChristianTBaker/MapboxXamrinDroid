using System;
using System.IO.MemoryMappedFiles;
using Android.App;
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
using Java.Security;

namespace MapboxAndroidSandbox
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnMapReadyCallback
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

        public void OnMapReady(MapboxMap p0)
        {
            p0.SetStyle(Style.MapboxStreets);
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
