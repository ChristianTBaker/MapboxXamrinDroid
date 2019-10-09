using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='TelemetryDefinition']"
	[Register ("com/mapbox/mapboxsdk/maps/TelemetryDefinition", "", "Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinitionInvoker")]
	public partial interface ITelemetryDefinition : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='TelemetryDefinition']/method[@name='disableTelemetrySession' and count(parameter)=0]"
		[Register ("disableTelemetrySession", "()V", "GetDisableTelemetrySessionHandler:Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void DisableTelemetrySession ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='TelemetryDefinition']/method[@name='onAppUserTurnstileEvent' and count(parameter)=0]"
		[Register ("onAppUserTurnstileEvent", "()V", "GetOnAppUserTurnstileEventHandler:Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void OnAppUserTurnstileEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='TelemetryDefinition']/method[@name='onCreateOfflineRegion' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegionDefinition']]"
		[Register ("onCreateOfflineRegion", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;)V", "GetOnCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_Handler:Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void OnCreateOfflineRegion (global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='TelemetryDefinition']/method[@name='onGestureInteraction' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
[Obsolete (@"deprecated")]
		[Register ("onGestureInteraction", "(Ljava/lang/String;DDD)V", "GetOnGestureInteraction_Ljava_lang_String_DDDHandler:Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void OnGestureInteraction (string p0, double p1, double p2, double p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='TelemetryDefinition']/method[@name='onPerformanceEvent' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onPerformanceEvent", "(Landroid/os/Bundle;)V", "GetOnPerformanceEvent_Landroid_os_Bundle_Handler:Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void OnPerformanceEvent (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='TelemetryDefinition']/method[@name='setDebugLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebugLoggingEnabled", "(Z)V", "GetSetDebugLoggingEnabled_ZHandler:Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void SetDebugLoggingEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='TelemetryDefinition']/method[@name='setSessionIdRotationInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSessionIdRotationInterval", "(I)Z", "GetSetSessionIdRotationInterval_IHandler:Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinitionInvoker, Mapbox-SDK-8.4.0")]
		bool SetSessionIdRotationInterval (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='TelemetryDefinition']/method[@name='setUserTelemetryRequestState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUserTelemetryRequestState", "(Z)V", "GetSetUserTelemetryRequestState_ZHandler:Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void SetUserTelemetryRequestState (bool p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/TelemetryDefinition", DoNotGenerateAcw=true)]
	internal class ITelemetryDefinitionInvoker : global::Java.Lang.Object, ITelemetryDefinition {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/TelemetryDefinition", typeof (ITelemetryDefinitionInvoker));

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

		public static ITelemetryDefinition GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITelemetryDefinition> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.TelemetryDefinition"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITelemetryDefinitionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableTelemetrySession ();
		}
#pragma warning restore 0169

		IntPtr id_disableTelemetrySession;
		public unsafe void DisableTelemetrySession ()
		{
			if (id_disableTelemetrySession == IntPtr.Zero)
				id_disableTelemetrySession = JNIEnv.GetMethodID (class_ref, "disableTelemetrySession", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableTelemetrySession);
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
			global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAppUserTurnstileEvent ();
		}
#pragma warning restore 0169

		IntPtr id_onAppUserTurnstileEvent;
		public unsafe void OnAppUserTurnstileEvent ()
		{
			if (id_onAppUserTurnstileEvent == IntPtr.Zero)
				id_onAppUserTurnstileEvent = JNIEnv.GetMethodID (class_ref, "onAppUserTurnstileEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAppUserTurnstileEvent);
		}

		static Delegate cb_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_;
#pragma warning disable 0169
		static Delegate GetOnCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_Handler ()
		{
			if (cb_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_ == null)
				cb_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_);
			return cb_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_;
		}

		static void n_OnCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition p0 = (global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateOfflineRegion (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_;
		public unsafe void OnCreateOfflineRegion (global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition p0)
		{
			if (id_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_ == IntPtr.Zero)
				id_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_ = JNIEnv.GetMethodID (class_ref, "onCreateOfflineRegion", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_, __args);
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
		static void n_OnGestureInteraction_Ljava_lang_String_DDD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1, double p2, double p3)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGestureInteraction (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onGestureInteraction_Ljava_lang_String_DDD;
		public unsafe void OnGestureInteraction (string p0, double p1, double p2, double p3)
		{
			if (id_onGestureInteraction_Ljava_lang_String_DDD == IntPtr.Zero)
				id_onGestureInteraction_Ljava_lang_String_DDD = JNIEnv.GetMethodID (class_ref, "onGestureInteraction", "(Ljava/lang/String;DDD)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGestureInteraction_Ljava_lang_String_DDD, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onPerformanceEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnPerformanceEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_onPerformanceEvent_Landroid_os_Bundle_ == null)
				cb_onPerformanceEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPerformanceEvent_Landroid_os_Bundle_);
			return cb_onPerformanceEvent_Landroid_os_Bundle_;
		}

		static void n_OnPerformanceEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPerformanceEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPerformanceEvent_Landroid_os_Bundle_;
		public unsafe void OnPerformanceEvent (global::Android.OS.Bundle p0)
		{
			if (id_onPerformanceEvent_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onPerformanceEvent_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onPerformanceEvent", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPerformanceEvent_Landroid_os_Bundle_, __args);
		}

		static Delegate cb_setDebugLoggingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDebugLoggingEnabled_ZHandler ()
		{
			if (cb_setDebugLoggingEnabled_Z == null)
				cb_setDebugLoggingEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebugLoggingEnabled_Z);
			return cb_setDebugLoggingEnabled_Z;
		}

		static void n_SetDebugLoggingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugLoggingEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDebugLoggingEnabled_Z;
		public unsafe void SetDebugLoggingEnabled (bool p0)
		{
			if (id_setDebugLoggingEnabled_Z == IntPtr.Zero)
				id_setDebugLoggingEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDebugLoggingEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDebugLoggingEnabled_Z, __args);
		}

		static Delegate cb_setSessionIdRotationInterval_I;
#pragma warning disable 0169
		static Delegate GetSetSessionIdRotationInterval_IHandler ()
		{
			if (cb_setSessionIdRotationInterval_I == null)
				cb_setSessionIdRotationInterval_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetSessionIdRotationInterval_I);
			return cb_setSessionIdRotationInterval_I;
		}

		static bool n_SetSessionIdRotationInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSessionIdRotationInterval (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSessionIdRotationInterval_I;
		public unsafe bool SetSessionIdRotationInterval (int p0)
		{
			if (id_setSessionIdRotationInterval_I == IntPtr.Zero)
				id_setSessionIdRotationInterval_I = JNIEnv.GetMethodID (class_ref, "setSessionIdRotationInterval", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setSessionIdRotationInterval_I, __args);
		}

		static Delegate cb_setUserTelemetryRequestState_Z;
#pragma warning disable 0169
		static Delegate GetSetUserTelemetryRequestState_ZHandler ()
		{
			if (cb_setUserTelemetryRequestState_Z == null)
				cb_setUserTelemetryRequestState_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUserTelemetryRequestState_Z);
			return cb_setUserTelemetryRequestState_Z;
		}

		static void n_SetUserTelemetryRequestState_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUserTelemetryRequestState (p0);
		}
#pragma warning restore 0169

		IntPtr id_setUserTelemetryRequestState_Z;
		public unsafe void SetUserTelemetryRequestState (bool p0)
		{
			if (id_setUserTelemetryRequestState_Z == IntPtr.Zero)
				id_setUserTelemetryRequestState_Z = JNIEnv.GetMethodID (class_ref, "setUserTelemetryRequestState", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserTelemetryRequestState_Z, __args);
		}

	}

}
