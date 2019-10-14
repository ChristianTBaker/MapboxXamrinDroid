using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='SessionIdentifier']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/location/SessionIdentifier", DoNotGenerateAcw=true)]
	public partial class SessionIdentifier : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/location/SessionIdentifier", typeof (SessionIdentifier));
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

		protected SessionIdentifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='SessionIdentifier']/constructor[@name='SessionIdentifier' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SessionIdentifier ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='SessionIdentifier']/constructor[@name='SessionIdentifier' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe SessionIdentifier (int rotationInterval)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rotationInterval);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='SessionIdentifier']/constructor[@name='SessionIdentifier' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe SessionIdentifier (long intervalMillis)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (intervalMillis);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getInterval;
#pragma warning disable 0169
		static Delegate GetGetIntervalHandler ()
		{
			if (cb_getInterval == null)
				cb_getInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetInterval);
			return cb_getInterval;
		}

		static long n_GetInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.Location.SessionIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Location.SessionIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Interval;
		}
#pragma warning restore 0169

		public virtual unsafe long Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='SessionIdentifier']/method[@name='getInterval' and count(parameter)=0]"
			[Register ("getInterval", "()J", "GetGetIntervalHandler")]
			get {
				const string __id = "getInterval.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
