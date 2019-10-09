using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/interface[@name='HttpResponder']"
	[Register ("com/mapbox/mapboxsdk/http/HttpResponder", "", "Com.Mapbox.Mapboxsdk.Http.IHttpResponderInvoker")]
	public partial interface IHttpResponder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/interface[@name='HttpResponder']/method[@name='handleFailure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("handleFailure", "(ILjava/lang/String;)V", "GetHandleFailure_ILjava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Http.IHttpResponderInvoker, Mapbox-SDK-8.4.0")]
		void HandleFailure (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/interface[@name='HttpResponder']/method[@name='onResponse' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='byte[]']]"
		[Register ("onResponse", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V", "GetOnResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBHandler:Com.Mapbox.Mapboxsdk.Http.IHttpResponderInvoker, Mapbox-SDK-8.4.0")]
		void OnResponse (int p0, string p1, string p2, string p3, string p4, string p5, string p6, byte[] p7);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/http/HttpResponder", DoNotGenerateAcw=true)]
	internal class IHttpResponderInvoker : global::Java.Lang.Object, IHttpResponder {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/http/HttpResponder", typeof (IHttpResponderInvoker));

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

		public static IHttpResponder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpResponder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.http.HttpResponder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpResponderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handleFailure_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleFailure_ILjava_lang_String_Handler ()
		{
			if (cb_handleFailure_ILjava_lang_String_ == null)
				cb_handleFailure_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_HandleFailure_ILjava_lang_String_);
			return cb_handleFailure_ILjava_lang_String_;
		}

		static void n_HandleFailure_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_handleFailure_ILjava_lang_String_;
		public unsafe void HandleFailure (int p0, string p1)
		{
			if (id_handleFailure_ILjava_lang_String_ == IntPtr.Zero)
				id_handleFailure_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleFailure", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleFailure_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB);
			return cb_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		static void n_OnResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			byte[] p7 = (byte[]) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnResponse (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p7 != null)
				JNIEnv.CopyArray (p7, native_p7);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB;
		public unsafe void OnResponse (int p0, string p1, string p2, string p3, string p4, string p5, string p6, byte[] p7)
		{
			if (id_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onResponse", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (native_p7);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
			if (p7 != null) {
				JNIEnv.CopyArray (native_p7, p7);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

	}

}
