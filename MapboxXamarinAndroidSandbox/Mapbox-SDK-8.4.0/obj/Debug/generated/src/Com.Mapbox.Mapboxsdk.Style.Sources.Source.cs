using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/Source", DoNotGenerateAcw=true)]
	public abstract partial class Source : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/field[@name='detached']"
		[Register ("detached")]
		protected bool Detached {
			get {
				const string __id = "detached.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "detached.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/Source", typeof (Source));
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

		protected Source (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/constructor[@name='Source' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Source ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/constructor[@name='Source' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe Source (long nativePtr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativePtr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAttribution;
#pragma warning disable 0169
		static Delegate GetGetAttributionHandler ()
		{
			if (cb_getAttribution == null)
				cb_getAttribution = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttribution);
			return cb_getAttribution;
		}

		static IntPtr n_GetAttribution (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.Source __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Attribution);
		}
#pragma warning restore 0169

		public virtual unsafe string Attribution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/method[@name='getAttribution' and count(parameter)=0]"
			[Register ("getAttribution", "()Ljava/lang/String;", "GetGetAttributionHandler")]
			get {
				const string __id = "getAttribution.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.Source __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNativePtr;
#pragma warning disable 0169
		static Delegate GetGetNativePtrHandler ()
		{
			if (cb_getNativePtr == null)
				cb_getNativePtr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativePtr);
			return cb_getNativePtr;
		}

		static long n_GetNativePtr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.Source __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativePtr;
		}
#pragma warning restore 0169

		public virtual unsafe long NativePtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/method[@name='getNativePtr' and count(parameter)=0]"
			[Register ("getNativePtr", "()J", "GetGetNativePtrHandler")]
			get {
				const string __id = "getNativePtr.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_checkThread;
#pragma warning disable 0169
		static Delegate GetCheckThreadHandler ()
		{
			if (cb_checkThread == null)
				cb_checkThread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckThread);
			return cb_checkThread;
		}

		static void n_CheckThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.Source __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckThread ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/method[@name='checkThread' and count(parameter)=0]"
		[Register ("checkThread", "()V", "GetCheckThreadHandler")]
		protected virtual unsafe void CheckThread ()
		{
			const string __id = "checkThread.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_nativeGetAttribution;
#pragma warning disable 0169
		static Delegate GetNativeGetAttributionHandler ()
		{
			if (cb_nativeGetAttribution == null)
				cb_nativeGetAttribution = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NativeGetAttribution);
			return cb_nativeGetAttribution;
		}

		static IntPtr n_NativeGetAttribution (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.Source __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NativeGetAttribution ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/method[@name='nativeGetAttribution' and count(parameter)=0]"
		[Register ("nativeGetAttribution", "()Ljava/lang/String;", "GetNativeGetAttributionHandler")]
		protected virtual unsafe string NativeGetAttribution ()
		{
			const string __id = "nativeGetAttribution.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nativeGetId;
#pragma warning disable 0169
		static Delegate GetNativeGetIdHandler ()
		{
			if (cb_nativeGetId == null)
				cb_nativeGetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NativeGetId);
			return cb_nativeGetId;
		}

		static IntPtr n_NativeGetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.Source __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NativeGetId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/method[@name='nativeGetId' and count(parameter)=0]"
		[Register ("nativeGetId", "()Ljava/lang/String;", "GetNativeGetIdHandler")]
		protected virtual unsafe string NativeGetId ()
		{
			const string __id = "nativeGetId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDetached;
#pragma warning disable 0169
		static Delegate GetSetDetachedHandler ()
		{
			if (cb_setDetached == null)
				cb_setDetached = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetDetached);
			return cb_setDetached;
		}

		static void n_SetDetached (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.Source __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDetached ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='Source']/method[@name='setDetached' and count(parameter)=0]"
		[Register ("setDetached", "()V", "GetSetDetachedHandler")]
		public virtual unsafe void SetDetached ()
		{
			const string __id = "setDetached.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/Source", DoNotGenerateAcw=true)]
	internal partial class SourceInvoker : Source {

		public SourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/style/sources/Source", typeof (SourceInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
