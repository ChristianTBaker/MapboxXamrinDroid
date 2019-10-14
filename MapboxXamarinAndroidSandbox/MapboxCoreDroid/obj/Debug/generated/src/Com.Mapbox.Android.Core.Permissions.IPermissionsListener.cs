using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Permissions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.core.permissions']/interface[@name='PermissionsListener']"
	[Register ("com/mapbox/android/core/permissions/PermissionsListener", "", "Com.Mapbox.Android.Core.Permissions.IPermissionsListenerInvoker")]
	public partial interface IPermissionsListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.permissions']/interface[@name='PermissionsListener']/method[@name='onExplanationNeeded' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("onExplanationNeeded", "(Ljava/util/List;)V", "GetOnExplanationNeeded_Ljava_util_List_Handler:Com.Mapbox.Android.Core.Permissions.IPermissionsListenerInvoker, MapboxCoreDroid")]
		void OnExplanationNeeded (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.permissions']/interface[@name='PermissionsListener']/method[@name='onPermissionResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onPermissionResult", "(Z)V", "GetOnPermissionResult_ZHandler:Com.Mapbox.Android.Core.Permissions.IPermissionsListenerInvoker, MapboxCoreDroid")]
		void OnPermissionResult (bool p0);

	}

	[global::Android.Runtime.Register ("com/mapbox/android/core/permissions/PermissionsListener", DoNotGenerateAcw=true)]
	internal class IPermissionsListenerInvoker : global::Java.Lang.Object, IPermissionsListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/core/permissions/PermissionsListener", typeof (IPermissionsListenerInvoker));

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

		public static IPermissionsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPermissionsListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.core.permissions.PermissionsListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPermissionsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onExplanationNeeded_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnExplanationNeeded_Ljava_util_List_Handler ()
		{
			if (cb_onExplanationNeeded_Ljava_util_List_ == null)
				cb_onExplanationNeeded_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnExplanationNeeded_Ljava_util_List_);
			return cb_onExplanationNeeded_Ljava_util_List_;
		}

		static void n_OnExplanationNeeded_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnExplanationNeeded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onExplanationNeeded_Ljava_util_List_;
		public unsafe void OnExplanationNeeded (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_onExplanationNeeded_Ljava_util_List_ == IntPtr.Zero)
				id_onExplanationNeeded_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onExplanationNeeded", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onExplanationNeeded_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onPermissionResult_Z;
#pragma warning disable 0169
		static Delegate GetOnPermissionResult_ZHandler ()
		{
			if (cb_onPermissionResult_Z == null)
				cb_onPermissionResult_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnPermissionResult_Z);
			return cb_onPermissionResult_Z;
		}

		static void n_OnPermissionResult_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Permissions.IPermissionsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPermissionResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPermissionResult_Z;
		public unsafe void OnPermissionResult (bool p0)
		{
			if (id_onPermissionResult_Z == IntPtr.Zero)
				id_onPermissionResult_Z = JNIEnv.GetMethodID (class_ref, "onPermissionResult", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPermissionResult_Z, __args);
		}

	}

	// event args for com.mapbox.android.core.permissions.PermissionsListener.onExplanationNeeded
	public partial class ExplanationNeededEventArgs : global::System.EventArgs {

		public ExplanationNeededEventArgs (global::System.Collections.Generic.IList<string> p0)
		{
			this.p0 = p0;
		}

		global::System.Collections.Generic.IList<string> p0;
		public global::System.Collections.Generic.IList<string> P0 {
			get { return p0; }
		}
	}

	// event args for com.mapbox.android.core.permissions.PermissionsListener.onPermissionResult
	public partial class PermissionResultEventArgs : global::System.EventArgs {

		public PermissionResultEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/android/core/permissions/PermissionsListenerImplementor")]
	internal sealed partial class IPermissionsListenerImplementor : global::Java.Lang.Object, IPermissionsListener {

		object sender;

		public IPermissionsListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/android/core/permissions/PermissionsListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ExplanationNeededEventArgs> OnExplanationNeededHandler;
#pragma warning restore 0649

		public void OnExplanationNeeded (global::System.Collections.Generic.IList<string> p0)
		{
			var __h = OnExplanationNeededHandler;
			if (__h != null)
				__h (sender, new ExplanationNeededEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<PermissionResultEventArgs> OnPermissionResultHandler;
#pragma warning restore 0649

		public void OnPermissionResult (bool p0)
		{
			var __h = OnPermissionResultHandler;
			if (__h != null)
				__h (sender, new PermissionResultEventArgs (p0));
		}

		internal static bool __IsEmpty (IPermissionsListenerImplementor value)
		{
			return value.OnExplanationNeededHandler == null && value.OnPermissionResultHandler == null;
		}
	}

}
