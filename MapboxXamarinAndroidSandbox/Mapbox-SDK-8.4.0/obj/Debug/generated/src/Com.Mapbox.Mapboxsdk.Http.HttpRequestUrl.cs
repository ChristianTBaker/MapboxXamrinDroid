using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='HttpRequestUrl']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/http/HttpRequestUrl", DoNotGenerateAcw=true)]
	public partial class HttpRequestUrl : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/http/HttpRequestUrl", typeof (HttpRequestUrl));
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

		protected HttpRequestUrl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='HttpRequestUrl']/method[@name='buildResourceUrl' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("buildResourceUrl", "(Ljava/lang/String;Ljava/lang/String;IZ)Ljava/lang/String;", "")]
		public static unsafe string BuildResourceUrl (string host, string resourceUrl, int querySize, bool offline)
		{
			const string __id = "buildResourceUrl.(Ljava/lang/String;Ljava/lang/String;IZ)Ljava/lang/String;";
			IntPtr native_host = JNIEnv.NewString (host);
			IntPtr native_resourceUrl = JNIEnv.NewString (resourceUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_host);
				__args [1] = new JniArgumentValue (native_resourceUrl);
				__args [2] = new JniArgumentValue (querySize);
				__args [3] = new JniArgumentValue (offline);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_resourceUrl);
			}
		}

	}
}
