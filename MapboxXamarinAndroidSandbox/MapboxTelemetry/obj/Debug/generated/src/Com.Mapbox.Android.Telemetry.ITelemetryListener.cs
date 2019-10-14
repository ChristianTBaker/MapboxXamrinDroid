using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='TelemetryListener']"
	[Register ("com/mapbox/android/telemetry/TelemetryListener", "", "Com.Mapbox.Android.Telemetry.ITelemetryListenerInvoker")]
	public partial interface ITelemetryListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='TelemetryListener']/method[@name='onHttpFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onHttpFailure", "(Ljava/lang/String;)V", "GetOnHttpFailure_Ljava_lang_String_Handler:Com.Mapbox.Android.Telemetry.ITelemetryListenerInvoker, MapboxTelemetry")]
		void OnHttpFailure (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/interface[@name='TelemetryListener']/method[@name='onHttpResponse' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("onHttpResponse", "(ZI)V", "GetOnHttpResponse_ZIHandler:Com.Mapbox.Android.Telemetry.ITelemetryListenerInvoker, MapboxTelemetry")]
		void OnHttpResponse (bool p0, int p1);

	}

	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/TelemetryListener", DoNotGenerateAcw=true)]
	internal class ITelemetryListenerInvoker : global::Java.Lang.Object, ITelemetryListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/telemetry/TelemetryListener", typeof (ITelemetryListenerInvoker));

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

		public static ITelemetryListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITelemetryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.telemetry.TelemetryListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITelemetryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onHttpFailure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnHttpFailure_Ljava_lang_String_Handler ()
		{
			if (cb_onHttpFailure_Ljava_lang_String_ == null)
				cb_onHttpFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHttpFailure_Ljava_lang_String_);
			return cb_onHttpFailure_Ljava_lang_String_;
		}

		static void n_OnHttpFailure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Android.Telemetry.ITelemetryListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.ITelemetryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHttpFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onHttpFailure_Ljava_lang_String_;
		public unsafe void OnHttpFailure (string p0)
		{
			if (id_onHttpFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onHttpFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onHttpFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHttpFailure_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onHttpResponse_ZI;
#pragma warning disable 0169
		static Delegate GetOnHttpResponse_ZIHandler ()
		{
			if (cb_onHttpResponse_ZI == null)
				cb_onHttpResponse_ZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int>) n_OnHttpResponse_ZI);
			return cb_onHttpResponse_ZI;
		}

		static void n_OnHttpResponse_ZI (IntPtr jnienv, IntPtr native__this, bool p0, int p1)
		{
			global::Com.Mapbox.Android.Telemetry.ITelemetryListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.ITelemetryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHttpResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onHttpResponse_ZI;
		public unsafe void OnHttpResponse (bool p0, int p1)
		{
			if (id_onHttpResponse_ZI == IntPtr.Zero)
				id_onHttpResponse_ZI = JNIEnv.GetMethodID (class_ref, "onHttpResponse", "(ZI)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHttpResponse_ZI, __args);
		}

	}

	// event args for com.mapbox.android.telemetry.TelemetryListener.onHttpFailure
	public partial class HttpFailureEventArgs : global::System.EventArgs {

		public HttpFailureEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	// event args for com.mapbox.android.telemetry.TelemetryListener.onHttpResponse
	public partial class HttpResponseEventArgs : global::System.EventArgs {

		public HttpResponseEventArgs (bool p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mapbox/android/telemetry/TelemetryListenerImplementor")]
	internal sealed partial class ITelemetryListenerImplementor : global::Java.Lang.Object, ITelemetryListener {

		object sender;

		public ITelemetryListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/android/telemetry/TelemetryListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<HttpFailureEventArgs> OnHttpFailureHandler;
#pragma warning restore 0649

		public void OnHttpFailure (string p0)
		{
			var __h = OnHttpFailureHandler;
			if (__h != null)
				__h (sender, new HttpFailureEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<HttpResponseEventArgs> OnHttpResponseHandler;
#pragma warning restore 0649

		public void OnHttpResponse (bool p0, int p1)
		{
			var __h = OnHttpResponseHandler;
			if (__h != null)
				__h (sender, new HttpResponseEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ITelemetryListenerImplementor value)
		{
			return value.OnHttpFailureHandler == null && value.OnHttpResponseHandler == null;
		}
	}

}
