using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='FocalPointChangeListener']"
	[Register ("com/mapbox/mapboxsdk/maps/FocalPointChangeListener", "", "Com.Mapbox.Mapboxsdk.Maps.IFocalPointChangeListenerInvoker")]
	public partial interface IFocalPointChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='FocalPointChangeListener']/method[@name='onFocalPointChanged' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
		[Register ("onFocalPointChanged", "(Landroid/graphics/PointF;)V", "GetOnFocalPointChanged_Landroid_graphics_PointF_Handler:Com.Mapbox.Mapboxsdk.Maps.IFocalPointChangeListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnFocalPointChanged (global::Android.Graphics.PointF p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/FocalPointChangeListener", DoNotGenerateAcw=true)]
	internal class IFocalPointChangeListenerInvoker : global::Java.Lang.Object, IFocalPointChangeListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/FocalPointChangeListener", typeof (IFocalPointChangeListenerInvoker));

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

		public static IFocalPointChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFocalPointChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.FocalPointChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFocalPointChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFocalPointChanged_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetOnFocalPointChanged_Landroid_graphics_PointF_Handler ()
		{
			if (cb_onFocalPointChanged_Landroid_graphics_PointF_ == null)
				cb_onFocalPointChanged_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFocalPointChanged_Landroid_graphics_PointF_);
			return cb_onFocalPointChanged_Landroid_graphics_PointF_;
		}

		static void n_OnFocalPointChanged_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.IFocalPointChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.IFocalPointChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFocalPointChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFocalPointChanged_Landroid_graphics_PointF_;
		public unsafe void OnFocalPointChanged (global::Android.Graphics.PointF p0)
		{
			if (id_onFocalPointChanged_Landroid_graphics_PointF_ == IntPtr.Zero)
				id_onFocalPointChanged_Landroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "onFocalPointChanged", "(Landroid/graphics/PointF;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFocalPointChanged_Landroid_graphics_PointF_, __args);
		}

	}

	// event args for com.mapbox.mapboxsdk.maps.FocalPointChangeListener.onFocalPointChanged
	public partial class FocalPointChangeEventArgs : global::System.EventArgs {

		public FocalPointChangeEventArgs (global::Android.Graphics.PointF p0)
		{
			this.p0 = p0;
		}

		global::Android.Graphics.PointF p0;
		public global::Android.Graphics.PointF P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/FocalPointChangeListenerImplementor")]
	internal sealed partial class IFocalPointChangeListenerImplementor : global::Java.Lang.Object, IFocalPointChangeListener {

		object sender;

		public IFocalPointChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/FocalPointChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FocalPointChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnFocalPointChanged (global::Android.Graphics.PointF p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FocalPointChangeEventArgs (p0));
		}

		internal static bool __IsEmpty (IFocalPointChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
