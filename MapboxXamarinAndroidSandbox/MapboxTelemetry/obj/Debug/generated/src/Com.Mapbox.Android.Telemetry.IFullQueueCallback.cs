using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='FullQueueCallback']"
	[Register ("com/mapbox/android/telemetry/FullQueueCallback", "", "Com.Mapbox.Android.Telemetry.IFullQueueCallbackInvoker")]
	public partial interface IFullQueueCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='FullQueueCallback']/method[@name='onFullQueue' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.android.telemetry.Event&gt;']]"
		[Register ("onFullQueue", "(Ljava/util/List;)V", "GetOnFullQueue_Ljava_util_List_Handler:Com.Mapbox.Android.Telemetry.IFullQueueCallbackInvoker, MapboxTelemetry")]
		void OnFullQueue (global::System.Collections.Generic.IList<global::Com.Mapbox.Android.Telemetry.Event> fullQueue);

	}

	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/FullQueueCallback", DoNotGenerateAcw=true)]
	internal class IFullQueueCallbackInvoker : global::Java.Lang.Object, IFullQueueCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/telemetry/FullQueueCallback", typeof (IFullQueueCallbackInvoker));

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

		public static IFullQueueCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFullQueueCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.telemetry.FullQueueCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFullQueueCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFullQueue_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnFullQueue_Ljava_util_List_Handler ()
		{
			if (cb_onFullQueue_Ljava_util_List_ == null)
				cb_onFullQueue_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFullQueue_Ljava_util_List_);
			return cb_onFullQueue_Ljava_util_List_;
		}

		static void n_OnFullQueue_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fullQueue)
		{
			global::Com.Mapbox.Android.Telemetry.IFullQueueCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.IFullQueueCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fullQueue = global::Android.Runtime.JavaList<global::Com.Mapbox.Android.Telemetry.Event>.FromJniHandle (native_fullQueue, JniHandleOwnership.DoNotTransfer);
			__this.OnFullQueue (fullQueue);
		}
#pragma warning restore 0169

		IntPtr id_onFullQueue_Ljava_util_List_;
		public unsafe void OnFullQueue (global::System.Collections.Generic.IList<global::Com.Mapbox.Android.Telemetry.Event> fullQueue)
		{
			if (id_onFullQueue_Ljava_util_List_ == IntPtr.Zero)
				id_onFullQueue_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onFullQueue", "(Ljava/util/List;)V");
			IntPtr native_fullQueue = global::Android.Runtime.JavaList<global::Com.Mapbox.Android.Telemetry.Event>.ToLocalJniHandle (fullQueue);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_fullQueue);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFullQueue_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_fullQueue);
		}

	}

}
