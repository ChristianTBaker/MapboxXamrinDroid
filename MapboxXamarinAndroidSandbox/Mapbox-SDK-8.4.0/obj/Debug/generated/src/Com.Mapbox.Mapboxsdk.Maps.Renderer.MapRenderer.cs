using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/MapRenderer", DoNotGenerateAcw=true)]
	public abstract partial class MapRenderer : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Maps.Renderer.IMapRendererScheduler {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/MapRenderer", typeof (MapRenderer));
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

		protected MapRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/constructor[@name='MapRenderer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe MapRenderer (global::Android.Content.Context context, string localIdeographFontFamily)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_localIdeographFontFamily = JNIEnv.NewString (localIdeographFontFamily);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_localIdeographFontFamily);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_localIdeographFontFamily);
			}
		}

		static Delegate cb_nativeReset;
#pragma warning disable 0169
		static Delegate GetNativeResetHandler ()
		{
			if (cb_nativeReset == null)
				cb_nativeReset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NativeReset);
			return cb_nativeReset;
		}

		static void n_NativeReset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NativeReset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='nativeReset' and count(parameter)=0]"
		[Register ("nativeReset", "()V", "GetNativeResetHandler")]
		protected virtual unsafe void NativeReset ()
		{
			const string __id = "nativeReset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 gl = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_gl, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawFrame (gl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='onDrawFrame' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
		[Register ("onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", "GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler")]
		protected virtual unsafe void OnDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 gl)
		{
			const string __id = "onDrawFrame.(Ljavax/microedition/khronos/opengles/GL10;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gl).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			const string __id = "onResume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			const string __id = "onStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			const string __id = "onStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 gl = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_gl, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceChanged (gl, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='onSurfaceChanged' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", "GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler")]
		protected virtual unsafe void OnSurfaceChanged (global::Javax.Microedition.Khronos.Opengles.IGL10 gl, int width, int height)
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
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 gl = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_gl, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Egl.EGLConfig config = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceCreated (gl, config);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='onSurfaceCreated' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLConfig']]"
		[Register ("onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", "GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler")]
		protected virtual unsafe void OnSurfaceCreated (global::Javax.Microedition.Khronos.Opengles.IGL10 gl, global::Javax.Microedition.Khronos.Egl.EGLConfig config)
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

		static Delegate cb_onSurfaceDestroyed;
#pragma warning disable 0169
		static Delegate GetOnSurfaceDestroyedHandler ()
		{
			if (cb_onSurfaceDestroyed == null)
				cb_onSurfaceDestroyed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSurfaceDestroyed);
			return cb_onSurfaceDestroyed;
		}

		static void n_OnSurfaceDestroyed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceDestroyed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='onSurfaceDestroyed' and count(parameter)=0]"
		[Register ("onSurfaceDestroyed", "()V", "GetOnSurfaceDestroyedHandler")]
		protected virtual unsafe void OnSurfaceDestroyed ()
		{
			const string __id = "onSurfaceDestroyed.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setMaximumFps_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumFps_IHandler ()
		{
			if (cb_setMaximumFps_I == null)
				cb_setMaximumFps_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumFps_I);
			return cb_setMaximumFps_I;
		}

		static void n_SetMaximumFps_I (IntPtr jnienv, IntPtr native__this, int maximumFps)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaximumFps (maximumFps);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='setMaximumFps' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaximumFps", "(I)V", "GetSetMaximumFps_IHandler")]
		public virtual unsafe void SetMaximumFps (int maximumFps)
		{
			const string __id = "setMaximumFps.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maximumFps);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnFpsChangedListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnFpsChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnFpsChangedListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnFpsChangedListener_Handler ()
		{
			if (cb_setOnFpsChangedListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnFpsChangedListener_ == null)
				cb_setOnFpsChangedListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnFpsChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnFpsChangedListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnFpsChangedListener_);
			return cb_setOnFpsChangedListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnFpsChangedListener_;
		}

		static void n_SetOnFpsChangedListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnFpsChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnFpsChangedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/class[@name='MapRenderer']/method[@name='setOnFpsChangedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnFpsChangedListener']]"
		[Register ("setOnFpsChangedListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnFpsChangedListener;)V", "GetSetOnFpsChangedListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnFpsChangedListener_Handler")]
		public virtual unsafe void SetOnFpsChangedListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener listener)
		{
			const string __id = "setOnFpsChangedListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnFpsChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.FpsChangedEventArgs> FpsChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor>(
						ref weak_implementor_SetOnFpsChangedListener,
						__CreateIOnFpsChangedListenerImplementor,
						SetOnFpsChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor>(
						ref weak_implementor_SetOnFpsChangedListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor.__IsEmpty,
						__v => SetOnFpsChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnFpsChangedListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor __CreateIOnFpsChangedListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor (this);
		}
#endregion
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
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QueueEvent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/interface[@name='MapRendererScheduler']/method[@name='queueEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("queueEvent", "(Ljava/lang/Runnable;)V", "GetQueueEvent_Ljava_lang_Runnable_Handler")]
		public abstract void QueueEvent (global::Java.Lang.IRunnable p0);

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
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestRender ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/interface[@name='MapRendererScheduler']/method[@name='requestRender' and count(parameter)=0]"
		[Register ("requestRender", "()V", "GetRequestRenderHandler")]
		public abstract void RequestRender ();

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/MapRenderer", DoNotGenerateAcw=true)]
	internal partial class MapRendererInvoker : MapRenderer {

		public MapRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/MapRenderer", typeof (MapRendererInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/interface[@name='MapRendererScheduler']/method[@name='queueEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("queueEvent", "(Ljava/lang/Runnable;)V", "GetQueueEvent_Ljava_lang_Runnable_Handler")]
		public override unsafe void QueueEvent (global::Java.Lang.IRunnable p0)
		{
			const string __id = "queueEvent.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer']/interface[@name='MapRendererScheduler']/method[@name='requestRender' and count(parameter)=0]"
		[Register ("requestRender", "()V", "GetRequestRenderHandler")]
		public override unsafe void RequestRender ()
		{
			const string __id = "requestRender.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
