using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='LocationMapper']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/location/LocationMapper", DoNotGenerateAcw=true)]
	public partial class LocationMapper : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/location/LocationMapper", typeof (LocationMapper));
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

		protected LocationMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='LocationMapper']/constructor[@name='LocationMapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocationMapper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='LocationMapper']/method[@name='create' and count(parameter)=2 and parameter[1][@type='android.location.Location'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Landroid/location/Location;Ljava/lang/String;)Lcom/mapbox/android/telemetry/LocationEvent;", "")]
		public static unsafe global::Com.Mapbox.Android.Telemetry.LocationEvent Create (global::Android.Locations.Location location, string sessionId)
		{
			const string __id = "create.(Landroid/location/Location;Ljava/lang/String;)Lcom/mapbox/android/telemetry/LocationEvent;";
			IntPtr native_sessionId = JNIEnv.NewString (sessionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((location == null) ? IntPtr.Zero : ((global::Java.Lang.Object) location).Handle);
				__args [1] = new JniArgumentValue (native_sessionId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.LocationEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sessionId);
			}
		}

		static Delegate cb_from_Landroid_location_Location_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFrom_Landroid_location_Location_Ljava_lang_String_Handler ()
		{
			if (cb_from_Landroid_location_Location_Ljava_lang_String_ == null)
				cb_from_Landroid_location_Location_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_From_Landroid_location_Location_Ljava_lang_String_);
			return cb_from_Landroid_location_Location_Ljava_lang_String_;
		}

		static IntPtr n_From_Landroid_location_Location_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location, IntPtr native_applicationState)
		{
			global::Com.Mapbox.Android.Telemetry.Location.LocationMapper __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Location.LocationMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location location = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_location, JniHandleOwnership.DoNotTransfer);
			string applicationState = JNIEnv.GetString (native_applicationState, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.From (location, applicationState));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='LocationMapper']/method[@name='from' and count(parameter)=2 and parameter[1][@type='android.location.Location'] and parameter[2][@type='java.lang.String']]"
		[Register ("from", "(Landroid/location/Location;Ljava/lang/String;)Lcom/mapbox/android/telemetry/LocationEvent;", "GetFrom_Landroid_location_Location_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Android.Telemetry.LocationEvent From (global::Android.Locations.Location location, string applicationState)
		{
			const string __id = "from.(Landroid/location/Location;Ljava/lang/String;)Lcom/mapbox/android/telemetry/LocationEvent;";
			IntPtr native_applicationState = JNIEnv.NewString (applicationState);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((location == null) ? IntPtr.Zero : ((global::Java.Lang.Object) location).Handle);
				__args [1] = new JniArgumentValue (native_applicationState);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.LocationEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationState);
			}
		}

		static Delegate cb_updateSessionIdentifier_Lcom_mapbox_android_telemetry_location_SessionIdentifier_;
#pragma warning disable 0169
		static Delegate GetUpdateSessionIdentifier_Lcom_mapbox_android_telemetry_location_SessionIdentifier_Handler ()
		{
			if (cb_updateSessionIdentifier_Lcom_mapbox_android_telemetry_location_SessionIdentifier_ == null)
				cb_updateSessionIdentifier_Lcom_mapbox_android_telemetry_location_SessionIdentifier_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateSessionIdentifier_Lcom_mapbox_android_telemetry_location_SessionIdentifier_);
			return cb_updateSessionIdentifier_Lcom_mapbox_android_telemetry_location_SessionIdentifier_;
		}

		static void n_UpdateSessionIdentifier_Lcom_mapbox_android_telemetry_location_SessionIdentifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sessionIdentifier)
		{
			global::Com.Mapbox.Android.Telemetry.Location.LocationMapper __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Location.LocationMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Telemetry.Location.SessionIdentifier sessionIdentifier = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Location.SessionIdentifier> (native_sessionIdentifier, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSessionIdentifier (sessionIdentifier);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='LocationMapper']/method[@name='updateSessionIdentifier' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.location.SessionIdentifier']]"
		[Register ("updateSessionIdentifier", "(Lcom/mapbox/android/telemetry/location/SessionIdentifier;)V", "GetUpdateSessionIdentifier_Lcom_mapbox_android_telemetry_location_SessionIdentifier_Handler")]
		public virtual unsafe void UpdateSessionIdentifier (global::Com.Mapbox.Android.Telemetry.Location.SessionIdentifier sessionIdentifier)
		{
			const string __id = "updateSessionIdentifier.(Lcom/mapbox/android/telemetry/location/SessionIdentifier;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sessionIdentifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sessionIdentifier).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
