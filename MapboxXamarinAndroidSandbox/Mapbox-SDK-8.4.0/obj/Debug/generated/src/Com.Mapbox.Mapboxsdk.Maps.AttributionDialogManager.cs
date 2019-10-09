using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='AttributionDialogManager']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/AttributionDialogManager", DoNotGenerateAcw=true)]
	public partial class AttributionDialogManager : global::Java.Lang.Object, global::Android.Content.IDialogInterfaceOnClickListener, global::Android.Views.View.IOnClickListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/AttributionDialogManager", typeof (AttributionDialogManager));
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

		protected AttributionDialogManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='AttributionDialogManager']/constructor[@name='AttributionDialogManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V", "")]
		public unsafe AttributionDialogManager (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onClick_Landroid_content_DialogInterface_I;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_content_DialogInterface_IHandler ()
		{
			if (cb_onClick_Landroid_content_DialogInterface_I == null)
				cb_onClick_Landroid_content_DialogInterface_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnClick_Landroid_content_DialogInterface_I);
			return cb_onClick_Landroid_content_DialogInterface_I;
		}

		static void n_OnClick_Landroid_content_DialogInterface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int which)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IDialogInterface dialog = (global::Android.Content.IDialogInterface)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterface> (native_dialog, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (dialog, which);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='AttributionDialogManager']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int']]"
		[Register ("onClick", "(Landroid/content/DialogInterface;I)V", "GetOnClick_Landroid_content_DialogInterface_IHandler")]
		public virtual unsafe void OnClick (global::Android.Content.IDialogInterface dialog, int which)
		{
			const string __id = "onClick.(Landroid/content/DialogInterface;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				__args [1] = new JniArgumentValue (which);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='AttributionDialogManager']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View view)
		{
			const string __id = "onClick.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='AttributionDialogManager']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			const string __id = "onStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_showAttributionDialog_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowAttributionDialog_arrayLjava_lang_String_Handler ()
		{
			if (cb_showAttributionDialog_arrayLjava_lang_String_ == null)
				cb_showAttributionDialog_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowAttributionDialog_arrayLjava_lang_String_);
			return cb_showAttributionDialog_arrayLjava_lang_String_;
		}

		static void n_ShowAttributionDialog_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attributionTitles)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] attributionTitles = (string[]) JNIEnv.GetArray (native_attributionTitles, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.ShowAttributionDialog (attributionTitles);
			if (attributionTitles != null)
				JNIEnv.CopyArray (attributionTitles, native_attributionTitles);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='AttributionDialogManager']/method[@name='showAttributionDialog' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("showAttributionDialog", "([Ljava/lang/String;)V", "GetShowAttributionDialog_arrayLjava_lang_String_Handler")]
		protected virtual unsafe void ShowAttributionDialog (string[] attributionTitles)
		{
			const string __id = "showAttributionDialog.([Ljava/lang/String;)V";
			IntPtr native_attributionTitles = JNIEnv.NewArray (attributionTitles);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attributionTitles);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (attributionTitles != null) {
					JNIEnv.CopyArray (native_attributionTitles, attributionTitles);
					JNIEnv.DeleteLocalRef (native_attributionTitles);
				}
			}
		}

	}
}
