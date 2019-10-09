using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/LocationComponentOptions", DoNotGenerateAcw=true)]
	public partial class LocationComponentOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/LocationComponentOptions$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/location/LocationComponentOptions$Builder", typeof (Builder));
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

			static Delegate cb_accuracyAlpha_F;
#pragma warning disable 0169
			static Delegate GetAccuracyAlpha_FHandler ()
			{
				if (cb_accuracyAlpha_F == null)
					cb_accuracyAlpha_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_AccuracyAlpha_F);
				return cb_accuracyAlpha_F;
			}

			static IntPtr n_AccuracyAlpha_F (IntPtr jnienv, IntPtr native__this, float accuracyAlpha)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AccuracyAlpha (accuracyAlpha));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='accuracyAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("accuracyAlpha", "(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetAccuracyAlpha_FHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder AccuracyAlpha (float accuracyAlpha)
			{
				const string __id = "accuracyAlpha.(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (accuracyAlpha);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_accuracyAnimationEnabled_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetAccuracyAnimationEnabled_Ljava_lang_Boolean_Handler ()
			{
				if (cb_accuracyAnimationEnabled_Ljava_lang_Boolean_ == null)
					cb_accuracyAnimationEnabled_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AccuracyAnimationEnabled_Ljava_lang_Boolean_);
				return cb_accuracyAnimationEnabled_Ljava_lang_Boolean_;
			}

			static IntPtr n_AccuracyAnimationEnabled_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accuracyAnimationEnabled)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean accuracyAnimationEnabled = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_accuracyAnimationEnabled, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AccuracyAnimationEnabled (accuracyAnimationEnabled));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='accuracyAnimationEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("accuracyAnimationEnabled", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetAccuracyAnimationEnabled_Ljava_lang_Boolean_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder AccuracyAnimationEnabled (global::Java.Lang.Boolean accuracyAnimationEnabled)
			{
				const string __id = "accuracyAnimationEnabled.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((accuracyAnimationEnabled == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accuracyAnimationEnabled).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_accuracyColor_I;
#pragma warning disable 0169
			static Delegate GetAccuracyColor_IHandler ()
			{
				if (cb_accuracyColor_I == null)
					cb_accuracyColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AccuracyColor_I);
				return cb_accuracyColor_I;
			}

			static IntPtr n_AccuracyColor_I (IntPtr jnienv, IntPtr native__this, int accuracyColor)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AccuracyColor (accuracyColor));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='accuracyColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("accuracyColor", "(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetAccuracyColor_IHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder AccuracyColor (int accuracyColor)
			{
				const string __id = "accuracyColor.(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (accuracyColor);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_backgroundDrawable_I;
#pragma warning disable 0169
			static Delegate GetBackgroundDrawable_IHandler ()
			{
				if (cb_backgroundDrawable_I == null)
					cb_backgroundDrawable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_BackgroundDrawable_I);
				return cb_backgroundDrawable_I;
			}

			static IntPtr n_BackgroundDrawable_I (IntPtr jnienv, IntPtr native__this, int backgroundDrawable)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BackgroundDrawable (backgroundDrawable));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='backgroundDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("backgroundDrawable", "(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetBackgroundDrawable_IHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder BackgroundDrawable (int backgroundDrawable)
			{
				const string __id = "backgroundDrawable.(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (backgroundDrawable);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_backgroundDrawableStale_I;
#pragma warning disable 0169
			static Delegate GetBackgroundDrawableStale_IHandler ()
			{
				if (cb_backgroundDrawableStale_I == null)
					cb_backgroundDrawableStale_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_BackgroundDrawableStale_I);
				return cb_backgroundDrawableStale_I;
			}

			static IntPtr n_BackgroundDrawableStale_I (IntPtr jnienv, IntPtr native__this, int backgroundDrawableStale)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BackgroundDrawableStale (backgroundDrawableStale));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='backgroundDrawableStale' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("backgroundDrawableStale", "(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetBackgroundDrawableStale_IHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder BackgroundDrawableStale (int backgroundDrawableStale)
			{
				const string __id = "backgroundDrawableStale.(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (backgroundDrawableStale);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_backgroundName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetBackgroundName_Ljava_lang_String_Handler ()
			{
				if (cb_backgroundName_Ljava_lang_String_ == null)
					cb_backgroundName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BackgroundName_Ljava_lang_String_);
				return cb_backgroundName_Ljava_lang_String_;
			}

			static IntPtr n_BackgroundName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_backgroundName)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string backgroundName = JNIEnv.GetString (native_backgroundName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BackgroundName (backgroundName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='backgroundName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("backgroundName", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetBackgroundName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder BackgroundName (string backgroundName)
			{
				const string __id = "backgroundName.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				IntPtr native_backgroundName = JNIEnv.NewString (backgroundName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_backgroundName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_backgroundName);
				}
			}

			static Delegate cb_backgroundStaleName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetBackgroundStaleName_Ljava_lang_String_Handler ()
			{
				if (cb_backgroundStaleName_Ljava_lang_String_ == null)
					cb_backgroundStaleName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BackgroundStaleName_Ljava_lang_String_);
				return cb_backgroundStaleName_Ljava_lang_String_;
			}

			static IntPtr n_BackgroundStaleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_backgroundStaleName)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string backgroundStaleName = JNIEnv.GetString (native_backgroundStaleName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BackgroundStaleName (backgroundStaleName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='backgroundStaleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("backgroundStaleName", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetBackgroundStaleName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder BackgroundStaleName (string backgroundStaleName)
			{
				const string __id = "backgroundStaleName.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				IntPtr native_backgroundStaleName = JNIEnv.NewString (backgroundStaleName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_backgroundStaleName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_backgroundStaleName);
				}
			}

			static Delegate cb_backgroundStaleTintColor_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetBackgroundStaleTintColor_Ljava_lang_Integer_Handler ()
			{
				if (cb_backgroundStaleTintColor_Ljava_lang_Integer_ == null)
					cb_backgroundStaleTintColor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BackgroundStaleTintColor_Ljava_lang_Integer_);
				return cb_backgroundStaleTintColor_Ljava_lang_Integer_;
			}

			static IntPtr n_BackgroundStaleTintColor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_backgroundStaleTintColor)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer backgroundStaleTintColor = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_backgroundStaleTintColor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BackgroundStaleTintColor (backgroundStaleTintColor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='backgroundStaleTintColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("backgroundStaleTintColor", "(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetBackgroundStaleTintColor_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder BackgroundStaleTintColor (global::Java.Lang.Integer backgroundStaleTintColor)
			{
				const string __id = "backgroundStaleTintColor.(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((backgroundStaleTintColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) backgroundStaleTintColor).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_backgroundTintColor_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetBackgroundTintColor_Ljava_lang_Integer_Handler ()
			{
				if (cb_backgroundTintColor_Ljava_lang_Integer_ == null)
					cb_backgroundTintColor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BackgroundTintColor_Ljava_lang_Integer_);
				return cb_backgroundTintColor_Ljava_lang_Integer_;
			}

			static IntPtr n_BackgroundTintColor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_backgroundTintColor)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer backgroundTintColor = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_backgroundTintColor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BackgroundTintColor (backgroundTintColor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='backgroundTintColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("backgroundTintColor", "(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetBackgroundTintColor_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder BackgroundTintColor (global::Java.Lang.Integer backgroundTintColor)
			{
				const string __id = "backgroundTintColor.(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((backgroundTintColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) backgroundTintColor).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_bearingDrawable_I;
#pragma warning disable 0169
			static Delegate GetBearingDrawable_IHandler ()
			{
				if (cb_bearingDrawable_I == null)
					cb_bearingDrawable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_BearingDrawable_I);
				return cb_bearingDrawable_I;
			}

			static IntPtr n_BearingDrawable_I (IntPtr jnienv, IntPtr native__this, int bearingDrawable)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BearingDrawable (bearingDrawable));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='bearingDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("bearingDrawable", "(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetBearingDrawable_IHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder BearingDrawable (int bearingDrawable)
			{
				const string __id = "bearingDrawable.(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (bearingDrawable);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_bearingName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetBearingName_Ljava_lang_String_Handler ()
			{
				if (cb_bearingName_Ljava_lang_String_ == null)
					cb_bearingName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BearingName_Ljava_lang_String_);
				return cb_bearingName_Ljava_lang_String_;
			}

			static IntPtr n_BearingName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bearingName)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string bearingName = JNIEnv.GetString (native_bearingName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BearingName (bearingName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='bearingName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("bearingName", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetBearingName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder BearingName (string bearingName)
			{
				const string __id = "bearingName.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				IntPtr native_bearingName = JNIEnv.NewString (bearingName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_bearingName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_bearingName);
				}
			}

			static Delegate cb_bearingTintColor_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetBearingTintColor_Ljava_lang_Integer_Handler ()
			{
				if (cb_bearingTintColor_Ljava_lang_Integer_ == null)
					cb_bearingTintColor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BearingTintColor_Ljava_lang_Integer_);
				return cb_bearingTintColor_Ljava_lang_Integer_;
			}

			static IntPtr n_BearingTintColor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bearingTintColor)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer bearingTintColor = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_bearingTintColor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BearingTintColor (bearingTintColor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='bearingTintColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("bearingTintColor", "(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetBearingTintColor_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder BearingTintColor (global::Java.Lang.Integer bearingTintColor)
			{
				const string __id = "bearingTintColor.(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bearingTintColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bearingTintColor).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions Build ()
			{
				const string __id = "build.()Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_compassAnimationEnabled_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetCompassAnimationEnabled_Ljava_lang_Boolean_Handler ()
			{
				if (cb_compassAnimationEnabled_Ljava_lang_Boolean_ == null)
					cb_compassAnimationEnabled_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CompassAnimationEnabled_Ljava_lang_Boolean_);
				return cb_compassAnimationEnabled_Ljava_lang_Boolean_;
			}

			static IntPtr n_CompassAnimationEnabled_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_compassAnimationEnabled)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean compassAnimationEnabled = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_compassAnimationEnabled, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompassAnimationEnabled (compassAnimationEnabled));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='compassAnimationEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("compassAnimationEnabled", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetCompassAnimationEnabled_Ljava_lang_Boolean_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder CompassAnimationEnabled (global::Java.Lang.Boolean compassAnimationEnabled)
			{
				const string __id = "compassAnimationEnabled.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((compassAnimationEnabled == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compassAnimationEnabled).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_elevation_F;
#pragma warning disable 0169
			static Delegate GetElevation_FHandler ()
			{
				if (cb_elevation_F == null)
					cb_elevation_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Elevation_F);
				return cb_elevation_F;
			}

			static IntPtr n_Elevation_F (IntPtr jnienv, IntPtr native__this, float elevation)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Elevation (elevation));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='elevation' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("elevation", "(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetElevation_FHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder Elevation (float elevation)
			{
				const string __id = "elevation.(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (elevation);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_enableStaleState_Z;
#pragma warning disable 0169
			static Delegate GetEnableStaleState_ZHandler ()
			{
				if (cb_enableStaleState_Z == null)
					cb_enableStaleState_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_EnableStaleState_Z);
				return cb_enableStaleState_Z;
			}

			static IntPtr n_EnableStaleState_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.EnableStaleState (enabled));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='enableStaleState' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("enableStaleState", "(Z)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetEnableStaleState_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder EnableStaleState (bool enabled)
			{
				const string __id = "enableStaleState.(Z)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_foregroundDrawable_I;
#pragma warning disable 0169
			static Delegate GetForegroundDrawable_IHandler ()
			{
				if (cb_foregroundDrawable_I == null)
					cb_foregroundDrawable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ForegroundDrawable_I);
				return cb_foregroundDrawable_I;
			}

			static IntPtr n_ForegroundDrawable_I (IntPtr jnienv, IntPtr native__this, int foregroundDrawable)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ForegroundDrawable (foregroundDrawable));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='foregroundDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("foregroundDrawable", "(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetForegroundDrawable_IHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder ForegroundDrawable (int foregroundDrawable)
			{
				const string __id = "foregroundDrawable.(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (foregroundDrawable);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_foregroundDrawableStale_I;
#pragma warning disable 0169
			static Delegate GetForegroundDrawableStale_IHandler ()
			{
				if (cb_foregroundDrawableStale_I == null)
					cb_foregroundDrawableStale_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ForegroundDrawableStale_I);
				return cb_foregroundDrawableStale_I;
			}

			static IntPtr n_ForegroundDrawableStale_I (IntPtr jnienv, IntPtr native__this, int foregroundDrawableStale)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ForegroundDrawableStale (foregroundDrawableStale));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='foregroundDrawableStale' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("foregroundDrawableStale", "(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetForegroundDrawableStale_IHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder ForegroundDrawableStale (int foregroundDrawableStale)
			{
				const string __id = "foregroundDrawableStale.(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (foregroundDrawableStale);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_foregroundName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetForegroundName_Ljava_lang_String_Handler ()
			{
				if (cb_foregroundName_Ljava_lang_String_ == null)
					cb_foregroundName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ForegroundName_Ljava_lang_String_);
				return cb_foregroundName_Ljava_lang_String_;
			}

			static IntPtr n_ForegroundName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_foregroundName)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string foregroundName = JNIEnv.GetString (native_foregroundName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForegroundName (foregroundName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='foregroundName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("foregroundName", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetForegroundName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder ForegroundName (string foregroundName)
			{
				const string __id = "foregroundName.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				IntPtr native_foregroundName = JNIEnv.NewString (foregroundName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_foregroundName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_foregroundName);
				}
			}

			static Delegate cb_foregroundStaleName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetForegroundStaleName_Ljava_lang_String_Handler ()
			{
				if (cb_foregroundStaleName_Ljava_lang_String_ == null)
					cb_foregroundStaleName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ForegroundStaleName_Ljava_lang_String_);
				return cb_foregroundStaleName_Ljava_lang_String_;
			}

			static IntPtr n_ForegroundStaleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_foregroundStaleName)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string foregroundStaleName = JNIEnv.GetString (native_foregroundStaleName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForegroundStaleName (foregroundStaleName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='foregroundStaleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("foregroundStaleName", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetForegroundStaleName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder ForegroundStaleName (string foregroundStaleName)
			{
				const string __id = "foregroundStaleName.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				IntPtr native_foregroundStaleName = JNIEnv.NewString (foregroundStaleName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_foregroundStaleName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_foregroundStaleName);
				}
			}

			static Delegate cb_foregroundStaleTintColor_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetForegroundStaleTintColor_Ljava_lang_Integer_Handler ()
			{
				if (cb_foregroundStaleTintColor_Ljava_lang_Integer_ == null)
					cb_foregroundStaleTintColor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ForegroundStaleTintColor_Ljava_lang_Integer_);
				return cb_foregroundStaleTintColor_Ljava_lang_Integer_;
			}

			static IntPtr n_ForegroundStaleTintColor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_foregroundStaleTintColor)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer foregroundStaleTintColor = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_foregroundStaleTintColor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForegroundStaleTintColor (foregroundStaleTintColor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='foregroundStaleTintColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("foregroundStaleTintColor", "(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetForegroundStaleTintColor_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder ForegroundStaleTintColor (global::Java.Lang.Integer foregroundStaleTintColor)
			{
				const string __id = "foregroundStaleTintColor.(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((foregroundStaleTintColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) foregroundStaleTintColor).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_foregroundTintColor_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetForegroundTintColor_Ljava_lang_Integer_Handler ()
			{
				if (cb_foregroundTintColor_Ljava_lang_Integer_ == null)
					cb_foregroundTintColor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ForegroundTintColor_Ljava_lang_Integer_);
				return cb_foregroundTintColor_Ljava_lang_Integer_;
			}

			static IntPtr n_ForegroundTintColor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_foregroundTintColor)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer foregroundTintColor = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_foregroundTintColor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForegroundTintColor (foregroundTintColor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='foregroundTintColor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("foregroundTintColor", "(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetForegroundTintColor_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder ForegroundTintColor (global::Java.Lang.Integer foregroundTintColor)
			{
				const string __id = "foregroundTintColor.(Ljava/lang/Integer;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((foregroundTintColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) foregroundTintColor).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_gpsDrawable_I;
#pragma warning disable 0169
			static Delegate GetGpsDrawable_IHandler ()
			{
				if (cb_gpsDrawable_I == null)
					cb_gpsDrawable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GpsDrawable_I);
				return cb_gpsDrawable_I;
			}

			static IntPtr n_GpsDrawable_I (IntPtr jnienv, IntPtr native__this, int gpsDrawable)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GpsDrawable (gpsDrawable));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='gpsDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("gpsDrawable", "(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetGpsDrawable_IHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder GpsDrawable (int gpsDrawable)
			{
				const string __id = "gpsDrawable.(I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (gpsDrawable);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_gpsName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGpsName_Ljava_lang_String_Handler ()
			{
				if (cb_gpsName_Ljava_lang_String_ == null)
					cb_gpsName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GpsName_Ljava_lang_String_);
				return cb_gpsName_Ljava_lang_String_;
			}

			static IntPtr n_GpsName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gpsName)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string gpsName = JNIEnv.GetString (native_gpsName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GpsName (gpsName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='gpsName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("gpsName", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetGpsName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder GpsName (string gpsName)
			{
				const string __id = "gpsName.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				IntPtr native_gpsName = JNIEnv.NewString (gpsName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_gpsName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_gpsName);
				}
			}

			static Delegate cb_layerAbove_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLayerAbove_Ljava_lang_String_Handler ()
			{
				if (cb_layerAbove_Ljava_lang_String_ == null)
					cb_layerAbove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LayerAbove_Ljava_lang_String_);
				return cb_layerAbove_Ljava_lang_String_;
			}

			static IntPtr n_LayerAbove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layerAbove)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string layerAbove = JNIEnv.GetString (native_layerAbove, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LayerAbove (layerAbove));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='layerAbove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("layerAbove", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetLayerAbove_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder LayerAbove (string layerAbove)
			{
				const string __id = "layerAbove.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				IntPtr native_layerAbove = JNIEnv.NewString (layerAbove);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_layerAbove);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_layerAbove);
				}
			}

			static Delegate cb_layerBelow_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLayerBelow_Ljava_lang_String_Handler ()
			{
				if (cb_layerBelow_Ljava_lang_String_ == null)
					cb_layerBelow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LayerBelow_Ljava_lang_String_);
				return cb_layerBelow_Ljava_lang_String_;
			}

			static IntPtr n_LayerBelow_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layerBelow)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string layerBelow = JNIEnv.GetString (native_layerBelow, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LayerBelow (layerBelow));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='layerBelow' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("layerBelow", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetLayerBelow_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder LayerBelow (string layerBelow)
			{
				const string __id = "layerBelow.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				IntPtr native_layerBelow = JNIEnv.NewString (layerBelow);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_layerBelow);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_layerBelow);
				}
			}

			static Delegate cb_maxZoomIconScale_F;
#pragma warning disable 0169
			static Delegate GetMaxZoomIconScale_FHandler ()
			{
				if (cb_maxZoomIconScale_F == null)
					cb_maxZoomIconScale_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_MaxZoomIconScale_F);
				return cb_maxZoomIconScale_F;
			}

			static IntPtr n_MaxZoomIconScale_F (IntPtr jnienv, IntPtr native__this, float maxZoomIconScale)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MaxZoomIconScale (maxZoomIconScale));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='maxZoomIconScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("maxZoomIconScale", "(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetMaxZoomIconScale_FHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder MaxZoomIconScale (float maxZoomIconScale)
			{
				const string __id = "maxZoomIconScale.(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxZoomIconScale);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_minZoomIconScale_F;
#pragma warning disable 0169
			static Delegate GetMinZoomIconScale_FHandler ()
			{
				if (cb_minZoomIconScale_F == null)
					cb_minZoomIconScale_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_MinZoomIconScale_F);
				return cb_minZoomIconScale_F;
			}

			static IntPtr n_MinZoomIconScale_F (IntPtr jnienv, IntPtr native__this, float minZoomIconScale)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MinZoomIconScale (minZoomIconScale));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='minZoomIconScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("minZoomIconScale", "(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetMinZoomIconScale_FHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder MinZoomIconScale (float minZoomIconScale)
			{
				const string __id = "minZoomIconScale.(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (minZoomIconScale);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_padding_arrayI;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetPadding_arrayIHandler ()
			{
				if (cb_padding_arrayI == null)
					cb_padding_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Padding_arrayI);
				return cb_padding_arrayI;
			}

			[Obsolete]
			static IntPtr n_Padding_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_padding)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] padding = (int[]) JNIEnv.GetArray (native_padding, JniHandleOwnership.DoNotTransfer, typeof (int));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Padding (padding));
				if (padding != null)
					JNIEnv.CopyArray (padding, native_padding);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='padding' and count(parameter)=1 and parameter[1][@type='int[]']]"
			[Obsolete (@"deprecated")]
			[Register ("padding", "([I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetPadding_arrayIHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder Padding (int[] padding)
			{
				const string __id = "padding.([I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				IntPtr native_padding = JNIEnv.NewArray (padding);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_padding);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (padding != null) {
						JNIEnv.CopyArray (native_padding, padding);
						JNIEnv.DeleteLocalRef (native_padding);
					}
				}
			}

			static Delegate cb_staleStateTimeout_J;
#pragma warning disable 0169
			static Delegate GetStaleStateTimeout_JHandler ()
			{
				if (cb_staleStateTimeout_J == null)
					cb_staleStateTimeout_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_StaleStateTimeout_J);
				return cb_staleStateTimeout_J;
			}

			static IntPtr n_StaleStateTimeout_J (IntPtr jnienv, IntPtr native__this, long timeout)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.StaleStateTimeout (timeout));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='staleStateTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("staleStateTimeout", "(J)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetStaleStateTimeout_JHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder StaleStateTimeout (long timeout)
			{
				const string __id = "staleStateTimeout.(J)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (timeout);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_trackingAnimationDurationMultiplier_F;
#pragma warning disable 0169
			static Delegate GetTrackingAnimationDurationMultiplier_FHandler ()
			{
				if (cb_trackingAnimationDurationMultiplier_F == null)
					cb_trackingAnimationDurationMultiplier_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TrackingAnimationDurationMultiplier_F);
				return cb_trackingAnimationDurationMultiplier_F;
			}

			static IntPtr n_TrackingAnimationDurationMultiplier_F (IntPtr jnienv, IntPtr native__this, float trackingAnimationDurationMultiplier)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TrackingAnimationDurationMultiplier (trackingAnimationDurationMultiplier));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='trackingAnimationDurationMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("trackingAnimationDurationMultiplier", "(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetTrackingAnimationDurationMultiplier_FHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder TrackingAnimationDurationMultiplier (float trackingAnimationDurationMultiplier)
			{
				const string __id = "trackingAnimationDurationMultiplier.(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (trackingAnimationDurationMultiplier);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_trackingGesturesManagement_Z;
#pragma warning disable 0169
			static Delegate GetTrackingGesturesManagement_ZHandler ()
			{
				if (cb_trackingGesturesManagement_Z == null)
					cb_trackingGesturesManagement_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_TrackingGesturesManagement_Z);
				return cb_trackingGesturesManagement_Z;
			}

			static IntPtr n_TrackingGesturesManagement_Z (IntPtr jnienv, IntPtr native__this, bool trackingGesturesManagement)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TrackingGesturesManagement (trackingGesturesManagement));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='trackingGesturesManagement' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("trackingGesturesManagement", "(Z)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetTrackingGesturesManagement_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder TrackingGesturesManagement (bool trackingGesturesManagement)
			{
				const string __id = "trackingGesturesManagement.(Z)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (trackingGesturesManagement);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_trackingInitialMoveThreshold_F;
#pragma warning disable 0169
			static Delegate GetTrackingInitialMoveThreshold_FHandler ()
			{
				if (cb_trackingInitialMoveThreshold_F == null)
					cb_trackingInitialMoveThreshold_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TrackingInitialMoveThreshold_F);
				return cb_trackingInitialMoveThreshold_F;
			}

			static IntPtr n_TrackingInitialMoveThreshold_F (IntPtr jnienv, IntPtr native__this, float moveThreshold)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TrackingInitialMoveThreshold (moveThreshold));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='trackingInitialMoveThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("trackingInitialMoveThreshold", "(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetTrackingInitialMoveThreshold_FHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder TrackingInitialMoveThreshold (float moveThreshold)
			{
				const string __id = "trackingInitialMoveThreshold.(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (moveThreshold);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_trackingMultiFingerMoveThreshold_F;
#pragma warning disable 0169
			static Delegate GetTrackingMultiFingerMoveThreshold_FHandler ()
			{
				if (cb_trackingMultiFingerMoveThreshold_F == null)
					cb_trackingMultiFingerMoveThreshold_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TrackingMultiFingerMoveThreshold_F);
				return cb_trackingMultiFingerMoveThreshold_F;
			}

			static IntPtr n_TrackingMultiFingerMoveThreshold_F (IntPtr jnienv, IntPtr native__this, float moveThreshold)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TrackingMultiFingerMoveThreshold (moveThreshold));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions.Builder']/method[@name='trackingMultiFingerMoveThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("trackingMultiFingerMoveThreshold", "(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetTrackingMultiFingerMoveThreshold_FHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder TrackingMultiFingerMoveThreshold (float moveThreshold)
			{
				const string __id = "trackingMultiFingerMoveThreshold.(F)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (moveThreshold);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/location/LocationComponentOptions", typeof (LocationComponentOptions));
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

		protected LocationComponentOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_accuracyAlpha;
#pragma warning disable 0169
		static Delegate GetAccuracyAlphaHandler ()
		{
			if (cb_accuracyAlpha == null)
				cb_accuracyAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_AccuracyAlpha);
			return cb_accuracyAlpha;
		}

		static float n_AccuracyAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccuracyAlpha ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='accuracyAlpha' and count(parameter)=0]"
		[Register ("accuracyAlpha", "()F", "GetAccuracyAlphaHandler")]
		public virtual unsafe float AccuracyAlpha ()
		{
			const string __id = "accuracyAlpha.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_accuracyAnimationEnabled;
#pragma warning disable 0169
		static Delegate GetAccuracyAnimationEnabledHandler ()
		{
			if (cb_accuracyAnimationEnabled == null)
				cb_accuracyAnimationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AccuracyAnimationEnabled);
			return cb_accuracyAnimationEnabled;
		}

		static bool n_AccuracyAnimationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccuracyAnimationEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='accuracyAnimationEnabled' and count(parameter)=0]"
		[Register ("accuracyAnimationEnabled", "()Z", "GetAccuracyAnimationEnabledHandler")]
		public virtual unsafe bool AccuracyAnimationEnabled ()
		{
			const string __id = "accuracyAnimationEnabled.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_accuracyColor;
#pragma warning disable 0169
		static Delegate GetAccuracyColorHandler ()
		{
			if (cb_accuracyColor == null)
				cb_accuracyColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_AccuracyColor);
			return cb_accuracyColor;
		}

		static int n_AccuracyColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccuracyColor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='accuracyColor' and count(parameter)=0]"
		[Register ("accuracyColor", "()I", "GetAccuracyColorHandler")]
		public virtual unsafe int AccuracyColor ()
		{
			const string __id = "accuracyColor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_backgroundDrawable;
#pragma warning disable 0169
		static Delegate GetBackgroundDrawableHandler ()
		{
			if (cb_backgroundDrawable == null)
				cb_backgroundDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BackgroundDrawable);
			return cb_backgroundDrawable;
		}

		static int n_BackgroundDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundDrawable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='backgroundDrawable' and count(parameter)=0]"
		[Register ("backgroundDrawable", "()I", "GetBackgroundDrawableHandler")]
		public virtual unsafe int BackgroundDrawable ()
		{
			const string __id = "backgroundDrawable.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_backgroundDrawableStale;
#pragma warning disable 0169
		static Delegate GetBackgroundDrawableStaleHandler ()
		{
			if (cb_backgroundDrawableStale == null)
				cb_backgroundDrawableStale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BackgroundDrawableStale);
			return cb_backgroundDrawableStale;
		}

		static int n_BackgroundDrawableStale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundDrawableStale ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='backgroundDrawableStale' and count(parameter)=0]"
		[Register ("backgroundDrawableStale", "()I", "GetBackgroundDrawableStaleHandler")]
		public virtual unsafe int BackgroundDrawableStale ()
		{
			const string __id = "backgroundDrawableStale.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_backgroundName;
#pragma warning disable 0169
		static Delegate GetBackgroundNameHandler ()
		{
			if (cb_backgroundName == null)
				cb_backgroundName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BackgroundName);
			return cb_backgroundName;
		}

		static IntPtr n_BackgroundName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BackgroundName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='backgroundName' and count(parameter)=0]"
		[Register ("backgroundName", "()Ljava/lang/String;", "GetBackgroundNameHandler")]
		public virtual unsafe string BackgroundName ()
		{
			const string __id = "backgroundName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_backgroundStaleName;
#pragma warning disable 0169
		static Delegate GetBackgroundStaleNameHandler ()
		{
			if (cb_backgroundStaleName == null)
				cb_backgroundStaleName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BackgroundStaleName);
			return cb_backgroundStaleName;
		}

		static IntPtr n_BackgroundStaleName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BackgroundStaleName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='backgroundStaleName' and count(parameter)=0]"
		[Register ("backgroundStaleName", "()Ljava/lang/String;", "GetBackgroundStaleNameHandler")]
		public virtual unsafe string BackgroundStaleName ()
		{
			const string __id = "backgroundStaleName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_backgroundStaleTintColor;
#pragma warning disable 0169
		static Delegate GetBackgroundStaleTintColorHandler ()
		{
			if (cb_backgroundStaleTintColor == null)
				cb_backgroundStaleTintColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BackgroundStaleTintColor);
			return cb_backgroundStaleTintColor;
		}

		static IntPtr n_BackgroundStaleTintColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BackgroundStaleTintColor ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='backgroundStaleTintColor' and count(parameter)=0]"
		[Register ("backgroundStaleTintColor", "()Ljava/lang/Integer;", "GetBackgroundStaleTintColorHandler")]
		public virtual unsafe global::Java.Lang.Integer BackgroundStaleTintColor ()
		{
			const string __id = "backgroundStaleTintColor.()Ljava/lang/Integer;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_backgroundTintColor;
#pragma warning disable 0169
		static Delegate GetBackgroundTintColorHandler ()
		{
			if (cb_backgroundTintColor == null)
				cb_backgroundTintColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BackgroundTintColor);
			return cb_backgroundTintColor;
		}

		static IntPtr n_BackgroundTintColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BackgroundTintColor ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='backgroundTintColor' and count(parameter)=0]"
		[Register ("backgroundTintColor", "()Ljava/lang/Integer;", "GetBackgroundTintColorHandler")]
		public virtual unsafe global::Java.Lang.Integer BackgroundTintColor ()
		{
			const string __id = "backgroundTintColor.()Ljava/lang/Integer;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_bearingDrawable;
#pragma warning disable 0169
		static Delegate GetBearingDrawableHandler ()
		{
			if (cb_bearingDrawable == null)
				cb_bearingDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BearingDrawable);
			return cb_bearingDrawable;
		}

		static int n_BearingDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BearingDrawable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='bearingDrawable' and count(parameter)=0]"
		[Register ("bearingDrawable", "()I", "GetBearingDrawableHandler")]
		public virtual unsafe int BearingDrawable ()
		{
			const string __id = "bearingDrawable.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_bearingName;
#pragma warning disable 0169
		static Delegate GetBearingNameHandler ()
		{
			if (cb_bearingName == null)
				cb_bearingName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BearingName);
			return cb_bearingName;
		}

		static IntPtr n_BearingName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BearingName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='bearingName' and count(parameter)=0]"
		[Register ("bearingName", "()Ljava/lang/String;", "GetBearingNameHandler")]
		public virtual unsafe string BearingName ()
		{
			const string __id = "bearingName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_bearingTintColor;
#pragma warning disable 0169
		static Delegate GetBearingTintColorHandler ()
		{
			if (cb_bearingTintColor == null)
				cb_bearingTintColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BearingTintColor);
			return cb_bearingTintColor;
		}

		static IntPtr n_BearingTintColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BearingTintColor ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='bearingTintColor' and count(parameter)=0]"
		[Register ("bearingTintColor", "()Ljava/lang/Integer;", "GetBearingTintColorHandler")]
		public virtual unsafe global::Java.Lang.Integer BearingTintColor ()
		{
			const string __id = "bearingTintColor.()Ljava/lang/Integer;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("builder", "(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder InvokeBuilder (global::Android.Content.Context context)
		{
			const string __id = "builder.(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compassAnimationEnabled;
#pragma warning disable 0169
		static Delegate GetCompassAnimationEnabledHandler ()
		{
			if (cb_compassAnimationEnabled == null)
				cb_compassAnimationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CompassAnimationEnabled);
			return cb_compassAnimationEnabled;
		}

		static bool n_CompassAnimationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompassAnimationEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='compassAnimationEnabled' and count(parameter)=0]"
		[Register ("compassAnimationEnabled", "()Z", "GetCompassAnimationEnabledHandler")]
		public virtual unsafe bool CompassAnimationEnabled ()
		{
			const string __id = "compassAnimationEnabled.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='createFromAttributes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("createFromAttributes", "(Landroid/content/Context;I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions CreateFromAttributes (global::Android.Content.Context context, int styleRes)
		{
			const string __id = "createFromAttributes.(Landroid/content/Context;I)Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (styleRes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_elevation;
#pragma warning disable 0169
		static Delegate GetElevationHandler ()
		{
			if (cb_elevation == null)
				cb_elevation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Elevation);
			return cb_elevation;
		}

		static float n_Elevation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Elevation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='elevation' and count(parameter)=0]"
		[Register ("elevation", "()F", "GetElevationHandler")]
		public virtual unsafe float Elevation ()
		{
			const string __id = "elevation.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_enableStaleState;
#pragma warning disable 0169
		static Delegate GetEnableStaleStateHandler ()
		{
			if (cb_enableStaleState == null)
				cb_enableStaleState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EnableStaleState);
			return cb_enableStaleState;
		}

		static bool n_EnableStaleState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableStaleState ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='enableStaleState' and count(parameter)=0]"
		[Register ("enableStaleState", "()Z", "GetEnableStaleStateHandler")]
		public virtual unsafe bool EnableStaleState ()
		{
			const string __id = "enableStaleState.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_foregroundDrawable;
#pragma warning disable 0169
		static Delegate GetForegroundDrawableHandler ()
		{
			if (cb_foregroundDrawable == null)
				cb_foregroundDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ForegroundDrawable);
			return cb_foregroundDrawable;
		}

		static int n_ForegroundDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForegroundDrawable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='foregroundDrawable' and count(parameter)=0]"
		[Register ("foregroundDrawable", "()I", "GetForegroundDrawableHandler")]
		public virtual unsafe int ForegroundDrawable ()
		{
			const string __id = "foregroundDrawable.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_foregroundDrawableStale;
#pragma warning disable 0169
		static Delegate GetForegroundDrawableStaleHandler ()
		{
			if (cb_foregroundDrawableStale == null)
				cb_foregroundDrawableStale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ForegroundDrawableStale);
			return cb_foregroundDrawableStale;
		}

		static int n_ForegroundDrawableStale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForegroundDrawableStale ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='foregroundDrawableStale' and count(parameter)=0]"
		[Register ("foregroundDrawableStale", "()I", "GetForegroundDrawableStaleHandler")]
		public virtual unsafe int ForegroundDrawableStale ()
		{
			const string __id = "foregroundDrawableStale.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_foregroundName;
#pragma warning disable 0169
		static Delegate GetForegroundNameHandler ()
		{
			if (cb_foregroundName == null)
				cb_foregroundName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForegroundName);
			return cb_foregroundName;
		}

		static IntPtr n_ForegroundName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ForegroundName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='foregroundName' and count(parameter)=0]"
		[Register ("foregroundName", "()Ljava/lang/String;", "GetForegroundNameHandler")]
		public virtual unsafe string ForegroundName ()
		{
			const string __id = "foregroundName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_foregroundStaleName;
#pragma warning disable 0169
		static Delegate GetForegroundStaleNameHandler ()
		{
			if (cb_foregroundStaleName == null)
				cb_foregroundStaleName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForegroundStaleName);
			return cb_foregroundStaleName;
		}

		static IntPtr n_ForegroundStaleName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ForegroundStaleName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='foregroundStaleName' and count(parameter)=0]"
		[Register ("foregroundStaleName", "()Ljava/lang/String;", "GetForegroundStaleNameHandler")]
		public virtual unsafe string ForegroundStaleName ()
		{
			const string __id = "foregroundStaleName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_foregroundStaleTintColor;
#pragma warning disable 0169
		static Delegate GetForegroundStaleTintColorHandler ()
		{
			if (cb_foregroundStaleTintColor == null)
				cb_foregroundStaleTintColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForegroundStaleTintColor);
			return cb_foregroundStaleTintColor;
		}

		static IntPtr n_ForegroundStaleTintColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForegroundStaleTintColor ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='foregroundStaleTintColor' and count(parameter)=0]"
		[Register ("foregroundStaleTintColor", "()Ljava/lang/Integer;", "GetForegroundStaleTintColorHandler")]
		public virtual unsafe global::Java.Lang.Integer ForegroundStaleTintColor ()
		{
			const string __id = "foregroundStaleTintColor.()Ljava/lang/Integer;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_foregroundTintColor;
#pragma warning disable 0169
		static Delegate GetForegroundTintColorHandler ()
		{
			if (cb_foregroundTintColor == null)
				cb_foregroundTintColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForegroundTintColor);
			return cb_foregroundTintColor;
		}

		static IntPtr n_ForegroundTintColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForegroundTintColor ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='foregroundTintColor' and count(parameter)=0]"
		[Register ("foregroundTintColor", "()Ljava/lang/Integer;", "GetForegroundTintColorHandler")]
		public virtual unsafe global::Java.Lang.Integer ForegroundTintColor ()
		{
			const string __id = "foregroundTintColor.()Ljava/lang/Integer;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_gpsDrawable;
#pragma warning disable 0169
		static Delegate GetGpsDrawableHandler ()
		{
			if (cb_gpsDrawable == null)
				cb_gpsDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GpsDrawable);
			return cb_gpsDrawable;
		}

		static int n_GpsDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GpsDrawable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='gpsDrawable' and count(parameter)=0]"
		[Register ("gpsDrawable", "()I", "GetGpsDrawableHandler")]
		public virtual unsafe int GpsDrawable ()
		{
			const string __id = "gpsDrawable.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_gpsName;
#pragma warning disable 0169
		static Delegate GetGpsNameHandler ()
		{
			if (cb_gpsName == null)
				cb_gpsName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GpsName);
			return cb_gpsName;
		}

		static IntPtr n_GpsName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GpsName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='gpsName' and count(parameter)=0]"
		[Register ("gpsName", "()Ljava/lang/String;", "GetGpsNameHandler")]
		public virtual unsafe string GpsName ()
		{
			const string __id = "gpsName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_layerAbove;
#pragma warning disable 0169
		static Delegate GetLayerAboveHandler ()
		{
			if (cb_layerAbove == null)
				cb_layerAbove = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LayerAbove);
			return cb_layerAbove;
		}

		static IntPtr n_LayerAbove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LayerAbove ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='layerAbove' and count(parameter)=0]"
		[Register ("layerAbove", "()Ljava/lang/String;", "GetLayerAboveHandler")]
		public virtual unsafe string LayerAbove ()
		{
			const string __id = "layerAbove.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_layerBelow;
#pragma warning disable 0169
		static Delegate GetLayerBelowHandler ()
		{
			if (cb_layerBelow == null)
				cb_layerBelow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LayerBelow);
			return cb_layerBelow;
		}

		static IntPtr n_LayerBelow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LayerBelow ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='layerBelow' and count(parameter)=0]"
		[Register ("layerBelow", "()Ljava/lang/String;", "GetLayerBelowHandler")]
		public virtual unsafe string LayerBelow ()
		{
			const string __id = "layerBelow.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_maxZoomIconScale;
#pragma warning disable 0169
		static Delegate GetMaxZoomIconScaleHandler ()
		{
			if (cb_maxZoomIconScale == null)
				cb_maxZoomIconScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_MaxZoomIconScale);
			return cb_maxZoomIconScale;
		}

		static float n_MaxZoomIconScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoomIconScale ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='maxZoomIconScale' and count(parameter)=0]"
		[Register ("maxZoomIconScale", "()F", "GetMaxZoomIconScaleHandler")]
		public virtual unsafe float MaxZoomIconScale ()
		{
			const string __id = "maxZoomIconScale.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_minZoomIconScale;
#pragma warning disable 0169
		static Delegate GetMinZoomIconScaleHandler ()
		{
			if (cb_minZoomIconScale == null)
				cb_minZoomIconScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_MinZoomIconScale);
			return cb_minZoomIconScale;
		}

		static float n_MinZoomIconScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoomIconScale ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='minZoomIconScale' and count(parameter)=0]"
		[Register ("minZoomIconScale", "()F", "GetMinZoomIconScaleHandler")]
		public virtual unsafe float MinZoomIconScale ()
		{
			const string __id = "minZoomIconScale.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_padding;
#pragma warning disable 0169
		static Delegate GetPaddingHandler ()
		{
			if (cb_padding == null)
				cb_padding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Padding);
			return cb_padding;
		}

		static IntPtr n_Padding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Padding ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='padding' and count(parameter)=0]"
		[Register ("padding", "()[I", "GetPaddingHandler")]
		public virtual unsafe int[] Padding ()
		{
			const string __id = "padding.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_staleStateTimeout;
#pragma warning disable 0169
		static Delegate GetStaleStateTimeoutHandler ()
		{
			if (cb_staleStateTimeout == null)
				cb_staleStateTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_StaleStateTimeout);
			return cb_staleStateTimeout;
		}

		static long n_StaleStateTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StaleStateTimeout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='staleStateTimeout' and count(parameter)=0]"
		[Register ("staleStateTimeout", "()J", "GetStaleStateTimeoutHandler")]
		public virtual unsafe long StaleStateTimeout ()
		{
			const string __id = "staleStateTimeout.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_toBuilder;
#pragma warning disable 0169
		static Delegate GetToBuilderHandler ()
		{
			if (cb_toBuilder == null)
				cb_toBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBuilder);
			return cb_toBuilder;
		}

		static IntPtr n_ToBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBuilder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='toBuilder' and count(parameter)=0]"
		[Register ("toBuilder", "()Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;", "GetToBuilderHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder ToBuilder ()
		{
			const string __id = "toBuilder.()Lcom/mapbox/mapboxsdk/location/LocationComponentOptions$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_trackingAnimationDurationMultiplier;
#pragma warning disable 0169
		static Delegate GetTrackingAnimationDurationMultiplierHandler ()
		{
			if (cb_trackingAnimationDurationMultiplier == null)
				cb_trackingAnimationDurationMultiplier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_TrackingAnimationDurationMultiplier);
			return cb_trackingAnimationDurationMultiplier;
		}

		static float n_TrackingAnimationDurationMultiplier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackingAnimationDurationMultiplier ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='trackingAnimationDurationMultiplier' and count(parameter)=0]"
		[Register ("trackingAnimationDurationMultiplier", "()F", "GetTrackingAnimationDurationMultiplierHandler")]
		public virtual unsafe float TrackingAnimationDurationMultiplier ()
		{
			const string __id = "trackingAnimationDurationMultiplier.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_trackingGesturesManagement;
#pragma warning disable 0169
		static Delegate GetTrackingGesturesManagementHandler ()
		{
			if (cb_trackingGesturesManagement == null)
				cb_trackingGesturesManagement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_TrackingGesturesManagement);
			return cb_trackingGesturesManagement;
		}

		static bool n_TrackingGesturesManagement (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackingGesturesManagement ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='trackingGesturesManagement' and count(parameter)=0]"
		[Register ("trackingGesturesManagement", "()Z", "GetTrackingGesturesManagementHandler")]
		public virtual unsafe bool TrackingGesturesManagement ()
		{
			const string __id = "trackingGesturesManagement.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_trackingInitialMoveThreshold;
#pragma warning disable 0169
		static Delegate GetTrackingInitialMoveThresholdHandler ()
		{
			if (cb_trackingInitialMoveThreshold == null)
				cb_trackingInitialMoveThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_TrackingInitialMoveThreshold);
			return cb_trackingInitialMoveThreshold;
		}

		static float n_TrackingInitialMoveThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackingInitialMoveThreshold ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='trackingInitialMoveThreshold' and count(parameter)=0]"
		[Register ("trackingInitialMoveThreshold", "()F", "GetTrackingInitialMoveThresholdHandler")]
		public virtual unsafe float TrackingInitialMoveThreshold ()
		{
			const string __id = "trackingInitialMoveThreshold.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_trackingMultiFingerMoveThreshold;
#pragma warning disable 0169
		static Delegate GetTrackingMultiFingerMoveThresholdHandler ()
		{
			if (cb_trackingMultiFingerMoveThreshold == null)
				cb_trackingMultiFingerMoveThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_TrackingMultiFingerMoveThreshold);
			return cb_trackingMultiFingerMoveThreshold;
		}

		static float n_TrackingMultiFingerMoveThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackingMultiFingerMoveThreshold ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='trackingMultiFingerMoveThreshold' and count(parameter)=0]"
		[Register ("trackingMultiFingerMoveThreshold", "()F", "GetTrackingMultiFingerMoveThresholdHandler")]
		public virtual unsafe float TrackingMultiFingerMoveThreshold ()
		{
			const string __id = "trackingMultiFingerMoveThreshold.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
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
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

	}
}
