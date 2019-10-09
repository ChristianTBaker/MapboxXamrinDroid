using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='HttpIdentifier']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/http/HttpIdentifier", DoNotGenerateAcw=true)]
	public partial class HttpIdentifier : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/http/HttpIdentifier", typeof (HttpIdentifier));
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

		protected HttpIdentifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.http']/class[@name='HttpIdentifier']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")]
			get {
				const string __id = "getIdentifier.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
