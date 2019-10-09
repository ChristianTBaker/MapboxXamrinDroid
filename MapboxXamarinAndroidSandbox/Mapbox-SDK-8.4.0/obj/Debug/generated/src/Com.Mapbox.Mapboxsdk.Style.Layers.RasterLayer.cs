using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/RasterLayer", DoNotGenerateAcw=true)]
	public partial class RasterLayer : global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/RasterLayer", typeof (RasterLayer));
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

		protected RasterLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/constructor[@name='RasterLayer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe RasterLayer (string layerId, string sourceId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_layerId = JNIEnv.NewString (layerId);
			IntPtr native_sourceId = JNIEnv.NewString (sourceId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_layerId);
				__args [1] = new JniArgumentValue (native_sourceId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_layerId);
				JNIEnv.DeleteLocalRef (native_sourceId);
			}
		}

		static Delegate cb_getRasterBrightnessMax;
#pragma warning disable 0169
		static Delegate GetGetRasterBrightnessMaxHandler ()
		{
			if (cb_getRasterBrightnessMax == null)
				cb_getRasterBrightnessMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterBrightnessMax);
			return cb_getRasterBrightnessMax;
		}

		static IntPtr n_GetRasterBrightnessMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterBrightnessMax);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterBrightnessMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterBrightnessMax' and count(parameter)=0]"
			[Register ("getRasterBrightnessMax", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetRasterBrightnessMaxHandler")]
			get {
				const string __id = "getRasterBrightnessMax.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterBrightnessMaxTransition;
#pragma warning disable 0169
		static Delegate GetGetRasterBrightnessMaxTransitionHandler ()
		{
			if (cb_getRasterBrightnessMaxTransition == null)
				cb_getRasterBrightnessMaxTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterBrightnessMaxTransition);
			return cb_getRasterBrightnessMaxTransition;
		}

		static IntPtr n_GetRasterBrightnessMaxTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterBrightnessMaxTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setRasterBrightnessMaxTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetRasterBrightnessMaxTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setRasterBrightnessMaxTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setRasterBrightnessMaxTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRasterBrightnessMaxTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setRasterBrightnessMaxTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetRasterBrightnessMaxTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.RasterBrightnessMaxTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions RasterBrightnessMaxTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterBrightnessMaxTransition' and count(parameter)=0]"
			[Register ("getRasterBrightnessMaxTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetRasterBrightnessMaxTransitionHandler")]
			get {
				const string __id = "getRasterBrightnessMaxTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='setRasterBrightnessMaxTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setRasterBrightnessMaxTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetRasterBrightnessMaxTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setRasterBrightnessMaxTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterBrightnessMin;
#pragma warning disable 0169
		static Delegate GetGetRasterBrightnessMinHandler ()
		{
			if (cb_getRasterBrightnessMin == null)
				cb_getRasterBrightnessMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterBrightnessMin);
			return cb_getRasterBrightnessMin;
		}

		static IntPtr n_GetRasterBrightnessMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterBrightnessMin);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterBrightnessMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterBrightnessMin' and count(parameter)=0]"
			[Register ("getRasterBrightnessMin", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetRasterBrightnessMinHandler")]
			get {
				const string __id = "getRasterBrightnessMin.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterBrightnessMinTransition;
#pragma warning disable 0169
		static Delegate GetGetRasterBrightnessMinTransitionHandler ()
		{
			if (cb_getRasterBrightnessMinTransition == null)
				cb_getRasterBrightnessMinTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterBrightnessMinTransition);
			return cb_getRasterBrightnessMinTransition;
		}

		static IntPtr n_GetRasterBrightnessMinTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterBrightnessMinTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setRasterBrightnessMinTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetRasterBrightnessMinTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setRasterBrightnessMinTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setRasterBrightnessMinTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRasterBrightnessMinTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setRasterBrightnessMinTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetRasterBrightnessMinTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.RasterBrightnessMinTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions RasterBrightnessMinTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterBrightnessMinTransition' and count(parameter)=0]"
			[Register ("getRasterBrightnessMinTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetRasterBrightnessMinTransitionHandler")]
			get {
				const string __id = "getRasterBrightnessMinTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='setRasterBrightnessMinTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setRasterBrightnessMinTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetRasterBrightnessMinTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setRasterBrightnessMinTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterContrast;
#pragma warning disable 0169
		static Delegate GetGetRasterContrastHandler ()
		{
			if (cb_getRasterContrast == null)
				cb_getRasterContrast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterContrast);
			return cb_getRasterContrast;
		}

		static IntPtr n_GetRasterContrast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterContrast);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterContrast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterContrast' and count(parameter)=0]"
			[Register ("getRasterContrast", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetRasterContrastHandler")]
			get {
				const string __id = "getRasterContrast.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterContrastTransition;
#pragma warning disable 0169
		static Delegate GetGetRasterContrastTransitionHandler ()
		{
			if (cb_getRasterContrastTransition == null)
				cb_getRasterContrastTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterContrastTransition);
			return cb_getRasterContrastTransition;
		}

		static IntPtr n_GetRasterContrastTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterContrastTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setRasterContrastTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetRasterContrastTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setRasterContrastTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setRasterContrastTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRasterContrastTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setRasterContrastTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetRasterContrastTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.RasterContrastTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions RasterContrastTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterContrastTransition' and count(parameter)=0]"
			[Register ("getRasterContrastTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetRasterContrastTransitionHandler")]
			get {
				const string __id = "getRasterContrastTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='setRasterContrastTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setRasterContrastTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetRasterContrastTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setRasterContrastTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterFadeDuration;
#pragma warning disable 0169
		static Delegate GetGetRasterFadeDurationHandler ()
		{
			if (cb_getRasterFadeDuration == null)
				cb_getRasterFadeDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterFadeDuration);
			return cb_getRasterFadeDuration;
		}

		static IntPtr n_GetRasterFadeDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterFadeDuration);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterFadeDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterFadeDuration' and count(parameter)=0]"
			[Register ("getRasterFadeDuration", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetRasterFadeDurationHandler")]
			get {
				const string __id = "getRasterFadeDuration.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterHueRotate;
#pragma warning disable 0169
		static Delegate GetGetRasterHueRotateHandler ()
		{
			if (cb_getRasterHueRotate == null)
				cb_getRasterHueRotate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterHueRotate);
			return cb_getRasterHueRotate;
		}

		static IntPtr n_GetRasterHueRotate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterHueRotate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterHueRotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterHueRotate' and count(parameter)=0]"
			[Register ("getRasterHueRotate", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetRasterHueRotateHandler")]
			get {
				const string __id = "getRasterHueRotate.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterHueRotateTransition;
#pragma warning disable 0169
		static Delegate GetGetRasterHueRotateTransitionHandler ()
		{
			if (cb_getRasterHueRotateTransition == null)
				cb_getRasterHueRotateTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterHueRotateTransition);
			return cb_getRasterHueRotateTransition;
		}

		static IntPtr n_GetRasterHueRotateTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterHueRotateTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setRasterHueRotateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetRasterHueRotateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setRasterHueRotateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setRasterHueRotateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRasterHueRotateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setRasterHueRotateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetRasterHueRotateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.RasterHueRotateTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions RasterHueRotateTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterHueRotateTransition' and count(parameter)=0]"
			[Register ("getRasterHueRotateTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetRasterHueRotateTransitionHandler")]
			get {
				const string __id = "getRasterHueRotateTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='setRasterHueRotateTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setRasterHueRotateTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetRasterHueRotateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setRasterHueRotateTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterOpacity;
#pragma warning disable 0169
		static Delegate GetGetRasterOpacityHandler ()
		{
			if (cb_getRasterOpacity == null)
				cb_getRasterOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterOpacity);
			return cb_getRasterOpacity;
		}

		static IntPtr n_GetRasterOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterOpacity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterOpacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterOpacity' and count(parameter)=0]"
			[Register ("getRasterOpacity", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetRasterOpacityHandler")]
			get {
				const string __id = "getRasterOpacity.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterOpacityTransition;
#pragma warning disable 0169
		static Delegate GetGetRasterOpacityTransitionHandler ()
		{
			if (cb_getRasterOpacityTransition == null)
				cb_getRasterOpacityTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterOpacityTransition);
			return cb_getRasterOpacityTransition;
		}

		static IntPtr n_GetRasterOpacityTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterOpacityTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setRasterOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetRasterOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setRasterOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setRasterOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRasterOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setRasterOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetRasterOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.RasterOpacityTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions RasterOpacityTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterOpacityTransition' and count(parameter)=0]"
			[Register ("getRasterOpacityTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetRasterOpacityTransitionHandler")]
			get {
				const string __id = "getRasterOpacityTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='setRasterOpacityTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setRasterOpacityTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetRasterOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setRasterOpacityTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterResampling;
#pragma warning disable 0169
		static Delegate GetGetRasterResamplingHandler ()
		{
			if (cb_getRasterResampling == null)
				cb_getRasterResampling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterResampling);
			return cb_getRasterResampling;
		}

		static IntPtr n_GetRasterResampling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterResampling);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterResampling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterResampling' and count(parameter)=0]"
			[Register ("getRasterResampling", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetRasterResamplingHandler")]
			get {
				const string __id = "getRasterResampling.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterSaturation;
#pragma warning disable 0169
		static Delegate GetGetRasterSaturationHandler ()
		{
			if (cb_getRasterSaturation == null)
				cb_getRasterSaturation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterSaturation);
			return cb_getRasterSaturation;
		}

		static IntPtr n_GetRasterSaturation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterSaturation);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterSaturation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterSaturation' and count(parameter)=0]"
			[Register ("getRasterSaturation", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetRasterSaturationHandler")]
			get {
				const string __id = "getRasterSaturation.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRasterSaturationTransition;
#pragma warning disable 0169
		static Delegate GetGetRasterSaturationTransitionHandler ()
		{
			if (cb_getRasterSaturationTransition == null)
				cb_getRasterSaturationTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRasterSaturationTransition);
			return cb_getRasterSaturationTransition;
		}

		static IntPtr n_GetRasterSaturationTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RasterSaturationTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setRasterSaturationTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetRasterSaturationTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setRasterSaturationTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setRasterSaturationTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRasterSaturationTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setRasterSaturationTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetRasterSaturationTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.RasterSaturationTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions RasterSaturationTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getRasterSaturationTransition' and count(parameter)=0]"
			[Register ("getRasterSaturationTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetRasterSaturationTransitionHandler")]
			get {
				const string __id = "getRasterSaturationTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='setRasterSaturationTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setRasterSaturationTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetRasterSaturationTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setRasterSaturationTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceId;
#pragma warning disable 0169
		static Delegate GetGetSourceIdHandler ()
		{
			if (cb_getSourceId == null)
				cb_getSourceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourceId);
			return cb_getSourceId;
		}

		static IntPtr n_GetSourceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourceId);
		}
#pragma warning restore 0169

		public virtual unsafe string SourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='getSourceId' and count(parameter)=0]"
			[Register ("getSourceId", "()Ljava/lang/String;", "GetGetSourceIdHandler")]
			get {
				const string __id = "getSourceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_initialize_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_initialize_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_initialize_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_lang_String_Ljava_lang_String_);
			return cb_initialize_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Initialize_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("initialize", "(Ljava/lang/String;Ljava/lang/String;)V", "GetInitialize_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void Initialize (string p0, string p1)
		{
			const string __id = "initialize.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setSourceLayer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSourceLayer_Ljava_lang_String_Handler ()
		{
			if (cb_setSourceLayer_Ljava_lang_String_ == null)
				cb_setSourceLayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSourceLayer_Ljava_lang_String_);
			return cb_setSourceLayer_Ljava_lang_String_;
		}

		static void n_SetSourceLayer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceLayer)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			__this.SetSourceLayer (sourceLayer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='setSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSourceLayer", "(Ljava/lang/String;)V", "GetSetSourceLayer_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSourceLayer (string sourceLayer)
		{
			const string __id = "setSourceLayer.(Ljava/lang/String;)V";
			IntPtr native_sourceLayer = JNIEnv.NewString (sourceLayer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourceLayer);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceLayer);
			}
		}

		static Delegate cb_withProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_;
#pragma warning disable 0169
		static Delegate GetWithProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_Handler ()
		{
			if (cb_withProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_ == null)
				cb_withProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_);
			return cb_withProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_;
		}

		static IntPtr n_WithProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_properties)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties = (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[]) JNIEnv.GetArray (native_properties, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithProperties (properties));
			if (properties != null)
				JNIEnv.CopyArray (properties, native_properties);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='withProperties' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.PropertyValue&lt;?&gt;...']]"
		[Register ("withProperties", "([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/RasterLayer;", "GetWithProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer WithProperties (params global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties)
		{
			const string __id = "withProperties.([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/RasterLayer;";
			IntPtr native_properties = JNIEnv.NewArray (properties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_properties);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (properties != null) {
					JNIEnv.CopyArray (native_properties, properties);
					JNIEnv.DeleteLocalRef (native_properties);
				}
			}
		}

		static Delegate cb_withSourceLayer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithSourceLayer_Ljava_lang_String_Handler ()
		{
			if (cb_withSourceLayer_Ljava_lang_String_ == null)
				cb_withSourceLayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSourceLayer_Ljava_lang_String_);
			return cb_withSourceLayer_Ljava_lang_String_;
		}

		static IntPtr n_WithSourceLayer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceLayer)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSourceLayer (sourceLayer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='RasterLayer']/method[@name='withSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSourceLayer", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/RasterLayer;", "GetWithSourceLayer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer WithSourceLayer (string sourceLayer)
		{
			const string __id = "withSourceLayer.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/RasterLayer;";
			IntPtr native_sourceLayer = JNIEnv.NewString (sourceLayer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourceLayer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.RasterLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceLayer);
			}
		}

	}
}
