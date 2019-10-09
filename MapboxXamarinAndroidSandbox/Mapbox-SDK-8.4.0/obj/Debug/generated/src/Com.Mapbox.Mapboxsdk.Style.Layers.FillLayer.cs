using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/FillLayer", DoNotGenerateAcw=true)]
	public partial class FillLayer : global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/FillLayer", typeof (FillLayer));
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

		protected FillLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/constructor[@name='FillLayer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FillLayer (string layerId, string sourceId)
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

		static Delegate cb_getFillAntialias;
#pragma warning disable 0169
		static Delegate GetGetFillAntialiasHandler ()
		{
			if (cb_getFillAntialias == null)
				cb_getFillAntialias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillAntialias);
			return cb_getFillAntialias;
		}

		static IntPtr n_GetFillAntialias (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillAntialias);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillAntialias {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillAntialias' and count(parameter)=0]"
			[Register ("getFillAntialias", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetFillAntialiasHandler")]
			get {
				const string __id = "getFillAntialias.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFillColor;
#pragma warning disable 0169
		static Delegate GetGetFillColorHandler ()
		{
			if (cb_getFillColor == null)
				cb_getFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillColor);
			return cb_getFillColor;
		}

		static IntPtr n_GetFillColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetFillColorHandler")]
			get {
				const string __id = "getFillColor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFillColorAsInt;
#pragma warning disable 0169
		static Delegate GetGetFillColorAsIntHandler ()
		{
			if (cb_getFillColorAsInt == null)
				cb_getFillColorAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillColorAsInt);
			return cb_getFillColorAsInt;
		}

		static int n_GetFillColorAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillColorAsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int FillColorAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillColorAsInt' and count(parameter)=0]"
			[Register ("getFillColorAsInt", "()I", "GetGetFillColorAsIntHandler")]
			get {
				const string __id = "getFillColorAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFillColorTransition;
#pragma warning disable 0169
		static Delegate GetGetFillColorTransitionHandler ()
		{
			if (cb_getFillColorTransition == null)
				cb_getFillColorTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillColorTransition);
			return cb_getFillColorTransition;
		}

		static IntPtr n_GetFillColorTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillColorTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setFillColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetFillColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setFillColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setFillColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFillColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setFillColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetFillColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.FillColorTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions FillColorTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillColorTransition' and count(parameter)=0]"
			[Register ("getFillColorTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetFillColorTransitionHandler")]
			get {
				const string __id = "getFillColorTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='setFillColorTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setFillColorTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetFillColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setFillColorTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFillOpacity;
#pragma warning disable 0169
		static Delegate GetGetFillOpacityHandler ()
		{
			if (cb_getFillOpacity == null)
				cb_getFillOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillOpacity);
			return cb_getFillOpacity;
		}

		static IntPtr n_GetFillOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillOpacity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillOpacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillOpacity' and count(parameter)=0]"
			[Register ("getFillOpacity", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetFillOpacityHandler")]
			get {
				const string __id = "getFillOpacity.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFillOpacityTransition;
#pragma warning disable 0169
		static Delegate GetGetFillOpacityTransitionHandler ()
		{
			if (cb_getFillOpacityTransition == null)
				cb_getFillOpacityTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillOpacityTransition);
			return cb_getFillOpacityTransition;
		}

		static IntPtr n_GetFillOpacityTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillOpacityTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setFillOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetFillOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setFillOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setFillOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFillOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setFillOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetFillOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.FillOpacityTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions FillOpacityTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillOpacityTransition' and count(parameter)=0]"
			[Register ("getFillOpacityTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetFillOpacityTransitionHandler")]
			get {
				const string __id = "getFillOpacityTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='setFillOpacityTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setFillOpacityTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetFillOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setFillOpacityTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFillOutlineColor;
#pragma warning disable 0169
		static Delegate GetGetFillOutlineColorHandler ()
		{
			if (cb_getFillOutlineColor == null)
				cb_getFillOutlineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillOutlineColor);
			return cb_getFillOutlineColor;
		}

		static IntPtr n_GetFillOutlineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillOutlineColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillOutlineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillOutlineColor' and count(parameter)=0]"
			[Register ("getFillOutlineColor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetFillOutlineColorHandler")]
			get {
				const string __id = "getFillOutlineColor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFillOutlineColorAsInt;
#pragma warning disable 0169
		static Delegate GetGetFillOutlineColorAsIntHandler ()
		{
			if (cb_getFillOutlineColorAsInt == null)
				cb_getFillOutlineColorAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillOutlineColorAsInt);
			return cb_getFillOutlineColorAsInt;
		}

		static int n_GetFillOutlineColorAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillOutlineColorAsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int FillOutlineColorAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillOutlineColorAsInt' and count(parameter)=0]"
			[Register ("getFillOutlineColorAsInt", "()I", "GetGetFillOutlineColorAsIntHandler")]
			get {
				const string __id = "getFillOutlineColorAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFillOutlineColorTransition;
#pragma warning disable 0169
		static Delegate GetGetFillOutlineColorTransitionHandler ()
		{
			if (cb_getFillOutlineColorTransition == null)
				cb_getFillOutlineColorTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillOutlineColorTransition);
			return cb_getFillOutlineColorTransition;
		}

		static IntPtr n_GetFillOutlineColorTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillOutlineColorTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setFillOutlineColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetFillOutlineColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setFillOutlineColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setFillOutlineColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFillOutlineColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setFillOutlineColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetFillOutlineColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.FillOutlineColorTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions FillOutlineColorTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillOutlineColorTransition' and count(parameter)=0]"
			[Register ("getFillOutlineColorTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetFillOutlineColorTransitionHandler")]
			get {
				const string __id = "getFillOutlineColorTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='setFillOutlineColorTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setFillOutlineColorTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetFillOutlineColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setFillOutlineColorTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFillPattern;
#pragma warning disable 0169
		static Delegate GetGetFillPatternHandler ()
		{
			if (cb_getFillPattern == null)
				cb_getFillPattern = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillPattern);
			return cb_getFillPattern;
		}

		static IntPtr n_GetFillPattern (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillPattern);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillPattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillPattern' and count(parameter)=0]"
			[Register ("getFillPattern", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetFillPatternHandler")]
			get {
				const string __id = "getFillPattern.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFillPatternTransition;
#pragma warning disable 0169
		static Delegate GetGetFillPatternTransitionHandler ()
		{
			if (cb_getFillPatternTransition == null)
				cb_getFillPatternTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillPatternTransition);
			return cb_getFillPatternTransition;
		}

		static IntPtr n_GetFillPatternTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillPatternTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setFillPatternTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetFillPatternTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setFillPatternTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setFillPatternTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFillPatternTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setFillPatternTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetFillPatternTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.FillPatternTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions FillPatternTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillPatternTransition' and count(parameter)=0]"
			[Register ("getFillPatternTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetFillPatternTransitionHandler")]
			get {
				const string __id = "getFillPatternTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='setFillPatternTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setFillPatternTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetFillPatternTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setFillPatternTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFillTranslate;
#pragma warning disable 0169
		static Delegate GetGetFillTranslateHandler ()
		{
			if (cb_getFillTranslate == null)
				cb_getFillTranslate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillTranslate);
			return cb_getFillTranslate;
		}

		static IntPtr n_GetFillTranslate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillTranslate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillTranslate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillTranslate' and count(parameter)=0]"
			[Register ("getFillTranslate", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetFillTranslateHandler")]
			get {
				const string __id = "getFillTranslate.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFillTranslateAnchor;
#pragma warning disable 0169
		static Delegate GetGetFillTranslateAnchorHandler ()
		{
			if (cb_getFillTranslateAnchor == null)
				cb_getFillTranslateAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillTranslateAnchor);
			return cb_getFillTranslateAnchor;
		}

		static IntPtr n_GetFillTranslateAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillTranslateAnchor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillTranslateAnchor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillTranslateAnchor' and count(parameter)=0]"
			[Register ("getFillTranslateAnchor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetFillTranslateAnchorHandler")]
			get {
				const string __id = "getFillTranslateAnchor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFillTranslateTransition;
#pragma warning disable 0169
		static Delegate GetGetFillTranslateTransitionHandler ()
		{
			if (cb_getFillTranslateTransition == null)
				cb_getFillTranslateTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillTranslateTransition);
			return cb_getFillTranslateTransition;
		}

		static IntPtr n_GetFillTranslateTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillTranslateTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setFillTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetFillTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setFillTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setFillTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFillTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setFillTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetFillTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.FillTranslateTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions FillTranslateTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFillTranslateTransition' and count(parameter)=0]"
			[Register ("getFillTranslateTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetFillTranslateTransitionHandler")]
			get {
				const string __id = "getFillTranslateTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='setFillTranslateTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setFillTranslateTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetFillTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setFillTranslateTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.Filter = filter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "GetGetFilterHandler")]
			get {
				const string __id = "getFilter.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourceId);
		}
#pragma warning restore 0169

		public virtual unsafe string SourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getSourceId' and count(parameter)=0]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			__this.SourceLayer = sourceLayer;
		}
#pragma warning restore 0169

		public virtual unsafe string SourceLayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='getSourceLayer' and count(parameter)=0]"
			[Register ("getSourceLayer", "()Ljava/lang/String;", "GetGetSourceLayerHandler")]
			get {
				const string __id = "getSourceLayer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='setSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFilter (filter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='withFilter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("withFilter", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/FillLayer;", "GetWithFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer WithFilter (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter)
		{
			const string __id = "withFilter.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/FillLayer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties = (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[]) JNIEnv.GetArray (native_properties, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithProperties (properties));
			if (properties != null)
				JNIEnv.CopyArray (properties, native_properties);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='withProperties' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.PropertyValue&lt;?&gt;...']]"
		[Register ("withProperties", "([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/FillLayer;", "GetWithProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer WithProperties (params global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties)
		{
			const string __id = "withProperties.([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/FillLayer;";
			IntPtr native_properties = JNIEnv.NewArray (properties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_properties);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSourceLayer (sourceLayer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='FillLayer']/method[@name='withSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSourceLayer", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/FillLayer;", "GetWithSourceLayer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer WithSourceLayer (string sourceLayer)
		{
			const string __id = "withSourceLayer.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/FillLayer;";
			IntPtr native_sourceLayer = JNIEnv.NewString (sourceLayer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourceLayer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.FillLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceLayer);
			}
		}

	}
}
