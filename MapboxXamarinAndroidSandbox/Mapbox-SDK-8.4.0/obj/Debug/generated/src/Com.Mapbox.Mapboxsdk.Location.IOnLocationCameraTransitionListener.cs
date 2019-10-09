using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnLocationCameraTransitionListener']"
	[Register ("com/mapbox/mapboxsdk/location/OnLocationCameraTransitionListener", "", "Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListenerInvoker")]
	public partial interface IOnLocationCameraTransitionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnLocationCameraTransitionListener']/method[@name='onLocationCameraTransitionCanceled' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onLocationCameraTransitionCanceled", "(I)V", "GetOnLocationCameraTransitionCanceled_IHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnLocationCameraTransitionCanceled ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnLocationCameraTransitionListener']/method[@name='onLocationCameraTransitionFinished' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onLocationCameraTransitionFinished", "(I)V", "GetOnLocationCameraTransitionFinished_IHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnLocationCameraTransitionFinished ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/OnLocationCameraTransitionListener", DoNotGenerateAcw=true)]
	internal class IOnLocationCameraTransitionListenerInvoker : global::Java.Lang.Object, IOnLocationCameraTransitionListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/location/OnLocationCameraTransitionListener", typeof (IOnLocationCameraTransitionListenerInvoker));

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

		public static IOnLocationCameraTransitionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnLocationCameraTransitionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.location.OnLocationCameraTransitionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnLocationCameraTransitionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLocationCameraTransitionCanceled_I;
#pragma warning disable 0169
		static Delegate GetOnLocationCameraTransitionCanceled_IHandler ()
		{
			if (cb_onLocationCameraTransitionCanceled_I == null)
				cb_onLocationCameraTransitionCanceled_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnLocationCameraTransitionCanceled_I);
			return cb_onLocationCameraTransitionCanceled_I;
		}

		static void n_OnLocationCameraTransitionCanceled_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationCameraTransitionCanceled (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocationCameraTransitionCanceled_I;
		public unsafe void OnLocationCameraTransitionCanceled ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int p0)
		{
			if (id_onLocationCameraTransitionCanceled_I == IntPtr.Zero)
				id_onLocationCameraTransitionCanceled_I = JNIEnv.GetMethodID (class_ref, "onLocationCameraTransitionCanceled", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationCameraTransitionCanceled_I, __args);
		}

		static Delegate cb_onLocationCameraTransitionFinished_I;
#pragma warning disable 0169
		static Delegate GetOnLocationCameraTransitionFinished_IHandler ()
		{
			if (cb_onLocationCameraTransitionFinished_I == null)
				cb_onLocationCameraTransitionFinished_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnLocationCameraTransitionFinished_I);
			return cb_onLocationCameraTransitionFinished_I;
		}

		static void n_OnLocationCameraTransitionFinished_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationCameraTransitionFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocationCameraTransitionFinished_I;
		public unsafe void OnLocationCameraTransitionFinished ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int p0)
		{
			if (id_onLocationCameraTransitionFinished_I == IntPtr.Zero)
				id_onLocationCameraTransitionFinished_I = JNIEnv.GetMethodID (class_ref, "onLocationCameraTransitionFinished", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationCameraTransitionFinished_I, __args);
		}

	}

	// event args for com.mapbox.mapboxsdk.location.OnLocationCameraTransitionListener.onLocationCameraTransitionCanceled
	public partial class LocationCameraTransitionCanceledEventArgs : global::System.EventArgs {

		public LocationCameraTransitionCanceledEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	// event args for com.mapbox.mapboxsdk.location.OnLocationCameraTransitionListener.onLocationCameraTransitionFinished
	public partial class LocationCameraTransitionFinishedEventArgs : global::System.EventArgs {

		public LocationCameraTransitionFinishedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/location/OnLocationCameraTransitionListenerImplementor")]
	internal sealed partial class IOnLocationCameraTransitionListenerImplementor : global::Java.Lang.Object, IOnLocationCameraTransitionListener {

		object sender;

		public IOnLocationCameraTransitionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/location/OnLocationCameraTransitionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LocationCameraTransitionCanceledEventArgs> OnLocationCameraTransitionCanceledHandler;
#pragma warning restore 0649

		public void OnLocationCameraTransitionCanceled ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int p0)
		{
			var __h = OnLocationCameraTransitionCanceledHandler;
			if (__h != null)
				__h (sender, new LocationCameraTransitionCanceledEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<LocationCameraTransitionFinishedEventArgs> OnLocationCameraTransitionFinishedHandler;
#pragma warning restore 0649

		public void OnLocationCameraTransitionFinished ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int p0)
		{
			var __h = OnLocationCameraTransitionFinishedHandler;
			if (__h != null)
				__h (sender, new LocationCameraTransitionFinishedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnLocationCameraTransitionListenerImplementor value)
		{
			return value.OnLocationCameraTransitionCanceledHandler == null && value.OnLocationCameraTransitionFinishedHandler == null;
		}
	}

}
