using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk']/interface[@name='ModuleProvider']"
	[Register ("com/mapbox/mapboxsdk/ModuleProvider", "", "Com.Mapbox.Mapboxsdk.IModuleProviderInvoker")]
	public partial interface IModuleProvider : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/interface[@name='ModuleProvider']/method[@name='createHttpRequest' and count(parameter)=0]"
		[Register ("createHttpRequest", "()Lcom/mapbox/mapboxsdk/http/HttpRequest;", "GetCreateHttpRequestHandler:Com.Mapbox.Mapboxsdk.IModuleProviderInvoker, Mapbox-SDK-8.4.0")]
		global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest CreateHttpRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/interface[@name='ModuleProvider']/method[@name='createLibraryLoaderProvider' and count(parameter)=0]"
		[Register ("createLibraryLoaderProvider", "()Lcom/mapbox/mapboxsdk/LibraryLoaderProvider;", "GetCreateLibraryLoaderProviderHandler:Com.Mapbox.Mapboxsdk.IModuleProviderInvoker, Mapbox-SDK-8.4.0")]
		global::Com.Mapbox.Mapboxsdk.ILibraryLoaderProvider CreateLibraryLoaderProvider ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/interface[@name='ModuleProvider']/method[@name='obtainTelemetry' and count(parameter)=0]"
		[Register ("obtainTelemetry", "()Lcom/mapbox/mapboxsdk/maps/TelemetryDefinition;", "GetObtainTelemetryHandler:Com.Mapbox.Mapboxsdk.IModuleProviderInvoker, Mapbox-SDK-8.4.0")]
		global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition ObtainTelemetry ();

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/ModuleProvider", DoNotGenerateAcw=true)]
	internal class IModuleProviderInvoker : global::Java.Lang.Object, IModuleProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/ModuleProvider", typeof (IModuleProviderInvoker));

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

		public static IModuleProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IModuleProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.ModuleProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IModuleProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createHttpRequest;
#pragma warning disable 0169
		static Delegate GetCreateHttpRequestHandler ()
		{
			if (cb_createHttpRequest == null)
				cb_createHttpRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateHttpRequest);
			return cb_createHttpRequest;
		}

		static IntPtr n_CreateHttpRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.IModuleProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.IModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateHttpRequest ());
		}
#pragma warning restore 0169

		IntPtr id_createHttpRequest;
		public unsafe global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest CreateHttpRequest ()
		{
			if (id_createHttpRequest == IntPtr.Zero)
				id_createHttpRequest = JNIEnv.GetMethodID (class_ref, "createHttpRequest", "()Lcom/mapbox/mapboxsdk/http/HttpRequest;");
			return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createHttpRequest), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_createLibraryLoaderProvider;
#pragma warning disable 0169
		static Delegate GetCreateLibraryLoaderProviderHandler ()
		{
			if (cb_createLibraryLoaderProvider == null)
				cb_createLibraryLoaderProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateLibraryLoaderProvider);
			return cb_createLibraryLoaderProvider;
		}

		static IntPtr n_CreateLibraryLoaderProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.IModuleProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.IModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateLibraryLoaderProvider ());
		}
#pragma warning restore 0169

		IntPtr id_createLibraryLoaderProvider;
		public unsafe global::Com.Mapbox.Mapboxsdk.ILibraryLoaderProvider CreateLibraryLoaderProvider ()
		{
			if (id_createLibraryLoaderProvider == IntPtr.Zero)
				id_createLibraryLoaderProvider = JNIEnv.GetMethodID (class_ref, "createLibraryLoaderProvider", "()Lcom/mapbox/mapboxsdk/LibraryLoaderProvider;");
			return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.ILibraryLoaderProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createLibraryLoaderProvider), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_obtainTelemetry;
#pragma warning disable 0169
		static Delegate GetObtainTelemetryHandler ()
		{
			if (cb_obtainTelemetry == null)
				cb_obtainTelemetry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ObtainTelemetry);
			return cb_obtainTelemetry;
		}

		static IntPtr n_ObtainTelemetry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.IModuleProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.IModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainTelemetry ());
		}
#pragma warning restore 0169

		IntPtr id_obtainTelemetry;
		public unsafe global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition ObtainTelemetry ()
		{
			if (id_obtainTelemetry == IntPtr.Zero)
				id_obtainTelemetry = JNIEnv.GetMethodID (class_ref, "obtainTelemetry", "()Lcom/mapbox/mapboxsdk/maps/TelemetryDefinition;");
			return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainTelemetry), JniHandleOwnership.TransferLocalRef);
		}

	}

}
