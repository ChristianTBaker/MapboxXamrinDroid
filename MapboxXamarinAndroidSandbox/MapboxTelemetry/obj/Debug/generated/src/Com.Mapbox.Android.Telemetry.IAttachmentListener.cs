using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='AttachmentListener']"
	[Register ("com/mapbox/android/telemetry/AttachmentListener", "", "Com.Mapbox.Android.Telemetry.IAttachmentListenerInvoker")]
	public partial interface IAttachmentListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='AttachmentListener']/method[@name='onAttachmentFailure' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("onAttachmentFailure", "(Ljava/lang/String;Ljava/util/List;)V", "GetOnAttachmentFailure_Ljava_lang_String_Ljava_util_List_Handler:Com.Mapbox.Android.Telemetry.IAttachmentListenerInvoker, MapboxTelemetry")]
		void OnAttachmentFailure (string p0, global::System.Collections.Generic.IList<string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='AttachmentListener']/method[@name='onAttachmentResponse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("onAttachmentResponse", "(Ljava/lang/String;ILjava/util/List;)V", "GetOnAttachmentResponse_Ljava_lang_String_ILjava_util_List_Handler:Com.Mapbox.Android.Telemetry.IAttachmentListenerInvoker, MapboxTelemetry")]
		void OnAttachmentResponse (string p0, int p1, global::System.Collections.Generic.IList<string> p2);

	}

	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/AttachmentListener", DoNotGenerateAcw=true)]
	internal class IAttachmentListenerInvoker : global::Java.Lang.Object, IAttachmentListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/telemetry/AttachmentListener", typeof (IAttachmentListenerInvoker));

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

		public static IAttachmentListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAttachmentListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.telemetry.AttachmentListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAttachmentListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAttachmentFailure_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnAttachmentFailure_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_onAttachmentFailure_Ljava_lang_String_Ljava_util_List_ == null)
				cb_onAttachmentFailure_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAttachmentFailure_Ljava_lang_String_Ljava_util_List_);
			return cb_onAttachmentFailure_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_OnAttachmentFailure_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Android.Telemetry.IAttachmentListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.IAttachmentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAttachmentFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAttachmentFailure_Ljava_lang_String_Ljava_util_List_;
		public unsafe void OnAttachmentFailure (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_onAttachmentFailure_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_onAttachmentFailure_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onAttachmentFailure", "(Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttachmentFailure_Ljava_lang_String_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onAttachmentResponse_Ljava_lang_String_ILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnAttachmentResponse_Ljava_lang_String_ILjava_util_List_Handler ()
		{
			if (cb_onAttachmentResponse_Ljava_lang_String_ILjava_util_List_ == null)
				cb_onAttachmentResponse_Ljava_lang_String_ILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnAttachmentResponse_Ljava_lang_String_ILjava_util_List_);
			return cb_onAttachmentResponse_Ljava_lang_String_ILjava_util_List_;
		}

		static void n_OnAttachmentResponse_Ljava_lang_String_ILjava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Mapbox.Android.Telemetry.IAttachmentListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.IAttachmentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnAttachmentResponse (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onAttachmentResponse_Ljava_lang_String_ILjava_util_List_;
		public unsafe void OnAttachmentResponse (string p0, int p1, global::System.Collections.Generic.IList<string> p2)
		{
			if (id_onAttachmentResponse_Ljava_lang_String_ILjava_util_List_ == IntPtr.Zero)
				id_onAttachmentResponse_Ljava_lang_String_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "onAttachmentResponse", "(Ljava/lang/String;ILjava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttachmentResponse_Ljava_lang_String_ILjava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.mapbox.android.telemetry.AttachmentListener.onAttachmentFailure
	public partial class AttachmentFailureEventArgs : global::System.EventArgs {

		public AttachmentFailureEventArgs (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<string> p1;
		public global::System.Collections.Generic.IList<string> P1 {
			get { return p1; }
		}
	}

	// event args for com.mapbox.android.telemetry.AttachmentListener.onAttachmentResponse
	public partial class AttachmentResponseEventArgs : global::System.EventArgs {

		public AttachmentResponseEventArgs (string p0, int p1, global::System.Collections.Generic.IList<string> p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		global::System.Collections.Generic.IList<string> p2;
		public global::System.Collections.Generic.IList<string> P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/android/telemetry/AttachmentListenerImplementor")]
	internal sealed partial class IAttachmentListenerImplementor : global::Java.Lang.Object, IAttachmentListener {

		object sender;

		public IAttachmentListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/android/telemetry/AttachmentListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AttachmentFailureEventArgs> OnAttachmentFailureHandler;
#pragma warning restore 0649

		public void OnAttachmentFailure (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			var __h = OnAttachmentFailureHandler;
			if (__h != null)
				__h (sender, new AttachmentFailureEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<AttachmentResponseEventArgs> OnAttachmentResponseHandler;
#pragma warning restore 0649

		public void OnAttachmentResponse (string p0, int p1, global::System.Collections.Generic.IList<string> p2)
		{
			var __h = OnAttachmentResponseHandler;
			if (__h != null)
				__h (sender, new AttachmentResponseEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IAttachmentListenerImplementor value)
		{
			return value.OnAttachmentFailureHandler == null && value.OnAttachmentResponseHandler == null;
		}
	}

}
