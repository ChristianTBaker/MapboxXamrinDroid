using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Permissions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core.permissions']/class[@name='PermissionsManager']"
	[global::Android.Runtime.Register ("com/mapbox/android/core/permissions/PermissionsManager", DoNotGenerateAcw=true)]
	public partial class PermissionsManager : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/permissions/PermissionsManager", typeof (PermissionsManager));
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

		protected PermissionsManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.core.permissions']/class[@name='PermissionsManager']/constructor[@name='PermissionsManager' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.core.permissions.PermissionsListener']]"
		[Register (".ctor", "(Lcom/mapbox/android/core/permissions/PermissionsListener;)V", "")]
		public unsafe PermissionsManager (global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/mapbox/android/core/permissions/PermissionsListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Permissions.PermissionsManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Permissions.PermissionsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		static Delegate cb_setListener_Lcom_mapbox_android_core_permissions_PermissionsListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_mapbox_android_core_permissions_PermissionsListener_Handler ()
		{
			if (cb_setListener_Lcom_mapbox_android_core_permissions_PermissionsListener_ == null)
				cb_setListener_Lcom_mapbox_android_core_permissions_PermissionsListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_mapbox_android_core_permissions_PermissionsListener_);
			return cb_setListener_Lcom_mapbox_android_core_permissions_PermissionsListener_;
		}

		static void n_SetListener_Lcom_mapbox_android_core_permissions_PermissionsListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Core.Permissions.PermissionsManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Permissions.PermissionsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener listener = (global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Listener = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.permissions']/class[@name='PermissionsManager']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/mapbox/android/core/permissions/PermissionsListener;", "GetGetListenerHandler")]
			get {
				const string __id = "getListener.()Lcom/mapbox/android/core/permissions/PermissionsListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.permissions']/class[@name='PermissionsManager']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.core.permissions.PermissionsListener']]"
			[Register ("setListener", "(Lcom/mapbox/android/core/permissions/PermissionsListener;)V", "GetSetListener_Lcom_mapbox_android_core_permissions_PermissionsListener_Handler")]
			set {
				const string __id = "setListener.(Lcom/mapbox/android/core/permissions/PermissionsListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.permissions']/class[@name='PermissionsManager']/method[@name='areLocationPermissionsGranted' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("areLocationPermissionsGranted", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool AreLocationPermissionsGranted (global::Android.Content.Context context)
		{
			const string __id = "areLocationPermissionsGranted.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.permissions']/class[@name='PermissionsManager']/method[@name='areRuntimePermissionsRequired' and count(parameter)=0]"
		[Register ("areRuntimePermissionsRequired", "()Z", "")]
		public static unsafe bool AreRuntimePermissionsRequired ()
		{
			const string __id = "areRuntimePermissionsRequired.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
				cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI);
			return cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, int requestCode, IntPtr native_permissions, IntPtr native_grantResults)
		{
			global::Com.Mapbox.Android.Core.Permissions.PermissionsManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Permissions.PermissionsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] permissions = (string[]) JNIEnv.GetArray (native_permissions, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] grantResults = (int[]) JNIEnv.GetArray (native_grantResults, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnRequestPermissionsResult (requestCode, permissions, grantResults);
			if (permissions != null)
				JNIEnv.CopyArray (permissions, native_permissions);
			if (grantResults != null)
				JNIEnv.CopyArray (grantResults, native_grantResults);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.permissions']/class[@name='PermissionsManager']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
		[Register ("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe void OnRequestPermissionsResult (int requestCode, string[] permissions, int[] grantResults)
		{
			const string __id = "onRequestPermissionsResult.(I[Ljava/lang/String;[I)V";
			IntPtr native_permissions = JNIEnv.NewArray (permissions);
			IntPtr native_grantResults = JNIEnv.NewArray (grantResults);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (requestCode);
				__args [1] = new JniArgumentValue (native_permissions);
				__args [2] = new JniArgumentValue (native_grantResults);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (permissions != null) {
					JNIEnv.CopyArray (native_permissions, permissions);
					JNIEnv.DeleteLocalRef (native_permissions);
				}
				if (grantResults != null) {
					JNIEnv.CopyArray (native_grantResults, grantResults);
					JNIEnv.DeleteLocalRef (native_grantResults);
				}
			}
		}

		static Delegate cb_requestLocationPermissions_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetRequestLocationPermissions_Landroid_app_Activity_Handler ()
		{
			if (cb_requestLocationPermissions_Landroid_app_Activity_ == null)
				cb_requestLocationPermissions_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestLocationPermissions_Landroid_app_Activity_);
			return cb_requestLocationPermissions_Landroid_app_Activity_;
		}

		static void n_RequestLocationPermissions_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.Mapbox.Android.Core.Permissions.PermissionsManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Permissions.PermissionsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocationPermissions (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.permissions']/class[@name='PermissionsManager']/method[@name='requestLocationPermissions' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("requestLocationPermissions", "(Landroid/app/Activity;)V", "GetRequestLocationPermissions_Landroid_app_Activity_Handler")]
		public virtual unsafe void RequestLocationPermissions (global::Android.App.Activity activity)
		{
			const string __id = "requestLocationPermissions.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mapbox.Android.Core.Permissions.IPermissionsListener"

		global::Com.Mapbox.Android.Core.Permissions.IPermissionsListenerImplementor __CreateIPermissionsListenerImplementor ()
		{
			return new global::Com.Mapbox.Android.Core.Permissions.IPermissionsListenerImplementor (this);
		}
#endregion
	}
}
