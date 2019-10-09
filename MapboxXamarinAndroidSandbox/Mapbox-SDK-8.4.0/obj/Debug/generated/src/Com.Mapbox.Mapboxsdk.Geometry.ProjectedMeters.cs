using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='ProjectedMeters']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/geometry/ProjectedMeters", DoNotGenerateAcw=true)]
	public partial class ProjectedMeters : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='ProjectedMeters']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/geometry/ProjectedMeters", typeof (ProjectedMeters));
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

		protected ProjectedMeters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='ProjectedMeters']/constructor[@name='ProjectedMeters' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.ProjectedMeters']]"
		[Register (".ctor", "(Lcom/mapbox/mapboxsdk/geometry/ProjectedMeters;)V", "")]
		public unsafe ProjectedMeters (global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters projectedMeters)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/mapbox/mapboxsdk/geometry/ProjectedMeters;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((projectedMeters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) projectedMeters).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='ProjectedMeters']/constructor[@name='ProjectedMeters' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe ProjectedMeters (double northing, double easting)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(DD)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (northing);
				__args [1] = new JniArgumentValue (easting);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getEasting;
#pragma warning disable 0169
		static Delegate GetGetEastingHandler ()
		{
			if (cb_getEasting == null)
				cb_getEasting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetEasting);
			return cb_getEasting;
		}

		static double n_GetEasting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Easting;
		}
#pragma warning restore 0169

		public virtual unsafe double Easting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='ProjectedMeters']/method[@name='getEasting' and count(parameter)=0]"
			[Register ("getEasting", "()D", "GetGetEastingHandler")]
			get {
				const string __id = "getEasting.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNorthing;
#pragma warning disable 0169
		static Delegate GetGetNorthingHandler ()
		{
			if (cb_getNorthing == null)
				cb_getNorthing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetNorthing);
			return cb_getNorthing;
		}

		static double n_GetNorthing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Northing;
		}
#pragma warning restore 0169

		public virtual unsafe double Northing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='ProjectedMeters']/method[@name='getNorthing' and count(parameter)=0]"
			[Register ("getNorthing", "()D", "GetGetNorthingHandler")]
			get {
				const string __id = "getNorthing.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
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
			global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='ProjectedMeters']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.ProjectedMeters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @out = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__out, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (@out, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='ProjectedMeters']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
