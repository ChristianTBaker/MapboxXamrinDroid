using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='Compare']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/Compare", DoNotGenerateAcw=true)]
	public partial class Compare : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/Compare", typeof (Compare));
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

		protected Compare (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='Compare']/constructor[@name='Compare' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Compare ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='Compare']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("compare", "(ZZ)I", "")]
		public static unsafe int InvokeCompare (bool x, bool y)
		{
			const string __id = "compare.(ZZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='Compare']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("compare", "(II)I", "")]
		public static unsafe int InvokeCompare (int x, int y)
		{
			const string __id = "compare.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
