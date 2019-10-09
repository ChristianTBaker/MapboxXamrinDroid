using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk']/interface[@name='LibraryLoaderProvider']"
	[Register ("com/mapbox/mapboxsdk/LibraryLoaderProvider", "", "Com.Mapbox.Mapboxsdk.ILibraryLoaderProviderInvoker")]
	public partial interface ILibraryLoaderProvider : IJavaObject {

		global::Com.Mapbox.Mapboxsdk.LibraryLoader DefaultLibraryLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/interface[@name='LibraryLoaderProvider']/method[@name='getDefaultLibraryLoader' and count(parameter)=0]"
			[Register ("getDefaultLibraryLoader", "()Lcom/mapbox/mapboxsdk/LibraryLoader;", "GetGetDefaultLibraryLoaderHandler:Com.Mapbox.Mapboxsdk.ILibraryLoaderProviderInvoker, Mapbox-SDK-8.4.0")] get;
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/LibraryLoaderProvider", DoNotGenerateAcw=true)]
	internal class ILibraryLoaderProviderInvoker : global::Java.Lang.Object, ILibraryLoaderProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/LibraryLoaderProvider", typeof (ILibraryLoaderProviderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ILibraryLoaderProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILibraryLoaderProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.LibraryLoaderProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILibraryLoaderProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Mapbox.Mapboxsdk.ILibraryLoaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.ILibraryLoaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultLibraryLoader);
		}
#pragma warning restore 0169

		IntPtr id_getDefaultLibraryLoader;
		public unsafe global::Com.Mapbox.Mapboxsdk.LibraryLoader DefaultLibraryLoader {
			get {
				if (id_getDefaultLibraryLoader == IntPtr.Zero)
					id_getDefaultLibraryLoader = JNIEnv.GetMethodID (class_ref, "getDefaultLibraryLoader", "()Lcom/mapbox/mapboxsdk/LibraryLoader;");
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.LibraryLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultLibraryLoader), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
