using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='VisionBuildEvent']"
	[Register ("com/mapbox/android/telemetry/VisionBuildEvent", "", "Com.Mapbox.Android.Telemetry.IVisionBuildEventInvoker")]
	public partial interface IVisionBuildEvent : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='VisionBuildEvent']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/mapbox/android/telemetry/Event;", "GetBuildHandler:Com.Mapbox.Android.Telemetry.IVisionBuildEventInvoker, MapboxTelemetry")]
		global::Com.Mapbox.Android.Telemetry.Event Build ();

	}

	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/VisionBuildEvent", DoNotGenerateAcw=true)]
	internal class IVisionBuildEventInvoker : global::Java.Lang.Object, IVisionBuildEvent {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/telemetry/VisionBuildEvent", typeof (IVisionBuildEventInvoker));

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

		public static IVisionBuildEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVisionBuildEvent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.telemetry.VisionBuildEvent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVisionBuildEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.IVisionBuildEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.IVisionBuildEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		IntPtr id_build;
		public unsafe global::Com.Mapbox.Android.Telemetry.Event Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mapbox/android/telemetry/Event;");
			return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
		}

	}

}
