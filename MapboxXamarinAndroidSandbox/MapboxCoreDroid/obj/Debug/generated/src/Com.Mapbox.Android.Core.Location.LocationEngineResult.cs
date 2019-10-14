using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineResult']"
	[global::Android.Runtime.Register ("com/mapbox/android/core/location/LocationEngineResult", DoNotGenerateAcw=true)]
	public sealed partial class LocationEngineResult : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/location/LocationEngineResult", typeof (LocationEngineResult));
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

		internal LocationEngineResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Android.Locations.Location LastLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineResult']/method[@name='getLastLocation' and count(parameter)=0]"
			[Register ("getLastLocation", "()Landroid/location/Location;", "GetGetLastLocationHandler")]
			get {
				const string __id = "getLastLocation.()Landroid/location/Location;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Android.Locations.Location> Locations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineResult']/method[@name='getLocations' and count(parameter)=0]"
			[Register ("getLocations", "()Ljava/util/List;", "GetGetLocationsHandler")]
			get {
				const string __id = "getLocations.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Locations.Location>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineResult']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("create", "(Landroid/location/Location;)Lcom/mapbox/android/core/location/LocationEngineResult;", "")]
		public static unsafe global::Com.Mapbox.Android.Core.Location.LocationEngineResult Create (global::Android.Locations.Location location)
		{
			const string __id = "create.(Landroid/location/Location;)Lcom/mapbox/android/core/location/LocationEngineResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((location == null) ? IntPtr.Zero : ((global::Java.Lang.Object) location).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineResult']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.location.Location&gt;']]"
		[Register ("create", "(Ljava/util/List;)Lcom/mapbox/android/core/location/LocationEngineResult;", "")]
		public static unsafe global::Com.Mapbox.Android.Core.Location.LocationEngineResult Create (global::System.Collections.Generic.IList<global::Android.Locations.Location> locations)
		{
			const string __id = "create.(Ljava/util/List;)Lcom/mapbox/android/core/location/LocationEngineResult;";
			IntPtr native_locations = global::Android.Runtime.JavaList<global::Android.Locations.Location>.ToLocalJniHandle (locations);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_locations);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_locations);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineResult']/method[@name='extractResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("extractResult", "(Landroid/content/Intent;)Lcom/mapbox/android/core/location/LocationEngineResult;", "")]
		public static unsafe global::Com.Mapbox.Android.Core.Location.LocationEngineResult ExtractResult (global::Android.Content.Intent intent)
		{
			const string __id = "extractResult.(Landroid/content/Intent;)Lcom/mapbox/android/core/location/LocationEngineResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
