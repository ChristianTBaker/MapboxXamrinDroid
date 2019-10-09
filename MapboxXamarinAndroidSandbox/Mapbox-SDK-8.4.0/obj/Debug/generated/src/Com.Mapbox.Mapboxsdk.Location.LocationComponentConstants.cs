using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentConstants']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/LocationComponentConstants", DoNotGenerateAcw=true)]
	public sealed partial class LocationComponentConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentConstants']/field[@name='ACCURACY_LAYER']"
		[Register ("ACCURACY_LAYER")]
		public const string AccuracyLayer = (string) "mapbox-location-accuracy-layer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentConstants']/field[@name='BACKGROUND_LAYER']"
		[Register ("BACKGROUND_LAYER")]
		public const string BackgroundLayer = (string) "mapbox-location-background-layer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentConstants']/field[@name='BEARING_LAYER']"
		[Register ("BEARING_LAYER")]
		public const string BearingLayer = (string) "mapbox-location-bearing-layer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentConstants']/field[@name='FOREGROUND_LAYER']"
		[Register ("FOREGROUND_LAYER")]
		public const string ForegroundLayer = (string) "mapbox-location-foreground-layer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentConstants']/field[@name='LOCATION_SOURCE']"
		[Register ("LOCATION_SOURCE")]
		public const string LocationSource = (string) "mapbox-location-source";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentConstants']/field[@name='SHADOW_LAYER']"
		[Register ("SHADOW_LAYER")]
		public const string ShadowLayer = (string) "mapbox-location-shadow-layer";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/location/LocationComponentConstants", typeof (LocationComponentConstants));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal LocationComponentConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
