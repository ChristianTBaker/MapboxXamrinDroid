using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NativeLibrary']"
	[global::Android.Runtime.Register ("com/facebook/soloader/NativeLibrary", DoNotGenerateAcw=true)]
	public abstract partial class NativeLibrary : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/NativeLibrary", typeof (NativeLibrary));
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

		protected NativeLibrary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NativeLibrary']/constructor[@name='NativeLibrary' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		protected unsafe NativeLibrary (global::System.Collections.Generic.IList<string> libraryNames)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_libraryNames = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (libraryNames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_libraryNames);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_libraryNames);
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Soloader.NativeLibrary __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.NativeLibrary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.UnsatisfiedLinkError Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NativeLibrary']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/UnsatisfiedLinkError;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Ljava/lang/UnsatisfiedLinkError;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.UnsatisfiedLinkError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_ensureLoaded;
#pragma warning disable 0169
		static Delegate GetEnsureLoadedHandler ()
		{
			if (cb_ensureLoaded == null)
				cb_ensureLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnsureLoaded);
			return cb_ensureLoaded;
		}

		static void n_EnsureLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Soloader.NativeLibrary __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.NativeLibrary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnsureLoaded ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NativeLibrary']/method[@name='ensureLoaded' and count(parameter)=0]"
		[Register ("ensureLoaded", "()V", "GetEnsureLoadedHandler")]
		public virtual unsafe void EnsureLoaded ()
		{
			const string __id = "ensureLoaded.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initialNativeCheck;
#pragma warning disable 0169
		static Delegate GetInitialNativeCheckHandler ()
		{
			if (cb_initialNativeCheck == null)
				cb_initialNativeCheck = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitialNativeCheck);
			return cb_initialNativeCheck;
		}

		static void n_InitialNativeCheck (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Soloader.NativeLibrary __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.NativeLibrary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitialNativeCheck ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NativeLibrary']/method[@name='initialNativeCheck' and count(parameter)=0]"
		[Register ("initialNativeCheck", "()V", "GetInitialNativeCheckHandler")]
		protected virtual unsafe void InitialNativeCheck ()
		{
			const string __id = "initialNativeCheck.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_loadLibraries;
#pragma warning disable 0169
		static Delegate GetLoadLibrariesHandler ()
		{
			if (cb_loadLibraries == null)
				cb_loadLibraries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_LoadLibraries);
			return cb_loadLibraries;
		}

		static bool n_LoadLibraries (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Soloader.NativeLibrary __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.NativeLibrary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoadLibraries ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='NativeLibrary']/method[@name='loadLibraries' and count(parameter)=0]"
		[Register ("loadLibraries", "()Z", "GetLoadLibrariesHandler")]
		public virtual unsafe bool LoadLibraries ()
		{
			const string __id = "loadLibraries.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/facebook/soloader/NativeLibrary", DoNotGenerateAcw=true)]
	internal partial class NativeLibraryInvoker : NativeLibrary {

		public NativeLibraryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/facebook/soloader/NativeLibrary", typeof (NativeLibraryInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
