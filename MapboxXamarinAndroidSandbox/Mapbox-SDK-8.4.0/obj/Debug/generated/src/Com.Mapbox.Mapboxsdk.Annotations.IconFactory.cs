using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='IconFactory']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/IconFactory", DoNotGenerateAcw=true)]
	public sealed partial class IconFactory : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/IconFactory", typeof (IconFactory));
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

		internal IconFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='IconFactory']/method[@name='defaultMarker' and count(parameter)=0]"
		[Register ("defaultMarker", "()Lcom/mapbox/mapboxsdk/annotations/Icon;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Icon DefaultMarker ()
		{
			const string __id = "defaultMarker.()Lcom/mapbox/mapboxsdk/annotations/Icon;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='IconFactory']/method[@name='fromAsset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAsset", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/Icon;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Icon FromAsset (string assetName)
		{
			const string __id = "fromAsset.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/Icon;";
			IntPtr native_assetName = JNIEnv.NewString (assetName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_assetName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_assetName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='IconFactory']/method[@name='fromBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/annotations/Icon;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Icon FromBitmap (global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "fromBitmap.(Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/annotations/Icon;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='IconFactory']/method[@name='fromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromFile", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/Icon;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Icon FromFile (string fileName)
		{
			const string __id = "fromFile.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/Icon;";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='IconFactory']/method[@name='fromPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromPath", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/Icon;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Icon FromPath (string absolutePath)
		{
			const string __id = "fromPath.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/Icon;";
			IntPtr native_absolutePath = JNIEnv.NewString (absolutePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_absolutePath);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_absolutePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='IconFactory']/method[@name='fromResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromResource", "(I)Lcom/mapbox/mapboxsdk/annotations/Icon;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Icon FromResource (int resourceId)
		{
			const string __id = "fromResource.(I)Lcom/mapbox/mapboxsdk/annotations/Icon;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='IconFactory']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/annotations/IconFactory;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Annotations.IconFactory GetInstance (global::Android.Content.Context context)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/annotations/IconFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.IconFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='IconFactory']/method[@name='recreate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("recreate", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/annotations/Icon;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Icon Recreate (string iconId, global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "recreate.(Ljava/lang/String;Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/annotations/Icon;";
			IntPtr native_iconId = JNIEnv.NewString (iconId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_iconId);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_iconId);
			}
		}

	}
}
