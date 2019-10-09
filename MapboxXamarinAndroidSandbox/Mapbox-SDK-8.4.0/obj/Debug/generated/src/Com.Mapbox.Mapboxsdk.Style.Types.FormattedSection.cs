using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/types/FormattedSection", DoNotGenerateAcw=true)]
	public partial class FormattedSection : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/types/FormattedSection", typeof (FormattedSection));
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

		protected FormattedSection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/constructor[@name='FormattedSection' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe FormattedSection (string text)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/constructor[@name='FormattedSection' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Number;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe FormattedSection (string text, global::Java.Lang.Number fontScale)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Number;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((fontScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fontScale).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/constructor[@name='FormattedSection' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='java.lang.String[]']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Number;[Ljava/lang/String;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe FormattedSection (string text, global::Java.Lang.Number fontScale, string[] fontStack)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Number;[Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_fontStack = JNIEnv.NewArray (fontStack);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((fontScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fontScale).Handle);
				__args [2] = new JniArgumentValue (native_fontStack);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				if (fontStack != null) {
					JNIEnv.CopyArray (native_fontStack, fontStack);
					JNIEnv.DeleteLocalRef (native_fontStack);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/constructor[@name='FormattedSection' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Number;[Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FormattedSection (string text, global::Java.Lang.Number fontScale, string[] fontStack, string textColor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Number;[Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_fontStack = JNIEnv.NewArray (fontStack);
			IntPtr native_textColor = JNIEnv.NewString (textColor);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((fontScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fontScale).Handle);
				__args [2] = new JniArgumentValue (native_fontStack);
				__args [3] = new JniArgumentValue (native_textColor);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				if (fontStack != null) {
					JNIEnv.CopyArray (native_fontStack, fontStack);
					JNIEnv.DeleteLocalRef (native_fontStack);
				}
				JNIEnv.DeleteLocalRef (native_textColor);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/constructor[@name='FormattedSection' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register (".ctor", "(Ljava/lang/String;[Ljava/lang/String;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe FormattedSection (string text, string[] fontStack)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			IntPtr native_fontStack = JNIEnv.NewArray (fontStack);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_fontStack);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				if (fontStack != null) {
					JNIEnv.CopyArray (native_fontStack, fontStack);
					JNIEnv.DeleteLocalRef (native_fontStack);
				}
			}
		}

		static Delegate cb_getFontScale;
#pragma warning disable 0169
		static Delegate GetGetFontScaleHandler ()
		{
			if (cb_getFontScale == null)
				cb_getFontScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFontScale);
			return cb_getFontScale;
		}

		static IntPtr n_GetFontScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FontScale);
		}
#pragma warning restore 0169

		static Delegate cb_setFontScale_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetSetFontScale_Ljava_lang_Number_Handler ()
		{
			if (cb_setFontScale_Ljava_lang_Number_ == null)
				cb_setFontScale_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFontScale_Ljava_lang_Number_);
			return cb_setFontScale_Ljava_lang_Number_;
		}

		static void n_SetFontScale_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fontScale)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number fontScale = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_fontScale, JniHandleOwnership.DoNotTransfer);
			__this.FontScale = fontScale;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Number FontScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/method[@name='getFontScale' and count(parameter)=0]"
			[Register ("getFontScale", "()Ljava/lang/Number;", "GetGetFontScaleHandler")]
			get {
				const string __id = "getFontScale.()Ljava/lang/Number;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/method[@name='setFontScale' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
			[Register ("setFontScale", "(Ljava/lang/Number;)V", "GetSetFontScale_Ljava_lang_Number_Handler")]
			set {
				const string __id = "setFontScale.(Ljava/lang/Number;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextColor);
			return cb_getTextColor;
		}

		static IntPtr n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TextColor);
		}
#pragma warning restore 0169

		static Delegate cb_setTextColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTextColor_Ljava_lang_String_Handler ()
		{
			if (cb_setTextColor_Ljava_lang_String_ == null)
				cb_setTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextColor_Ljava_lang_String_);
			return cb_setTextColor_Ljava_lang_String_;
		}

		static void n_SetTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textColor)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string textColor = JNIEnv.GetString (native_textColor, JniHandleOwnership.DoNotTransfer);
			__this.TextColor = textColor;
		}
#pragma warning restore 0169

		public virtual unsafe string TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()Ljava/lang/String;", "GetGetTextColorHandler")]
			get {
				const string __id = "getTextColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTextColor", "(Ljava/lang/String;)V", "GetSetTextColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTextColor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFontStack;
#pragma warning disable 0169
		static Delegate GetGetFontStackHandler ()
		{
			if (cb_getFontStack == null)
				cb_getFontStack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFontStack);
			return cb_getFontStack;
		}

		static IntPtr n_GetFontStack (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFontStack ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/method[@name='getFontStack' and count(parameter)=0]"
		[Register ("getFontStack", "()[Ljava/lang/String;", "GetGetFontStackHandler")]
		public virtual unsafe string[] GetFontStack ()
		{
			const string __id = "getFontStack.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setFontStack_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFontStack_arrayLjava_lang_String_Handler ()
		{
			if (cb_setFontStack_arrayLjava_lang_String_ == null)
				cb_setFontStack_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFontStack_arrayLjava_lang_String_);
			return cb_setFontStack_arrayLjava_lang_String_;
		}

		static void n_SetFontStack_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fontStack)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] fontStack = (string[]) JNIEnv.GetArray (native_fontStack, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetFontStack (fontStack);
			if (fontStack != null)
				JNIEnv.CopyArray (fontStack, native_fontStack);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/method[@name='setFontStack' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setFontStack", "([Ljava/lang/String;)V", "GetSetFontStack_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetFontStack (string[] fontStack)
		{
			const string __id = "setFontStack.([Ljava/lang/String;)V";
			IntPtr native_fontStack = JNIEnv.NewArray (fontStack);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fontStack);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (fontStack != null) {
					JNIEnv.CopyArray (native_fontStack, fontStack);
					JNIEnv.DeleteLocalRef (native_fontStack);
				}
			}
		}

		static Delegate cb_setTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextColor_IHandler ()
		{
			if (cb_setTextColor_I == null)
				cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextColor_I);
			return cb_setTextColor_I;
		}

		static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int textColor)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColor (textColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='FormattedSection']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
		public virtual unsafe void SetTextColor (int textColor)
		{
			const string __id = "setTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
