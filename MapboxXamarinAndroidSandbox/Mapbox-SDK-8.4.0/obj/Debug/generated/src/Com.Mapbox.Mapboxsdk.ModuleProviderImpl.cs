using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='ModuleProviderImpl']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/ModuleProviderImpl", DoNotGenerateAcw=true)]
	public partial class ModuleProviderImpl : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.IModuleProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/ModuleProviderImpl", typeof (ModuleProviderImpl));
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

		protected ModuleProviderImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='ModuleProviderImpl']/constructor[@name='ModuleProviderImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ModuleProviderImpl ()
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
			global::Com.Mapbox.Mapboxsdk.ModuleProviderImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.ModuleProviderImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateHttpRequest ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='ModuleProviderImpl']/method[@name='createHttpRequest' and count(parameter)=0]"
		[Register ("createHttpRequest", "()Lcom/mapbox/mapboxsdk/http/HttpRequest;", "GetCreateHttpRequestHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest CreateHttpRequest ()
		{
			const string __id = "createHttpRequest.()Lcom/mapbox/mapboxsdk/http/HttpRequest;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Http.IHttpRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Mapbox.Mapboxsdk.ModuleProviderImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.ModuleProviderImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateLibraryLoaderProvider ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='ModuleProviderImpl']/method[@name='createLibraryLoaderProvider' and count(parameter)=0]"
		[Register ("createLibraryLoaderProvider", "()Lcom/mapbox/mapboxsdk/LibraryLoaderProvider;", "GetCreateLibraryLoaderProviderHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.ILibraryLoaderProvider CreateLibraryLoaderProvider ()
		{
			const string __id = "createLibraryLoaderProvider.()Lcom/mapbox/mapboxsdk/LibraryLoaderProvider;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.ILibraryLoaderProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Mapbox.Mapboxsdk.ModuleProviderImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.ModuleProviderImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainTelemetry ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='ModuleProviderImpl']/method[@name='obtainTelemetry' and count(parameter)=0]"
		[Register ("obtainTelemetry", "()Lcom/mapbox/mapboxsdk/maps/TelemetryDefinition;", "GetObtainTelemetryHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition ObtainTelemetry ()
		{
			const string __id = "obtainTelemetry.()Lcom/mapbox/mapboxsdk/maps/TelemetryDefinition;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
