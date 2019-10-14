using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/TelemetryUtils", DoNotGenerateAcw=true)]
	public partial class TelemetryUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/TelemetryUtils", typeof (TelemetryUtils));
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

		protected TelemetryUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/constructor[@name='TelemetryUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TelemetryUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/method[@name='generateCreateDateFormatted' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("generateCreateDateFormatted", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static unsafe string GenerateCreateDateFormatted (global::Java.Util.Date date)
		{
			const string __id = "generateCreateDateFormatted.(Ljava/util/Date;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/method[@name='isPluggedIn' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isPluggedIn", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsPluggedIn (global::Android.Content.Context context)
		{
			const string __id = "isPluggedIn.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/method[@name='obtainApplicationState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("obtainApplicationState", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string ObtainApplicationState (global::Android.Content.Context context)
		{
			const string __id = "obtainApplicationState.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/method[@name='obtainBatteryLevel' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("obtainBatteryLevel", "(Landroid/content/Context;)I", "")]
		public static unsafe int ObtainBatteryLevel (global::Android.Content.Context context)
		{
			const string __id = "obtainBatteryLevel.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/method[@name='obtainCellularNetworkType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("obtainCellularNetworkType", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string ObtainCellularNetworkType (global::Android.Content.Context context)
		{
			const string __id = "obtainCellularNetworkType.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/method[@name='obtainCurrentDate' and count(parameter)=0]"
		[Register ("obtainCurrentDate", "()Ljava/lang/String;", "")]
		public static unsafe string ObtainCurrentDate ()
		{
			const string __id = "obtainCurrentDate.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/method[@name='obtainUniversalUniqueIdentifier' and count(parameter)=0]"
		[Register ("obtainUniversalUniqueIdentifier", "()Ljava/lang/String;", "")]
		public static unsafe string ObtainUniversalUniqueIdentifier ()
		{
			const string __id = "obtainUniversalUniqueIdentifier.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/method[@name='retrieveVendorId' and count(parameter)=0]"
		[Register ("retrieveVendorId", "()Ljava/lang/String;", "")]
		public static unsafe string RetrieveVendorId ()
		{
			const string __id = "retrieveVendorId.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryUtils']/method[@name='toHumanReadableAscii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toHumanReadableAscii", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToHumanReadableAscii (string s)
		{
			const string __id = "toHumanReadableAscii.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

	}
}
