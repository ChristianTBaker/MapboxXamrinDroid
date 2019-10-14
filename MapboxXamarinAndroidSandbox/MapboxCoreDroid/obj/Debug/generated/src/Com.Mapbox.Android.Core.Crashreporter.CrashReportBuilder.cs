using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Crashreporter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='CrashReportBuilder']"
	[global::Android.Runtime.Register ("com/mapbox/android/core/crashreporter/CrashReportBuilder", DoNotGenerateAcw=true)]
	public sealed partial class CrashReportBuilder : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/crashreporter/CrashReportBuilder", typeof (CrashReportBuilder));
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

		internal CrashReportBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='CrashReportBuilder']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Lcom/mapbox/android/core/crashreporter/CrashReport;", "")]
		public static unsafe global::Com.Mapbox.Android.Core.Crashreporter.CrashReport FromJson (string json)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Lcom/mapbox/android/core/crashreporter/CrashReport;";
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_json);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Crashreporter.CrashReport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

	}
}
