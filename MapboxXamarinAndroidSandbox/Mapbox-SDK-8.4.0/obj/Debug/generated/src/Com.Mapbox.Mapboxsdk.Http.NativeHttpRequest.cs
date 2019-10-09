using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='NativeHttpRequest']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/http/NativeHttpRequest", DoNotGenerateAcw=true)]
	public partial class NativeHttpRequest : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/http/NativeHttpRequest", typeof (NativeHttpRequest));
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

		protected NativeHttpRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Http.NativeHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.NativeHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='NativeHttpRequest']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_handleFailure_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleFailure_ILjava_lang_String_Handler ()
		{
			if (cb_handleFailure_ILjava_lang_String_ == null)
				cb_handleFailure_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_HandleFailure_ILjava_lang_String_);
			return cb_handleFailure_ILjava_lang_String_;
		}

		static void n_HandleFailure_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int type, IntPtr native_errorMessage)
		{
			global::Com.Mapbox.Mapboxsdk.Http.NativeHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.NativeHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string errorMessage = JNIEnv.GetString (native_errorMessage, JniHandleOwnership.DoNotTransfer);
			__this.HandleFailure (type, errorMessage);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='NativeHttpRequest']/method[@name='handleFailure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("handleFailure", "(ILjava/lang/String;)V", "GetHandleFailure_ILjava_lang_String_Handler")]
		public virtual unsafe void HandleFailure (int type, string errorMessage)
		{
			const string __id = "handleFailure.(ILjava/lang/String;)V";
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (native_errorMessage);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorMessage);
			}
		}

		static Delegate cb_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB);
			return cb_onResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		static void n_OnResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, int responseCode, IntPtr native_etag, IntPtr native_lastModified, IntPtr native_cacheControl, IntPtr native_expires, IntPtr native_retryAfter, IntPtr native_xRateLimitReset, IntPtr native_body)
		{
			global::Com.Mapbox.Mapboxsdk.Http.NativeHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.NativeHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string etag = JNIEnv.GetString (native_etag, JniHandleOwnership.DoNotTransfer);
			string lastModified = JNIEnv.GetString (native_lastModified, JniHandleOwnership.DoNotTransfer);
			string cacheControl = JNIEnv.GetString (native_cacheControl, JniHandleOwnership.DoNotTransfer);
			string expires = JNIEnv.GetString (native_expires, JniHandleOwnership.DoNotTransfer);
			string retryAfter = JNIEnv.GetString (native_retryAfter, JniHandleOwnership.DoNotTransfer);
			string xRateLimitReset = JNIEnv.GetString (native_xRateLimitReset, JniHandleOwnership.DoNotTransfer);
			byte[] body = (byte[]) JNIEnv.GetArray (native_body, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnResponse (responseCode, etag, lastModified, cacheControl, expires, retryAfter, xRateLimitReset, body);
			if (body != null)
				JNIEnv.CopyArray (body, native_body);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='NativeHttpRequest']/method[@name='onResponse' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='byte[]']]"
		[Register ("onResponse", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V", "GetOnResponse_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe void OnResponse (int responseCode, string etag, string lastModified, string cacheControl, string expires, string retryAfter, string xRateLimitReset, byte[] body)
		{
			const string __id = "onResponse.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V";
			IntPtr native_etag = JNIEnv.NewString (etag);
			IntPtr native_lastModified = JNIEnv.NewString (lastModified);
			IntPtr native_cacheControl = JNIEnv.NewString (cacheControl);
			IntPtr native_expires = JNIEnv.NewString (expires);
			IntPtr native_retryAfter = JNIEnv.NewString (retryAfter);
			IntPtr native_xRateLimitReset = JNIEnv.NewString (xRateLimitReset);
			IntPtr native_body = JNIEnv.NewArray (body);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (responseCode);
				__args [1] = new JniArgumentValue (native_etag);
				__args [2] = new JniArgumentValue (native_lastModified);
				__args [3] = new JniArgumentValue (native_cacheControl);
				__args [4] = new JniArgumentValue (native_expires);
				__args [5] = new JniArgumentValue (native_retryAfter);
				__args [6] = new JniArgumentValue (native_xRateLimitReset);
				__args [7] = new JniArgumentValue (native_body);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_etag);
				JNIEnv.DeleteLocalRef (native_lastModified);
				JNIEnv.DeleteLocalRef (native_cacheControl);
				JNIEnv.DeleteLocalRef (native_expires);
				JNIEnv.DeleteLocalRef (native_retryAfter);
				JNIEnv.DeleteLocalRef (native_xRateLimitReset);
				if (body != null) {
					JNIEnv.CopyArray (native_body, body);
					JNIEnv.DeleteLocalRef (native_body);
				}
			}
		}

	}
}
