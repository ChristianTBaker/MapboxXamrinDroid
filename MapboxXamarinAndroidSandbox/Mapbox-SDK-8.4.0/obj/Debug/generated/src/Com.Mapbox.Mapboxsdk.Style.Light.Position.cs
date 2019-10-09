using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Light {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Position']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/light/Position", DoNotGenerateAcw=true)]
	public partial class Position : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/light/Position", typeof (Position));
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

		protected Position (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Position']/constructor[@name='Position' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register (".ctor", "(FFF)V", "")]
		public unsafe Position (float radialCoordinate, float azimuthalAngle, float polarAngle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (radialCoordinate);
				__args [1] = new JniArgumentValue (azimuthalAngle);
				__args [2] = new JniArgumentValue (polarAngle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.light']/class[@name='Position']/method[@name='fromPosition' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("fromPosition", "(FFF)Lcom/mapbox/mapboxsdk/style/light/Position;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Light.Position FromPosition (float radialCoordinate, float azimuthalAngle, float polarAngle)
		{
			const string __id = "fromPosition.(FFF)Lcom/mapbox/mapboxsdk/style/light/Position;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (radialCoordinate);
				__args [1] = new JniArgumentValue (azimuthalAngle);
				__args [2] = new JniArgumentValue (polarAngle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Light.Position> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
