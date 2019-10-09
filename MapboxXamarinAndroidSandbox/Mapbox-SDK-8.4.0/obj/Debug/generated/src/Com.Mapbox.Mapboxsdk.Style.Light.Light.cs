using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Light {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/light/Light", DoNotGenerateAcw=true)]
	public partial class Light : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/light/Light", typeof (Light));
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

		protected Light (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAnchor;
#pragma warning disable 0169
		static Delegate GetGetAnchorHandler ()
		{
			if (cb_getAnchor == null)
				cb_getAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnchor);
			return cb_getAnchor;
		}

		static IntPtr n_GetAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Anchor);
		}
#pragma warning restore 0169

		static Delegate cb_setAnchor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAnchor_Ljava_lang_String_Handler ()
		{
			if (cb_setAnchor_Ljava_lang_String_ == null)
				cb_setAnchor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnchor_Ljava_lang_String_);
			return cb_setAnchor_Ljava_lang_String_;
		}

		static void n_SetAnchor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_anchor)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string anchor = JNIEnv.GetString (native_anchor, JniHandleOwnership.DoNotTransfer);
			__this.Anchor = anchor;
		}
#pragma warning restore 0169

		[global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"AnchorMap", "AnchorViewport"})]
		public virtual unsafe string Anchor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='getAnchor' and count(parameter)=0]"
			[Register ("getAnchor", "()Ljava/lang/String;", "GetGetAnchorHandler")]
			get {
				const string __id = "getAnchor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='setAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAnchor", "(Ljava/lang/String;)V", "GetSetAnchor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAnchor.(Ljava/lang/String;)V";
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

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColor);
			return cb_getColor;
		}

		static IntPtr n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Color);
		}
#pragma warning restore 0169

		static Delegate cb_setColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetColor_Ljava_lang_String_Handler ()
		{
			if (cb_setColor_Ljava_lang_String_ == null)
				cb_setColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColor_Ljava_lang_String_);
			return cb_setColor_Ljava_lang_String_;
		}

		static void n_SetColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_color)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string color = JNIEnv.GetString (native_color, JniHandleOwnership.DoNotTransfer);
			__this.Color = color;
		}
#pragma warning restore 0169

		public virtual unsafe string Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()Ljava/lang/String;", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setColor", "(Ljava/lang/String;)V", "GetSetColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setColor.(Ljava/lang/String;)V";
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

		static Delegate cb_getColorTransition;
#pragma warning disable 0169
		static Delegate GetGetColorTransitionHandler ()
		{
			if (cb_getColorTransition == null)
				cb_getColorTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColorTransition);
			return cb_getColorTransition;
		}

		static IntPtr n_GetColorTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ColorTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.ColorTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions ColorTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='getColorTransition' and count(parameter)=0]"
			[Register ("getColorTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetColorTransitionHandler")]
			get {
				const string __id = "getColorTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='setColorTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setColorTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetColorTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setColorTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIntensity;
#pragma warning disable 0169
		static Delegate GetGetIntensityHandler ()
		{
			if (cb_getIntensity == null)
				cb_getIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIntensity);
			return cb_getIntensity;
		}

		static float n_GetIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Intensity;
		}
#pragma warning restore 0169

		static Delegate cb_setIntensity_F;
#pragma warning disable 0169
		static Delegate GetSetIntensity_FHandler ()
		{
			if (cb_setIntensity_F == null)
				cb_setIntensity_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetIntensity_F);
			return cb_setIntensity_F;
		}

		static void n_SetIntensity_F (IntPtr jnienv, IntPtr native__this, float intensity)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Intensity = intensity;
		}
#pragma warning restore 0169

		public virtual unsafe float Intensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='getIntensity' and count(parameter)=0]"
			[Register ("getIntensity", "()F", "GetGetIntensityHandler")]
			get {
				const string __id = "getIntensity.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='setIntensity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setIntensity", "(F)V", "GetSetIntensity_FHandler")]
			set {
				const string __id = "setIntensity.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIntensityTransition;
#pragma warning disable 0169
		static Delegate GetGetIntensityTransitionHandler ()
		{
			if (cb_getIntensityTransition == null)
				cb_getIntensityTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntensityTransition);
			return cb_getIntensityTransition;
		}

		static IntPtr n_GetIntensityTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IntensityTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.IntensityTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions IntensityTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='getIntensityTransition' and count(parameter)=0]"
			[Register ("getIntensityTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetIntensityTransitionHandler")]
			get {
				const string __id = "getIntensityTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='setIntensityTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setIntensityTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetIntensityTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setIntensityTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lcom_mapbox_mapboxsdk_style_light_Position_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_mapbox_mapboxsdk_style_light_Position_Handler ()
		{
			if (cb_setPosition_Lcom_mapbox_mapboxsdk_style_light_Position_ == null)
				cb_setPosition_Lcom_mapbox_mapboxsdk_style_light_Position_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lcom_mapbox_mapboxsdk_style_light_Position_);
			return cb_setPosition_Lcom_mapbox_mapboxsdk_style_light_Position_;
		}

		static void n_SetPosition_Lcom_mapbox_mapboxsdk_style_light_Position_ (IntPtr jnienv, IntPtr native__this, IntPtr native_position)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Light.Position position = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Position> (native_position, JniHandleOwnership.DoNotTransfer);
			__this.Position = position;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Light.Position Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/mapbox/mapboxsdk/style/light/Position;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/mapbox/mapboxsdk/style/light/Position;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Position> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.light.Position']]"
			[Register ("setPosition", "(Lcom/mapbox/mapboxsdk/style/light/Position;)V", "GetSetPosition_Lcom_mapbox_mapboxsdk_style_light_Position_Handler")]
			set {
				const string __id = "setPosition.(Lcom/mapbox/mapboxsdk/style/light/Position;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPositionTransition;
#pragma warning disable 0169
		static Delegate GetGetPositionTransitionHandler ()
		{
			if (cb_getPositionTransition == null)
				cb_getPositionTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPositionTransition);
			return cb_getPositionTransition;
		}

		static IntPtr n_GetPositionTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PositionTransition);
		}
#pragma warning restore 0169

		static Delegate cb_setPositionTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetPositionTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setPositionTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setPositionTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPositionTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setPositionTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetPositionTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.PositionTransition = options;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions PositionTransition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='getPositionTransition' and count(parameter)=0]"
			[Register ("getPositionTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetPositionTransitionHandler")]
			get {
				const string __id = "getPositionTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='setPositionTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setPositionTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetPositionTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setPositionTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Light.Light __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Light']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
		public virtual unsafe void SetColor (int color)
		{
			const string __id = "setColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
