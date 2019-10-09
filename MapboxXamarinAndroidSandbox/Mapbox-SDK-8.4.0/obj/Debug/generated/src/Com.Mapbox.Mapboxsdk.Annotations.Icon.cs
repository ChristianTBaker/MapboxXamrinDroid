using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Icon']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/Icon", DoNotGenerateAcw=true)]
	public partial class Icon : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/Icon", typeof (Icon));
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

		protected Icon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBitmap;
#pragma warning disable 0169
		static Delegate GetGetBitmapHandler ()
		{
			if (cb_getBitmap == null)
				cb_getBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmap);
			return cb_getBitmap;
		}

		static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Icon __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Icon']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				const string __id = "getBitmap.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Annotations.Icon __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Icon']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_getScale;
#pragma warning disable 0169
		static Delegate GetGetScaleHandler ()
		{
			if (cb_getScale == null)
				cb_getScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScale);
			return cb_getScale;
		}

		static float n_GetScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Icon __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scale;
		}
#pragma warning restore 0169

		public virtual unsafe float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Icon']/method[@name='getScale' and count(parameter)=0]"
			[Register ("getScale", "()F", "GetGetScaleHandler")]
			get {
				const string __id = "getScale.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_toBytes;
#pragma warning disable 0169
		static Delegate GetToBytesHandler ()
		{
			if (cb_toBytes == null)
				cb_toBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBytes);
			return cb_toBytes;
		}

		static IntPtr n_ToBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Icon __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToBytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Icon']/method[@name='toBytes' and count(parameter)=0]"
		[Register ("toBytes", "()[B", "GetToBytesHandler")]
		public virtual unsafe byte[] ToBytes ()
		{
			const string __id = "toBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
