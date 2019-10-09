using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Snapshotter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter", DoNotGenerateAcw=true)]
	public partial class MapSnapshotter : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/interface[@name='MapSnapshotter.ErrorHandler']"
		[Register ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter$ErrorHandler", "", "Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter/IErrorHandlerInvoker")]
		public partial interface IErrorHandler : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/interface[@name='MapSnapshotter.ErrorHandler']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter/IErrorHandlerInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter$ErrorHandler", DoNotGenerateAcw=true)]
		internal class IErrorHandlerInvoker : global::Java.Lang.Object, IErrorHandler {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter$ErrorHandler", typeof (IErrorHandlerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IErrorHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IErrorHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.snapshotter.MapSnapshotter.ErrorHandler"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IErrorHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_String_Handler ()
			{
				if (cb_onError_Ljava_lang_String_ == null)
					cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_String_);
				return cb_onError_Ljava_lang_String_;
			}

			static void n_OnError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.IErrorHandler __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.IErrorHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_String_;
			public unsafe void OnError (string p0)
			{
				if (id_onError_Ljava_lang_String_ == IntPtr.Zero)
					id_onError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options", DoNotGenerateAcw=true)]
		public partial class Options : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options", typeof (Options));
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

			protected Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/constructor[@name='MapSnapshotter.Options' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe Options (int width, int height)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getApiBaseUri;
#pragma warning disable 0169
			static Delegate GetGetApiBaseUriHandler ()
			{
				if (cb_getApiBaseUri == null)
					cb_getApiBaseUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApiBaseUri);
				return cb_getApiBaseUri;
			}

			static IntPtr n_GetApiBaseUri (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ApiBaseUri);
			}
#pragma warning restore 0169

			public virtual unsafe string ApiBaseUri {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getApiBaseUri' and count(parameter)=0]"
				[Register ("getApiBaseUri", "()Ljava/lang/String;", "GetGetApiBaseUriHandler")]
				get {
					const string __id = "getApiBaseUri.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getApiBaseUrl;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetGetApiBaseUrlHandler ()
			{
				if (cb_getApiBaseUrl == null)
					cb_getApiBaseUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApiBaseUrl);
				return cb_getApiBaseUrl;
			}

			[Obsolete]
			static IntPtr n_GetApiBaseUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ApiBaseUrl);
			}
#pragma warning restore 0169

			[Obsolete (@"deprecated")]
			public virtual unsafe string ApiBaseUrl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getApiBaseUrl' and count(parameter)=0]"
				[Register ("getApiBaseUrl", "()Ljava/lang/String;", "GetGetApiBaseUrlHandler")]
				get {
					const string __id = "getApiBaseUrl.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getCameraPosition;
#pragma warning disable 0169
			static Delegate GetGetCameraPositionHandler ()
			{
				if (cb_getCameraPosition == null)
					cb_getCameraPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCameraPosition);
				return cb_getCameraPosition;
			}

			static IntPtr n_GetCameraPosition (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CameraPosition);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition CameraPosition {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getCameraPosition' and count(parameter)=0]"
				[Register ("getCameraPosition", "()Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "GetGetCameraPositionHandler")]
				get {
					const string __id = "getCameraPosition.()Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getHeight;
#pragma warning disable 0169
			static Delegate GetGetHeightHandler ()
			{
				if (cb_getHeight == null)
					cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
				return cb_getHeight;
			}

			static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Height;
			}
#pragma warning restore 0169

			public virtual unsafe int Height {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getHeight' and count(parameter)=0]"
				[Register ("getHeight", "()I", "GetGetHeightHandler")]
				get {
					const string __id = "getHeight.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getLocalIdeographFontFamily;
#pragma warning disable 0169
			static Delegate GetGetLocalIdeographFontFamilyHandler ()
			{
				if (cb_getLocalIdeographFontFamily == null)
					cb_getLocalIdeographFontFamily = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalIdeographFontFamily);
				return cb_getLocalIdeographFontFamily;
			}

			static IntPtr n_GetLocalIdeographFontFamily (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.LocalIdeographFontFamily);
			}
#pragma warning restore 0169

			public virtual unsafe string LocalIdeographFontFamily {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getLocalIdeographFontFamily' and count(parameter)=0]"
				[Register ("getLocalIdeographFontFamily", "()Ljava/lang/String;", "GetGetLocalIdeographFontFamilyHandler")]
				get {
					const string __id = "getLocalIdeographFontFamily.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getPixelRatio;
#pragma warning disable 0169
			static Delegate GetGetPixelRatioHandler ()
			{
				if (cb_getPixelRatio == null)
					cb_getPixelRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPixelRatio);
				return cb_getPixelRatio;
			}

			static float n_GetPixelRatio (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.PixelRatio;
			}
#pragma warning restore 0169

			public virtual unsafe float PixelRatio {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getPixelRatio' and count(parameter)=0]"
				[Register ("getPixelRatio", "()F", "GetGetPixelRatioHandler")]
				get {
					const string __id = "getPixelRatio.()F";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getRegion;
#pragma warning disable 0169
			static Delegate GetGetRegionHandler ()
			{
				if (cb_getRegion == null)
					cb_getRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegion);
				return cb_getRegion;
			}

			static IntPtr n_GetRegion (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Region);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Region {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getRegion' and count(parameter)=0]"
				[Register ("getRegion", "()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "GetGetRegionHandler")]
				get {
					const string __id = "getRegion.()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStyleUri;
#pragma warning disable 0169
			static Delegate GetGetStyleUriHandler ()
			{
				if (cb_getStyleUri == null)
					cb_getStyleUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStyleUri);
				return cb_getStyleUri;
			}

			static IntPtr n_GetStyleUri (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.StyleUri);
			}
#pragma warning restore 0169

			public virtual unsafe string StyleUri {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getStyleUri' and count(parameter)=0]"
				[Register ("getStyleUri", "()Ljava/lang/String;", "GetGetStyleUriHandler")]
				get {
					const string __id = "getStyleUri.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStyleUrl;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetGetStyleUrlHandler ()
			{
				if (cb_getStyleUrl == null)
					cb_getStyleUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStyleUrl);
				return cb_getStyleUrl;
			}

			[Obsolete]
			static IntPtr n_GetStyleUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.StyleUrl);
			}
#pragma warning restore 0169

			[Obsolete (@"deprecated")]
			public virtual unsafe string StyleUrl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getStyleUrl' and count(parameter)=0]"
				[Register ("getStyleUrl", "()Ljava/lang/String;", "GetGetStyleUrlHandler")]
				get {
					const string __id = "getStyleUrl.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getWidth;
#pragma warning disable 0169
			static Delegate GetGetWidthHandler ()
			{
				if (cb_getWidth == null)
					cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
				return cb_getWidth;
			}

			static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Width;
			}
#pragma warning restore 0169

			public virtual unsafe int Width {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='getWidth' and count(parameter)=0]"
				[Register ("getWidth", "()I", "GetGetWidthHandler")]
				get {
					const string __id = "getWidth.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_withApiBaseUri_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithApiBaseUri_Ljava_lang_String_Handler ()
			{
				if (cb_withApiBaseUri_Ljava_lang_String_ == null)
					cb_withApiBaseUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithApiBaseUri_Ljava_lang_String_);
				return cb_withApiBaseUri_Ljava_lang_String_;
			}

			static IntPtr n_WithApiBaseUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiBaseUri)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string apiBaseUri = JNIEnv.GetString (native_apiBaseUri, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithApiBaseUri (apiBaseUri));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withApiBaseUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withApiBaseUri", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithApiBaseUri_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithApiBaseUri (string apiBaseUri)
			{
				const string __id = "withApiBaseUri.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				IntPtr native_apiBaseUri = JNIEnv.NewString (apiBaseUri);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_apiBaseUri);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_apiBaseUri);
				}
			}

			static Delegate cb_withApiBaseUrl_Ljava_lang_String_;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetWithApiBaseUrl_Ljava_lang_String_Handler ()
			{
				if (cb_withApiBaseUrl_Ljava_lang_String_ == null)
					cb_withApiBaseUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithApiBaseUrl_Ljava_lang_String_);
				return cb_withApiBaseUrl_Ljava_lang_String_;
			}

			[Obsolete]
			static IntPtr n_WithApiBaseUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiBaseUrl)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string apiBaseUrl = JNIEnv.GetString (native_apiBaseUrl, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithApiBaseUrl (apiBaseUrl));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withApiBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Obsolete (@"deprecated")]
			[Register ("withApiBaseUrl", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithApiBaseUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithApiBaseUrl (string apiBaseUrl)
			{
				const string __id = "withApiBaseUrl.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				IntPtr native_apiBaseUrl = JNIEnv.NewString (apiBaseUrl);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_apiBaseUrl);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_apiBaseUrl);
				}
			}

			static Delegate cb_withCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_;
#pragma warning disable 0169
			static Delegate GetWithCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_Handler ()
			{
				if (cb_withCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ == null)
					cb_withCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_);
				return cb_withCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_;
			}

			static IntPtr n_WithCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cameraPosition)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition cameraPosition = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (native_cameraPosition, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCameraPosition (cameraPosition));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withCameraPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraPosition']]"
			[Register ("withCameraPosition", "(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithCameraPosition (global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition cameraPosition)
			{
				const string __id = "withCameraPosition.(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cameraPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cameraPosition).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withLocalIdeographFontFamily_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithLocalIdeographFontFamily_Ljava_lang_String_Handler ()
			{
				if (cb_withLocalIdeographFontFamily_Ljava_lang_String_ == null)
					cb_withLocalIdeographFontFamily_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLocalIdeographFontFamily_Ljava_lang_String_);
				return cb_withLocalIdeographFontFamily_Ljava_lang_String_;
			}

			static IntPtr n_WithLocalIdeographFontFamily_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fontFamily)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string fontFamily = JNIEnv.GetString (native_fontFamily, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLocalIdeographFontFamily (fontFamily));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withLocalIdeographFontFamily' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withLocalIdeographFontFamily", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithLocalIdeographFontFamily_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithLocalIdeographFontFamily (string fontFamily)
			{
				const string __id = "withLocalIdeographFontFamily.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				IntPtr native_fontFamily = JNIEnv.NewString (fontFamily);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_fontFamily);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_fontFamily);
				}
			}

			static Delegate cb_withLocalIdeographFontFamily_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithLocalIdeographFontFamily_arrayLjava_lang_String_Handler ()
			{
				if (cb_withLocalIdeographFontFamily_arrayLjava_lang_String_ == null)
					cb_withLocalIdeographFontFamily_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLocalIdeographFontFamily_arrayLjava_lang_String_);
				return cb_withLocalIdeographFontFamily_arrayLjava_lang_String_;
			}

			static IntPtr n_WithLocalIdeographFontFamily_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fontFamilies)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] fontFamilies = (string[]) JNIEnv.GetArray (native_fontFamilies, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLocalIdeographFontFamily (fontFamilies));
				if (fontFamilies != null)
					JNIEnv.CopyArray (fontFamilies, native_fontFamilies);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withLocalIdeographFontFamily' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
			[Register ("withLocalIdeographFontFamily", "([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithLocalIdeographFontFamily_arrayLjava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithLocalIdeographFontFamily (params string[] fontFamilies)
			{
				const string __id = "withLocalIdeographFontFamily.([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				IntPtr native_fontFamilies = JNIEnv.NewArray (fontFamilies);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_fontFamilies);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (fontFamilies != null) {
						JNIEnv.CopyArray (native_fontFamilies, fontFamilies);
						JNIEnv.DeleteLocalRef (native_fontFamilies);
					}
				}
			}

			static Delegate cb_withLogo_Z;
#pragma warning disable 0169
			static Delegate GetWithLogo_ZHandler ()
			{
				if (cb_withLogo_Z == null)
					cb_withLogo_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithLogo_Z);
				return cb_withLogo_Z;
			}

			static IntPtr n_WithLogo_Z (IntPtr jnienv, IntPtr native__this, bool showLogo)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WithLogo (showLogo));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withLogo' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("withLogo", "(Z)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithLogo_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithLogo (bool showLogo)
			{
				const string __id = "withLogo.(Z)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (showLogo);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withPixelRatio_F;
#pragma warning disable 0169
			static Delegate GetWithPixelRatio_FHandler ()
			{
				if (cb_withPixelRatio_F == null)
					cb_withPixelRatio_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_WithPixelRatio_F);
				return cb_withPixelRatio_F;
			}

			static IntPtr n_WithPixelRatio_F (IntPtr jnienv, IntPtr native__this, float pixelRatio)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WithPixelRatio (pixelRatio));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withPixelRatio' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("withPixelRatio", "(F)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithPixelRatio_FHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithPixelRatio (float pixelRatio)
			{
				const string __id = "withPixelRatio.(F)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (pixelRatio);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
#pragma warning disable 0169
			static Delegate GetWithRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler ()
			{
				if (cb_withRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ == null)
					cb_withRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_);
				return cb_withRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
			}

			static IntPtr n_WithRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_region)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds region = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (native_region, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRegion (region));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withRegion' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds']]"
			[Register ("withRegion", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithRegion (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds region)
			{
				const string __id = "withRegion.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((region == null) ? IntPtr.Zero : ((global::Java.Lang.Object) region).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withStyle_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithStyle_Ljava_lang_String_Handler ()
			{
				if (cb_withStyle_Ljava_lang_String_ == null)
					cb_withStyle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithStyle_Ljava_lang_String_);
				return cb_withStyle_Ljava_lang_String_;
			}

			static IntPtr n_WithStyle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithStyle (uri));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withStyle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withStyle", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithStyle_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithStyle (string uri)
			{
				const string __id = "withStyle.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				IntPtr native_uri = JNIEnv.NewString (uri);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_uri);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_uri);
				}
			}

			static Delegate cb_withStyleJson_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithStyleJson_Ljava_lang_String_Handler ()
			{
				if (cb_withStyleJson_Ljava_lang_String_ == null)
					cb_withStyleJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithStyleJson_Ljava_lang_String_);
				return cb_withStyleJson_Ljava_lang_String_;
			}

			static IntPtr n_WithStyleJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_styleJson)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string styleJson = JNIEnv.GetString (native_styleJson, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithStyleJson (styleJson));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter.Options']/method[@name='withStyleJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withStyleJson", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;", "GetWithStyleJson_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options WithStyleJson (string styleJson)
			{
				const string __id = "withStyleJson.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;";
				IntPtr native_styleJson = JNIEnv.NewString (styleJson);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_styleJson);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_styleJson);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/interface[@name='MapSnapshotter.SnapshotReadyCallback']"
		[Register ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter$SnapshotReadyCallback", "", "Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter/ISnapshotReadyCallbackInvoker")]
		public partial interface ISnapshotReadyCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/interface[@name='MapSnapshotter.SnapshotReadyCallback']/method[@name='onSnapshotReady' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.snapshotter.MapSnapshot']]"
			[Register ("onSnapshotReady", "(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshot;)V", "GetOnSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_Handler:Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter/ISnapshotReadyCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnSnapshotReady (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter$SnapshotReadyCallback", DoNotGenerateAcw=true)]
		internal class ISnapshotReadyCallbackInvoker : global::Java.Lang.Object, ISnapshotReadyCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter$SnapshotReadyCallback", typeof (ISnapshotReadyCallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ISnapshotReadyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISnapshotReadyCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.snapshotter.MapSnapshotter.SnapshotReadyCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISnapshotReadyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_;
#pragma warning disable 0169
			static Delegate GetOnSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_Handler ()
			{
				if (cb_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ == null)
					cb_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_);
				return cb_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_;
			}

			static void n_OnSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSnapshotReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_;
			public unsafe void OnSnapshotReady (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot p0)
			{
				if (id_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ == IntPtr.Zero)
					id_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ = JNIEnv.GetMethodID (class_ref, "onSnapshotReady", "(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshot;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_, __args);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/snapshotter/MapSnapshotter", typeof (MapSnapshotter));
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

		protected MapSnapshotter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/constructor[@name='MapSnapshotter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.snapshotter.MapSnapshotter.Options']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;)V", "")]
		public unsafe MapSnapshotter (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.Options options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$Options;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOverlay_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_;
#pragma warning disable 0169
		static Delegate GetAddOverlay_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_Handler ()
		{
			if (cb_addOverlay_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ == null)
				cb_addOverlay_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOverlay_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_);
			return cb_addOverlay_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_;
		}

		static void n_AddOverlay_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapSnapshot)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot mapSnapshot = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot> (native_mapSnapshot, JniHandleOwnership.DoNotTransfer);
			__this.AddOverlay (mapSnapshot);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='addOverlay' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.snapshotter.MapSnapshot']]"
		[Register ("addOverlay", "(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshot;)V", "GetAddOverlay_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_Handler")]
		protected virtual unsafe void AddOverlay (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot mapSnapshot)
		{
			const string __id = "addOverlay.(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshot;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapSnapshot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapSnapshot).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_nativeCancel;
#pragma warning disable 0169
		static Delegate GetNativeCancelHandler ()
		{
			if (cb_nativeCancel == null)
				cb_nativeCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NativeCancel);
			return cb_nativeCancel;
		}

		static void n_NativeCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NativeCancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='nativeCancel' and count(parameter)=0]"
		[Register ("nativeCancel", "()V", "GetNativeCancelHandler")]
		protected virtual unsafe void NativeCancel ()
		{
			const string __id = "nativeCancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_nativeInitialize_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_Lcom_mapbox_mapboxsdk_storage_FileSource_FIILjava_lang_String_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNativeInitialize_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_Lcom_mapbox_mapboxsdk_storage_FileSource_FIILjava_lang_String_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ZLjava_lang_String_Handler ()
		{
			if (cb_nativeInitialize_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_Lcom_mapbox_mapboxsdk_storage_FileSource_FIILjava_lang_String_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ZLjava_lang_String_ == null)
				cb_nativeInitialize_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_Lcom_mapbox_mapboxsdk_storage_FileSource_FIILjava_lang_String_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, int, int, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_NativeInitialize_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_Lcom_mapbox_mapboxsdk_storage_FileSource_FIILjava_lang_String_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ZLjava_lang_String_);
			return cb_nativeInitialize_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_Lcom_mapbox_mapboxsdk_storage_FileSource_FIILjava_lang_String_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ZLjava_lang_String_;
		}

		static void n_NativeInitialize_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_Lcom_mapbox_mapboxsdk_storage_FileSource_FIILjava_lang_String_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, int p3, int p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, bool p9, IntPtr native_p10)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Storage.FileSource p1 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds p7 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (native_p7, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition p8 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (native_p8, JniHandleOwnership.DoNotTransfer);
			string p10 = JNIEnv.GetString (native_p10, JniHandleOwnership.DoNotTransfer);
			__this.NativeInitialize (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='nativeInitialize' and count(parameter)=11 and parameter[1][@type='com.mapbox.mapboxsdk.snapshotter.MapSnapshotter'] and parameter[2][@type='com.mapbox.mapboxsdk.storage.FileSource'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds'] and parameter[9][@type='com.mapbox.mapboxsdk.camera.CameraPosition'] and parameter[10][@type='boolean'] and parameter[11][@type='java.lang.String']]"
		[Register ("nativeInitialize", "(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter;Lcom/mapbox/mapboxsdk/storage/FileSource;FIILjava/lang/String;Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;Lcom/mapbox/mapboxsdk/camera/CameraPosition;ZLjava/lang/String;)V", "GetNativeInitialize_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_Lcom_mapbox_mapboxsdk_storage_FileSource_FIILjava_lang_String_Ljava_lang_String_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ZLjava_lang_String_Handler")]
		protected virtual unsafe void NativeInitialize (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter p0, global::Com.Mapbox.Mapboxsdk.Storage.FileSource p1, float p2, int p3, int p4, string p5, string p6, global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds p7, global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition p8, bool p9, string p10)
		{
			const string __id = "nativeInitialize.(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter;Lcom/mapbox/mapboxsdk/storage/FileSource;FIILjava/lang/String;Ljava/lang/String;Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;Lcom/mapbox/mapboxsdk/camera/CameraPosition;ZLjava/lang/String;)V";
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p10 = JNIEnv.NewString (p10);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue ((p7 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p7).Handle);
				__args [8] = new JniArgumentValue ((p8 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p8).Handle);
				__args [9] = new JniArgumentValue (p9);
				__args [10] = new JniArgumentValue (native_p10);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p10);
			}
		}

		static Delegate cb_nativeStart;
#pragma warning disable 0169
		static Delegate GetNativeStartHandler ()
		{
			if (cb_nativeStart == null)
				cb_nativeStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NativeStart);
			return cb_nativeStart;
		}

		static void n_NativeStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NativeStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='nativeStart' and count(parameter)=0]"
		[Register ("nativeStart", "()V", "GetNativeStartHandler")]
		protected virtual unsafe void NativeStart ()
		{
			const string __id = "nativeStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSnapshotFailed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSnapshotFailed_Ljava_lang_String_Handler ()
		{
			if (cb_onSnapshotFailed_Ljava_lang_String_ == null)
				cb_onSnapshotFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSnapshotFailed_Ljava_lang_String_);
			return cb_onSnapshotFailed_Ljava_lang_String_;
		}

		static void n_OnSnapshotFailed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reason)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.OnSnapshotFailed (reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='onSnapshotFailed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSnapshotFailed", "(Ljava/lang/String;)V", "GetOnSnapshotFailed_Ljava_lang_String_Handler")]
		protected virtual unsafe void OnSnapshotFailed (string reason)
		{
			const string __id = "onSnapshotFailed.(Ljava/lang/String;)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_reason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static Delegate cb_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_;
#pragma warning disable 0169
		static Delegate GetOnSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_Handler ()
		{
			if (cb_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ == null)
				cb_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_);
			return cb_onSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_;
		}

		static void n_OnSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_snapshot)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot snapshot = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot> (native_snapshot, JniHandleOwnership.DoNotTransfer);
			__this.OnSnapshotReady (snapshot);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='onSnapshotReady' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.snapshotter.MapSnapshot']]"
		[Register ("onSnapshotReady", "(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshot;)V", "GetOnSnapshotReady_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshot_Handler")]
		protected virtual unsafe void OnSnapshotReady (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshot snapshot)
		{
			const string __id = "onSnapshotReady.(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshot;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((snapshot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) snapshot).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		protected virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_;
#pragma warning disable 0169
		static Delegate GetSetCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_Handler ()
		{
			if (cb_setCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ == null)
				cb_setCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_);
			return cb_setCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_;
		}

		static void n_SetCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraPosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='setCameraPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraPosition']]"
		[Register ("setCameraPosition", "(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)V", "GetSetCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_Handler")]
		public virtual unsafe void SetCameraPosition (global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition p0)
		{
			const string __id = "setCameraPosition.(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetSetRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler ()
		{
			if (cb_setRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ == null)
				cb_setRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_);
			return cb_setRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
		}

		static void n_SetRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRegion (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='setRegion' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds']]"
		[Register ("setRegion", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)V", "GetSetRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler")]
		public virtual unsafe void SetRegion (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds p0)
		{
			const string __id = "setRegion.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSize_II;
#pragma warning disable 0169
		static Delegate GetSetSize_IIHandler ()
		{
			if (cb_setSize_II == null)
				cb_setSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetSize_II);
			return cb_setSize_II;
		}

		static void n_SetSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='setSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setSize", "(II)V", "GetSetSize_IIHandler")]
		public virtual unsafe void SetSize (int p0, int p1)
		{
			const string __id = "setSize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStyleJson_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStyleJson_Ljava_lang_String_Handler ()
		{
			if (cb_setStyleJson_Ljava_lang_String_ == null)
				cb_setStyleJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStyleJson_Ljava_lang_String_);
			return cb_setStyleJson_Ljava_lang_String_;
		}

		static void n_SetStyleJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStyleJson (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='setStyleJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setStyleJson", "(Ljava/lang/String;)V", "GetSetStyleJson_Ljava_lang_String_Handler")]
		public virtual unsafe void SetStyleJson (string p0)
		{
			const string __id = "setStyleJson.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setStyleUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStyleUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setStyleUrl_Ljava_lang_String_ == null)
				cb_setStyleUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStyleUrl_Ljava_lang_String_);
			return cb_setStyleUrl_Ljava_lang_String_;
		}

		static void n_SetStyleUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStyleUrl (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='setStyleUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setStyleUrl", "(Ljava/lang/String;)V", "GetSetStyleUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetStyleUrl (string p0)
		{
			const string __id = "setStyleUrl.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_;
#pragma warning disable 0169
		static Delegate GetStart_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Handler ()
		{
			if (cb_start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_ == null)
				cb_start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_);
			return cb_start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_;
		}

		static void n_Start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback @callback = (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Start (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='start' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.snapshotter.MapSnapshotter.SnapshotReadyCallback']]"
		[Register ("start", "(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$SnapshotReadyCallback;)V", "GetStart_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Handler")]
		public virtual unsafe void Start (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback @callback)
		{
			const string __id = "start.(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$SnapshotReadyCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_ErrorHandler_;
#pragma warning disable 0169
		static Delegate GetStart_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_ErrorHandler_Handler ()
		{
			if (cb_start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_ErrorHandler_ == null)
				cb_start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_ErrorHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_ErrorHandler_);
			return cb_start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_ErrorHandler_;
		}

		static void n_Start_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_ErrorHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback, IntPtr native_errorHandler)
		{
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback @callback = (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.IErrorHandler errorHandler = (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.IErrorHandler)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.IErrorHandler> (native_errorHandler, JniHandleOwnership.DoNotTransfer);
			__this.Start (@callback, errorHandler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.snapshotter']/class[@name='MapSnapshotter']/method[@name='start' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.snapshotter.MapSnapshotter.SnapshotReadyCallback'] and parameter[2][@type='com.mapbox.mapboxsdk.snapshotter.MapSnapshotter.ErrorHandler']]"
		[Register ("start", "(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$SnapshotReadyCallback;Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$ErrorHandler;)V", "GetStart_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_SnapshotReadyCallback_Lcom_mapbox_mapboxsdk_snapshotter_MapSnapshotter_ErrorHandler_Handler")]
		public virtual unsafe void Start (global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.ISnapshotReadyCallback @callback, global::Com.Mapbox.Mapboxsdk.Snapshotter.MapSnapshotter.IErrorHandler errorHandler)
		{
			const string __id = "start.(Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$SnapshotReadyCallback;Lcom/mapbox/mapboxsdk/snapshotter/MapSnapshotter$ErrorHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [1] = new JniArgumentValue ((errorHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorHandler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
