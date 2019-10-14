using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Connectivity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core.connectivity']/class[@name='ConnectivityReceiver']"
	[global::Android.Runtime.Register ("com/mapbox/android/core/connectivity/ConnectivityReceiver", DoNotGenerateAcw=true)]
	public partial class ConnectivityReceiver : global::Android.Content.BroadcastReceiver {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/connectivity/ConnectivityReceiver", typeof (ConnectivityReceiver));
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

		protected ConnectivityReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.core.connectivity']/class[@name='ConnectivityReceiver']/constructor[@name='ConnectivityReceiver' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ConnectivityReceiver (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getConnectedFlag;
#pragma warning disable 0169
		static Delegate GetGetConnectedFlagHandler ()
		{
			if (cb_getConnectedFlag == null)
				cb_getConnectedFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedFlag);
			return cb_getConnectedFlag;
		}

		static IntPtr n_GetConnectedFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectedFlag);
		}
#pragma warning restore 0169

		static Delegate cb_setConnectedFlag_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetConnectedFlag_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setConnectedFlag_Ljava_lang_Boolean_ == null)
				cb_setConnectedFlag_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConnectedFlag_Ljava_lang_Boolean_);
			return cb_setConnectedFlag_Ljava_lang_Boolean_;
		}

		static void n_SetConnectedFlag_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connectedFlag)
		{
			global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean connectedFlag = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_connectedFlag, JniHandleOwnership.DoNotTransfer);
			__this.ConnectedFlag = connectedFlag;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean ConnectedFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.connectivity']/class[@name='ConnectivityReceiver']/method[@name='getConnectedFlag' and count(parameter)=0]"
			[Register ("getConnectedFlag", "()Ljava/lang/Boolean;", "GetGetConnectedFlagHandler")]
			get {
				const string __id = "getConnectedFlag.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.connectivity']/class[@name='ConnectivityReceiver']/method[@name='setConnectedFlag' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setConnectedFlag", "(Ljava/lang/Boolean;)V", "GetSetConnectedFlag_Ljava_lang_Boolean_Handler")]
			set {
				const string __id = "setConnectedFlag.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.connectivity']/class[@name='ConnectivityReceiver']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.connectivity']/class[@name='ConnectivityReceiver']/method[@name='isConnected' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isConnected", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool InvokeIsConnected (global::Android.Content.Context context)
		{
			const string __id = "isConnected.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (context, intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.connectivity']/class[@name='ConnectivityReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeConnectivityUpdates;
#pragma warning disable 0169
		static Delegate GetRemoveConnectivityUpdatesHandler ()
		{
			if (cb_removeConnectivityUpdates == null)
				cb_removeConnectivityUpdates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveConnectivityUpdates);
			return cb_removeConnectivityUpdates;
		}

		static void n_RemoveConnectivityUpdates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConnectivityUpdates ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.connectivity']/class[@name='ConnectivityReceiver']/method[@name='removeConnectivityUpdates' and count(parameter)=0]"
		[Register ("removeConnectivityUpdates", "()V", "GetRemoveConnectivityUpdatesHandler")]
		public virtual unsafe void RemoveConnectivityUpdates ()
		{
			const string __id = "removeConnectivityUpdates.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_requestConnectivityUpdates;
#pragma warning disable 0169
		static Delegate GetRequestConnectivityUpdatesHandler ()
		{
			if (cb_requestConnectivityUpdates == null)
				cb_requestConnectivityUpdates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestConnectivityUpdates);
			return cb_requestConnectivityUpdates;
		}

		static void n_RequestConnectivityUpdates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Connectivity.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestConnectivityUpdates ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.connectivity']/class[@name='ConnectivityReceiver']/method[@name='requestConnectivityUpdates' and count(parameter)=0]"
		[Register ("requestConnectivityUpdates", "()V", "GetRequestConnectivityUpdatesHandler")]
		public virtual unsafe void RequestConnectivityUpdates ()
		{
			const string __id = "requestConnectivityUpdates.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
