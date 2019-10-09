using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='TelemetryConstants']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/constants/TelemetryConstants", DoNotGenerateAcw=true)]
	public partial class TelemetryConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='TelemetryConstants']/field[@name='DOUBLE_TAP']"
		[Register ("DOUBLE_TAP")]
		public const string DoubleTap = (string) "DoubleTap";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='TelemetryConstants']/field[@name='PAN']"
		[Register ("PAN")]
		public const string Pan = (string) "Pan";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='TelemetryConstants']/field[@name='PINCH']"
		[Register ("PINCH")]
		public const string Pinch = (string) "Pinch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='TelemetryConstants']/field[@name='PITCH']"
		[Register ("PITCH")]
		public const string Pitch = (string) "Pitch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='TelemetryConstants']/field[@name='ROTATION']"
		[Register ("ROTATION")]
		public const string Rotation = (string) "Rotation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='TelemetryConstants']/field[@name='SINGLE_TAP']"
		[Register ("SINGLE_TAP")]
		public const string SingleTap = (string) "SingleTap";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='TelemetryConstants']/field[@name='TWO_FINGER_TAP']"
		[Register ("TWO_FINGER_TAP")]
		public const string TwoFingerTap = (string) "TwoFingerTap";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/constants/TelemetryConstants", typeof (TelemetryConstants));
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

		protected TelemetryConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='TelemetryConstants']/constructor[@name='TelemetryConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TelemetryConstants ()
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

	}
}
