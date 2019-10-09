using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Module.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/module/telemetry/TelemetryImpl", DoNotGenerateAcw=true)]
	public partial class TelemetryImpl : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/module/telemetry/TelemetryImpl", typeof (TelemetryImpl));
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

		protected TelemetryImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']/constructor[@name='TelemetryImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TelemetryImpl ()
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

		static Delegate cb_disableTelemetrySession;
#pragma warning disable 0169
		static Delegate GetDisableTelemetrySessionHandler ()
		{
			if (cb_disableTelemetrySession == null)
				cb_disableTelemetrySession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableTelemetrySession);
			return cb_disableTelemetrySession;
		}

		static void n_DisableTelemetrySession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableTelemetrySession ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']/method[@name='disableTelemetrySession' and count(parameter)=0]"
		[Register ("disableTelemetrySession", "()V", "GetDisableTelemetrySessionHandler")]
		public virtual unsafe void DisableTelemetrySession ()
		{
			const string __id = "disableTelemetrySession.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onAppUserTurnstileEvent;
#pragma warning disable 0169
		static Delegate GetOnAppUserTurnstileEventHandler ()
		{
			if (cb_onAppUserTurnstileEvent == null)
				cb_onAppUserTurnstileEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAppUserTurnstileEvent);
			return cb_onAppUserTurnstileEvent;
		}

		static void n_OnAppUserTurnstileEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAppUserTurnstileEvent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']/method[@name='onAppUserTurnstileEvent' and count(parameter)=0]"
		[Register ("onAppUserTurnstileEvent", "()V", "GetOnAppUserTurnstileEventHandler")]
		public virtual unsafe void OnAppUserTurnstileEvent ()
		{
			const string __id = "onAppUserTurnstileEvent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_;
#pragma warning disable 0169
		static Delegate GetOnCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_Handler ()
		{
			if (cb_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_ == null)
				cb_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_);
			return cb_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_;
		}

		static void n_OnCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_offlineDefinition)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition offlineDefinition = (global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (native_offlineDefinition, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateOfflineRegion (offlineDefinition);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']/method[@name='onCreateOfflineRegion' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegionDefinition']]"
		[Register ("onCreateOfflineRegion", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;)V", "GetOnCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_Handler")]
		public virtual unsafe void OnCreateOfflineRegion (global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition offlineDefinition)
		{
			const string __id = "onCreateOfflineRegion.(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((offlineDefinition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) offlineDefinition).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onGestureInteraction_Ljava_lang_String_DDD;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetOnGestureInteraction_Ljava_lang_String_DDDHandler ()
		{
			if (cb_onGestureInteraction_Ljava_lang_String_DDD == null)
				cb_onGestureInteraction_Ljava_lang_String_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double, double, double>) n_OnGestureInteraction_Ljava_lang_String_DDD);
			return cb_onGestureInteraction_Ljava_lang_String_DDD;
		}

		[Obsolete]
		static void n_OnGestureInteraction_Ljava_lang_String_DDD (IntPtr jnienv, IntPtr native__this, IntPtr native_eventType, double latitude, double longitude, double zoom)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eventType = JNIEnv.GetString (native_eventType, JniHandleOwnership.DoNotTransfer);
			__this.OnGestureInteraction (eventType, latitude, longitude, zoom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']/method[@name='onGestureInteraction' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Obsolete (@"deprecated")]
		[Register ("onGestureInteraction", "(Ljava/lang/String;DDD)V", "GetOnGestureInteraction_Ljava_lang_String_DDDHandler")]
		public virtual unsafe void OnGestureInteraction (string eventType, double latitude, double longitude, double zoom)
		{
			const string __id = "onGestureInteraction.(Ljava/lang/String;DDD)V";
			IntPtr native_eventType = JNIEnv.NewString (eventType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_eventType);
				__args [1] = new JniArgumentValue (latitude);
				__args [2] = new JniArgumentValue (longitude);
				__args [3] = new JniArgumentValue (zoom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventType);
			}
		}

		static Delegate cb_onPerformanceEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnPerformanceEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_onPerformanceEvent_Landroid_os_Bundle_ == null)
				cb_onPerformanceEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPerformanceEvent_Landroid_os_Bundle_);
			return cb_onPerformanceEvent_Landroid_os_Bundle_;
		}

		static void n_OnPerformanceEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle data = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.OnPerformanceEvent (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']/method[@name='onPerformanceEvent' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onPerformanceEvent", "(Landroid/os/Bundle;)V", "GetOnPerformanceEvent_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnPerformanceEvent (global::Android.OS.Bundle data)
		{
			const string __id = "onPerformanceEvent.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDebugLoggingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDebugLoggingEnabled_ZHandler ()
		{
			if (cb_setDebugLoggingEnabled_Z == null)
				cb_setDebugLoggingEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebugLoggingEnabled_Z);
			return cb_setDebugLoggingEnabled_Z;
		}

		static void n_SetDebugLoggingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool debugLoggingEnabled)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugLoggingEnabled (debugLoggingEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']/method[@name='setDebugLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebugLoggingEnabled", "(Z)V", "GetSetDebugLoggingEnabled_ZHandler")]
		public virtual unsafe void SetDebugLoggingEnabled (bool debugLoggingEnabled)
		{
			const string __id = "setDebugLoggingEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (debugLoggingEnabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSessionIdRotationInterval_I;
#pragma warning disable 0169
		static Delegate GetSetSessionIdRotationInterval_IHandler ()
		{
			if (cb_setSessionIdRotationInterval_I == null)
				cb_setSessionIdRotationInterval_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetSessionIdRotationInterval_I);
			return cb_setSessionIdRotationInterval_I;
		}

		static bool n_SetSessionIdRotationInterval_I (IntPtr jnienv, IntPtr native__this, int interval)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSessionIdRotationInterval (interval);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']/method[@name='setSessionIdRotationInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSessionIdRotationInterval", "(I)Z", "GetSetSessionIdRotationInterval_IHandler")]
		public virtual unsafe bool SetSessionIdRotationInterval (int interval)
		{
			const string __id = "setSessionIdRotationInterval.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (interval);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setUserTelemetryRequestState_Z;
#pragma warning disable 0169
		static Delegate GetSetUserTelemetryRequestState_ZHandler ()
		{
			if (cb_setUserTelemetryRequestState_Z == null)
				cb_setUserTelemetryRequestState_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUserTelemetryRequestState_Z);
			return cb_setUserTelemetryRequestState_Z;
		}

		static void n_SetUserTelemetryRequestState_Z (IntPtr jnienv, IntPtr native__this, bool enabledTelemetry)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Telemetry.TelemetryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUserTelemetryRequestState (enabledTelemetry);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.telemetry']/class[@name='TelemetryImpl']/method[@name='setUserTelemetryRequestState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUserTelemetryRequestState", "(Z)V", "GetSetUserTelemetryRequestState_ZHandler")]
		public virtual unsafe void SetUserTelemetryRequestState (bool enabledTelemetry)
		{
			const string __id = "setUserTelemetryRequestState.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabledTelemetry);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
