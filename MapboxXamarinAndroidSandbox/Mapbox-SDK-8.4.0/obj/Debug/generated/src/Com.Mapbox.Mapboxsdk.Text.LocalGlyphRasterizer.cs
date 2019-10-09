using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.text']/class[@name='LocalGlyphRasterizer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/text/LocalGlyphRasterizer", DoNotGenerateAcw=true)]
	public partial class LocalGlyphRasterizer : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/text/LocalGlyphRasterizer", typeof (LocalGlyphRasterizer));
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

		protected LocalGlyphRasterizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_drawGlyphBitmap_Ljava_lang_String_ZC;
#pragma warning disable 0169
		static Delegate GetDrawGlyphBitmap_Ljava_lang_String_ZCHandler ()
		{
			if (cb_drawGlyphBitmap_Ljava_lang_String_ZC == null)
				cb_drawGlyphBitmap_Ljava_lang_String_ZC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, char, IntPtr>) n_DrawGlyphBitmap_Ljava_lang_String_ZC);
			return cb_drawGlyphBitmap_Ljava_lang_String_ZC;
		}

		static IntPtr n_DrawGlyphBitmap_Ljava_lang_String_ZC (IntPtr jnienv, IntPtr native__this, IntPtr native_fontFamily, bool bold, char glyphID)
		{
			global::Com.Mapbox.Mapboxsdk.Text.LocalGlyphRasterizer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Text.LocalGlyphRasterizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fontFamily = JNIEnv.GetString (native_fontFamily, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DrawGlyphBitmap (fontFamily, bold, glyphID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.text']/class[@name='LocalGlyphRasterizer']/method[@name='drawGlyphBitmap' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='char']]"
		[Register ("drawGlyphBitmap", "(Ljava/lang/String;ZC)Landroid/graphics/Bitmap;", "GetDrawGlyphBitmap_Ljava_lang_String_ZCHandler")]
		protected virtual unsafe global::Android.Graphics.Bitmap DrawGlyphBitmap (string fontFamily, bool bold, char glyphID)
		{
			const string __id = "drawGlyphBitmap.(Ljava/lang/String;ZC)Landroid/graphics/Bitmap;";
			IntPtr native_fontFamily = JNIEnv.NewString (fontFamily);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_fontFamily);
				__args [1] = new JniArgumentValue (bold);
				__args [2] = new JniArgumentValue (glyphID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fontFamily);
			}
		}

	}
}
