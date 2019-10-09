using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Module.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.http']/class[@name='HttpRequestImpl']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/module/http/HttpRequestImpl", DoNotGenerateAcw=true)]
	public partial class HttpRequestImpl : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest {


		public static class InterfaceConsts {

			// The following are fields from: com.mapbox.mapboxsdk.http.HttpRequest

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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/module/http/HttpRequestImpl", typeof (HttpRequestImpl));
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

		protected HttpRequestImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.http']/class[@name='HttpRequestImpl']/constructor[@name='HttpRequestImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpRequestImpl ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
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
			global::Com.Mapbox.Mapboxsdk.Module.Http.HttpRequestImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Http.HttpRequestImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelRequest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.http']/class[@name='HttpRequestImpl']/method[@name='cancelRequest' and count(parameter)=0]"
		[Register ("cancelRequest", "()V", "GetCancelRequestHandler")]
		public virtual unsafe void CancelRequest ()
		{
			const string __id = "cancelRequest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.http']/class[@name='HttpRequestImpl']/method[@name='enableLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableLog", "(Z)V", "")]
		public static unsafe void EnableLog (bool enabled)
		{
			const string __id = "enableLog.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.http']/class[@name='HttpRequestImpl']/method[@name='enablePrintRequestUrlOnFailure' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enablePrintRequestUrlOnFailure", "(Z)V", "")]
		public static unsafe void EnablePrintRequestUrlOnFailure (bool enabled)
		{
			const string __id = "enablePrintRequestUrlOnFailure.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetExecuteRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, bool>) n_ExecuteRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_executeRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_ExecuteRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_httpRequest, long nativePtr, IntPtr native_resourceUrl, IntPtr native_etag, IntPtr native_modified, bool offlineUsage)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Http.HttpRequestImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Http.HttpRequestImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder httpRequest = (global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder> (native_httpRequest, JniHandleOwnership.DoNotTransfer);
			string resourceUrl = JNIEnv.GetString (native_resourceUrl, JniHandleOwnership.DoNotTransfer);
			string etag = JNIEnv.GetString (native_etag, JniHandleOwnership.DoNotTransfer);
			string modified = JNIEnv.GetString (native_modified, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteRequest (httpRequest, nativePtr, resourceUrl, etag, modified, offlineUsage);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.http']/class[@name='HttpRequestImpl']/method[@name='executeRequest' and count(parameter)=6 and parameter[1][@type='com.mapbox.mapboxsdk.http.HttpResponder'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean']]"
		[Register ("executeRequest", "(Lcom/mapbox/mapboxsdk/http/HttpResponder;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "GetExecuteRequest_Lcom_mapbox_mapboxsdk_http_HttpResponder_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe void ExecuteRequest (global::Com.Mapbox.Mapboxsdk.Http.IHttpResponder httpRequest, long nativePtr, string resourceUrl, string etag, string modified, bool offlineUsage)
		{
			const string __id = "executeRequest.(Lcom/mapbox/mapboxsdk/http/HttpResponder;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V";
			IntPtr native_resourceUrl = JNIEnv.NewString (resourceUrl);
			IntPtr native_etag = JNIEnv.NewString (etag);
			IntPtr native_modified = JNIEnv.NewString (modified);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((httpRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) httpRequest).Handle);
				__args [1] = new JniArgumentValue (nativePtr);
				__args [2] = new JniArgumentValue (native_resourceUrl);
				__args [3] = new JniArgumentValue (native_etag);
				__args [4] = new JniArgumentValue (native_modified);
				__args [5] = new JniArgumentValue (offlineUsage);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_resourceUrl);
				JNIEnv.DeleteLocalRef (native_etag);
				JNIEnv.DeleteLocalRef (native_modified);
			}
		}

	}
}
