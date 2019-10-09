using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='MapboxGLSurfaceView']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView", DoNotGenerateAcw=true)]
	public partial class MapboxGLSurfaceView : global::Android.Opengl.GLSurfaceView {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/interface[@name='MapboxGLSurfaceView.OnGLSurfaceViewDetachedListener']"
		[Register ("com/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView$OnGLSurfaceViewDetachedListener", "", "Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView/IOnGLSurfaceViewDetachedListenerInvoker")]
		public partial interface IOnGLSurfaceViewDetachedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/interface[@name='MapboxGLSurfaceView.OnGLSurfaceViewDetachedListener']/method[@name='onGLSurfaceViewDetached' and count(parameter)=0]"
			[Register ("onGLSurfaceViewDetached", "()V", "GetOnGLSurfaceViewDetachedHandler:Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView/IOnGLSurfaceViewDetachedListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnGLSurfaceViewDetached ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView$OnGLSurfaceViewDetachedListener", DoNotGenerateAcw=true)]
		internal class IOnGLSurfaceViewDetachedListenerInvoker : global::Java.Lang.Object, IOnGLSurfaceViewDetachedListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView$OnGLSurfaceViewDetachedListener", typeof (IOnGLSurfaceViewDetachedListenerInvoker));

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

			public static IOnGLSurfaceViewDetachedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnGLSurfaceViewDetachedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.renderer.glsurfaceview.MapboxGLSurfaceView.OnGLSurfaceViewDetachedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnGLSurfaceViewDetachedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onGLSurfaceViewDetached;
#pragma warning disable 0169
			static Delegate GetOnGLSurfaceViewDetachedHandler ()
			{
				if (cb_onGLSurfaceViewDetached == null)
					cb_onGLSurfaceViewDetached = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGLSurfaceViewDetached);
				return cb_onGLSurfaceViewDetached;
			}

			static void n_OnGLSurfaceViewDetached (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnGLSurfaceViewDetached ();
			}
#pragma warning restore 0169

			IntPtr id_onGLSurfaceViewDetached;
			public unsafe void OnGLSurfaceViewDetached ()
			{
				if (id_onGLSurfaceViewDetached == IntPtr.Zero)
					id_onGLSurfaceViewDetached = JNIEnv.GetMethodID (class_ref, "onGLSurfaceViewDetached", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGLSurfaceViewDetached);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView_OnGLSurfaceViewDetachedListenerImplementor")]
		internal sealed partial class IOnGLSurfaceViewDetachedListenerImplementor : global::Java.Lang.Object, IOnGLSurfaceViewDetachedListener {

			object sender;

			public IOnGLSurfaceViewDetachedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView_OnGLSurfaceViewDetachedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnGLSurfaceViewDetached ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnGLSurfaceViewDetachedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView", typeof (MapboxGLSurfaceView));
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

		protected MapboxGLSurfaceView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='MapboxGLSurfaceView']/constructor[@name='MapboxGLSurfaceView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MapboxGLSurfaceView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='MapboxGLSurfaceView']/constructor[@name='MapboxGLSurfaceView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MapboxGLSurfaceView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDetachedListener_Lcom_mapbox_mapboxsdk_maps_renderer_glsurfaceview_MapboxGLSurfaceView_OnGLSurfaceViewDetachedListener_;
#pragma warning disable 0169
		static Delegate GetSetDetachedListener_Lcom_mapbox_mapboxsdk_maps_renderer_glsurfaceview_MapboxGLSurfaceView_OnGLSurfaceViewDetachedListener_Handler ()
		{
			if (cb_setDetachedListener_Lcom_mapbox_mapboxsdk_maps_renderer_glsurfaceview_MapboxGLSurfaceView_OnGLSurfaceViewDetachedListener_ == null)
				cb_setDetachedListener_Lcom_mapbox_mapboxsdk_maps_renderer_glsurfaceview_MapboxGLSurfaceView_OnGLSurfaceViewDetachedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDetachedListener_Lcom_mapbox_mapboxsdk_maps_renderer_glsurfaceview_MapboxGLSurfaceView_OnGLSurfaceViewDetachedListener_);
			return cb_setDetachedListener_Lcom_mapbox_mapboxsdk_maps_renderer_glsurfaceview_MapboxGLSurfaceView_OnGLSurfaceViewDetachedListener_;
		}

		static void n_SetDetachedListener_Lcom_mapbox_mapboxsdk_maps_renderer_glsurfaceview_MapboxGLSurfaceView_OnGLSurfaceViewDetachedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_detachedListener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListener detachedListener = (global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListener> (native_detachedListener, JniHandleOwnership.DoNotTransfer);
			__this.SetDetachedListener (detachedListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview']/class[@name='MapboxGLSurfaceView']/method[@name='setDetachedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.renderer.glsurfaceview.MapboxGLSurfaceView.OnGLSurfaceViewDetachedListener']]"
		[Register ("setDetachedListener", "(Lcom/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView$OnGLSurfaceViewDetachedListener;)V", "GetSetDetachedListener_Lcom_mapbox_mapboxsdk_maps_renderer_glsurfaceview_MapboxGLSurfaceView_OnGLSurfaceViewDetachedListener_Handler")]
		public virtual unsafe void SetDetachedListener (global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListener detachedListener)
		{
			const string __id = "setDetachedListener.(Lcom/mapbox/mapboxsdk/maps/renderer/glsurfaceview/MapboxGLSurfaceView$OnGLSurfaceViewDetachedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((detachedListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detachedListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListener"
		public event EventHandler Detached {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListener, global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListenerImplementor>(
						ref weak_implementor_SetDetachedListener,
						__CreateIOnGLSurfaceViewDetachedListenerImplementor,
						SetDetachedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListener, global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListenerImplementor>(
						ref weak_implementor_SetDetachedListener,
						global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListenerImplementor.__IsEmpty,
						__v => SetDetachedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetDetachedListener;

		global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListenerImplementor __CreateIOnGLSurfaceViewDetachedListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView.IOnGLSurfaceViewDetachedListenerImplementor (this);
		}
#endregion
	}
}
