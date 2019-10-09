using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps.Renderer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/interface[@name='MapRendererScheduler']"
	[Register ("com/mapbox/mapboxsdk/maps/renderer/MapRendererScheduler", "", "Com.Mapbox.Mapboxsdk.Maps.Renderer.IMapRendererSchedulerInvoker")]
	public partial interface IMapRendererScheduler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/interface[@name='MapRendererScheduler']/method[@name='queueEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("queueEvent", "(Ljava/lang/Runnable;)V", "GetQueueEvent_Ljava_lang_Runnable_Handler:Com.Mapbox.Mapboxsdk.Maps.Renderer.IMapRendererSchedulerInvoker, Mapbox-SDK-8.4.0")]
		void QueueEvent (global::Java.Lang.IRunnable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/interface[@name='MapRendererScheduler']/method[@name='requestRender' and count(parameter)=0]"
		[Register ("requestRender", "()V", "GetRequestRenderHandler:Com.Mapbox.Mapboxsdk.Maps.Renderer.IMapRendererSchedulerInvoker, Mapbox-SDK-8.4.0")]
		void RequestRender ();

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/MapRendererScheduler", DoNotGenerateAcw=true)]
	internal class IMapRendererSchedulerInvoker : global::Java.Lang.Object, IMapRendererScheduler {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/MapRendererScheduler", typeof (IMapRendererSchedulerInvoker));

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

		public static IMapRendererScheduler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapRendererScheduler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.renderer.MapRendererScheduler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapRendererSchedulerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_queueEvent_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetQueueEvent_Ljava_lang_Runnable_Handler ()
		{
			if (cb_queueEvent_Ljava_lang_Runnable_ == null)
				cb_queueEvent_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_QueueEvent_Ljava_lang_Runnable_);
			return cb_queueEvent_Ljava_lang_Runnable_;
		}

		static void n_QueueEvent_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.IMapRendererScheduler __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.IMapRendererScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QueueEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_queueEvent_Ljava_lang_Runnable_;
		public unsafe void QueueEvent (global::Java.Lang.IRunnable p0)
		{
			if (id_queueEvent_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_queueEvent_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "queueEvent", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queueEvent_Ljava_lang_Runnable_, __args);
		}

		static Delegate cb_requestRender;
#pragma warning disable 0169
		static Delegate GetRequestRenderHandler ()
		{
			if (cb_requestRender == null)
				cb_requestRender = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestRender);
			return cb_requestRender;
		}

		static void n_RequestRender (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.IMapRendererScheduler __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.IMapRendererScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestRender ();
		}
#pragma warning restore 0169

		IntPtr id_requestRender;
		public unsafe void RequestRender ()
		{
			if (id_requestRender == IntPtr.Zero)
				id_requestRender = JNIEnv.GetMethodID (class_ref, "requestRender", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestRender);
		}

	}

}
