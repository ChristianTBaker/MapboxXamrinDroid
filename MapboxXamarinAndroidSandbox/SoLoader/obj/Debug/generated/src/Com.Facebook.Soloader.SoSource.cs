using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']"
	[global::Android.Runtime.Register ("com/facebook/soloader/SoSource", DoNotGenerateAcw=true)]
	public abstract partial class SoSource : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/field[@name='LOAD_FLAG_ALLOW_IMPLICIT_PROVISION']"
		[Register ("LOAD_FLAG_ALLOW_IMPLICIT_PROVISION")]
		public const int LoadFlagAllowImplicitProvision = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/field[@name='LOAD_FLAG_ALLOW_SOURCE_CHANGE']"
		[Register ("LOAD_FLAG_ALLOW_SOURCE_CHANGE")]
		public const int LoadFlagAllowSourceChange = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/field[@name='LOAD_FLAG_MIN_CUSTOM_FLAG']"
		[Register ("LOAD_FLAG_MIN_CUSTOM_FLAG")]
		public const int LoadFlagMinCustomFlag = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/field[@name='LOAD_RESULT_CORRUPTED_LIB_FILE']"
		[Register ("LOAD_RESULT_CORRUPTED_LIB_FILE")]
		public const int LoadResultCorruptedLibFile = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/field[@name='LOAD_RESULT_IMPLICITLY_PROVIDED']"
		[Register ("LOAD_RESULT_IMPLICITLY_PROVIDED")]
		public const int LoadResultImplicitlyProvided = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/field[@name='LOAD_RESULT_LOADED']"
		[Register ("LOAD_RESULT_LOADED")]
		public const int LoadResultLoaded = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/field[@name='LOAD_RESULT_NOT_FOUND']"
		[Register ("LOAD_RESULT_NOT_FOUND")]
		public const int LoadResultNotFound = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/field[@name='PREPARE_FLAG_ALLOW_ASYNC_INIT']"
		[Register ("PREPARE_FLAG_ALLOW_ASYNC_INIT")]
		public const int PrepareFlagAllowAsyncInit = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/field[@name='PREPARE_FLAG_FORCE_REFRESH']"
		[Register ("PREPARE_FLAG_FORCE_REFRESH")]
		public const int PrepareFlagForceRefresh = (int) 2;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/SoSource", typeof (SoSource));
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

		protected SoSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/constructor[@name='SoSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SoSource ()
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

		static Delegate cb_addToLdLibraryPath_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddToLdLibraryPath_Ljava_util_Collection_Handler ()
		{
			if (cb_addToLdLibraryPath_Ljava_util_Collection_ == null)
				cb_addToLdLibraryPath_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddToLdLibraryPath_Ljava_util_Collection_);
			return cb_addToLdLibraryPath_Ljava_util_Collection_;
		}

		static void n_AddToLdLibraryPath_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paths)
		{
			global::Com.Facebook.Soloader.SoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.SoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paths = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_paths, JniHandleOwnership.DoNotTransfer);
			__this.AddToLdLibraryPath (paths);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/method[@name='addToLdLibraryPath' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("addToLdLibraryPath", "(Ljava/util/Collection;)V", "GetAddToLdLibraryPath_Ljava_util_Collection_Handler")]
		public virtual unsafe void AddToLdLibraryPath (global::System.Collections.Generic.ICollection<string> paths)
		{
			const string __id = "addToLdLibraryPath.(Ljava/util/Collection;)V";
			IntPtr native_paths = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (paths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paths);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_paths);
			}
		}

		static Delegate cb_getLibraryPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLibraryPath_Ljava_lang_String_Handler ()
		{
			if (cb_getLibraryPath_Ljava_lang_String_ == null)
				cb_getLibraryPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLibraryPath_Ljava_lang_String_);
			return cb_getLibraryPath_Ljava_lang_String_;
		}

		static IntPtr n_GetLibraryPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_soFileName)
		{
			global::Com.Facebook.Soloader.SoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.SoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string soFileName = JNIEnv.GetString (native_soFileName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLibraryPath (soFileName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/method[@name='getLibraryPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibraryPath", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLibraryPath_Ljava_lang_String_Handler")]
		public virtual unsafe string GetLibraryPath (string soFileName)
		{
			const string __id = "getLibraryPath.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_soFileName = JNIEnv.NewString (soFileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_soFileName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_soFileName);
			}
		}

		static Delegate cb_getSoSourceAbis;
#pragma warning disable 0169
		static Delegate GetGetSoSourceAbisHandler ()
		{
			if (cb_getSoSourceAbis == null)
				cb_getSoSourceAbis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSoSourceAbis);
			return cb_getSoSourceAbis;
		}

		static IntPtr n_GetSoSourceAbis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Soloader.SoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.SoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSoSourceAbis ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/method[@name='getSoSourceAbis' and count(parameter)=0]"
		[Register ("getSoSourceAbis", "()[Ljava/lang/String;", "GetGetSoSourceAbisHandler")]
		public virtual unsafe string[] GetSoSourceAbis ()
		{
			const string __id = "getSoSourceAbis.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
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

		static int n_LoadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Facebook.Soloader.SoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.SoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.StrictMode.ThreadPolicy p2 = global::Java.Lang.Object.GetObject<global::Android.OS.StrictMode.ThreadPolicy> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LoadLibrary (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/method[@name='loadLibrary' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.StrictMode.ThreadPolicy']]"
		[Register ("loadLibrary", "(Ljava/lang/String;ILandroid/os/StrictMode$ThreadPolicy;)I", "GetLoadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_Handler")]
		public abstract int LoadLibrary (string p0, int p1, global::Android.OS.StrictMode.ThreadPolicy p2);

		static Delegate cb_prepare_I;
#pragma warning disable 0169
		static Delegate GetPrepare_IHandler ()
		{
			if (cb_prepare_I == null)
				cb_prepare_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Prepare_I);
			return cb_prepare_I;
		}

		static void n_Prepare_I (IntPtr jnienv, IntPtr native__this, int flags)
		{
			global::Com.Facebook.Soloader.SoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.SoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("prepare", "(I)V", "GetPrepare_IHandler")]
		protected virtual unsafe void Prepare (int flags)
		{
			const string __id = "prepare.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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

		static IntPtr n_UnpackLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Soloader.SoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.SoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnpackLibrary (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/method[@name='unpackLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unpackLibrary", "(Ljava/lang/String;)Ljava/io/File;", "GetUnpackLibrary_Ljava_lang_String_Handler")]
		public abstract global::Java.IO.File UnpackLibrary (string p0);

	}

	[global::Android.Runtime.Register ("com/facebook/soloader/SoSource", DoNotGenerateAcw=true)]
	internal partial class SoSourceInvoker : SoSource {

		public SoSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/facebook/soloader/SoSource", typeof (SoSourceInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/method[@name='loadLibrary' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.StrictMode.ThreadPolicy']]"
		[Register ("loadLibrary", "(Ljava/lang/String;ILandroid/os/StrictMode$ThreadPolicy;)I", "GetLoadLibrary_Ljava_lang_String_ILandroid_os_StrictMode_ThreadPolicy_Handler")]
		public override unsafe int LoadLibrary (string p0, int p1, global::Android.OS.StrictMode.ThreadPolicy p2)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;ILandroid/os/StrictMode$ThreadPolicy;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoSource']/method[@name='unpackLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unpackLibrary", "(Ljava/lang/String;)Ljava/io/File;", "GetUnpackLibrary_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File UnpackLibrary (string p0)
		{
			const string __id = "unpackLibrary.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
