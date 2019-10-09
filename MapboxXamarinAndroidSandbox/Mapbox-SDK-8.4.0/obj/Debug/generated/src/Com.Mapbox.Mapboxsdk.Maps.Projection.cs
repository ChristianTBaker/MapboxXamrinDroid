using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Projection", DoNotGenerateAcw=true)]
	public partial class Projection : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/Projection", typeof (Projection));
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

		protected Projection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getVisibleRegion;
#pragma warning disable 0169
		static Delegate GetGetVisibleRegionHandler ()
		{
			if (cb_getVisibleRegion == null)
				cb_getVisibleRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisibleRegion);
			return cb_getVisibleRegion;
		}

		static IntPtr n_GetVisibleRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisibleRegion);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.VisibleRegion VisibleRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']/method[@name='getVisibleRegion' and count(parameter)=0]"
			[Register ("getVisibleRegion", "()Lcom/mapbox/mapboxsdk/geometry/VisibleRegion;", "GetGetVisibleRegionHandler")]
			get {
				const string __id = "getVisibleRegion.()Lcom/mapbox/mapboxsdk/geometry/VisibleRegion;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.VisibleRegion> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_calculateZoom_F;
#pragma warning disable 0169
		static Delegate GetCalculateZoom_FHandler ()
		{
			if (cb_calculateZoom_F == null)
				cb_calculateZoom_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, double>) n_CalculateZoom_F);
			return cb_calculateZoom_F;
		}

		static double n_CalculateZoom_F (IntPtr jnienv, IntPtr native__this, float minScale)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculateZoom (minScale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']/method[@name='calculateZoom' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("calculateZoom", "(F)D", "GetCalculateZoom_FHandler")]
		public virtual unsafe double CalculateZoom (float minScale)
		{
			const string __id = "calculateZoom.(F)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minScale);
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_fromScreenLocation_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetFromScreenLocation_Landroid_graphics_PointF_Handler ()
		{
			if (cb_fromScreenLocation_Landroid_graphics_PointF_ == null)
				cb_fromScreenLocation_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromScreenLocation_Landroid_graphics_PointF_);
			return cb_fromScreenLocation_Landroid_graphics_PointF_;
		}

		static IntPtr n_FromScreenLocation_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_point)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF point = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_point, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromScreenLocation (point));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']/method[@name='fromScreenLocation' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
		[Register ("fromScreenLocation", "(Landroid/graphics/PointF;)Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetFromScreenLocation_Landroid_graphics_PointF_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng FromScreenLocation (global::Android.Graphics.PointF point)
		{
			const string __id = "fromScreenLocation.(Landroid/graphics/PointF;)Lcom/mapbox/mapboxsdk/geometry/LatLng;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((point == null) ? IntPtr.Zero : ((global::Java.Lang.Object) point).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLatLngForProjectedMeters_Lcom_mapbox_mapboxsdk_geometry_ProjectedMeters_;
#pragma warning disable 0169
		static Delegate GetGetLatLngForProjectedMeters_Lcom_mapbox_mapboxsdk_geometry_ProjectedMeters_Handler ()
		{
			if (cb_getLatLngForProjectedMeters_Lcom_mapbox_mapboxsdk_geometry_ProjectedMeters_ == null)
				cb_getLatLngForProjectedMeters_Lcom_mapbox_mapboxsdk_geometry_ProjectedMeters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatLngForProjectedMeters_Lcom_mapbox_mapboxsdk_geometry_ProjectedMeters_);
			return cb_getLatLngForProjectedMeters_Lcom_mapbox_mapboxsdk_geometry_ProjectedMeters_;
		}

		static IntPtr n_GetLatLngForProjectedMeters_Lcom_mapbox_mapboxsdk_geometry_ProjectedMeters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_projectedMeters)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters projectedMeters = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters> (native_projectedMeters, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLatLngForProjectedMeters (projectedMeters));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']/method[@name='getLatLngForProjectedMeters' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.ProjectedMeters']]"
		[Register ("getLatLngForProjectedMeters", "(Lcom/mapbox/mapboxsdk/geometry/ProjectedMeters;)Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetLatLngForProjectedMeters_Lcom_mapbox_mapboxsdk_geometry_ProjectedMeters_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng GetLatLngForProjectedMeters (global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters projectedMeters)
		{
			const string __id = "getLatLngForProjectedMeters.(Lcom/mapbox/mapboxsdk/geometry/ProjectedMeters;)Lcom/mapbox/mapboxsdk/geometry/LatLng;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((projectedMeters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) projectedMeters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMetersPerPixelAtLatitude_D;
#pragma warning disable 0169
		static Delegate GetGetMetersPerPixelAtLatitude_DHandler ()
		{
			if (cb_getMetersPerPixelAtLatitude_D == null)
				cb_getMetersPerPixelAtLatitude_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double>) n_GetMetersPerPixelAtLatitude_D);
			return cb_getMetersPerPixelAtLatitude_D;
		}

		static double n_GetMetersPerPixelAtLatitude_D (IntPtr jnienv, IntPtr native__this, double latitude)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMetersPerPixelAtLatitude (latitude);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']/method[@name='getMetersPerPixelAtLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getMetersPerPixelAtLatitude", "(D)D", "GetGetMetersPerPixelAtLatitude_DHandler")]
		public virtual unsafe double GetMetersPerPixelAtLatitude (double latitude)
		{
			const string __id = "getMetersPerPixelAtLatitude.(D)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (latitude);
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getProjectedMetersForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetGetProjectedMetersForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_getProjectedMetersForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_getProjectedMetersForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProjectedMetersForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_getProjectedMetersForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static IntPtr n_GetProjectedMetersForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_latLng)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_latLng, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProjectedMetersForLatLng (latLng));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']/method[@name='getProjectedMetersForLatLng' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("getProjectedMetersForLatLng", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/geometry/ProjectedMeters;", "GetGetProjectedMetersForLatLng_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters GetProjectedMetersForLatLng (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng)
		{
			const string __id = "getProjectedMetersForLatLng.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/geometry/ProjectedMeters;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((latLng == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLng).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getVisibleRegion_Z;
#pragma warning disable 0169
		static Delegate GetGetVisibleRegion_ZHandler ()
		{
			if (cb_getVisibleRegion_Z == null)
				cb_getVisibleRegion_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_GetVisibleRegion_Z);
			return cb_getVisibleRegion_Z;
		}

		static IntPtr n_GetVisibleRegion_Z (IntPtr jnienv, IntPtr native__this, bool ignorePadding)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetVisibleRegion (ignorePadding));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']/method[@name='getVisibleRegion' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getVisibleRegion", "(Z)Lcom/mapbox/mapboxsdk/geometry/VisibleRegion;", "GetGetVisibleRegion_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.VisibleRegion GetVisibleRegion (bool ignorePadding)
		{
			const string __id = "getVisibleRegion.(Z)Lcom/mapbox/mapboxsdk/geometry/VisibleRegion;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ignorePadding);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.VisibleRegion> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_invalidateContentPadding;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetInvalidateContentPaddingHandler ()
		{
			if (cb_invalidateContentPadding == null)
				cb_invalidateContentPadding = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InvalidateContentPadding);
			return cb_invalidateContentPadding;
		}

		[Obsolete]
		static void n_InvalidateContentPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateContentPadding ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']/method[@name='invalidateContentPadding' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("invalidateContentPadding", "()V", "GetInvalidateContentPaddingHandler")]
		public virtual unsafe void InvalidateContentPadding ()
		{
			const string __id = "invalidateContentPadding.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toScreenLocation_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetToScreenLocation_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_toScreenLocation_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_toScreenLocation_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToScreenLocation_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_toScreenLocation_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static IntPtr n_ToScreenLocation_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng location = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_location, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToScreenLocation (location));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Projection']/method[@name='toScreenLocation' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("toScreenLocation", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Landroid/graphics/PointF;", "GetToScreenLocation_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe global::Android.Graphics.PointF ToScreenLocation (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng location)
		{
			const string __id = "toScreenLocation.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Landroid/graphics/PointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((location == null) ? IntPtr.Zero : ((global::Java.Lang.Object) location).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
