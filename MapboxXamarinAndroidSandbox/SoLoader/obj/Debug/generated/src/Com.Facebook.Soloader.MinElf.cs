using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']"
	[global::Android.Runtime.Register ("com/facebook/soloader/MinElf", DoNotGenerateAcw=true)]
	public sealed partial class MinElf : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/field[@name='DT_NEEDED']"
		[Register ("DT_NEEDED")]
		public const int DtNeeded = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/field[@name='DT_NULL']"
		[Register ("DT_NULL")]
		public const int DtNull = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/field[@name='DT_STRTAB']"
		[Register ("DT_STRTAB")]
		public const int DtStrtab = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/field[@name='ELF_MAGIC']"
		[Register ("ELF_MAGIC")]
		public const int ElfMagic = (int) 1179403647;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/field[@name='PN_XNUM']"
		[Register ("PN_XNUM")]
		public const int PnXnum = (int) 65535;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/field[@name='PT_DYNAMIC']"
		[Register ("PT_DYNAMIC")]
		public const int PtDynamic = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/field[@name='PT_LOAD']"
		[Register ("PT_LOAD")]
		public const int PtLoad = (int) 1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/MinElf", typeof (MinElf));
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

		internal MinElf (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/constructor[@name='MinElf' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MinElf ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/method[@name='extract_DT_NEEDED' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("extract_DT_NEEDED", "(Ljava/io/File;)[Ljava/lang/String;", "")]
		public static unsafe string[] Extract_DT_NEEDED (global::Java.IO.File elfFile)
		{
			const string __id = "extract_DT_NEEDED.(Ljava/io/File;)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((elfFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) elfFile).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='MinElf']/method[@name='extract_DT_NEEDED' and count(parameter)=1 and parameter[1][@type='java.nio.channels.FileChannel']]"
		[Register ("extract_DT_NEEDED", "(Ljava/nio/channels/FileChannel;)[Ljava/lang/String;", "")]
		public static unsafe string[] Extract_DT_NEEDED (global::Java.Nio.Channels.FileChannel fc)
		{
			const string __id = "extract_DT_NEEDED.(Ljava/nio/channels/FileChannel;)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fc).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
