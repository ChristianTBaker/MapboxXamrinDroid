using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='OnMapReadyCallback']"
	[Register ("com/mapbox/mapboxsdk/maps/OnMapReadyCallback", "", "Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallbackInvoker")]
	public partial interface IOnMapReadyCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='OnMapReadyCallback']/method[@name='onMapReady' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
		[Register ("onMapReady", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V", "GetOnMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Handler:Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallbackInvoker, Mapbox-SDK-8.4.0")]
		void OnMapReady (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/OnMapReadyCallback", DoNotGenerateAcw=true)]
	internal class IOnMapReadyCallbackInvoker : global::Java.Lang.Object, IOnMapReadyCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/OnMapReadyCallback", typeof (IOnMapReadyCallbackInvoker));

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

		public static IOnMapReadyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnMapReadyCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.OnMapReadyCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnMapReadyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
#pragma warning disable 0169
		static Delegate GetOnMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Handler ()
		{
			if (cb_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ == null)
				cb_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_);
			return cb_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
		}

		static void n_OnMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMapReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
		public unsafe void OnMapReady (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap p0)
		{
			if (id_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ == IntPtr.Zero)
				id_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ = JNIEnv.GetMethodID (class_ref, "onMapReady", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_, __args);
		}

	}

}
