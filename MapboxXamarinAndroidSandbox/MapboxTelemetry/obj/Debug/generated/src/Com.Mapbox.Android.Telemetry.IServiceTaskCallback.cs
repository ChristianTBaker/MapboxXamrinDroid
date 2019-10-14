using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='ServiceTaskCallback']"
	[Register ("com/mapbox/android/telemetry/ServiceTaskCallback", "", "Com.Mapbox.Android.Telemetry.IServiceTaskCallbackInvoker")]
	public partial interface IServiceTaskCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='ServiceTaskCallback']/method[@name='onTaskRemoved' and count(parameter)=0]"
		[Register ("onTaskRemoved", "()V", "GetOnTaskRemovedHandler:Com.Mapbox.Android.Telemetry.IServiceTaskCallbackInvoker, MapboxTelemetry")]
		void OnTaskRemoved ();

	}

	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/ServiceTaskCallback", DoNotGenerateAcw=true)]
	internal class IServiceTaskCallbackInvoker : global::Java.Lang.Object, IServiceTaskCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/telemetry/ServiceTaskCallback", typeof (IServiceTaskCallbackInvoker));

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

		public static IServiceTaskCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IServiceTaskCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.telemetry.ServiceTaskCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IServiceTaskCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Mapbox.Android.Telemetry.IServiceTaskCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.IServiceTaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskRemoved ();
		}
#pragma warning restore 0169

		IntPtr id_onTaskRemoved;
		public unsafe void OnTaskRemoved ()
		{
			if (id_onTaskRemoved == IntPtr.Zero)
				id_onTaskRemoved = JNIEnv.GetMethodID (class_ref, "onTaskRemoved", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskRemoved);
		}

	}

}
