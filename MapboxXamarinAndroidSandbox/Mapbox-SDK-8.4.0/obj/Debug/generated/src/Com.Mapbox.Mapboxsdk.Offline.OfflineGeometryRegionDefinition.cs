using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineGeometryRegionDefinition", DoNotGenerateAcw=true)]
	public partial class OfflineGeometryRegionDefinition : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineGeometryRegionDefinition", typeof (OfflineGeometryRegionDefinition));
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

		protected OfflineGeometryRegionDefinition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/constructor[@name='OfflineGeometryRegionDefinition' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe OfflineGeometryRegionDefinition (global::Android.OS.Parcel parcel)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parcel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parcel).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBounds;
#pragma warning disable 0169
		static Delegate GetGetBoundsHandler ()
		{
			if (cb_getBounds == null)
				cb_getBounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBounds);
			return cb_getBounds;
		}

		static IntPtr n_GetBounds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bounds);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Bounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/method[@name='getBounds' and count(parameter)=0]"
			[Register ("getBounds", "()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "GetGetBoundsHandler")]
			get {
				const string __id = "getBounds.()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIncludeIdeographs;
#pragma warning disable 0169
		static Delegate GetGetIncludeIdeographsHandler ()
		{
			if (cb_getIncludeIdeographs == null)
				cb_getIncludeIdeographs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIncludeIdeographs);
			return cb_getIncludeIdeographs;
		}

		static bool n_GetIncludeIdeographs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IncludeIdeographs;
		}
#pragma warning restore 0169

		public virtual unsafe bool IncludeIdeographs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/method[@name='getIncludeIdeographs' and count(parameter)=0]"
			[Register ("getIncludeIdeographs", "()Z", "GetGetIncludeIdeographsHandler")]
			get {
				const string __id = "getIncludeIdeographs.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxZoom;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomHandler ()
		{
			if (cb_getMaxZoom == null)
				cb_getMaxZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxZoom);
			return cb_getMaxZoom;
		}

		static double n_GetMaxZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoom;
		}
#pragma warning restore 0169

		public virtual unsafe double MaxZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/method[@name='getMaxZoom' and count(parameter)=0]"
			[Register ("getMaxZoom", "()D", "GetGetMaxZoomHandler")]
			get {
				const string __id = "getMaxZoom.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinZoom;
#pragma warning disable 0169
		static Delegate GetGetMinZoomHandler ()
		{
			if (cb_getMinZoom == null)
				cb_getMinZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinZoom);
			return cb_getMinZoom;
		}

		static double n_GetMinZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoom;
		}
#pragma warning restore 0169

		public virtual unsafe double MinZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/method[@name='getMinZoom' and count(parameter)=0]"
			[Register ("getMinZoom", "()D", "GetGetMinZoomHandler")]
			get {
				const string __id = "getMinZoom.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPixelRatio;
#pragma warning disable 0169
		static Delegate GetGetPixelRatioHandler ()
		{
			if (cb_getPixelRatio == null)
				cb_getPixelRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPixelRatio);
			return cb_getPixelRatio;
		}

		static float n_GetPixelRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelRatio;
		}
#pragma warning restore 0169

		public virtual unsafe float PixelRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/method[@name='getPixelRatio' and count(parameter)=0]"
			[Register ("getPixelRatio", "()F", "GetGetPixelRatioHandler")]
			get {
				const string __id = "getPixelRatio.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStyleURL;
#pragma warning disable 0169
		static Delegate GetGetStyleURLHandler ()
		{
			if (cb_getStyleURL == null)
				cb_getStyleURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStyleURL);
			return cb_getStyleURL;
		}

		static IntPtr n_GetStyleURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StyleURL);
		}
#pragma warning restore 0169

		public virtual unsafe string StyleURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/method[@name='getStyleURL' and count(parameter)=0]"
			[Register ("getStyleURL", "()Ljava/lang/String;", "GetGetStyleURLHandler")]
			get {
				const string __id = "getStyleURL.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/method[@name='describeContents' and count(parameter)=0]"
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

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineGeometryRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineGeometryRegionDefinition']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
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
