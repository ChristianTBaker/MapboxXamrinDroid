using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/CircleLayer", DoNotGenerateAcw=true)]
	public partial class CircleLayer : global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/CircleLayer", typeof (CircleLayer));
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

		protected CircleLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/constructor[@name='CircleLayer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CircleLayer (string layerId, string sourceId)
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

		static Delegate cb_getCircleBlur;
#pragma warning disable 0169
		static Delegate GetGetCircleBlurHandler ()
		{
			if (cb_getCircleBlur == null)
				cb_getCircleBlur = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleBlur);
			return cb_getCircleBlur;
		}

		static IntPtr n_GetCircleBlur (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleBlur);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleBlur {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleBlur' and count(parameter)=0]"
			[Register ("getCircleBlur", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCircleBlurHandler")]
			get {
				const string __id = "getCircleBlur.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleBlurTransition;
#pragma warning disable 0169
		static Delegate GetGetCircleBlurTransitionHandler ()
		{
			if (cb_getCircleBlurTransition == null)
				cb_getCircleBlurTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleBlurTransition);
			return cb_getCircleBlurTransition;
		}

		static IntPtr n_GetCircleBlurTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleBlurTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setCircleBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetCircleBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setCircleBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setCircleBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setCircleBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetCircleBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.CircleBlurTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions CircleBlurTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleBlurTransition' and count(parameter)=0]"
			[Register ("getCircleBlurTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetCircleBlurTransitionHandler")]
			get {
				const string __id = "getCircleBlurTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setCircleBlurTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setCircleBlurTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetCircleBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setCircleBlurTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleColor;
#pragma warning disable 0169
		static Delegate GetGetCircleColorHandler ()
		{
			if (cb_getCircleColor == null)
				cb_getCircleColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleColor);
			return cb_getCircleColor;
		}

		static IntPtr n_GetCircleColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleColor' and count(parameter)=0]"
			[Register ("getCircleColor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCircleColorHandler")]
			get {
				const string __id = "getCircleColor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleColorAsInt;
#pragma warning disable 0169
		static Delegate GetGetCircleColorAsIntHandler ()
		{
			if (cb_getCircleColorAsInt == null)
				cb_getCircleColorAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCircleColorAsInt);
			return cb_getCircleColorAsInt;
		}

		static int n_GetCircleColorAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleColorAsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int CircleColorAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleColorAsInt' and count(parameter)=0]"
			[Register ("getCircleColorAsInt", "()I", "GetGetCircleColorAsIntHandler")]
			get {
				const string __id = "getCircleColorAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCircleColorTransition;
#pragma warning disable 0169
		static Delegate GetGetCircleColorTransitionHandler ()
		{
			if (cb_getCircleColorTransition == null)
				cb_getCircleColorTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleColorTransition);
			return cb_getCircleColorTransition;
		}

		static IntPtr n_GetCircleColorTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleColorTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setCircleColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetCircleColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setCircleColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setCircleColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setCircleColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetCircleColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.CircleColorTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions CircleColorTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleColorTransition' and count(parameter)=0]"
			[Register ("getCircleColorTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetCircleColorTransitionHandler")]
			get {
				const string __id = "getCircleColorTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setCircleColorTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setCircleColorTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetCircleColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setCircleColorTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleOpacity;
#pragma warning disable 0169
		static Delegate GetGetCircleOpacityHandler ()
		{
			if (cb_getCircleOpacity == null)
				cb_getCircleOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleOpacity);
			return cb_getCircleOpacity;
		}

		static IntPtr n_GetCircleOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleOpacity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleOpacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleOpacity' and count(parameter)=0]"
			[Register ("getCircleOpacity", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCircleOpacityHandler")]
			get {
				const string __id = "getCircleOpacity.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleOpacityTransition;
#pragma warning disable 0169
		static Delegate GetGetCircleOpacityTransitionHandler ()
		{
			if (cb_getCircleOpacityTransition == null)
				cb_getCircleOpacityTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleOpacityTransition);
			return cb_getCircleOpacityTransition;
		}

		static IntPtr n_GetCircleOpacityTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleOpacityTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setCircleOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetCircleOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setCircleOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setCircleOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setCircleOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetCircleOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.CircleOpacityTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions CircleOpacityTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleOpacityTransition' and count(parameter)=0]"
			[Register ("getCircleOpacityTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetCircleOpacityTransitionHandler")]
			get {
				const string __id = "getCircleOpacityTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setCircleOpacityTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setCircleOpacityTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetCircleOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setCircleOpacityTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCirclePitchAlignment;
#pragma warning disable 0169
		static Delegate GetGetCirclePitchAlignmentHandler ()
		{
			if (cb_getCirclePitchAlignment == null)
				cb_getCirclePitchAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCirclePitchAlignment);
			return cb_getCirclePitchAlignment;
		}

		static IntPtr n_GetCirclePitchAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CirclePitchAlignment);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CirclePitchAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCirclePitchAlignment' and count(parameter)=0]"
			[Register ("getCirclePitchAlignment", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCirclePitchAlignmentHandler")]
			get {
				const string __id = "getCirclePitchAlignment.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCirclePitchScale;
#pragma warning disable 0169
		static Delegate GetGetCirclePitchScaleHandler ()
		{
			if (cb_getCirclePitchScale == null)
				cb_getCirclePitchScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCirclePitchScale);
			return cb_getCirclePitchScale;
		}

		static IntPtr n_GetCirclePitchScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CirclePitchScale);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CirclePitchScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCirclePitchScale' and count(parameter)=0]"
			[Register ("getCirclePitchScale", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCirclePitchScaleHandler")]
			get {
				const string __id = "getCirclePitchScale.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleRadius;
#pragma warning disable 0169
		static Delegate GetGetCircleRadiusHandler ()
		{
			if (cb_getCircleRadius == null)
				cb_getCircleRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleRadius);
			return cb_getCircleRadius;
		}

		static IntPtr n_GetCircleRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleRadius);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleRadius' and count(parameter)=0]"
			[Register ("getCircleRadius", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCircleRadiusHandler")]
			get {
				const string __id = "getCircleRadius.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleRadiusTransition;
#pragma warning disable 0169
		static Delegate GetGetCircleRadiusTransitionHandler ()
		{
			if (cb_getCircleRadiusTransition == null)
				cb_getCircleRadiusTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleRadiusTransition);
			return cb_getCircleRadiusTransition;
		}

		static IntPtr n_GetCircleRadiusTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleRadiusTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setCircleRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetCircleRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setCircleRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setCircleRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setCircleRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetCircleRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.CircleRadiusTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions CircleRadiusTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleRadiusTransition' and count(parameter)=0]"
			[Register ("getCircleRadiusTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetCircleRadiusTransitionHandler")]
			get {
				const string __id = "getCircleRadiusTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setCircleRadiusTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setCircleRadiusTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetCircleRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setCircleRadiusTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleStrokeColor;
#pragma warning disable 0169
		static Delegate GetGetCircleStrokeColorHandler ()
		{
			if (cb_getCircleStrokeColor == null)
				cb_getCircleStrokeColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleStrokeColor);
			return cb_getCircleStrokeColor;
		}

		static IntPtr n_GetCircleStrokeColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleStrokeColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleStrokeColor' and count(parameter)=0]"
			[Register ("getCircleStrokeColor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCircleStrokeColorHandler")]
			get {
				const string __id = "getCircleStrokeColor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleStrokeColorAsInt;
#pragma warning disable 0169
		static Delegate GetGetCircleStrokeColorAsIntHandler ()
		{
			if (cb_getCircleStrokeColorAsInt == null)
				cb_getCircleStrokeColorAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCircleStrokeColorAsInt);
			return cb_getCircleStrokeColorAsInt;
		}

		static int n_GetCircleStrokeColorAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleStrokeColorAsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int CircleStrokeColorAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleStrokeColorAsInt' and count(parameter)=0]"
			[Register ("getCircleStrokeColorAsInt", "()I", "GetGetCircleStrokeColorAsIntHandler")]
			get {
				const string __id = "getCircleStrokeColorAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCircleStrokeColorTransition;
#pragma warning disable 0169
		static Delegate GetGetCircleStrokeColorTransitionHandler ()
		{
			if (cb_getCircleStrokeColorTransition == null)
				cb_getCircleStrokeColorTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleStrokeColorTransition);
			return cb_getCircleStrokeColorTransition;
		}

		static IntPtr n_GetCircleStrokeColorTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleStrokeColorTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setCircleStrokeColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetCircleStrokeColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setCircleStrokeColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setCircleStrokeColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleStrokeColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setCircleStrokeColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetCircleStrokeColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.CircleStrokeColorTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions CircleStrokeColorTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleStrokeColorTransition' and count(parameter)=0]"
			[Register ("getCircleStrokeColorTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetCircleStrokeColorTransitionHandler")]
			get {
				const string __id = "getCircleStrokeColorTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setCircleStrokeColorTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setCircleStrokeColorTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetCircleStrokeColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setCircleStrokeColorTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleStrokeOpacity;
#pragma warning disable 0169
		static Delegate GetGetCircleStrokeOpacityHandler ()
		{
			if (cb_getCircleStrokeOpacity == null)
				cb_getCircleStrokeOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleStrokeOpacity);
			return cb_getCircleStrokeOpacity;
		}

		static IntPtr n_GetCircleStrokeOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleStrokeOpacity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeOpacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleStrokeOpacity' and count(parameter)=0]"
			[Register ("getCircleStrokeOpacity", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCircleStrokeOpacityHandler")]
			get {
				const string __id = "getCircleStrokeOpacity.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleStrokeOpacityTransition;
#pragma warning disable 0169
		static Delegate GetGetCircleStrokeOpacityTransitionHandler ()
		{
			if (cb_getCircleStrokeOpacityTransition == null)
				cb_getCircleStrokeOpacityTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleStrokeOpacityTransition);
			return cb_getCircleStrokeOpacityTransition;
		}

		static IntPtr n_GetCircleStrokeOpacityTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleStrokeOpacityTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setCircleStrokeOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetCircleStrokeOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setCircleStrokeOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setCircleStrokeOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleStrokeOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setCircleStrokeOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetCircleStrokeOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.CircleStrokeOpacityTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions CircleStrokeOpacityTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleStrokeOpacityTransition' and count(parameter)=0]"
			[Register ("getCircleStrokeOpacityTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetCircleStrokeOpacityTransitionHandler")]
			get {
				const string __id = "getCircleStrokeOpacityTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setCircleStrokeOpacityTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setCircleStrokeOpacityTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetCircleStrokeOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setCircleStrokeOpacityTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetCircleStrokeWidthHandler ()
		{
			if (cb_getCircleStrokeWidth == null)
				cb_getCircleStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleStrokeWidth);
			return cb_getCircleStrokeWidth;
		}

		static IntPtr n_GetCircleStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleStrokeWidth);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleStrokeWidth' and count(parameter)=0]"
			[Register ("getCircleStrokeWidth", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCircleStrokeWidthHandler")]
			get {
				const string __id = "getCircleStrokeWidth.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleStrokeWidthTransition;
#pragma warning disable 0169
		static Delegate GetGetCircleStrokeWidthTransitionHandler ()
		{
			if (cb_getCircleStrokeWidthTransition == null)
				cb_getCircleStrokeWidthTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleStrokeWidthTransition);
			return cb_getCircleStrokeWidthTransition;
		}

		static IntPtr n_GetCircleStrokeWidthTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleStrokeWidthTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setCircleStrokeWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetCircleStrokeWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setCircleStrokeWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setCircleStrokeWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleStrokeWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setCircleStrokeWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetCircleStrokeWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.CircleStrokeWidthTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions CircleStrokeWidthTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleStrokeWidthTransition' and count(parameter)=0]"
			[Register ("getCircleStrokeWidthTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetCircleStrokeWidthTransitionHandler")]
			get {
				const string __id = "getCircleStrokeWidthTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setCircleStrokeWidthTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setCircleStrokeWidthTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetCircleStrokeWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setCircleStrokeWidthTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleTranslate;
#pragma warning disable 0169
		static Delegate GetGetCircleTranslateHandler ()
		{
			if (cb_getCircleTranslate == null)
				cb_getCircleTranslate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleTranslate);
			return cb_getCircleTranslate;
		}

		static IntPtr n_GetCircleTranslate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleTranslate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleTranslate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleTranslate' and count(parameter)=0]"
			[Register ("getCircleTranslate", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCircleTranslateHandler")]
			get {
				const string __id = "getCircleTranslate.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleTranslateAnchor;
#pragma warning disable 0169
		static Delegate GetGetCircleTranslateAnchorHandler ()
		{
			if (cb_getCircleTranslateAnchor == null)
				cb_getCircleTranslateAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleTranslateAnchor);
			return cb_getCircleTranslateAnchor;
		}

		static IntPtr n_GetCircleTranslateAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleTranslateAnchor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleTranslateAnchor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleTranslateAnchor' and count(parameter)=0]"
			[Register ("getCircleTranslateAnchor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetCircleTranslateAnchorHandler")]
			get {
				const string __id = "getCircleTranslateAnchor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleTranslateTransition;
#pragma warning disable 0169
		static Delegate GetGetCircleTranslateTransitionHandler ()
		{
			if (cb_getCircleTranslateTransition == null)
				cb_getCircleTranslateTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleTranslateTransition);
			return cb_getCircleTranslateTransition;
		}

		static IntPtr n_GetCircleTranslateTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleTranslateTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setCircleTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetCircleTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setCircleTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setCircleTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setCircleTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetCircleTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.CircleTranslateTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions CircleTranslateTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getCircleTranslateTransition' and count(parameter)=0]"
			[Register ("getCircleTranslateTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetCircleTranslateTransitionHandler")]
			get {
				const string __id = "getCircleTranslateTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setCircleTranslateTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setCircleTranslateTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetCircleTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setCircleTranslateTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFilter;
#pragma warning disable 0169
		static Delegate GetGetFilterHandler ()
		{
			if (cb_getFilter == null)
				cb_getFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilter);
			return cb_getFilter;
		}

		static IntPtr n_GetFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Filter);
		}
#pragma warning restore 0169

		static Delegate cb_setFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_;
#pragma warning disable 0169
		static Delegate GetSetFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Handler ()
		{
			if (cb_setFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_ == null)
				cb_setFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_);
			return cb_setFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_;
		}

		static void n_SetFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.Filter = filter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "GetGetFilterHandler")]
			get {
				const string __id = "getFilter.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
			[Register ("setFilter", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)V", "GetSetFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Handler")]
			set {
				const string __id = "setFilter.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)V";
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourceId);
		}
#pragma warning restore 0169

		public virtual unsafe string SourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getSourceId' and count(parameter)=0]"
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

		static Delegate cb_getSourceLayer;
#pragma warning disable 0169
		static Delegate GetGetSourceLayerHandler ()
		{
			if (cb_getSourceLayer == null)
				cb_getSourceLayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourceLayer);
			return cb_getSourceLayer;
		}

		static IntPtr n_GetSourceLayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourceLayer);
		}
#pragma warning restore 0169

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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			__this.SourceLayer = sourceLayer;
		}
#pragma warning restore 0169

		public virtual unsafe string SourceLayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='getSourceLayer' and count(parameter)=0]"
			[Register ("getSourceLayer", "()Ljava/lang/String;", "GetGetSourceLayerHandler")]
			get {
				const string __id = "getSourceLayer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='setSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSourceLayer", "(Ljava/lang/String;)V", "GetSetSourceLayer_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSourceLayer.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_withFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_;
#pragma warning disable 0169
		static Delegate GetWithFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Handler ()
		{
			if (cb_withFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_ == null)
				cb_withFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_);
			return cb_withFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_;
		}

		static IntPtr n_WithFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFilter (filter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='withFilter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("withFilter", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/CircleLayer;", "GetWithFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer WithFilter (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter)
		{
			const string __id = "withFilter.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/CircleLayer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties = (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[]) JNIEnv.GetArray (native_properties, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithProperties (properties));
			if (properties != null)
				JNIEnv.CopyArray (properties, native_properties);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='withProperties' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.PropertyValue&lt;?&gt;...']]"
		[Register ("withProperties", "([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/CircleLayer;", "GetWithProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer WithProperties (params global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties)
		{
			const string __id = "withProperties.([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/CircleLayer;";
			IntPtr native_properties = JNIEnv.NewArray (properties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_properties);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSourceLayer (sourceLayer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CircleLayer']/method[@name='withSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSourceLayer", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/CircleLayer;", "GetWithSourceLayer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer WithSourceLayer (string sourceLayer)
		{
			const string __id = "withSourceLayer.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/CircleLayer;";
			IntPtr native_sourceLayer = JNIEnv.NewString (sourceLayer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourceLayer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CircleLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceLayer);
			}
		}

	}
}
