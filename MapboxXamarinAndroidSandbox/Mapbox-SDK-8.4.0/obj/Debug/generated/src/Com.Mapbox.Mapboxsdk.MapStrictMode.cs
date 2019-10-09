using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='MapStrictMode']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/MapStrictMode", DoNotGenerateAcw=true)]
	public partial class MapStrictMode : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/MapStrictMode", typeof (MapStrictMode));
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

		protected MapStrictMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='MapStrictMode']/constructor[@name='MapStrictMode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapStrictMode ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='MapStrictMode']/method[@name='setStrictModeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStrictModeEnabled", "(Z)V", "")]
		public static unsafe void SetStrictModeEnabled (bool strictModeEnabled)
		{
			const string __id = "setStrictModeEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (strictModeEnabled);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='MapStrictMode']/method[@name='strictModeViolation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("strictModeViolation", "(Ljava/lang/String;)V", "")]
		public static unsafe void StrictModeViolation (string message)
		{
			const string __id = "strictModeViolation.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='MapStrictMode']/method[@name='strictModeViolation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("strictModeViolation", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void StrictModeViolation (string message, global::Java.Lang.Throwable throwable)
		{
			const string __id = "strictModeViolation.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='MapStrictMode']/method[@name='strictModeViolation' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("strictModeViolation", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void StrictModeViolation (global::Java.Lang.Throwable throwable)
		{
			const string __id = "strictModeViolation.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
