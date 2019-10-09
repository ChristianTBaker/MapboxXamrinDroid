using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CustomLayer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/CustomLayer", DoNotGenerateAcw=true)]
	public partial class CustomLayer : global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/CustomLayer", typeof (CustomLayer));
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

		protected CustomLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CustomLayer']/constructor[@name='CustomLayer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;J)V", "")]
		public unsafe CustomLayer (string id, long host)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (host);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_initialize_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_lang_String_JHandler ()
		{
			if (cb_initialize_Ljava_lang_String_J == null)
				cb_initialize_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Initialize_Ljava_lang_String_J);
			return cb_initialize_Ljava_lang_String_J;
		}

		static void n_Initialize_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CustomLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CustomLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CustomLayer']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("initialize", "(Ljava/lang/String;J)V", "GetInitialize_Ljava_lang_String_JHandler")]
		protected virtual unsafe void Initialize (string p0, long p1)
		{
			const string __id = "initialize.(Ljava/lang/String;J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_nativeUpdate;
#pragma warning disable 0169
		static Delegate GetNativeUpdateHandler ()
		{
			if (cb_nativeUpdate == null)
				cb_nativeUpdate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NativeUpdate);
			return cb_nativeUpdate;
		}

		static void n_NativeUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CustomLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CustomLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NativeUpdate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CustomLayer']/method[@name='nativeUpdate' and count(parameter)=0]"
		[Register ("nativeUpdate", "()V", "GetNativeUpdateHandler")]
		protected virtual unsafe void NativeUpdate ()
		{
			const string __id = "nativeUpdate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Update);
			return cb_update;
		}

		static void n_Update (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.CustomLayer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.CustomLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='CustomLayer']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()V", "GetUpdateHandler")]
		public virtual unsafe void Update ()
		{
			const string __id = "update.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
