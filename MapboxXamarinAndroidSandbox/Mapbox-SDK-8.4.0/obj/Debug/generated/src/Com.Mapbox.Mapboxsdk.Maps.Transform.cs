using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Transform']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Transform", DoNotGenerateAcw=true)]
	public sealed partial class Transform : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/Transform", typeof (Transform));
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

		internal Transform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition CameraPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Transform']/method[@name='getCameraPosition' and count(parameter)=0]"
			[Register ("getCameraPosition", "()Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "GetGetCameraPositionHandler")]
			get {
				const string __id = "getCameraPosition.()Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Transform']/method[@name='animateCamera' and count(parameter)=4 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap'] and parameter[2][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[3][@type='int'] and parameter[4][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("animateCamera", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;Lcom/mapbox/mapboxsdk/camera/CameraUpdate;ILcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void AnimateCamera (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap, global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, int durationMs, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "animateCamera.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;Lcom/mapbox/mapboxsdk/camera/CameraUpdate;ILcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
				__args [1] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [2] = new JniArgumentValue (durationMs);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Transform']/method[@name='moveCamera' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap'] and parameter[2][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[3][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("moveCamera", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;Lcom/mapbox/mapboxsdk/camera/CameraUpdate;Lcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void MoveCamera (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap, global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "moveCamera.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;Lcom/mapbox/mapboxsdk/camera/CameraUpdate;Lcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
				__args [1] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Transform']/method[@name='onCameraDidChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onCameraDidChange", "(Z)V", "")]
		public unsafe void OnCameraDidChange (bool animated)
		{
			const string __id = "onCameraDidChange.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (animated);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
