using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='LibraryLoader']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/LibraryLoader", DoNotGenerateAcw=true)]
	public abstract partial class LibraryLoader : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/LibraryLoader", typeof (LibraryLoader));
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

		protected LibraryLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='LibraryLoader']/constructor[@name='LibraryLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LibraryLoader ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='LibraryLoader']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "")]
		public static unsafe void Load ()
		{
			const string __id = "load.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_load_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Handler ()
		{
			if (cb_load_Ljava_lang_String_ == null)
				cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_String_);
			return cb_load_Ljava_lang_String_;
		}

		static void n_Load_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.LibraryLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.LibraryLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='LibraryLoader']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)V", "GetLoad_Ljava_lang_String_Handler")]
		public abstract void Load (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='LibraryLoader']/method[@name='setLibraryLoader' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.LibraryLoader']]"
		[Register ("setLibraryLoader", "(Lcom/mapbox/mapboxsdk/LibraryLoader;)V", "")]
		public static unsafe void SetLibraryLoader (global::Com.Mapbox.Mapboxsdk.LibraryLoader libraryLoader)
		{
			const string __id = "setLibraryLoader.(Lcom/mapbox/mapboxsdk/LibraryLoader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((libraryLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) libraryLoader).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/LibraryLoader", DoNotGenerateAcw=true)]
	internal partial class LibraryLoaderInvoker : LibraryLoader {

		public LibraryLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/LibraryLoader", typeof (LibraryLoaderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='LibraryLoader']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)V", "GetLoad_Ljava_lang_String_Handler")]
		public override unsafe void Load (string p0)
		{
			const string __id = "load.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
