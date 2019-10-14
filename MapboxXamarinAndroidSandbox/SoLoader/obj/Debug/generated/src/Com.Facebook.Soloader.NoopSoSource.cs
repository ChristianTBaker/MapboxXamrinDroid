using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NoopSoSource']"
	[global::Android.Runtime.Register ("com/facebook/soloader/NoopSoSource", DoNotGenerateAcw=true)]
	public partial class NoopSoSource : global::Com.Facebook.Soloader.SoSource {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/NoopSoSource", typeof (NoopSoSource));
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

		protected NoopSoSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NoopSoSource']/constructor[@name='NoopSoSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NoopSoSource ()
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

		static Delegate cb_loadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_;
#pragma warning disable 0169
		static Delegate GetLoadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_Handler ()
		{
			if (cb_loadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_ == null)
				cb_loadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_LoadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_);
			return cb_loadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_;
		}

		static int n_LoadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_soName, int loadFlags, IntPtr native_threadPolicy)
		{
			global::Com.Facebook.Soloader.NoopSoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.NoopSoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string soName = JNIEnv.GetString (native_soName, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.StrictMode.ThreadPolicy threadPolicy = global::Java.Lang.Object.GetObject<global::Android.OS.StrictMode.ThreadPolicy> (native_threadPolicy, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LoadLibrary (soName, loadFlags, threadPolicy);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NoopSoSource']/method[@name='loadLibrary' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.StrictMode.ThreadPolicy']]"
		[Register ("loadLibrary", "(Ljava/lang/String;ILandroid/os/StrictMode$ThreadPolicy;)I", "GetLoadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_Handler")]
		public override unsafe int LoadLibrary (string soName, int loadFlags, global::Android.OS.StrictMode.ThreadPolicy threadPolicy)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;ILandroid/os/StrictMode$ThreadPolicy;)I";
			IntPtr native_soName = JNIEnv.NewString (soName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_soName);
				__args [1] = new JniArgumentValue (loadFlags);
				__args [2] = new JniArgumentValue ((threadPolicy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) threadPolicy).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_soName);
			}
		}

		static Delegate cb_unpackLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnpackLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_unpackLibrary_Ljava_lang_String_ == null)
				cb_unpackLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnpackLibrary_Ljava_lang_String_);
			return cb_unpackLibrary_Ljava_lang_String_;
		}

		static IntPtr n_UnpackLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_soName)
		{
			global::Com.Facebook.Soloader.NoopSoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.NoopSoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string soName = JNIEnv.GetString (native_soName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnpackLibrary (soName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NoopSoSource']/method[@name='unpackLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unpackLibrary", "(Ljava/lang/String;)Ljava/io/File;", "GetUnpackLibrary_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File UnpackLibrary (string soName)
		{
			const string __id = "unpackLibrary.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_soName = JNIEnv.NewString (soName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_soName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_soName);
			}
		}

	}
}
