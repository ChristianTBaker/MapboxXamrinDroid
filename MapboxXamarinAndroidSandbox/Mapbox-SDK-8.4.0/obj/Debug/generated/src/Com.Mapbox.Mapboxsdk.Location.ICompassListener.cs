using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='CompassListener']"
	[Register ("com/mapbox/mapboxsdk/location/CompassListener", "", "Com.Mapbox.Mapboxsdk.Location.ICompassListenerInvoker")]
	public partial interface ICompassListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='CompassListener']/method[@name='onCompassAccuracyChange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCompassAccuracyChange", "(I)V", "GetOnCompassAccuracyChange_IHandler:Com.Mapbox.Mapboxsdk.Location.ICompassListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnCompassAccuracyChange (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='CompassListener']/method[@name='onCompassChanged' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onCompassChanged", "(F)V", "GetOnCompassChanged_FHandler:Com.Mapbox.Mapboxsdk.Location.ICompassListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnCompassChanged (float p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/CompassListener", DoNotGenerateAcw=true)]
	internal class ICompassListenerInvoker : global::Java.Lang.Object, ICompassListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/location/CompassListener", typeof (ICompassListenerInvoker));

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

		public static ICompassListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICompassListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.location.CompassListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICompassListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCompassAccuracyChange_I;
#pragma warning disable 0169
		static Delegate GetOnCompassAccuracyChange_IHandler ()
		{
			if (cb_onCompassAccuracyChange_I == null)
				cb_onCompassAccuracyChange_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnCompassAccuracyChange_I);
			return cb_onCompassAccuracyChange_I;
		}

		static void n_OnCompassAccuracyChange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Mapboxsdk.Location.ICompassListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.ICompassListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompassAccuracyChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCompassAccuracyChange_I;
		public unsafe void OnCompassAccuracyChange (int p0)
		{
			if (id_onCompassAccuracyChange_I == IntPtr.Zero)
				id_onCompassAccuracyChange_I = JNIEnv.GetMethodID (class_ref, "onCompassAccuracyChange", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompassAccuracyChange_I, __args);
		}

		static Delegate cb_onCompassChanged_F;
#pragma warning disable 0169
		static Delegate GetOnCompassChanged_FHandler ()
		{
			if (cb_onCompassChanged_F == null)
				cb_onCompassChanged_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_OnCompassChanged_F);
			return cb_onCompassChanged_F;
		}

		static void n_OnCompassChanged_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Mapbox.Mapboxsdk.Location.ICompassListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.ICompassListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompassChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCompassChanged_F;
		public unsafe void OnCompassChanged (float p0)
		{
			if (id_onCompassChanged_F == IntPtr.Zero)
				id_onCompassChanged_F = JNIEnv.GetMethodID (class_ref, "onCompassChanged", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompassChanged_F, __args);
		}

	}

	// event args for com.mapbox.mapboxsdk.location.CompassListener.onCompassAccuracyChange
	public partial class CompassAccuracyChangeEventArgs : global::System.EventArgs {

		public CompassAccuracyChangeEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	// event args for com.mapbox.mapboxsdk.location.CompassListener.onCompassChanged
	public partial class CompassChangedEventArgs : global::System.EventArgs {

		public CompassChangedEventArgs (float p0)
		{
			this.p0 = p0;
		}

		float p0;
		public float P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/location/CompassListenerImplementor")]
	internal sealed partial class ICompassListenerImplementor : global::Java.Lang.Object, ICompassListener {

		object sender;

		public ICompassListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/location/CompassListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CompassAccuracyChangeEventArgs> OnCompassAccuracyChangeHandler;
#pragma warning restore 0649

		public void OnCompassAccuracyChange (int p0)
		{
			var __h = OnCompassAccuracyChangeHandler;
			if (__h != null)
				__h (sender, new CompassAccuracyChangeEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<CompassChangedEventArgs> OnCompassChangedHandler;
#pragma warning restore 0649

		public void OnCompassChanged (float p0)
		{
			var __h = OnCompassChangedHandler;
			if (__h != null)
				__h (sender, new CompassChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (ICompassListenerImplementor value)
		{
			return value.OnCompassAccuracyChangeHandler == null && value.OnCompassChangedHandler == null;
		}
	}

}
