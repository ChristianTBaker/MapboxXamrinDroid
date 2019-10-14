using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Constants']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/Constants", DoNotGenerateAcw=true)]
	public sealed partial class Constants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Constants']/field[@name='DEFAULT_MULTI_TAP_TIME_THRESHOLD']"
		[Register ("DEFAULT_MULTI_TAP_TIME_THRESHOLD")]
		public const long DefaultMultiTapTimeThreshold = (long) 150;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Constants']/field[@name='DEFAULT_ROTATE_ANGLE_THRESHOLD']"
		[Register ("DEFAULT_ROTATE_ANGLE_THRESHOLD")]
		public const float DefaultRotateAngleThreshold = (float) 15.3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Constants']/field[@name='DEFAULT_SHOVE_MAX_ANGLE']"
		[Register ("DEFAULT_SHOVE_MAX_ANGLE")]
		public const float DefaultShoveMaxAngle = (float) 20;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/Constants", typeof (Constants));
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

		internal Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Constants']/constructor[@name='Constants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Constants ()
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
