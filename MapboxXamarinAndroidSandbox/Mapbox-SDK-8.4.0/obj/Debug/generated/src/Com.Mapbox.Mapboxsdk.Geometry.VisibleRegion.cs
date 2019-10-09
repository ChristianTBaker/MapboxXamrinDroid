using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/geometry/VisibleRegion", DoNotGenerateAcw=true)]
	public partial class VisibleRegion : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']/field[@name='farLeft']"
		[Register ("farLeft")]
		public global::Com.Mapbox.Mapboxsdk.Geometry.LatLng FarLeft {
			get {
				const string __id = "farLeft.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "farLeft.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']/field[@name='farRight']"
		[Register ("farRight")]
		public global::Com.Mapbox.Mapboxsdk.Geometry.LatLng FarRight {
			get {
				const string __id = "farRight.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "farRight.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']/field[@name='latLngBounds']"
		[Register ("latLngBounds")]
		public global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds LatLngBounds {
			get {
				const string __id = "latLngBounds.Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "latLngBounds.Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']/field[@name='nearLeft']"
		[Register ("nearLeft")]
		public global::Com.Mapbox.Mapboxsdk.Geometry.LatLng NearLeft {
			get {
				const string __id = "nearLeft.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "nearLeft.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']/field[@name='nearRight']"
		[Register ("nearRight")]
		public global::Com.Mapbox.Mapboxsdk.Geometry.LatLng NearRight {
			get {
				const string __id = "nearRight.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "nearRight.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/geometry/VisibleRegion", typeof (VisibleRegion));
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

		protected VisibleRegion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']/constructor[@name='VisibleRegion' and count(parameter)=5 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng'] and parameter[2][@type='com.mapbox.mapboxsdk.geometry.LatLng'] and parameter[3][@type='com.mapbox.mapboxsdk.geometry.LatLng'] and parameter[4][@type='com.mapbox.mapboxsdk.geometry.LatLng'] and parameter[5][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds']]"
		[Register (".ctor", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)V", "")]
		public unsafe VisibleRegion (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng farLeft, global::Com.Mapbox.Mapboxsdk.Geometry.LatLng farRight, global::Com.Mapbox.Mapboxsdk.Geometry.LatLng nearLeft, global::Com.Mapbox.Mapboxsdk.Geometry.LatLng nearRight, global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds latLngBounds)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((farLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) farLeft).Handle);
				__args [1] = new JniArgumentValue ((farRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) farRight).Handle);
				__args [2] = new JniArgumentValue ((nearLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nearLeft).Handle);
				__args [3] = new JniArgumentValue ((nearRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nearRight).Handle);
				__args [4] = new JniArgumentValue ((latLngBounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLngBounds).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			global::Com.Mapbox.Mapboxsdk.Geometry.VisibleRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.VisibleRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Mapbox.Mapboxsdk.Geometry.VisibleRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.VisibleRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @out = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__out, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (@out, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='VisibleRegion']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
