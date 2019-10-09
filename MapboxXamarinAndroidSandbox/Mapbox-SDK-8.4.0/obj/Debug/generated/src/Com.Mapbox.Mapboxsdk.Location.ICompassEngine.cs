using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='CompassEngine']"
	[Register ("com/mapbox/mapboxsdk/location/CompassEngine", "", "Com.Mapbox.Mapboxsdk.Location.ICompassEngineInvoker")]
	public partial interface ICompassEngine : IJavaObject {

		int LastAccuracySensorStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='CompassEngine']/method[@name='getLastAccuracySensorStatus' and count(parameter)=0]"
			[Register ("getLastAccuracySensorStatus", "()I", "GetGetLastAccuracySensorStatusHandler:Com.Mapbox.Mapboxsdk.Location.ICompassEngineInvoker, Mapbox-SDK-8.4.0")] get;
		}

		float LastHeading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='CompassEngine']/method[@name='getLastHeading' and count(parameter)=0]"
			[Register ("getLastHeading", "()F", "GetGetLastHeadingHandler:Com.Mapbox.Mapboxsdk.Location.ICompassEngineInvoker, Mapbox-SDK-8.4.0")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='CompassEngine']/method[@name='addCompassListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.CompassListener']]"
		[Register ("addCompassListener", "(Lcom/mapbox/mapboxsdk/location/CompassListener;)V", "GetAddCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_Handler:Com.Mapbox.Mapboxsdk.Location.ICompassEngineInvoker, Mapbox-SDK-8.4.0")]
		void AddCompassListener (global::Com.Mapbox.Mapboxsdk.Location.ICompassListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/interface[@name='CompassEngine']/method[@name='removeCompassListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.CompassListener']]"
		[Register ("removeCompassListener", "(Lcom/mapbox/mapboxsdk/location/CompassListener;)V", "GetRemoveCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_Handler:Com.Mapbox.Mapboxsdk.Location.ICompassEngineInvoker, Mapbox-SDK-8.4.0")]
		void RemoveCompassListener (global::Com.Mapbox.Mapboxsdk.Location.ICompassListener p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/CompassEngine", DoNotGenerateAcw=true)]
	internal class ICompassEngineInvoker : global::Java.Lang.Object, ICompassEngine {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/location/CompassEngine", typeof (ICompassEngineInvoker));

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

		public static ICompassEngine GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICompassEngine> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.location.CompassEngine"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICompassEngineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLastAccuracySensorStatus;
#pragma warning disable 0169
		static Delegate GetGetLastAccuracySensorStatusHandler ()
		{
			if (cb_getLastAccuracySensorStatus == null)
				cb_getLastAccuracySensorStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastAccuracySensorStatus);
			return cb_getLastAccuracySensorStatus;
		}

		static int n_GetLastAccuracySensorStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastAccuracySensorStatus;
		}
#pragma warning restore 0169

		IntPtr id_getLastAccuracySensorStatus;
		public unsafe int LastAccuracySensorStatus {
			get {
				if (id_getLastAccuracySensorStatus == IntPtr.Zero)
					id_getLastAccuracySensorStatus = JNIEnv.GetMethodID (class_ref, "getLastAccuracySensorStatus", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastAccuracySensorStatus);
			}
		}

		static Delegate cb_getLastHeading;
#pragma warning disable 0169
		static Delegate GetGetLastHeadingHandler ()
		{
			if (cb_getLastHeading == null)
				cb_getLastHeading = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLastHeading);
			return cb_getLastHeading;
		}

		static float n_GetLastHeading (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastHeading;
		}
#pragma warning restore 0169

		IntPtr id_getLastHeading;
		public unsafe float LastHeading {
			get {
				if (id_getLastHeading == IntPtr.Zero)
					id_getLastHeading = JNIEnv.GetMethodID (class_ref, "getLastHeading", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getLastHeading);
			}
		}

		static Delegate cb_addCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_;
#pragma warning disable 0169
		static Delegate GetAddCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_Handler ()
		{
			if (cb_addCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ == null)
				cb_addCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_);
			return cb_addCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_;
		}

		static void n_AddCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Location.ICompassListener p0 = (global::Com.Mapbox.Mapboxsdk.Location.ICompassListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.ICompassListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCompassListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_;
		public unsafe void AddCompassListener (global::Com.Mapbox.Mapboxsdk.Location.ICompassListener p0)
		{
			if (id_addCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ == IntPtr.Zero)
				id_addCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ = JNIEnv.GetMethodID (class_ref, "addCompassListener", "(Lcom/mapbox/mapboxsdk/location/CompassListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_, __args);
		}

		static Delegate cb_removeCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_;
#pragma warning disable 0169
		static Delegate GetRemoveCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_Handler ()
		{
			if (cb_removeCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ == null)
				cb_removeCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_);
			return cb_removeCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_;
		}

		static void n_RemoveCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Location.ICompassListener p0 = (global::Com.Mapbox.Mapboxsdk.Location.ICompassListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.ICompassListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCompassListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_;
		public unsafe void RemoveCompassListener (global::Com.Mapbox.Mapboxsdk.Location.ICompassListener p0)
		{
			if (id_removeCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ == IntPtr.Zero)
				id_removeCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_ = JNIEnv.GetMethodID (class_ref, "removeCompassListener", "(Lcom/mapbox/mapboxsdk/location/CompassListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCompassListener_Lcom_mapbox_mapboxsdk_location_CompassListener_, __args);
		}

	}

}
