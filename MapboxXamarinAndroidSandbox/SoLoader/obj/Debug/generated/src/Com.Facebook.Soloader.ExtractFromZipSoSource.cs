using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource']"
	[global::Android.Runtime.Register ("com/facebook/soloader/ExtractFromZipSoSource", DoNotGenerateAcw=true)]
	public partial class ExtractFromZipSoSource : global::Com.Facebook.Soloader.UnpackingSoSource {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource']/field[@name='mZipFileName']"
		[Register ("mZipFileName")]
		protected global::Java.IO.File MZipFileName {
			get {
				const string __id = "mZipFileName.Ljava/io/File;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mZipFileName.Ljava/io/File;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource']/field[@name='mZipSearchPattern']"
		[Register ("mZipSearchPattern")]
		protected string MZipSearchPattern {
			get {
				const string __id = "mZipSearchPattern.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mZipSearchPattern.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource.ZipUnpacker']"
		[global::Android.Runtime.Register ("com/facebook/soloader/ExtractFromZipSoSource$ZipUnpacker", DoNotGenerateAcw=true)]
		protected internal partial class ZipUnpacker : global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/ExtractFromZipSoSource$ZipUnpacker", typeof (ZipUnpacker));
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

			protected ZipUnpacker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			protected override unsafe global::Com.Facebook.Soloader.UnpackingSoSource.DsoManifest DsoManifest {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource.ZipUnpacker']/method[@name='getDsoManifest' and count(parameter)=0]"
				[Register ("getDsoManifest", "()Lcom/facebook/soloader/UnpackingSoSource$DsoManifest;", "GetGetDsoManifestHandler")]
				get {
					const string __id = "getDsoManifest.()Lcom/facebook/soloader/UnpackingSoSource$DsoManifest;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.DsoManifest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_close;
#pragma warning disable 0169
			static Delegate GetCloseHandler ()
			{
				if (cb_close == null)
					cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
				return cb_close;
			}

			static void n_Close (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Soloader.ExtractFromZipSoSource.ZipUnpacker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.ExtractFromZipSoSource.ZipUnpacker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource.ZipUnpacker']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public override unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource.ZipUnpacker']/method[@name='openDsoIterator' and count(parameter)=0]"
			[Register ("openDsoIterator", "()Lcom/facebook/soloader/UnpackingSoSource$InputDsoIterator;", "")]
			protected override sealed unsafe global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator OpenDsoIterator ()
			{
				const string __id = "openDsoIterator.()Lcom/facebook/soloader/UnpackingSoSource$InputDsoIterator;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

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
				global::Com.Facebook.Soloader.ExtractFromZipSoSource.ZipUnpacker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.ExtractFromZipSoSource.ZipUnpacker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Zip.ZipEntry ze = global::Java.Lang.Object.GetObject<global::Java.Util.Zip.ZipEntry> (native_ze, JniHandleOwnership.DoNotTransfer);
				string soName = JNIEnv.GetString (native_soName, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.ShouldExtract (ze, soName);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource.ZipUnpacker']/method[@name='shouldExtract' and count(parameter)=2 and parameter[1][@type='java.util.zip.ZipEntry'] and parameter[2][@type='java.lang.String']]"
			[Register ("shouldExtract", "(Ljava/util/zip/ZipEntry;Ljava/lang/String;)Z", "GetShouldExtract_Ljava_util_zip_ZipEntry_Ljava_lang_String_Handler")]
			protected virtual unsafe bool ShouldExtract (global::Java.Util.Zip.ZipEntry ze, string soName)
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/ExtractFromZipSoSource", typeof (ExtractFromZipSoSource));
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

		protected ExtractFromZipSoSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource']/constructor[@name='ExtractFromZipSoSource' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.io.File'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/io/File;Ljava/lang/String;)V", "")]
		public unsafe ExtractFromZipSoSource (global::Android.Content.Context context, string name, global::Java.IO.File zipFileName, string zipSearchPattern)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/io/File;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_zipSearchPattern = JNIEnv.NewString (zipSearchPattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue ((zipFileName == null) ? IntPtr.Zero : ((global::Java.Lang.Object) zipFileName).Handle);
				__args [3] = new JniArgumentValue (native_zipSearchPattern);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_zipSearchPattern);
			}
		}

		static Delegate cb_makeUnpacker;
#pragma warning disable 0169
		static Delegate GetMakeUnpackerHandler ()
		{
			if (cb_makeUnpacker == null)
				cb_makeUnpacker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MakeUnpacker);
			return cb_makeUnpacker;
		}

		static IntPtr n_MakeUnpacker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Soloader.ExtractFromZipSoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.ExtractFromZipSoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MakeUnpacker ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='ExtractFromZipSoSource']/method[@name='makeUnpacker' and count(parameter)=0]"
		[Register ("makeUnpacker", "()Lcom/facebook/soloader/UnpackingSoSource$Unpacker;", "GetMakeUnpackerHandler")]
		protected override unsafe global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker MakeUnpacker ()
		{
			const string __id = "makeUnpacker.()Lcom/facebook/soloader/UnpackingSoSource$Unpacker;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
