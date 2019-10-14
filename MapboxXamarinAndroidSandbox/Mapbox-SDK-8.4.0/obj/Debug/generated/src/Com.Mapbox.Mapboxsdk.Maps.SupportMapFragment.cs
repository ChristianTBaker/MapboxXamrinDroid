using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='SupportMapFragment']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/SupportMapFragment", DoNotGenerateAcw=true)]
	public partial class SupportMapFragment : global::Android.Support.V4.App.Fragment, global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/SupportMapFragment", typeof (SupportMapFragment));
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

		protected SupportMapFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='SupportMapFragment']/constructor[@name='SupportMapFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SupportMapFragment ()
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

		static Delegate cb_getMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_;
#pragma warning disable 0169
		static Delegate GetGetMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_Handler ()
		{
			if (cb_getMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_ == null)
				cb_getMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_);
			return cb_getMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_;
		}

		static void n_GetMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onMapReadyCallback)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.SupportMapFragment __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.SupportMapFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback onMapReadyCallback = (global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback> (native_onMapReadyCallback, JniHandleOwnership.DoNotTransfer);
			__this.GetMapAsync (onMapReadyCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='SupportMapFragment']/method[@name='getMapAsync' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.OnMapReadyCallback']]"
		[Register ("getMapAsync", "(Lcom/mapbox/mapboxsdk/maps/OnMapReadyCallback;)V", "GetGetMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_Handler")]
		public virtual unsafe void GetMapAsync (global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback onMapReadyCallback)
		{
			const string __id = "getMapAsync.(Lcom/mapbox/mapboxsdk/maps/OnMapReadyCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onMapReadyCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onMapReadyCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='SupportMapFragment']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/mapbox/mapboxsdk/maps/SupportMapFragment;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.SupportMapFragment NewInstance ()
		{
			const string __id = "newInstance.()Lcom/mapbox/mapboxsdk/maps/SupportMapFragment;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.SupportMapFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='SupportMapFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMapOptions']]"
		[Register ("newInstance", "(Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)Lcom/mapbox/mapboxsdk/maps/SupportMapFragment;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.SupportMapFragment NewInstance (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions mapboxMapOptions)
		{
			const string __id = "newInstance.(Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)Lcom/mapbox/mapboxsdk/maps/SupportMapFragment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapboxMapOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMapOptions).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.SupportMapFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
#pragma warning disable 0169
		static Delegate GetOnMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Handler ()
		{
			if (cb_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ == null)
				cb_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_);
			return cb_onMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
		}

		static void n_OnMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapboxMap)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.SupportMapFragment __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.SupportMapFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap> (native_mapboxMap, JniHandleOwnership.DoNotTransfer);
			__this.OnMapReady (mapboxMap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='SupportMapFragment']/method[@name='onMapReady' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
		[Register ("onMapReady", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V", "GetOnMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Handler")]
		public virtual unsafe void OnMapReady (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap)
		{
			const string __id = "onMapReady.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
