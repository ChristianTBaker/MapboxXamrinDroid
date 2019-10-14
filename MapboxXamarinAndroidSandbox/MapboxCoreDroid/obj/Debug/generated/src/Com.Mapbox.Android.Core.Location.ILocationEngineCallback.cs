using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.core.location']/interface[@name='LocationEngineCallback']"
	[Register ("com/mapbox/android/core/location/LocationEngineCallback", "", "Com.Mapbox.Android.Core.Location.ILocationEngineCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ILocationEngineCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/interface[@name='LocationEngineCallback']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onFailure", "(Ljava/lang/Exception;)V", "GetOnFailure_Ljava_lang_Exception_Handler:Com.Mapbox.Android.Core.Location.ILocationEngineCallbackInvoker, MapboxCoreDroid")]
		void OnFailure (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/interface[@name='LocationEngineCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:Com.Mapbox.Android.Core.Location.ILocationEngineCallbackInvoker, MapboxCoreDroid")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/android/core/location/LocationEngineCallback", DoNotGenerateAcw=true)]
	internal class ILocationEngineCallbackInvoker : global::Java.Lang.Object, ILocationEngineCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/core/location/LocationEngineCallback", typeof (ILocationEngineCallbackInvoker));

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

		public static ILocationEngineCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationEngineCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.core.location.LocationEngineCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationEngineCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_Exception_Handler ()
		{
			if (cb_onFailure_Ljava_lang_Exception_ == null)
				cb_onFailure_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_Exception_);
			return cb_onFailure_Ljava_lang_Exception_;
		}

		static void n_OnFailure_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_Exception_;
		public unsafe void OnFailure (global::Java.Lang.Exception p0)
		{
			if (id_onFailure_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngineCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
