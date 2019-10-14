using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ApkSoSource']"
	[global::Android.Runtime.Register ("com/facebook/soloader/ApkSoSource", DoNotGenerateAcw=true)]
	public partial class ApkSoSource : global::Com.Facebook.Soloader.ExtractFromZipSoSource {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ApkSoSource']/field[@name='PREFER_ANDROID_LIBS_DIRECTORY']"
		[Register ("PREFER_ANDROID_LIBS_DIRECTORY")]
		public const int PreferAndroidLibsDirectory = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ApkSoSource.ApkUnpacker']"
		[global::Android.Runtime.Register ("com/facebook/soloader/ApkSoSource$ApkUnpacker", DoNotGenerateAcw=true)]
		protected internal partial class ApkUnpacker : global::Com.Facebook.Soloader.ExtractFromZipSoSource.ZipUnpacker {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/ApkSoSource$ApkUnpacker", typeof (ApkUnpacker));
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

			protected ApkUnpacker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_shouldExtract_Ljava_util_zip_ZipEntry_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetShouldExtract_Ljava_util_zip_ZipEntry_Ljava_lang_String_Handler ()
			{
				if (cb_shouldExtract_Ljava_util_zip_ZipEntry_Ljava_lang_String_ == null)
					cb_shouldExtract_Ljava_util_zip_ZipEntry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ShouldExtract_Ljava_util_zip_ZipEntry_Ljava_lang_String_);
				return cb_shouldExtract_Ljava_util_zip_ZipEntry_Ljava_lang_String_;
			}

			static bool n_ShouldExtract_Ljava_util_zip_ZipEntry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ze, IntPtr native_soName)
			{
				global::Com.Facebook.Soloader.ApkSoSource.ApkUnpacker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.ApkSoSource.ApkUnpacker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Zip.ZipEntry ze = global::Java.Lang.Object.GetObject<global::Java.Util.Zip.ZipEntry> (native_ze, JniHandleOwnership.DoNotTransfer);
				string soName = JNIEnv.GetString (native_soName, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.ShouldExtract (ze, soName);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ApkSoSource.ApkUnpacker']/method[@name='shouldExtract' and count(parameter)=2 and parameter[1][@type='java.util.zip.ZipEntry'] and parameter[2][@type='java.lang.String']]"
			[Register ("shouldExtract", "(Ljava/util/zip/ZipEntry;Ljava/lang/String;)Z", "GetShouldExtract_Ljava_util_zip_ZipEntry_Ljava_lang_String_Handler")]
			protected override unsafe bool ShouldExtract (global::Java.Util.Zip.ZipEntry ze, string soName)
			{
				const string __id = "shouldExtract.(Ljava/util/zip/ZipEntry;Ljava/lang/String;)Z";
				IntPtr native_soName = JNIEnv.NewString (soName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((ze == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ze).Handle);
					__args [1] = new JniArgumentValue (native_soName);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_soName);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/ApkSoSource", typeof (ApkSoSource));
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

		protected ApkSoSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ApkSoSource']/constructor[@name='ApkSoSource' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/io/File;Ljava/lang/String;I)V", "")]
		public unsafe ApkSoSource (global::Android.Content.Context context, global::Java.IO.File apkPath, string name, int flags)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/io/File;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((apkPath == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apkPath).Handle);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ApkSoSource']/constructor[@name='ApkSoSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public unsafe ApkSoSource (global::Android.Content.Context context, string name, int flags)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
