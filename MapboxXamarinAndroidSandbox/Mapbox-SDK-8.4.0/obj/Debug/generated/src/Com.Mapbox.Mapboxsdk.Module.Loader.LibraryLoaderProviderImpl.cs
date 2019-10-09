using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Module.Loader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.loader']/class[@name='LibraryLoaderProviderImpl']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/module/loader/LibraryLoaderProviderImpl", DoNotGenerateAcw=true)]
	public partial class LibraryLoaderProviderImpl : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.ILibraryLoaderProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/module/loader/LibraryLoaderProviderImpl", typeof (LibraryLoaderProviderImpl));
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

		protected LibraryLoaderProviderImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.loader']/class[@name='LibraryLoaderProviderImpl']/constructor[@name='LibraryLoaderProviderImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LibraryLoaderProviderImpl ()
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

		static Delegate cb_getDefaultLibraryLoader;
#pragma warning disable 0169
		static Delegate GetGetDefaultLibraryLoaderHandler ()
		{
			if (cb_getDefaultLibraryLoader == null)
				cb_getDefaultLibraryLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultLibraryLoader);
			return cb_getDefaultLibraryLoader;
		}

		static IntPtr n_GetDefaultLibraryLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Module.Loader.LibraryLoaderProviderImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Module.Loader.LibraryLoaderProviderImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultLibraryLoader);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.LibraryLoader DefaultLibraryLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.module.loader']/class[@name='LibraryLoaderProviderImpl']/method[@name='getDefaultLibraryLoader' and count(parameter)=0]"
			[Register ("getDefaultLibraryLoader", "()Lcom/mapbox/mapboxsdk/LibraryLoader;", "GetGetDefaultLibraryLoaderHandler")]
			get {
				const string __id = "getDefaultLibraryLoader.()Lcom/mapbox/mapboxsdk/LibraryLoader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.LibraryLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
