using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Plugins.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/interface[@name='OnAnnotationLongClickListener']"
	[Register ("com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationLongClickListener", "", "Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationLongClickListenerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mapbox.mapboxsdk.plugins.annotation.Annotation"})]
	public partial interface IOnAnnotationLongClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/interface[@name='OnAnnotationLongClickListener']/method[@name='onAnnotationLongClick' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onAnnotationLongClick", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V", "GetOnAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler:Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationLongClickListenerInvoker, Mapbox-Android-Annotation-Plugin-v8")]
		void OnAnnotationLongClick (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationLongClickListener", DoNotGenerateAcw=true)]
	internal class IOnAnnotationLongClickListenerInvoker : global::Java.Lang.Object, IOnAnnotationLongClickListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationLongClickListener", typeof (IOnAnnotationLongClickListenerInvoker));

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

		public static IOnAnnotationLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnAnnotationLongClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationLongClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnAnnotationLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
#pragma warning disable 0169
		static Delegate GetOnAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler ()
		{
			if (cb_onAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == null)
				cb_onAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_);
			return cb_onAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		}

		static void n_OnAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAnnotationLongClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		public unsafe void OnAnnotationLongClick (global::Java.Lang.Object p0)
		{
			if (id_onAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == IntPtr.Zero)
				id_onAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "onAnnotationLongClick", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationLongClickListener.onAnnotationLongClick
	public partial class AnnotationLongClickEventArgs : global::System.EventArgs {

		public AnnotationLongClickEventArgs (global::Java.Lang.Object p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationLongClickListenerImplementor")]
	internal sealed partial class IOnAnnotationLongClickListenerImplementor : global::Java.Lang.Object, IOnAnnotationLongClickListener {

		object sender;

		public IOnAnnotationLongClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationLongClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AnnotationLongClickEventArgs> Handler;
#pragma warning restore 0649

		public void OnAnnotationLongClick (global::Java.Lang.Object p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AnnotationLongClickEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnAnnotationLongClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
