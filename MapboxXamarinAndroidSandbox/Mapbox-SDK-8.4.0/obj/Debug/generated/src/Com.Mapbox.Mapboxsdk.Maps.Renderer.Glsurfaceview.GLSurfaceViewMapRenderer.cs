using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='GLSurfaceViewMapRenderer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/glsurfaceview/GLSurfaceViewMapRenderer", DoNotGenerateAcw=true)]
	public partial class GLSurfaceViewMapRenderer : global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer, global::Android.Opengl.GLSurfaceView.IRenderer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/glsurfaceview/GLSurfaceViewMapRenderer", typeof (GLSurfaceViewMapRenderer));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected GLSurfaceViewMapRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='GLSurfaceViewMapRenderer']/constructor[@name='GLSurfaceViewMapRenderer' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview.MapboxGLSurfaceView'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView;Ljava/lang/String;)V", "")]
		public unsafe GLSurfaceViewMapRenderer (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView glSurfaceView, string localIdeographFontFamily)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_localIdeographFontFamily = JNIEnv.NewString (localIdeographFontFamily);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((glSurfaceView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) glSurfaceView).Handle);
				__args [2] = new JniArgumentValue (native_localIdeographFontFamily);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_localIdeographFontFamily);
			}
		}

		static Delegate cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
#pragma warning disable 0169
		static Delegate GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler ()
		{
			if (cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == null)
				cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_);
			return cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		}

		static void n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gl)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 gl = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_gl, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawFrame (gl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='GLSurfaceViewMapRenderer']/method[@name='onDrawFrame' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
		[Register ("onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", "GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler")]
		public virtual unsafe void OnDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 gl)
		{
			const string __id = "onDrawFrame.(Ljavax/microedition/khronos/opengles/GL10;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gl).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler ()
		{
			if (cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == null)
				cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II);
			return cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		}

		static void n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II (IntPtr jnienv, IntPtr native__this, IntPtr native_gl, int width, int height)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 gl = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_gl, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceChanged (gl, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='GLSurfaceViewMapRenderer']/method[@name='onSurfaceChanged' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", "GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler")]
		public virtual unsafe void OnSurfaceChanged (global::Javax.Microedition.Khronos.Opengles.IGL10 gl, int width, int height)
		{
			const string __id = "onSurfaceChanged.(Ljavax/microedition/khronos/opengles/GL10;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((gl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gl).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler ()
		{
			if (cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == null)
				cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_);
			return cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		}

		static void n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gl, IntPtr native_config)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 gl = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_gl, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Egl.EGLConfig config = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceCreated (gl, config);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='GLSurfaceViewMapRenderer']/method[@name='onSurfaceCreated' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLConfig']]"
		[Register ("onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", "GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler")]
		public virtual unsafe void OnSurfaceCreated (global::Javax.Microedition.Khronos.Opengles.IGL10 gl, global::Javax.Microedition.Khronos.Egl.EGLConfig config)
		{
			const string __id = "onSurfaceCreated.(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((gl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gl).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_queueEvent_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetQueueEvent_Ljava_lang_Runnable_Handler ()
		{
			if (cb_queueEvent_Ljava_lang_Runnable_ == null)
				cb_queueEvent_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_QueueEvent_Ljava_lang_Runnable_);
			return cb_queueEvent_Ljava_lang_Runnable_;
		}

		static void n_QueueEvent_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			__this.QueueEvent (runnable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='GLSurfaceViewMapRenderer']/method[@name='queueEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("queueEvent", "(Ljava/lang/Runnable;)V", "GetQueueEvent_Ljava_lang_Runnable_Handler")]
		public override unsafe void QueueEvent (global::Java.Lang.IRunnable runnable)
		{
			const string __id = "queueEvent.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runnable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.GLSurfaceViewMapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestRender ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='GLSurfaceViewMapRenderer']/method[@name='requestRender' and count(parameter)=0]"
		[Register ("requestRender", "()V", "GetRequestRenderHandler")]
		public override unsafe void RequestRender ()
		{
			const string __id = "requestRender.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
