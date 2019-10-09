using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/BaseMarkerOptions", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"U extends com.mapbox.mapboxsdk.annotations.Marker", "T extends com.mapbox.mapboxsdk.annotations.BaseMarkerOptions<U, T>"})]
	public abstract partial class BaseMarkerOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/BaseMarkerOptions", typeof (BaseMarkerOptions));
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

		protected BaseMarkerOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/constructor[@name='BaseMarkerOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseMarkerOptions ()
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

		static Delegate cb_getMarker;
#pragma warning disable 0169
		static Delegate GetGetMarkerHandler ()
		{
			if (cb_getMarker == null)
				cb_getMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarker);
			return cb_getMarker;
		}

		static IntPtr n_GetMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawMarker);
		}
#pragma warning restore 0169

		protected abstract global::Java.Lang.Object RawMarker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Lcom/mapbox/mapboxsdk/annotations/Marker;", "GetGetMarkerHandler")] get;
		}

		static Delegate cb_getThis;
#pragma warning disable 0169
		static Delegate GetGetThisHandler ()
		{
			if (cb_getThis == null)
				cb_getThis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThis);
			return cb_getThis;
		}

		static IntPtr n_GetThis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawThis);
		}
#pragma warning restore 0169

		protected abstract global::Java.Lang.Object RawThis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='getThis' and count(parameter)=0]"
			[Register ("getThis", "()Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetGetThisHandler")] get;
		}

		static Delegate cb_icon_Lcom_mapbox_mapboxsdk_annotations_Icon_;
#pragma warning disable 0169
		static Delegate GetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_Handler ()
		{
			if (cb_icon_Lcom_mapbox_mapboxsdk_annotations_Icon_ == null)
				cb_icon_Lcom_mapbox_mapboxsdk_annotations_Icon_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Icon_Lcom_mapbox_mapboxsdk_annotations_Icon_);
			return cb_icon_Lcom_mapbox_mapboxsdk_annotations_Icon_;
		}

		static IntPtr n_Icon_Lcom_mapbox_mapboxsdk_annotations_Icon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Annotations.Icon icon = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (native_icon, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Icon (icon));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='icon' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Icon']]"
		[Register ("icon", "(Lcom/mapbox/mapboxsdk/annotations/Icon;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_Handler")]
		public virtual unsafe global::Java.Lang.Object Icon (global::Com.Mapbox.Mapboxsdk.Annotations.Icon icon)
		{
			const string __id = "icon.(Lcom/mapbox/mapboxsdk/annotations/Icon;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_position_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_position_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_position_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Position_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_position_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static IntPtr n_Position_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_position)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng position = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_position, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Position (position));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("position", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe global::Java.Lang.Object Position (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng position)
		{
			const string __id = "position.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((position == null) ? IntPtr.Zero : ((global::Java.Lang.Object) position).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_Handler ()
		{
			if (cb_setIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_ == null)
				cb_setIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_);
			return cb_setIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_;
		}

		static IntPtr n_SetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Annotations.Icon icon = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (native_icon, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIcon (icon));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Icon']]"
		[Register ("setIcon", "(Lcom/mapbox/mapboxsdk/annotations/Icon;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetSetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_Handler")]
		public virtual unsafe global::Java.Lang.Object SetIcon (global::Com.Mapbox.Mapboxsdk.Annotations.Icon icon)
		{
			const string __id = "setIcon.(Lcom/mapbox/mapboxsdk/annotations/Icon;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_setPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_setPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_setPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static IntPtr n_SetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_position)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng position = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_position, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPosition (position));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("setPosition", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetSetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe global::Java.Lang.Object SetPosition (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng position)
		{
			const string __id = "setPosition.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((position == null) ? IntPtr.Zero : ((global::Java.Lang.Object) position).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSnippet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSnippet_Ljava_lang_String_Handler ()
		{
			if (cb_setSnippet_Ljava_lang_String_ == null)
				cb_setSnippet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSnippet_Ljava_lang_String_);
			return cb_setSnippet_Ljava_lang_String_;
		}

		static IntPtr n_SetSnippet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_snippet)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string snippet = JNIEnv.GetString (native_snippet, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSnippet (snippet));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='setSnippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSnippet", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetSetSnippet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object SetSnippet (string snippet)
		{
			const string __id = "setSnippet.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;";
			IntPtr native_snippet = JNIEnv.NewString (snippet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_snippet);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_snippet);
			}
		}

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static IntPtr n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object SetTitle (string title)
		{
			const string __id = "setTitle.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_snippet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSnippet_Ljava_lang_String_Handler ()
		{
			if (cb_snippet_Ljava_lang_String_ == null)
				cb_snippet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Snippet_Ljava_lang_String_);
			return cb_snippet_Ljava_lang_String_;
		}

		static IntPtr n_Snippet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_snippet)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string snippet = JNIEnv.GetString (native_snippet, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Snippet (snippet));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='snippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("snippet", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetSnippet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object Snippet (string snippet)
		{
			const string __id = "snippet.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;";
			IntPtr native_snippet = JNIEnv.NewString (snippet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_snippet);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_snippet);
			}
		}

		static Delegate cb_title_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_title_Ljava_lang_String_ == null)
				cb_title_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Title_Ljava_lang_String_);
			return cb_title_Ljava_lang_String_;
		}

		static IntPtr n_Title_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Title (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='title' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("title", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetTitle_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object Title (string title)
		{
			const string __id = "title.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
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
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public abstract global::System.Int32 DescribeContents ();

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
			global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/BaseMarkerOptions", DoNotGenerateAcw=true)]
	internal partial class BaseMarkerOptionsInvoker : BaseMarkerOptions {

		public BaseMarkerOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/annotations/BaseMarkerOptions", typeof (BaseMarkerOptionsInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe global::Java.Lang.Object RawMarker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Lcom/mapbox/mapboxsdk/annotations/Marker;", "GetGetMarkerHandler")]
			get {
				const string __id = "getMarker.()Lcom/mapbox/mapboxsdk/annotations/Marker;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected override unsafe global::Java.Lang.Object RawThis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BaseMarkerOptions']/method[@name='getThis' and count(parameter)=0]"
			[Register ("getThis", "()Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;", "GetGetThisHandler")]
			get {
				const string __id = "getThis.()Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override unsafe global::System.Int32 DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
