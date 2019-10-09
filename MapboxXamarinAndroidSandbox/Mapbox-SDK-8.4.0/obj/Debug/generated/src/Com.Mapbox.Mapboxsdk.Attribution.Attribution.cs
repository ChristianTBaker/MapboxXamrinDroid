using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Attribution {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='Attribution']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/attribution/Attribution", DoNotGenerateAcw=true)]
	public partial class Attribution : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/attribution/Attribution", typeof (Attribution));
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

		protected Attribution (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.Attribution __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.Attribution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='Attribution']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitleAbbreviated;
#pragma warning disable 0169
		static Delegate GetGetTitleAbbreviatedHandler ()
		{
			if (cb_getTitleAbbreviated == null)
				cb_getTitleAbbreviated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleAbbreviated);
			return cb_getTitleAbbreviated;
		}

		static IntPtr n_GetTitleAbbreviated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.Attribution __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.Attribution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TitleAbbreviated);
		}
#pragma warning restore 0169

		public virtual unsafe string TitleAbbreviated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='Attribution']/method[@name='getTitleAbbreviated' and count(parameter)=0]"
			[Register ("getTitleAbbreviated", "()Ljava/lang/String;", "GetGetTitleAbbreviatedHandler")]
			get {
				const string __id = "getTitleAbbreviated.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.Attribution __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.Attribution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='Attribution']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
