using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/TileSet", DoNotGenerateAcw=true)]
	public partial class TileSet : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/TileSet", typeof (TileSet));
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

		protected TileSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/constructor[@name='TileSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register (".ctor", "(Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe TileSet (string tilejson, params string[] tiles)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tilejson = JNIEnv.NewString (tilejson);
			IntPtr native_tiles = JNIEnv.NewArray (tiles);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tilejson);
				__args [1] = new JniArgumentValue (native_tiles);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tilejson);
				if (tiles != null) {
					JNIEnv.CopyArray (native_tiles, tiles);
					JNIEnv.DeleteLocalRef (native_tiles);
				}
			}
		}

		static Delegate cb_getAttribution;
#pragma warning disable 0169
		static Delegate GetGetAttributionHandler ()
		{
			if (cb_getAttribution == null)
				cb_getAttribution = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttribution);
			return cb_getAttribution;
		}

		static IntPtr n_GetAttribution (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Attribution);
		}
#pragma warning restore 0169

		static Delegate cb_setAttribution_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAttribution_Ljava_lang_String_Handler ()
		{
			if (cb_setAttribution_Ljava_lang_String_ == null)
				cb_setAttribution_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAttribution_Ljava_lang_String_);
			return cb_setAttribution_Ljava_lang_String_;
		}

		static void n_SetAttribution_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attribution)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string attribution = JNIEnv.GetString (native_attribution, JniHandleOwnership.DoNotTransfer);
			__this.Attribution = attribution;
		}
#pragma warning restore 0169

		public virtual unsafe string Attribution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getAttribution' and count(parameter)=0]"
			[Register ("getAttribution", "()Ljava/lang/String;", "GetGetAttributionHandler")]
			get {
				const string __id = "getAttribution.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setAttribution' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAttribution", "(Ljava/lang/String;)V", "GetSetAttribution_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAttribution.(Ljava/lang/String;)V";
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

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
			__this.Description = description;
		}
#pragma warning restore 0169

		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				const string __id = "getDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDescription.(Ljava/lang/String;)V";
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

		static Delegate cb_getEncoding;
#pragma warning disable 0169
		static Delegate GetGetEncodingHandler ()
		{
			if (cb_getEncoding == null)
				cb_getEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncoding);
			return cb_getEncoding;
		}

		static IntPtr n_GetEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Encoding);
		}
#pragma warning restore 0169

		static Delegate cb_setEncoding_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncoding_Ljava_lang_String_Handler ()
		{
			if (cb_setEncoding_Ljava_lang_String_ == null)
				cb_setEncoding_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncoding_Ljava_lang_String_);
			return cb_setEncoding_Ljava_lang_String_;
		}

		static void n_SetEncoding_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encoding)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string encoding = JNIEnv.GetString (native_encoding, JniHandleOwnership.DoNotTransfer);
			__this.Encoding = encoding;
		}
#pragma warning restore 0169

		public virtual unsafe string Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/lang/String;", "GetGetEncodingHandler")]
			get {
				const string __id = "getEncoding.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEncoding", "(Ljava/lang/String;)V", "GetSetEncoding_Ljava_lang_String_Handler")]
			set {
				const string __id = "setEncoding.(Ljava/lang/String;)V";
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

		static Delegate cb_getLegend;
#pragma warning disable 0169
		static Delegate GetGetLegendHandler ()
		{
			if (cb_getLegend == null)
				cb_getLegend = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLegend);
			return cb_getLegend;
		}

		static IntPtr n_GetLegend (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Legend);
		}
#pragma warning restore 0169

		static Delegate cb_setLegend_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLegend_Ljava_lang_String_Handler ()
		{
			if (cb_setLegend_Ljava_lang_String_ == null)
				cb_setLegend_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLegend_Ljava_lang_String_);
			return cb_setLegend_Ljava_lang_String_;
		}

		static void n_SetLegend_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_legend)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string legend = JNIEnv.GetString (native_legend, JniHandleOwnership.DoNotTransfer);
			__this.Legend = legend;
		}
#pragma warning restore 0169

		public virtual unsafe string Legend {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getLegend' and count(parameter)=0]"
			[Register ("getLegend", "()Ljava/lang/String;", "GetGetLegendHandler")]
			get {
				const string __id = "getLegend.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setLegend' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLegend", "(Ljava/lang/String;)V", "GetSetLegend_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLegend.(Ljava/lang/String;)V";
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

		static Delegate cb_getMaxZoom;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomHandler ()
		{
			if (cb_getMaxZoom == null)
				cb_getMaxZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxZoom);
			return cb_getMaxZoom;
		}

		static float n_GetMaxZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoom;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxZoom_F;
#pragma warning disable 0169
		static Delegate GetSetMaxZoom_FHandler ()
		{
			if (cb_setMaxZoom_F == null)
				cb_setMaxZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxZoom_F);
			return cb_setMaxZoom_F;
		}

		static void n_SetMaxZoom_F (IntPtr jnienv, IntPtr native__this, float maxZoom)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxZoom = maxZoom;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getMaxZoom' and count(parameter)=0]"
			[Register ("getMaxZoom", "()F", "GetGetMaxZoomHandler")]
			get {
				const string __id = "getMaxZoom.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setMaxZoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxZoom", "(F)V", "GetSetMaxZoom_FHandler")]
			set {
				const string __id = "setMaxZoom.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinZoom;
#pragma warning disable 0169
		static Delegate GetGetMinZoomHandler ()
		{
			if (cb_getMinZoom == null)
				cb_getMinZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinZoom);
			return cb_getMinZoom;
		}

		static float n_GetMinZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoom;
		}
#pragma warning restore 0169

		static Delegate cb_setMinZoom_F;
#pragma warning disable 0169
		static Delegate GetSetMinZoom_FHandler ()
		{
			if (cb_setMinZoom_F == null)
				cb_setMinZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinZoom_F);
			return cb_setMinZoom_F;
		}

		static void n_SetMinZoom_F (IntPtr jnienv, IntPtr native__this, float minZoom)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinZoom = minZoom;
		}
#pragma warning restore 0169

		public virtual unsafe float MinZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getMinZoom' and count(parameter)=0]"
			[Register ("getMinZoom", "()F", "GetGetMinZoomHandler")]
			get {
				const string __id = "getMinZoom.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setMinZoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinZoom", "(F)V", "GetSetMinZoom_FHandler")]
			set {
				const string __id = "setMinZoom.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Name = name;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
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

		static Delegate cb_getScheme;
#pragma warning disable 0169
		static Delegate GetGetSchemeHandler ()
		{
			if (cb_getScheme == null)
				cb_getScheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScheme);
			return cb_getScheme;
		}

		static IntPtr n_GetScheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scheme);
		}
#pragma warning restore 0169

		static Delegate cb_setScheme_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScheme_Ljava_lang_String_Handler ()
		{
			if (cb_setScheme_Ljava_lang_String_ == null)
				cb_setScheme_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScheme_Ljava_lang_String_);
			return cb_setScheme_Ljava_lang_String_;
		}

		static void n_SetScheme_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scheme)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string scheme = JNIEnv.GetString (native_scheme, JniHandleOwnership.DoNotTransfer);
			__this.Scheme = scheme;
		}
#pragma warning restore 0169

		public virtual unsafe string Scheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getScheme' and count(parameter)=0]"
			[Register ("getScheme", "()Ljava/lang/String;", "GetGetSchemeHandler")]
			get {
				const string __id = "getScheme.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScheme", "(Ljava/lang/String;)V", "GetSetScheme_Ljava_lang_String_Handler")]
			set {
				const string __id = "setScheme.(Ljava/lang/String;)V";
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

		static Delegate cb_getTemplate;
#pragma warning disable 0169
		static Delegate GetGetTemplateHandler ()
		{
			if (cb_getTemplate == null)
				cb_getTemplate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTemplate);
			return cb_getTemplate;
		}

		static IntPtr n_GetTemplate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Template);
		}
#pragma warning restore 0169

		static Delegate cb_setTemplate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTemplate_Ljava_lang_String_Handler ()
		{
			if (cb_setTemplate_Ljava_lang_String_ == null)
				cb_setTemplate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTemplate_Ljava_lang_String_);
			return cb_setTemplate_Ljava_lang_String_;
		}

		static void n_SetTemplate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_template)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string template = JNIEnv.GetString (native_template, JniHandleOwnership.DoNotTransfer);
			__this.Template = template;
		}
#pragma warning restore 0169

		public virtual unsafe string Template {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getTemplate' and count(parameter)=0]"
			[Register ("getTemplate", "()Ljava/lang/String;", "GetGetTemplateHandler")]
			get {
				const string __id = "getTemplate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setTemplate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTemplate", "(Ljava/lang/String;)V", "GetSetTemplate_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTemplate.(Ljava/lang/String;)V";
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

		static Delegate cb_getTilejson;
#pragma warning disable 0169
		static Delegate GetGetTilejsonHandler ()
		{
			if (cb_getTilejson == null)
				cb_getTilejson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTilejson);
			return cb_getTilejson;
		}

		static IntPtr n_GetTilejson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tilejson);
		}
#pragma warning restore 0169

		public virtual unsafe string Tilejson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getTilejson' and count(parameter)=0]"
			[Register ("getTilejson", "()Ljava/lang/String;", "GetGetTilejsonHandler")]
			get {
				const string __id = "getTilejson.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setVersion_Ljava_lang_String_ == null)
				cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVersion_Ljava_lang_String_);
			return cb_setVersion_Ljava_lang_String_;
		}

		static void n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_version)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string version = JNIEnv.GetString (native_version, JniHandleOwnership.DoNotTransfer);
			__this.Version = version;
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVersion.(Ljava/lang/String;)V";
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

		static Delegate cb_getBounds;
#pragma warning disable 0169
		static Delegate GetGetBoundsHandler ()
		{
			if (cb_getBounds == null)
				cb_getBounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBounds);
			return cb_getBounds;
		}

		static IntPtr n_GetBounds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBounds ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getBounds' and count(parameter)=0]"
		[Register ("getBounds", "()[Ljava/lang/Float;", "GetGetBoundsHandler")]
		public virtual unsafe global::Java.Lang.Float[] GetBounds ()
		{
			const string __id = "getBounds.()[Ljava/lang/Float;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Float));
			} finally {
			}
		}

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCenter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getCenter' and count(parameter)=0]"
		[Register ("getCenter", "()[Ljava/lang/Float;", "GetGetCenterHandler")]
		public virtual unsafe global::Java.Lang.Float[] GetCenter ()
		{
			const string __id = "getCenter.()[Ljava/lang/Float;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Float));
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[Ljava/lang/String;", "GetGetDataHandler")]
		public virtual unsafe string[] GetData ()
		{
			const string __id = "getData.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getGrids;
#pragma warning disable 0169
		static Delegate GetGetGridsHandler ()
		{
			if (cb_getGrids == null)
				cb_getGrids = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGrids);
			return cb_getGrids;
		}

		static IntPtr n_GetGrids (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGrids ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getGrids' and count(parameter)=0]"
		[Register ("getGrids", "()[Ljava/lang/String;", "GetGetGridsHandler")]
		public virtual unsafe string[] GetGrids ()
		{
			const string __id = "getGrids.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getTiles;
#pragma warning disable 0169
		static Delegate GetGetTilesHandler ()
		{
			if (cb_getTiles == null)
				cb_getTiles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTiles);
			return cb_getTiles;
		}

		static IntPtr n_GetTiles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTiles ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='getTiles' and count(parameter)=0]"
		[Register ("getTiles", "()[Ljava/lang/String;", "GetGetTilesHandler")]
		public virtual unsafe string[] GetTiles ()
		{
			const string __id = "getTiles.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setBounds_arrayLjava_lang_Float_;
#pragma warning disable 0169
		static Delegate GetSetBounds_arrayLjava_lang_Float_Handler ()
		{
			if (cb_setBounds_arrayLjava_lang_Float_ == null)
				cb_setBounds_arrayLjava_lang_Float_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBounds_arrayLjava_lang_Float_);
			return cb_setBounds_arrayLjava_lang_Float_;
		}

		static void n_SetBounds_arrayLjava_lang_Float_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Float[] bounds = (global::Java.Lang.Float[]) JNIEnv.GetArray (native_bounds, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Float));
			__this.SetBounds (bounds);
			if (bounds != null)
				JNIEnv.CopyArray (bounds, native_bounds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setBounds' and count(parameter)=1 and parameter[1][@type='java.lang.Float...']]"
		[Register ("setBounds", "([Ljava/lang/Float;)V", "GetSetBounds_arrayLjava_lang_Float_Handler")]
		public virtual unsafe void SetBounds (params global::Java.Lang.Float[] bounds)
		{
			const string __id = "setBounds.([Ljava/lang/Float;)V";
			IntPtr native_bounds = JNIEnv.NewArray (bounds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bounds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bounds != null) {
					JNIEnv.CopyArray (native_bounds, bounds);
					JNIEnv.DeleteLocalRef (native_bounds);
				}
			}
		}

		static Delegate cb_setCenter_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetCenter_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_setCenter_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_setCenter_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_setCenter_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static void n_SetCenter_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_center)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng center = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_center, JniHandleOwnership.DoNotTransfer);
			__this.SetCenter (center);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("setCenter", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)V", "GetSetCenter_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe void SetCenter (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng center)
		{
			const string __id = "setCenter.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((center == null) ? IntPtr.Zero : ((global::Java.Lang.Object) center).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCenter_arrayLjava_lang_Float_;
#pragma warning disable 0169
		static Delegate GetSetCenter_arrayLjava_lang_Float_Handler ()
		{
			if (cb_setCenter_arrayLjava_lang_Float_ == null)
				cb_setCenter_arrayLjava_lang_Float_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_arrayLjava_lang_Float_);
			return cb_setCenter_arrayLjava_lang_Float_;
		}

		static void n_SetCenter_arrayLjava_lang_Float_ (IntPtr jnienv, IntPtr native__this, IntPtr native_center)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Float[] center = (global::Java.Lang.Float[]) JNIEnv.GetArray (native_center, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Float));
			__this.SetCenter (center);
			if (center != null)
				JNIEnv.CopyArray (center, native_center);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='java.lang.Float...']]"
		[Register ("setCenter", "([Ljava/lang/Float;)V", "GetSetCenter_arrayLjava_lang_Float_Handler")]
		public virtual unsafe void SetCenter (params global::Java.Lang.Float[] center)
		{
			const string __id = "setCenter.([Ljava/lang/Float;)V";
			IntPtr native_center = JNIEnv.NewArray (center);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_center);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (center != null) {
					JNIEnv.CopyArray (native_center, center);
					JNIEnv.DeleteLocalRef (native_center);
				}
			}
		}

		static Delegate cb_setData_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetData_arrayLjava_lang_String_Handler ()
		{
			if (cb_setData_arrayLjava_lang_String_ == null)
				cb_setData_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_arrayLjava_lang_String_);
			return cb_setData_arrayLjava_lang_String_;
		}

		static void n_SetData_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] data = (string[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetData (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setData", "([Ljava/lang/String;)V", "GetSetData_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetData (params string[] data)
		{
			const string __id = "setData.([Ljava/lang/String;)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_setGrids_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGrids_arrayLjava_lang_String_Handler ()
		{
			if (cb_setGrids_arrayLjava_lang_String_ == null)
				cb_setGrids_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGrids_arrayLjava_lang_String_);
			return cb_setGrids_arrayLjava_lang_String_;
		}

		static void n_SetGrids_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_grids)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] grids = (string[]) JNIEnv.GetArray (native_grids, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetGrids (grids);
			if (grids != null)
				JNIEnv.CopyArray (grids, native_grids);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='TileSet']/method[@name='setGrids' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setGrids", "([Ljava/lang/String;)V", "GetSetGrids_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetGrids (params string[] grids)
		{
			const string __id = "setGrids.([Ljava/lang/String;)V";
			IntPtr native_grids = JNIEnv.NewArray (grids);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_grids);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (grids != null) {
					JNIEnv.CopyArray (native_grids, grids);
					JNIEnv.DeleteLocalRef (native_grids);
				}
			}
		}

	}
}
