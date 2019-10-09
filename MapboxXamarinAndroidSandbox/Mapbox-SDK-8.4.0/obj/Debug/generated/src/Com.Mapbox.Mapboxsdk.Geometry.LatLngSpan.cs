using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngSpan']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/geometry/LatLngSpan", DoNotGenerateAcw=true)]
	public partial class LatLngSpan : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngSpan']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/geometry/LatLngSpan", typeof (LatLngSpan));
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

		protected LatLngSpan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngSpan']/constructor[@name='LatLngSpan' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe LatLngSpan (double latitudeSpan, double longitudeSpan)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(DD)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (latitudeSpan);
				__args [1] = new JniArgumentValue (longitudeSpan);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getLatitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLatitudeSpanHandler ()
		{
			if (cb_getLatitudeSpan == null)
				cb_getLatitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitudeSpan);
			return cb_getLatitudeSpan;
		}

		static double n_GetLatitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpan;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitudeSpan_D;
#pragma warning disable 0169
		static Delegate GetSetLatitudeSpan_DHandler ()
		{
			if (cb_setLatitudeSpan_D == null)
				cb_setLatitudeSpan_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLatitudeSpan_D);
			return cb_setLatitudeSpan_D;
		}

		static void n_SetLatitudeSpan_D (IntPtr jnienv, IntPtr native__this, double latitudeSpan)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LatitudeSpan = latitudeSpan;
		}
#pragma warning restore 0169

		public virtual unsafe double LatitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngSpan']/method[@name='getLatitudeSpan' and count(parameter)=0]"
			[Register ("getLatitudeSpan", "()D", "GetGetLatitudeSpanHandler")]
			get {
				const string __id = "getLatitudeSpan.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngSpan']/method[@name='setLatitudeSpan' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitudeSpan", "(D)V", "GetSetLatitudeSpan_DHandler")]
			set {
				const string __id = "setLatitudeSpan.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLongitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLongitudeSpanHandler ()
		{
			if (cb_getLongitudeSpan == null)
				cb_getLongitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitudeSpan);
			return cb_getLongitudeSpan;
		}

		static double n_GetLongitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpan;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitudeSpan_D;
#pragma warning disable 0169
		static Delegate GetSetLongitudeSpan_DHandler ()
		{
			if (cb_setLongitudeSpan_D == null)
				cb_setLongitudeSpan_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLongitudeSpan_D);
			return cb_setLongitudeSpan_D;
		}

		static void n_SetLongitudeSpan_D (IntPtr jnienv, IntPtr native__this, double longitudeSpan)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LongitudeSpan = longitudeSpan;
		}
#pragma warning restore 0169

		public virtual unsafe double LongitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngSpan']/method[@name='getLongitudeSpan' and count(parameter)=0]"
			[Register ("getLongitudeSpan", "()D", "GetGetLongitudeSpanHandler")]
			get {
				const string __id = "getLongitudeSpan.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngSpan']/method[@name='setLongitudeSpan' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitudeSpan", "(D)V", "GetSetLongitudeSpan_DHandler")]
			set {
				const string __id = "setLongitudeSpan.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngSpan']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
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

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @out = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__out, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (@out, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngSpan']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel @out, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
