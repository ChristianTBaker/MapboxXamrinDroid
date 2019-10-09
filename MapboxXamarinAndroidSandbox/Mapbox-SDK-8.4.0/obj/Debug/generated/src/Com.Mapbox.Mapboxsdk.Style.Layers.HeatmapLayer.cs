using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/HeatmapLayer", DoNotGenerateAcw=true)]
	public partial class HeatmapLayer : global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/HeatmapLayer", typeof (HeatmapLayer));
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

		protected HeatmapLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/constructor[@name='HeatmapLayer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe HeatmapLayer (string layerId, string sourceId)
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.Filter = filter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "GetGetFilterHandler")]
			get {
				const string __id = "getFilter.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
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

		static Delegate cb_getHeatmapColor;
#pragma warning disable 0169
		static Delegate GetGetHeatmapColorHandler ()
		{
			if (cb_getHeatmapColor == null)
				cb_getHeatmapColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeatmapColor);
			return cb_getHeatmapColor;
		}

		static IntPtr n_GetHeatmapColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeatmapColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getHeatmapColor' and count(parameter)=0]"
			[Register ("getHeatmapColor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetHeatmapColorHandler")]
			get {
				const string __id = "getHeatmapColor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeatmapColorAsInt;
#pragma warning disable 0169
		static Delegate GetGetHeatmapColorAsIntHandler ()
		{
			if (cb_getHeatmapColorAsInt == null)
				cb_getHeatmapColorAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeatmapColorAsInt);
			return cb_getHeatmapColorAsInt;
		}

		static int n_GetHeatmapColorAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeatmapColorAsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int HeatmapColorAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getHeatmapColorAsInt' and count(parameter)=0]"
			[Register ("getHeatmapColorAsInt", "()I", "GetGetHeatmapColorAsIntHandler")]
			get {
				const string __id = "getHeatmapColorAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHeatmapIntensity;
#pragma warning disable 0169
		static Delegate GetGetHeatmapIntensityHandler ()
		{
			if (cb_getHeatmapIntensity == null)
				cb_getHeatmapIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeatmapIntensity);
			return cb_getHeatmapIntensity;
		}

		static IntPtr n_GetHeatmapIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeatmapIntensity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getHeatmapIntensity' and count(parameter)=0]"
			[Register ("getHeatmapIntensity", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetHeatmapIntensityHandler")]
			get {
				const string __id = "getHeatmapIntensity.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeatmapIntensityTransition;
#pragma warning disable 0169
		static Delegate GetGetHeatmapIntensityTransitionHandler ()
		{
			if (cb_getHeatmapIntensityTransition == null)
				cb_getHeatmapIntensityTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeatmapIntensityTransition);
			return cb_getHeatmapIntensityTransition;
		}

		static IntPtr n_GetHeatmapIntensityTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeatmapIntensityTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setHeatmapIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetHeatmapIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setHeatmapIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setHeatmapIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeatmapIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setHeatmapIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetHeatmapIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.HeatmapIntensityTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions HeatmapIntensityTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getHeatmapIntensityTransition' and count(parameter)=0]"
			[Register ("getHeatmapIntensityTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetHeatmapIntensityTransitionHandler")]
			get {
				const string __id = "getHeatmapIntensityTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='setHeatmapIntensityTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setHeatmapIntensityTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetHeatmapIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setHeatmapIntensityTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeatmapOpacity;
#pragma warning disable 0169
		static Delegate GetGetHeatmapOpacityHandler ()
		{
			if (cb_getHeatmapOpacity == null)
				cb_getHeatmapOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeatmapOpacity);
			return cb_getHeatmapOpacity;
		}

		static IntPtr n_GetHeatmapOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeatmapOpacity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapOpacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getHeatmapOpacity' and count(parameter)=0]"
			[Register ("getHeatmapOpacity", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetHeatmapOpacityHandler")]
			get {
				const string __id = "getHeatmapOpacity.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeatmapOpacityTransition;
#pragma warning disable 0169
		static Delegate GetGetHeatmapOpacityTransitionHandler ()
		{
			if (cb_getHeatmapOpacityTransition == null)
				cb_getHeatmapOpacityTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeatmapOpacityTransition);
			return cb_getHeatmapOpacityTransition;
		}

		static IntPtr n_GetHeatmapOpacityTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeatmapOpacityTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setHeatmapOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetHeatmapOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setHeatmapOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setHeatmapOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeatmapOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setHeatmapOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetHeatmapOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.HeatmapOpacityTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions HeatmapOpacityTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getHeatmapOpacityTransition' and count(parameter)=0]"
			[Register ("getHeatmapOpacityTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetHeatmapOpacityTransitionHandler")]
			get {
				const string __id = "getHeatmapOpacityTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='setHeatmapOpacityTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setHeatmapOpacityTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetHeatmapOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setHeatmapOpacityTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeatmapRadius;
#pragma warning disable 0169
		static Delegate GetGetHeatmapRadiusHandler ()
		{
			if (cb_getHeatmapRadius == null)
				cb_getHeatmapRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeatmapRadius);
			return cb_getHeatmapRadius;
		}

		static IntPtr n_GetHeatmapRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeatmapRadius);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getHeatmapRadius' and count(parameter)=0]"
			[Register ("getHeatmapRadius", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetHeatmapRadiusHandler")]
			get {
				const string __id = "getHeatmapRadius.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeatmapRadiusTransition;
#pragma warning disable 0169
		static Delegate GetGetHeatmapRadiusTransitionHandler ()
		{
			if (cb_getHeatmapRadiusTransition == null)
				cb_getHeatmapRadiusTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeatmapRadiusTransition);
			return cb_getHeatmapRadiusTransition;
		}

		static IntPtr n_GetHeatmapRadiusTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeatmapRadiusTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setHeatmapRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetHeatmapRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setHeatmapRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setHeatmapRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeatmapRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setHeatmapRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetHeatmapRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.HeatmapRadiusTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions HeatmapRadiusTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getHeatmapRadiusTransition' and count(parameter)=0]"
			[Register ("getHeatmapRadiusTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetHeatmapRadiusTransitionHandler")]
			get {
				const string __id = "getHeatmapRadiusTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='setHeatmapRadiusTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setHeatmapRadiusTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetHeatmapRadiusTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setHeatmapRadiusTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeatmapWeight;
#pragma warning disable 0169
		static Delegate GetGetHeatmapWeightHandler ()
		{
			if (cb_getHeatmapWeight == null)
				cb_getHeatmapWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeatmapWeight);
			return cb_getHeatmapWeight;
		}

		static IntPtr n_GetHeatmapWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeatmapWeight);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapWeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getHeatmapWeight' and count(parameter)=0]"
			[Register ("getHeatmapWeight", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetHeatmapWeightHandler")]
			get {
				const string __id = "getHeatmapWeight.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourceId);
		}
#pragma warning restore 0169

		public virtual unsafe string SourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getSourceId' and count(parameter)=0]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			__this.SourceLayer = sourceLayer;
		}
#pragma warning restore 0169

		public virtual unsafe string SourceLayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='getSourceLayer' and count(parameter)=0]"
			[Register ("getSourceLayer", "()Ljava/lang/String;", "GetGetSourceLayerHandler")]
			get {
				const string __id = "getSourceLayer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='setSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFilter (filter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='withFilter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("withFilter", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/HeatmapLayer;", "GetWithFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer WithFilter (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter)
		{
			const string __id = "withFilter.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/HeatmapLayer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties = (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[]) JNIEnv.GetArray (native_properties, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithProperties (properties));
			if (properties != null)
				JNIEnv.CopyArray (properties, native_properties);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='withProperties' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.PropertyValue&lt;?&gt;...']]"
		[Register ("withProperties", "([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/HeatmapLayer;", "GetWithProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer WithProperties (params global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties)
		{
			const string __id = "withProperties.([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/HeatmapLayer;";
			IntPtr native_properties = JNIEnv.NewArray (properties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_properties);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSourceLayer (sourceLayer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='HeatmapLayer']/method[@name='withSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSourceLayer", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/HeatmapLayer;", "GetWithSourceLayer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer WithSourceLayer (string sourceLayer)
		{
			const string __id = "withSourceLayer.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/HeatmapLayer;";
			IntPtr native_sourceLayer = JNIEnv.NewString (sourceLayer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourceLayer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.HeatmapLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceLayer);
			}
		}

	}
}
