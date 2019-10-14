using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='LocationEvent']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/LocationEvent", DoNotGenerateAcw=true)]
	public partial class LocationEvent : global::Com.Mapbox.Android.Telemetry.Event, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='LocationEvent']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/LocationEvent", typeof (LocationEvent));
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

		protected LocationEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='LocationEvent']/constructor[@name='LocationEvent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;DDLjava/lang/String;)V", "")]
		public unsafe LocationEvent (string sessionId, double latitude, double longitude, string applicationState)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;DDLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sessionId = JNIEnv.NewString (sessionId);
			IntPtr native_applicationState = JNIEnv.NewString (applicationState);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sessionId);
				__args [1] = new JniArgumentValue (latitude);
				__args [2] = new JniArgumentValue (longitude);
				__args [3] = new JniArgumentValue (native_applicationState);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sessionId);
				JNIEnv.DeleteLocalRef (native_applicationState);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.LocationEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.LocationEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='LocationEvent']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setAccuracy_Ljava_lang_Float_;
#pragma warning disable 0169
		static Delegate GetSetAccuracy_Ljava_lang_Float_Handler ()
		{
			if (cb_setAccuracy_Ljava_lang_Float_ == null)
				cb_setAccuracy_Ljava_lang_Float_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccuracy_Ljava_lang_Float_);
			return cb_setAccuracy_Ljava_lang_Float_;
		}

		static void n_SetAccuracy_Ljava_lang_Float_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accuracy)
		{
			global::Com.Mapbox.Android.Telemetry.LocationEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.LocationEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Float accuracy = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (native_accuracy, JniHandleOwnership.DoNotTransfer);
			__this.SetAccuracy (accuracy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='LocationEvent']/method[@name='setAccuracy' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("setAccuracy", "(Ljava/lang/Float;)V", "GetSetAccuracy_Ljava_lang_Float_Handler")]
		public virtual unsafe void SetAccuracy (global::Java.Lang.Float accuracy)
		{
			const string __id = "setAccuracy.(Ljava/lang/Float;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accuracy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accuracy).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAltitude_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetAltitude_Ljava_lang_Double_Handler ()
		{
			if (cb_setAltitude_Ljava_lang_Double_ == null)
				cb_setAltitude_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAltitude_Ljava_lang_Double_);
			return cb_setAltitude_Ljava_lang_Double_;
		}

		static void n_SetAltitude_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_altitude)
		{
			global::Com.Mapbox.Android.Telemetry.LocationEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.LocationEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double altitude = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_altitude, JniHandleOwnership.DoNotTransfer);
			__this.SetAltitude (altitude);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='LocationEvent']/method[@name='setAltitude' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("setAltitude", "(Ljava/lang/Double;)V", "GetSetAltitude_Ljava_lang_Double_Handler")]
		public virtual unsafe void SetAltitude (global::Java.Lang.Double altitude)
		{
			const string __id = "setAltitude.(Ljava/lang/Double;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((altitude == null) ? IntPtr.Zero : ((global::Java.Lang.Object) altitude).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Mapbox.Android.Telemetry.LocationEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.LocationEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='LocationEvent']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
