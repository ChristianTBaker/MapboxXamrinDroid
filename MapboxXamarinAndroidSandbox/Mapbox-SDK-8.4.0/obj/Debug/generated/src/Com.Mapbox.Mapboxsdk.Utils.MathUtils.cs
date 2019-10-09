using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MathUtils']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/MathUtils", DoNotGenerateAcw=true)]
	public partial class MathUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/MathUtils", typeof (MathUtils));
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

		protected MathUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MathUtils']/constructor[@name='MathUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MathUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MathUtils']/method[@name='clamp' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("clamp", "(DDD)D", "")]
		public static unsafe double Clamp (double value, double min, double max)
		{
			const string __id = "clamp.(DDD)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (min);
				__args [2] = new JniArgumentValue (max);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MathUtils']/method[@name='clamp' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("clamp", "(FFF)F", "")]
		public static unsafe float Clamp (float value, float min, float max)
		{
			const string __id = "clamp.(FFF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (min);
				__args [2] = new JniArgumentValue (max);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MathUtils']/method[@name='normalize' and count(parameter)=5 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register ("normalize", "(DDDDD)D", "")]
		public static unsafe double Normalize (double x, double dataLow, double dataHigh, double normalizedLow, double normalizedHigh)
		{
			const string __id = "normalize.(DDDDD)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (dataLow);
				__args [2] = new JniArgumentValue (dataHigh);
				__args [3] = new JniArgumentValue (normalizedLow);
				__args [4] = new JniArgumentValue (normalizedHigh);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MathUtils']/method[@name='wrap' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("wrap", "(DDD)D", "")]
		public static unsafe double Wrap (double value, double min, double max)
		{
			const string __id = "wrap.(DDD)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (min);
				__args [2] = new JniArgumentValue (max);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
