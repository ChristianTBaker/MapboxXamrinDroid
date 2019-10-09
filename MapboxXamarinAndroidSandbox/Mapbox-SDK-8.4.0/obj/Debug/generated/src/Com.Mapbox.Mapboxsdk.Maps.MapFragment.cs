using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapFragment']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapFragment", DoNotGenerateAcw=true)]
	public sealed partial class MapFragment : global::Android.App.Fragment, global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapFragment.OnMapViewReadyCallback']"
		[Register ("com/mapbox/mapboxsdk/maps/MapFragment$OnMapViewReadyCallback", "", "Com.Mapbox.Mapboxsdk.Maps.MapFragment/IOnMapViewReadyCallbackInvoker")]
		public partial interface IOnMapViewReadyCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapFragment.OnMapViewReadyCallback']/method[@name='onMapViewReady' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView']]"
			[Register ("onMapViewReady", "(Lcom/mapbox/mapboxsdk/maps/MapView;)V", "GetOnMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_Handler:Com.Mapbox.Mapboxsdk.Maps.MapFragment/IOnMapViewReadyCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnMapViewReady (global::Com.Mapbox.Mapboxsdk.Maps.MapView p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapFragment$OnMapViewReadyCallback", DoNotGenerateAcw=true)]
		internal class IOnMapViewReadyCallbackInvoker : global::Java.Lang.Object, IOnMapViewReadyCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapFragment$OnMapViewReadyCallback", typeof (IOnMapViewReadyCallbackInvoker));

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

			public static IOnMapViewReadyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapViewReadyCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapFragment.OnMapViewReadyCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapViewReadyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_;
#pragma warning disable 0169
			static Delegate GetOnMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_Handler ()
			{
				if (cb_onMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_ == null)
					cb_onMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_);
				return cb_onMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_;
			}

			static void n_OnMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapFragment.IOnMapViewReadyCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapFragment.IOnMapViewReadyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Maps.MapView p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapViewReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_;
			public unsafe void OnMapViewReady (global::Com.Mapbox.Mapboxsdk.Maps.MapView p0)
			{
				if (id_onMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_ == IntPtr.Zero)
					id_onMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_ = JNIEnv.GetMethodID (class_ref, "onMapViewReady", "(Lcom/mapbox/mapboxsdk/maps/MapView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapViewReady_Lcom_mapbox_mapboxsdk_maps_MapView_, __args);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/MapFragment", typeof (MapFragment));
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

		internal MapFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapFragment']/constructor[@name='MapFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapFragment ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapFragment']/method[@name='getMapAsync' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.OnMapReadyCallback']]"
		[Register ("getMapAsync", "(Lcom/mapbox/mapboxsdk/maps/OnMapReadyCallback;)V", "")]
		public unsafe void GetMapAsync (global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback onMapReadyCallback)
		{
			const string __id = "getMapAsync.(Lcom/mapbox/mapboxsdk/maps/OnMapReadyCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onMapReadyCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onMapReadyCallback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapFragment']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/mapbox/mapboxsdk/maps/MapFragment;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapFragment NewInstance ()
		{
			const string __id = "newInstance.()Lcom/mapbox/mapboxsdk/maps/MapFragment;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMapOptions']]"
		[Register ("newInstance", "(Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)Lcom/mapbox/mapboxsdk/maps/MapFragment;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapFragment NewInstance (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions mapboxMapOptions)
		{
			const string __id = "newInstance.(Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)Lcom/mapbox/mapboxsdk/maps/MapFragment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapboxMapOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMapOptions).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapFragment']/method[@name='onMapReady' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
		[Register ("onMapReady", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V", "")]
		public unsafe void OnMapReady (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap)
		{
			const string __id = "onMapReady.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
