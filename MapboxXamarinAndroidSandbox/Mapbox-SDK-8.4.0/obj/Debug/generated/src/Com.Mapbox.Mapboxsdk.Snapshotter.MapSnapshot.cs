using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Snapshotter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshot']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/snapshotter/MapSnapshot", DoNotGenerateAcw=true)]
	public partial class MapSnapshot : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/snapshotter/MapSnapshot", typeof (MapSnapshot));
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

		protected MapSnapshot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBitmap;
#pragma warning disable 0169
		static Delegate GetGetBitmapHandler ()
		{
			if (cb_getBitmap == null)
				cb_getBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmap);
			return cb_getBitmap;
		}

		static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshot']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				const string __id = "getBitmap.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAttributions;
#pragma warning disable 0169
		static Delegate GetGetAttributionsHandler ()
		{
			if (cb_getAttributions == null)
				cb_getAttributions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributions);
			return cb_getAttributions;
		}

		static IntPtr n_GetAttributions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAttributions ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshot']/method[@name='getAttributions' and count(parameter)=0]"
		[Register ("getAttributions", "()[Ljava/lang/String;", "GetGetAttributionsHandler")]
		protected virtual unsafe string[] GetAttributions ()
		{
			const string __id = "getAttributions.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_latLngForPixel_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetLatLngForPixel_Landroid_graphics_PointF_Handler ()
		{
			if (cb_latLngForPixel_Landroid_graphics_PointF_ == null)
				cb_latLngForPixel_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LatLngForPixel_Landroid_graphics_PointF_);
			return cb_latLngForPixel_Landroid_graphics_PointF_;
		}

		static IntPtr n_LatLngForPixel_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LatLngForPixel (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshot']/method[@name='latLngForPixel' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
		[Register ("latLngForPixel", "(Landroid/graphics/PointF;)Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetLatLngForPixel_Landroid_graphics_PointF_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng LatLngForPixel (global::Android.Graphics.PointF p0)
		{
			const string __id = "latLngForPixel.(Landroid/graphics/PointF;)Lcom/mapbox/mapboxsdk/geometry/LatLng;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pixelForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetPixelForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_pixelForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_pixelForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PixelForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_pixelForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static IntPtr n_PixelForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PixelForLatLng (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshot']/method[@name='pixelForLatLng' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("pixelForLatLng", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Landroid/graphics/PointF;", "GetPixelForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe global::Android.Graphics.PointF PixelForLatLng (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0)
		{
			const string __id = "pixelForLatLng.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Landroid/graphics/PointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
