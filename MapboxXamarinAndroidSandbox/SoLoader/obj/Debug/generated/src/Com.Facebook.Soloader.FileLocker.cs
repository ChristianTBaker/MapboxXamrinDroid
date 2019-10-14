using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='FileLocker']"
	[global::Android.Runtime.Register ("com/facebook/soloader/FileLocker", DoNotGenerateAcw=true)]
	public sealed partial class FileLocker : global::Java.Lang.Object, global::Java.IO.ICloseable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/FileLocker", typeof (FileLocker));
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

		internal FileLocker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='FileLocker']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='FileLocker']/method[@name='lock' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("lock", "(Ljava/io/File;)Lcom/facebook/soloader/FileLocker;", "")]
		public static unsafe global::Com.Facebook.Soloader.FileLocker Lock (global::Java.IO.File lockFile)
		{
			const string __id = "lock.(Ljava/io/File;)Lcom/facebook/soloader/FileLocker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((lockFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lockFile).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.FileLocker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
