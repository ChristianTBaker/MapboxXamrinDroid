using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='FileAttachment']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/FileAttachment", DoNotGenerateAcw=true)]
	public partial class FileAttachment : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/FileAttachment", typeof (FileAttachment));
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

		protected FileAttachment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAttachmentMetadata;
#pragma warning disable 0169
		static Delegate GetGetAttachmentMetadataHandler ()
		{
			if (cb_getAttachmentMetadata == null)
				cb_getAttachmentMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttachmentMetadata);
			return cb_getAttachmentMetadata;
		}

		static IntPtr n_GetAttachmentMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.FileAttachment __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.FileAttachment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AttachmentMetadata);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Android.Telemetry.AttachmentMetadata AttachmentMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='FileAttachment']/method[@name='getAttachmentMetadata' and count(parameter)=0]"
			[Register ("getAttachmentMetadata", "()Lcom/mapbox/android/telemetry/AttachmentMetadata;", "GetGetAttachmentMetadataHandler")]
			get {
				const string __id = "getAttachmentMetadata.()Lcom/mapbox/android/telemetry/AttachmentMetadata;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFileData;
#pragma warning disable 0169
		static Delegate GetGetFileDataHandler ()
		{
			if (cb_getFileData == null)
				cb_getFileData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileData);
			return cb_getFileData;
		}

		static IntPtr n_GetFileData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.FileAttachment __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.FileAttachment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileData);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object FileData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='FileAttachment']/method[@name='getFileData' and count(parameter)=0]"
			[Register ("getFileData", "()Ljava/lang/Object;", "GetGetFileDataHandler")]
			get {
				const string __id = "getFileData.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
