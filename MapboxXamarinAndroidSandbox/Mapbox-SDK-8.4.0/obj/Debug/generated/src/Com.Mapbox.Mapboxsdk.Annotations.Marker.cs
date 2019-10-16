using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/Marker", DoNotGenerateAcw=true)]
	public partial class Marker : global::Com.Mapbox.Mapboxsdk.Annotations.Annotation {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/Marker", typeof (Marker));
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

		protected Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/constructor[@name='Marker' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.BaseMarkerOptions']]"
		[Register (".ctor", "(Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;)V", "")]
		public unsafe Marker (global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions baseMarkerOptions)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((baseMarkerOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseMarkerOptions).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		static Delegate cb_setIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_Handler ()
		{
			if (cb_setIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_ == null)
				cb_setIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_);
			return cb_setIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_;
		}

		static void n_SetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Annotations.Icon icon = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (native_icon, JniHandleOwnership.DoNotTransfer);
			__this.Icon = icon;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Icon Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/mapbox/mapboxsdk/annotations/Icon;", "GetGetIconHandler")]
			get {
				const string __id = "getIcon.()Lcom/mapbox/mapboxsdk/annotations/Icon;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Icon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Icon']]"
			[Register ("setIcon", "(Lcom/mapbox/mapboxsdk/annotations/Icon;)V", "GetSetIcon_Lcom_mapbox_mapboxsdk_annotations_Icon_Handler")]
			set {
				const string __id = "setIcon.(Lcom/mapbox/mapboxsdk/annotations/Icon;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInfoWindow;
#pragma warning disable 0169
		static Delegate GetGetInfoWindowHandler ()
		{
			if (cb_getInfoWindow == null)
				cb_getInfoWindow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfoWindow);
			return cb_getInfoWindow;
		}

		static IntPtr n_GetInfoWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InfoWindow);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.InfoWindow InfoWindow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='getInfoWindow' and count(parameter)=0]"
			[Register ("getInfoWindow", "()Lcom/mapbox/mapboxsdk/annotations/InfoWindow;", "GetGetInfoWindowHandler")]
			get {
				const string __id = "getInfoWindow.()Lcom/mapbox/mapboxsdk/annotations/InfoWindow;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.InfoWindow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isInfoWindowShown;
#pragma warning disable 0169
		static Delegate GetIsInfoWindowShownHandler ()
		{
			if (cb_isInfoWindowShown == null)
				cb_isInfoWindowShown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInfoWindowShown);
			return cb_isInfoWindowShown;
		}

		static bool n_IsInfoWindowShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInfoWindowShown;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInfoWindowShown {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='isInfoWindowShown' and count(parameter)=0]"
			[Register ("isInfoWindowShown", "()Z", "GetIsInfoWindowShownHandler")]
			get {
				const string __id = "isInfoWindowShown.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_setPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_setPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_setPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static void n_SetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_position)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng position = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_position, JniHandleOwnership.DoNotTransfer);
			__this.Position = position;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
			[Register ("setPosition", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)V", "GetSetPosition_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
			set {
				const string __id = "setPosition.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSnippet;
#pragma warning disable 0169
		static Delegate GetGetSnippetHandler ()
		{
			if (cb_getSnippet == null)
				cb_getSnippet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSnippet);
			return cb_getSnippet;
		}

		static IntPtr n_GetSnippet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Snippet);
		}
#pragma warning restore 0169

		static Delegate cb_setSnippet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSnippet_Ljava_lang_String_Handler ()
		{
			if (cb_setSnippet_Ljava_lang_String_ == null)
				cb_setSnippet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSnippet_Ljava_lang_String_);
			return cb_setSnippet_Ljava_lang_String_;
		}

		static void n_SetSnippet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_snippet)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string snippet = JNIEnv.GetString (native_snippet, JniHandleOwnership.DoNotTransfer);
			__this.Snippet = snippet;
		}
#pragma warning restore 0169

		public virtual unsafe string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				const string __id = "getSnippet.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='setSnippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSnippet", "(Ljava/lang/String;)V", "GetSetSnippet_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSnippet.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			__this.Title = title;
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTitle.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_hideInfoWindow;
#pragma warning disable 0169
		static Delegate GetHideInfoWindowHandler ()
		{
			if (cb_hideInfoWindow == null)
				cb_hideInfoWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideInfoWindow);
			return cb_hideInfoWindow;
		}

		static void n_HideInfoWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideInfoWindow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='hideInfoWindow' and count(parameter)=0]"
		[Register ("hideInfoWindow", "()V", "GetHideInfoWindowHandler")]
		public virtual unsafe void HideInfoWindow ()
		{
			const string __id = "hideInfoWindow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setRightOffsetPixels_I;
#pragma warning disable 0169
		static Delegate GetSetRightOffsetPixels_IHandler ()
		{
			if (cb_setRightOffsetPixels_I == null)
				cb_setRightOffsetPixels_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRightOffsetPixels_I);
			return cb_setRightOffsetPixels_I;
		}

		static void n_SetRightOffsetPixels_I (IntPtr jnienv, IntPtr native__this, int rightOffsetPixels)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRightOffsetPixels (rightOffsetPixels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='setRightOffsetPixels' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRightOffsetPixels", "(I)V", "GetSetRightOffsetPixels_IHandler")]
		public virtual unsafe void SetRightOffsetPixels (int rightOffsetPixels)
		{
			const string __id = "setRightOffsetPixels.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rightOffsetPixels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTopOffsetPixels_I;
#pragma warning disable 0169
		static Delegate GetSetTopOffsetPixels_IHandler ()
		{
			if (cb_setTopOffsetPixels_I == null)
				cb_setTopOffsetPixels_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTopOffsetPixels_I);
			return cb_setTopOffsetPixels_I;
		}

		static void n_SetTopOffsetPixels_I (IntPtr jnienv, IntPtr native__this, int topOffsetPixels)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTopOffsetPixels (topOffsetPixels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='setTopOffsetPixels' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTopOffsetPixels", "(I)V", "GetSetTopOffsetPixels_IHandler")]
		public virtual unsafe void SetTopOffsetPixels (int topOffsetPixels)
		{
			const string __id = "setTopOffsetPixels.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (topOffsetPixels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showInfoWindow_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Lcom_mapbox_mapboxsdk_maps_MapView_;
#pragma warning disable 0169
		static Delegate GetShowInfoWindow_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Lcom_mapbox_mapboxsdk_maps_MapView_Handler ()
		{
			if (cb_showInfoWindow_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Lcom_mapbox_mapboxsdk_maps_MapView_ == null)
				cb_showInfoWindow_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Lcom_mapbox_mapboxsdk_maps_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowInfoWindow_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Lcom_mapbox_mapboxsdk_maps_MapView_);
			return cb_showInfoWindow_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Lcom_mapbox_mapboxsdk_maps_MapView_;
		}

		static IntPtr n_ShowInfoWindow_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Lcom_mapbox_mapboxsdk_maps_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapboxMap, IntPtr native_mapView)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.Marker __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap> (native_mapboxMap, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView mapView = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowInfoWindow (mapboxMap, mapView));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Marker']/method[@name='showInfoWindow' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.MapView']]"
		[Register ("showInfoWindow", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;Lcom/mapbox/mapboxsdk/maps/MapView;)Lcom/mapbox/mapboxsdk/annotations/InfoWindow;", "GetShowInfoWindow_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Lcom_mapbox_mapboxsdk_maps_MapView_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.InfoWindow ShowInfoWindow (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap, global::Com.Mapbox.Mapboxsdk.Maps.MapView mapView)
		{
			const string __id = "showInfoWindow.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;Lcom/mapbox/mapboxsdk/maps/MapView;)Lcom/mapbox/mapboxsdk/annotations/InfoWindow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
				__args [1] = new JniArgumentValue ((mapView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapView).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.InfoWindow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
