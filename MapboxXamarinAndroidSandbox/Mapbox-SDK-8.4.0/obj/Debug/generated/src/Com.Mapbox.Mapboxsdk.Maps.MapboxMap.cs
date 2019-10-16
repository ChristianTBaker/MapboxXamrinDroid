using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap", DoNotGenerateAcw=true)]
	public sealed partial class MapboxMap : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.CancelableCallback']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/ICancelableCallbackInvoker")]
		public partial interface ICancelableCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.CancelableCallback']/method[@name='onCancel' and count(parameter)=0]"
			[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/ICancelableCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnCancel ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.CancelableCallback']/method[@name='onFinish' and count(parameter)=0]"
			[Register ("onFinish", "()V", "GetOnFinishHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/ICancelableCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnFinish ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback", DoNotGenerateAcw=true)]
		internal class ICancelableCallbackInvoker : global::Java.Lang.Object, ICancelableCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback", typeof (ICancelableCallbackInvoker));

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

			public static ICancelableCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICancelableCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICancelableCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCancel;
#pragma warning disable 0169
			static Delegate GetOnCancelHandler ()
			{
				if (cb_onCancel == null)
					cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
				return cb_onCancel;
			}

			static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			IntPtr id_onCancel;
			public unsafe void OnCancel ()
			{
				if (id_onCancel == IntPtr.Zero)
					id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
			}

			static Delegate cb_onFinish;
#pragma warning disable 0169
			static Delegate GetOnFinishHandler ()
			{
				if (cb_onFinish == null)
					cb_onFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinish);
				return cb_onFinish;
			}

			static void n_OnFinish (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFinish ();
			}
#pragma warning restore 0169

			IntPtr id_onFinish;
			public unsafe void OnFinish ()
			{
				if (id_onFinish == IntPtr.Zero)
					id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinish);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.InfoWindowAdapter']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$InfoWindowAdapter", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IInfoWindowAdapterInvoker")]
		public partial interface IInfoWindowAdapter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.InfoWindowAdapter']/method[@name='getInfoWindow' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Marker']]"
			[Register ("getInfoWindow", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)Landroid/view/View;", "GetGetInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IInfoWindowAdapterInvoker, Mapbox-SDK-8.4.0")]
			global::Android.Views.View GetInfoWindow (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$InfoWindowAdapter", DoNotGenerateAcw=true)]
		internal class IInfoWindowAdapterInvoker : global::Java.Lang.Object, IInfoWindowAdapter {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$InfoWindowAdapter", typeof (IInfoWindowAdapterInvoker));

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

			public static IInfoWindowAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInfoWindowAdapter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.InfoWindowAdapter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInfoWindowAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_;
#pragma warning disable 0169
			static Delegate GetGetInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler ()
			{
				if (cb_getInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_ == null)
					cb_getInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_);
				return cb_getInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			}

			static IntPtr n_GetInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IInfoWindowAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInfoWindow (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			public unsafe global::Android.Views.View GetInfoWindow (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				if (id_getInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_ == IntPtr.Zero)
					id_getInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNIEnv.GetMethodID (class_ref, "getInfoWindow", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)Landroid/view/View;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfoWindow_Lcom_mapbox_mapboxsdk_annotations_Marker_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraIdleListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraIdleListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraIdleListenerInvoker")]
		public partial interface IOnCameraIdleListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraIdleListener']/method[@name='onCameraIdle' and count(parameter)=0]"
			[Register ("onCameraIdle", "()V", "GetOnCameraIdleHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraIdleListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnCameraIdle ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraIdleListener", DoNotGenerateAcw=true)]
		internal class IOnCameraIdleListenerInvoker : global::Java.Lang.Object, IOnCameraIdleListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraIdleListener", typeof (IOnCameraIdleListenerInvoker));

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

			public static IOnCameraIdleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCameraIdleListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraIdleListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCameraIdleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraIdle;
#pragma warning disable 0169
			static Delegate GetOnCameraIdleHandler ()
			{
				if (cb_onCameraIdle == null)
					cb_onCameraIdle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraIdle);
				return cb_onCameraIdle;
			}

			static void n_OnCameraIdle (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraIdle ();
			}
#pragma warning restore 0169

			IntPtr id_onCameraIdle;
			public unsafe void OnCameraIdle ()
			{
				if (id_onCameraIdle == IntPtr.Zero)
					id_onCameraIdle = JNIEnv.GetMethodID (class_ref, "onCameraIdle", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraIdle);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCameraIdleListenerImplementor")]
		internal sealed partial class IOnCameraIdleListenerImplementor : global::Java.Lang.Object, IOnCameraIdleListener {

			object sender;

			public IOnCameraIdleListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCameraIdleListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnCameraIdle ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnCameraIdleListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraMoveCanceledListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveCanceledListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraMoveCanceledListenerInvoker")]
		public partial interface IOnCameraMoveCanceledListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraMoveCanceledListener']/method[@name='onCameraMoveCanceled' and count(parameter)=0]"
			[Register ("onCameraMoveCanceled", "()V", "GetOnCameraMoveCanceledHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraMoveCanceledListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnCameraMoveCanceled ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveCanceledListener", DoNotGenerateAcw=true)]
		internal class IOnCameraMoveCanceledListenerInvoker : global::Java.Lang.Object, IOnCameraMoveCanceledListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveCanceledListener", typeof (IOnCameraMoveCanceledListenerInvoker));

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

			public static IOnCameraMoveCanceledListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCameraMoveCanceledListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveCanceledListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCameraMoveCanceledListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraMoveCanceled;
#pragma warning disable 0169
			static Delegate GetOnCameraMoveCanceledHandler ()
			{
				if (cb_onCameraMoveCanceled == null)
					cb_onCameraMoveCanceled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraMoveCanceled);
				return cb_onCameraMoveCanceled;
			}

			static void n_OnCameraMoveCanceled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraMoveCanceled ();
			}
#pragma warning restore 0169

			IntPtr id_onCameraMoveCanceled;
			public unsafe void OnCameraMoveCanceled ()
			{
				if (id_onCameraMoveCanceled == IntPtr.Zero)
					id_onCameraMoveCanceled = JNIEnv.GetMethodID (class_ref, "onCameraMoveCanceled", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraMoveCanceled);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCameraMoveCanceledListenerImplementor")]
		internal sealed partial class IOnCameraMoveCanceledListenerImplementor : global::Java.Lang.Object, IOnCameraMoveCanceledListener {

			object sender;

			public IOnCameraMoveCanceledListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCameraMoveCanceledListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnCameraMoveCanceled ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnCameraMoveCanceledListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraMoveListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraMoveListenerInvoker")]
		public partial interface IOnCameraMoveListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraMoveListener']/method[@name='onCameraMove' and count(parameter)=0]"
			[Register ("onCameraMove", "()V", "GetOnCameraMoveHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraMoveListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnCameraMove ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveListener", DoNotGenerateAcw=true)]
		internal class IOnCameraMoveListenerInvoker : global::Java.Lang.Object, IOnCameraMoveListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveListener", typeof (IOnCameraMoveListenerInvoker));

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

			public static IOnCameraMoveListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCameraMoveListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCameraMoveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraMove;
#pragma warning disable 0169
			static Delegate GetOnCameraMoveHandler ()
			{
				if (cb_onCameraMove == null)
					cb_onCameraMove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraMove);
				return cb_onCameraMove;
			}

			static void n_OnCameraMove (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraMove ();
			}
#pragma warning restore 0169

			IntPtr id_onCameraMove;
			public unsafe void OnCameraMove ()
			{
				if (id_onCameraMove == IntPtr.Zero)
					id_onCameraMove = JNIEnv.GetMethodID (class_ref, "onCameraMove", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraMove);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCameraMoveListenerImplementor")]
		internal sealed partial class IOnCameraMoveListenerImplementor : global::Java.Lang.Object, IOnCameraMoveListener {

			object sender;

			public IOnCameraMoveListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCameraMoveListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnCameraMove ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnCameraMoveListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveStartedListener", DoNotGenerateAcw=true)]
		public abstract class OnCameraMoveStartedListener : Java.Lang.Object {

			internal OnCameraMoveStartedListener ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraMoveStartedListener']/field[@name='REASON_API_ANIMATION']"
			[Register ("REASON_API_ANIMATION")]
			public const int ReasonApiAnimation = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraMoveStartedListener']/field[@name='REASON_API_GESTURE']"
			[Register ("REASON_API_GESTURE")]
			public const int ReasonApiGesture = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraMoveStartedListener']/field[@name='REASON_DEVELOPER_ANIMATION']"
			[Register ("REASON_DEVELOPER_ANIMATION")]
			public const int ReasonDeveloperAnimation = (int) 2;
		}

		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveStartedListener", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'OnCameraMoveStartedListener' type. This type will be removed in a future release.")]
		public abstract class OnCameraMoveStartedListenerConsts : OnCameraMoveStartedListener {

			private OnCameraMoveStartedListenerConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraMoveStartedListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveStartedListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraMoveStartedListenerInvoker")]
		public partial interface IOnCameraMoveStartedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCameraMoveStartedListener']/method[@name='onCameraMoveStarted' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onCameraMoveStarted", "(I)V", "GetOnCameraMoveStarted_IHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraMoveStartedListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnCameraMoveStarted (int p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveStartedListener", DoNotGenerateAcw=true)]
		internal class IOnCameraMoveStartedListenerInvoker : global::Java.Lang.Object, IOnCameraMoveStartedListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveStartedListener", typeof (IOnCameraMoveStartedListenerInvoker));

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

			public static IOnCameraMoveStartedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCameraMoveStartedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveStartedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCameraMoveStartedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraMoveStarted_I;
#pragma warning disable 0169
			static Delegate GetOnCameraMoveStarted_IHandler ()
			{
				if (cb_onCameraMoveStarted_I == null)
					cb_onCameraMoveStarted_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnCameraMoveStarted_I);
				return cb_onCameraMoveStarted_I;
			}

			static void n_OnCameraMoveStarted_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraMoveStarted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraMoveStarted_I;
			public unsafe void OnCameraMoveStarted (int p0)
			{
				if (id_onCameraMoveStarted_I == IntPtr.Zero)
					id_onCameraMoveStarted_I = JNIEnv.GetMethodID (class_ref, "onCameraMoveStarted", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraMoveStarted_I, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveStartedListener.onCameraMoveStarted
		public partial class CameraMoveStartedEventArgs : global::System.EventArgs {

			public CameraMoveStartedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCameraMoveStartedListenerImplementor")]
		internal sealed partial class IOnCameraMoveStartedListenerImplementor : global::Java.Lang.Object, IOnCameraMoveStartedListener {

			object sender;

			public IOnCameraMoveStartedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCameraMoveStartedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CameraMoveStartedEventArgs> Handler;
#pragma warning restore 0649

			public void OnCameraMoveStarted (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CameraMoveStartedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCameraMoveStartedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCompassAnimationListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCompassAnimationListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCompassAnimationListenerInvoker")]
		public partial interface IOnCompassAnimationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCompassAnimationListener']/method[@name='onCompassAnimation' and count(parameter)=0]"
			[Register ("onCompassAnimation", "()V", "GetOnCompassAnimationHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCompassAnimationListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnCompassAnimation ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnCompassAnimationListener']/method[@name='onCompassAnimationFinished' and count(parameter)=0]"
			[Register ("onCompassAnimationFinished", "()V", "GetOnCompassAnimationFinishedHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCompassAnimationListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnCompassAnimationFinished ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCompassAnimationListener", DoNotGenerateAcw=true)]
		internal class IOnCompassAnimationListenerInvoker : global::Java.Lang.Object, IOnCompassAnimationListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnCompassAnimationListener", typeof (IOnCompassAnimationListenerInvoker));

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

			public static IOnCompassAnimationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCompassAnimationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnCompassAnimationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCompassAnimationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCompassAnimation;
#pragma warning disable 0169
			static Delegate GetOnCompassAnimationHandler ()
			{
				if (cb_onCompassAnimation == null)
					cb_onCompassAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCompassAnimation);
				return cb_onCompassAnimation;
			}

			static void n_OnCompassAnimation (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCompassAnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCompassAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCompassAnimation ();
			}
#pragma warning restore 0169

			IntPtr id_onCompassAnimation;
			public unsafe void OnCompassAnimation ()
			{
				if (id_onCompassAnimation == IntPtr.Zero)
					id_onCompassAnimation = JNIEnv.GetMethodID (class_ref, "onCompassAnimation", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompassAnimation);
			}

			static Delegate cb_onCompassAnimationFinished;
#pragma warning disable 0169
			static Delegate GetOnCompassAnimationFinishedHandler ()
			{
				if (cb_onCompassAnimationFinished == null)
					cb_onCompassAnimationFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCompassAnimationFinished);
				return cb_onCompassAnimationFinished;
			}

			static void n_OnCompassAnimationFinished (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCompassAnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCompassAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCompassAnimationFinished ();
			}
#pragma warning restore 0169

			IntPtr id_onCompassAnimationFinished;
			public unsafe void OnCompassAnimationFinished ()
			{
				if (id_onCompassAnimationFinished == IntPtr.Zero)
					id_onCompassAnimationFinished = JNIEnv.GetMethodID (class_ref, "onCompassAnimationFinished", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompassAnimationFinished);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCompassAnimationListenerImplementor")]
		internal sealed partial class IOnCompassAnimationListenerImplementor : global::Java.Lang.Object, IOnCompassAnimationListener {

			object sender;

			public IOnCompassAnimationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnCompassAnimationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnCompassAnimationHandler;
#pragma warning restore 0649

			public void OnCompassAnimation ()
			{
				var __h = OnCompassAnimationHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnCompassAnimationFinishedHandler;
#pragma warning restore 0649

			public void OnCompassAnimationFinished ()
			{
				var __h = OnCompassAnimationFinishedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnCompassAnimationListenerImplementor value)
			{
				return value.OnCompassAnimationHandler == null && value.OnCompassAnimationFinishedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnDeveloperAnimationListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnDeveloperAnimationListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnDeveloperAnimationListenerInvoker")]
		public partial interface IOnDeveloperAnimationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnDeveloperAnimationListener']/method[@name='onDeveloperAnimationStarted' and count(parameter)=0]"
			[Register ("onDeveloperAnimationStarted", "()V", "GetOnDeveloperAnimationStartedHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnDeveloperAnimationListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnDeveloperAnimationStarted ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnDeveloperAnimationListener", DoNotGenerateAcw=true)]
		internal class IOnDeveloperAnimationListenerInvoker : global::Java.Lang.Object, IOnDeveloperAnimationListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnDeveloperAnimationListener", typeof (IOnDeveloperAnimationListenerInvoker));

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

			public static IOnDeveloperAnimationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDeveloperAnimationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnDeveloperAnimationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDeveloperAnimationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDeveloperAnimationStarted;
#pragma warning disable 0169
			static Delegate GetOnDeveloperAnimationStartedHandler ()
			{
				if (cb_onDeveloperAnimationStarted == null)
					cb_onDeveloperAnimationStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDeveloperAnimationStarted);
				return cb_onDeveloperAnimationStarted;
			}

			static void n_OnDeveloperAnimationStarted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnDeveloperAnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnDeveloperAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDeveloperAnimationStarted ();
			}
#pragma warning restore 0169

			IntPtr id_onDeveloperAnimationStarted;
			public unsafe void OnDeveloperAnimationStarted ()
			{
				if (id_onDeveloperAnimationStarted == IntPtr.Zero)
					id_onDeveloperAnimationStarted = JNIEnv.GetMethodID (class_ref, "onDeveloperAnimationStarted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeveloperAnimationStarted);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnDeveloperAnimationListenerImplementor")]
		internal sealed partial class IOnDeveloperAnimationListenerImplementor : global::Java.Lang.Object, IOnDeveloperAnimationListener {

			object sender;

			public IOnDeveloperAnimationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnDeveloperAnimationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnDeveloperAnimationStarted ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnDeveloperAnimationListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnFlingListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnFlingListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnFlingListenerInvoker")]
		public partial interface IOnFlingListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnFlingListener']/method[@name='onFling' and count(parameter)=0]"
			[Register ("onFling", "()V", "GetOnFlingHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnFlingListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnFling ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnFlingListener", DoNotGenerateAcw=true)]
		internal class IOnFlingListenerInvoker : global::Java.Lang.Object, IOnFlingListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnFlingListener", typeof (IOnFlingListenerInvoker));

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

			public static IOnFlingListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnFlingListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnFlingListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnFlingListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFling;
#pragma warning disable 0169
			static Delegate GetOnFlingHandler ()
			{
				if (cb_onFling == null)
					cb_onFling = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFling);
				return cb_onFling;
			}

			static void n_OnFling (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFling ();
			}
#pragma warning restore 0169

			IntPtr id_onFling;
			public unsafe void OnFling ()
			{
				if (id_onFling == IntPtr.Zero)
					id_onFling = JNIEnv.GetMethodID (class_ref, "onFling", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFling);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnFlingListenerImplementor")]
		internal sealed partial class IOnFlingListenerImplementor : global::Java.Lang.Object, IOnFlingListener {

			object sender;

			public IOnFlingListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnFlingListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnFling ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnFlingListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnFpsChangedListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnFpsChangedListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnFpsChangedListenerInvoker")]
		public partial interface IOnFpsChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnFpsChangedListener']/method[@name='onFpsChanged' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("onFpsChanged", "(D)V", "GetOnFpsChanged_DHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnFpsChangedListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnFpsChanged (double p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnFpsChangedListener", DoNotGenerateAcw=true)]
		internal class IOnFpsChangedListenerInvoker : global::Java.Lang.Object, IOnFpsChangedListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnFpsChangedListener", typeof (IOnFpsChangedListenerInvoker));

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

			public static IOnFpsChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnFpsChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnFpsChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnFpsChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFpsChanged_D;
#pragma warning disable 0169
			static Delegate GetOnFpsChanged_DHandler ()
			{
				if (cb_onFpsChanged_D == null)
					cb_onFpsChanged_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_OnFpsChanged_D);
				return cb_onFpsChanged_D;
			}

			static void n_OnFpsChanged_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFpsChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFpsChanged_D;
			public unsafe void OnFpsChanged (double p0)
			{
				if (id_onFpsChanged_D == IntPtr.Zero)
					id_onFpsChanged_D = JNIEnv.GetMethodID (class_ref, "onFpsChanged", "(D)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFpsChanged_D, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnFpsChangedListener.onFpsChanged
		public partial class FpsChangedEventArgs : global::System.EventArgs {

			public FpsChangedEventArgs (double p0)
			{
				this.p0 = p0;
			}

			double p0;
			public double P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnFpsChangedListenerImplementor")]
		internal sealed partial class IOnFpsChangedListenerImplementor : global::Java.Lang.Object, IOnFpsChangedListener {

			object sender;

			public IOnFpsChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnFpsChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FpsChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnFpsChanged (double p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new FpsChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnFpsChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnInfoWindowClickListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowClickListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnInfoWindowClickListenerInvoker")]
		public partial interface IOnInfoWindowClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnInfoWindowClickListener']/method[@name='onInfoWindowClick' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Marker']]"
			[Register ("onInfoWindowClick", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)Z", "GetOnInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnInfoWindowClickListenerInvoker, Mapbox-SDK-8.4.0")]
			bool OnInfoWindowClick (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowClickListener", DoNotGenerateAcw=true)]
		internal class IOnInfoWindowClickListenerInvoker : global::Java.Lang.Object, IOnInfoWindowClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowClickListener", typeof (IOnInfoWindowClickListenerInvoker));

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

			public static IOnInfoWindowClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInfoWindowClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInfoWindowClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_;
#pragma warning disable 0169
			static Delegate GetOnInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler ()
			{
				if (cb_onInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ == null)
					cb_onInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_);
				return cb_onInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			}

			static bool n_OnInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnInfoWindowClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			public unsafe bool OnInfoWindowClick (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				if (id_onInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ == IntPtr.Zero)
					id_onInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNIEnv.GetMethodID (class_ref, "onInfoWindowClick", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_, __args);
				return __ret;
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowClickListener.onInfoWindowClick
		public partial class InfoWindowClickEventArgs : global::System.EventArgs {

			public InfoWindowClickEventArgs (bool handled, global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0;
			public global::Com.Mapbox.Mapboxsdk.Annotations.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnInfoWindowClickListenerImplementor")]
		internal sealed partial class IOnInfoWindowClickListenerImplementor : global::Java.Lang.Object, IOnInfoWindowClickListener {

			object sender;

			public IOnInfoWindowClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnInfoWindowClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InfoWindowClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnInfoWindowClick (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new InfoWindowClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnInfoWindowClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnInfoWindowCloseListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowCloseListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnInfoWindowCloseListenerInvoker")]
		public partial interface IOnInfoWindowCloseListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnInfoWindowCloseListener']/method[@name='onInfoWindowClose' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Marker']]"
			[Register ("onInfoWindowClose", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)V", "GetOnInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnInfoWindowCloseListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnInfoWindowClose (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowCloseListener", DoNotGenerateAcw=true)]
		internal class IOnInfoWindowCloseListenerInvoker : global::Java.Lang.Object, IOnInfoWindowCloseListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowCloseListener", typeof (IOnInfoWindowCloseListenerInvoker));

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

			public static IOnInfoWindowCloseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInfoWindowCloseListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowCloseListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInfoWindowCloseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_;
#pragma warning disable 0169
			static Delegate GetOnInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler ()
			{
				if (cb_onInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_ == null)
					cb_onInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_);
				return cb_onInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			}

			static void n_OnInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInfoWindowClose (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			public unsafe void OnInfoWindowClose (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				if (id_onInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_ == IntPtr.Zero)
					id_onInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNIEnv.GetMethodID (class_ref, "onInfoWindowClose", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowCloseListener.onInfoWindowClose
		public partial class InfoWindowCloseEventArgs : global::System.EventArgs {

			public InfoWindowCloseEventArgs (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0;
			public global::Com.Mapbox.Mapboxsdk.Annotations.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnInfoWindowCloseListenerImplementor")]
		internal sealed partial class IOnInfoWindowCloseListenerImplementor : global::Java.Lang.Object, IOnInfoWindowCloseListener {

			object sender;

			public IOnInfoWindowCloseListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnInfoWindowCloseListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InfoWindowCloseEventArgs> Handler;
#pragma warning restore 0649

			public void OnInfoWindowClose (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new InfoWindowCloseEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnInfoWindowCloseListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnInfoWindowLongClickListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowLongClickListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnInfoWindowLongClickListenerInvoker")]
		public partial interface IOnInfoWindowLongClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnInfoWindowLongClickListener']/method[@name='onInfoWindowLongClick' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Marker']]"
			[Register ("onInfoWindowLongClick", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)V", "GetOnInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnInfoWindowLongClickListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnInfoWindowLongClick (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnInfoWindowLongClickListenerInvoker : global::Java.Lang.Object, IOnInfoWindowLongClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowLongClickListener", typeof (IOnInfoWindowLongClickListenerInvoker));

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

			public static IOnInfoWindowLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInfoWindowLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInfoWindowLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_;
#pragma warning disable 0169
			static Delegate GetOnInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler ()
			{
				if (cb_onInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ == null)
					cb_onInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_);
				return cb_onInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			}

			static void n_OnInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInfoWindowLongClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			public unsafe void OnInfoWindowLongClick (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				if (id_onInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ == IntPtr.Zero)
					id_onInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNIEnv.GetMethodID (class_ref, "onInfoWindowLongClick", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowLongClickListener.onInfoWindowLongClick
		public partial class InfoWindowLongClickEventArgs : global::System.EventArgs {

			public InfoWindowLongClickEventArgs (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0;
			public global::Com.Mapbox.Mapboxsdk.Annotations.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnInfoWindowLongClickListenerImplementor")]
		internal sealed partial class IOnInfoWindowLongClickListenerImplementor : global::Java.Lang.Object, IOnInfoWindowLongClickListener {

			object sender;

			public IOnInfoWindowLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnInfoWindowLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InfoWindowLongClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnInfoWindowLongClick (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new InfoWindowLongClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnInfoWindowLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnMapClickListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnMapClickListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnMapClickListenerInvoker")]
		public partial interface IOnMapClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnMapClickListener']/method[@name='onMapClick' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
			[Register ("onMapClick", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Z", "GetOnMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnMapClickListenerInvoker, Mapbox-SDK-8.4.0")]
			bool OnMapClick (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnMapClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapClickListenerInvoker : global::Java.Lang.Object, IOnMapClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnMapClickListener", typeof (IOnMapClickListenerInvoker));

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

			public static IOnMapClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnMapClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
			{
				if (cb_onMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
					cb_onMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
				return cb_onMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
			}

			static bool n_OnMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMapClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
			public unsafe bool OnMapClick (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0)
			{
				if (id_onMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == IntPtr.Zero)
					id_onMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapClick", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_, __args);
				return __ret;
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnMapClickListener.onMapClick
		public partial class MapClickEventArgs : global::System.EventArgs {

			public MapClickEventArgs (bool handled, global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0;
			public global::Com.Mapbox.Mapboxsdk.Geometry.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnMapClickListenerImplementor")]
		internal sealed partial class IOnMapClickListenerImplementor : global::Java.Lang.Object, IOnMapClickListener {

			object sender;

			public IOnMapClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnMapClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMapClick (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MapClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMapClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnMapLongClickListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnMapLongClickListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnMapLongClickListenerInvoker")]
		public partial interface IOnMapLongClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnMapLongClickListener']/method[@name='onMapLongClick' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
			[Register ("onMapLongClick", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Z", "GetOnMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnMapLongClickListenerInvoker, Mapbox-SDK-8.4.0")]
			bool OnMapLongClick (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnMapLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapLongClickListenerInvoker : global::Java.Lang.Object, IOnMapLongClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnMapLongClickListener", typeof (IOnMapLongClickListenerInvoker));

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

			public static IOnMapLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnMapLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
			{
				if (cb_onMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
					cb_onMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
				return cb_onMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
			}

			static bool n_OnMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMapLongClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
			public unsafe bool OnMapLongClick (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0)
			{
				if (id_onMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == IntPtr.Zero)
					id_onMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapLongClick", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_, __args);
				return __ret;
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnMapLongClickListener.onMapLongClick
		public partial class MapLongClickEventArgs : global::System.EventArgs {

			public MapLongClickEventArgs (bool handled, global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0;
			public global::Com.Mapbox.Mapboxsdk.Geometry.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnMapLongClickListenerImplementor")]
		internal sealed partial class IOnMapLongClickListenerImplementor : global::Java.Lang.Object, IOnMapLongClickListener {

			object sender;

			public IOnMapLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnMapLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapLongClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMapLongClick (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MapLongClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMapLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnMarkerClickListener']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnMarkerClickListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnMarkerClickListenerInvoker")]
		public partial interface IOnMarkerClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnMarkerClickListener']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Marker']]"
			[Register ("onMarkerClick", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)Z", "GetOnMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnMarkerClickListenerInvoker, Mapbox-SDK-8.4.0")]
			bool OnMarkerClick (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnMarkerClickListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerClickListenerInvoker : global::Java.Lang.Object, IOnMarkerClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnMarkerClickListener", typeof (IOnMarkerClickListenerInvoker));

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

			public static IOnMarkerClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnMarkerClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler ()
			{
				if (cb_onMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ == null)
					cb_onMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_);
				return cb_onMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			}

			static bool n_OnMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMarkerClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_;
			public unsafe bool OnMarkerClick (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				if (id_onMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ == IntPtr.Zero)
					id_onMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerClick", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_, __args);
				return __ret;
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnMarkerClickListener.onMarkerClick
		public partial class MarkerClickEventArgs : global::System.EventArgs {

			public MarkerClickEventArgs (bool handled, global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0;
			public global::Com.Mapbox.Mapboxsdk.Annotations.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnMarkerClickListenerImplementor")]
		internal sealed partial class IOnMarkerClickListenerImplementor : global::Java.Lang.Object, IOnMarkerClickListener {

			object sender;

			public IOnMarkerClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnMarkerClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMarkerClick (global::Com.Mapbox.Mapboxsdk.Annotations.Marker p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MarkerClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMarkerClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnPolygonClickListener']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnPolygonClickListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnPolygonClickListenerInvoker")]
		public partial interface IOnPolygonClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnPolygonClickListener']/method[@name='onPolygonClick' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Polygon']]"
			[Register ("onPolygonClick", "(Lcom/mapbox/mapboxsdk/annotations/Polygon;)V", "GetOnPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnPolygonClickListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnPolygonClick (global::Com.Mapbox.Mapboxsdk.Annotations.Polygon p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnPolygonClickListener", DoNotGenerateAcw=true)]
		internal class IOnPolygonClickListenerInvoker : global::Java.Lang.Object, IOnPolygonClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnPolygonClickListener", typeof (IOnPolygonClickListenerInvoker));

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

			public static IOnPolygonClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPolygonClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnPolygonClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPolygonClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_;
#pragma warning disable 0169
			static Delegate GetOnPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_Handler ()
			{
				if (cb_onPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_ == null)
					cb_onPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_);
				return cb_onPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_;
			}

			static void n_OnPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Annotations.Polygon p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Polygon> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPolygonClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_;
			public unsafe void OnPolygonClick (global::Com.Mapbox.Mapboxsdk.Annotations.Polygon p0)
			{
				if (id_onPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_ == IntPtr.Zero)
					id_onPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_ = JNIEnv.GetMethodID (class_ref, "onPolygonClick", "(Lcom/mapbox/mapboxsdk/annotations/Polygon;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnPolygonClickListener.onPolygonClick
		public partial class PolygonClickEventArgs : global::System.EventArgs {

			public PolygonClickEventArgs (global::Com.Mapbox.Mapboxsdk.Annotations.Polygon p0)
			{
				this.p0 = p0;
			}

			global::Com.Mapbox.Mapboxsdk.Annotations.Polygon p0;
			public global::Com.Mapbox.Mapboxsdk.Annotations.Polygon P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnPolygonClickListenerImplementor")]
		internal sealed partial class IOnPolygonClickListenerImplementor : global::Java.Lang.Object, IOnPolygonClickListener {

			object sender;

			public IOnPolygonClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnPolygonClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PolygonClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnPolygonClick (global::Com.Mapbox.Mapboxsdk.Annotations.Polygon p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PolygonClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnPolygonClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnPolylineClickListener']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnPolylineClickListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnPolylineClickListenerInvoker")]
		public partial interface IOnPolylineClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.OnPolylineClickListener']/method[@name='onPolylineClick' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Polyline']]"
			[Register ("onPolylineClick", "(Lcom/mapbox/mapboxsdk/annotations/Polyline;)V", "GetOnPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnPolylineClickListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnPolylineClick (global::Com.Mapbox.Mapboxsdk.Annotations.Polyline p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$OnPolylineClickListener", DoNotGenerateAcw=true)]
		internal class IOnPolylineClickListenerInvoker : global::Java.Lang.Object, IOnPolylineClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$OnPolylineClickListener", typeof (IOnPolylineClickListenerInvoker));

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

			public static IOnPolylineClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPolylineClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.OnPolylineClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPolylineClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_;
#pragma warning disable 0169
			static Delegate GetOnPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_Handler ()
			{
				if (cb_onPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_ == null)
					cb_onPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_);
				return cb_onPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_;
			}

			static void n_OnPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Annotations.Polyline p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Polyline> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPolylineClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_;
			public unsafe void OnPolylineClick (global::Com.Mapbox.Mapboxsdk.Annotations.Polyline p0)
			{
				if (id_onPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_ == IntPtr.Zero)
					id_onPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_ = JNIEnv.GetMethodID (class_ref, "onPolylineClick", "(Lcom/mapbox/mapboxsdk/annotations/Polyline;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapboxMap.OnPolylineClickListener.onPolylineClick
		public partial class PolylineClickEventArgs : global::System.EventArgs {

			public PolylineClickEventArgs (global::Com.Mapbox.Mapboxsdk.Annotations.Polyline p0)
			{
				this.p0 = p0;
			}

			global::Com.Mapbox.Mapboxsdk.Annotations.Polyline p0;
			public global::Com.Mapbox.Mapboxsdk.Annotations.Polyline P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnPolylineClickListenerImplementor")]
		internal sealed partial class IOnPolylineClickListenerImplementor : global::Java.Lang.Object, IOnPolylineClickListener {

			object sender;

			public IOnPolylineClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapboxMap_OnPolylineClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PolylineClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnPolylineClick (global::Com.Mapbox.Mapboxsdk.Annotations.Polyline p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PolylineClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnPolylineClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.SnapshotReadyCallback']"
		[Register ("com/mapbox/mapboxsdk/maps/MapboxMap$SnapshotReadyCallback", "", "Com.Mapbox.Mapboxsdk.Maps.MapboxMap/ISnapshotReadyCallbackInvoker")]
		public partial interface ISnapshotReadyCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapboxMap.SnapshotReadyCallback']/method[@name='onSnapshotReady' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("onSnapshotReady", "(Landroid/graphics/Bitmap;)V", "GetOnSnapshotReady_Landroid_graphics_Bitmap_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/ISnapshotReadyCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnSnapshotReady (global::Android.Graphics.Bitmap p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapboxMap$SnapshotReadyCallback", DoNotGenerateAcw=true)]
		internal class ISnapshotReadyCallbackInvoker : global::Java.Lang.Object, ISnapshotReadyCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap$SnapshotReadyCallback", typeof (ISnapshotReadyCallbackInvoker));

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

			public static ISnapshotReadyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISnapshotReadyCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapboxMap.SnapshotReadyCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISnapshotReadyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSnapshotReady_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnSnapshotReady_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onSnapshotReady_Landroid_graphics_Bitmap_ == null)
					cb_onSnapshotReady_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSnapshotReady_Landroid_graphics_Bitmap_);
				return cb_onSnapshotReady_Landroid_graphics_Bitmap_;
			}

			static void n_OnSnapshotReady_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ISnapshotReadyCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ISnapshotReadyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSnapshotReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSnapshotReady_Landroid_graphics_Bitmap_;
			public unsafe void OnSnapshotReady (global::Android.Graphics.Bitmap p0)
			{
				if (id_onSnapshotReady_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onSnapshotReady_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onSnapshotReady", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSnapshotReady_Landroid_graphics_Bitmap_, __args);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/MapboxMap", typeof (MapboxMap));
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

		internal MapboxMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		[Obsolete (@"deprecated")]
		public unsafe bool AllowConcurrentMultipleOpenInfoWindows {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='isAllowConcurrentMultipleOpenInfoWindows' and count(parameter)=0]"
			[Register ("isAllowConcurrentMultipleOpenInfoWindows", "()Z", "GetIsAllowConcurrentMultipleOpenInfoWindowsHandler")]
			get {
				const string __id = "isAllowConcurrentMultipleOpenInfoWindows.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setAllowConcurrentMultipleOpenInfoWindows' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowConcurrentMultipleOpenInfoWindows", "(Z)V", "GetSetAllowConcurrentMultipleOpenInfoWindows_ZHandler")]
			set {
				const string __id = "setAllowConcurrentMultipleOpenInfoWindows.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> Annotations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getAnnotations' and count(parameter)=0]"
			[Register ("getAnnotations", "()Ljava/util/List;", "GetGetAnnotationsHandler")]
			get {
				const string __id = "getAnnotations.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition CameraPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getCameraPosition' and count(parameter)=0]"
			[Register ("getCameraPosition", "()Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "GetGetCameraPositionHandler")]
			get {
				const string __id = "getCameraPosition.()Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setCameraPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraPosition']]"
			[Register ("setCameraPosition", "(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)V", "GetSetCameraPosition_Lcom_mapbox_mapboxsdk_camera_CameraPosition_Handler")]
			set {
				const string __id = "setCameraPosition.(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool DebugActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='isDebugActive' and count(parameter)=0]"
			[Register ("isDebugActive", "()Z", "GetIsDebugActiveHandler")]
			get {
				const string __id = "isDebugActive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setDebugActive' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugActive", "(Z)V", "GetSetDebugActive_ZHandler")]
			set {
				const string __id = "setDebugActive.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Android.Gestures.AndroidGesturesManager GesturesManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getGesturesManager' and count(parameter)=0]"
			[Register ("getGesturesManager", "()Lcom/mapbox/android/gestures/AndroidGesturesManager;", "GetGetGesturesManagerHandler")]
			get {
				const string __id = "getGesturesManager.()Lcom/mapbox/android/gestures/AndroidGesturesManager;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IInfoWindowAdapter InfoWindowAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getInfoWindowAdapter' and count(parameter)=0]"
			[Register ("getInfoWindowAdapter", "()Lcom/mapbox/mapboxsdk/maps/MapboxMap$InfoWindowAdapter;", "GetGetInfoWindowAdapterHandler")]
			get {
				const string __id = "getInfoWindowAdapter.()Lcom/mapbox/mapboxsdk/maps/MapboxMap$InfoWindowAdapter;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IInfoWindowAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setInfoWindowAdapter' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.InfoWindowAdapter']]"
			[Register ("setInfoWindowAdapter", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$InfoWindowAdapter;)V", "GetSetInfoWindowAdapter_Lcom_mapbox_mapboxsdk_maps_MapboxMap_InfoWindowAdapter_Handler")]
			set {
				const string __id = "setInfoWindowAdapter.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$InfoWindowAdapter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponent LocationComponent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getLocationComponent' and count(parameter)=0]"
			[Register ("getLocationComponent", "()Lcom/mapbox/mapboxsdk/location/LocationComponent;", "GetGetLocationComponentHandler")]
			get {
				const string __id = "getLocationComponent.()Lcom/mapbox/mapboxsdk/location/LocationComponent;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> Markers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getMarkers' and count(parameter)=0]"
			[Register ("getMarkers", "()Ljava/util/List;", "GetGetMarkersHandler")]
			get {
				const string __id = "getMarkers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.Marker>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe double MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
			[Register ("getMaxZoomLevel", "()D", "GetGetMaxZoomLevelHandler")]
			get {
				const string __id = "getMaxZoomLevel.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe double MinZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getMinZoomLevel' and count(parameter)=0]"
			[Register ("getMinZoomLevel", "()D", "GetGetMinZoomLevelHandler")]
			get {
				const string __id = "getMinZoomLevel.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListener OnInfoWindowClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getOnInfoWindowClickListener' and count(parameter)=0]"
			[Register ("getOnInfoWindowClickListener", "()Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowClickListener;", "GetGetOnInfoWindowClickListenerHandler")]
			get {
				const string __id = "getOnInfoWindowClickListener.()Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowClickListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setOnInfoWindowClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowClickListener']]"
			[Register ("setOnInfoWindowClickListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowClickListener;)V", "GetSetOnInfoWindowClickListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnInfoWindowClickListener_Handler")]
			set {
				const string __id = "setOnInfoWindowClickListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowClickListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListener OnInfoWindowCloseListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getOnInfoWindowCloseListener' and count(parameter)=0]"
			[Register ("getOnInfoWindowCloseListener", "()Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowCloseListener;", "GetGetOnInfoWindowCloseListenerHandler")]
			get {
				const string __id = "getOnInfoWindowCloseListener.()Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowCloseListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setOnInfoWindowCloseListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowCloseListener']]"
			[Register ("setOnInfoWindowCloseListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowCloseListener;)V", "GetSetOnInfoWindowCloseListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnInfoWindowCloseListener_Handler")]
			set {
				const string __id = "setOnInfoWindowCloseListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowCloseListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListener OnInfoWindowLongClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getOnInfoWindowLongClickListener' and count(parameter)=0]"
			[Register ("getOnInfoWindowLongClickListener", "()Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowLongClickListener;", "GetGetOnInfoWindowLongClickListenerHandler")]
			get {
				const string __id = "getOnInfoWindowLongClickListener.()Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowLongClickListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setOnInfoWindowLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowLongClickListener']]"
			[Register ("setOnInfoWindowLongClickListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowLongClickListener;)V", "GetSetOnInfoWindowLongClickListener_Lcom_mapbox_mapboxsdk_maps_MapboxMap_OnInfoWindowLongClickListener_Handler")]
			set {
				const string __id = "setOnInfoWindowLongClickListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnInfoWindowLongClickListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.Polygon> Polygons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getPolygons' and count(parameter)=0]"
			[Register ("getPolygons", "()Ljava/util/List;", "GetGetPolygonsHandler")]
			get {
				const string __id = "getPolygons.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.Polygon>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.Polyline> Polylines {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getPolylines' and count(parameter)=0]"
			[Register ("getPolylines", "()Ljava/util/List;", "GetGetPolylinesHandler")]
			get {
				const string __id = "getPolylines.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.Polyline>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool PrefetchesTiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getPrefetchesTiles' and count(parameter)=0]"
			[Register ("getPrefetchesTiles", "()Z", "GetGetPrefetchesTilesHandler")]
			get {
				const string __id = "getPrefetchesTiles.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setPrefetchesTiles' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPrefetchesTiles", "(Z)V", "GetSetPrefetchesTiles_ZHandler")]
			set {
				const string __id = "setPrefetchesTiles.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Maps.Projection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Lcom/mapbox/mapboxsdk/maps/Projection;", "GetGetProjectionHandler")]
			get {
				const string __id = "getProjection.()Lcom/mapbox/mapboxsdk/maps/Projection;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Projection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> SelectedMarkers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getSelectedMarkers' and count(parameter)=0]"
			[Register ("getSelectedMarkers", "()Ljava/util/List;", "GetGetSelectedMarkersHandler")]
			get {
				const string __id = "getSelectedMarkers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.Marker>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Maps.Style Style {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getStyle' and count(parameter)=0]"
			[Register ("getStyle", "()Lcom/mapbox/mapboxsdk/maps/Style;", "GetGetStyleHandler")]
			get {
				const string __id = "getStyle.()Lcom/mapbox/mapboxsdk/maps/Style;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Style> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Maps.UiSettings UiSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getUiSettings' and count(parameter)=0]"
			[Register ("getUiSettings", "()Lcom/mapbox/mapboxsdk/maps/UiSettings;", "GetGetUiSettingsHandler")]
			get {
				const string __id = "getUiSettings.()Lcom/mapbox/mapboxsdk/maps/UiSettings;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.UiSettings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.BaseMarkerOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addMarker", "(Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;)Lcom/mapbox/mapboxsdk/annotations/Marker;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Marker AddMarker (global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions markerOptions)
		{
			const string __id = "addMarker.(Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;)Lcom/mapbox/mapboxsdk/annotations/Marker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((markerOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) markerOptions).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.MarkerOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addMarker", "(Lcom/mapbox/mapboxsdk/annotations/MarkerOptions;)Lcom/mapbox/mapboxsdk/annotations/Marker;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Marker AddMarker (global::Com.Mapbox.Mapboxsdk.Annotations.MarkerOptions markerOptions)
		{
			const string __id = "addMarker.(Lcom/mapbox/mapboxsdk/annotations/MarkerOptions;)Lcom/mapbox/mapboxsdk/annotations/Marker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((markerOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) markerOptions).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addMarkers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends com.mapbox.mapboxsdk.annotations.BaseMarkerOptions&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("addMarkers", "(Ljava/util/List;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.Marker> AddMarkers (global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions> markerOptionsList)
		{
			const string __id = "addMarkers.(Ljava/util/List;)Ljava/util/List;";
			IntPtr native_markerOptionsList = global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions>.ToLocalJniHandle (markerOptionsList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_markerOptionsList);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.Marker>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_markerOptionsList);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addOnCameraIdleListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraIdleListener']]"
		[Register ("addOnCameraIdleListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraIdleListener;)V", "")]
		public unsafe void AddOnCameraIdleListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListener listener)
		{
			const string __id = "addOnCameraIdleListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraIdleListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addOnCameraMoveCancelListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveCanceledListener']]"
		[Register ("addOnCameraMoveCancelListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveCanceledListener;)V", "")]
		public unsafe void AddOnCameraMoveCancelListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListener listener)
		{
			const string __id = "addOnCameraMoveCancelListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveCanceledListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addOnCameraMoveListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveListener']]"
		[Register ("addOnCameraMoveListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveListener;)V", "")]
		public unsafe void AddOnCameraMoveListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListener listener)
		{
			const string __id = "addOnCameraMoveListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addOnCameraMoveStartedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveStartedListener']]"
		[Register ("addOnCameraMoveStartedListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveStartedListener;)V", "")]
		public unsafe void AddOnCameraMoveStartedListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListener listener)
		{
			const string __id = "addOnCameraMoveStartedListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveStartedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addOnFlingListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnFlingListener']]"
		[Register ("addOnFlingListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnFlingListener;)V", "")]
		public unsafe void AddOnFlingListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListener listener)
		{
			const string __id = "addOnFlingListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnFlingListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addOnMapClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnMapClickListener']]"
		[Register ("addOnMapClickListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMapClickListener;)V", "")]
		public unsafe void AddOnMapClickListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListener listener)
		{
			const string __id = "addOnMapClickListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMapClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addOnMapLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnMapLongClickListener']]"
		[Register ("addOnMapLongClickListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMapLongClickListener;)V", "")]
		public unsafe void AddOnMapLongClickListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListener listener)
		{
			const string __id = "addOnMapLongClickListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMapLongClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addPolygon' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.PolygonOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addPolygon", "(Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;)Lcom/mapbox/mapboxsdk/annotations/Polygon;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Polygon AddPolygon (global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions polygonOptions)
		{
			const string __id = "addPolygon.(Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;)Lcom/mapbox/mapboxsdk/annotations/Polygon;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((polygonOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) polygonOptions).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Polygon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addPolygons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.mapboxsdk.annotations.PolygonOptions&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("addPolygons", "(Ljava/util/List;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.Polygon> AddPolygons (global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions> polygonOptionsList)
		{
			const string __id = "addPolygons.(Ljava/util/List;)Ljava/util/List;";
			IntPtr native_polygonOptionsList = global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions>.ToLocalJniHandle (polygonOptionsList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_polygonOptionsList);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.Polygon>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_polygonOptionsList);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addPolyline' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.PolylineOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addPolyline", "(Lcom/mapbox/mapboxsdk/annotations/PolylineOptions;)Lcom/mapbox/mapboxsdk/annotations/Polyline;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Polyline AddPolyline (global::Com.Mapbox.Mapboxsdk.Annotations.PolylineOptions polylineOptions)
		{
			const string __id = "addPolyline.(Lcom/mapbox/mapboxsdk/annotations/PolylineOptions;)Lcom/mapbox/mapboxsdk/annotations/Polyline;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((polylineOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) polylineOptions).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Polyline> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='addPolylines' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.mapboxsdk.annotations.PolylineOptions&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("addPolylines", "(Ljava/util/List;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.Polyline> AddPolylines (global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.PolylineOptions> polylineOptionsList)
		{
			const string __id = "addPolylines.(Ljava/util/List;)Ljava/util/List;";
			IntPtr native_polylineOptionsList = global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.PolylineOptions>.ToLocalJniHandle (polylineOptionsList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_polylineOptionsList);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.Polyline>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_polylineOptionsList);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='animateCamera' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate']]"
		[Register ("animateCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;)V", "")]
		public unsafe void AnimateCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update)
		{
			const string __id = "animateCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='animateCamera' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("animateCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;Lcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void AnimateCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "animateCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;Lcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='animateCamera' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[2][@type='int']]"
		[Register ("animateCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;I)V", "")]
		public unsafe void AnimateCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, int durationMs)
		{
			const string __id = "animateCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue (durationMs);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='animateCamera' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[2][@type='int'] and parameter[3][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("animateCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;ILcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void AnimateCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, int durationMs, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "animateCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;ILcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue (durationMs);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='cancelAllVelocityAnimations' and count(parameter)=0]"
		[Register ("cancelAllVelocityAnimations", "()V", "")]
		public unsafe void CancelAllVelocityAnimations ()
		{
			const string __id = "cancelAllVelocityAnimations.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='cancelTransitions' and count(parameter)=0]"
		[Register ("cancelTransitions", "()V", "")]
		public unsafe void CancelTransitions ()
		{
			const string __id = "cancelTransitions.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='clear' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='cycleDebugOptions' and count(parameter)=0]"
		[Register ("cycleDebugOptions", "()V", "")]
		public unsafe void CycleDebugOptions ()
		{
			const string __id = "cycleDebugOptions.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='deselectMarker' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Marker']]"
		[Obsolete (@"deprecated")]
		[Register ("deselectMarker", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)V", "")]
		public unsafe void DeselectMarker (global::Com.Mapbox.Mapboxsdk.Annotations.Marker marker)
		{
			const string __id = "deselectMarker.(Lcom/mapbox/mapboxsdk/annotations/Marker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='deselectMarkers' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("deselectMarkers", "()V", "")]
		public unsafe void DeselectMarkers ()
		{
			const string __id = "deselectMarkers.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='easeCamera' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate']]"
		[Register ("easeCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;)V", "")]
		public unsafe void EaseCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update)
		{
			const string __id = "easeCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='easeCamera' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("easeCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;Lcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void EaseCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "easeCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;Lcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='easeCamera' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[2][@type='int']]"
		[Register ("easeCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;I)V", "")]
		public unsafe void EaseCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, int durationMs)
		{
			const string __id = "easeCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue (durationMs);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='easeCamera' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("easeCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;IZ)V", "")]
		public unsafe void EaseCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, int durationMs, bool easingInterpolator)
		{
			const string __id = "easeCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue (durationMs);
				__args [2] = new JniArgumentValue (easingInterpolator);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='easeCamera' and count(parameter)=4 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("easeCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;IZLcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void EaseCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, int durationMs, bool easingInterpolator, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "easeCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;IZLcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue (durationMs);
				__args [2] = new JniArgumentValue (easingInterpolator);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='easeCamera' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[2][@type='int'] and parameter[3][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("easeCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;ILcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void EaseCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, int durationMs, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "easeCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;ILcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue (durationMs);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getAnnotation' and count(parameter)=1 and parameter[1][@type='long']]"
		[Obsolete (@"deprecated")]
		[Register ("getAnnotation", "(J)Lcom/mapbox/mapboxsdk/annotations/Annotation;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Annotation GetAnnotation (long id)
		{
			const string __id = "getAnnotation.(J)Lcom/mapbox/mapboxsdk/annotations/Annotation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getCameraForLatLngBounds' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds']]"
		[Register ("getCameraForLatLngBounds", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraForLatLngBounds (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds latLngBounds)
		{
			const string __id = "getCameraForLatLngBounds.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((latLngBounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLngBounds).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getCameraForLatLngBounds' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("getCameraForLatLngBounds", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;DD)Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraForLatLngBounds (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds latLngBounds, double bearing, double tilt)
		{
			const string __id = "getCameraForLatLngBounds.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;DD)Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((latLngBounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLngBounds).Handle);
				__args [1] = new JniArgumentValue (bearing);
				__args [2] = new JniArgumentValue (tilt);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getCameraForLatLngBounds' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds'] and parameter[2][@type='int[]']]"
		[Register ("getCameraForLatLngBounds", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;[I)Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraForLatLngBounds (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds latLngBounds, int[] padding)
		{
			const string __id = "getCameraForLatLngBounds.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;[I)Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
			IntPtr native_padding = JNIEnv.NewArray (padding);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((latLngBounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLngBounds).Handle);
				__args [1] = new JniArgumentValue (native_padding);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (padding != null) {
					JNIEnv.CopyArray (native_padding, padding);
					JNIEnv.DeleteLocalRef (native_padding);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getCameraForLatLngBounds' and count(parameter)=4 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds'] and parameter[2][@type='int[]'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("getCameraForLatLngBounds", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;[IDD)Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraForLatLngBounds (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds latLngBounds, int[] padding, double bearing, double tilt)
		{
			const string __id = "getCameraForLatLngBounds.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;[IDD)Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
			IntPtr native_padding = JNIEnv.NewArray (padding);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((latLngBounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLngBounds).Handle);
				__args [1] = new JniArgumentValue (native_padding);
				__args [2] = new JniArgumentValue (bearing);
				__args [3] = new JniArgumentValue (tilt);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (padding != null) {
					JNIEnv.CopyArray (native_padding, padding);
					JNIEnv.DeleteLocalRef (native_padding);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getPadding' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("getPadding", "()[I", "")]
		public unsafe int[] GetPadding ()
		{
			const string __id = "getPadding.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='getStyle' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.Style.OnStyleLoaded']]"
		[Register ("getStyle", "(Lcom/mapbox/mapboxsdk/maps/Style$OnStyleLoaded;)V", "")]
		public unsafe void GetStyle (global::Com.Mapbox.Mapboxsdk.Maps.Style.IOnStyleLoaded onStyleLoaded)
		{
			const string __id = "getStyle.(Lcom/mapbox/mapboxsdk/maps/Style$OnStyleLoaded;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onStyleLoaded == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onStyleLoaded).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='moveCamera' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate']]"
		[Register ("moveCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;)V", "")]
		public unsafe void MoveCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update)
		{
			const string __id = "moveCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='moveCamera' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraUpdate'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("moveCamera", "(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;Lcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void MoveCamera (global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate update, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "moveCamera.(Lcom/mapbox/mapboxsdk/camera/CameraUpdate;Lcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeAnnotation' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Annotation']]"
		[Obsolete (@"deprecated")]
		[Register ("removeAnnotation", "(Lcom/mapbox/mapboxsdk/annotations/Annotation;)V", "")]
		public unsafe void RemoveAnnotation (global::Com.Mapbox.Mapboxsdk.Annotations.Annotation annotation)
		{
			const string __id = "removeAnnotation.(Lcom/mapbox/mapboxsdk/annotations/Annotation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((annotation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotation).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeAnnotation' and count(parameter)=1 and parameter[1][@type='long']]"
		[Obsolete (@"deprecated")]
		[Register ("removeAnnotation", "(J)V", "")]
		public unsafe void RemoveAnnotation (long id)
		{
			const string __id = "removeAnnotation.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeAnnotations' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("removeAnnotations", "()V", "")]
		public unsafe void RemoveAnnotations ()
		{
			const string __id = "removeAnnotations.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeAnnotations' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends com.mapbox.mapboxsdk.annotations.Annotation&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("removeAnnotations", "(Ljava/util/List;)V", "")]
		public unsafe void RemoveAnnotations (global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation> annotationList)
		{
			const string __id = "removeAnnotations.(Ljava/util/List;)V";
			IntPtr native_annotationList = global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Annotations.Annotation>.ToLocalJniHandle (annotationList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_annotationList);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_annotationList);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeMarker' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Marker']]"
		[Obsolete (@"deprecated")]
		[Register ("removeMarker", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)V", "")]
		public unsafe void RemoveMarker (global::Com.Mapbox.Mapboxsdk.Annotations.Marker marker)
		{
			const string __id = "removeMarker.(Lcom/mapbox/mapboxsdk/annotations/Marker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeOnCameraIdleListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraIdleListener']]"
		[Register ("removeOnCameraIdleListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraIdleListener;)V", "")]
		public unsafe void RemoveOnCameraIdleListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListener listener)
		{
			const string __id = "removeOnCameraIdleListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraIdleListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeOnCameraMoveCancelListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveCanceledListener']]"
		[Register ("removeOnCameraMoveCancelListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveCanceledListener;)V", "")]
		public unsafe void RemoveOnCameraMoveCancelListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListener listener)
		{
			const string __id = "removeOnCameraMoveCancelListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveCanceledListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeOnCameraMoveListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveListener']]"
		[Register ("removeOnCameraMoveListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveListener;)V", "")]
		public unsafe void RemoveOnCameraMoveListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListener listener)
		{
			const string __id = "removeOnCameraMoveListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeOnCameraMoveStartedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveStartedListener']]"
		[Register ("removeOnCameraMoveStartedListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveStartedListener;)V", "")]
		public unsafe void RemoveOnCameraMoveStartedListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListener listener)
		{
			const string __id = "removeOnCameraMoveStartedListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCameraMoveStartedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeOnFlingListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnFlingListener']]"
		[Register ("removeOnFlingListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnFlingListener;)V", "")]
		public unsafe void RemoveOnFlingListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListener listener)
		{
			const string __id = "removeOnFlingListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnFlingListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeOnMapClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnMapClickListener']]"
		[Register ("removeOnMapClickListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMapClickListener;)V", "")]
		public unsafe void RemoveOnMapClickListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListener listener)
		{
			const string __id = "removeOnMapClickListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMapClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removeOnMapLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnMapLongClickListener']]"
		[Register ("removeOnMapLongClickListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMapLongClickListener;)V", "")]
		public unsafe void RemoveOnMapLongClickListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListener listener)
		{
			const string __id = "removeOnMapLongClickListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMapLongClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removePolygon' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Polygon']]"
		[Obsolete (@"deprecated")]
		[Register ("removePolygon", "(Lcom/mapbox/mapboxsdk/annotations/Polygon;)V", "")]
		public unsafe void RemovePolygon (global::Com.Mapbox.Mapboxsdk.Annotations.Polygon polygon)
		{
			const string __id = "removePolygon.(Lcom/mapbox/mapboxsdk/annotations/Polygon;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((polygon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) polygon).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='removePolyline' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Polyline']]"
		[Obsolete (@"deprecated")]
		[Register ("removePolyline", "(Lcom/mapbox/mapboxsdk/annotations/Polyline;)V", "")]
		public unsafe void RemovePolyline (global::Com.Mapbox.Mapboxsdk.Annotations.Polyline polyline)
		{
			const string __id = "removePolyline.(Lcom/mapbox/mapboxsdk/annotations/Polyline;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((polyline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) polyline).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='resetNorth' and count(parameter)=0]"
		[Register ("resetNorth", "()V", "")]
		public unsafe void ResetNorth ()
		{
			const string __id = "resetNorth.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("scrollBy", "(FF)V", "")]
		public unsafe void ScrollBy (float x, float y)
		{
			const string __id = "scrollBy.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='scrollBy' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='long']]"
		[Register ("scrollBy", "(FFJ)V", "")]
		public unsafe void ScrollBy (float x, float y, long duration)
		{
			const string __id = "scrollBy.(FFJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (duration);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='selectMarker' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Marker']]"
		[Obsolete (@"deprecated")]
		[Register ("selectMarker", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)V", "")]
		public unsafe void SelectMarker (global::Com.Mapbox.Mapboxsdk.Annotations.Marker marker)
		{
			const string __id = "selectMarker.(Lcom/mapbox/mapboxsdk/annotations/Marker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setFocalBearing' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='long']]"
		[Register ("setFocalBearing", "(DFFJ)V", "")]
		public unsafe void SetFocalBearing (double bearing, float focalX, float focalY, long duration)
		{
			const string __id = "setFocalBearing.(DFFJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (bearing);
				__args [1] = new JniArgumentValue (focalX);
				__args [2] = new JniArgumentValue (focalY);
				__args [3] = new JniArgumentValue (duration);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setGesturesManager' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.AndroidGesturesManager'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("setGesturesManager", "(Lcom/mapbox/android/gestures/AndroidGesturesManager;ZZ)V", "")]
		public unsafe void SetGesturesManager (global::Com.Mapbox.Android.Gestures.AndroidGesturesManager androidGesturesManager, bool attachDefaultListeners, bool setDefaultMutuallyExclusives)
		{
			const string __id = "setGesturesManager.(Lcom/mapbox/android/gestures/AndroidGesturesManager;ZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((androidGesturesManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) androidGesturesManager).Handle);
				__args [1] = new JniArgumentValue (attachDefaultListeners);
				__args [2] = new JniArgumentValue (setDefaultMutuallyExclusives);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setLatLngBoundsForCameraTarget' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds']]"
		[Register ("setLatLngBoundsForCameraTarget", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)V", "")]
		public unsafe void SetLatLngBoundsForCameraTarget (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds latLngBounds)
		{
			const string __id = "setLatLngBoundsForCameraTarget.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((latLngBounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLngBounds).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setMaxZoomPreference' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setMaxZoomPreference", "(D)V", "")]
		public unsafe void SetMaxZoomPreference (double maxZoom)
		{
			const string __id = "setMaxZoomPreference.(D)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxZoom);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setMinZoomPreference' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setMinZoomPreference", "(D)V", "")]
		public unsafe void SetMinZoomPreference (double minZoom)
		{
			const string __id = "setMinZoomPreference.(D)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minZoom);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setOfflineRegionDefinition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegionDefinition']]"
		[Register ("setOfflineRegionDefinition", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;)V", "")]
		public unsafe void SetOfflineRegionDefinition (global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition definition)
		{
			const string __id = "setOfflineRegionDefinition.(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((definition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) definition).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setOfflineRegionDefinition' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegionDefinition'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Style.OnStyleLoaded']]"
		[Register ("setOfflineRegionDefinition", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;Lcom/mapbox/mapboxsdk/maps/Style$OnStyleLoaded;)V", "")]
		public unsafe void SetOfflineRegionDefinition (global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition definition, global::Com.Mapbox.Mapboxsdk.Maps.Style.IOnStyleLoaded @callback)
		{
			const string __id = "setOfflineRegionDefinition.(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;Lcom/mapbox/mapboxsdk/maps/Style$OnStyleLoaded;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((definition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) definition).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setOnFpsChangedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnFpsChangedListener']]"
		[Register ("setOnFpsChangedListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnFpsChangedListener;)V", "")]
		public unsafe void SetOnFpsChangedListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener listener)
		{
			const string __id = "setOnFpsChangedListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnFpsChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setOnMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnMarkerClickListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnMarkerClickListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMarkerClickListener;)V", "")]
		public unsafe void SetOnMarkerClickListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListener listener)
		{
			const string __id = "setOnMarkerClickListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnMarkerClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setOnPolygonClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnPolygonClickListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnPolygonClickListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnPolygonClickListener;)V", "")]
		public unsafe void SetOnPolygonClickListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListener listener)
		{
			const string __id = "setOnPolygonClickListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnPolygonClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setOnPolylineClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnPolylineClickListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnPolylineClickListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnPolylineClickListener;)V", "")]
		public unsafe void SetOnPolylineClickListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListener listener)
		{
			const string __id = "setOnPolylineClickListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnPolylineClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setPadding' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setPadding", "(IIII)V", "")]
		public unsafe void SetPadding (int left, int top, int right, int bottom)
		{
			const string __id = "setPadding.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setStyle' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.Style.Builder']]"
		[Register ("setStyle", "(Lcom/mapbox/mapboxsdk/maps/Style$Builder;)V", "")]
		public unsafe void SetStyle (global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder builder)
		{
			const string __id = "setStyle.(Lcom/mapbox/mapboxsdk/maps/Style$Builder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setStyle' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.maps.Style.Builder'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Style.OnStyleLoaded']]"
		[Register ("setStyle", "(Lcom/mapbox/mapboxsdk/maps/Style$Builder;Lcom/mapbox/mapboxsdk/maps/Style$OnStyleLoaded;)V", "")]
		public unsafe void SetStyle (global::Com.Mapbox.Mapboxsdk.Maps.Style.Builder builder, global::Com.Mapbox.Mapboxsdk.Maps.Style.IOnStyleLoaded @callback)
		{
			const string __id = "setStyle.(Lcom/mapbox/mapboxsdk/maps/Style$Builder;Lcom/mapbox/mapboxsdk/maps/Style$OnStyleLoaded;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setStyle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setStyle", "(Ljava/lang/String;)V", "")]
		public unsafe void SetStyle ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Maps.Style", Fields = new string [] {"MapboxStreets", "Outdoors", "Light", "Dark", "Satellite", "SatelliteStreets", "TrafficDay", "TrafficNight"})]string style)
		{
			const string __id = "setStyle.(Ljava/lang/String;)V";
			IntPtr native_style = JNIEnv.NewString (style);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_style);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_style);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='setStyle' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Style.OnStyleLoaded']]"
		[Register ("setStyle", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/maps/Style$OnStyleLoaded;)V", "")]
		public unsafe void SetStyle ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Maps.Style", Fields = new string [] {"MapboxStreets", "Outdoors", "Light", "Dark", "Satellite", "SatelliteStreets", "TrafficDay", "TrafficNight"})]string style, global::Com.Mapbox.Mapboxsdk.Maps.Style.IOnStyleLoaded @callback)
		{
			const string __id = "setStyle.(Ljava/lang/String;Lcom/mapbox/mapboxsdk/maps/Style$OnStyleLoaded;)V";
			IntPtr native_style = JNIEnv.NewString (style);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_style);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_style);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='snapshot' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.SnapshotReadyCallback']]"
		[Register ("snapshot", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$SnapshotReadyCallback;)V", "")]
		public unsafe void Snapshot (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ISnapshotReadyCallback @callback)
		{
			const string __id = "snapshot.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$SnapshotReadyCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='updateMarker' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Marker']]"
		[Obsolete (@"deprecated")]
		[Register ("updateMarker", "(Lcom/mapbox/mapboxsdk/annotations/Marker;)V", "")]
		public unsafe void UpdateMarker (global::Com.Mapbox.Mapboxsdk.Annotations.Marker updatedMarker)
		{
			const string __id = "updateMarker.(Lcom/mapbox/mapboxsdk/annotations/Marker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((updatedMarker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) updatedMarker).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='updatePolygon' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Polygon']]"
		[Obsolete (@"deprecated")]
		[Register ("updatePolygon", "(Lcom/mapbox/mapboxsdk/annotations/Polygon;)V", "")]
		public unsafe void UpdatePolygon (global::Com.Mapbox.Mapboxsdk.Annotations.Polygon polygon)
		{
			const string __id = "updatePolygon.(Lcom/mapbox/mapboxsdk/annotations/Polygon;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((polygon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) polygon).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapboxMap']/method[@name='updatePolyline' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.annotations.Polyline']]"
		[Obsolete (@"deprecated")]
		[Register ("updatePolyline", "(Lcom/mapbox/mapboxsdk/annotations/Polyline;)V", "")]
		public unsafe void UpdatePolyline (global::Com.Mapbox.Mapboxsdk.Annotations.Polyline polyline)
		{
			const string __id = "updatePolyline.(Lcom/mapbox/mapboxsdk/annotations/Polyline;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((polyline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) polyline).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListener"
		public event EventHandler CameraIdle {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListenerImplementor>(
						ref weak_implementor_AddOnCameraIdleListener,
						__CreateIOnCameraIdleListenerImplementor,
						AddOnCameraIdleListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListenerImplementor>(
						ref weak_implementor_AddOnCameraIdleListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListenerImplementor.__IsEmpty,
						__v => RemoveOnCameraIdleListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnCameraIdleListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListenerImplementor __CreateIOnCameraIdleListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraIdleListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListener"
		public event EventHandler CameraMoveCancel {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListenerImplementor>(
						ref weak_implementor_AddOnCameraMoveCancelListener,
						__CreateIOnCameraMoveCanceledListenerImplementor,
						AddOnCameraMoveCancelListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListenerImplementor>(
						ref weak_implementor_AddOnCameraMoveCancelListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListenerImplementor.__IsEmpty,
						__v => RemoveOnCameraMoveCancelListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnCameraMoveCancelListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListenerImplementor __CreateIOnCameraMoveCanceledListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveCanceledListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListener"
		public event EventHandler CameraMove {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListenerImplementor>(
						ref weak_implementor_AddOnCameraMoveListener,
						__CreateIOnCameraMoveListenerImplementor,
						AddOnCameraMoveListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListenerImplementor>(
						ref weak_implementor_AddOnCameraMoveListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListenerImplementor.__IsEmpty,
						__v => RemoveOnCameraMoveListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnCameraMoveListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListenerImplementor __CreateIOnCameraMoveListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.CameraMoveStartedEventArgs> CameraMoveStarted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListenerImplementor>(
						ref weak_implementor_AddOnCameraMoveStartedListener,
						__CreateIOnCameraMoveStartedListenerImplementor,
						AddOnCameraMoveStartedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListenerImplementor>(
						ref weak_implementor_AddOnCameraMoveStartedListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListenerImplementor.__IsEmpty,
						__v => RemoveOnCameraMoveStartedListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnCameraMoveStartedListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListenerImplementor __CreateIOnCameraMoveStartedListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCameraMoveStartedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListener"
		public event EventHandler Fling {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListenerImplementor>(
						ref weak_implementor_AddOnFlingListener,
						__CreateIOnFlingListenerImplementor,
						AddOnFlingListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListenerImplementor>(
						ref weak_implementor_AddOnFlingListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListenerImplementor.__IsEmpty,
						__v => RemoveOnFlingListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnFlingListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListenerImplementor __CreateIOnFlingListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFlingListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.MapClickEventArgs> MapClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_AddOnMapClickListener,
						__CreateIOnMapClickListenerImplementor,
						AddOnMapClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_AddOnMapClickListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListenerImplementor.__IsEmpty,
						__v => RemoveOnMapClickListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnMapClickListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListenerImplementor __CreateIOnMapClickListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.MapLongClickEventArgs> MapLongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_AddOnMapLongClickListener,
						__CreateIOnMapLongClickListenerImplementor,
						AddOnMapLongClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_AddOnMapLongClickListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListenerImplementor.__IsEmpty,
						__v => RemoveOnMapLongClickListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnMapLongClickListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListenerImplementor __CreateIOnMapLongClickListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMapLongClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.FpsChangedEventArgs> FpsChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor>(
						ref weak_implementor_SetOnFpsChangedListener,
						__CreateIOnFpsChangedListenerImplementor,
						SetOnFpsChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor>(
						ref weak_implementor_SetOnFpsChangedListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor.__IsEmpty,
						__v => SetOnFpsChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnFpsChangedListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor __CreateIOnFpsChangedListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnFpsChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.MarkerClickEventArgs> MarkerClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						__CreateIOnMarkerClickListenerImplementor,
						SetOnMarkerClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListenerImplementor.__IsEmpty,
						__v => SetOnMarkerClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerClickListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListenerImplementor __CreateIOnMarkerClickListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnMarkerClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.PolygonClickEventArgs> PolygonClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListenerImplementor>(
						ref weak_implementor_SetOnPolygonClickListener,
						__CreateIOnPolygonClickListenerImplementor,
						SetOnPolygonClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListenerImplementor>(
						ref weak_implementor_SetOnPolygonClickListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListenerImplementor.__IsEmpty,
						__v => SetOnPolygonClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnPolygonClickListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListenerImplementor __CreateIOnPolygonClickListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolygonClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.PolylineClickEventArgs> PolylineClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListenerImplementor>(
						ref weak_implementor_SetOnPolylineClickListener,
						__CreateIOnPolylineClickListenerImplementor,
						SetOnPolylineClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListenerImplementor>(
						ref weak_implementor_SetOnPolylineClickListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListenerImplementor.__IsEmpty,
						__v => SetOnPolylineClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnPolylineClickListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListenerImplementor __CreateIOnPolylineClickListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnPolylineClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.InfoWindowClickEventArgs> InfoWindowClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor___SetOnInfoWindowClickListener,
						__CreateIOnInfoWindowClickListenerImplementor,
						__v => OnInfoWindowClickListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor___SetOnInfoWindowClickListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListenerImplementor.__IsEmpty,
						__v => OnInfoWindowClickListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnInfoWindowClickListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListenerImplementor __CreateIOnInfoWindowClickListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.InfoWindowCloseEventArgs> InfoWindowClose {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListenerImplementor>(
						ref weak_implementor___SetOnInfoWindowCloseListener,
						__CreateIOnInfoWindowCloseListenerImplementor,
						__v => OnInfoWindowCloseListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListenerImplementor>(
						ref weak_implementor___SetOnInfoWindowCloseListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListenerImplementor.__IsEmpty,
						__v => OnInfoWindowCloseListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnInfoWindowCloseListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListenerImplementor __CreateIOnInfoWindowCloseListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowCloseListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.InfoWindowLongClickEventArgs> InfoWindowLongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListenerImplementor>(
						ref weak_implementor___SetOnInfoWindowLongClickListener,
						__CreateIOnInfoWindowLongClickListenerImplementor,
						__v => OnInfoWindowLongClickListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListener, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListenerImplementor>(
						ref weak_implementor___SetOnInfoWindowLongClickListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListenerImplementor.__IsEmpty,
						__v => OnInfoWindowLongClickListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnInfoWindowLongClickListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListenerImplementor __CreateIOnInfoWindowLongClickListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnInfoWindowLongClickListenerImplementor (this);
		}
#endregion
	}
}
