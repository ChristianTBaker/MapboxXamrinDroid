using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/geometry/LatLng", DoNotGenerateAcw=true)]
	public partial class LatLng : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/geometry/LatLng", typeof (LatLng));
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

		protected LatLng (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LatLng ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register (".ctor", "(Landroid/location/Location;)V", "")]
		public unsafe LatLng (global::Android.Locations.Location location)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/location/Location;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((location == null) ? IntPtr.Zero : ((global::Java.Lang.Object) location).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe LatLng (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register (".ctor", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)V", "")]
		public unsafe LatLng (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((latLng == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLng).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe LatLng (double latitude, double longitude)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(DD)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (latitude);
				__args [1] = new JniArgumentValue (longitude);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register (".ctor", "(DDD)V", "")]
		public unsafe LatLng (double latitude, double longitude, double altitude)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(DDD)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (latitude);
				__args [1] = new JniArgumentValue (longitude);
				__args [2] = new JniArgumentValue (altitude);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAltitude;
#pragma warning disable 0169
		static Delegate GetGetAltitudeHandler ()
		{
			if (cb_getAltitude == null)
				cb_getAltitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAltitude);
			return cb_getAltitude;
		}

		static double n_GetAltitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Altitude;
		}
#pragma warning restore 0169

		static Delegate cb_setAltitude_D;
#pragma warning disable 0169
		static Delegate GetSetAltitude_DHandler ()
		{
			if (cb_setAltitude_D == null)
				cb_setAltitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetAltitude_D);
			return cb_setAltitude_D;
		}

		static void n_SetAltitude_D (IntPtr jnienv, IntPtr native__this, double altitude)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Altitude = altitude;
		}
#pragma warning restore 0169

		public virtual unsafe double Altitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='getAltitude' and count(parameter)=0]"
			[Register ("getAltitude", "()D", "GetGetAltitudeHandler")]
			get {
				const string __id = "getAltitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='setAltitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setAltitude", "(D)V", "GetSetAltitude_DHandler")]
			set {
				const string __id = "setAltitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitude_D;
#pragma warning disable 0169
		static Delegate GetSetLatitude_DHandler ()
		{
			if (cb_setLatitude_D == null)
				cb_setLatitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLatitude_D);
			return cb_setLatitude_D;
		}

		static void n_SetLatitude_D (IntPtr jnienv, IntPtr native__this, double latitude)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Latitude = latitude;
		}
#pragma warning restore 0169

		public virtual unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				const string __id = "getLatitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitude", "(D)V", "GetSetLatitude_DHandler")]
			set {
				const string __id = "setLatitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitude_D;
#pragma warning disable 0169
		static Delegate GetSetLongitude_DHandler ()
		{
			if (cb_setLongitude_D == null)
				cb_setLongitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLongitude_D);
			return cb_setLongitude_D;
		}

		static void n_SetLongitude_D (IntPtr jnienv, IntPtr native__this, double longitude)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Longitude = longitude;
		}
#pragma warning restore 0169

		public virtual unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				const string __id = "getLongitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitude", "(D)V", "GetSetLongitude_DHandler")]
			set {
				const string __id = "setLongitude.(D)V";
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
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_distanceTo_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetDistanceTo_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_distanceTo_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_distanceTo_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_DistanceTo_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_distanceTo_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static double n_DistanceTo_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng other = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_other, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceTo (other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='distanceTo' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("distanceTo", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)D", "GetDistanceTo_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe double DistanceTo (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng other)
		{
			const string __id = "distanceTo.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_wrap;
#pragma warning disable 0169
		static Delegate GetWrapHandler ()
		{
			if (cb_wrap == null)
				cb_wrap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Wrap);
			return cb_wrap;
		}

		static IntPtr n_Wrap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Wrap ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='wrap' and count(parameter)=0]"
		[Register ("wrap", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetWrapHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng Wrap ()
		{
			const string __id = "wrap.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @out = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__out, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (@out, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLng']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
