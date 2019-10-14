using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SysUtil']"
	[global::Android.Runtime.Register ("com/facebook/soloader/SysUtil", DoNotGenerateAcw=true)]
	public sealed partial class SysUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/SysUtil", typeof (SysUtil));
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

		internal SysUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SysUtil']/constructor[@name='SysUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SysUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SysUtil']/method[@name='deleteOrThrow' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteOrThrow", "(Ljava/io/File;)V", "")]
		public static unsafe void DeleteOrThrow (global::Java.IO.File file)
		{
			const string __id = "deleteOrThrow.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SysUtil']/method[@name='dumbDeleteRecursive' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("dumbDeleteRecursive", "(Ljava/io/File;)V", "")]
		public static unsafe void DumbDeleteRecursive (global::Java.IO.File file)
		{
			const string __id = "dumbDeleteRecursive.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SysUtil']/method[@name='fallocateIfSupported' and count(parameter)=2 and parameter[1][@type='java.io.FileDescriptor'] and parameter[2][@type='long']]"
		[Register ("fallocateIfSupported", "(Ljava/io/FileDescriptor;J)V", "")]
		public static unsafe void FallocateIfSupported (global::Java.IO.FileDescriptor fd, long length)
		{
			const string __id = "fallocateIfSupported.(Ljava/io/FileDescriptor;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fd).Handle);
				__args [1] = new JniArgumentValue (length);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SysUtil']/method[@name='findAbiScore' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("findAbiScore", "([Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int FindAbiScore (string[] supportedAbis, string abi)
		{
			const string __id = "findAbiScore.([Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_supportedAbis = JNIEnv.NewArray (supportedAbis);
			IntPtr native_abi = JNIEnv.NewString (abi);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_supportedAbis);
				__args [1] = new JniArgumentValue (native_abi);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (supportedAbis != null) {
					JNIEnv.CopyArray (native_supportedAbis, supportedAbis);
					JNIEnv.DeleteLocalRef (native_supportedAbis);
				}
				JNIEnv.DeleteLocalRef (native_abi);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SysUtil']/method[@name='getAppVersionCode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersionCode", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetAppVersionCode (global::Android.Content.Context context)
		{
			const string __id = "getAppVersionCode.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SysUtil']/method[@name='getSupportedAbis' and count(parameter)=0]"
		[Register ("getSupportedAbis", "()[Ljava/lang/String;", "")]
		public static unsafe string[] GetSupportedAbis ()
		{
			const string __id = "getSupportedAbis.()[Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='SysUtil']/method[@name='makeApkDepBlock' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='android.content.Context']]"
		[Register ("makeApkDepBlock", "(Ljava/io/File;Landroid/content/Context;)[B", "")]
		public static unsafe byte[] MakeApkDepBlock (global::Java.IO.File apkFile, global::Android.Content.Context context)
		{
			const string __id = "makeApkDepBlock.(Ljava/io/File;Landroid/content/Context;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((apkFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apkFile).Handle);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
