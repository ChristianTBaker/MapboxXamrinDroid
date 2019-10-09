using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Http {

	[Register ("com/mapbox/mapboxsdk/http/HttpRequest", DoNotGenerateAcw=true)]
	public abstract class HttpRequest : Java.Lang.Object {

		internal HttpRequest ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/interface[@name='HttpRequest']/field[@name='CONNECTION_ERROR']"
		[Register ("CONNECTION_ERROR")]
		public const int ConnectionError = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/interface[@name='HttpRequest']/field[@name='PERMANENT_ERROR']"
		[Register ("PERMANENT_ERROR")]
		public const int PermanentError = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/interface[@name='HttpRequest']/field[@name='TEMPORARY_ERROR']"
		[Register ("TEMPORARY_ERROR")]
		public const int TemporaryError = (int) 1;
	}

	[Register ("com/mapbox/mapboxsdk/http/HttpRequest", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'HttpRequest' type. This type will be removed in a future release.")]
	public abstract class HttpRequestConsts : HttpRequest {

		private HttpRequestConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/interface[@name='HttpRequest']"
	[Register ("com/mapbox/mapboxsdk/http/HttpRequest", "", "Com.Mapbox.Mapboxsdk.Http.IHttpRequestInvoker")]
	public partial interface IHttpRequest : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/interface[@name='HttpRequest']/method[@name='cancelRequest' and count(parameter)=0]"
		[Register ("cancelRequest", "()V", "GetCancelRequestHandler:Com.Mapbox.Mapboxsdk.Http.IHttpRequestInvoker, Mapbox-SDK-8.4.0")]
		void CancelRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/interface[@name='HttpRequest']/method[@name='executeRequest' and count(parameter)=6 and parameter[1][@type='com.mapbox.mapboxsdk.http.HttpResponder'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean']]"
		[Register ("executeRequest", "(Lcom/mapbox/mapboxsdk/http/HttpResponder;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "GetExecuteRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler:Com.Mapbox.Mapboxsdk.Http.IHttpRequestInvoker, Mapbox-SDK-8.4.0")]
		void ExecuteRequest (global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder p0, long p1, string p2, string p3, string p4, bool p5);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/http/HttpRequest", DoNotGenerateAcw=true)]
	internal class IHttpRequestInvoker : global::Java.Lang.Object, IHttpRequest {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/http/HttpRequest", typeof (IHttpRequestInvoker));

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

		public static IHttpRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.http.HttpRequest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancelRequest;
#pragma warning disable 0169
		static Delegate GetCancelRequestHandler ()
		{
			if (cb_cancelRequest == null)
				cb_cancelRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelRequest);
			return cb_cancelRequest;
		}

		static void n_CancelRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelRequest ();
		}
#pragma warning restore 0169

		IntPtr id_cancelRequest;
		public unsafe void CancelRequest ()
		{
			if (id_cancelRequest == IntPtr.Zero)
				id_cancelRequest = JNIEnv.GetMethodID (class_ref, "cancelRequest", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelRequest);
		}

		static Delegate cb_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetExecuteRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, bool>) n_ExecuteRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_ExecuteRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5)
		{
			global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder p0 = (global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteRequest (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		public unsafe void ExecuteRequest (global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder p0, long p1, string p2, string p3, string p4, bool p5)
		{
			if (id_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "executeRequest", "(Lcom/mapbox/mapboxsdk/http/HttpResponder;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}

}
