using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Attribution {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/attribution/AttributionMeasure", DoNotGenerateAcw=true)]
	public partial class AttributionMeasure : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure.Builder']/constructor[@name='AttributionMeasure.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure Build ()
			{
				const string __id = "build.()Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setLogo_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetSetLogo_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_setLogo_Landroid_graphics_Bitmap_ == null)
					cb_setLogo_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLogo_Landroid_graphics_Bitmap_);
				return cb_setLogo_Landroid_graphics_Bitmap_;
			}

			static IntPtr n_SetLogo_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logo)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap logo = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_logo, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLogo (logo));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure.Builder']/method[@name='setLogo' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setLogo", "(Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;", "GetSetLogo_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder SetLogo (global::Android.Graphics.Bitmap logo)
			{
				const string __id = "setLogo.(Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((logo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logo).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setLogoSmall_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetSetLogoSmall_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_setLogoSmall_Landroid_graphics_Bitmap_ == null)
					cb_setLogoSmall_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLogoSmall_Landroid_graphics_Bitmap_);
				return cb_setLogoSmall_Landroid_graphics_Bitmap_;
			}

			static IntPtr n_SetLogoSmall_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logoSmall)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap logoSmall = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_logoSmall, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLogoSmall (logoSmall));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure.Builder']/method[@name='setLogoSmall' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setLogoSmall", "(Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;", "GetSetLogoSmall_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder SetLogoSmall (global::Android.Graphics.Bitmap logoSmall)
			{
				const string __id = "setLogoSmall.(Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((logoSmall == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logoSmall).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMarginPadding_F;
#pragma warning disable 0169
			static Delegate GetSetMarginPadding_FHandler ()
			{
				if (cb_setMarginPadding_F == null)
					cb_setMarginPadding_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetMarginPadding_F);
				return cb_setMarginPadding_F;
			}

			static IntPtr n_SetMarginPadding_F (IntPtr jnienv, IntPtr native__this, float marginPadding)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetMarginPadding (marginPadding));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure.Builder']/method[@name='setMarginPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMarginPadding", "(F)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;", "GetSetMarginPadding_FHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder SetMarginPadding (float marginPadding)
			{
				const string __id = "setMarginPadding.(F)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (marginPadding);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSnapshot_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetSetSnapshot_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_setSnapshot_Landroid_graphics_Bitmap_ == null)
					cb_setSnapshot_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSnapshot_Landroid_graphics_Bitmap_);
				return cb_setSnapshot_Landroid_graphics_Bitmap_;
			}

			static IntPtr n_SetSnapshot_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_snapshot)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap snapshot = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_snapshot, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSnapshot (snapshot));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure.Builder']/method[@name='setSnapshot' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setSnapshot", "(Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;", "GetSetSnapshot_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder SetSnapshot (global::Android.Graphics.Bitmap snapshot)
			{
				const string __id = "setSnapshot.(Landroid/graphics/Bitmap;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((snapshot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) snapshot).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setTextView_Landroid_widget_TextView_;
#pragma warning disable 0169
			static Delegate GetSetTextView_Landroid_widget_TextView_Handler ()
			{
				if (cb_setTextView_Landroid_widget_TextView_ == null)
					cb_setTextView_Landroid_widget_TextView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTextView_Landroid_widget_TextView_);
				return cb_setTextView_Landroid_widget_TextView_;
			}

			static IntPtr n_SetTextView_Landroid_widget_TextView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textView)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.TextView textView = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_textView, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTextView (textView));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure.Builder']/method[@name='setTextView' and count(parameter)=1 and parameter[1][@type='android.widget.TextView']]"
			[Register ("setTextView", "(Landroid/widget/TextView;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;", "GetSetTextView_Landroid_widget_TextView_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder SetTextView (global::Android.Widget.TextView textView)
			{
				const string __id = "setTextView.(Landroid/widget/TextView;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((textView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textView).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setTextViewShort_Landroid_widget_TextView_;
#pragma warning disable 0169
			static Delegate GetSetTextViewShort_Landroid_widget_TextView_Handler ()
			{
				if (cb_setTextViewShort_Landroid_widget_TextView_ == null)
					cb_setTextViewShort_Landroid_widget_TextView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTextViewShort_Landroid_widget_TextView_);
				return cb_setTextViewShort_Landroid_widget_TextView_;
			}

			static IntPtr n_SetTextViewShort_Landroid_widget_TextView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textViewShort)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.TextView textViewShort = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_textViewShort, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTextViewShort (textViewShort));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure.Builder']/method[@name='setTextViewShort' and count(parameter)=1 and parameter[1][@type='android.widget.TextView']]"
			[Register ("setTextViewShort", "(Landroid/widget/TextView;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;", "GetSetTextViewShort_Landroid_widget_TextView_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder SetTextViewShort (global::Android.Widget.TextView textViewShort)
			{
				const string __id = "setTextViewShort.(Landroid/widget/TextView;)Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((textViewShort == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textViewShort).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/interface[@name='AttributionMeasure.Command']"
		[Register ("com/mapbox/mapboxsdk/attribution/AttributionMeasure$Command", "", "Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure/ICommandInvoker")]
		public partial interface ICommand : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/interface[@name='AttributionMeasure.Command']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.attribution.AttributionMeasure']]"
			[Register ("execute", "(Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure;)Lcom/mapbox/mapboxsdk/attribution/AttributionLayout;", "GetExecute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_Handler:Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure/ICommandInvoker, Mapbox-SDK-8.4.0")]
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout Execute (global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/attribution/AttributionMeasure$Command", DoNotGenerateAcw=true)]
		internal class ICommandInvoker : global::Java.Lang.Object, ICommand {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/attribution/AttributionMeasure$Command", typeof (ICommandInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICommand GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICommand> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.attribution.AttributionMeasure.Command"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_;
#pragma warning disable 0169
			static Delegate GetExecute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_Handler ()
			{
				if (cb_execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_ == null)
					cb_execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_);
				return cb_execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_;
			}

			static IntPtr n_Execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.ICommand __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_;
			public unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout Execute (global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure p0)
			{
				if (id_execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_ == IntPtr.Zero)
					id_execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/mapbox/mapboxsdk/attribution/AttributionMeasure;)Lcom/mapbox/mapboxsdk/attribution/AttributionLayout;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute_Lcom_mapbox_mapboxsdk_attribution_AttributionMeasure_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/attribution/AttributionMeasure", typeof (AttributionMeasure));
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

		protected AttributionMeasure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getTextView;
#pragma warning disable 0169
		static Delegate GetGetTextViewHandler ()
		{
			if (cb_getTextView == null)
				cb_getTextView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextView);
			return cb_getTextView;
		}

		static IntPtr n_GetTextView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.TextView TextView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure']/method[@name='getTextView' and count(parameter)=0]"
			[Register ("getTextView", "()Landroid/widget/TextView;", "GetGetTextViewHandler")]
			get {
				const string __id = "getTextView.()Landroid/widget/TextView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_measure;
#pragma warning disable 0169
		static Delegate GetMeasureHandler ()
		{
			if (cb_measure == null)
				cb_measure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Measure);
			return cb_measure;
		}

		static IntPtr n_Measure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Measure ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionMeasure']/method[@name='measure' and count(parameter)=0]"
		[Register ("measure", "()Lcom/mapbox/mapboxsdk/attribution/AttributionLayout;", "GetMeasureHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout Measure ()
		{
			const string __id = "measure.()Lcom/mapbox/mapboxsdk/attribution/AttributionLayout;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
