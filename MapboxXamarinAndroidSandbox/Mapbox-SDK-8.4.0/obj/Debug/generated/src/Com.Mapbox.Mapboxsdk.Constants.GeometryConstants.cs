using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/constants/GeometryConstants", DoNotGenerateAcw=true)]
	public partial class GeometryConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='LATITUDE_SPAN']"
		[Register ("LATITUDE_SPAN")]
		public const double LatitudeSpan = (double) 180;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='LONGITUDE_SPAN']"
		[Register ("LONGITUDE_SPAN")]
		public const double LongitudeSpan = (double) 360;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='MAX_LATITUDE']"
		[Register ("MAX_LATITUDE")]
		public const double MaxLatitude = (double) 90;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='MAX_LONGITUDE']"
		[Register ("MAX_LONGITUDE")]
		public const double MaxLongitude = (double) 1.7976931348623157E308;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='MAX_MERCATOR_LATITUDE']"
		[Register ("MAX_MERCATOR_LATITUDE")]
		public const double MaxMercatorLatitude = (double) 85.051128779806589;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='MAX_WRAP_LONGITUDE']"
		[Register ("MAX_WRAP_LONGITUDE")]
		public const double MaxWrapLongitude = (double) 180;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='MIN_LATITUDE']"
		[Register ("MIN_LATITUDE")]
		public const double MinLatitude = (double) -90;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='MIN_LONGITUDE']"
		[Register ("MIN_LONGITUDE")]
		public const double MinLongitude = (double) -1.7976931348623157E308;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='MIN_MERCATOR_LATITUDE']"
		[Register ("MIN_MERCATOR_LATITUDE")]
		public const double MinMercatorLatitude = (double) -85.051128779806589;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='MIN_WRAP_LONGITUDE']"
		[Register ("MIN_WRAP_LONGITUDE")]
		public const double MinWrapLongitude = (double) -180;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='GeometryConstants']/field[@name='RADIUS_EARTH_METERS']"
		[Register ("RADIUS_EARTH_METERS")]
		public const int RadiusEarthMeters = (int) 6378137;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/constants/GeometryConstants", typeof (GeometryConstants));
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

		protected GeometryConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
