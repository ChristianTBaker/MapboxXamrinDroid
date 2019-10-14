using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']"
	[global::Android.Runtime.Register ("com/facebook/soloader/SoLoader", DoNotGenerateAcw=true)]
	public partial class SoLoader : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/field[@name='SOLOADER_ALLOW_ASYNC_INIT']"
		[Register ("SOLOADER_ALLOW_ASYNC_INIT")]
		public const int SoloaderAllowAsyncInit = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/field[@name='SOLOADER_DISABLE_BACKUP_SOSOURCE']"
		[Register ("SOLOADER_DISABLE_BACKUP_SOSOURCE")]
		public const int SoloaderDisableBackupSosource = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/field[@name='SOLOADER_ENABLE_EXOPACKAGE']"
		[Register ("SOLOADER_ENABLE_EXOPACKAGE")]
		public const int SoloaderEnableExopackage = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/field[@name='SOLOADER_LOOK_IN_ZIP']"
		[Register ("SOLOADER_LOOK_IN_ZIP")]
		public const int SoloaderLookInZip = (int) 4;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader.WrongAbiError']"
		[global::Android.Runtime.Register ("com/facebook/soloader/SoLoader$WrongAbiError", DoNotGenerateAcw=true)]
		public sealed partial class WrongAbiError : global::Java.Lang.UnsatisfiedLinkError {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/SoLoader$WrongAbiError", typeof (WrongAbiError));
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

			internal WrongAbiError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/SoLoader", typeof (SoLoader));
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

		protected SoLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/constructor[@name='SoLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SoLoader ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='areSoSourcesAbisSupported' and count(parameter)=0]"
		[Register ("areSoSourcesAbisSupported", "()Z", "")]
		public static unsafe bool AreSoSourcesAbisSupported ()
		{
			const string __id = "areSoSourcesAbisSupported.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='deinitForTest' and count(parameter)=0]"
		[Register ("deinitForTest", "()V", "")]
		public static unsafe void DeinitForTest ()
		{
			const string __id = "deinitForTest.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='getLibraryPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibraryPath", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetLibraryPath (string libName)
		{
			const string __id = "getLibraryPath.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_libName = JNIEnv.NewString (libName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_libName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_libName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("init", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void Init (global::Android.Content.Context context, bool nativeExopackage)
		{
			const string __id = "init.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (nativeExopackage);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("init", "(Landroid/content/Context;I)V", "")]
		public static unsafe void Init (global::Android.Content.Context context, int flags)
		{
			const string __id = "init.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (flags);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='loadLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibrary", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool LoadLibrary (string shortName)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;)Z";
			IntPtr native_shortName = JNIEnv.NewString (shortName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_shortName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_shortName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='loadLibrary' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("loadLibrary", "(Ljava/lang/String;I)Z", "")]
		public static unsafe bool LoadLibrary (string shortName, int loadFlags)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;I)Z";
			IntPtr native_shortName = JNIEnv.NewString (shortName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_shortName);
				__args [1] = new JniArgumentValue (loadFlags);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_shortName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='makeLdLibraryPath' and count(parameter)=0]"
		[Register ("makeLdLibraryPath", "()Ljava/lang/String;", "")]
		public static unsafe string MakeLdLibraryPath ()
		{
			const string __id = "makeLdLibraryPath.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='makeNonZipPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeNonZipPath", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string MakeNonZipPath (string localLdLibraryPath)
		{
			const string __id = "makeNonZipPath.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_localLdLibraryPath = JNIEnv.NewString (localLdLibraryPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_localLdLibraryPath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_localLdLibraryPath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='prependSoSource' and count(parameter)=1 and parameter[1][@type='com.facebook.soloader.SoSource']]"
		[Register ("prependSoSource", "(Lcom/facebook/soloader/SoSource;)V", "")]
		public static unsafe void PrependSoSource (global::Com.Facebook.Soloader.SoSource extraSoSource)
		{
			const string __id = "prependSoSource.(Lcom/facebook/soloader/SoSource;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((extraSoSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extraSoSource).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='setInTestMode' and count(parameter)=0]"
		[Register ("setInTestMode", "()V", "")]
		public static unsafe void SetInTestMode ()
		{
			const string __id = "setInTestMode.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='setSystemLoadLibraryWrapper' and count(parameter)=1 and parameter[1][@type='com.facebook.soloader.SystemLoadLibraryWrapper']]"
		[Register ("setSystemLoadLibraryWrapper", "(Lcom/facebook/soloader/SystemLoadLibraryWrapper;)V", "")]
		public static unsafe void SetSystemLoadLibraryWrapper (global::Com.Facebook.Soloader.ISystemLoadLibraryWrapper wrapper)
		{
			const string __id = "setSystemLoadLibraryWrapper.(Lcom/facebook/soloader/SystemLoadLibraryWrapper;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((wrapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wrapper).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SoLoader']/method[@name='unpackLibraryAndDependencies' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unpackLibraryAndDependencies", "(Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File UnpackLibraryAndDependencies (string shortName)
		{
			const string __id = "unpackLibraryAndDependencies.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_shortName = JNIEnv.NewString (shortName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_shortName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_shortName);
			}
		}

	}
}
