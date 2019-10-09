using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnRenderModeChangedListener']"
	[Register ("com/mapbox/mapboxsdk/location/OnRenderModeChangedListener", "", "Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerInvoker")]
	public partial interface IOnRenderModeChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnRenderModeChangedListener']/method[@name='onRenderModeChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onRenderModeChanged", "(I)V", "GetOnRenderModeChanged_IHandler:Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnRenderModeChanged ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.RenderMode", Fields = new string [] {"Compass", "Gps", "Normal"})]int p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/OnRenderModeChangedListener", DoNotGenerateAcw=true)]
	internal class IOnRenderModeChangedListenerInvoker : global::Java.Lang.Object, IOnRenderModeChangedListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/location/OnRenderModeChangedListener", typeof (IOnRenderModeChangedListenerInvoker));

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

		public static IOnRenderModeChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnRenderModeChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.location.OnRenderModeChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnRenderModeChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRenderModeChanged_I;
#pragma warning disable 0169
		static Delegate GetOnRenderModeChanged_IHandler ()
		{
			if (cb_onRenderModeChanged_I == null)
				cb_onRenderModeChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnRenderModeChanged_I);
			return cb_onRenderModeChanged_I;
		}

		static void n_OnRenderModeChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRenderModeChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRenderModeChanged_I;
		public unsafe void OnRenderModeChanged ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.RenderMode", Fields = new string [] {"Compass", "Gps", "Normal"})]int p0)
		{
			if (id_onRenderModeChanged_I == IntPtr.Zero)
				id_onRenderModeChanged_I = JNIEnv.GetMethodID (class_ref, "onRenderModeChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRenderModeChanged_I, __args);
		}

	}

	// event args for com.mapbox.mapboxsdk.location.OnRenderModeChangedListener.onRenderModeChanged
	public partial class RenderModeChangedEventArgs : global::System.EventArgs {

		public RenderModeChangedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/location/OnRenderModeChangedListenerImplementor")]
	internal sealed partial class IOnRenderModeChangedListenerImplementor : global::Java.Lang.Object, IOnRenderModeChangedListener {

		object sender;

		public IOnRenderModeChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/location/OnRenderModeChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<RenderModeChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnRenderModeChanged ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.RenderMode", Fields = new string [] {"Compass", "Gps", "Normal"})]int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new RenderModeChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnRenderModeChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
