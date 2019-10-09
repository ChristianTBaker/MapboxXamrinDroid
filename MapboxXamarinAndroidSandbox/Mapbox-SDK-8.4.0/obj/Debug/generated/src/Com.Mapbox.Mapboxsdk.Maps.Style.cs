using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Style", DoNotGenerateAcw=true)]
	public partial class Style : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/field[@name='DARK']"
		[Register ("DARK")]
		public const string Dark = (string) "mapbox://styles/mapbox/dark-v10";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/field[@name='MAPBOX_STREETS']"
		[Register ("MAPBOX_STREETS")]
		public const string MapboxStreets = (string) "mapbox://styles/mapbox/streets-v11";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/field[@name='OUTDOORS']"
		[Register ("OUTDOORS")]
		public const string Outdoors = (string) "mapbox://styles/mapbox/outdoors-v11";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/field[@name='SATELLITE']"
		[Register ("SATELLITE")]
		public const string Satellite = (string) "mapbox://styles/mapbox/satellite-v9";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/field[@name='SATELLITE_STREETS']"
		[Register ("SATELLITE_STREETS")]
		public const string SatelliteStreets = (string) "mapbox://styles/mapbox/satellite-streets-v11";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/field[@name='TRAFFIC_DAY']"
		[Register ("TRAFFIC_DAY")]
		public const string TrafficDay = (string) "mapbox://styles/mapbox/traffic-day-v2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/field[@name='TRAFFIC_NIGHT']"
		[Register ("TRAFFIC_NIGHT")]
		public const string TrafficNight = (string) "mapbox://styles/mapbox/traffic-night-v2";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Style$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder.ImageWrapper']"
			[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Style$Builder$ImageWrapper", DoNotGenerateAcw=true)]
			public partial class ImageWrapper : global::Java.Lang.Object {

				internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/Style$Builder$ImageWrapper", typeof (ImageWrapper));
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

				protected ImageWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder.LayerAboveWrapper']"
			[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Style$Builder$LayerAboveWrapper", DoNotGenerateAcw=true)]
			public partial class LayerAboveWrapper : global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder.LayerWrapper {

				internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/Style$Builder$LayerAboveWrapper", typeof (LayerAboveWrapper));
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

				protected LayerAboveWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder.LayerAtWrapper']"
			[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Style$Builder$LayerAtWrapper", DoNotGenerateAcw=true)]
			public partial class LayerAtWrapper : global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder.LayerWrapper {

				internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/Style$Builder$LayerAtWrapper", typeof (LayerAtWrapper));
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

				protected LayerAtWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder.LayerBelowWrapper']"
			[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Style$Builder$LayerBelowWrapper", DoNotGenerateAcw=true)]
			public partial class LayerBelowWrapper : global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder.LayerWrapper {

				internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/Style$Builder$LayerBelowWrapper", typeof (LayerBelowWrapper));
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

				protected LayerBelowWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder.LayerWrapper']"
			[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Style$Builder$LayerWrapper", DoNotGenerateAcw=true)]
			public partial class LayerWrapper : global::Java.Lang.Object {

				internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/Style$Builder$LayerWrapper", typeof (LayerWrapper));
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

				protected LayerWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/Style$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/constructor[@name='Style.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			static Delegate cb_fromJson_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetFromJson_Ljava_lang_String_Handler ()
			{
				if (cb_fromJson_Ljava_lang_String_ == null)
					cb_fromJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromJson_Ljava_lang_String_);
				return cb_fromJson_Ljava_lang_String_;
			}

			static IntPtr n_FromJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_styleJson)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string styleJson = JNIEnv.GetString (native_styleJson, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromJson (styleJson));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetFromJson_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder FromJson (string styleJson)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_styleJson = JNIEnv.NewString (styleJson);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_styleJson);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_styleJson);
				}
			}

			static Delegate cb_fromUri_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetFromUri_Ljava_lang_String_Handler ()
			{
				if (cb_fromUri_Ljava_lang_String_ == null)
					cb_fromUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromUri_Ljava_lang_String_);
				return cb_fromUri_Ljava_lang_String_;
			}

			static IntPtr n_FromUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromUri (uri));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='fromUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromUri", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetFromUri_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder FromUri (string uri)
			{
				const string __id = "fromUri.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_uri = JNIEnv.NewString (uri);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_uri);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_uri);
				}
			}

			static Delegate cb_fromUrl_Ljava_lang_String_;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetFromUrl_Ljava_lang_String_Handler ()
			{
				if (cb_fromUrl_Ljava_lang_String_ == null)
					cb_fromUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromUrl_Ljava_lang_String_);
				return cb_fromUrl_Ljava_lang_String_;
			}

			[Obsolete]
			static IntPtr n_FromUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromUrl (url));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='fromUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Obsolete (@"deprecated")]
			[Register ("fromUrl", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetFromUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder FromUrl (string url)
			{
				const string __id = "fromUrl.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_url);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_url);
				}
			}

			static Delegate cb_withBitmapImages_arrayLandroid_util_Pair_;
#pragma warning disable 0169
			static Delegate GetWithBitmapImages_arrayLandroid_util_Pair_Handler ()
			{
				if (cb_withBitmapImages_arrayLandroid_util_Pair_ == null)
					cb_withBitmapImages_arrayLandroid_util_Pair_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithBitmapImages_arrayLandroid_util_Pair_);
				return cb_withBitmapImages_arrayLandroid_util_Pair_;
			}

			static IntPtr n_WithBitmapImages_arrayLandroid_util_Pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_values)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.Pair[] values = (global::Android.Util.Pair[]) JNIEnv.GetArray (native_values, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Util.Pair));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBitmapImages (values));
				if (values != null)
					JNIEnv.CopyArray (values, native_values);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withBitmapImages' and count(parameter)=1 and parameter[1][@type='android.util.Pair&lt;java.lang.String, android.graphics.Bitmap&gt;...']]"
			[Register ("withBitmapImages", "([Landroid/util/Pair;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithBitmapImages_arrayLandroid_util_Pair_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithBitmapImages (params global::Android.Util.Pair[] values)
			{
				const string __id = "withBitmapImages.([Landroid/util/Pair;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_values = JNIEnv.NewArray (values);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_values);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (values != null) {
						JNIEnv.CopyArray (native_values, values);
						JNIEnv.DeleteLocalRef (native_values);
					}
				}
			}

			static Delegate cb_withBitmapImages_ZarrayLandroid_util_Pair_;
#pragma warning disable 0169
			static Delegate GetWithBitmapImages_ZarrayLandroid_util_Pair_Handler ()
			{
				if (cb_withBitmapImages_ZarrayLandroid_util_Pair_ == null)
					cb_withBitmapImages_ZarrayLandroid_util_Pair_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr, IntPtr>) n_WithBitmapImages_ZarrayLandroid_util_Pair_);
				return cb_withBitmapImages_ZarrayLandroid_util_Pair_;
			}

			static IntPtr n_WithBitmapImages_ZarrayLandroid_util_Pair_ (IntPtr jnienv, IntPtr native__this, bool sdf, IntPtr native_values)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.Pair[] values = (global::Android.Util.Pair[]) JNIEnv.GetArray (native_values, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Util.Pair));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBitmapImages (sdf, values));
				if (values != null)
					JNIEnv.CopyArray (values, native_values);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withBitmapImages' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='android.util.Pair&lt;java.lang.String, android.graphics.Bitmap&gt;...']]"
			[Register ("withBitmapImages", "(Z[Landroid/util/Pair;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithBitmapImages_ZarrayLandroid_util_Pair_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithBitmapImages (bool sdf, params global::Android.Util.Pair[] values)
			{
				const string __id = "withBitmapImages.(Z[Landroid/util/Pair;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_values = JNIEnv.NewArray (values);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (sdf);
					__args [1] = new JniArgumentValue (native_values);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (values != null) {
						JNIEnv.CopyArray (native_values, values);
						JNIEnv.DeleteLocalRef (native_values);
					}
				}
			}

			static Delegate cb_withDrawableImages_arrayLandroid_util_Pair_;
#pragma warning disable 0169
			static Delegate GetWithDrawableImages_arrayLandroid_util_Pair_Handler ()
			{
				if (cb_withDrawableImages_arrayLandroid_util_Pair_ == null)
					cb_withDrawableImages_arrayLandroid_util_Pair_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDrawableImages_arrayLandroid_util_Pair_);
				return cb_withDrawableImages_arrayLandroid_util_Pair_;
			}

			static IntPtr n_WithDrawableImages_arrayLandroid_util_Pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_values)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.Pair[] values = (global::Android.Util.Pair[]) JNIEnv.GetArray (native_values, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Util.Pair));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDrawableImages (values));
				if (values != null)
					JNIEnv.CopyArray (values, native_values);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withDrawableImages' and count(parameter)=1 and parameter[1][@type='android.util.Pair&lt;java.lang.String, android.graphics.drawable.Drawable&gt;...']]"
			[Register ("withDrawableImages", "([Landroid/util/Pair;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithDrawableImages_arrayLandroid_util_Pair_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithDrawableImages (params global::Android.Util.Pair[] values)
			{
				const string __id = "withDrawableImages.([Landroid/util/Pair;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_values = JNIEnv.NewArray (values);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_values);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (values != null) {
						JNIEnv.CopyArray (native_values, values);
						JNIEnv.DeleteLocalRef (native_values);
					}
				}
			}

			static Delegate cb_withDrawableImages_ZarrayLandroid_util_Pair_;
#pragma warning disable 0169
			static Delegate GetWithDrawableImages_ZarrayLandroid_util_Pair_Handler ()
			{
				if (cb_withDrawableImages_ZarrayLandroid_util_Pair_ == null)
					cb_withDrawableImages_ZarrayLandroid_util_Pair_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr, IntPtr>) n_WithDrawableImages_ZarrayLandroid_util_Pair_);
				return cb_withDrawableImages_ZarrayLandroid_util_Pair_;
			}

			static IntPtr n_WithDrawableImages_ZarrayLandroid_util_Pair_ (IntPtr jnienv, IntPtr native__this, bool sdf, IntPtr native_values)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.Pair[] values = (global::Android.Util.Pair[]) JNIEnv.GetArray (native_values, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Util.Pair));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDrawableImages (sdf, values));
				if (values != null)
					JNIEnv.CopyArray (values, native_values);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withDrawableImages' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='android.util.Pair&lt;java.lang.String, android.graphics.drawable.Drawable&gt;...']]"
			[Register ("withDrawableImages", "(Z[Landroid/util/Pair;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithDrawableImages_ZarrayLandroid_util_Pair_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithDrawableImages (bool sdf, params global::Android.Util.Pair[] values)
			{
				const string __id = "withDrawableImages.(Z[Landroid/util/Pair;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_values = JNIEnv.NewArray (values);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (sdf);
					__args [1] = new JniArgumentValue (native_values);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (values != null) {
						JNIEnv.CopyArray (native_values, values);
						JNIEnv.DeleteLocalRef (native_values);
					}
				}
			}

			static Delegate cb_withImage_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetWithImage_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_withImage_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
					cb_withImage_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithImage_Ljava_lang_String_Landroid_graphics_Bitmap_);
				return cb_withImage_Ljava_lang_String_Landroid_graphics_Bitmap_;
			}

			static IntPtr n_WithImage_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_image)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithImage (id, image));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
			[Register ("withImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithImage_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithImage (string id, global::Android.Graphics.Bitmap image)
			{
				const string __id = "withImage.(Ljava/lang/String;Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			static Delegate cb_withImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z;
#pragma warning disable 0169
			static Delegate GetWithImage_Ljava_lang_String_Landroid_graphics_Bitmap_ZHandler ()
			{
				if (cb_withImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z == null)
					cb_withImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_WithImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z);
				return cb_withImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z;
			}

			static IntPtr n_WithImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_image, bool sdf)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithImage (id, image, sdf));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='boolean']]"
			[Register ("withImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;Z)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithImage_Ljava_lang_String_Landroid_graphics_Bitmap_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithImage (string id, global::Android.Graphics.Bitmap image, bool sdf)
			{
				const string __id = "withImage.(Ljava/lang/String;Landroid/graphics/Bitmap;Z)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
					__args [2] = new JniArgumentValue (sdf);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			static Delegate cb_withImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetWithImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_withImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ == null)
					cb_withImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_);
				return cb_withImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
			}

			static IntPtr n_WithImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_drawable)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithImage (id, drawable));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
			[Register ("withImage", "(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithImage (string id, global::Android.Graphics.Drawables.Drawable drawable)
			{
				const string __id = "withImage.(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			static Delegate cb_withImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Z;
#pragma warning disable 0169
			static Delegate GetWithImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ZHandler ()
			{
				if (cb_withImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Z == null)
					cb_withImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_WithImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Z);
				return cb_withImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Z;
			}

			static IntPtr n_WithImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_drawable, bool sdf)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithImage (id, drawable, sdf));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='boolean']]"
			[Register ("withImage", "(Ljava/lang/String;Landroid/graphics/drawable/Drawable;Z)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithImage (string id, global::Android.Graphics.Drawables.Drawable drawable, bool sdf)
			{
				const string __id = "withImage.(Ljava/lang/String;Landroid/graphics/drawable/Drawable;Z)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
					__args [2] = new JniArgumentValue (sdf);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			static Delegate cb_withLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_;
#pragma warning disable 0169
			static Delegate GetWithLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_Handler ()
			{
				if (cb_withLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_ == null)
					cb_withLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_);
				return cb_withLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_;
			}

			static IntPtr n_WithLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layer)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (native_layer, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLayer (layer));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withLayer' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer']]"
			[Register ("withLayer", "(Lcom/mapbox/mapboxsdk/style/layers/Layer;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithLayer (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer)
			{
				const string __id = "withLayer.(Lcom/mapbox/mapboxsdk/style/layers/Layer;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((layer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layer).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_Handler ()
			{
				if (cb_withLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ == null)
					cb_withLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_);
				return cb_withLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_;
			}

			static IntPtr n_WithLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layer, IntPtr native_aboveLayerId)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (native_layer, JniHandleOwnership.DoNotTransfer);
				string aboveLayerId = JNIEnv.GetString (native_aboveLayerId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLayerAbove (layer, aboveLayerId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withLayerAbove' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer'] and parameter[2][@type='java.lang.String']]"
			[Register ("withLayerAbove", "(Lcom/mapbox/mapboxsdk/style/layers/Layer;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithLayerAbove (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer, string aboveLayerId)
			{
				const string __id = "withLayerAbove.(Lcom/mapbox/mapboxsdk/style/layers/Layer;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_aboveLayerId = JNIEnv.NewString (aboveLayerId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((layer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layer).Handle);
					__args [1] = new JniArgumentValue (native_aboveLayerId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_aboveLayerId);
				}
			}

			static Delegate cb_withLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I;
#pragma warning disable 0169
			static Delegate GetWithLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_IHandler ()
			{
				if (cb_withLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I == null)
					cb_withLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_WithLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I);
				return cb_withLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I;
			}

			static IntPtr n_WithLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_layer, int index)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (native_layer, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLayerAt (layer, index));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withLayerAt' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer'] and parameter[2][@type='int']]"
			[Register ("withLayerAt", "(Lcom/mapbox/mapboxsdk/style/layers/Layer;I)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_IHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithLayerAt (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer, int index)
			{
				const string __id = "withLayerAt.(Lcom/mapbox/mapboxsdk/style/layers/Layer;I)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((layer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layer).Handle);
					__args [1] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_Handler ()
			{
				if (cb_withLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ == null)
					cb_withLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_);
				return cb_withLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_;
			}

			static IntPtr n_WithLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layer, IntPtr native_belowLayerId)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (native_layer, JniHandleOwnership.DoNotTransfer);
				string belowLayerId = JNIEnv.GetString (native_belowLayerId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLayerBelow (layer, belowLayerId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withLayerBelow' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer'] and parameter[2][@type='java.lang.String']]"
			[Register ("withLayerBelow", "(Lcom/mapbox/mapboxsdk/style/layers/Layer;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithLayerBelow (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer, string belowLayerId)
			{
				const string __id = "withLayerBelow.(Lcom/mapbox/mapboxsdk/style/layers/Layer;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_belowLayerId = JNIEnv.NewString (belowLayerId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((layer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layer).Handle);
					__args [1] = new JniArgumentValue (native_belowLayerId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_belowLayerId);
				}
			}

			static Delegate cb_withLayers_arrayLcom_mapbox_mapboxsdk_style_layers_Layer_;
#pragma warning disable 0169
			static Delegate GetWithLayers_arrayLcom_mapbox_mapboxsdk_style_layers_Layer_Handler ()
			{
				if (cb_withLayers_arrayLcom_mapbox_mapboxsdk_style_layers_Layer_ == null)
					cb_withLayers_arrayLcom_mapbox_mapboxsdk_style_layers_Layer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLayers_arrayLcom_mapbox_mapboxsdk_style_layers_Layer_);
				return cb_withLayers_arrayLcom_mapbox_mapboxsdk_style_layers_Layer_;
			}

			static IntPtr n_WithLayers_arrayLcom_mapbox_mapboxsdk_style_layers_Layer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layers)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer[] layers = (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer[]) JNIEnv.GetArray (native_layers, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLayers (layers));
				if (layers != null)
					JNIEnv.CopyArray (layers, native_layers);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withLayers' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer...']]"
			[Register ("withLayers", "([Lcom/mapbox/mapboxsdk/style/layers/Layer;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithLayers_arrayLcom_mapbox_mapboxsdk_style_layers_Layer_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithLayers (params global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer[] layers)
			{
				const string __id = "withLayers.([Lcom/mapbox/mapboxsdk/style/layers/Layer;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_layers = JNIEnv.NewArray (layers);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_layers);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (layers != null) {
						JNIEnv.CopyArray (native_layers, layers);
						JNIEnv.DeleteLocalRef (native_layers);
					}
				}
			}

			static Delegate cb_withSource_Lcom_mapbox_mapboxsdk_style_sources_Source_;
#pragma warning disable 0169
			static Delegate GetWithSource_Lcom_mapbox_mapboxsdk_style_sources_Source_Handler ()
			{
				if (cb_withSource_Lcom_mapbox_mapboxsdk_style_sources_Source_ == null)
					cb_withSource_Lcom_mapbox_mapboxsdk_style_sources_Source_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSource_Lcom_mapbox_mapboxsdk_style_sources_Source_);
				return cb_withSource_Lcom_mapbox_mapboxsdk_style_sources_Source_;
			}

			static IntPtr n_WithSource_Lcom_mapbox_mapboxsdk_style_sources_Source_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Style.Sources.Source source = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (native_source, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSource (source));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withSource' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.sources.Source']]"
			[Register ("withSource", "(Lcom/mapbox/mapboxsdk/style/sources/Source;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithSource_Lcom_mapbox_mapboxsdk_style_sources_Source_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithSource (global::Com.Mapbox.Mapboxsdk.Style.Sources.Source source)
			{
				const string __id = "withSource.(Lcom/mapbox/mapboxsdk/style/sources/Source;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withSources_arrayLcom_mapbox_mapboxsdk_style_sources_Source_;
#pragma warning disable 0169
			static Delegate GetWithSources_arrayLcom_mapbox_mapboxsdk_style_sources_Source_Handler ()
			{
				if (cb_withSources_arrayLcom_mapbox_mapboxsdk_style_sources_Source_ == null)
					cb_withSources_arrayLcom_mapbox_mapboxsdk_style_sources_Source_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSources_arrayLcom_mapbox_mapboxsdk_style_sources_Source_);
				return cb_withSources_arrayLcom_mapbox_mapboxsdk_style_sources_Source_;
			}

			static IntPtr n_WithSources_arrayLcom_mapbox_mapboxsdk_style_sources_Source_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sources)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Style.Sources.Source[] sources = (global::Com.Mapbox.Mapboxsdk.Style.Sources.Source[]) JNIEnv.GetArray (native_sources, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Style.Sources.Source));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSources (sources));
				if (sources != null)
					JNIEnv.CopyArray (sources, native_sources);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withSources' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.sources.Source...']]"
			[Register ("withSources", "([Lcom/mapbox/mapboxsdk/style/sources/Source;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithSources_arrayLcom_mapbox_mapboxsdk_style_sources_Source_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithSources (params global::Com.Mapbox.Mapboxsdk.Style.Sources.Source[] sources)
			{
				const string __id = "withSources.([Lcom/mapbox/mapboxsdk/style/sources/Source;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				IntPtr native_sources = JNIEnv.NewArray (sources);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_sources);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (sources != null) {
						JNIEnv.CopyArray (native_sources, sources);
						JNIEnv.DeleteLocalRef (native_sources);
					}
				}
			}

			static Delegate cb_withTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
			static Delegate GetWithTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
			{
				if (cb_withTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
					cb_withTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
				return cb_withTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
			}

			static IntPtr n_WithTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transition)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions transition = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_transition, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithTransition (transition));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style.Builder']/method[@name='withTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("withTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;", "GetWithTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder WithTransition (global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions transition)
			{
				const string __id = "withTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)Lcom/mapbox/mapboxsdk/maps/Style$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((transition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transition).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='Style.OnStyleLoaded']"
		[Register ("com/mapbox/mapboxsdk/maps/Style$OnStyleLoaded", "", "Com.Mapbox.Mapboxsdk.Maps.Style/IOnStyleLoadedInvoker")]
		public partial interface IOnStyleLoaded : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='Style.OnStyleLoaded']/method[@name='onStyleLoaded' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.Style']]"
			[Register ("onStyleLoaded", "(Lcom/mapbox/mapboxsdk/maps/Style;)V", "GetOnStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_Handler:Com.Mapbox.Mapboxsdk.Maps.Style/IOnStyleLoadedInvoker, Mapbox-SDK-8.4.0")]
			void OnStyleLoaded (global::Com.Mapbox.Mapboxsdk.Maps.Style p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Style$OnStyleLoaded", DoNotGenerateAcw=true)]
		internal class IOnStyleLoadedInvoker : global::Java.Lang.Object, IOnStyleLoaded {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/Style$OnStyleLoaded", typeof (IOnStyleLoadedInvoker));

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

			public static IOnStyleLoaded GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnStyleLoaded> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.Style.OnStyleLoaded"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnStyleLoadedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_;
#pragma warning disable 0169
			static Delegate GetOnStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_Handler ()
			{
				if (cb_onStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_ == null)
					cb_onStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_);
				return cb_onStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_;
			}

			static void n_OnStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.IOnStyleLoaded __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.IOnStyleLoaded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Maps.Style p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStyleLoaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_;
			public unsafe void OnStyleLoaded (global::Com.Mapbox.Mapboxsdk.Maps.Style p0)
			{
				if (id_onStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_ == IntPtr.Zero)
					id_onStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_ = JNIEnv.GetMethodID (class_ref, "onStyleLoaded", "(Lcom/mapbox/mapboxsdk/maps/Style;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='Style.StyleUrl']"
		[Register ("com/mapbox/mapboxsdk/maps/Style$StyleUrl", "", "Com.Mapbox.Mapboxsdk.Maps.Style/IStyleUrlInvoker")]
		public partial interface IStyleUrl : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/Style$StyleUrl", DoNotGenerateAcw=true)]
		internal class IStyleUrlInvoker : global::Java.Lang.Object, IStyleUrl {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/Style$StyleUrl", typeof (IStyleUrlInvoker));

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

			public static IStyleUrl GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStyleUrl> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.Style.StyleUrl"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStyleUrlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.IStyleUrl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.IStyleUrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.IStyleUrl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.IStyleUrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.IStyleUrl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.IStyleUrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Style.IStyleUrl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style.IStyleUrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/Style", typeof (Style));
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

		protected Style (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isFullyLoaded;
#pragma warning disable 0169
		static Delegate GetIsFullyLoadedHandler ()
		{
			if (cb_isFullyLoaded == null)
				cb_isFullyLoaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFullyLoaded);
			return cb_isFullyLoaded;
		}

		static bool n_IsFullyLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFullyLoaded;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFullyLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='isFullyLoaded' and count(parameter)=0]"
			[Register ("isFullyLoaded", "()Z", "GetIsFullyLoadedHandler")]
			get {
				const string __id = "isFullyLoaded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getJson;
#pragma warning disable 0169
		static Delegate GetGetJsonHandler ()
		{
			if (cb_getJson == null)
				cb_getJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJson);
			return cb_getJson;
		}

		static IntPtr n_GetJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Json);
		}
#pragma warning restore 0169

		public virtual unsafe string Json {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getJson' and count(parameter)=0]"
			[Register ("getJson", "()Ljava/lang/String;", "GetGetJsonHandler")]
			get {
				const string __id = "getJson.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLayers;
#pragma warning disable 0169
		static Delegate GetGetLayersHandler ()
		{
			if (cb_getLayers == null)
				cb_getLayers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayers);
			return cb_getLayers;
		}

		static IntPtr n_GetLayers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer>.ToLocalJniHandle (__this.Layers);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> Layers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getLayers' and count(parameter)=0]"
			[Register ("getLayers", "()Ljava/util/List;", "GetGetLayersHandler")]
			get {
				const string __id = "getLayers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLight;
#pragma warning disable 0169
		static Delegate GetGetLightHandler ()
		{
			if (cb_getLight == null)
				cb_getLight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLight);
			return cb_getLight;
		}

		static IntPtr n_GetLight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Light);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Light.Light Light {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getLight' and count(parameter)=0]"
			[Register ("getLight", "()Lcom/mapbox/mapboxsdk/style/light/Light;", "GetGetLightHandler")]
			get {
				const string __id = "getLight.()Lcom/mapbox/mapboxsdk/style/light/Light;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Light> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSources;
#pragma warning disable 0169
		static Delegate GetGetSourcesHandler ()
		{
			if (cb_getSources == null)
				cb_getSources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSources);
			return cb_getSources;
		}

		static IntPtr n_GetSources (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source>.ToLocalJniHandle (__this.Sources);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> Sources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getSources' and count(parameter)=0]"
			[Register ("getSources", "()Ljava/util/List;", "GetGetSourcesHandler")]
			get {
				const string __id = "getSources.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransition;
#pragma warning disable 0169
		static Delegate GetGetTransitionHandler ()
		{
			if (cb_getTransition == null)
				cb_getTransition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransition);
			return cb_getTransition;
		}

		static IntPtr n_GetTransition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transition);
		}
#pragma warning restore 0169

		static Delegate cb_setTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
#pragma warning disable 0169
		static Delegate GetSetTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler ()
		{
			if (cb_setTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ == null)
				cb_setTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_);
			return cb_setTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_;
		}

		static void n_SetTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transitionOptions)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions transitionOptions = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (native_transitionOptions, JniHandleOwnership.DoNotTransfer);
			__this.Transition = transitionOptions;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions Transition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getTransition' and count(parameter)=0]"
			[Register ("getTransition", "()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "GetGetTransitionHandler")]
			get {
				const string __id = "getTransition.()Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='setTransition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.TransitionOptions']]"
			[Register ("setTransition", "(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V", "GetSetTransition_Lcom_mapbox_mapboxsdk_style_layers_TransitionOptions_Handler")]
			set {
				const string __id = "setTransition.(Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uri);
		}
#pragma warning restore 0169

		public virtual unsafe string Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getUri' and count(parameter)=0]"
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
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getUrl' and count(parameter)=0]"
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

		static Delegate cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetAddImage_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddImage_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_AddImage_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_image)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			__this.AddImage (name, image);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("addImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetAddImage_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void AddImage (string name, global::Android.Graphics.Bitmap image)
		{
			const string __id = "addImage.(Ljava/lang/String;Landroid/graphics/Bitmap;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z;
#pragma warning disable 0169
		static Delegate GetAddImage_Ljava_lang_String_Landroid_graphics_Bitmap_ZHandler ()
		{
			if (cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z == null)
				cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z);
			return cb_addImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z;
		}

		static void n_AddImage_Ljava_lang_String_Landroid_graphics_Bitmap_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_bitmap, bool sdf)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.AddImage (name, bitmap, sdf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='boolean']]"
		[Register ("addImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;Z)V", "GetAddImage_Ljava_lang_String_Landroid_graphics_Bitmap_ZHandler")]
		public virtual unsafe void AddImage (string name, global::Android.Graphics.Bitmap bitmap, bool sdf)
		{
			const string __id = "addImage.(Ljava/lang/String;Landroid/graphics/Bitmap;Z)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [2] = new JniArgumentValue (sdf);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_addImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetAddImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_addImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ == null)
				cb_addImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_);
			return cb_addImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
		}

		static void n_AddImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_drawable)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.AddImage (name, drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("addImage", "(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V", "GetAddImage_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void AddImage (string name, global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "addImage.(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_addImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetAddImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_addImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_addImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_addImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_AddImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_image)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			__this.AddImageAsync (name, image);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImageAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("addImageAsync", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetAddImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void AddImageAsync (string name, global::Android.Graphics.Bitmap image)
		{
			const string __id = "addImageAsync.(Ljava/lang/String;Landroid/graphics/Bitmap;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_addImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_Z;
#pragma warning disable 0169
		static Delegate GetAddImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_ZHandler ()
		{
			if (cb_addImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_Z == null)
				cb_addImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_Z);
			return cb_addImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_Z;
		}

		static void n_AddImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_bitmap, bool sdf)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.AddImageAsync (name, bitmap, sdf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImageAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='boolean']]"
		[Register ("addImageAsync", "(Ljava/lang/String;Landroid/graphics/Bitmap;Z)V", "GetAddImageAsync_Ljava_lang_String_Landroid_graphics_Bitmap_ZHandler")]
		public virtual unsafe void AddImageAsync (string name, global::Android.Graphics.Bitmap bitmap, bool sdf)
		{
			const string __id = "addImageAsync.(Ljava/lang/String;Landroid/graphics/Bitmap;Z)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [2] = new JniArgumentValue (sdf);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_addImageAsync_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetAddImageAsync_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_addImageAsync_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ == null)
				cb_addImageAsync_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddImageAsync_Ljava_lang_String_Landroid_graphics_drawable_Drawable_);
			return cb_addImageAsync_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
		}

		static void n_AddImageAsync_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_drawable)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.AddImageAsync (name, drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImageAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("addImageAsync", "(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V", "GetAddImageAsync_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void AddImageAsync (string name, global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "addImageAsync.(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_addImages_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetAddImages_Ljava_util_HashMap_Handler ()
		{
			if (cb_addImages_Ljava_util_HashMap_ == null)
				cb_addImages_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddImages_Ljava_util_HashMap_);
			return cb_addImages_Ljava_util_HashMap_;
		}

		static void n_AddImages_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_images)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var images = global::Android.Runtime.JavaDictionary<string, global::Android.Graphics.Bitmap>.FromJniHandle (native_images, JniHandleOwnership.DoNotTransfer);
			__this.AddImages (images);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImages' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, android.graphics.Bitmap&gt;']]"
		[Register ("addImages", "(Ljava/util/HashMap;)V", "GetAddImages_Ljava_util_HashMap_Handler")]
		public virtual unsafe void AddImages (global::System.Collections.Generic.IDictionary<string, global::Android.Graphics.Bitmap> images)
		{
			const string __id = "addImages.(Ljava/util/HashMap;)V";
			IntPtr native_images = global::Android.Runtime.JavaDictionary<string, global::Android.Graphics.Bitmap>.ToLocalJniHandle (images);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_images);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_images);
			}
		}

		static Delegate cb_addImages_Ljava_util_HashMap_Z;
#pragma warning disable 0169
		static Delegate GetAddImages_Ljava_util_HashMap_ZHandler ()
		{
			if (cb_addImages_Ljava_util_HashMap_Z == null)
				cb_addImages_Ljava_util_HashMap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddImages_Ljava_util_HashMap_Z);
			return cb_addImages_Ljava_util_HashMap_Z;
		}

		static void n_AddImages_Ljava_util_HashMap_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_images, bool sdf)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var images = global::Android.Runtime.JavaDictionary<string, global::Android.Graphics.Bitmap>.FromJniHandle (native_images, JniHandleOwnership.DoNotTransfer);
			__this.AddImages (images, sdf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImages' and count(parameter)=2 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, android.graphics.Bitmap&gt;'] and parameter[2][@type='boolean']]"
		[Register ("addImages", "(Ljava/util/HashMap;Z)V", "GetAddImages_Ljava_util_HashMap_ZHandler")]
		public virtual unsafe void AddImages (global::System.Collections.Generic.IDictionary<string, global::Android.Graphics.Bitmap> images, bool sdf)
		{
			const string __id = "addImages.(Ljava/util/HashMap;Z)V";
			IntPtr native_images = global::Android.Runtime.JavaDictionary<string, global::Android.Graphics.Bitmap>.ToLocalJniHandle (images);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_images);
				__args [1] = new JniArgumentValue (sdf);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_images);
			}
		}

		static Delegate cb_addImagesAsync_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetAddImagesAsync_Ljava_util_HashMap_Handler ()
		{
			if (cb_addImagesAsync_Ljava_util_HashMap_ == null)
				cb_addImagesAsync_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddImagesAsync_Ljava_util_HashMap_);
			return cb_addImagesAsync_Ljava_util_HashMap_;
		}

		static void n_AddImagesAsync_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_images)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var images = global::Android.Runtime.JavaDictionary<string, global::Android.Graphics.Bitmap>.FromJniHandle (native_images, JniHandleOwnership.DoNotTransfer);
			__this.AddImagesAsync (images);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImagesAsync' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, android.graphics.Bitmap&gt;']]"
		[Register ("addImagesAsync", "(Ljava/util/HashMap;)V", "GetAddImagesAsync_Ljava_util_HashMap_Handler")]
		public virtual unsafe void AddImagesAsync (global::System.Collections.Generic.IDictionary<string, global::Android.Graphics.Bitmap> images)
		{
			const string __id = "addImagesAsync.(Ljava/util/HashMap;)V";
			IntPtr native_images = global::Android.Runtime.JavaDictionary<string, global::Android.Graphics.Bitmap>.ToLocalJniHandle (images);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_images);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_images);
			}
		}

		static Delegate cb_addImagesAsync_Ljava_util_HashMap_Z;
#pragma warning disable 0169
		static Delegate GetAddImagesAsync_Ljava_util_HashMap_ZHandler ()
		{
			if (cb_addImagesAsync_Ljava_util_HashMap_Z == null)
				cb_addImagesAsync_Ljava_util_HashMap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddImagesAsync_Ljava_util_HashMap_Z);
			return cb_addImagesAsync_Ljava_util_HashMap_Z;
		}

		static void n_AddImagesAsync_Ljava_util_HashMap_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_images, bool sdf)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var images = global::Android.Runtime.JavaDictionary<string, global::Android.Graphics.Bitmap>.FromJniHandle (native_images, JniHandleOwnership.DoNotTransfer);
			__this.AddImagesAsync (images, sdf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addImagesAsync' and count(parameter)=2 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, android.graphics.Bitmap&gt;'] and parameter[2][@type='boolean']]"
		[Register ("addImagesAsync", "(Ljava/util/HashMap;Z)V", "GetAddImagesAsync_Ljava_util_HashMap_ZHandler")]
		public virtual unsafe void AddImagesAsync (global::System.Collections.Generic.IDictionary<string, global::Android.Graphics.Bitmap> images, bool sdf)
		{
			const string __id = "addImagesAsync.(Ljava/util/HashMap;Z)V";
			IntPtr native_images = global::Android.Runtime.JavaDictionary<string, global::Android.Graphics.Bitmap>.ToLocalJniHandle (images);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_images);
				__args [1] = new JniArgumentValue (sdf);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_images);
			}
		}

		static Delegate cb_addLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_;
#pragma warning disable 0169
		static Delegate GetAddLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_Handler ()
		{
			if (cb_addLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_ == null)
				cb_addLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_);
			return cb_addLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_;
		}

		static void n_AddLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layer)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (native_layer, JniHandleOwnership.DoNotTransfer);
			__this.AddLayer (layer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addLayer' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer']]"
		[Register ("addLayer", "(Lcom/mapbox/mapboxsdk/style/layers/Layer;)V", "GetAddLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_Handler")]
		public virtual unsafe void AddLayer (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer)
		{
			const string __id = "addLayer.(Lcom/mapbox/mapboxsdk/style/layers/Layer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_Handler ()
		{
			if (cb_addLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ == null)
				cb_addLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_);
			return cb_addLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_;
		}

		static void n_AddLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layer, IntPtr native_above)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (native_layer, JniHandleOwnership.DoNotTransfer);
			string above = JNIEnv.GetString (native_above, JniHandleOwnership.DoNotTransfer);
			__this.AddLayerAbove (layer, above);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addLayerAbove' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer'] and parameter[2][@type='java.lang.String']]"
		[Register ("addLayerAbove", "(Lcom/mapbox/mapboxsdk/style/layers/Layer;Ljava/lang/String;)V", "GetAddLayerAbove_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_Handler")]
		public virtual unsafe void AddLayerAbove (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer, string above)
		{
			const string __id = "addLayerAbove.(Lcom/mapbox/mapboxsdk/style/layers/Layer;Ljava/lang/String;)V";
			IntPtr native_above = JNIEnv.NewString (above);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((layer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layer).Handle);
				__args [1] = new JniArgumentValue (native_above);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_above);
			}
		}

		static Delegate cb_addLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I;
#pragma warning disable 0169
		static Delegate GetAddLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_IHandler ()
		{
			if (cb_addLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I == null)
				cb_addLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I);
			return cb_addLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I;
		}

		static void n_AddLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_layer, int index)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (native_layer, JniHandleOwnership.DoNotTransfer);
			__this.AddLayerAt (layer, index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addLayerAt' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer'] and parameter[2][@type='int']]"
		[Register ("addLayerAt", "(Lcom/mapbox/mapboxsdk/style/layers/Layer;I)V", "GetAddLayerAt_Lcom_mapbox_mapboxsdk_style_layers_Layer_IHandler")]
		public virtual unsafe void AddLayerAt (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer, int index)
		{
			const string __id = "addLayerAt.(Lcom/mapbox/mapboxsdk/style/layers/Layer;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((layer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layer).Handle);
				__args [1] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_Handler ()
		{
			if (cb_addLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ == null)
				cb_addLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_);
			return cb_addLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_;
		}

		static void n_AddLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layer, IntPtr native_below)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (native_layer, JniHandleOwnership.DoNotTransfer);
			string below = JNIEnv.GetString (native_below, JniHandleOwnership.DoNotTransfer);
			__this.AddLayerBelow (layer, below);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addLayerBelow' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer'] and parameter[2][@type='java.lang.String']]"
		[Register ("addLayerBelow", "(Lcom/mapbox/mapboxsdk/style/layers/Layer;Ljava/lang/String;)V", "GetAddLayerBelow_Lcom_mapbox_mapboxsdk_style_layers_Layer_Ljava_lang_String_Handler")]
		public virtual unsafe void AddLayerBelow (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer, string below)
		{
			const string __id = "addLayerBelow.(Lcom/mapbox/mapboxsdk/style/layers/Layer;Ljava/lang/String;)V";
			IntPtr native_below = JNIEnv.NewString (below);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((layer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layer).Handle);
				__args [1] = new JniArgumentValue (native_below);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_below);
			}
		}

		static Delegate cb_addSource_Lcom_mapbox_mapboxsdk_style_sources_Source_;
#pragma warning disable 0169
		static Delegate GetAddSource_Lcom_mapbox_mapboxsdk_style_sources_Source_Handler ()
		{
			if (cb_addSource_Lcom_mapbox_mapboxsdk_style_sources_Source_ == null)
				cb_addSource_Lcom_mapbox_mapboxsdk_style_sources_Source_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSource_Lcom_mapbox_mapboxsdk_style_sources_Source_);
			return cb_addSource_Lcom_mapbox_mapboxsdk_style_sources_Source_;
		}

		static void n_AddSource_Lcom_mapbox_mapboxsdk_style_sources_Source_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Sources.Source source = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.AddSource (source);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='addSource' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.sources.Source']]"
		[Register ("addSource", "(Lcom/mapbox/mapboxsdk/style/sources/Source;)V", "GetAddSource_Lcom_mapbox_mapboxsdk_style_sources_Source_Handler")]
		public virtual unsafe void AddSource (global::Com.Mapbox.Mapboxsdk.Style.Sources.Source source)
		{
			const string __id = "addSource.(Lcom/mapbox/mapboxsdk/style/sources/Source;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getImage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetImage_Ljava_lang_String_Handler ()
		{
			if (cb_getImage_Ljava_lang_String_ == null)
				cb_getImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImage_Ljava_lang_String_);
			return cb_getImage_Ljava_lang_String_;
		}

		static IntPtr n_GetImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetImage (id));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getImage", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGetImage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetImage (string id)
		{
			const string __id = "getImage.(Ljava/lang/String;)Landroid/graphics/Bitmap;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_getLayer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLayer_Ljava_lang_String_Handler ()
		{
			if (cb_getLayer_Ljava_lang_String_ == null)
				cb_getLayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLayer_Ljava_lang_String_);
			return cb_getLayer_Ljava_lang_String_;
		}

		static IntPtr n_GetLayer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLayer (id));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLayer", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/Layer;", "GetGetLayer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer GetLayer (string id)
		{
			const string __id = "getLayer.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/Layer;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_getLayerAs_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLayerAs_Ljava_lang_String_Handler ()
		{
			if (cb_getLayerAs_Ljava_lang_String_ == null)
				cb_getLayerAs_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLayerAs_Ljava_lang_String_);
			return cb_getLayerAs_Ljava_lang_String_;
		}

		static IntPtr n_GetLayerAs_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layerId)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string layerId = JNIEnv.GetString (native_layerId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLayerAs (layerId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getLayerAs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLayerAs", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/Layer;", "GetGetLayerAs_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mapbox.mapboxsdk.style.layers.Layer"})]
		public virtual unsafe global::Java.Lang.Object GetLayerAs (string layerId)
		{
			const string __id = "getLayerAs.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/Layer;";
			IntPtr native_layerId = JNIEnv.NewString (layerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_layerId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_layerId);
			}
		}

		static Delegate cb_getSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSource_Ljava_lang_String_Handler ()
		{
			if (cb_getSource_Ljava_lang_String_ == null)
				cb_getSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSource_Ljava_lang_String_);
			return cb_getSource_Ljava_lang_String_;
		}

		static IntPtr n_GetSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSource (id));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSource", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/sources/Source;", "GetGetSource_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.Source GetSource (string id)
		{
			const string __id = "getSource.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/sources/Source;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_getSourceAs_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSourceAs_Ljava_lang_String_Handler ()
		{
			if (cb_getSourceAs_Ljava_lang_String_ == null)
				cb_getSourceAs_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSourceAs_Ljava_lang_String_);
			return cb_getSourceAs_Ljava_lang_String_;
		}

		static IntPtr n_GetSourceAs_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceId)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceId = JNIEnv.GetString (native_sourceId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSourceAs (sourceId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='getSourceAs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSourceAs", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/sources/Source;", "GetGetSourceAs_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mapbox.mapboxsdk.style.sources.Source"})]
		public virtual unsafe global::Java.Lang.Object GetSourceAs (string sourceId)
		{
			const string __id = "getSourceAs.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/sources/Source;";
			IntPtr native_sourceId = JNIEnv.NewString (sourceId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourceId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceId);
			}
		}

		static Delegate cb_removeImage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveImage_Ljava_lang_String_Handler ()
		{
			if (cb_removeImage_Ljava_lang_String_ == null)
				cb_removeImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveImage_Ljava_lang_String_);
			return cb_removeImage_Ljava_lang_String_;
		}

		static void n_RemoveImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RemoveImage (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='removeImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeImage", "(Ljava/lang/String;)V", "GetRemoveImage_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveImage (string name)
		{
			const string __id = "removeImage.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_removeLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_;
#pragma warning disable 0169
		static Delegate GetRemoveLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_Handler ()
		{
			if (cb_removeLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_ == null)
				cb_removeLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_);
			return cb_removeLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_;
		}

		static bool n_RemoveLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layer)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (native_layer, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveLayer (layer);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='removeLayer' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.Layer']]"
		[Register ("removeLayer", "(Lcom/mapbox/mapboxsdk/style/layers/Layer;)Z", "GetRemoveLayer_Lcom_mapbox_mapboxsdk_style_layers_Layer_Handler")]
		public virtual unsafe bool RemoveLayer (global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer layer)
		{
			const string __id = "removeLayer.(Lcom/mapbox/mapboxsdk/style/layers/Layer;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeLayer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveLayer_Ljava_lang_String_Handler ()
		{
			if (cb_removeLayer_Ljava_lang_String_ == null)
				cb_removeLayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveLayer_Ljava_lang_String_);
			return cb_removeLayer_Ljava_lang_String_;
		}

		static bool n_RemoveLayer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layerId)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string layerId = JNIEnv.GetString (native_layerId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveLayer (layerId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='removeLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeLayer", "(Ljava/lang/String;)Z", "GetRemoveLayer_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemoveLayer (string layerId)
		{
			const string __id = "removeLayer.(Ljava/lang/String;)Z";
			IntPtr native_layerId = JNIEnv.NewString (layerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_layerId);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_layerId);
			}
		}

		static Delegate cb_removeLayerAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveLayerAt_IHandler ()
		{
			if (cb_removeLayerAt_I == null)
				cb_removeLayerAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RemoveLayerAt_I);
			return cb_removeLayerAt_I;
		}

		static bool n_RemoveLayerAt_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveLayerAt (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='removeLayerAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeLayerAt", "(I)Z", "GetRemoveLayerAt_IHandler")]
		public virtual unsafe bool RemoveLayerAt (int index)
		{
			const string __id = "removeLayerAt.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeSource_Lcom_mapbox_mapboxsdk_style_sources_Source_;
#pragma warning disable 0169
		static Delegate GetRemoveSource_Lcom_mapbox_mapboxsdk_style_sources_Source_Handler ()
		{
			if (cb_removeSource_Lcom_mapbox_mapboxsdk_style_sources_Source_ == null)
				cb_removeSource_Lcom_mapbox_mapboxsdk_style_sources_Source_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveSource_Lcom_mapbox_mapboxsdk_style_sources_Source_);
			return cb_removeSource_Lcom_mapbox_mapboxsdk_style_sources_Source_;
		}

		static bool n_RemoveSource_Lcom_mapbox_mapboxsdk_style_sources_Source_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Sources.Source source = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (native_source, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveSource (source);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='removeSource' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.sources.Source']]"
		[Register ("removeSource", "(Lcom/mapbox/mapboxsdk/style/sources/Source;)Z", "GetRemoveSource_Lcom_mapbox_mapboxsdk_style_sources_Source_Handler")]
		public virtual unsafe bool RemoveSource (global::Com.Mapbox.Mapboxsdk.Style.Sources.Source source)
		{
			const string __id = "removeSource.(Lcom/mapbox/mapboxsdk/style/sources/Source;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveSource_Ljava_lang_String_Handler ()
		{
			if (cb_removeSource_Ljava_lang_String_ == null)
				cb_removeSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveSource_Ljava_lang_String_);
			return cb_removeSource_Ljava_lang_String_;
		}

		static bool n_RemoveSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceId)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Style __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceId = JNIEnv.GetString (native_sourceId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveSource (sourceId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='Style']/method[@name='removeSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeSource", "(Ljava/lang/String;)Z", "GetRemoveSource_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemoveSource (string sourceId)
		{
			const string __id = "removeSource.(Ljava/lang/String;)Z";
			IntPtr native_sourceId = JNIEnv.NewString (sourceId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourceId);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceId);
			}
		}

	}
}
