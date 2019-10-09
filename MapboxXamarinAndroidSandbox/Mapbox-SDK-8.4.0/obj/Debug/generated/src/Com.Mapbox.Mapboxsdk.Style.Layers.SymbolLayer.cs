using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/SymbolLayer", DoNotGenerateAcw=true)]
	public partial class SymbolLayer : global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/SymbolLayer", typeof (SymbolLayer));
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

		protected SymbolLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/constructor[@name='SymbolLayer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SymbolLayer (string layerId, string sourceId)
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.Filter = filter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "GetGetFilterHandler")]
			get {
				const string __id = "getFilter.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
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

		static Delegate cb_getIconAllowOverlap;
#pragma warning disable 0169
		static Delegate GetGetIconAllowOverlapHandler ()
		{
			if (cb_getIconAllowOverlap == null)
				cb_getIconAllowOverlap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconAllowOverlap);
			return cb_getIconAllowOverlap;
		}

		static IntPtr n_GetIconAllowOverlap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconAllowOverlap);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconAllowOverlap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconAllowOverlap' and count(parameter)=0]"
			[Register ("getIconAllowOverlap", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconAllowOverlapHandler")]
			get {
				const string __id = "getIconAllowOverlap.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconAnchor;
#pragma warning disable 0169
		static Delegate GetGetIconAnchorHandler ()
		{
			if (cb_getIconAnchor == null)
				cb_getIconAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconAnchor);
			return cb_getIconAnchor;
		}

		static IntPtr n_GetIconAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconAnchor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconAnchor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconAnchor' and count(parameter)=0]"
			[Register ("getIconAnchor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconAnchorHandler")]
			get {
				const string __id = "getIconAnchor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconColor;
#pragma warning disable 0169
		static Delegate GetGetIconColorHandler ()
		{
			if (cb_getIconColor == null)
				cb_getIconColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconColor);
			return cb_getIconColor;
		}

		static IntPtr n_GetIconColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconColor' and count(parameter)=0]"
			[Register ("getIconColor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconColorHandler")]
			get {
				const string __id = "getIconColor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconColorAsInt;
#pragma warning disable 0169
		static Delegate GetGetIconColorAsIntHandler ()
		{
			if (cb_getIconColorAsInt == null)
				cb_getIconColorAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIconColorAsInt);
			return cb_getIconColorAsInt;
		}

		static int n_GetIconColorAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconColorAsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int IconColorAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconColorAsInt' and count(parameter)=0]"
			[Register ("getIconColorAsInt", "()I", "GetGetIconColorAsIntHandler")]
			get {
				const string __id = "getIconColorAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIconColorTransition;
#pragma warning disable 0169
		static Delegate GetGetIconColorTransitionHandler ()
		{
			if (cb_getIconColorTransition == null)
				cb_getIconColorTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconColorTransition);
			return cb_getIconColorTransition;
		}

		static IntPtr n_GetIconColorTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconColorTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setIconColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetIconColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setIconColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setIconColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setIconColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetIconColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.IconColorTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions IconColorTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconColorTransition' and count(parameter)=0]"
			[Register ("getIconColorTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetIconColorTransitionHandler")]
			get {
				const string __id = "getIconColorTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setIconColorTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setIconColorTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetIconColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setIconColorTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconHaloBlur;
#pragma warning disable 0169
		static Delegate GetGetIconHaloBlurHandler ()
		{
			if (cb_getIconHaloBlur == null)
				cb_getIconHaloBlur = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconHaloBlur);
			return cb_getIconHaloBlur;
		}

		static IntPtr n_GetIconHaloBlur (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconHaloBlur);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloBlur {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconHaloBlur' and count(parameter)=0]"
			[Register ("getIconHaloBlur", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconHaloBlurHandler")]
			get {
				const string __id = "getIconHaloBlur.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconHaloBlurTransition;
#pragma warning disable 0169
		static Delegate GetGetIconHaloBlurTransitionHandler ()
		{
			if (cb_getIconHaloBlurTransition == null)
				cb_getIconHaloBlurTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconHaloBlurTransition);
			return cb_getIconHaloBlurTransition;
		}

		static IntPtr n_GetIconHaloBlurTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconHaloBlurTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setIconHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetIconHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setIconHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setIconHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setIconHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetIconHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.IconHaloBlurTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions IconHaloBlurTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconHaloBlurTransition' and count(parameter)=0]"
			[Register ("getIconHaloBlurTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetIconHaloBlurTransitionHandler")]
			get {
				const string __id = "getIconHaloBlurTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setIconHaloBlurTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setIconHaloBlurTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetIconHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setIconHaloBlurTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconHaloColor;
#pragma warning disable 0169
		static Delegate GetGetIconHaloColorHandler ()
		{
			if (cb_getIconHaloColor == null)
				cb_getIconHaloColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconHaloColor);
			return cb_getIconHaloColor;
		}

		static IntPtr n_GetIconHaloColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconHaloColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconHaloColor' and count(parameter)=0]"
			[Register ("getIconHaloColor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconHaloColorHandler")]
			get {
				const string __id = "getIconHaloColor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconHaloColorAsInt;
#pragma warning disable 0169
		static Delegate GetGetIconHaloColorAsIntHandler ()
		{
			if (cb_getIconHaloColorAsInt == null)
				cb_getIconHaloColorAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIconHaloColorAsInt);
			return cb_getIconHaloColorAsInt;
		}

		static int n_GetIconHaloColorAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconHaloColorAsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int IconHaloColorAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconHaloColorAsInt' and count(parameter)=0]"
			[Register ("getIconHaloColorAsInt", "()I", "GetGetIconHaloColorAsIntHandler")]
			get {
				const string __id = "getIconHaloColorAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIconHaloColorTransition;
#pragma warning disable 0169
		static Delegate GetGetIconHaloColorTransitionHandler ()
		{
			if (cb_getIconHaloColorTransition == null)
				cb_getIconHaloColorTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconHaloColorTransition);
			return cb_getIconHaloColorTransition;
		}

		static IntPtr n_GetIconHaloColorTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconHaloColorTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setIconHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetIconHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setIconHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setIconHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setIconHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetIconHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.IconHaloColorTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions IconHaloColorTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconHaloColorTransition' and count(parameter)=0]"
			[Register ("getIconHaloColorTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetIconHaloColorTransitionHandler")]
			get {
				const string __id = "getIconHaloColorTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setIconHaloColorTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setIconHaloColorTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetIconHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setIconHaloColorTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconHaloWidth;
#pragma warning disable 0169
		static Delegate GetGetIconHaloWidthHandler ()
		{
			if (cb_getIconHaloWidth == null)
				cb_getIconHaloWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconHaloWidth);
			return cb_getIconHaloWidth;
		}

		static IntPtr n_GetIconHaloWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconHaloWidth);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconHaloWidth' and count(parameter)=0]"
			[Register ("getIconHaloWidth", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconHaloWidthHandler")]
			get {
				const string __id = "getIconHaloWidth.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconHaloWidthTransition;
#pragma warning disable 0169
		static Delegate GetGetIconHaloWidthTransitionHandler ()
		{
			if (cb_getIconHaloWidthTransition == null)
				cb_getIconHaloWidthTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconHaloWidthTransition);
			return cb_getIconHaloWidthTransition;
		}

		static IntPtr n_GetIconHaloWidthTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconHaloWidthTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setIconHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetIconHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setIconHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setIconHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setIconHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetIconHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.IconHaloWidthTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions IconHaloWidthTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconHaloWidthTransition' and count(parameter)=0]"
			[Register ("getIconHaloWidthTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetIconHaloWidthTransitionHandler")]
			get {
				const string __id = "getIconHaloWidthTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setIconHaloWidthTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setIconHaloWidthTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetIconHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setIconHaloWidthTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconIgnorePlacement;
#pragma warning disable 0169
		static Delegate GetGetIconIgnorePlacementHandler ()
		{
			if (cb_getIconIgnorePlacement == null)
				cb_getIconIgnorePlacement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconIgnorePlacement);
			return cb_getIconIgnorePlacement;
		}

		static IntPtr n_GetIconIgnorePlacement (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconIgnorePlacement);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconIgnorePlacement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconIgnorePlacement' and count(parameter)=0]"
			[Register ("getIconIgnorePlacement", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconIgnorePlacementHandler")]
			get {
				const string __id = "getIconIgnorePlacement.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconImage;
#pragma warning disable 0169
		static Delegate GetGetIconImageHandler ()
		{
			if (cb_getIconImage == null)
				cb_getIconImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconImage);
			return cb_getIconImage;
		}

		static IntPtr n_GetIconImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconImage);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconImage' and count(parameter)=0]"
			[Register ("getIconImage", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconImageHandler")]
			get {
				const string __id = "getIconImage.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconKeepUpright;
#pragma warning disable 0169
		static Delegate GetGetIconKeepUprightHandler ()
		{
			if (cb_getIconKeepUpright == null)
				cb_getIconKeepUpright = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconKeepUpright);
			return cb_getIconKeepUpright;
		}

		static IntPtr n_GetIconKeepUpright (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconKeepUpright);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconKeepUpright {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconKeepUpright' and count(parameter)=0]"
			[Register ("getIconKeepUpright", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconKeepUprightHandler")]
			get {
				const string __id = "getIconKeepUpright.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconOffset;
#pragma warning disable 0169
		static Delegate GetGetIconOffsetHandler ()
		{
			if (cb_getIconOffset == null)
				cb_getIconOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconOffset);
			return cb_getIconOffset;
		}

		static IntPtr n_GetIconOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconOffset);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconOffset' and count(parameter)=0]"
			[Register ("getIconOffset", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconOffsetHandler")]
			get {
				const string __id = "getIconOffset.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconOpacity;
#pragma warning disable 0169
		static Delegate GetGetIconOpacityHandler ()
		{
			if (cb_getIconOpacity == null)
				cb_getIconOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconOpacity);
			return cb_getIconOpacity;
		}

		static IntPtr n_GetIconOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconOpacity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconOpacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconOpacity' and count(parameter)=0]"
			[Register ("getIconOpacity", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconOpacityHandler")]
			get {
				const string __id = "getIconOpacity.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconOpacityTransition;
#pragma warning disable 0169
		static Delegate GetGetIconOpacityTransitionHandler ()
		{
			if (cb_getIconOpacityTransition == null)
				cb_getIconOpacityTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconOpacityTransition);
			return cb_getIconOpacityTransition;
		}

		static IntPtr n_GetIconOpacityTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconOpacityTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setIconOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetIconOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setIconOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setIconOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setIconOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetIconOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.IconOpacityTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions IconOpacityTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconOpacityTransition' and count(parameter)=0]"
			[Register ("getIconOpacityTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetIconOpacityTransitionHandler")]
			get {
				const string __id = "getIconOpacityTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setIconOpacityTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setIconOpacityTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetIconOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setIconOpacityTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconOptional;
#pragma warning disable 0169
		static Delegate GetGetIconOptionalHandler ()
		{
			if (cb_getIconOptional == null)
				cb_getIconOptional = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconOptional);
			return cb_getIconOptional;
		}

		static IntPtr n_GetIconOptional (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconOptional);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconOptional {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconOptional' and count(parameter)=0]"
			[Register ("getIconOptional", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconOptionalHandler")]
			get {
				const string __id = "getIconOptional.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconPadding;
#pragma warning disable 0169
		static Delegate GetGetIconPaddingHandler ()
		{
			if (cb_getIconPadding == null)
				cb_getIconPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconPadding);
			return cb_getIconPadding;
		}

		static IntPtr n_GetIconPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconPadding);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconPadding' and count(parameter)=0]"
			[Register ("getIconPadding", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconPaddingHandler")]
			get {
				const string __id = "getIconPadding.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconPitchAlignment;
#pragma warning disable 0169
		static Delegate GetGetIconPitchAlignmentHandler ()
		{
			if (cb_getIconPitchAlignment == null)
				cb_getIconPitchAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconPitchAlignment);
			return cb_getIconPitchAlignment;
		}

		static IntPtr n_GetIconPitchAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconPitchAlignment);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconPitchAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconPitchAlignment' and count(parameter)=0]"
			[Register ("getIconPitchAlignment", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconPitchAlignmentHandler")]
			get {
				const string __id = "getIconPitchAlignment.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconRotate;
#pragma warning disable 0169
		static Delegate GetGetIconRotateHandler ()
		{
			if (cb_getIconRotate == null)
				cb_getIconRotate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconRotate);
			return cb_getIconRotate;
		}

		static IntPtr n_GetIconRotate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconRotate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconRotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconRotate' and count(parameter)=0]"
			[Register ("getIconRotate", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconRotateHandler")]
			get {
				const string __id = "getIconRotate.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconRotationAlignment;
#pragma warning disable 0169
		static Delegate GetGetIconRotationAlignmentHandler ()
		{
			if (cb_getIconRotationAlignment == null)
				cb_getIconRotationAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconRotationAlignment);
			return cb_getIconRotationAlignment;
		}

		static IntPtr n_GetIconRotationAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconRotationAlignment);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconRotationAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconRotationAlignment' and count(parameter)=0]"
			[Register ("getIconRotationAlignment", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconRotationAlignmentHandler")]
			get {
				const string __id = "getIconRotationAlignment.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconSize;
#pragma warning disable 0169
		static Delegate GetGetIconSizeHandler ()
		{
			if (cb_getIconSize == null)
				cb_getIconSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconSize);
			return cb_getIconSize;
		}

		static IntPtr n_GetIconSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconSize);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconSize' and count(parameter)=0]"
			[Register ("getIconSize", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconSizeHandler")]
			get {
				const string __id = "getIconSize.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconTextFit;
#pragma warning disable 0169
		static Delegate GetGetIconTextFitHandler ()
		{
			if (cb_getIconTextFit == null)
				cb_getIconTextFit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconTextFit);
			return cb_getIconTextFit;
		}

		static IntPtr n_GetIconTextFit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconTextFit);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTextFit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconTextFit' and count(parameter)=0]"
			[Register ("getIconTextFit", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconTextFitHandler")]
			get {
				const string __id = "getIconTextFit.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconTextFitPadding;
#pragma warning disable 0169
		static Delegate GetGetIconTextFitPaddingHandler ()
		{
			if (cb_getIconTextFitPadding == null)
				cb_getIconTextFitPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconTextFitPadding);
			return cb_getIconTextFitPadding;
		}

		static IntPtr n_GetIconTextFitPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconTextFitPadding);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTextFitPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconTextFitPadding' and count(parameter)=0]"
			[Register ("getIconTextFitPadding", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconTextFitPaddingHandler")]
			get {
				const string __id = "getIconTextFitPadding.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconTranslate;
#pragma warning disable 0169
		static Delegate GetGetIconTranslateHandler ()
		{
			if (cb_getIconTranslate == null)
				cb_getIconTranslate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconTranslate);
			return cb_getIconTranslate;
		}

		static IntPtr n_GetIconTranslate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconTranslate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTranslate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconTranslate' and count(parameter)=0]"
			[Register ("getIconTranslate", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconTranslateHandler")]
			get {
				const string __id = "getIconTranslate.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconTranslateAnchor;
#pragma warning disable 0169
		static Delegate GetGetIconTranslateAnchorHandler ()
		{
			if (cb_getIconTranslateAnchor == null)
				cb_getIconTranslateAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconTranslateAnchor);
			return cb_getIconTranslateAnchor;
		}

		static IntPtr n_GetIconTranslateAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconTranslateAnchor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTranslateAnchor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconTranslateAnchor' and count(parameter)=0]"
			[Register ("getIconTranslateAnchor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetIconTranslateAnchorHandler")]
			get {
				const string __id = "getIconTranslateAnchor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconTranslateTransition;
#pragma warning disable 0169
		static Delegate GetGetIconTranslateTransitionHandler ()
		{
			if (cb_getIconTranslateTransition == null)
				cb_getIconTranslateTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconTranslateTransition);
			return cb_getIconTranslateTransition;
		}

		static IntPtr n_GetIconTranslateTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconTranslateTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setIconTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetIconTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setIconTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setIconTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setIconTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetIconTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.IconTranslateTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions IconTranslateTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getIconTranslateTransition' and count(parameter)=0]"
			[Register ("getIconTranslateTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetIconTranslateTransitionHandler")]
			get {
				const string __id = "getIconTranslateTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setIconTranslateTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setIconTranslateTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetIconTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setIconTranslateTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourceId);
		}
#pragma warning restore 0169

		public virtual unsafe string SourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getSourceId' and count(parameter)=0]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			__this.SourceLayer = sourceLayer;
		}
#pragma warning restore 0169

		public virtual unsafe string SourceLayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getSourceLayer' and count(parameter)=0]"
			[Register ("getSourceLayer", "()Ljava/lang/String;", "GetGetSourceLayerHandler")]
			get {
				const string __id = "getSourceLayer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getSymbolAvoidEdges;
#pragma warning disable 0169
		static Delegate GetGetSymbolAvoidEdgesHandler ()
		{
			if (cb_getSymbolAvoidEdges == null)
				cb_getSymbolAvoidEdges = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSymbolAvoidEdges);
			return cb_getSymbolAvoidEdges;
		}

		static IntPtr n_GetSymbolAvoidEdges (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SymbolAvoidEdges);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolAvoidEdges {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getSymbolAvoidEdges' and count(parameter)=0]"
			[Register ("getSymbolAvoidEdges", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetSymbolAvoidEdgesHandler")]
			get {
				const string __id = "getSymbolAvoidEdges.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSymbolPlacement;
#pragma warning disable 0169
		static Delegate GetGetSymbolPlacementHandler ()
		{
			if (cb_getSymbolPlacement == null)
				cb_getSymbolPlacement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSymbolPlacement);
			return cb_getSymbolPlacement;
		}

		static IntPtr n_GetSymbolPlacement (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SymbolPlacement);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolPlacement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getSymbolPlacement' and count(parameter)=0]"
			[Register ("getSymbolPlacement", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetSymbolPlacementHandler")]
			get {
				const string __id = "getSymbolPlacement.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSymbolSortKey;
#pragma warning disable 0169
		static Delegate GetGetSymbolSortKeyHandler ()
		{
			if (cb_getSymbolSortKey == null)
				cb_getSymbolSortKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSymbolSortKey);
			return cb_getSymbolSortKey;
		}

		static IntPtr n_GetSymbolSortKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SymbolSortKey);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolSortKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getSymbolSortKey' and count(parameter)=0]"
			[Register ("getSymbolSortKey", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetSymbolSortKeyHandler")]
			get {
				const string __id = "getSymbolSortKey.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSymbolSpacing;
#pragma warning disable 0169
		static Delegate GetGetSymbolSpacingHandler ()
		{
			if (cb_getSymbolSpacing == null)
				cb_getSymbolSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSymbolSpacing);
			return cb_getSymbolSpacing;
		}

		static IntPtr n_GetSymbolSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SymbolSpacing);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getSymbolSpacing' and count(parameter)=0]"
			[Register ("getSymbolSpacing", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetSymbolSpacingHandler")]
			get {
				const string __id = "getSymbolSpacing.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSymbolZOrder;
#pragma warning disable 0169
		static Delegate GetGetSymbolZOrderHandler ()
		{
			if (cb_getSymbolZOrder == null)
				cb_getSymbolZOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSymbolZOrder);
			return cb_getSymbolZOrder;
		}

		static IntPtr n_GetSymbolZOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SymbolZOrder);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolZOrder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getSymbolZOrder' and count(parameter)=0]"
			[Register ("getSymbolZOrder", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetSymbolZOrderHandler")]
			get {
				const string __id = "getSymbolZOrder.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextAllowOverlap;
#pragma warning disable 0169
		static Delegate GetGetTextAllowOverlapHandler ()
		{
			if (cb_getTextAllowOverlap == null)
				cb_getTextAllowOverlap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextAllowOverlap);
			return cb_getTextAllowOverlap;
		}

		static IntPtr n_GetTextAllowOverlap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextAllowOverlap);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextAllowOverlap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextAllowOverlap' and count(parameter)=0]"
			[Register ("getTextAllowOverlap", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextAllowOverlapHandler")]
			get {
				const string __id = "getTextAllowOverlap.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextAnchor;
#pragma warning disable 0169
		static Delegate GetGetTextAnchorHandler ()
		{
			if (cb_getTextAnchor == null)
				cb_getTextAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextAnchor);
			return cb_getTextAnchor;
		}

		static IntPtr n_GetTextAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextAnchor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextAnchor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextAnchor' and count(parameter)=0]"
			[Register ("getTextAnchor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextAnchorHandler")]
			get {
				const string __id = "getTextAnchor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextColor);
			return cb_getTextColor;
		}

		static IntPtr n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextColorHandler")]
			get {
				const string __id = "getTextColor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColorAsInt;
#pragma warning disable 0169
		static Delegate GetGetTextColorAsIntHandler ()
		{
			if (cb_getTextColorAsInt == null)
				cb_getTextColorAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextColorAsInt);
			return cb_getTextColorAsInt;
		}

		static int n_GetTextColorAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextColorAsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int TextColorAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextColorAsInt' and count(parameter)=0]"
			[Register ("getTextColorAsInt", "()I", "GetGetTextColorAsIntHandler")]
			get {
				const string __id = "getTextColorAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTextColorTransition;
#pragma warning disable 0169
		static Delegate GetGetTextColorTransitionHandler ()
		{
			if (cb_getTextColorTransition == null)
				cb_getTextColorTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextColorTransition);
			return cb_getTextColorTransition;
		}

		static IntPtr n_GetTextColorTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextColorTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setTextColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetTextColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setTextColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setTextColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setTextColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetTextColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.TextColorTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions TextColorTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextColorTransition' and count(parameter)=0]"
			[Register ("getTextColorTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetTextColorTransitionHandler")]
			get {
				const string __id = "getTextColorTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setTextColorTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setTextColorTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetTextColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setTextColorTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextField;
#pragma warning disable 0169
		static Delegate GetGetTextFieldHandler ()
		{
			if (cb_getTextField == null)
				cb_getTextField = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextField);
			return cb_getTextField;
		}

		static IntPtr n_GetTextField (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextField);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextField {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextField' and count(parameter)=0]"
			[Register ("getTextField", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextFieldHandler")]
			get {
				const string __id = "getTextField.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextFont;
#pragma warning disable 0169
		static Delegate GetGetTextFontHandler ()
		{
			if (cb_getTextFont == null)
				cb_getTextFont = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextFont);
			return cb_getTextFont;
		}

		static IntPtr n_GetTextFont (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextFont);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextFont {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextFont' and count(parameter)=0]"
			[Register ("getTextFont", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextFontHandler")]
			get {
				const string __id = "getTextFont.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextHaloBlur;
#pragma warning disable 0169
		static Delegate GetGetTextHaloBlurHandler ()
		{
			if (cb_getTextHaloBlur == null)
				cb_getTextHaloBlur = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextHaloBlur);
			return cb_getTextHaloBlur;
		}

		static IntPtr n_GetTextHaloBlur (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextHaloBlur);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloBlur {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextHaloBlur' and count(parameter)=0]"
			[Register ("getTextHaloBlur", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextHaloBlurHandler")]
			get {
				const string __id = "getTextHaloBlur.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextHaloBlurTransition;
#pragma warning disable 0169
		static Delegate GetGetTextHaloBlurTransitionHandler ()
		{
			if (cb_getTextHaloBlurTransition == null)
				cb_getTextHaloBlurTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextHaloBlurTransition);
			return cb_getTextHaloBlurTransition;
		}

		static IntPtr n_GetTextHaloBlurTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextHaloBlurTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setTextHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetTextHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setTextHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setTextHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setTextHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetTextHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.TextHaloBlurTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions TextHaloBlurTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextHaloBlurTransition' and count(parameter)=0]"
			[Register ("getTextHaloBlurTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetTextHaloBlurTransitionHandler")]
			get {
				const string __id = "getTextHaloBlurTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setTextHaloBlurTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setTextHaloBlurTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetTextHaloBlurTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setTextHaloBlurTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextHaloColor;
#pragma warning disable 0169
		static Delegate GetGetTextHaloColorHandler ()
		{
			if (cb_getTextHaloColor == null)
				cb_getTextHaloColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextHaloColor);
			return cb_getTextHaloColor;
		}

		static IntPtr n_GetTextHaloColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextHaloColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextHaloColor' and count(parameter)=0]"
			[Register ("getTextHaloColor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextHaloColorHandler")]
			get {
				const string __id = "getTextHaloColor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextHaloColorAsInt;
#pragma warning disable 0169
		static Delegate GetGetTextHaloColorAsIntHandler ()
		{
			if (cb_getTextHaloColorAsInt == null)
				cb_getTextHaloColorAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextHaloColorAsInt);
			return cb_getTextHaloColorAsInt;
		}

		static int n_GetTextHaloColorAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextHaloColorAsInt;
		}
#pragma warning restore 0169

		public virtual unsafe int TextHaloColorAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextHaloColorAsInt' and count(parameter)=0]"
			[Register ("getTextHaloColorAsInt", "()I", "GetGetTextHaloColorAsIntHandler")]
			get {
				const string __id = "getTextHaloColorAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTextHaloColorTransition;
#pragma warning disable 0169
		static Delegate GetGetTextHaloColorTransitionHandler ()
		{
			if (cb_getTextHaloColorTransition == null)
				cb_getTextHaloColorTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextHaloColorTransition);
			return cb_getTextHaloColorTransition;
		}

		static IntPtr n_GetTextHaloColorTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextHaloColorTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setTextHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetTextHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setTextHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setTextHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setTextHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetTextHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.TextHaloColorTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions TextHaloColorTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextHaloColorTransition' and count(parameter)=0]"
			[Register ("getTextHaloColorTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetTextHaloColorTransitionHandler")]
			get {
				const string __id = "getTextHaloColorTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setTextHaloColorTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setTextHaloColorTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetTextHaloColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setTextHaloColorTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextHaloWidth;
#pragma warning disable 0169
		static Delegate GetGetTextHaloWidthHandler ()
		{
			if (cb_getTextHaloWidth == null)
				cb_getTextHaloWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextHaloWidth);
			return cb_getTextHaloWidth;
		}

		static IntPtr n_GetTextHaloWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextHaloWidth);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextHaloWidth' and count(parameter)=0]"
			[Register ("getTextHaloWidth", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextHaloWidthHandler")]
			get {
				const string __id = "getTextHaloWidth.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextHaloWidthTransition;
#pragma warning disable 0169
		static Delegate GetGetTextHaloWidthTransitionHandler ()
		{
			if (cb_getTextHaloWidthTransition == null)
				cb_getTextHaloWidthTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextHaloWidthTransition);
			return cb_getTextHaloWidthTransition;
		}

		static IntPtr n_GetTextHaloWidthTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextHaloWidthTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setTextHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetTextHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setTextHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setTextHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setTextHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetTextHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.TextHaloWidthTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions TextHaloWidthTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextHaloWidthTransition' and count(parameter)=0]"
			[Register ("getTextHaloWidthTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetTextHaloWidthTransitionHandler")]
			get {
				const string __id = "getTextHaloWidthTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setTextHaloWidthTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setTextHaloWidthTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetTextHaloWidthTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setTextHaloWidthTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextIgnorePlacement;
#pragma warning disable 0169
		static Delegate GetGetTextIgnorePlacementHandler ()
		{
			if (cb_getTextIgnorePlacement == null)
				cb_getTextIgnorePlacement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextIgnorePlacement);
			return cb_getTextIgnorePlacement;
		}

		static IntPtr n_GetTextIgnorePlacement (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextIgnorePlacement);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextIgnorePlacement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextIgnorePlacement' and count(parameter)=0]"
			[Register ("getTextIgnorePlacement", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextIgnorePlacementHandler")]
			get {
				const string __id = "getTextIgnorePlacement.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextJustify;
#pragma warning disable 0169
		static Delegate GetGetTextJustifyHandler ()
		{
			if (cb_getTextJustify == null)
				cb_getTextJustify = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextJustify);
			return cb_getTextJustify;
		}

		static IntPtr n_GetTextJustify (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextJustify);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextJustify {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextJustify' and count(parameter)=0]"
			[Register ("getTextJustify", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextJustifyHandler")]
			get {
				const string __id = "getTextJustify.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextKeepUpright;
#pragma warning disable 0169
		static Delegate GetGetTextKeepUprightHandler ()
		{
			if (cb_getTextKeepUpright == null)
				cb_getTextKeepUpright = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextKeepUpright);
			return cb_getTextKeepUpright;
		}

		static IntPtr n_GetTextKeepUpright (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextKeepUpright);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextKeepUpright {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextKeepUpright' and count(parameter)=0]"
			[Register ("getTextKeepUpright", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextKeepUprightHandler")]
			get {
				const string __id = "getTextKeepUpright.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextLetterSpacing;
#pragma warning disable 0169
		static Delegate GetGetTextLetterSpacingHandler ()
		{
			if (cb_getTextLetterSpacing == null)
				cb_getTextLetterSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextLetterSpacing);
			return cb_getTextLetterSpacing;
		}

		static IntPtr n_GetTextLetterSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextLetterSpacing);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextLetterSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextLetterSpacing' and count(parameter)=0]"
			[Register ("getTextLetterSpacing", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextLetterSpacingHandler")]
			get {
				const string __id = "getTextLetterSpacing.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextLineHeight;
#pragma warning disable 0169
		static Delegate GetGetTextLineHeightHandler ()
		{
			if (cb_getTextLineHeight == null)
				cb_getTextLineHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextLineHeight);
			return cb_getTextLineHeight;
		}

		static IntPtr n_GetTextLineHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextLineHeight);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextLineHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextLineHeight' and count(parameter)=0]"
			[Register ("getTextLineHeight", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextLineHeightHandler")]
			get {
				const string __id = "getTextLineHeight.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextMaxAngle;
#pragma warning disable 0169
		static Delegate GetGetTextMaxAngleHandler ()
		{
			if (cb_getTextMaxAngle == null)
				cb_getTextMaxAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextMaxAngle);
			return cb_getTextMaxAngle;
		}

		static IntPtr n_GetTextMaxAngle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextMaxAngle);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextMaxAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextMaxAngle' and count(parameter)=0]"
			[Register ("getTextMaxAngle", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextMaxAngleHandler")]
			get {
				const string __id = "getTextMaxAngle.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextMaxWidth;
#pragma warning disable 0169
		static Delegate GetGetTextMaxWidthHandler ()
		{
			if (cb_getTextMaxWidth == null)
				cb_getTextMaxWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextMaxWidth);
			return cb_getTextMaxWidth;
		}

		static IntPtr n_GetTextMaxWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextMaxWidth);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextMaxWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextMaxWidth' and count(parameter)=0]"
			[Register ("getTextMaxWidth", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextMaxWidthHandler")]
			get {
				const string __id = "getTextMaxWidth.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextOffset;
#pragma warning disable 0169
		static Delegate GetGetTextOffsetHandler ()
		{
			if (cb_getTextOffset == null)
				cb_getTextOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextOffset);
			return cb_getTextOffset;
		}

		static IntPtr n_GetTextOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextOffset);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextOffset' and count(parameter)=0]"
			[Register ("getTextOffset", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextOffsetHandler")]
			get {
				const string __id = "getTextOffset.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextOpacity;
#pragma warning disable 0169
		static Delegate GetGetTextOpacityHandler ()
		{
			if (cb_getTextOpacity == null)
				cb_getTextOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextOpacity);
			return cb_getTextOpacity;
		}

		static IntPtr n_GetTextOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextOpacity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextOpacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextOpacity' and count(parameter)=0]"
			[Register ("getTextOpacity", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextOpacityHandler")]
			get {
				const string __id = "getTextOpacity.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextOpacityTransition;
#pragma warning disable 0169
		static Delegate GetGetTextOpacityTransitionHandler ()
		{
			if (cb_getTextOpacityTransition == null)
				cb_getTextOpacityTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextOpacityTransition);
			return cb_getTextOpacityTransition;
		}

		static IntPtr n_GetTextOpacityTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextOpacityTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setTextOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetTextOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setTextOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setTextOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setTextOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetTextOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.TextOpacityTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions TextOpacityTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextOpacityTransition' and count(parameter)=0]"
			[Register ("getTextOpacityTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetTextOpacityTransitionHandler")]
			get {
				const string __id = "getTextOpacityTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setTextOpacityTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setTextOpacityTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetTextOpacityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setTextOpacityTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextOptional;
#pragma warning disable 0169
		static Delegate GetGetTextOptionalHandler ()
		{
			if (cb_getTextOptional == null)
				cb_getTextOptional = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextOptional);
			return cb_getTextOptional;
		}

		static IntPtr n_GetTextOptional (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextOptional);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextOptional {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextOptional' and count(parameter)=0]"
			[Register ("getTextOptional", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextOptionalHandler")]
			get {
				const string __id = "getTextOptional.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextPadding;
#pragma warning disable 0169
		static Delegate GetGetTextPaddingHandler ()
		{
			if (cb_getTextPadding == null)
				cb_getTextPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextPadding);
			return cb_getTextPadding;
		}

		static IntPtr n_GetTextPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextPadding);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextPadding' and count(parameter)=0]"
			[Register ("getTextPadding", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextPaddingHandler")]
			get {
				const string __id = "getTextPadding.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextPitchAlignment;
#pragma warning disable 0169
		static Delegate GetGetTextPitchAlignmentHandler ()
		{
			if (cb_getTextPitchAlignment == null)
				cb_getTextPitchAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextPitchAlignment);
			return cb_getTextPitchAlignment;
		}

		static IntPtr n_GetTextPitchAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextPitchAlignment);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextPitchAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextPitchAlignment' and count(parameter)=0]"
			[Register ("getTextPitchAlignment", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextPitchAlignmentHandler")]
			get {
				const string __id = "getTextPitchAlignment.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextRadialOffset;
#pragma warning disable 0169
		static Delegate GetGetTextRadialOffsetHandler ()
		{
			if (cb_getTextRadialOffset == null)
				cb_getTextRadialOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextRadialOffset);
			return cb_getTextRadialOffset;
		}

		static IntPtr n_GetTextRadialOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextRadialOffset);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextRadialOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextRadialOffset' and count(parameter)=0]"
			[Register ("getTextRadialOffset", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextRadialOffsetHandler")]
			get {
				const string __id = "getTextRadialOffset.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextRotate;
#pragma warning disable 0169
		static Delegate GetGetTextRotateHandler ()
		{
			if (cb_getTextRotate == null)
				cb_getTextRotate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextRotate);
			return cb_getTextRotate;
		}

		static IntPtr n_GetTextRotate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextRotate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextRotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextRotate' and count(parameter)=0]"
			[Register ("getTextRotate", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextRotateHandler")]
			get {
				const string __id = "getTextRotate.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextRotationAlignment;
#pragma warning disable 0169
		static Delegate GetGetTextRotationAlignmentHandler ()
		{
			if (cb_getTextRotationAlignment == null)
				cb_getTextRotationAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextRotationAlignment);
			return cb_getTextRotationAlignment;
		}

		static IntPtr n_GetTextRotationAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextRotationAlignment);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextRotationAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextRotationAlignment' and count(parameter)=0]"
			[Register ("getTextRotationAlignment", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextRotationAlignmentHandler")]
			get {
				const string __id = "getTextRotationAlignment.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextSize;
#pragma warning disable 0169
		static Delegate GetGetTextSizeHandler ()
		{
			if (cb_getTextSize == null)
				cb_getTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextSize);
			return cb_getTextSize;
		}

		static IntPtr n_GetTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextSize);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextSize' and count(parameter)=0]"
			[Register ("getTextSize", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextSizeHandler")]
			get {
				const string __id = "getTextSize.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextTransform;
#pragma warning disable 0169
		static Delegate GetGetTextTransformHandler ()
		{
			if (cb_getTextTransform == null)
				cb_getTextTransform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextTransform);
			return cb_getTextTransform;
		}

		static IntPtr n_GetTextTransform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextTransform);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextTransform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextTransform' and count(parameter)=0]"
			[Register ("getTextTransform", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextTransformHandler")]
			get {
				const string __id = "getTextTransform.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextTranslate;
#pragma warning disable 0169
		static Delegate GetGetTextTranslateHandler ()
		{
			if (cb_getTextTranslate == null)
				cb_getTextTranslate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextTranslate);
			return cb_getTextTranslate;
		}

		static IntPtr n_GetTextTranslate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextTranslate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextTranslate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextTranslate' and count(parameter)=0]"
			[Register ("getTextTranslate", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextTranslateHandler")]
			get {
				const string __id = "getTextTranslate.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextTranslateAnchor;
#pragma warning disable 0169
		static Delegate GetGetTextTranslateAnchorHandler ()
		{
			if (cb_getTextTranslateAnchor == null)
				cb_getTextTranslateAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextTranslateAnchor);
			return cb_getTextTranslateAnchor;
		}

		static IntPtr n_GetTextTranslateAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextTranslateAnchor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextTranslateAnchor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextTranslateAnchor' and count(parameter)=0]"
			[Register ("getTextTranslateAnchor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextTranslateAnchorHandler")]
			get {
				const string __id = "getTextTranslateAnchor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextTranslateTransition;
#pragma warning disable 0169
		static Delegate GetGetTextTranslateTransitionHandler ()
		{
			if (cb_getTextTranslateTransition == null)
				cb_getTextTranslateTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextTranslateTransition);
			return cb_getTextTranslateTransition;
		}

		static IntPtr n_GetTextTranslateTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextTranslateTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setTextTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetTextTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setTextTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setTextTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setTextTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetTextTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.TextTranslateTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions TextTranslateTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextTranslateTransition' and count(parameter)=0]"
			[Register ("getTextTranslateTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetTextTranslateTransitionHandler")]
			get {
				const string __id = "getTextTranslateTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='setTextTranslateTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setTextTranslateTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetTextTranslateTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setTextTranslateTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextVariableAnchor;
#pragma warning disable 0169
		static Delegate GetGetTextVariableAnchorHandler ()
		{
			if (cb_getTextVariableAnchor == null)
				cb_getTextVariableAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextVariableAnchor);
			return cb_getTextVariableAnchor;
		}

		static IntPtr n_GetTextVariableAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextVariableAnchor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextVariableAnchor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextVariableAnchor' and count(parameter)=0]"
			[Register ("getTextVariableAnchor", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextVariableAnchorHandler")]
			get {
				const string __id = "getTextVariableAnchor.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextWritingMode;
#pragma warning disable 0169
		static Delegate GetGetTextWritingModeHandler ()
		{
			if (cb_getTextWritingMode == null)
				cb_getTextWritingMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextWritingMode);
			return cb_getTextWritingMode;
		}

		static IntPtr n_GetTextWritingMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextWritingMode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextWritingMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='getTextWritingMode' and count(parameter)=0]"
			[Register ("getTextWritingMode", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetTextWritingModeHandler")]
			get {
				const string __id = "getTextWritingMode.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFilter (filter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='withFilter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("withFilter", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/SymbolLayer;", "GetWithFilter_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer WithFilter (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression filter)
		{
			const string __id = "withFilter.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/SymbolLayer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties = (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[]) JNIEnv.GetArray (native_properties, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithProperties (properties));
			if (properties != null)
				JNIEnv.CopyArray (properties, native_properties);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='withProperties' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.PropertyValue&lt;?&gt;...']]"
		[Register ("withProperties", "([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/SymbolLayer;", "GetWithProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer WithProperties (params global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties)
		{
			const string __id = "withProperties.([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)Lcom/mapbox/mapboxsdk/style/layers/SymbolLayer;";
			IntPtr native_properties = JNIEnv.NewArray (properties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_properties);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceLayer = JNIEnv.GetString (native_sourceLayer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSourceLayer (sourceLayer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='SymbolLayer']/method[@name='withSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSourceLayer", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/SymbolLayer;", "GetWithSourceLayer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer WithSourceLayer (string sourceLayer)
		{
			const string __id = "withSourceLayer.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/SymbolLayer;";
			IntPtr native_sourceLayer = JNIEnv.NewString (sourceLayer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourceLayer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.SymbolLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceLayer);
			}
		}

	}
}
