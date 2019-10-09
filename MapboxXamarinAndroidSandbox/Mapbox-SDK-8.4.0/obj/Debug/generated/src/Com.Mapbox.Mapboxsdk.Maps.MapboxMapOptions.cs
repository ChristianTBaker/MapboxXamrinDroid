using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMapOptions", DoNotGenerateAcw=true)]
	public partial class MapboxMapOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMapOptions", typeof (MapboxMapOptions));
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

		protected MapboxMapOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/constructor[@name='MapboxMapOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		[Obsolete (@"deprecated")]
		public unsafe MapboxMapOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
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
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiBaseUri);
		}
#pragma warning restore 0169

		public virtual unsafe string ApiBaseUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getApiBaseUri' and count(parameter)=0]"
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
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiBaseUrl);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe string ApiBaseUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getApiBaseUrl' and count(parameter)=0]"
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

		static Delegate cb_getAttributionEnabled;
#pragma warning disable 0169
		static Delegate GetGetAttributionEnabledHandler ()
		{
			if (cb_getAttributionEnabled == null)
				cb_getAttributionEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAttributionEnabled);
			return cb_getAttributionEnabled;
		}

		static bool n_GetAttributionEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AttributionEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool AttributionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getAttributionEnabled' and count(parameter)=0]"
			[Register ("getAttributionEnabled", "()Z", "GetGetAttributionEnabledHandler")]
			get {
				const string __id = "getAttributionEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAttributionGravity;
#pragma warning disable 0169
		static Delegate GetGetAttributionGravityHandler ()
		{
			if (cb_getAttributionGravity == null)
				cb_getAttributionGravity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAttributionGravity);
			return cb_getAttributionGravity;
		}

		static int n_GetAttributionGravity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AttributionGravity;
		}
#pragma warning restore 0169

		public virtual unsafe int AttributionGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getAttributionGravity' and count(parameter)=0]"
			[Register ("getAttributionGravity", "()I", "GetGetAttributionGravityHandler")]
			get {
				const string __id = "getAttributionGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAttributionTintColor;
#pragma warning disable 0169
		static Delegate GetGetAttributionTintColorHandler ()
		{
			if (cb_getAttributionTintColor == null)
				cb_getAttributionTintColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAttributionTintColor);
			return cb_getAttributionTintColor;
		}

		static int n_GetAttributionTintColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AttributionTintColor;
		}
#pragma warning restore 0169

		public virtual unsafe int AttributionTintColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getAttributionTintColor' and count(parameter)=0]"
			[Register ("getAttributionTintColor", "()I", "GetGetAttributionTintColorHandler")]
			get {
				const string __id = "getAttributionTintColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCamera;
#pragma warning disable 0169
		static Delegate GetGetCameraHandler ()
		{
			if (cb_getCamera == null)
				cb_getCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCamera);
			return cb_getCamera;
		}

		static IntPtr n_GetCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Camera);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition Camera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getCamera' and count(parameter)=0]"
			[Register ("getCamera", "()Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "GetGetCameraHandler")]
			get {
				const string __id = "getCamera.()Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCompassEnabled;
#pragma warning disable 0169
		static Delegate GetGetCompassEnabledHandler ()
		{
			if (cb_getCompassEnabled == null)
				cb_getCompassEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetCompassEnabled);
			return cb_getCompassEnabled;
		}

		static bool n_GetCompassEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompassEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool CompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getCompassEnabled' and count(parameter)=0]"
			[Register ("getCompassEnabled", "()Z", "GetGetCompassEnabledHandler")]
			get {
				const string __id = "getCompassEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCompassFadeFacingNorth;
#pragma warning disable 0169
		static Delegate GetGetCompassFadeFacingNorthHandler ()
		{
			if (cb_getCompassFadeFacingNorth == null)
				cb_getCompassFadeFacingNorth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetCompassFadeFacingNorth);
			return cb_getCompassFadeFacingNorth;
		}

		static bool n_GetCompassFadeFacingNorth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompassFadeFacingNorth;
		}
#pragma warning restore 0169

		public virtual unsafe bool CompassFadeFacingNorth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getCompassFadeFacingNorth' and count(parameter)=0]"
			[Register ("getCompassFadeFacingNorth", "()Z", "GetGetCompassFadeFacingNorthHandler")]
			get {
				const string __id = "getCompassFadeFacingNorth.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCompassGravity;
#pragma warning disable 0169
		static Delegate GetGetCompassGravityHandler ()
		{
			if (cb_getCompassGravity == null)
				cb_getCompassGravity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCompassGravity);
			return cb_getCompassGravity;
		}

		static int n_GetCompassGravity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompassGravity;
		}
#pragma warning restore 0169

		public virtual unsafe int CompassGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getCompassGravity' and count(parameter)=0]"
			[Register ("getCompassGravity", "()I", "GetGetCompassGravityHandler")]
			get {
				const string __id = "getCompassGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCompassImage;
#pragma warning disable 0169
		static Delegate GetGetCompassImageHandler ()
		{
			if (cb_getCompassImage == null)
				cb_getCompassImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompassImage);
			return cb_getCompassImage;
		}

		static IntPtr n_GetCompassImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CompassImage);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable CompassImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getCompassImage' and count(parameter)=0]"
			[Register ("getCompassImage", "()Landroid/graphics/drawable/Drawable;", "GetGetCompassImageHandler")]
			get {
				const string __id = "getCompassImage.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCrossSourceCollisions;
#pragma warning disable 0169
		static Delegate GetGetCrossSourceCollisionsHandler ()
		{
			if (cb_getCrossSourceCollisions == null)
				cb_getCrossSourceCollisions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetCrossSourceCollisions);
			return cb_getCrossSourceCollisions;
		}

		static bool n_GetCrossSourceCollisions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CrossSourceCollisions;
		}
#pragma warning restore 0169

		public virtual unsafe bool CrossSourceCollisions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getCrossSourceCollisions' and count(parameter)=0]"
			[Register ("getCrossSourceCollisions", "()Z", "GetGetCrossSourceCollisionsHandler")]
			get {
				const string __id = "getCrossSourceCollisions.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDebugActive;
#pragma warning disable 0169
		static Delegate GetGetDebugActiveHandler ()
		{
			if (cb_getDebugActive == null)
				cb_getDebugActive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetDebugActive);
			return cb_getDebugActive;
		}

		static bool n_GetDebugActive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DebugActive;
		}
#pragma warning restore 0169

		public virtual unsafe bool DebugActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getDebugActive' and count(parameter)=0]"
			[Register ("getDebugActive", "()Z", "GetGetDebugActiveHandler")]
			get {
				const string __id = "getDebugActive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDoubleTapGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetGetDoubleTapGesturesEnabledHandler ()
		{
			if (cb_getDoubleTapGesturesEnabled == null)
				cb_getDoubleTapGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetDoubleTapGesturesEnabled);
			return cb_getDoubleTapGesturesEnabled;
		}

		static bool n_GetDoubleTapGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoubleTapGesturesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool DoubleTapGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getDoubleTapGesturesEnabled' and count(parameter)=0]"
			[Register ("getDoubleTapGesturesEnabled", "()Z", "GetGetDoubleTapGesturesEnabledHandler")]
			get {
				const string __id = "getDoubleTapGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getForegroundLoadColor;
#pragma warning disable 0169
		static Delegate GetGetForegroundLoadColorHandler ()
		{
			if (cb_getForegroundLoadColor == null)
				cb_getForegroundLoadColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetForegroundLoadColor);
			return cb_getForegroundLoadColor;
		}

		static int n_GetForegroundLoadColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForegroundLoadColor;
		}
#pragma warning restore 0169

		public virtual unsafe int ForegroundLoadColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getForegroundLoadColor' and count(parameter)=0]"
			[Register ("getForegroundLoadColor", "()I", "GetGetForegroundLoadColorHandler")]
			get {
				const string __id = "getForegroundLoadColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isLocalIdeographFontFamilyEnabled;
#pragma warning disable 0169
		static Delegate GetIsLocalIdeographFontFamilyEnabledHandler ()
		{
			if (cb_isLocalIdeographFontFamilyEnabled == null)
				cb_isLocalIdeographFontFamilyEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocalIdeographFontFamilyEnabled);
			return cb_isLocalIdeographFontFamilyEnabled;
		}

		static bool n_IsLocalIdeographFontFamilyEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocalIdeographFontFamilyEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLocalIdeographFontFamilyEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='isLocalIdeographFontFamilyEnabled' and count(parameter)=0]"
			[Register ("isLocalIdeographFontFamilyEnabled", "()Z", "GetIsLocalIdeographFontFamilyEnabledHandler")]
			get {
				const string __id = "isLocalIdeographFontFamilyEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
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
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalIdeographFontFamily);
		}
#pragma warning restore 0169

		public virtual unsafe string LocalIdeographFontFamily {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getLocalIdeographFontFamily' and count(parameter)=0]"
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

		static Delegate cb_getLogoEnabled;
#pragma warning disable 0169
		static Delegate GetGetLogoEnabledHandler ()
		{
			if (cb_getLogoEnabled == null)
				cb_getLogoEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetLogoEnabled);
			return cb_getLogoEnabled;
		}

		static bool n_GetLogoEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LogoEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool LogoEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getLogoEnabled' and count(parameter)=0]"
			[Register ("getLogoEnabled", "()Z", "GetGetLogoEnabledHandler")]
			get {
				const string __id = "getLogoEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLogoGravity;
#pragma warning disable 0169
		static Delegate GetGetLogoGravityHandler ()
		{
			if (cb_getLogoGravity == null)
				cb_getLogoGravity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLogoGravity);
			return cb_getLogoGravity;
		}

		static int n_GetLogoGravity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LogoGravity;
		}
#pragma warning restore 0169

		public virtual unsafe int LogoGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getLogoGravity' and count(parameter)=0]"
			[Register ("getLogoGravity", "()I", "GetGetLogoGravityHandler")]
			get {
				const string __id = "getLogoGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxZoomPreference;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomPreferenceHandler ()
		{
			if (cb_getMaxZoomPreference == null)
				cb_getMaxZoomPreference = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxZoomPreference);
			return cb_getMaxZoomPreference;
		}

		static double n_GetMaxZoomPreference (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoomPreference;
		}
#pragma warning restore 0169

		public virtual unsafe double MaxZoomPreference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getMaxZoomPreference' and count(parameter)=0]"
			[Register ("getMaxZoomPreference", "()D", "GetGetMaxZoomPreferenceHandler")]
			get {
				const string __id = "getMaxZoomPreference.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinZoomPreference;
#pragma warning disable 0169
		static Delegate GetGetMinZoomPreferenceHandler ()
		{
			if (cb_getMinZoomPreference == null)
				cb_getMinZoomPreference = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinZoomPreference);
			return cb_getMinZoomPreference;
		}

		static double n_GetMinZoomPreference (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoomPreference;
		}
#pragma warning restore 0169

		public virtual unsafe double MinZoomPreference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getMinZoomPreference' and count(parameter)=0]"
			[Register ("getMinZoomPreference", "()D", "GetGetMinZoomPreferenceHandler")]
			get {
				const string __id = "getMinZoomPreference.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
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
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelRatio;
		}
#pragma warning restore 0169

		public virtual unsafe float PixelRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getPixelRatio' and count(parameter)=0]"
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

		static Delegate cb_getPrefetchesTiles;
#pragma warning disable 0169
		static Delegate GetGetPrefetchesTilesHandler ()
		{
			if (cb_getPrefetchesTiles == null)
				cb_getPrefetchesTiles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPrefetchesTiles);
			return cb_getPrefetchesTiles;
		}

		static bool n_GetPrefetchesTiles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrefetchesTiles;
		}
#pragma warning restore 0169

		public virtual unsafe bool PrefetchesTiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getPrefetchesTiles' and count(parameter)=0]"
			[Register ("getPrefetchesTiles", "()Z", "GetGetPrefetchesTilesHandler")]
			get {
				const string __id = "getPrefetchesTiles.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getQuickZoomGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetGetQuickZoomGesturesEnabledHandler ()
		{
			if (cb_getQuickZoomGesturesEnabled == null)
				cb_getQuickZoomGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetQuickZoomGesturesEnabled);
			return cb_getQuickZoomGesturesEnabled;
		}

		static bool n_GetQuickZoomGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QuickZoomGesturesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool QuickZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getQuickZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("getQuickZoomGesturesEnabled", "()Z", "GetGetQuickZoomGesturesEnabledHandler")]
			get {
				const string __id = "getQuickZoomGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRenderSurfaceOnTop;
#pragma warning disable 0169
		static Delegate GetGetRenderSurfaceOnTopHandler ()
		{
			if (cb_getRenderSurfaceOnTop == null)
				cb_getRenderSurfaceOnTop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRenderSurfaceOnTop);
			return cb_getRenderSurfaceOnTop;
		}

		static bool n_GetRenderSurfaceOnTop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RenderSurfaceOnTop;
		}
#pragma warning restore 0169

		public virtual unsafe bool RenderSurfaceOnTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getRenderSurfaceOnTop' and count(parameter)=0]"
			[Register ("getRenderSurfaceOnTop", "()Z", "GetGetRenderSurfaceOnTopHandler")]
			get {
				const string __id = "getRenderSurfaceOnTop.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRotateGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetGetRotateGesturesEnabledHandler ()
		{
			if (cb_getRotateGesturesEnabled == null)
				cb_getRotateGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRotateGesturesEnabled);
			return cb_getRotateGesturesEnabled;
		}

		static bool n_GetRotateGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotateGesturesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool RotateGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getRotateGesturesEnabled' and count(parameter)=0]"
			[Register ("getRotateGesturesEnabled", "()Z", "GetGetRotateGesturesEnabledHandler")]
			get {
				const string __id = "getRotateGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScrollGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetGetScrollGesturesEnabledHandler ()
		{
			if (cb_getScrollGesturesEnabled == null)
				cb_getScrollGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetScrollGesturesEnabled);
			return cb_getScrollGesturesEnabled;
		}

		static bool n_GetScrollGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollGesturesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool ScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("getScrollGesturesEnabled", "()Z", "GetGetScrollGesturesEnabledHandler")]
			get {
				const string __id = "getScrollGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTextureMode;
#pragma warning disable 0169
		static Delegate GetGetTextureModeHandler ()
		{
			if (cb_getTextureMode == null)
				cb_getTextureMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTextureMode);
			return cb_getTextureMode;
		}

		static bool n_GetTextureMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextureMode;
		}
#pragma warning restore 0169

		public virtual unsafe bool TextureMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getTextureMode' and count(parameter)=0]"
			[Register ("getTextureMode", "()Z", "GetGetTextureModeHandler")]
			get {
				const string __id = "getTextureMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTiltGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetGetTiltGesturesEnabledHandler ()
		{
			if (cb_getTiltGesturesEnabled == null)
				cb_getTiltGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTiltGesturesEnabled);
			return cb_getTiltGesturesEnabled;
		}

		static bool n_GetTiltGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TiltGesturesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool TiltGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getTiltGesturesEnabled' and count(parameter)=0]"
			[Register ("getTiltGesturesEnabled", "()Z", "GetGetTiltGesturesEnabledHandler")]
			get {
				const string __id = "getTiltGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTranslucentTextureSurface;
#pragma warning disable 0169
		static Delegate GetGetTranslucentTextureSurfaceHandler ()
		{
			if (cb_getTranslucentTextureSurface == null)
				cb_getTranslucentTextureSurface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTranslucentTextureSurface);
			return cb_getTranslucentTextureSurface;
		}

		static bool n_GetTranslucentTextureSurface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TranslucentTextureSurface;
		}
#pragma warning restore 0169

		public virtual unsafe bool TranslucentTextureSurface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getTranslucentTextureSurface' and count(parameter)=0]"
			[Register ("getTranslucentTextureSurface", "()Z", "GetGetTranslucentTextureSurfaceHandler")]
			get {
				const string __id = "getTranslucentTextureSurface.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getZoomGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetGetZoomGesturesEnabledHandler ()
		{
			if (cb_getZoomGesturesEnabled == null)
				cb_getZoomGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetZoomGesturesEnabled);
			return cb_getZoomGesturesEnabled;
		}

		static bool n_GetZoomGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomGesturesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool ZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("getZoomGesturesEnabled", "()Z", "GetGetZoomGesturesEnabledHandler")]
			get {
				const string __id = "getZoomGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_apiBaseUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeApiBaseUri_Ljava_lang_String_Handler ()
		{
			if (cb_apiBaseUri_Ljava_lang_String_ == null)
				cb_apiBaseUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeApiBaseUri_Ljava_lang_String_);
			return cb_apiBaseUri_Ljava_lang_String_;
		}

		static IntPtr n_InvokeApiBaseUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiBaseUri)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string apiBaseUri = JNIEnv.GetString (native_apiBaseUri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeApiBaseUri (apiBaseUri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='apiBaseUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("apiBaseUri", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeApiBaseUri_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeApiBaseUri (string apiBaseUri)
		{
			const string __id = "apiBaseUri.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			IntPtr native_apiBaseUri = JNIEnv.NewString (apiBaseUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_apiBaseUri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_apiBaseUri);
			}
		}

		static Delegate cb_apiBaseUrl_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetInvokeApiBaseUrl_Ljava_lang_String_Handler ()
		{
			if (cb_apiBaseUrl_Ljava_lang_String_ == null)
				cb_apiBaseUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeApiBaseUrl_Ljava_lang_String_);
			return cb_apiBaseUrl_Ljava_lang_String_;
		}

		[Obsolete]
		static IntPtr n_InvokeApiBaseUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiBaseUrl)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string apiBaseUrl = JNIEnv.GetString (native_apiBaseUrl, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeApiBaseUrl (apiBaseUrl));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='apiBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("apiBaseUrl", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeApiBaseUrl_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeApiBaseUrl (string apiBaseUrl)
		{
			const string __id = "apiBaseUrl.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			IntPtr native_apiBaseUrl = JNIEnv.NewString (apiBaseUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_apiBaseUrl);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_apiBaseUrl);
			}
		}

		static Delegate cb_attributionEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeAttributionEnabled_ZHandler ()
		{
			if (cb_attributionEnabled_Z == null)
				cb_attributionEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeAttributionEnabled_Z);
			return cb_attributionEnabled_Z;
		}

		static IntPtr n_InvokeAttributionEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeAttributionEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='attributionEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("attributionEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeAttributionEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeAttributionEnabled (bool enabled)
		{
			const string __id = "attributionEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_attributionGravity_I;
#pragma warning disable 0169
		static Delegate GetInvokeAttributionGravity_IHandler ()
		{
			if (cb_attributionGravity_I == null)
				cb_attributionGravity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeAttributionGravity_I);
			return cb_attributionGravity_I;
		}

		static IntPtr n_InvokeAttributionGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeAttributionGravity (gravity));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='attributionGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("attributionGravity", "(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeAttributionGravity_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeAttributionGravity (int gravity)
		{
			const string __id = "attributionGravity.(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (gravity);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_attributionMargins_arrayI;
#pragma warning disable 0169
		static Delegate GetAttributionMargins_arrayIHandler ()
		{
			if (cb_attributionMargins_arrayI == null)
				cb_attributionMargins_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AttributionMargins_arrayI);
			return cb_attributionMargins_arrayI;
		}

		static IntPtr n_AttributionMargins_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_margins)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] margins = (int[]) JNIEnv.GetArray (native_margins, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AttributionMargins (margins));
			if (margins != null)
				JNIEnv.CopyArray (margins, native_margins);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='attributionMargins' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("attributionMargins", "([I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetAttributionMargins_arrayIHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions AttributionMargins (int[] margins)
		{
			const string __id = "attributionMargins.([I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			IntPtr native_margins = JNIEnv.NewArray (margins);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_margins);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (margins != null) {
					JNIEnv.CopyArray (native_margins, margins);
					JNIEnv.DeleteLocalRef (native_margins);
				}
			}
		}

		static Delegate cb_attributionTintColor_I;
#pragma warning disable 0169
		static Delegate GetInvokeAttributionTintColor_IHandler ()
		{
			if (cb_attributionTintColor_I == null)
				cb_attributionTintColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeAttributionTintColor_I);
			return cb_attributionTintColor_I;
		}

		static IntPtr n_InvokeAttributionTintColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeAttributionTintColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='attributionTintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("attributionTintColor", "(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeAttributionTintColor_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeAttributionTintColor (int color)
		{
			const string __id = "attributionTintColor.(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_camera_Lcom_mapbox_mapboxsdk_camera_CameraPosition_;
#pragma warning disable 0169
		static Delegate GetInvokeCamera_Lcom_mapbox_mapboxsdk_camera_CameraPosition_Handler ()
		{
			if (cb_camera_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ == null)
				cb_camera_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeCamera_Lcom_mapbox_mapboxsdk_camera_CameraPosition_);
			return cb_camera_Lcom_mapbox_mapboxsdk_camera_CameraPosition_;
		}

		static IntPtr n_InvokeCamera_Lcom_mapbox_mapboxsdk_camera_CameraPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cameraPosition)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition cameraPosition = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (native_cameraPosition, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeCamera (cameraPosition));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='camera' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraPosition']]"
		[Register ("camera", "(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeCamera_Lcom_mapbox_mapboxsdk_camera_CameraPosition_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeCamera (global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition cameraPosition)
		{
			const string __id = "camera.(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cameraPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cameraPosition).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compassEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeCompassEnabled_ZHandler ()
		{
			if (cb_compassEnabled_Z == null)
				cb_compassEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeCompassEnabled_Z);
			return cb_compassEnabled_Z;
		}

		static IntPtr n_InvokeCompassEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeCompassEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='compassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("compassEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeCompassEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeCompassEnabled (bool enabled)
		{
			const string __id = "compassEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compassFadesWhenFacingNorth_Z;
#pragma warning disable 0169
		static Delegate GetCompassFadesWhenFacingNorth_ZHandler ()
		{
			if (cb_compassFadesWhenFacingNorth_Z == null)
				cb_compassFadesWhenFacingNorth_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_CompassFadesWhenFacingNorth_Z);
			return cb_compassFadesWhenFacingNorth_Z;
		}

		static IntPtr n_CompassFadesWhenFacingNorth_Z (IntPtr jnienv, IntPtr native__this, bool compassFadeWhenFacingNorth)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CompassFadesWhenFacingNorth (compassFadeWhenFacingNorth));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='compassFadesWhenFacingNorth' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("compassFadesWhenFacingNorth", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetCompassFadesWhenFacingNorth_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions CompassFadesWhenFacingNorth (bool compassFadeWhenFacingNorth)
		{
			const string __id = "compassFadesWhenFacingNorth.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (compassFadeWhenFacingNorth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compassGravity_I;
#pragma warning disable 0169
		static Delegate GetInvokeCompassGravity_IHandler ()
		{
			if (cb_compassGravity_I == null)
				cb_compassGravity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeCompassGravity_I);
			return cb_compassGravity_I;
		}

		static IntPtr n_InvokeCompassGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeCompassGravity (gravity));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='compassGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("compassGravity", "(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeCompassGravity_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeCompassGravity (int gravity)
		{
			const string __id = "compassGravity.(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (gravity);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compassImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetInvokeCompassImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_compassImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_compassImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeCompassImage_Landroid_graphics_drawable_Drawable_);
			return cb_compassImage_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_InvokeCompassImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_compass)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable compass = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_compass, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeCompassImage (compass));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='compassImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("compassImage", "(Landroid/graphics/drawable/Drawable;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeCompassImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeCompassImage (global::Android.Graphics.Drawables.Drawable compass)
		{
			const string __id = "compassImage.(Landroid/graphics/drawable/Drawable;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((compass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compass).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compassMargins_arrayI;
#pragma warning disable 0169
		static Delegate GetCompassMargins_arrayIHandler ()
		{
			if (cb_compassMargins_arrayI == null)
				cb_compassMargins_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CompassMargins_arrayI);
			return cb_compassMargins_arrayI;
		}

		static IntPtr n_CompassMargins_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_margins)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] margins = (int[]) JNIEnv.GetArray (native_margins, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompassMargins (margins));
			if (margins != null)
				JNIEnv.CopyArray (margins, native_margins);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='compassMargins' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("compassMargins", "([I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetCompassMargins_arrayIHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions CompassMargins (int[] margins)
		{
			const string __id = "compassMargins.([I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			IntPtr native_margins = JNIEnv.NewArray (margins);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_margins);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (margins != null) {
					JNIEnv.CopyArray (native_margins, margins);
					JNIEnv.DeleteLocalRef (native_margins);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='createFromAttributes' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createFromAttributes", "(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions CreateFromAttributes (global::Android.Content.Context context)
		{
			const string __id = "createFromAttributes.(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='createFromAttributes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("createFromAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions CreateFromAttributes (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
		{
			const string __id = "createFromAttributes.(Landroid/content/Context;Landroid/util/AttributeSet;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_crossSourceCollisions_Z;
#pragma warning disable 0169
		static Delegate GetInvokeCrossSourceCollisions_ZHandler ()
		{
			if (cb_crossSourceCollisions_Z == null)
				cb_crossSourceCollisions_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeCrossSourceCollisions_Z);
			return cb_crossSourceCollisions_Z;
		}

		static IntPtr n_InvokeCrossSourceCollisions_Z (IntPtr jnienv, IntPtr native__this, bool crossSourceCollisions)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeCrossSourceCollisions (crossSourceCollisions));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='crossSourceCollisions' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("crossSourceCollisions", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeCrossSourceCollisions_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeCrossSourceCollisions (bool crossSourceCollisions)
		{
			const string __id = "crossSourceCollisions.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (crossSourceCollisions);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_debugActive_Z;
#pragma warning disable 0169
		static Delegate GetInvokeDebugActive_ZHandler ()
		{
			if (cb_debugActive_Z == null)
				cb_debugActive_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeDebugActive_Z);
			return cb_debugActive_Z;
		}

		static IntPtr n_InvokeDebugActive_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeDebugActive (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='debugActive' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("debugActive", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeDebugActive_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeDebugActive (bool enabled)
		{
			const string __id = "debugActive.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doubleTapGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeDoubleTapGesturesEnabled_ZHandler ()
		{
			if (cb_doubleTapGesturesEnabled_Z == null)
				cb_doubleTapGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeDoubleTapGesturesEnabled_Z);
			return cb_doubleTapGesturesEnabled_Z;
		}

		static IntPtr n_InvokeDoubleTapGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeDoubleTapGesturesEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='doubleTapGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("doubleTapGesturesEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeDoubleTapGesturesEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeDoubleTapGesturesEnabled (bool enabled)
		{
			const string __id = "doubleTapGesturesEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_foregroundLoadColor_I;
#pragma warning disable 0169
		static Delegate GetInvokeForegroundLoadColor_IHandler ()
		{
			if (cb_foregroundLoadColor_I == null)
				cb_foregroundLoadColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeForegroundLoadColor_I);
			return cb_foregroundLoadColor_I;
		}

		static IntPtr n_InvokeForegroundLoadColor_I (IntPtr jnienv, IntPtr native__this, int loadColor)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeForegroundLoadColor (loadColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='foregroundLoadColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("foregroundLoadColor", "(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeForegroundLoadColor_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeForegroundLoadColor (int loadColor)
		{
			const string __id = "foregroundLoadColor.(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (loadColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAttributionMargins;
#pragma warning disable 0169
		static Delegate GetGetAttributionMarginsHandler ()
		{
			if (cb_getAttributionMargins == null)
				cb_getAttributionMargins = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributionMargins);
			return cb_getAttributionMargins;
		}

		static IntPtr n_GetAttributionMargins (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAttributionMargins ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getAttributionMargins' and count(parameter)=0]"
		[Register ("getAttributionMargins", "()[I", "GetGetAttributionMarginsHandler")]
		public virtual unsafe int[] GetAttributionMargins ()
		{
			const string __id = "getAttributionMargins.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getCompassMargins;
#pragma warning disable 0169
		static Delegate GetGetCompassMarginsHandler ()
		{
			if (cb_getCompassMargins == null)
				cb_getCompassMargins = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompassMargins);
			return cb_getCompassMargins;
		}

		static IntPtr n_GetCompassMargins (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCompassMargins ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getCompassMargins' and count(parameter)=0]"
		[Register ("getCompassMargins", "()[I", "GetGetCompassMarginsHandler")]
		public virtual unsafe int[] GetCompassMargins ()
		{
			const string __id = "getCompassMargins.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getLogoMargins;
#pragma warning disable 0169
		static Delegate GetGetLogoMarginsHandler ()
		{
			if (cb_getLogoMargins == null)
				cb_getLogoMargins = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogoMargins);
			return cb_getLogoMargins;
		}

		static IntPtr n_GetLogoMargins (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLogoMargins ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='getLogoMargins' and count(parameter)=0]"
		[Register ("getLogoMargins", "()[I", "GetGetLogoMarginsHandler")]
		public virtual unsafe int[] GetLogoMargins ()
		{
			const string __id = "getLogoMargins.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_localIdeographFontFamily_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeLocalIdeographFontFamily_Ljava_lang_String_Handler ()
		{
			if (cb_localIdeographFontFamily_Ljava_lang_String_ == null)
				cb_localIdeographFontFamily_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeLocalIdeographFontFamily_Ljava_lang_String_);
			return cb_localIdeographFontFamily_Ljava_lang_String_;
		}

		static IntPtr n_InvokeLocalIdeographFontFamily_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fontFamily)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fontFamily = JNIEnv.GetString (native_fontFamily, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeLocalIdeographFontFamily (fontFamily));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='localIdeographFontFamily' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("localIdeographFontFamily", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeLocalIdeographFontFamily_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeLocalIdeographFontFamily (string fontFamily)
		{
			const string __id = "localIdeographFontFamily.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			IntPtr native_fontFamily = JNIEnv.NewString (fontFamily);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fontFamily);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fontFamily);
			}
		}

		static Delegate cb_localIdeographFontFamily_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeLocalIdeographFontFamily_arrayLjava_lang_String_Handler ()
		{
			if (cb_localIdeographFontFamily_arrayLjava_lang_String_ == null)
				cb_localIdeographFontFamily_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeLocalIdeographFontFamily_arrayLjava_lang_String_);
			return cb_localIdeographFontFamily_arrayLjava_lang_String_;
		}

		static IntPtr n_InvokeLocalIdeographFontFamily_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fontFamilies)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] fontFamilies = (string[]) JNIEnv.GetArray (native_fontFamilies, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeLocalIdeographFontFamily (fontFamilies));
			if (fontFamilies != null)
				JNIEnv.CopyArray (fontFamilies, native_fontFamilies);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='localIdeographFontFamily' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("localIdeographFontFamily", "([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeLocalIdeographFontFamily_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeLocalIdeographFontFamily (params string[] fontFamilies)
		{
			const string __id = "localIdeographFontFamily.([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			IntPtr native_fontFamilies = JNIEnv.NewArray (fontFamilies);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fontFamilies);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (fontFamilies != null) {
					JNIEnv.CopyArray (native_fontFamilies, fontFamilies);
					JNIEnv.DeleteLocalRef (native_fontFamilies);
				}
			}
		}

		static Delegate cb_localIdeographFontFamilyEnabled_Z;
#pragma warning disable 0169
		static Delegate GetLocalIdeographFontFamilyEnabled_ZHandler ()
		{
			if (cb_localIdeographFontFamilyEnabled_Z == null)
				cb_localIdeographFontFamilyEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_LocalIdeographFontFamilyEnabled_Z);
			return cb_localIdeographFontFamilyEnabled_Z;
		}

		static IntPtr n_LocalIdeographFontFamilyEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalIdeographFontFamilyEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='localIdeographFontFamilyEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("localIdeographFontFamilyEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetLocalIdeographFontFamilyEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions LocalIdeographFontFamilyEnabled (bool enabled)
		{
			const string __id = "localIdeographFontFamilyEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_logoEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeLogoEnabled_ZHandler ()
		{
			if (cb_logoEnabled_Z == null)
				cb_logoEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeLogoEnabled_Z);
			return cb_logoEnabled_Z;
		}

		static IntPtr n_InvokeLogoEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeLogoEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='logoEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("logoEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeLogoEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeLogoEnabled (bool enabled)
		{
			const string __id = "logoEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_logoGravity_I;
#pragma warning disable 0169
		static Delegate GetInvokeLogoGravity_IHandler ()
		{
			if (cb_logoGravity_I == null)
				cb_logoGravity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeLogoGravity_I);
			return cb_logoGravity_I;
		}

		static IntPtr n_InvokeLogoGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeLogoGravity (gravity));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='logoGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("logoGravity", "(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeLogoGravity_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeLogoGravity (int gravity)
		{
			const string __id = "logoGravity.(I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (gravity);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_logoMargins_arrayI;
#pragma warning disable 0169
		static Delegate GetLogoMargins_arrayIHandler ()
		{
			if (cb_logoMargins_arrayI == null)
				cb_logoMargins_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LogoMargins_arrayI);
			return cb_logoMargins_arrayI;
		}

		static IntPtr n_LogoMargins_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_margins)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] margins = (int[]) JNIEnv.GetArray (native_margins, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LogoMargins (margins));
			if (margins != null)
				JNIEnv.CopyArray (margins, native_margins);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='logoMargins' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("logoMargins", "([I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetLogoMargins_arrayIHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions LogoMargins (int[] margins)
		{
			const string __id = "logoMargins.([I)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			IntPtr native_margins = JNIEnv.NewArray (margins);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_margins);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (margins != null) {
					JNIEnv.CopyArray (native_margins, margins);
					JNIEnv.DeleteLocalRef (native_margins);
				}
			}
		}

		static Delegate cb_maxZoomPreference_D;
#pragma warning disable 0169
		static Delegate GetInvokeMaxZoomPreference_DHandler ()
		{
			if (cb_maxZoomPreference_D == null)
				cb_maxZoomPreference_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_InvokeMaxZoomPreference_D);
			return cb_maxZoomPreference_D;
		}

		static IntPtr n_InvokeMaxZoomPreference_D (IntPtr jnienv, IntPtr native__this, double maxZoom)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeMaxZoomPreference (maxZoom));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='maxZoomPreference' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("maxZoomPreference", "(D)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeMaxZoomPreference_DHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeMaxZoomPreference (double maxZoom)
		{
			const string __id = "maxZoomPreference.(D)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxZoom);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_minZoomPreference_D;
#pragma warning disable 0169
		static Delegate GetInvokeMinZoomPreference_DHandler ()
		{
			if (cb_minZoomPreference_D == null)
				cb_minZoomPreference_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_InvokeMinZoomPreference_D);
			return cb_minZoomPreference_D;
		}

		static IntPtr n_InvokeMinZoomPreference_D (IntPtr jnienv, IntPtr native__this, double minZoom)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeMinZoomPreference (minZoom));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='minZoomPreference' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("minZoomPreference", "(D)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeMinZoomPreference_DHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeMinZoomPreference (double minZoom)
		{
			const string __id = "minZoomPreference.(D)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minZoom);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pixelRatio_F;
#pragma warning disable 0169
		static Delegate GetInvokePixelRatio_FHandler ()
		{
			if (cb_pixelRatio_F == null)
				cb_pixelRatio_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_InvokePixelRatio_F);
			return cb_pixelRatio_F;
		}

		static IntPtr n_InvokePixelRatio_F (IntPtr jnienv, IntPtr native__this, float pixelRatio)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokePixelRatio (pixelRatio));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='pixelRatio' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("pixelRatio", "(F)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokePixelRatio_FHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokePixelRatio (float pixelRatio)
		{
			const string __id = "pixelRatio.(F)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pixelRatio);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_quickZoomGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeQuickZoomGesturesEnabled_ZHandler ()
		{
			if (cb_quickZoomGesturesEnabled_Z == null)
				cb_quickZoomGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeQuickZoomGesturesEnabled_Z);
			return cb_quickZoomGesturesEnabled_Z;
		}

		static IntPtr n_InvokeQuickZoomGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeQuickZoomGesturesEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='quickZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("quickZoomGesturesEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeQuickZoomGesturesEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeQuickZoomGesturesEnabled (bool enabled)
		{
			const string __id = "quickZoomGesturesEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_renderSurfaceOnTop_Z;
#pragma warning disable 0169
		static Delegate GetInvokeRenderSurfaceOnTop_ZHandler ()
		{
			if (cb_renderSurfaceOnTop_Z == null)
				cb_renderSurfaceOnTop_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_InvokeRenderSurfaceOnTop_Z);
			return cb_renderSurfaceOnTop_Z;
		}

		static void n_InvokeRenderSurfaceOnTop_Z (IntPtr jnienv, IntPtr native__this, bool renderOnTop)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvokeRenderSurfaceOnTop (renderOnTop);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='renderSurfaceOnTop' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("renderSurfaceOnTop", "(Z)V", "GetInvokeRenderSurfaceOnTop_ZHandler")]
		public virtual unsafe void InvokeRenderSurfaceOnTop (bool renderOnTop)
		{
			const string __id = "renderSurfaceOnTop.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (renderOnTop);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_rotateGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeRotateGesturesEnabled_ZHandler ()
		{
			if (cb_rotateGesturesEnabled_Z == null)
				cb_rotateGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeRotateGesturesEnabled_Z);
			return cb_rotateGesturesEnabled_Z;
		}

		static IntPtr n_InvokeRotateGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeRotateGesturesEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='rotateGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("rotateGesturesEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeRotateGesturesEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeRotateGesturesEnabled (bool enabled)
		{
			const string __id = "rotateGesturesEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_scrollGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeScrollGesturesEnabled_ZHandler ()
		{
			if (cb_scrollGesturesEnabled_Z == null)
				cb_scrollGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeScrollGesturesEnabled_Z);
			return cb_scrollGesturesEnabled_Z;
		}

		static IntPtr n_InvokeScrollGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeScrollGesturesEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='scrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scrollGesturesEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeScrollGesturesEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeScrollGesturesEnabled (bool enabled)
		{
			const string __id = "scrollGesturesEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPrefetchesTiles_Z;
#pragma warning disable 0169
		static Delegate GetSetPrefetchesTiles_ZHandler ()
		{
			if (cb_setPrefetchesTiles_Z == null)
				cb_setPrefetchesTiles_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetPrefetchesTiles_Z);
			return cb_setPrefetchesTiles_Z;
		}

		static IntPtr n_SetPrefetchesTiles_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPrefetchesTiles (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='setPrefetchesTiles' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPrefetchesTiles", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetSetPrefetchesTiles_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions SetPrefetchesTiles (bool enable)
		{
			const string __id = "setPrefetchesTiles.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textureMode_Z;
#pragma warning disable 0169
		static Delegate GetInvokeTextureMode_ZHandler ()
		{
			if (cb_textureMode_Z == null)
				cb_textureMode_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeTextureMode_Z);
			return cb_textureMode_Z;
		}

		static IntPtr n_InvokeTextureMode_Z (IntPtr jnienv, IntPtr native__this, bool textureMode)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeTextureMode (textureMode));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='textureMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("textureMode", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeTextureMode_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeTextureMode (bool textureMode)
		{
			const string __id = "textureMode.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textureMode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_tiltGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeTiltGesturesEnabled_ZHandler ()
		{
			if (cb_tiltGesturesEnabled_Z == null)
				cb_tiltGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeTiltGesturesEnabled_Z);
			return cb_tiltGesturesEnabled_Z;
		}

		static IntPtr n_InvokeTiltGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeTiltGesturesEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='tiltGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("tiltGesturesEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeTiltGesturesEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeTiltGesturesEnabled (bool enabled)
		{
			const string __id = "tiltGesturesEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_translucentTextureSurface_Z;
#pragma warning disable 0169
		static Delegate GetInvokeTranslucentTextureSurface_ZHandler ()
		{
			if (cb_translucentTextureSurface_Z == null)
				cb_translucentTextureSurface_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeTranslucentTextureSurface_Z);
			return cb_translucentTextureSurface_Z;
		}

		static IntPtr n_InvokeTranslucentTextureSurface_Z (IntPtr jnienv, IntPtr native__this, bool translucentTextureSurface)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeTranslucentTextureSurface (translucentTextureSurface));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='translucentTextureSurface' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("translucentTextureSurface", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeTranslucentTextureSurface_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeTranslucentTextureSurface (bool translucentTextureSurface)
		{
			const string __id = "translucentTextureSurface.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (translucentTextureSurface);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoomGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeZoomGesturesEnabled_ZHandler ()
		{
			if (cb_zoomGesturesEnabled_Z == null)
				cb_zoomGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeZoomGesturesEnabled_Z);
			return cb_zoomGesturesEnabled_Z;
		}

		static IntPtr n_InvokeZoomGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeZoomGesturesEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMapOptions']/method[@name='zoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomGesturesEnabled", "(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "GetInvokeZoomGesturesEnabled_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions InvokeZoomGesturesEnabled (bool enabled)
		{
			const string __id = "zoomGesturesEnabled.(Z)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
