using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnLocationClickListener']"
	[Register ("com/mapbox/mapboxsdk/location/OnLocationClickListener", "", "Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerInvoker")]
	public partial interface IOnLocationClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='OnLocationClickListener']/method[@name='onLocationComponentClick' and count(parameter)=0]"
		[Register ("onLocationComponentClick", "()V", "GetOnLocationComponentClickHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerInvoker, Mapbox-SDK-8.4.0")]
		void OnLocationComponentClick ();

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/OnLocationClickListener", DoNotGenerateAcw=true)]
	internal class IOnLocationClickListenerInvoker : global::Java.Lang.Object, IOnLocationClickListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/location/OnLocationClickListener", typeof (IOnLocationClickListenerInvoker));

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

		public static IOnLocationClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnLocationClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.location.OnLocationClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnLocationClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLocationComponentClick;
#pragma warning disable 0169
		static Delegate GetOnLocationComponentClickHandler ()
		{
			if (cb_onLocationComponentClick == null)
				cb_onLocationComponentClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLocationComponentClick);
			return cb_onLocationComponentClick;
		}

		static void n_OnLocationComponentClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationComponentClick ();
		}
#pragma warning restore 0169

		IntPtr id_onLocationComponentClick;
		public unsafe void OnLocationComponentClick ()
		{
			if (id_onLocationComponentClick == IntPtr.Zero)
				id_onLocationComponentClick = JNIEnv.GetMethodID (class_ref, "onLocationComponentClick", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationComponentClick);
		}

	}

	[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/location/OnLocationClickListenerImplementor")]
	internal sealed partial class IOnLocationClickListenerImplementor : global::Java.Lang.Object, IOnLocationClickListener {

		object sender;

		public IOnLocationClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/location/OnLocationClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnLocationComponentClick ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnLocationClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
