using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Net {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/interface[@name='ConnectivityListener']"
	[Register ("com/mapbox/mapboxsdk/net/ConnectivityListener", "", "Com.Mapbox.Mapboxsdk.Net.IConnectivityListenerInvoker")]
	public partial interface IConnectivityListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.net']/interface[@name='ConnectivityListener']/method[@name='onNetworkStateChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onNetworkStateChanged", "(Z)V", "GetOnNetworkStateChanged_ZHandler:Com.Mapbox.Mapboxsdk.Net.IConnectivityListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnNetworkStateChanged (bool p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/net/ConnectivityListener", DoNotGenerateAcw=true)]
	internal class IConnectivityListenerInvoker : global::Java.Lang.Object, IConnectivityListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/net/ConnectivityListener", typeof (IConnectivityListenerInvoker));

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

		public static IConnectivityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectivityListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.net.ConnectivityListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectivityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNetworkStateChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnNetworkStateChanged_ZHandler ()
		{
			if (cb_onNetworkStateChanged_Z == null)
				cb_onNetworkStateChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnNetworkStateChanged_Z);
			return cb_onNetworkStateChanged_Z;
		}

		static void n_OnNetworkStateChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Net.IConnectivityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkStateChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNetworkStateChanged_Z;
		public unsafe void OnNetworkStateChanged (bool p0)
		{
			if (id_onNetworkStateChanged_Z == IntPtr.Zero)
				id_onNetworkStateChanged_Z = JNIEnv.GetMethodID (class_ref, "onNetworkStateChanged", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkStateChanged_Z, __args);
		}

	}

	// event args for com.mapbox.mapboxsdk.net.ConnectivityListener.onNetworkStateChanged
	public partial class ConnectivityEventArgs : global::System.EventArgs {

		public ConnectivityEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/net/ConnectivityListenerImplementor")]
	internal sealed partial class IConnectivityListenerImplementor : global::Java.Lang.Object, IConnectivityListener {

		object sender;

		public IConnectivityListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/net/ConnectivityListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConnectivityEventArgs> Handler;
#pragma warning restore 0649

		public void OnNetworkStateChanged (bool p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ConnectivityEventArgs (p0));
		}

		internal static bool __IsEmpty (IConnectivityListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
