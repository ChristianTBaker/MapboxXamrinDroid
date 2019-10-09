using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Plugins.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/interface[@name='OnAnnotationDragListener']"
	[Register ("com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationDragListener", "", "Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListenerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mapbox.mapboxsdk.plugins.annotation.Annotation"})]
	public partial interface IOnAnnotationDragListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/interface[@name='OnAnnotationDragListener']/method[@name='onAnnotationDrag' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onAnnotationDrag", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V", "GetOnAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler:Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListenerInvoker, Mapbox-Android-Plugin -Annotation-v8-0.7.0")]
		void OnAnnotationDrag (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/interface[@name='OnAnnotationDragListener']/method[@name='onAnnotationDragFinished' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onAnnotationDragFinished", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V", "GetOnAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler:Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListenerInvoker, Mapbox-Android-Plugin -Annotation-v8-0.7.0")]
		void OnAnnotationDragFinished (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/interface[@name='OnAnnotationDragListener']/method[@name='onAnnotationDragStarted' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onAnnotationDragStarted", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V", "GetOnAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler:Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListenerInvoker, Mapbox-Android-Plugin -Annotation-v8-0.7.0")]
		void OnAnnotationDragStarted (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationDragListener", DoNotGenerateAcw=true)]
	internal class IOnAnnotationDragListenerInvoker : global::Java.Lang.Object, IOnAnnotationDragListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationDragListener", typeof (IOnAnnotationDragListenerInvoker));

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

		public static IOnAnnotationDragListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnAnnotationDragListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationDragListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnAnnotationDragListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
#pragma warning disable 0169
		static Delegate GetOnAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler ()
		{
			if (cb_onAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == null)
				cb_onAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_);
			return cb_onAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		}

		static void n_OnAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAnnotationDrag (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		public unsafe void OnAnnotationDrag (global::Java.Lang.Object p0)
		{
			if (id_onAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == IntPtr.Zero)
				id_onAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "onAnnotationDrag", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
#pragma warning disable 0169
		static Delegate GetOnAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler ()
		{
			if (cb_onAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == null)
				cb_onAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_);
			return cb_onAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		}

		static void n_OnAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAnnotationDragFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		public unsafe void OnAnnotationDragFinished (global::Java.Lang.Object p0)
		{
			if (id_onAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == IntPtr.Zero)
				id_onAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "onAnnotationDragFinished", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
#pragma warning disable 0169
		static Delegate GetOnAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler ()
		{
			if (cb_onAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == null)
				cb_onAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_);
			return cb_onAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		}

		static void n_OnAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAnnotationDragStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		public unsafe void OnAnnotationDragStarted (global::Java.Lang.Object p0)
		{
			if (id_onAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == IntPtr.Zero)
				id_onAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNIEnv.GetMethodID (class_ref, "onAnnotationDragStarted", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationDragListener.onAnnotationDrag
	public partial class AnnotationDragEventArgs : global::System.EventArgs {

		public AnnotationDragEventArgs (global::Java.Lang.Object p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}
	}

	// event args for com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationDragListener.onAnnotationDragFinished
	public partial class AnnotationDragFinishedEventArgs : global::System.EventArgs {

		public AnnotationDragFinishedEventArgs (global::Java.Lang.Object p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}
	}

	// event args for com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationDragListener.onAnnotationDragStarted
	public partial class AnnotationDragStartedEventArgs : global::System.EventArgs {

		public AnnotationDragStartedEventArgs (global::Java.Lang.Object p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationDragListenerImplementor")]
	internal sealed partial class IOnAnnotationDragListenerImplementor : global::Java.Lang.Object, IOnAnnotationDragListener {

		object sender;

		public IOnAnnotationDragListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/plugins/annotation/OnAnnotationDragListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AnnotationDragEventArgs> OnAnnotationDragHandler;
#pragma warning restore 0649

		public void OnAnnotationDrag (global::Java.Lang.Object p0)
		{
			var __h = OnAnnotationDragHandler;
			if (__h != null)
				__h (sender, new AnnotationDragEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<AnnotationDragFinishedEventArgs> OnAnnotationDragFinishedHandler;
#pragma warning restore 0649

		public void OnAnnotationDragFinished (global::Java.Lang.Object p0)
		{
			var __h = OnAnnotationDragFinishedHandler;
			if (__h != null)
				__h (sender, new AnnotationDragFinishedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<AnnotationDragStartedEventArgs> OnAnnotationDragStartedHandler;
#pragma warning restore 0649

		public void OnAnnotationDragStarted (global::Java.Lang.Object p0)
		{
			var __h = OnAnnotationDragStartedHandler;
			if (__h != null)
				__h (sender, new AnnotationDragStartedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnAnnotationDragListenerImplementor value)
		{
			return value.OnAnnotationDragHandler == null && value.OnAnnotationDragFinishedHandler == null && value.OnAnnotationDragStartedHandler == null;
		}
	}

}
