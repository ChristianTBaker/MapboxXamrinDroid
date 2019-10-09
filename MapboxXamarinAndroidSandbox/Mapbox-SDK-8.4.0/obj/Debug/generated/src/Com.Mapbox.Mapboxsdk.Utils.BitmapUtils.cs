using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/BitmapUtils", DoNotGenerateAcw=true)]
	public partial class BitmapUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/BitmapUtils", typeof (BitmapUtils));
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

		protected BitmapUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']/constructor[@name='BitmapUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']/method[@name='createBitmapFromView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("createBitmapFromView", "(Landroid/view/View;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateBitmapFromView (global::Android.Views.View view)
		{
			const string __id = "createBitmapFromView.(Landroid/view/View;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("equals", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)Z", "")]
		public static new unsafe bool Equals (global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Bitmap other)
		{
			const string __id = "equals.(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']/method[@name='getBitmapFromDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("getBitmapFromDrawable", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmapFromDrawable (global::Android.Graphics.Drawables.Drawable sourceDrawable)
		{
			const string __id = "getBitmapFromDrawable.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sourceDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sourceDrawable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']/method[@name='getByteArrayFromDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("getByteArrayFromDrawable", "(Landroid/graphics/drawable/Drawable;)[B", "")]
		public static unsafe byte[] GetByteArrayFromDrawable (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "getByteArrayFromDrawable.(Landroid/graphics/drawable/Drawable;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']/method[@name='getDrawableFromByteArray' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]']]"
		[Register ("getDrawableFromByteArray", "(Landroid/content/Context;[B)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetDrawableFromByteArray (global::Android.Content.Context context, byte[] array)
		{
			const string __id = "getDrawableFromByteArray.(Landroid/content/Context;[B)Landroid/graphics/drawable/Drawable;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']/method[@name='getDrawableFromRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getDrawableFromRes", "(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetDrawableFromRes (global::Android.Content.Context context, int drawableRes)
		{
			const string __id = "getDrawableFromRes.(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (drawableRes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']/method[@name='getDrawableFromRes' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("getDrawableFromRes", "(Landroid/content/Context;ILjava/lang/Integer;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetDrawableFromRes (global::Android.Content.Context context, int drawableRes, global::Java.Lang.Integer tintColor)
		{
			const string __id = "getDrawableFromRes.(Landroid/content/Context;ILjava/lang/Integer;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (drawableRes);
				__args [2] = new JniArgumentValue ((tintColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tintColor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='BitmapUtils']/method[@name='mergeBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("mergeBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap MergeBitmap (global::Android.Graphics.Bitmap background, global::Android.Graphics.Bitmap foreground)
		{
			const string __id = "mergeBitmap.(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((background == null) ? IntPtr.Zero : ((global::Java.Lang.Object) background).Handle);
				__args [1] = new JniArgumentValue ((foreground == null) ? IntPtr.Zero : ((global::Java.Lang.Object) foreground).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
