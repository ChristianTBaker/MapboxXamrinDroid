using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySourceOptions']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions", DoNotGenerateAcw=true)]
	public partial class CustomGeometrySourceOptions : global::Java.Util.HashMap {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions", typeof (CustomGeometrySourceOptions));
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

		protected CustomGeometrySourceOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySourceOptions']/constructor[@name='CustomGeometrySourceOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomGeometrySourceOptions ()
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

		static Delegate cb_withBuffer_I;
#pragma warning disable 0169
		static Delegate GetWithBuffer_IHandler ()
		{
			if (cb_withBuffer_I == null)
				cb_withBuffer_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithBuffer_I);
			return cb_withBuffer_I;
		}

		static IntPtr n_WithBuffer_I (IntPtr jnienv, IntPtr native__this, int buffer)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithBuffer (buffer));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySourceOptions']/method[@name='withBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withBuffer", "(I)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;", "GetWithBuffer_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions WithBuffer (int buffer)
		{
			const string __id = "withBuffer.(I)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (buffer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withClip_Z;
#pragma warning disable 0169
		static Delegate GetWithClip_ZHandler ()
		{
			if (cb_withClip_Z == null)
				cb_withClip_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithClip_Z);
			return cb_withClip_Z;
		}

		static IntPtr n_WithClip_Z (IntPtr jnienv, IntPtr native__this, bool clip)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithClip (clip));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySourceOptions']/method[@name='withClip' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withClip", "(Z)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;", "GetWithClip_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions WithClip (bool clip)
		{
			const string __id = "withClip.(Z)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (clip);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withMaxZoom_I;
#pragma warning disable 0169
		static Delegate GetWithMaxZoom_IHandler ()
		{
			if (cb_withMaxZoom_I == null)
				cb_withMaxZoom_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithMaxZoom_I);
			return cb_withMaxZoom_I;
		}

		static IntPtr n_WithMaxZoom_I (IntPtr jnienv, IntPtr native__this, int maxZoom)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithMaxZoom (maxZoom));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySourceOptions']/method[@name='withMaxZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withMaxZoom", "(I)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;", "GetWithMaxZoom_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions WithMaxZoom (int maxZoom)
		{
			const string __id = "withMaxZoom.(I)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxZoom);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withMinZoom_I;
#pragma warning disable 0169
		static Delegate GetWithMinZoom_IHandler ()
		{
			if (cb_withMinZoom_I == null)
				cb_withMinZoom_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithMinZoom_I);
			return cb_withMinZoom_I;
		}

		static IntPtr n_WithMinZoom_I (IntPtr jnienv, IntPtr native__this, int minZoom)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithMinZoom (minZoom));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySourceOptions']/method[@name='withMinZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withMinZoom", "(I)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;", "GetWithMinZoom_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions WithMinZoom (int minZoom)
		{
			const string __id = "withMinZoom.(I)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minZoom);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withTolerance_F;
#pragma warning disable 0169
		static Delegate GetWithTolerance_FHandler ()
		{
			if (cb_withTolerance_F == null)
				cb_withTolerance_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_WithTolerance_F);
			return cb_withTolerance_F;
		}

		static IntPtr n_WithTolerance_F (IntPtr jnienv, IntPtr native__this, float tolerance)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTolerance (tolerance));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySourceOptions']/method[@name='withTolerance' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("withTolerance", "(F)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;", "GetWithTolerance_FHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions WithTolerance (float tolerance)
		{
			const string __id = "withTolerance.(F)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tolerance);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withWrap_Z;
#pragma warning disable 0169
		static Delegate GetWithWrap_ZHandler ()
		{
			if (cb_withWrap_Z == null)
				cb_withWrap_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithWrap_Z);
			return cb_withWrap_Z;
		}

		static IntPtr n_WithWrap_Z (IntPtr jnienv, IntPtr native__this, bool wrap)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithWrap (wrap));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySourceOptions']/method[@name='withWrap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withWrap", "(Z)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;", "GetWithWrap_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions WithWrap (bool wrap)
		{
			const string __id = "withWrap.(Z)Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (wrap);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
