using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnLocationStaleListener']"
	[Register ("com/mapbox/mapboxsdk/location/OnLocationStaleListener", "", "Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerInvoker")]
	public partial interface IOnLocationStaleListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnLocationStaleListener']/method[@name='onStaleStateChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onStaleStateChange", "(Z)V", "GetOnStaleStateChange_ZHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnStaleStateChange (bool p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/OnLocationStaleListener", DoNotGenerateAcw=true)]
	internal class IOnLocationStaleListenerInvoker : global::Java.Lang.Object, IOnLocationStaleListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/location/OnLocationStaleListener", typeof (IOnLocationStaleListenerInvoker));

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

		public static IOnLocationStaleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnLocationStaleListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.location.OnLocationStaleListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnLocationStaleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onStaleStateChange_Z;
#pragma warning disable 0169
		static Delegate GetOnStaleStateChange_ZHandler ()
		{
			if (cb_onStaleStateChange_Z == null)
				cb_onStaleStateChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnStaleStateChange_Z);
			return cb_onStaleStateChange_Z;
		}

		static void n_OnStaleStateChange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStaleStateChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStaleStateChange_Z;
		public unsafe void OnStaleStateChange (bool p0)
		{
			if (id_onStaleStateChange_Z == IntPtr.Zero)
				id_onStaleStateChange_Z = JNIEnv.GetMethodID (class_ref, "onStaleStateChange", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStaleStateChange_Z, __args);
		}

	}

	// event args for com.mapbox.mapboxsdk.location.OnLocationStaleListener.onStaleStateChange
	public partial class LocationStaleEventArgs : global::System.EventArgs {

		public LocationStaleEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/location/OnLocationStaleListenerImplementor")]
	internal sealed partial class IOnLocationStaleListenerImplementor : global::Java.Lang.Object, IOnLocationStaleListener {

		object sender;

		public IOnLocationStaleListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/location/OnLocationStaleListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LocationStaleEventArgs> Handler;
#pragma warning restore 0649

		public void OnStaleStateChange (bool p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LocationStaleEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnLocationStaleListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
