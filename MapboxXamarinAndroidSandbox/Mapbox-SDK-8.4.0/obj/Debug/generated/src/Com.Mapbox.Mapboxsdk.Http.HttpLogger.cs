using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='HttpLogger']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/http/HttpLogger", DoNotGenerateAcw=true)]
	public partial class HttpLogger : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='HttpLogger']/field[@name='logEnabled']"
		[Register ("logEnabled")]
		public static bool LogEnabled {
			get {
				const string __id = "logEnabled.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "logEnabled.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='HttpLogger']/field[@name='logRequestUrl']"
		[Register ("logRequestUrl")]
		public static bool LogRequestUrl {
			get {
				const string __id = "logRequestUrl.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "logRequestUrl.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/http/HttpLogger", typeof (HttpLogger));
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

		protected HttpLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='HttpLogger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(ILjava/lang/String;)V", "")]
		public static unsafe void Log (int type, string errorMessage)
		{
			const string __id = "log.(ILjava/lang/String;)V";
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (native_errorMessage);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorMessage);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='HttpLogger']/method[@name='logFailure' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("logFailure", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void LogFailure (int type, string errorMessage, string requestUrl)
		{
			const string __id = "logFailure.(ILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			IntPtr native_requestUrl = JNIEnv.NewString (requestUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (native_errorMessage);
				__args [2] = new JniArgumentValue (native_requestUrl);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorMessage);
				JNIEnv.DeleteLocalRef (native_requestUrl);
			}
		}

	}
}
