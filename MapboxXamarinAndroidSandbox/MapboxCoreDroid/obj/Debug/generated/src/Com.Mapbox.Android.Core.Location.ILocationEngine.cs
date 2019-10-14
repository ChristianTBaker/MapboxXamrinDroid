using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.core.location']/interface[@name='LocationEngine']"
	[Register ("com/mapbox/android/core/location/LocationEngine", "", "Com.Mapbox.Android.Core.Location.ILocationEngineInvoker")]
	public partial interface ILocationEngine : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/interface[@name='LocationEngine']/method[@name='getLastLocation' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.core.location.LocationEngineCallback&lt;com.mapbox.android.core.location.LocationEngineResult&gt;']]"
		[Register ("getLastLocation", "(Lcom/mapbox/android/core/location/LocationEngineCallback;)V", "GetGetLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_Handler:Com.Mapbox.Android.Core.Location.ILocationEngineInvoker, MapboxCoreDroid")]
		void GetLastLocation (global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/interface[@name='LocationEngine']/method[@name='removeLocationUpdates' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
		[Register ("removeLocationUpdates", "(Landroid/app/PendingIntent;)V", "GetRemoveLocationUpdates_Landroid_app_PendingIntent_Handler:Com.Mapbox.Android.Core.Location.ILocationEngineInvoker, MapboxCoreDroid")]
		void RemoveLocationUpdates (global::Android.App.PendingIntent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/interface[@name='LocationEngine']/method[@name='removeLocationUpdates' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.core.location.LocationEngineCallback&lt;com.mapbox.android.core.location.LocationEngineResult&gt;']]"
		[Register ("removeLocationUpdates", "(Lcom/mapbox/android/core/location/LocationEngineCallback;)V", "GetRemoveLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_Handler:Com.Mapbox.Android.Core.Location.ILocationEngineInvoker, MapboxCoreDroid")]
		void RemoveLocationUpdates (global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/interface[@name='LocationEngine']/method[@name='requestLocationUpdates' and count(parameter)=2 and parameter[1][@type='com.mapbox.android.core.location.LocationEngineRequest'] and parameter[2][@type='android.app.PendingIntent']]"
		[Register ("requestLocationUpdates", "(Lcom/mapbox/android/core/location/LocationEngineRequest;Landroid/app/PendingIntent;)V", "GetRequestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_Handler:Com.Mapbox.Android.Core.Location.ILocationEngineInvoker, MapboxCoreDroid")]
		void RequestLocationUpdates (global::Com.Mapbox.Android.Core.Location.LocationEngineRequest p0, global::Android.App.PendingIntent p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/interface[@name='LocationEngine']/method[@name='requestLocationUpdates' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.core.location.LocationEngineRequest'] and parameter[2][@type='com.mapbox.android.core.location.LocationEngineCallback&lt;com.mapbox.android.core.location.LocationEngineResult&gt;'] and parameter[3][@type='android.os.Looper']]"
		[Register ("requestLocationUpdates", "(Lcom/mapbox/android/core/location/LocationEngineRequest;Lcom/mapbox/android/core/location/LocationEngineCallback;Landroid/os/Looper;)V", "GetRequestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_Handler:Com.Mapbox.Android.Core.Location.ILocationEngineInvoker, MapboxCoreDroid")]
		void RequestLocationUpdates (global::Com.Mapbox.Android.Core.Location.LocationEngineRequest p0, global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback p1, global::Android.OS.Looper p2);

	}

	[global::Android.Runtime.Register ("com/mapbox/android/core/location/LocationEngine", DoNotGenerateAcw=true)]
	internal class ILocationEngineInvoker : global::Java.Lang.Object, ILocationEngine {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/core/location/LocationEngine", typeof (ILocationEngineInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ILocationEngine GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationEngine> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.core.location.LocationEngine"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationEngineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_;
#pragma warning disable 0169
		static Delegate GetGetLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_Handler ()
		{
			if (cb_getLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_ == null)
				cb_getLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_);
			return cb_getLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_;
		}

		static void n_GetLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Android.Core.Location.ILocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback p0 = (global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetLastLocation (p0);
		}
#pragma warning restore 0169

		IntPtr id_getLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_;
		public unsafe void GetLastLocation (global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback p0)
		{
			if (id_getLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_ == IntPtr.Zero)
				id_getLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_ = JNIEnv.GetMethodID (class_ref, "getLastLocation", "(Lcom/mapbox/android/core/location/LocationEngineCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLastLocation_Lcom_mapbox_android_core_location_LocationEngineCallback_, __args);
		}

		static Delegate cb_removeLocationUpdates_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetRemoveLocationUpdates_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_removeLocationUpdates_Landroid_app_PendingIntent_ == null)
				cb_removeLocationUpdates_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocationUpdates_Landroid_app_PendingIntent_);
			return cb_removeLocationUpdates_Landroid_app_PendingIntent_;
		}

		static void n_RemoveLocationUpdates_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Android.Core.Location.ILocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocationUpdates (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeLocationUpdates_Landroid_app_PendingIntent_;
		public unsafe void RemoveLocationUpdates (global::Android.App.PendingIntent p0)
		{
			if (id_removeLocationUpdates_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_removeLocationUpdates_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "removeLocationUpdates", "(Landroid/app/PendingIntent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeLocationUpdates_Landroid_app_PendingIntent_, __args);
		}

		static Delegate cb_removeLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_Handler ()
		{
			if (cb_removeLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_ == null)
				cb_removeLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_);
			return cb_removeLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_;
		}

		static void n_RemoveLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Android.Core.Location.ILocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback p0 = (global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocationUpdates (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_;
		public unsafe void RemoveLocationUpdates (global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback p0)
		{
			if (id_removeLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_ == IntPtr.Zero)
				id_removeLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_ = JNIEnv.GetMethodID (class_ref, "removeLocationUpdates", "(Lcom/mapbox/android/core/location/LocationEngineCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineCallback_, __args);
		}

		static Delegate cb_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetRequestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_ == null)
				cb_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_);
			return cb_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_;
		}

		static void n_RequestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Android.Core.Location.ILocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Core.Location.LocationEngineRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p1 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocationUpdates (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_;
		public unsafe void RequestLocationUpdates (global::Com.Mapbox.Android.Core.Location.LocationEngineRequest p0, global::Android.App.PendingIntent p1)
		{
			if (id_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "requestLocationUpdates", "(Lcom/mapbox/android/core/location/LocationEngineRequest;Landroid/app/PendingIntent;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Landroid_app_PendingIntent_, __args);
		}

		static Delegate cb_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_;
#pragma warning disable 0169
		static Delegate GetRequestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_Handler ()
		{
			if (cb_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_ == null)
				cb_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_);
			return cb_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_;
		}

		static void n_RequestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mapbox.Android.Core.Location.ILocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Core.Location.LocationEngineRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback p1 = (global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Looper p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocationUpdates (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_;
		public unsafe void RequestLocationUpdates (global::Com.Mapbox.Android.Core.Location.LocationEngineRequest p0, global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback p1, global::Android.OS.Looper p2)
		{
			if (id_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_ == IntPtr.Zero)
				id_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "requestLocationUpdates", "(Lcom/mapbox/android/core/location/LocationEngineRequest;Lcom/mapbox/android/core/location/LocationEngineCallback;Landroid/os/Looper;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestLocationUpdates_Lcom_mapbox_android_core_location_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineCallback_Landroid_os_Looper_, __args);
		}

	}

}
