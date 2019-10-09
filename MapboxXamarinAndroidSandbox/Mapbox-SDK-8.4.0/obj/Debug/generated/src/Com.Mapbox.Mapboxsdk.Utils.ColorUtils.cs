using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/ColorUtils", DoNotGenerateAcw=true)]
	public partial class ColorUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/ColorUtils", typeof (ColorUtils));
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

		protected ColorUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/constructor[@name='ColorUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/method[@name='colorToGlRgbaArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("colorToGlRgbaArray", "(I)[F", "")]
		public static unsafe float[] ColorToGlRgbaArray (int color)
		{
			const string __id = "colorToGlRgbaArray.(I)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/method[@name='colorToRgbaArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("colorToRgbaArray", "(I)[F", "")]
		public static unsafe float[] ColorToRgbaArray (int color)
		{
			const string __id = "colorToRgbaArray.(I)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/method[@name='colorToRgbaString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("colorToRgbaString", "(I)Ljava/lang/String;", "")]
		public static unsafe string ColorToRgbaString (int color)
		{
			const string __id = "colorToRgbaString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/method[@name='getAccentColor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAccentColor", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetAccentColor (global::Android.Content.Context context)
		{
			const string __id = "getAccentColor.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/method[@name='getPrimaryColor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPrimaryColor", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetPrimaryColor (global::Android.Content.Context context)
		{
			const string __id = "getPrimaryColor.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/method[@name='getPrimaryDarkColor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPrimaryDarkColor", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetPrimaryDarkColor (global::Android.Content.Context context)
		{
			const string __id = "getPrimaryDarkColor.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/method[@name='getSelector' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSelector", "(I)Landroid/content/res/ColorStateList;", "")]
		public static unsafe global::Android.Content.Res.ColorStateList GetSelector (int color)
		{
			const string __id = "getSelector.(I)Landroid/content/res/ColorStateList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/method[@name='rgbaToColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rgbaToColor", "(Ljava/lang/String;)I", "")]
		public static unsafe int RgbaToColor (string value)
		{
			const string __id = "rgbaToColor.(Ljava/lang/String;)I";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='ColorUtils']/method[@name='setTintList' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int']]"
		[Register ("setTintList", "(Landroid/widget/ImageView;I)V", "")]
		public static unsafe void SetTintList (global::Android.Widget.ImageView imageView, int tintColor)
		{
			const string __id = "setTintList.(Landroid/widget/ImageView;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((imageView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageView).Handle);
				__args [1] = new JniArgumentValue (tintColor);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
