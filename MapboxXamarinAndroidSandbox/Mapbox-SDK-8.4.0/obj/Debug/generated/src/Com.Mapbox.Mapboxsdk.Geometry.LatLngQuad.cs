using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngQuad']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/geometry/LatLngQuad", DoNotGenerateAcw=true)]
	public partial class LatLngQuad : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngQuad']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/geometry/LatLngQuad", typeof (LatLngQuad));
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

		protected LatLngQuad (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngQuad']/constructor[@name='LatLngQuad' and count(parameter)=4 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng'] and parameter[2][@type='com.mapbox.mapboxsdk.geometry.LatLng'] and parameter[3][@type='com.mapbox.mapboxsdk.geometry.LatLng'] and parameter[4][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register (".ctor", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;)V", "")]
		public unsafe LatLngQuad (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng topLeft, global::Com.Mapbox.Mapboxsdk.Geometry.LatLng topRight, global::Com.Mapbox.Mapboxsdk.Geometry.LatLng bottomRight, global::Com.Mapbox.Mapboxsdk.Geometry.LatLng bottomLeft)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;Lcom/mapbox/mapboxsdk/geometry/LatLng;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((topLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) topLeft).Handle);
				__args [1] = new JniArgumentValue ((topRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) topRight).Handle);
				__args [2] = new JniArgumentValue ((bottomRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomRight).Handle);
				__args [3] = new JniArgumentValue ((bottomLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomLeft).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBottomLeft;
#pragma warning disable 0169
		static Delegate GetGetBottomLeftHandler ()
		{
			if (cb_getBottomLeft == null)
				cb_getBottomLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBottomLeft);
			return cb_getBottomLeft;
		}

		static IntPtr n_GetBottomLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BottomLeft);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng BottomLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngQuad']/method[@name='getBottomLeft' and count(parameter)=0]"
			[Register ("getBottomLeft", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetBottomLeftHandler")]
			get {
				const string __id = "getBottomLeft.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBottomRight;
#pragma warning disable 0169
		static Delegate GetGetBottomRightHandler ()
		{
			if (cb_getBottomRight == null)
				cb_getBottomRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBottomRight);
			return cb_getBottomRight;
		}

		static IntPtr n_GetBottomRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BottomRight);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng BottomRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngQuad']/method[@name='getBottomRight' and count(parameter)=0]"
			[Register ("getBottomRight", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetBottomRightHandler")]
			get {
				const string __id = "getBottomRight.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTopLeft;
#pragma warning disable 0169
		static Delegate GetGetTopLeftHandler ()
		{
			if (cb_getTopLeft == null)
				cb_getTopLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopLeft);
			return cb_getTopLeft;
		}

		static IntPtr n_GetTopLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopLeft);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng TopLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngQuad']/method[@name='getTopLeft' and count(parameter)=0]"
			[Register ("getTopLeft", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetTopLeftHandler")]
			get {
				const string __id = "getTopLeft.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTopRight;
#pragma warning disable 0169
		static Delegate GetGetTopRightHandler ()
		{
			if (cb_getTopRight == null)
				cb_getTopRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopRight);
			return cb_getTopRight;
		}

		static IntPtr n_GetTopRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopRight);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng TopRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngQuad']/method[@name='getTopRight' and count(parameter)=0]"
			[Register ("getTopRight", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetTopRightHandler")]
			get {
				const string __id = "getTopRight.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngQuad']/method[@name='describeContents' and count(parameter)=0]"
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

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_arg1)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngQuad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @out = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__out, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags arg1 = (global::Android.OS.ParcelableWriteFlags) native_arg1;
			__this.WriteToParcel (@out, arg1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngQuad']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel @out, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags arg1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue ((int) arg1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
