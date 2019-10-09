using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BasePointCollection']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/BasePointCollection", DoNotGenerateAcw=true)]
	public abstract partial class BasePointCollection : global::Com.Mapbox.Mapboxsdk.Annotations.Annotation {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/BasePointCollection", typeof (BasePointCollection));
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

		protected BasePointCollection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BasePointCollection']/constructor[@name='BasePointCollection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe BasePointCollection ()
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

		static Delegate cb_getAlpha;
#pragma warning disable 0169
		static Delegate GetGetAlphaHandler ()
		{
			if (cb_getAlpha == null)
				cb_getAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAlpha);
			return cb_getAlpha;
		}

		static float n_GetAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Alpha;
		}
#pragma warning restore 0169

		static Delegate cb_setAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetAlpha_FHandler ()
		{
			if (cb_setAlpha_F == null)
				cb_setAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAlpha_F);
			return cb_setAlpha_F;
		}

		static void n_SetAlpha_F (IntPtr jnienv, IntPtr native__this, float alpha)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alpha = alpha;
		}
#pragma warning restore 0169

		public virtual unsafe float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BasePointCollection']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				const string __id = "getAlpha.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BasePointCollection']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
			set {
				const string __id = "setAlpha.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPoints;
#pragma warning disable 0169
		static Delegate GetGetPointsHandler ()
		{
			if (cb_getPoints == null)
				cb_getPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoints);
			return cb_getPoints;
		}

		static IntPtr n_GetPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>.ToLocalJniHandle (__this.Points);
		}
#pragma warning restore 0169

		static Delegate cb_setPoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPoints_Ljava_util_List_Handler ()
		{
			if (cb_setPoints_Ljava_util_List_ == null)
				cb_setPoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoints_Ljava_util_List_);
			return cb_setPoints_Ljava_util_List_;
		}

		static void n_SetPoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_points)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var points = global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>.FromJniHandle (native_points, JniHandleOwnership.DoNotTransfer);
			__this.Points = points;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BasePointCollection']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				const string __id = "getPoints.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BasePointCollection']/method[@name='setPoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.mapboxsdk.geometry.LatLng&gt;']]"
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler")]
			set {
				const string __id = "setPoints.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addPoint_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetAddPoint_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_addPoint_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_addPoint_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPoint_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_addPoint_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static void n_AddPoint_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_point)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng point = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_point, JniHandleOwnership.DoNotTransfer);
			__this.AddPoint (point);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BasePointCollection']/method[@name='addPoint' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("addPoint", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)V", "GetAddPoint_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe void AddPoint (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng point)
		{
			const string __id = "addPoint.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((point == null) ? IntPtr.Zero : ((global::Java.Lang.Object) point).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/BasePointCollection", DoNotGenerateAcw=true)]
	internal partial class BasePointCollectionInvoker : BasePointCollection {

		public BasePointCollectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/annotations/BasePointCollection", typeof (BasePointCollectionInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public override unsafe global::System.Int32 CompareTo (global::Java.Lang.Object o)
		{
			const string __id = "compareTo.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

}
