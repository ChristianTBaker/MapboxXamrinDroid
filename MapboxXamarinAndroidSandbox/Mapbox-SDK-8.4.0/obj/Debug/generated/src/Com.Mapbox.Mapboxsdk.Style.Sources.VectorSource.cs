using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='VectorSource']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/VectorSource", DoNotGenerateAcw=true)]
	public partial class VectorSource : global::Com.Mapbox.Mapboxsdk.Style.Sources.Source {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/VectorSource", typeof (VectorSource));
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

		protected VectorSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='VectorSource']/constructor[@name='VectorSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.net.Uri']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/net/Uri;)V", "")]
		public unsafe VectorSource (string id, global::Android.Net.Uri uri)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Landroid/net/Uri;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='VectorSource']/constructor[@name='VectorSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.style.sources.TileSet']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/TileSet;)V", "")]
		public unsafe VectorSource (string id, global::Com.Mapbox.Mapboxsdk.Style.Sources.TileSet tileSet)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/TileSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((tileSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tileSet).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='VectorSource']/constructor[@name='VectorSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe VectorSource (string id, string uri)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_uri);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='VectorSource']/constructor[@name='VectorSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/net/URL;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe VectorSource (string id, global::Java.Net.URL url)
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.VectorSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.VectorSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uri);
		}
#pragma warning restore 0169

		public virtual unsafe string Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='VectorSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Ljava/lang/String;", "GetGetUriHandler")]
			get {
				const string __id = "getUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.VectorSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.VectorSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='VectorSource']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.VectorSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.VectorSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='VectorSource']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.VectorSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.VectorSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NativeGetUrl ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='VectorSource']/method[@name='nativeGetUrl' and count(parameter)=0]"
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

	}
}
