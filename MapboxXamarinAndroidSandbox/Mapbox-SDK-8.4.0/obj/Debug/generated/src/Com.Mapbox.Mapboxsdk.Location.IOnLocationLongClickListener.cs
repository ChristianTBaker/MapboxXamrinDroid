using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnLocationLongClickListener']"
	[Register ("com/mapbox/mapboxsdk/location/OnLocationLongClickListener", "", "Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerInvoker")]
	public partial interface IOnLocationLongClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnLocationLongClickListener']/method[@name='onLocationComponentLongClick' and count(parameter)=0]"
		[Register ("onLocationComponentLongClick", "()V", "GetOnLocationComponentLongClickHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnLocationComponentLongClick ();

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/OnLocationLongClickListener", DoNotGenerateAcw=true)]
	internal class IOnLocationLongClickListenerInvoker : global::Java.Lang.Object, IOnLocationLongClickListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/location/OnLocationLongClickListener", typeof (IOnLocationLongClickListenerInvoker));

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

		public static IOnLocationLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnLocationLongClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.location.OnLocationLongClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnLocationLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLocationComponentLongClick;
#pragma warning disable 0169
		static Delegate GetOnLocationComponentLongClickHandler ()
		{
			if (cb_onLocationComponentLongClick == null)
				cb_onLocationComponentLongClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLocationComponentLongClick);
			return cb_onLocationComponentLongClick;
		}

		static void n_OnLocationComponentLongClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationComponentLongClick ();
		}
#pragma warning restore 0169

		IntPtr id_onLocationComponentLongClick;
		public unsafe void OnLocationComponentLongClick ()
		{
			if (id_onLocationComponentLongClick == IntPtr.Zero)
				id_onLocationComponentLongClick = JNIEnv.GetMethodID (class_ref, "onLocationComponentLongClick", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationComponentLongClick);
		}

	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/location/OnLocationLongClickListenerImplementor")]
	internal sealed partial class IOnLocationLongClickListenerImplementor : global::Java.Lang.Object, IOnLocationLongClickListener {

		object sender;

		public IOnLocationLongClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/location/OnLocationLongClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnLocationComponentLongClick ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnLocationLongClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
