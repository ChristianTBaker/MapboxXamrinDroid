using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Camera {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/interface[@name='CameraUpdate']"
	[Register ("com/mapbox/mapboxsdk/camera/CameraUpdate", "", "Com.Mapbox.Mapboxsdk.Camera.ICameraUpdateInvoker")]
	public partial interface ICameraUpdate : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/interface[@name='CameraUpdate']/method[@name='getCameraPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
		[Register ("getCameraPosition", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "GetGetCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Handler:Com.Mapbox.Mapboxsdk.Camera.ICameraUpdateInvoker, Mapbox-SDK-8.4.0")]
		global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraPosition (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/camera/CameraUpdate", DoNotGenerateAcw=true)]
	internal class ICameraUpdateInvoker : global::Java.Lang.Object, ICameraUpdate {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/camera/CameraUpdate", typeof (ICameraUpdateInvoker));

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

		public static ICameraUpdate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICameraUpdate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.camera.CameraUpdate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraUpdateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
#pragma warning disable 0169
		static Delegate GetGetCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Handler ()
		{
			if (cb_getCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ == null)
				cb_getCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_);
			return cb_getCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
		}

		static IntPtr n_GetCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCameraPosition (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
		public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraPosition (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap p0)
		{
			if (id_getCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ == IntPtr.Zero)
				id_getCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ = JNIEnv.GetMethodID (class_ref, "getCameraPosition", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCameraPosition_Lcom_mapbox_mapboxsdk_maps_MapboxMap_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
