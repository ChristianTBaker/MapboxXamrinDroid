using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetryConstants']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/MapboxTelemetryConstants", DoNotGenerateAcw=true)]
	public sealed partial class MapboxTelemetryConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetryConstants']/field[@name='ACTION_TOKEN_CHANGED']"
		[Register ("ACTION_TOKEN_CHANGED")]
		public const string ActionTokenChanged = (string) "com.mapbox.android.telemetry.action.TOKEN_CHANGED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetryConstants']/field[@name='LOCATION_COLLECTOR_ENABLED']"
		[Register ("LOCATION_COLLECTOR_ENABLED")]
		public const string LocationCollectorEnabled = (string) "mapboxTelemetryLocationState";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetryConstants']/field[@name='MAPBOX_SHARED_PREFERENCES']"
		[Register ("MAPBOX_SHARED_PREFERENCES")]
		public const string MapboxSharedPreferences = (string) "MapboxSharedPreferences";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetryConstants']/field[@name='MAPBOX_TELEMETRY_PACKAGE']"
		[Register ("MAPBOX_TELEMETRY_PACKAGE")]
		public const string MapboxTelemetryPackage = (string) "com.mapbox.android.telemetry";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetryConstants']/field[@name='SESSION_ROTATION_INTERVAL_MILLIS']"
		[Register ("SESSION_ROTATION_INTERVAL_MILLIS")]
		public const string SessionRotationIntervalMillis = (string) "mapboxSessionRotationInterval";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/MapboxTelemetryConstants", typeof (MapboxTelemetryConstants));
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

		internal MapboxTelemetryConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
