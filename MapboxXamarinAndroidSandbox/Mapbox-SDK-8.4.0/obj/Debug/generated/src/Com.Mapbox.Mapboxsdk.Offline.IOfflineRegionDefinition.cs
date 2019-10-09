using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Offline {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegionDefinition']"
	[Register ("com/mapbox/mapboxsdk/offline/OfflineRegionDefinition", "", "Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinitionInvoker")]
	public partial interface IOfflineRegionDefinition : global::Android.OS.IParcelable {

		global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Bounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegionDefinition']/method[@name='getBounds' and count(parameter)=0]"
			[Register ("getBounds", "()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "GetGetBoundsHandler:Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinitionInvoker, Mapbox-SDK-8.4.0")] get;
		}

		bool IncludeIdeographs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegionDefinition']/method[@name='getIncludeIdeographs' and count(parameter)=0]"
			[Register ("getIncludeIdeographs", "()Z", "GetGetIncludeIdeographsHandler:Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinitionInvoker, Mapbox-SDK-8.4.0")] get;
		}

		double MaxZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegionDefinition']/method[@name='getMaxZoom' and count(parameter)=0]"
			[Register ("getMaxZoom", "()D", "GetGetMaxZoomHandler:Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinitionInvoker, Mapbox-SDK-8.4.0")] get;
		}

		double MinZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegionDefinition']/method[@name='getMinZoom' and count(parameter)=0]"
			[Register ("getMinZoom", "()D", "GetGetMinZoomHandler:Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinitionInvoker, Mapbox-SDK-8.4.0")] get;
		}

		float PixelRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegionDefinition']/method[@name='getPixelRatio' and count(parameter)=0]"
			[Register ("getPixelRatio", "()F", "GetGetPixelRatioHandler:Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinitionInvoker, Mapbox-SDK-8.4.0")] get;
		}

		string StyleURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegionDefinition']/method[@name='getStyleURL' and count(parameter)=0]"
			[Register ("getStyleURL", "()Ljava/lang/String;", "GetGetStyleURLHandler:Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinitionInvoker, Mapbox-SDK-8.4.0")] get;
		}

		string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegionDefinition']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler:Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinitionInvoker, Mapbox-SDK-8.4.0")] get;
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegionDefinition", DoNotGenerateAcw=true)]
	internal class IOfflineRegionDefinitionInvoker : global::Java.Lang.Object, IOfflineRegionDefinition {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegionDefinition", typeof (IOfflineRegionDefinitionInvoker));

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

		public static IOfflineRegionDefinition GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOfflineRegionDefinition> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineRegionDefinition"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOfflineRegionDefinitionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bounds);
		}
#pragma warning restore 0169

		IntPtr id_getBounds;
		public unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Bounds {
			get {
				if (id_getBounds == IntPtr.Zero)
					id_getBounds = JNIEnv.GetMethodID (class_ref, "getBounds", "()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBounds), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IncludeIdeographs;
		}
#pragma warning restore 0169

		IntPtr id_getIncludeIdeographs;
		public unsafe bool IncludeIdeographs {
			get {
				if (id_getIncludeIdeographs == IntPtr.Zero)
					id_getIncludeIdeographs = JNIEnv.GetMethodID (class_ref, "getIncludeIdeographs", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getIncludeIdeographs);
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
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoom;
		}
#pragma warning restore 0169

		IntPtr id_getMaxZoom;
		public unsafe double MaxZoom {
			get {
				if (id_getMaxZoom == IntPtr.Zero)
					id_getMaxZoom = JNIEnv.GetMethodID (class_ref, "getMaxZoom", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getMaxZoom);
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
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoom;
		}
#pragma warning restore 0169

		IntPtr id_getMinZoom;
		public unsafe double MinZoom {
			get {
				if (id_getMinZoom == IntPtr.Zero)
					id_getMinZoom = JNIEnv.GetMethodID (class_ref, "getMinZoom", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getMinZoom);
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
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelRatio;
		}
#pragma warning restore 0169

		IntPtr id_getPixelRatio;
		public unsafe float PixelRatio {
			get {
				if (id_getPixelRatio == IntPtr.Zero)
					id_getPixelRatio = JNIEnv.GetMethodID (class_ref, "getPixelRatio", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPixelRatio);
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
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StyleURL);
		}
#pragma warning restore 0169

		IntPtr id_getStyleURL;
		public unsafe string StyleURL {
			get {
				if (id_getStyleURL == IntPtr.Zero)
					id_getStyleURL = JNIEnv.GetMethodID (class_ref, "getStyleURL", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStyleURL), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe string Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		IntPtr id_describeContents;
		public unsafe global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
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
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
			__args [1] = new JValue ((int) flags);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
		}

	}

}
