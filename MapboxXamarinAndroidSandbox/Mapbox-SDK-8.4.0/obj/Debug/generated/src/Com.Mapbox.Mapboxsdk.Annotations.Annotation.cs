using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/Annotation", DoNotGenerateAcw=true)]
	public abstract partial class Annotation : global::Java.Lang.Object, global::Java.Lang.IComparable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/field[@name='mapView']"
		[Register ("mapView")]
		protected global::Com.Mapbox.Mapboxsdk.Maps.MapView _mapView {
			get {
				const string __id = "mapView.Lcom/mapbox/mapboxsdk/maps/MapView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mapView.Lcom/mapbox/mapboxsdk/maps/MapView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/field[@name='mapboxMap']"
		[Register ("mapboxMap")]
		protected global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap _mapboxMap {
			get {
				const string __id = "mapboxMap.Lcom/mapbox/mapboxsdk/maps/MapboxMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mapboxMap.Lcom/mapbox/mapboxsdk/maps/MapboxMap;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/Annotation", typeof (Annotation));
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

		protected Annotation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/constructor[@name='Annotation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Annotation ()
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

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetId);
			return cb_getId;
		}

		static long n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static Delegate cb_setId_J;
#pragma warning disable 0169
		static Delegate GetSetId_JHandler ()
		{
			if (cb_setId_J == null)
				cb_setId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetId_J);
			return cb_setId_J;
		}

		static void n_SetId_J (IntPtr jnienv, IntPtr native__this, long id)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = id;
		}
#pragma warning restore 0169

		public virtual unsafe long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")]
			get {
				const string __id = "getId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setId", "(J)V", "GetSetId_JHandler")]
			set {
				const string __id = "setId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMapView;
#pragma warning disable 0169
		static Delegate GetGetMapViewHandler ()
		{
			if (cb_getMapView == null)
				cb_getMapView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapView);
			return cb_getMapView;
		}

		static IntPtr n_GetMapView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapView);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapView MapView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/method[@name='getMapView' and count(parameter)=0]"
			[Register ("getMapView", "()Lcom/mapbox/mapboxsdk/maps/MapView;", "GetGetMapViewHandler")]
			get {
				const string __id = "getMapView.()Lcom/mapbox/mapboxsdk/maps/MapView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMapboxMap;
#pragma warning disable 0169
		static Delegate GetGetMapboxMapHandler ()
		{
			if (cb_getMapboxMap == null)
				cb_getMapboxMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapboxMap);
			return cb_getMapboxMap;
		}

		static IntPtr n_GetMapboxMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapboxMap);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap MapboxMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/method[@name='getMapboxMap' and count(parameter)=0]"
			[Register ("getMapboxMap", "()Lcom/mapbox/mapboxsdk/maps/MapboxMap;", "GetGetMapboxMapHandler")]
			get {
				const string __id = "getMapboxMap.()Lcom/mapbox/mapboxsdk/maps/MapboxMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_mapbox_mapboxsdk_annotations_Annotation_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_mapbox_mapboxsdk_annotations_Annotation_Handler ()
		{
			if (cb_compareTo_Lcom_mapbox_mapboxsdk_annotations_Annotation_ == null)
				cb_compareTo_Lcom_mapbox_mapboxsdk_annotations_Annotation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_mapbox_mapboxsdk_annotations_Annotation_);
			return cb_compareTo_Lcom_mapbox_mapboxsdk_annotations_Annotation_;
		}

		static int n_CompareTo_Lcom_mapbox_mapboxsdk_annotations_Annotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotation)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation annotation = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (native_annotation, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (annotation);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Annotation']]"
		[Register ("compareTo", "(Lcom/mapbox/mapboxsdk/annotations/Annotation;)I", "GetCompareTo_Lcom_mapbox_mapboxsdk_annotations_Annotation_Handler")]
		public virtual unsafe int CompareTo (global::Com.Mapbox.Mapboxsdk.Annotations.Annotation annotation)
		{
			const string __id = "compareTo.(Lcom/mapbox/mapboxsdk/annotations/Annotation;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((annotation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotation).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual unsafe void Remove ()
		{
			const string __id = "remove.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setMapView_Lcom_mapbox_mapboxsdk_maps_MapView_;
#pragma warning disable 0169
		static Delegate GetSetMapView_Lcom_mapbox_mapboxsdk_maps_MapView_Handler ()
		{
			if (cb_setMapView_Lcom_mapbox_mapboxsdk_maps_MapView_ == null)
				cb_setMapView_Lcom_mapbox_mapboxsdk_maps_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapView_Lcom_mapbox_mapboxsdk_maps_MapView_);
			return cb_setMapView_Lcom_mapbox_mapboxsdk_maps_MapView_;
		}

		static void n_SetMapView_Lcom_mapbox_mapboxsdk_maps_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapView)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView mapView = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			__this.SetMapView (mapView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/method[@name='setMapView' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView']]"
		[Register ("setMapView", "(Lcom/mapbox/mapboxsdk/maps/MapView;)V", "GetSetMapView_Lcom_mapbox_mapboxsdk_maps_MapView_Handler")]
		public virtual unsafe void SetMapView (global::Com.Mapbox.Mapboxsdk.Maps.MapView mapView)
		{
			const string __id = "setMapView.(Lcom/mapbox/mapboxsdk/maps/MapView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMapboxMap_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
#pragma warning disable 0169
		static Delegate GetSetMapboxMap_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Handler ()
		{
			if (cb_setMapboxMap_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ == null)
				cb_setMapboxMap_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapboxMap_Lcom_mapbox_mapboxsdk_maps_MapboxMap_);
			return cb_setMapboxMap_Lcom_mapbox_mapboxsdk_maps_MapboxMap_;
		}

		static void n_SetMapboxMap_Lcom_mapbox_mapboxsdk_maps_MapboxMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapboxMap)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap> (native_mapboxMap, JniHandleOwnership.DoNotTransfer);
			__this.SetMapboxMap (mapboxMap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Annotation']/method[@name='setMapboxMap' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
		[Register ("setMapboxMap", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V", "GetSetMapboxMap_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Handler")]
		public virtual unsafe void SetMapboxMap (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap)
		{
			const string __id = "setMapboxMap.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (o);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public abstract global::System.Int32 CompareTo (global::Java.Lang.Object o);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/Annotation", DoNotGenerateAcw=true)]
	internal partial class AnnotationInvoker : Annotation {

		public AnnotationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/annotations/Annotation", typeof (AnnotationInvoker));

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
