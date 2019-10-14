using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Crashreporter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='CrashReport']"
	[global::Android.Runtime.Register ("com/mapbox/android/core/crashreporter/CrashReport", DoNotGenerateAcw=true)]
	public partial class CrashReport : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/crashreporter/CrashReport", typeof (CrashReport));
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

		protected CrashReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDateString;
#pragma warning disable 0169
		static Delegate GetGetDateStringHandler ()
		{
			if (cb_getDateString == null)
				cb_getDateString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateString);
			return cb_getDateString;
		}

		static IntPtr n_GetDateString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Crashreporter.CrashReport __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Crashreporter.CrashReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateString);
		}
#pragma warning restore 0169

		public virtual unsafe string DateString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='CrashReport']/method[@name='getDateString' and count(parameter)=0]"
			[Register ("getDateString", "()Ljava/lang/String;", "GetGetDateStringHandler")]
			get {
				const string __id = "getDateString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Mapbox.Android.Core.Crashreporter.CrashReport __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Crashreporter.CrashReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='CrashReport']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Put (string key, string value)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Crashreporter.CrashReport __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Crashreporter.CrashReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='CrashReport']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Ljava/lang/String;", "GetToJsonHandler")]
		public virtual unsafe string ToJson ()
		{
			const string __id = "toJson.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
