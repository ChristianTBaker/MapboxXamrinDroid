using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionEventFactory']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/VisionEventFactory", DoNotGenerateAcw=true)]
	public partial class VisionEventFactory : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/VisionEventFactory", typeof (VisionEventFactory));
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

		protected VisionEventFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionEventFactory']/constructor[@name='VisionEventFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VisionEventFactory ()
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

		static Delegate cb_createAttachment_Lcom_mapbox_android_telemetry_Event_Type_;
#pragma warning disable 0169
		static Delegate GetCreateAttachment_Lcom_mapbox_android_telemetry_Event_Type_Handler ()
		{
			if (cb_createAttachment_Lcom_mapbox_android_telemetry_Event_Type_ == null)
				cb_createAttachment_Lcom_mapbox_android_telemetry_Event_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAttachment_Lcom_mapbox_android_telemetry_Event_Type_);
			return cb_createAttachment_Lcom_mapbox_android_telemetry_Event_Type_;
		}

		static IntPtr n_CreateAttachment_Lcom_mapbox_android_telemetry_Event_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Mapbox.Android.Telemetry.VisionEventFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionEventFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Telemetry.Event.Type type = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAttachment (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionEventFactory']/method[@name='createAttachment' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.Event.Type']]"
		[Register ("createAttachment", "(Lcom/mapbox/android/telemetry/Event$Type;)Lcom/mapbox/android/telemetry/Attachment;", "GetCreateAttachment_Lcom_mapbox_android_telemetry_Event_Type_Handler")]
		public virtual unsafe global::Com.Mapbox.Android.Telemetry.Attachment CreateAttachment (global::Com.Mapbox.Android.Telemetry.Event.Type type)
		{
			const string __id = "createAttachment.(Lcom/mapbox/android/telemetry/Event$Type;)Lcom/mapbox/android/telemetry/Attachment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Attachment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createVisionEvent_Lcom_mapbox_android_telemetry_Event_Type_;
#pragma warning disable 0169
		static Delegate GetCreateVisionEvent_Lcom_mapbox_android_telemetry_Event_Type_Handler ()
		{
			if (cb_createVisionEvent_Lcom_mapbox_android_telemetry_Event_Type_ == null)
				cb_createVisionEvent_Lcom_mapbox_android_telemetry_Event_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateVisionEvent_Lcom_mapbox_android_telemetry_Event_Type_);
			return cb_createVisionEvent_Lcom_mapbox_android_telemetry_Event_Type_;
		}

		static IntPtr n_CreateVisionEvent_Lcom_mapbox_android_telemetry_Event_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Mapbox.Android.Telemetry.VisionEventFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionEventFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Telemetry.Event.Type type = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateVisionEvent (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionEventFactory']/method[@name='createVisionEvent' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.Event.Type']]"
		[Register ("createVisionEvent", "(Lcom/mapbox/android/telemetry/Event$Type;)Lcom/mapbox/android/telemetry/Event;", "GetCreateVisionEvent_Lcom_mapbox_android_telemetry_Event_Type_Handler")]
		public virtual unsafe global::Com.Mapbox.Android.Telemetry.Event CreateVisionEvent (global::Com.Mapbox.Android.Telemetry.Event.Type type)
		{
			const string __id = "createVisionEvent.(Lcom/mapbox/android/telemetry/Event$Type;)Lcom/mapbox/android/telemetry/Event;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
