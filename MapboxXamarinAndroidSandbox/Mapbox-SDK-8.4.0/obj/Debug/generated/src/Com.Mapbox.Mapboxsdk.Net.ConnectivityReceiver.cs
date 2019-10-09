using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/class[@name='ConnectivityReceiver']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/net/ConnectivityReceiver", DoNotGenerateAcw=true)]
	public partial class ConnectivityReceiver : global::Android.Content.BroadcastReceiver {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/net/ConnectivityReceiver", typeof (ConnectivityReceiver));
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
			global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/class[@name='ConnectivityReceiver']/method[@name='isConnected' and count(parameter)=0]"
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

		static Delegate cb_activate;
#pragma warning disable 0169
		static Delegate GetActivateHandler ()
		{
			if (cb_activate == null)
				cb_activate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Activate);
			return cb_activate;
		}

		static void n_Activate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Activate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/class[@name='ConnectivityReceiver']/method[@name='activate' and count(parameter)=0]"
		[Register ("activate", "()V", "GetActivateHandler")]
		public virtual unsafe void Activate ()
		{
			const string __id = "activate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_addListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_Handler ()
		{
			if (cb_addListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_ == null)
				cb_addListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_);
			return cb_addListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_;
		}

		static void n_AddListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener listener = (global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/class[@name='ConnectivityReceiver']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.net.ConnectivityListener']]"
		[Register ("addListener", "(Lcom/mapbox/mapboxsdk/net/ConnectivityListener;)V", "GetAddListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_Handler")]
		public virtual unsafe void AddListener (global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener listener)
		{
			const string __id = "addListener.(Lcom/mapbox/mapboxsdk/net/ConnectivityListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_deactivate;
#pragma warning disable 0169
		static Delegate GetDeactivateHandler ()
		{
			if (cb_deactivate == null)
				cb_deactivate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Deactivate);
			return cb_deactivate;
		}

		static void n_Deactivate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deactivate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/class[@name='ConnectivityReceiver']/method[@name='deactivate' and count(parameter)=0]"
		[Register ("deactivate", "()V", "GetDeactivateHandler")]
		public virtual unsafe void Deactivate ()
		{
			const string __id = "deactivate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/class[@name='ConnectivityReceiver']/method[@name='instance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("instance", "(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/net/ConnectivityReceiver;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver Instance (global::Android.Content.Context context)
		{
			const string __id = "instance.(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/net/ConnectivityReceiver;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (context, intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/class[@name='ConnectivityReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
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

		static Delegate cb_removeListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_Handler ()
		{
			if (cb_removeListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_ == null)
				cb_removeListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_);
			return cb_removeListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_;
		}

		static void n_RemoveListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener listener = (global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/class[@name='ConnectivityReceiver']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.net.ConnectivityListener']]"
		[Register ("removeListener", "(Lcom/mapbox/mapboxsdk/net/ConnectivityListener;)V", "GetRemoveListener_Lcom_mapbox_mapboxsdk_net_ConnectivityListener_Handler")]
		public virtual unsafe void RemoveListener (global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener listener)
		{
			const string __id = "removeListener.(Lcom/mapbox/mapboxsdk/net/ConnectivityListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setConnected_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetConnected_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setConnected_Ljava_lang_Boolean_ == null)
				cb_setConnected_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConnected_Ljava_lang_Boolean_);
			return cb_setConnected_Ljava_lang_Boolean_;
		}

		static void n_SetConnected_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connected)
		{
			global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.ConnectivityReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean connected = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_connected, JniHandleOwnership.DoNotTransfer);
			__this.SetConnected (connected);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/class[@name='ConnectivityReceiver']/method[@name='setConnected' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setConnected", "(Ljava/lang/Boolean;)V", "GetSetConnected_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetConnected (global::Java.Lang.Boolean connected)
		{
			const string __id = "setConnected.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((connected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connected).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mapbox.Mapboxsdk.Net.IConnectivityListener"

		global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListenerImplementor __CreateIConnectivityListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListenerImplementor (this);
		}
#endregion
	}
}
