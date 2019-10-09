using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/ImageSource", DoNotGenerateAcw=true)]
	public partial class ImageSource : global::Com.Mapbox.Mapboxsdk.Style.Sources.Source {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/ImageSource", typeof (ImageSource));
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

		protected ImageSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/constructor[@name='ImageSource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.geometry.LatLngQuad'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;Landroid/graphics/Bitmap;)V", "")]
		public unsafe ImageSource (string id, global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad coordinates, global::Android.Graphics.Bitmap bitmap)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;Landroid/graphics/Bitmap;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((coordinates == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coordinates).Handle);
				__args [2] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/constructor[@name='ImageSource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.geometry.LatLngQuad'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;I)V", "")]
		public unsafe ImageSource (string id, global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad coordinates, int resourceId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((coordinates == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coordinates).Handle);
				__args [2] = new JniArgumentValue (resourceId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/constructor[@name='ImageSource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.geometry.LatLngQuad'] and parameter[3][@type='java.net.URI']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;Ljava/net/URI;)V", "")]
		public unsafe ImageSource (string id, global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad coordinates, global::Java.Net.URI uri)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;Ljava/net/URI;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((coordinates == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coordinates).Handle);
				__args [2] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/constructor[@name='ImageSource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.geometry.LatLngQuad'] and parameter[3][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;Ljava/net/URL;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe ImageSource (string id, global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad coordinates, global::Java.Net.URL url)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;Ljava/net/URL;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((coordinates == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coordinates).Handle);
				__args [2] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.Uri = uri;
		}
#pragma warning restore 0169

		public virtual unsafe string Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Ljava/lang/String;", "GetGetUriHandler")]
			get {
				const string __id = "getUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Url = url;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_initialize_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_Handler ()
		{
			if (cb_initialize_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_ == null)
				cb_initialize_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_);
			return cb_initialize_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_;
		}

		static void n_Initialize_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.geometry.LatLngQuad']]"
		[Register ("initialize", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;)V", "GetInitialize_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_Handler")]
		protected virtual unsafe void Initialize (string p0, global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad p1)
		{
			const string __id = "initialize.(Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;)V";
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NativeGetUrl ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='nativeGetUrl' and count(parameter)=0]"
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

		static Delegate cb_nativeSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_;
#pragma warning disable 0169
		static Delegate GetNativeSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_Handler ()
		{
			if (cb_nativeSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_ == null)
				cb_nativeSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NativeSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_);
			return cb_nativeSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_;
		}

		static void n_NativeSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetCoordinates (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='nativeSetCoordinates' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngQuad']]"
		[Register ("nativeSetCoordinates", "(Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;)V", "GetNativeSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_Handler")]
		protected virtual unsafe void NativeSetCoordinates (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad p0)
		{
			const string __id = "nativeSetCoordinates.(Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_nativeSetImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetNativeSetImage_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_nativeSetImage_Landroid_graphics_Bitmap_ == null)
				cb_nativeSetImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NativeSetImage_Landroid_graphics_Bitmap_);
			return cb_nativeSetImage_Landroid_graphics_Bitmap_;
		}

		static void n_NativeSetImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetImage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='nativeSetImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("nativeSetImage", "(Landroid/graphics/Bitmap;)V", "GetNativeSetImage_Landroid_graphics_Bitmap_Handler")]
		protected virtual unsafe void NativeSetImage (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "nativeSetImage.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetUrl (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='nativeSetUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_;
#pragma warning disable 0169
		static Delegate GetSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_Handler ()
		{
			if (cb_setCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_ == null)
				cb_setCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_);
			return cb_setCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_;
		}

		static void n_SetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_ (IntPtr jnienv, IntPtr native__this, IntPtr native_latLngQuad)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad latLngQuad = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad> (native_latLngQuad, JniHandleOwnership.DoNotTransfer);
			__this.SetCoordinates (latLngQuad);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='setCoordinates' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngQuad']]"
		[Register ("setCoordinates", "(Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;)V", "GetSetCoordinates_Lcom_mapbox_mapboxsdk_geometry_LatLngQuad_Handler")]
		public virtual unsafe void SetCoordinates (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad latLngQuad)
		{
			const string __id = "setCoordinates.(Lcom/mapbox/mapboxsdk/geometry/LatLngQuad;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((latLngQuad == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLngQuad).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImage_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImage_Landroid_graphics_Bitmap_ == null)
				cb_setImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Landroid_graphics_Bitmap_);
			return cb_setImage_Landroid_graphics_Bitmap_;
		}

		static void n_SetImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (bitmap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImage", "(Landroid/graphics/Bitmap;)V", "GetSetImage_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetImage (global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "setImage.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImage_I;
#pragma warning disable 0169
		static Delegate GetSetImage_IHandler ()
		{
			if (cb_setImage_I == null)
				cb_setImage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetImage_I);
			return cb_setImage_I;
		}

		static void n_SetImage_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (resourceId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setImage", "(I)V", "GetSetImage_IHandler")]
		public virtual unsafe void SetImage (int resourceId)
		{
			const string __id = "setImage.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI uri = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.SetUri (uri);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
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
			global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.ImageSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			__this.SetUrl (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='ImageSource']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
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
