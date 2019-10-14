using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/MapboxTelemetry", DoNotGenerateAcw=true)]
	public partial class MapboxTelemetry : global::Java.Lang.Object, global::Com.Mapbox.Android.Telemetry.IFullQueueCallback, global::Com.Mapbox.Android.Telemetry.IServiceTaskCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/MapboxTelemetry", typeof (MapboxTelemetry));
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

		protected MapboxTelemetry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/constructor[@name='MapboxTelemetry' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MapboxTelemetry (global::Android.Content.Context context, string accessToken, string userAgent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_accessToken = JNIEnv.NewString (accessToken);
			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_accessToken);
				__args [2] = new JniArgumentValue (native_userAgent);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accessToken);
				JNIEnv.DeleteLocalRef (native_userAgent);
			}
		}

		static Delegate cb_addAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_;
#pragma warning disable 0169
		static Delegate GetAddAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_Handler ()
		{
			if (cb_addAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_ == null)
				cb_addAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_);
			return cb_addAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_;
		}

		static bool n_AddAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Telemetry.IAttachmentListener listener = (global::Com.Mapbox.Android.Telemetry.IAttachmentListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.IAttachmentListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAttachmentListener (listener);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='addAttachmentListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.AttachmentListener']]"
		[Register ("addAttachmentListener", "(Lcom/mapbox/android/telemetry/AttachmentListener;)Z", "GetAddAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_Handler")]
		public virtual unsafe bool AddAttachmentListener (global::Com.Mapbox.Android.Telemetry.IAttachmentListener listener)
		{
			const string __id = "addAttachmentListener.(Lcom/mapbox/android/telemetry/AttachmentListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_addTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_;
#pragma warning disable 0169
		static Delegate GetAddTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_Handler ()
		{
			if (cb_addTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_ == null)
				cb_addTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_);
			return cb_addTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_;
		}

		static bool n_AddTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Telemetry.ITelemetryListener listener = (global::Com.Mapbox.Android.Telemetry.ITelemetryListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.ITelemetryListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddTelemetryListener (listener);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='addTelemetryListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.TelemetryListener']]"
		[Register ("addTelemetryListener", "(Lcom/mapbox/android/telemetry/TelemetryListener;)Z", "GetAddTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_Handler")]
		public virtual unsafe bool AddTelemetryListener (global::Com.Mapbox.Android.Telemetry.ITelemetryListener listener)
		{
			const string __id = "addTelemetryListener.(Lcom/mapbox/android/telemetry/TelemetryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Disable);
			return cb_disable;
		}

		static bool n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Disable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()Z", "GetDisableHandler")]
		public virtual unsafe bool Disable ()
		{
			const string __id = "disable.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_enable;
#pragma warning disable 0169
		static Delegate GetEnableHandler ()
		{
			if (cb_enable == null)
				cb_enable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Enable);
			return cb_enable;
		}

		static bool n_Enable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()Z", "GetEnableHandler")]
		public virtual unsafe bool Enable ()
		{
			const string __id = "enable.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onFullQueue_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnFullQueue_Ljava_util_List_Handler ()
		{
			if (cb_onFullQueue_Ljava_util_List_ == null)
				cb_onFullQueue_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFullQueue_Ljava_util_List_);
			return cb_onFullQueue_Ljava_util_List_;
		}

		static void n_OnFullQueue_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fullQueue)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fullQueue = global::Android.Runtime.JavaList<global::Com.Mapbox.Android.Telemetry.Event>.FromJniHandle (native_fullQueue, JniHandleOwnership.DoNotTransfer);
			__this.OnFullQueue (fullQueue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='onFullQueue' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.android.telemetry.Event&gt;']]"
		[Register ("onFullQueue", "(Ljava/util/List;)V", "GetOnFullQueue_Ljava_util_List_Handler")]
		public virtual unsafe void OnFullQueue (global::System.Collections.Generic.IList<global::Com.Mapbox.Android.Telemetry.Event> fullQueue)
		{
			const string __id = "onFullQueue.(Ljava/util/List;)V";
			IntPtr native_fullQueue = global::Android.Runtime.JavaList<global::Com.Mapbox.Android.Telemetry.Event>.ToLocalJniHandle (fullQueue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fullQueue);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fullQueue);
			}
		}

		static Delegate cb_onTaskRemoved;
#pragma warning disable 0169
		static Delegate GetOnTaskRemovedHandler ()
		{
			if (cb_onTaskRemoved == null)
				cb_onTaskRemoved = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTaskRemoved);
			return cb_onTaskRemoved;
		}

		static void n_OnTaskRemoved (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskRemoved ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='onTaskRemoved' and count(parameter)=0]"
		[Register ("onTaskRemoved", "()V", "GetOnTaskRemovedHandler")]
		public virtual unsafe void OnTaskRemoved ()
		{
			const string __id = "onTaskRemoved.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_push_Lcom_mapbox_android_telemetry_Event_;
#pragma warning disable 0169
		static Delegate GetPush_Lcom_mapbox_android_telemetry_Event_Handler ()
		{
			if (cb_push_Lcom_mapbox_android_telemetry_Event_ == null)
				cb_push_Lcom_mapbox_android_telemetry_Event_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Push_Lcom_mapbox_android_telemetry_Event_);
			return cb_push_Lcom_mapbox_android_telemetry_Event_;
		}

		static bool n_Push_Lcom_mapbox_android_telemetry_Event_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Telemetry.Event e = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Push (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='push' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.Event']]"
		[Register ("push", "(Lcom/mapbox/android/telemetry/Event;)Z", "GetPush_Lcom_mapbox_android_telemetry_Event_Handler")]
		public virtual unsafe bool Push (global::Com.Mapbox.Android.Telemetry.Event e)
		{
			const string __id = "push.(Lcom/mapbox/android/telemetry/Event;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_;
#pragma warning disable 0169
		static Delegate GetRemoveAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_Handler ()
		{
			if (cb_removeAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_ == null)
				cb_removeAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_);
			return cb_removeAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_;
		}

		static bool n_RemoveAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Telemetry.IAttachmentListener listener = (global::Com.Mapbox.Android.Telemetry.IAttachmentListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.IAttachmentListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAttachmentListener (listener);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='removeAttachmentListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.AttachmentListener']]"
		[Register ("removeAttachmentListener", "(Lcom/mapbox/android/telemetry/AttachmentListener;)Z", "GetRemoveAttachmentListener_Lcom_mapbox_android_telemetry_AttachmentListener_Handler")]
		public virtual unsafe bool RemoveAttachmentListener (global::Com.Mapbox.Android.Telemetry.IAttachmentListener listener)
		{
			const string __id = "removeAttachmentListener.(Lcom/mapbox/android/telemetry/AttachmentListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_;
#pragma warning disable 0169
		static Delegate GetRemoveTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_Handler ()
		{
			if (cb_removeTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_ == null)
				cb_removeTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_);
			return cb_removeTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_;
		}

		static bool n_RemoveTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Telemetry.ITelemetryListener listener = (global::Com.Mapbox.Android.Telemetry.ITelemetryListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.ITelemetryListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveTelemetryListener (listener);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='removeTelemetryListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.TelemetryListener']]"
		[Register ("removeTelemetryListener", "(Lcom/mapbox/android/telemetry/TelemetryListener;)Z", "GetRemoveTelemetryListener_Lcom_mapbox_android_telemetry_TelemetryListener_Handler")]
		public virtual unsafe bool RemoveTelemetryListener (global::Com.Mapbox.Android.Telemetry.ITelemetryListener listener)
		{
			const string __id = "removeTelemetryListener.(Lcom/mapbox/android/telemetry/TelemetryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_updateAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_updateAccessToken_Ljava_lang_String_ == null)
				cb_updateAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateAccessToken_Ljava_lang_String_);
			return cb_updateAccessToken_Ljava_lang_String_;
		}

		static bool n_UpdateAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessToken)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateAccessToken (accessToken);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='updateAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateAccessToken", "(Ljava/lang/String;)Z", "GetUpdateAccessToken_Ljava_lang_String_Handler")]
		public virtual unsafe bool UpdateAccessToken (string accessToken)
		{
			const string __id = "updateAccessToken.(Ljava/lang/String;)Z";
			IntPtr native_accessToken = JNIEnv.NewString (accessToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_accessToken);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_accessToken);
			}
		}

		static Delegate cb_updateDebugLoggingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetUpdateDebugLoggingEnabled_ZHandler ()
		{
			if (cb_updateDebugLoggingEnabled_Z == null)
				cb_updateDebugLoggingEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_UpdateDebugLoggingEnabled_Z);
			return cb_updateDebugLoggingEnabled_Z;
		}

		static void n_UpdateDebugLoggingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool isDebugLoggingEnabled)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDebugLoggingEnabled (isDebugLoggingEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='updateDebugLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("updateDebugLoggingEnabled", "(Z)V", "GetUpdateDebugLoggingEnabled_ZHandler")]
		public virtual unsafe void UpdateDebugLoggingEnabled (bool isDebugLoggingEnabled)
		{
			const string __id = "updateDebugLoggingEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isDebugLoggingEnabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateSessionIdRotationInterval_Lcom_mapbox_android_telemetry_SessionInterval_;
#pragma warning disable 0169
		static Delegate GetUpdateSessionIdRotationInterval_Lcom_mapbox_android_telemetry_SessionInterval_Handler ()
		{
			if (cb_updateSessionIdRotationInterval_Lcom_mapbox_android_telemetry_SessionInterval_ == null)
				cb_updateSessionIdRotationInterval_Lcom_mapbox_android_telemetry_SessionInterval_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateSessionIdRotationInterval_Lcom_mapbox_android_telemetry_SessionInterval_);
			return cb_updateSessionIdRotationInterval_Lcom_mapbox_android_telemetry_SessionInterval_;
		}

		static bool n_UpdateSessionIdRotationInterval_Lcom_mapbox_android_telemetry_SessionInterval_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interval)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Telemetry.SessionInterval interval = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.SessionInterval> (native_interval, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateSessionIdRotationInterval (interval);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='updateSessionIdRotationInterval' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.SessionInterval']]"
		[Register ("updateSessionIdRotationInterval", "(Lcom/mapbox/android/telemetry/SessionInterval;)Z", "GetUpdateSessionIdRotationInterval_Lcom_mapbox_android_telemetry_SessionInterval_Handler")]
		public virtual unsafe bool UpdateSessionIdRotationInterval (global::Com.Mapbox.Android.Telemetry.SessionInterval interval)
		{
			const string __id = "updateSessionIdRotationInterval.(Lcom/mapbox/android/telemetry/SessionInterval;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interval == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interval).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_updateUserAgent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateUserAgent_Ljava_lang_String_Handler ()
		{
			if (cb_updateUserAgent_Ljava_lang_String_ == null)
				cb_updateUserAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateUserAgent_Ljava_lang_String_);
			return cb_updateUserAgent_Ljava_lang_String_;
		}

		static void n_UpdateUserAgent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userAgent)
		{
			global::Com.Mapbox.Android.Telemetry.MapboxTelemetry __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.MapboxTelemetry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string userAgent = JNIEnv.GetString (native_userAgent, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserAgent (userAgent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='MapboxTelemetry']/method[@name='updateUserAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateUserAgent", "(Ljava/lang/String;)V", "GetUpdateUserAgent_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateUserAgent (string userAgent)
		{
			const string __id = "updateUserAgent.(Ljava/lang/String;)V";
			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userAgent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userAgent);
			}
		}

	}
}
