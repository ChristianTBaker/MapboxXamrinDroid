using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='DirectorySoSource']"
	[global::Android.Runtime.Register ("com/facebook/soloader/DirectorySoSource", DoNotGenerateAcw=true)]
	public partial class DirectorySoSource : global::Com.Facebook.Soloader.SoSource {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='DirectorySoSource']/field[@name='ON_LD_LIBRARY_PATH']"
		[Register ("ON_LD_LIBRARY_PATH")]
		public const int OnLdLibraryPath = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='DirectorySoSource']/field[@name='RESOLVE_DEPENDENCIES']"
		[Register ("RESOLVE_DEPENDENCIES")]
		public const int ResolveDependencies = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='DirectorySoSource']/field[@name='flags']"
		[Register ("flags")]
		protected int Flags {
			get {
				const string __id = "flags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "flags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='DirectorySoSource']/field[@name='soDirectory']"
		[Register ("soDirectory")]
		protected global::Java.IO.File SoDirectory {
			get {
				const string __id = "soDirectory.Ljava/io/File;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "soDirectory.Ljava/io/File;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/DirectorySoSource", typeof (DirectorySoSource));
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

		protected DirectorySoSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='DirectorySoSource']/constructor[@name='DirectorySoSource' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/File;I)V", "")]
		public unsafe DirectorySoSource (global::Java.IO.File soDirectory, int flags)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((soDirectory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) soDirectory).Handle);
				__args [1] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
			global::Com.Facebook.Soloader.DirectorySoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.DirectorySoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string soName = JNIEnv.GetString (native_soName, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.StrictMode.ThreadPolicy threadPolicy = global::Java.Lang.Object.GetObject<global::Android.OS.StrictMode.ThreadPolicy> (native_threadPolicy, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LoadLibrary (soName, loadFlags, threadPolicy);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='DirectorySoSource']/method[@name='loadLibrary' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.StrictMode.ThreadPolicy']]"
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

		static Delegate cb_loadLibraryFrom_Ljava_lang_String_ILjava_io_File_Landroid_os_StrictMode_ThreadPolicy_;
#pragma warning disable 0169
		static Delegate GetLoadLibraryFrom_Ljava_lang_String_ILjava_io_File_Landroid_os_StrictMode_ThreadPolicy_Handler ()
		{
			if (cb_loadLibraryFrom_Ljava_lang_String_ILjava_io_File_Landroid_os_StrictMode_ThreadPolicy_ == null)
				cb_loadLibraryFrom_Ljava_lang_String_ILjava_io_File_Landroid_os_StrictMode_ThreadPolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_LoadLibraryFrom_Ljava_lang_String_ILjava_io_File_Landroid_os_StrictMode_ThreadPolicy_);
			return cb_loadLibraryFrom_Ljava_lang_String_ILjava_io_File_Landroid_os_StrictMode_ThreadPolicy_;
		}

		static int n_LoadLibraryFrom_Ljava_lang_String_ILjava_io_File_Landroid_os_StrictMode_ThreadPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_soName, int loadFlags, IntPtr native_libDir, IntPtr native_threadPolicy)
		{
			global::Com.Facebook.Soloader.DirectorySoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.DirectorySoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string soName = JNIEnv.GetString (native_soName, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File libDir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_libDir, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.StrictMode.ThreadPolicy threadPolicy = global::Java.Lang.Object.GetObject<global::Android.OS.StrictMode.ThreadPolicy> (native_threadPolicy, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LoadLibraryFrom (soName, loadFlags, libDir, threadPolicy);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='DirectorySoSource']/method[@name='loadLibraryFrom' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.io.File'] and parameter[4][@type='android.os.StrictMode.ThreadPolicy']]"
		[Register ("loadLibraryFrom", "(Ljava/lang/String;ILjava/io/File;Landroid/os/StrictMode$ThreadPolicy;)I", "GetLoadLibraryFrom_Ljava_lang_String_ILjava_io_File_Landroid_os_StrictMode_ThreadPolicy_Handler")]
		protected virtual unsafe int LoadLibraryFrom (string soName, int loadFlags, global::Java.IO.File libDir, global::Android.OS.StrictMode.ThreadPolicy threadPolicy)
		{
			const string __id = "loadLibraryFrom.(Ljava/lang/String;ILjava/io/File;Landroid/os/StrictMode$ThreadPolicy;)I";
			IntPtr native_soName = JNIEnv.NewString (soName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_soName);
				__args [1] = new JniArgumentValue (loadFlags);
				__args [2] = new JniArgumentValue ((libDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) libDir).Handle);
				__args [3] = new JniArgumentValue ((threadPolicy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) threadPolicy).Handle);
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
			global::Com.Facebook.Soloader.DirectorySoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.DirectorySoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string soName = JNIEnv.GetString (native_soName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnpackLibrary (soName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='DirectorySoSource']/method[@name='unpackLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
