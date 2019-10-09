using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FontUtils']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/FontUtils", DoNotGenerateAcw=true)]
	public partial class FontUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/FontUtils", typeof (FontUtils));
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

		protected FontUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FontUtils']/method[@name='extractValidFont' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("extractValidFont", "([Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ExtractValidFont (params string[] fontNames)
		{
			const string __id = "extractValidFont.([Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_fontNames = JNIEnv.NewArray (fontNames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fontNames);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (fontNames != null) {
					JNIEnv.CopyArray (native_fontNames, fontNames);
					JNIEnv.DeleteLocalRef (native_fontNames);
				}
			}
		}

	}
}
