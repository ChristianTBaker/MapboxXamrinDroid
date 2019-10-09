using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnCameraTrackingChangedListener']"
	[Register ("com/mapbox/mapboxsdk/location/OnCameraTrackingChangedListener", "", "Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerInvoker")]
	public partial interface IOnCameraTrackingChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnCameraTrackingChangedListener']/method[@name='onCameraTrackingChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCameraTrackingChanged", "(I)V", "GetOnCameraTrackingChanged_IHandler:Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnCameraTrackingChanged ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnCameraTrackingChangedListener']/method[@name='onCameraTrackingDismissed' and count(parameter)=0]"
		[Register ("onCameraTrackingDismissed", "()V", "GetOnCameraTrackingDismissedHandler:Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnCameraTrackingDismissed ();

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/OnCameraTrackingChangedListener", DoNotGenerateAcw=true)]
	internal class IOnCameraTrackingChangedListenerInvoker : global::Java.Lang.Object, IOnCameraTrackingChangedListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/location/OnCameraTrackingChangedListener", typeof (IOnCameraTrackingChangedListenerInvoker));

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

		public static IOnCameraTrackingChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnCameraTrackingChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.location.OnCameraTrackingChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnCameraTrackingChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCameraTrackingChanged_I;
#pragma warning disable 0169
		static Delegate GetOnCameraTrackingChanged_IHandler ()
		{
			if (cb_onCameraTrackingChanged_I == null)
				cb_onCameraTrackingChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnCameraTrackingChanged_I);
			return cb_onCameraTrackingChanged_I;
		}

		static void n_OnCameraTrackingChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraTrackingChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCameraTrackingChanged_I;
		public unsafe void OnCameraTrackingChanged ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int p0)
		{
			if (id_onCameraTrackingChanged_I == IntPtr.Zero)
				id_onCameraTrackingChanged_I = JNIEnv.GetMethodID (class_ref, "onCameraTrackingChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraTrackingChanged_I, __args);
		}

		static Delegate cb_onCameraTrackingDismissed;
#pragma warning disable 0169
		static Delegate GetOnCameraTrackingDismissedHandler ()
		{
			if (cb_onCameraTrackingDismissed == null)
				cb_onCameraTrackingDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraTrackingDismissed);
			return cb_onCameraTrackingDismissed;
		}

		static void n_OnCameraTrackingDismissed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraTrackingDismissed ();
		}
#pragma warning restore 0169

		IntPtr id_onCameraTrackingDismissed;
		public unsafe void OnCameraTrackingDismissed ()
		{
			if (id_onCameraTrackingDismissed == IntPtr.Zero)
				id_onCameraTrackingDismissed = JNIEnv.GetMethodID (class_ref, "onCameraTrackingDismissed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraTrackingDismissed);
		}

	}

	// event args for com.mapbox.mapboxsdk.location.OnCameraTrackingChangedListener.onCameraTrackingChanged
	public partial class CameraTrackingChangedEventArgs : global::System.EventArgs {

		public CameraTrackingChangedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/location/OnCameraTrackingChangedListenerImplementor")]
	internal sealed partial class IOnCameraTrackingChangedListenerImplementor : global::Java.Lang.Object, IOnCameraTrackingChangedListener {

		object sender;

		public IOnCameraTrackingChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/location/OnCameraTrackingChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CameraTrackingChangedEventArgs> OnCameraTrackingChangedHandler;
#pragma warning restore 0649

		public void OnCameraTrackingChanged ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int p0)
		{
			var __h = OnCameraTrackingChangedHandler;
			if (__h != null)
				__h (sender, new CameraTrackingChangedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnCameraTrackingDismissedHandler;
#pragma warning restore 0649

		public void OnCameraTrackingDismissed ()
		{
			var __h = OnCameraTrackingDismissedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnCameraTrackingChangedListenerImplementor value)
		{
			return value.OnCameraTrackingChangedHandler == null && value.OnCameraTrackingDismissedHandler == null;
		}
	}

}
