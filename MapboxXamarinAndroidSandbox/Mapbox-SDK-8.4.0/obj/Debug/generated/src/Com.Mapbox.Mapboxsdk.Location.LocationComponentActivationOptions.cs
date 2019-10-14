using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/LocationComponentActivationOptions", DoNotGenerateAcw=true)]
	public partial class LocationComponentActivationOptions : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions.Builder']/constructor[@name='LocationComponentActivationOptions.Builder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Style']]"
			[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;)V", "")]
			public unsafe Builder (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.Style style)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue ((style == null) ? IntPtr.Zero : ((global::Java.Lang.Object) style).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions Build ()
			{
				const string __id = "build.()Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_locationComponentOptions_Lcom_mapbox_mapboxsdk_location_LocationComponentOptions_;
#pragma warning disable 0169
			static Delegate GetLocationComponentOptions_Lcom_mapbox_mapboxsdk_location_LocationComponentOptions_Handler ()
			{
				if (cb_locationComponentOptions_Lcom_mapbox_mapboxsdk_location_LocationComponentOptions_ == null)
					cb_locationComponentOptions_Lcom_mapbox_mapboxsdk_location_LocationComponentOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LocationComponentOptions_Lcom_mapbox_mapboxsdk_location_LocationComponentOptions_);
				return cb_locationComponentOptions_Lcom_mapbox_mapboxsdk_location_LocationComponentOptions_;
			}

			static IntPtr n_LocationComponentOptions_Lcom_mapbox_mapboxsdk_location_LocationComponentOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_locationComponentOptions)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions locationComponentOptions = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (native_locationComponentOptions, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LocationComponentOptions (locationComponentOptions));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions.Builder']/method[@name='locationComponentOptions' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.LocationComponentOptions']]"
			[Register ("locationComponentOptions", "(Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;", "GetLocationComponentOptions_Lcom_mapbox_mapboxsdk_location_LocationComponentOptions_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder LocationComponentOptions (global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions locationComponentOptions)
			{
				const string __id = "locationComponentOptions.(Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((locationComponentOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locationComponentOptions).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_locationEngine_Lcom_mapbox_android_core_location_LocationEngine_;
#pragma warning disable 0169
			static Delegate GetLocationEngine_Lcom_mapbox_android_core_location_LocationEngine_Handler ()
			{
				if (cb_locationEngine_Lcom_mapbox_android_core_location_LocationEngine_ == null)
					cb_locationEngine_Lcom_mapbox_android_core_location_LocationEngine_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LocationEngine_Lcom_mapbox_android_core_location_LocationEngine_);
				return cb_locationEngine_Lcom_mapbox_android_core_location_LocationEngine_;
			}

			static IntPtr n_LocationEngine_Lcom_mapbox_android_core_location_LocationEngine_ (IntPtr jnienv, IntPtr native__this, IntPtr native_locationEngine)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Core.Location.ILocationEngine locationEngine = (global::Com.Mapbox.Android.Core.Location.ILocationEngine)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngine> (native_locationEngine, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LocationEngine (locationEngine));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions.Builder']/method[@name='locationEngine' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.core.location.LocationEngine']]"
			[Register ("locationEngine", "(Lcom/mapbox/android/core/location/LocationEngine;)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;", "GetLocationEngine_Lcom_mapbox_android_core_location_LocationEngine_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder LocationEngine (global::Com.Mapbox.Android.Core.Location.ILocationEngine locationEngine)
			{
				const string __id = "locationEngine.(Lcom/mapbox/android/core/location/LocationEngine;)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((locationEngine == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locationEngine).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_locationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineRequest_;
#pragma warning disable 0169
			static Delegate GetLocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineRequest_Handler ()
			{
				if (cb_locationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineRequest_ == null)
					cb_locationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineRequest_);
				return cb_locationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineRequest_;
			}

			static IntPtr n_LocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_locationEngineRequest)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Core.Location.LocationEngineRequest locationEngineRequest = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (native_locationEngineRequest, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LocationEngineRequest (locationEngineRequest));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions.Builder']/method[@name='locationEngineRequest' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.core.location.LocationEngineRequest']]"
			[Register ("locationEngineRequest", "(Lcom/mapbox/android/core/location/LocationEngineRequest;)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;", "GetLocationEngineRequest_Lcom_mapbox_android_core_location_LocationEngineRequest_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder LocationEngineRequest (global::Com.Mapbox.Android.Core.Location.LocationEngineRequest locationEngineRequest)
			{
				const string __id = "locationEngineRequest.(Lcom/mapbox/android/core/location/LocationEngineRequest;)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((locationEngineRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locationEngineRequest).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_styleRes_I;
#pragma warning disable 0169
			static Delegate GetStyleRes_IHandler ()
			{
				if (cb_styleRes_I == null)
					cb_styleRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_StyleRes_I);
				return cb_styleRes_I;
			}

			static IntPtr n_StyleRes_I (IntPtr jnienv, IntPtr native__this, int styleRes)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.StyleRes (styleRes));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions.Builder']/method[@name='styleRes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("styleRes", "(I)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;", "GetStyleRes_IHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder StyleRes (int styleRes)
			{
				const string __id = "styleRes.(I)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (styleRes);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_useDefaultLocationEngine_Z;
#pragma warning disable 0169
			static Delegate GetUseDefaultLocationEngine_ZHandler ()
			{
				if (cb_useDefaultLocationEngine_Z == null)
					cb_useDefaultLocationEngine_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_UseDefaultLocationEngine_Z);
				return cb_useDefaultLocationEngine_Z;
			}

			static IntPtr n_UseDefaultLocationEngine_Z (IntPtr jnienv, IntPtr native__this, bool useDefaultLocationEngine)
			{
				global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.UseDefaultLocationEngine (useDefaultLocationEngine));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions.Builder']/method[@name='useDefaultLocationEngine' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("useDefaultLocationEngine", "(Z)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;", "GetUseDefaultLocationEngine_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder UseDefaultLocationEngine (bool useDefaultLocationEngine)
			{
				const string __id = "useDefaultLocationEngine.(Z)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (useDefaultLocationEngine);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/location/LocationComponentActivationOptions", typeof (LocationComponentActivationOptions));
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

		protected LocationComponentActivationOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions']/method[@name='builder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Style']]"
		[Register ("builder", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder InvokeBuilder (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.Style fullyLoadedMapStyle)
		{
			const string __id = "builder.(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;)Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((fullyLoadedMapStyle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fullyLoadedMapStyle).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_context;
#pragma warning disable 0169
		static Delegate GetContextHandler ()
		{
			if (cb_context == null)
				cb_context = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Context);
			return cb_context;
		}

		static IntPtr n_Context (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions']/method[@name='context' and count(parameter)=0]"
		[Register ("context", "()Landroid/content/Context;", "GetContextHandler")]
		public virtual unsafe global::Android.Content.Context Context ()
		{
			const string __id = "context.()Landroid/content/Context;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_locationComponentOptions;
#pragma warning disable 0169
		static Delegate GetLocationComponentOptionsHandler ()
		{
			if (cb_locationComponentOptions == null)
				cb_locationComponentOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LocationComponentOptions);
			return cb_locationComponentOptions;
		}

		static IntPtr n_LocationComponentOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocationComponentOptions ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions']/method[@name='locationComponentOptions' and count(parameter)=0]"
		[Register ("locationComponentOptions", "()Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;", "GetLocationComponentOptionsHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions LocationComponentOptions ()
		{
			const string __id = "locationComponentOptions.()Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_locationEngine;
#pragma warning disable 0169
		static Delegate GetLocationEngineHandler ()
		{
			if (cb_locationEngine == null)
				cb_locationEngine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LocationEngine);
			return cb_locationEngine;
		}

		static IntPtr n_LocationEngine (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocationEngine ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions']/method[@name='locationEngine' and count(parameter)=0]"
		[Register ("locationEngine", "()Lcom/mapbox/android/core/location/LocationEngine;", "GetLocationEngineHandler")]
		public virtual unsafe global::Com.Mapbox.Android.Core.Location.ILocationEngine LocationEngine ()
		{
			const string __id = "locationEngine.()Lcom/mapbox/android/core/location/LocationEngine;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_locationEngineRequest;
#pragma warning disable 0169
		static Delegate GetLocationEngineRequestHandler ()
		{
			if (cb_locationEngineRequest == null)
				cb_locationEngineRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LocationEngineRequest);
			return cb_locationEngineRequest;
		}

		static IntPtr n_LocationEngineRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocationEngineRequest ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions']/method[@name='locationEngineRequest' and count(parameter)=0]"
		[Register ("locationEngineRequest", "()Lcom/mapbox/android/core/location/LocationEngineRequest;", "GetLocationEngineRequestHandler")]
		public virtual unsafe global::Com.Mapbox.Android.Core.Location.LocationEngineRequest LocationEngineRequest ()
		{
			const string __id = "locationEngineRequest.()Lcom/mapbox/android/core/location/LocationEngineRequest;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_style;
#pragma warning disable 0169
		static Delegate GetStyleHandler ()
		{
			if (cb_style == null)
				cb_style = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Style);
			return cb_style;
		}

		static IntPtr n_Style (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Style ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions']/method[@name='style' and count(parameter)=0]"
		[Register ("style", "()Lcom/mapbox/mapboxsdk/maps/Style;", "GetStyleHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style Style ()
		{
			const string __id = "style.()Lcom/mapbox/mapboxsdk/maps/Style;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_styleRes;
#pragma warning disable 0169
		static Delegate GetStyleResHandler ()
		{
			if (cb_styleRes == null)
				cb_styleRes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_StyleRes);
			return cb_styleRes;
		}

		static int n_StyleRes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StyleRes ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions']/method[@name='styleRes' and count(parameter)=0]"
		[Register ("styleRes", "()I", "GetStyleResHandler")]
		public virtual unsafe int StyleRes ()
		{
			const string __id = "styleRes.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_useDefaultLocationEngine;
#pragma warning disable 0169
		static Delegate GetUseDefaultLocationEngineHandler ()
		{
			if (cb_useDefaultLocationEngine == null)
				cb_useDefaultLocationEngine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseDefaultLocationEngine);
			return cb_useDefaultLocationEngine;
		}

		static bool n_UseDefaultLocationEngine (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseDefaultLocationEngine ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponentActivationOptions']/method[@name='useDefaultLocationEngine' and count(parameter)=0]"
		[Register ("useDefaultLocationEngine", "()Z", "GetUseDefaultLocationEngineHandler")]
		public virtual unsafe bool UseDefaultLocationEngine ()
		{
			const string __id = "useDefaultLocationEngine.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
