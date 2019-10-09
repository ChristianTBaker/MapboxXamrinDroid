using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps.Renderer.Textureview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.textureview']/class[@name='TextureViewMapRenderer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/textureview/TextureViewMapRenderer", DoNotGenerateAcw=true)]
	public partial class TextureViewMapRenderer : global::Com.Mapbox.Mapboxsdk.Maps.Renderer.MapRenderer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/textureview/TextureViewMapRenderer", typeof (TextureViewMapRenderer));
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

		protected TextureViewMapRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.textureview']/class[@name='TextureViewMapRenderer']/constructor[@name='TextureViewMapRenderer' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.TextureView'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/view/TextureView;Ljava/lang/String;Z)V", "")]
		public unsafe TextureViewMapRenderer (global::Android.Content.Context context, global::Android.Views.TextureView textureView, string localIdeographFontFamily, bool translucentSurface)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/view/TextureView;Ljava/lang/String;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_localIdeographFontFamily = JNIEnv.NewString (localIdeographFontFamily);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((textureView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textureView).Handle);
				__args [2] = new JniArgumentValue (native_localIdeographFontFamily);
				__args [3] = new JniArgumentValue (translucentSurface);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_localIdeographFontFamily);
			}
		}

		static Delegate cb_isTranslucentSurface;
#pragma warning disable 0169
		static Delegate GetIsTranslucentSurfaceHandler ()
		{
			if (cb_isTranslucentSurface == null)
				cb_isTranslucentSurface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTranslucentSurface);
			return cb_isTranslucentSurface;
		}

		static bool n_IsTranslucentSurface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Textureview.TextureViewMapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Textureview.TextureViewMapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTranslucentSurface;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTranslucentSurface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.textureview']/class[@name='TextureViewMapRenderer']/method[@name='isTranslucentSurface' and count(parameter)=0]"
			[Register ("isTranslucentSurface", "()Z", "GetIsTranslucentSurfaceHandler")]
			get {
				const string __id = "isTranslucentSurface.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Textureview.TextureViewMapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Textureview.TextureViewMapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			__this.QueueEvent (runnable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.textureview']/class[@name='TextureViewMapRenderer']/method[@name='queueEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
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
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Textureview.TextureViewMapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Textureview.TextureViewMapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestRender ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.textureview']/class[@name='TextureViewMapRenderer']/method[@name='requestRender' and count(parameter)=0]"
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
