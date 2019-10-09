using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/GeoJsonSource", DoNotGenerateAcw=true)]
	public partial class GeoJsonSource : global::Com.Mapbox.Mapboxsdk.Style.Sources.Source {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/GeoJsonSource", typeof (GeoJsonSource));
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

		protected GeoJsonSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/constructor[@name='GeoJsonSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe GeoJsonSource (string id)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/constructor[@name='GeoJsonSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.style.sources.GeoJsonOptions']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;)V", "")]
		public unsafe GeoJsonSource (string id, global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/constructor[@name='GeoJsonSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GeoJsonSource (string id, string geoJson)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_geoJson = JNIEnv.NewString (geoJson);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_geoJson);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_geoJson);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/constructor[@name='GeoJsonSource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mapbox.mapboxsdk.style.sources.GeoJsonOptions']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;)V", "")]
		public unsafe GeoJsonSource (string id, string geoJson, global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_geoJson = JNIEnv.NewString (geoJson);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_geoJson);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_geoJson);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/constructor[@name='GeoJsonSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.net.URI']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/net/URI;)V", "")]
		public unsafe GeoJsonSource (string id, global::Java.Net.URI uri)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/net/URI;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/constructor[@name='GeoJsonSource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.net.URI'] and parameter[3][@type='com.mapbox.mapboxsdk.style.sources.GeoJsonOptions']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/net/URI;Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;)V", "")]
		public unsafe GeoJsonSource (string id, global::Java.Net.URI uri, global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/net/URI;Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/constructor[@name='GeoJsonSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/net/URL;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe GeoJsonSource (string id, global::Java.Net.URL url)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/net/URL;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/constructor[@name='GeoJsonSource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.net.URL'] and parameter[3][@type='com.mapbox.mapboxsdk.style.sources.GeoJsonOptions']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/net/URL;Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe GeoJsonSource (string id, global::Java.Net.URL url, global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/net/URL;Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_getUri;
#pragma warning disable 0169
		static Delegate GetGetUriHandler ()
		{
			if (cb_getUri == null)
				cb_getUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUri);
			return cb_getUri;
		}

		static IntPtr n_GetUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uri);
		}
#pragma warning restore 0169

		static Delegate cb_setUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUri_Ljava_lang_String_Handler ()
		{
			if (cb_setUri_Ljava_lang_String_ == null)
				cb_setUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUri_Ljava_lang_String_);
			return cb_setUri_Ljava_lang_String_;
		}

		static void n_SetUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.Uri = uri;
		}
#pragma warning restore 0169

		public virtual unsafe string Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Ljava/lang/String;", "GetGetUriHandler")]
			get {
				const string __id = "getUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUri", "(Ljava/lang/String;)V", "GetSetUri_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUri.(Ljava/lang/String;)V";
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

		static Delegate cb_getUrl;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		[Obsolete]
		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		[Obsolete]
		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Url = url;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUrl.(Ljava/lang/String;)V";
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

		static Delegate cb_initialize_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_initialize_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_initialize_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_lang_String_Ljava_lang_Object_);
			return cb_initialize_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Initialize_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("initialize", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetInitialize_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void Initialize (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "initialize.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_nativeGetUrl;
#pragma warning disable 0169
		static Delegate GetNativeGetUrlHandler ()
		{
			if (cb_nativeGetUrl == null)
				cb_nativeGetUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NativeGetUrl);
			return cb_nativeGetUrl;
		}

		static IntPtr n_NativeGetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NativeGetUrl ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='nativeGetUrl' and count(parameter)=0]"
		[Register ("nativeGetUrl", "()Ljava/lang/String;", "GetNativeGetUrlHandler")]
		protected virtual unsafe string NativeGetUrl ()
		{
			const string __id = "nativeGetUrl.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nativeSetUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNativeSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_nativeSetUrl_Ljava_lang_String_ == null)
				cb_nativeSetUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NativeSetUrl_Ljava_lang_String_);
			return cb_nativeSetUrl_Ljava_lang_String_;
		}

		static void n_NativeSetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetUrl (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='nativeSetUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("nativeSetUrl", "(Ljava/lang/String;)V", "GetNativeSetUrl_Ljava_lang_String_Handler")]
		protected virtual unsafe void NativeSetUrl (string p0)
		{
			const string __id = "nativeSetUrl.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setGeoJson_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGeoJson_Ljava_lang_String_Handler ()
		{
			if (cb_setGeoJson_Ljava_lang_String_ == null)
				cb_setGeoJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGeoJson_Ljava_lang_String_);
			return cb_setGeoJson_Ljava_lang_String_;
		}

		static void n_SetGeoJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_json)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string json = JNIEnv.GetString (native_json, JniHandleOwnership.DoNotTransfer);
			__this.SetGeoJson (json);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='setGeoJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setGeoJson", "(Ljava/lang/String;)V", "GetSetGeoJson_Ljava_lang_String_Handler")]
		public virtual unsafe void SetGeoJson (string json)
		{
			const string __id = "setGeoJson.(Ljava/lang/String;)V";
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_json);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static Delegate cb_setUri_Ljava_net_URI_;
#pragma warning disable 0169
		static Delegate GetSetUri_Ljava_net_URI_Handler ()
		{
			if (cb_setUri_Ljava_net_URI_ == null)
				cb_setUri_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUri_Ljava_net_URI_);
			return cb_setUri_Ljava_net_URI_;
		}

		static void n_SetUri_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI uri = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.SetUri (uri);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("setUri", "(Ljava/net/URI;)V", "GetSetUri_Ljava_net_URI_Handler")]
		public virtual unsafe void SetUri (global::Java.Net.URI uri)
		{
			const string __id = "setUri.(Ljava/net/URI;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUrl_Ljava_net_URL_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetUrl_Ljava_net_URL_Handler ()
		{
			if (cb_setUrl_Ljava_net_URL_ == null)
				cb_setUrl_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_net_URL_);
			return cb_setUrl_Ljava_net_URL_;
		}

		[Obsolete]
		static void n_SetUrl_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			__this.SetUrl (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonSource']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Obsolete (@"deprecated")]
		[Register ("setUrl", "(Ljava/net/URL;)V", "GetSetUrl_Ljava_net_URL_Handler")]
		public virtual unsafe void SetUrl (global::Java.Net.URL url)
		{
			const string __id = "setUrl.(Ljava/net/URL;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
