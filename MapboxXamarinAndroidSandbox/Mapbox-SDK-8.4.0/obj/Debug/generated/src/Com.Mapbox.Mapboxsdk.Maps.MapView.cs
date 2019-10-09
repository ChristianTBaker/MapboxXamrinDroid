using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView", DoNotGenerateAcw=true)]
	public partial class MapView : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnCameraDidChangeListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnCameraDidChangeListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCameraDidChangeListenerInvoker")]
		public partial interface IOnCameraDidChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnCameraDidChangeListener']/method[@name='onCameraDidChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onCameraDidChange", "(Z)V", "GetOnCameraDidChange_ZHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCameraDidChangeListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnCameraDidChange (bool p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnCameraDidChangeListener", DoNotGenerateAcw=true)]
		internal class IOnCameraDidChangeListenerInvoker : global::Java.Lang.Object, IOnCameraDidChangeListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnCameraDidChangeListener", typeof (IOnCameraDidChangeListenerInvoker));

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

			public static IOnCameraDidChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCameraDidChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnCameraDidChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCameraDidChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraDidChange_Z;
#pragma warning disable 0169
			static Delegate GetOnCameraDidChange_ZHandler ()
			{
				if (cb_onCameraDidChange_Z == null)
					cb_onCameraDidChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnCameraDidChange_Z);
				return cb_onCameraDidChange_Z;
			}

			static void n_OnCameraDidChange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraDidChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraDidChange_Z;
			public unsafe void OnCameraDidChange (bool p0)
			{
				if (id_onCameraDidChange_Z == IntPtr.Zero)
					id_onCameraDidChange_Z = JNIEnv.GetMethodID (class_ref, "onCameraDidChange", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraDidChange_Z, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapView.OnCameraDidChangeListener.onCameraDidChange
		public partial class CameraDidChangeEventArgs : global::System.EventArgs {

			public CameraDidChangeEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnCameraDidChangeListenerImplementor")]
		internal sealed partial class IOnCameraDidChangeListenerImplementor : global::Java.Lang.Object, IOnCameraDidChangeListener {

			object sender;

			public IOnCameraDidChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnCameraDidChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CameraDidChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnCameraDidChange (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CameraDidChangeEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCameraDidChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnCameraIsChangingListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnCameraIsChangingListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCameraIsChangingListenerInvoker")]
		public partial interface IOnCameraIsChangingListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnCameraIsChangingListener']/method[@name='onCameraIsChanging' and count(parameter)=0]"
			[Register ("onCameraIsChanging", "()V", "GetOnCameraIsChangingHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCameraIsChangingListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnCameraIsChanging ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnCameraIsChangingListener", DoNotGenerateAcw=true)]
		internal class IOnCameraIsChangingListenerInvoker : global::Java.Lang.Object, IOnCameraIsChangingListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnCameraIsChangingListener", typeof (IOnCameraIsChangingListenerInvoker));

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

			public static IOnCameraIsChangingListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCameraIsChangingListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnCameraIsChangingListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCameraIsChangingListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraIsChanging;
#pragma warning disable 0169
			static Delegate GetOnCameraIsChangingHandler ()
			{
				if (cb_onCameraIsChanging == null)
					cb_onCameraIsChanging = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraIsChanging);
				return cb_onCameraIsChanging;
			}

			static void n_OnCameraIsChanging (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraIsChanging ();
			}
#pragma warning restore 0169

			IntPtr id_onCameraIsChanging;
			public unsafe void OnCameraIsChanging ()
			{
				if (id_onCameraIsChanging == IntPtr.Zero)
					id_onCameraIsChanging = JNIEnv.GetMethodID (class_ref, "onCameraIsChanging", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraIsChanging);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnCameraIsChangingListenerImplementor")]
		internal sealed partial class IOnCameraIsChangingListenerImplementor : global::Java.Lang.Object, IOnCameraIsChangingListener {

			object sender;

			public IOnCameraIsChangingListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnCameraIsChangingListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnCameraIsChanging ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnCameraIsChangingListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnCameraWillChangeListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnCameraWillChangeListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCameraWillChangeListenerInvoker")]
		public partial interface IOnCameraWillChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnCameraWillChangeListener']/method[@name='onCameraWillChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onCameraWillChange", "(Z)V", "GetOnCameraWillChange_ZHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCameraWillChangeListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnCameraWillChange (bool p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnCameraWillChangeListener", DoNotGenerateAcw=true)]
		internal class IOnCameraWillChangeListenerInvoker : global::Java.Lang.Object, IOnCameraWillChangeListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnCameraWillChangeListener", typeof (IOnCameraWillChangeListenerInvoker));

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

			public static IOnCameraWillChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCameraWillChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnCameraWillChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCameraWillChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraWillChange_Z;
#pragma warning disable 0169
			static Delegate GetOnCameraWillChange_ZHandler ()
			{
				if (cb_onCameraWillChange_Z == null)
					cb_onCameraWillChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnCameraWillChange_Z);
				return cb_onCameraWillChange_Z;
			}

			static void n_OnCameraWillChange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraWillChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraWillChange_Z;
			public unsafe void OnCameraWillChange (bool p0)
			{
				if (id_onCameraWillChange_Z == IntPtr.Zero)
					id_onCameraWillChange_Z = JNIEnv.GetMethodID (class_ref, "onCameraWillChange", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraWillChange_Z, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapView.OnCameraWillChangeListener.onCameraWillChange
		public partial class CameraWillChangeEventArgs : global::System.EventArgs {

			public CameraWillChangeEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnCameraWillChangeListenerImplementor")]
		internal sealed partial class IOnCameraWillChangeListenerImplementor : global::Java.Lang.Object, IOnCameraWillChangeListener {

			object sender;

			public IOnCameraWillChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnCameraWillChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CameraWillChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnCameraWillChange (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CameraWillChangeEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCameraWillChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnCanRemoveUnusedStyleImageListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnCanRemoveUnusedStyleImageListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCanRemoveUnusedStyleImageListenerInvoker")]
		public partial interface IOnCanRemoveUnusedStyleImageListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnCanRemoveUnusedStyleImageListener']/method[@name='onCanRemoveUnusedStyleImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onCanRemoveUnusedStyleImage", "(Ljava/lang/String;)Z", "GetOnCanRemoveUnusedStyleImage_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCanRemoveUnusedStyleImageListenerInvoker, Mapbox-SDK-8.4.0")]
			bool OnCanRemoveUnusedStyleImage (string p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnCanRemoveUnusedStyleImageListener", DoNotGenerateAcw=true)]
		internal class IOnCanRemoveUnusedStyleImageListenerInvoker : global::Java.Lang.Object, IOnCanRemoveUnusedStyleImageListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnCanRemoveUnusedStyleImageListener", typeof (IOnCanRemoveUnusedStyleImageListenerInvoker));

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

			public static IOnCanRemoveUnusedStyleImageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCanRemoveUnusedStyleImageListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnCanRemoveUnusedStyleImageListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCanRemoveUnusedStyleImageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCanRemoveUnusedStyleImage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnCanRemoveUnusedStyleImage_Ljava_lang_String_Handler ()
			{
				if (cb_onCanRemoveUnusedStyleImage_Ljava_lang_String_ == null)
					cb_onCanRemoveUnusedStyleImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnCanRemoveUnusedStyleImage_Ljava_lang_String_);
				return cb_onCanRemoveUnusedStyleImage_Ljava_lang_String_;
			}

			static bool n_OnCanRemoveUnusedStyleImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCanRemoveUnusedStyleImage (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCanRemoveUnusedStyleImage_Ljava_lang_String_;
			public unsafe bool OnCanRemoveUnusedStyleImage (string p0)
			{
				if (id_onCanRemoveUnusedStyleImage_Ljava_lang_String_ == IntPtr.Zero)
					id_onCanRemoveUnusedStyleImage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCanRemoveUnusedStyleImage", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCanRemoveUnusedStyleImage_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapView.OnCanRemoveUnusedStyleImageListener.onCanRemoveUnusedStyleImage
		public partial class CanRemoveUnusedStyleImageEventArgs : global::System.EventArgs {

			public CanRemoveUnusedStyleImageEventArgs (bool handled, string p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnCanRemoveUnusedStyleImageListenerImplementor")]
		internal sealed partial class IOnCanRemoveUnusedStyleImageListenerImplementor : global::Java.Lang.Object, IOnCanRemoveUnusedStyleImageListener {

			object sender;

			public IOnCanRemoveUnusedStyleImageListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnCanRemoveUnusedStyleImageListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CanRemoveUnusedStyleImageEventArgs> Handler;
#pragma warning restore 0649

			public bool OnCanRemoveUnusedStyleImage (string p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new CanRemoveUnusedStyleImageEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnCanRemoveUnusedStyleImageListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidBecomeIdleListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidBecomeIdleListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidBecomeIdleListenerInvoker")]
		public partial interface IOnDidBecomeIdleListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidBecomeIdleListener']/method[@name='onDidBecomeIdle' and count(parameter)=0]"
			[Register ("onDidBecomeIdle", "()V", "GetOnDidBecomeIdleHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidBecomeIdleListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnDidBecomeIdle ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidBecomeIdleListener", DoNotGenerateAcw=true)]
		internal class IOnDidBecomeIdleListenerInvoker : global::Java.Lang.Object, IOnDidBecomeIdleListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnDidBecomeIdleListener", typeof (IOnDidBecomeIdleListenerInvoker));

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

			public static IOnDidBecomeIdleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDidBecomeIdleListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnDidBecomeIdleListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDidBecomeIdleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDidBecomeIdle;
#pragma warning disable 0169
			static Delegate GetOnDidBecomeIdleHandler ()
			{
				if (cb_onDidBecomeIdle == null)
					cb_onDidBecomeIdle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidBecomeIdle);
				return cb_onDidBecomeIdle;
			}

			static void n_OnDidBecomeIdle (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDidBecomeIdle ();
			}
#pragma warning restore 0169

			IntPtr id_onDidBecomeIdle;
			public unsafe void OnDidBecomeIdle ()
			{
				if (id_onDidBecomeIdle == IntPtr.Zero)
					id_onDidBecomeIdle = JNIEnv.GetMethodID (class_ref, "onDidBecomeIdle", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidBecomeIdle);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidBecomeIdleListenerImplementor")]
		internal sealed partial class IOnDidBecomeIdleListenerImplementor : global::Java.Lang.Object, IOnDidBecomeIdleListener {

			object sender;

			public IOnDidBecomeIdleListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidBecomeIdleListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnDidBecomeIdle ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnDidBecomeIdleListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFailLoadingMapListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFailLoadingMapListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFailLoadingMapListenerInvoker")]
		public partial interface IOnDidFailLoadingMapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFailLoadingMapListener']/method[@name='onDidFailLoadingMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onDidFailLoadingMap", "(Ljava/lang/String;)V", "GetOnDidFailLoadingMap_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFailLoadingMapListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnDidFailLoadingMap (string p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFailLoadingMapListener", DoNotGenerateAcw=true)]
		internal class IOnDidFailLoadingMapListenerInvoker : global::Java.Lang.Object, IOnDidFailLoadingMapListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnDidFailLoadingMapListener", typeof (IOnDidFailLoadingMapListenerInvoker));

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

			public static IOnDidFailLoadingMapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDidFailLoadingMapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnDidFailLoadingMapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDidFailLoadingMapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDidFailLoadingMap_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnDidFailLoadingMap_Ljava_lang_String_Handler ()
			{
				if (cb_onDidFailLoadingMap_Ljava_lang_String_ == null)
					cb_onDidFailLoadingMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidFailLoadingMap_Ljava_lang_String_);
				return cb_onDidFailLoadingMap_Ljava_lang_String_;
			}

			static void n_OnDidFailLoadingMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDidFailLoadingMap (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDidFailLoadingMap_Ljava_lang_String_;
			public unsafe void OnDidFailLoadingMap (string p0)
			{
				if (id_onDidFailLoadingMap_Ljava_lang_String_ == IntPtr.Zero)
					id_onDidFailLoadingMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDidFailLoadingMap", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidFailLoadingMap_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapView.OnDidFailLoadingMapListener.onDidFailLoadingMap
		public partial class DidFailLoadingMapEventArgs : global::System.EventArgs {

			public DidFailLoadingMapEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFailLoadingMapListenerImplementor")]
		internal sealed partial class IOnDidFailLoadingMapListenerImplementor : global::Java.Lang.Object, IOnDidFailLoadingMapListener {

			object sender;

			public IOnDidFailLoadingMapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFailLoadingMapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DidFailLoadingMapEventArgs> Handler;
#pragma warning restore 0649

			public void OnDidFailLoadingMap (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DidFailLoadingMapEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnDidFailLoadingMapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFinishLoadingMapListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingMapListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishLoadingMapListenerInvoker")]
		public partial interface IOnDidFinishLoadingMapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFinishLoadingMapListener']/method[@name='onDidFinishLoadingMap' and count(parameter)=0]"
			[Register ("onDidFinishLoadingMap", "()V", "GetOnDidFinishLoadingMapHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishLoadingMapListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnDidFinishLoadingMap ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingMapListener", DoNotGenerateAcw=true)]
		internal class IOnDidFinishLoadingMapListenerInvoker : global::Java.Lang.Object, IOnDidFinishLoadingMapListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingMapListener", typeof (IOnDidFinishLoadingMapListenerInvoker));

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

			public static IOnDidFinishLoadingMapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDidFinishLoadingMapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnDidFinishLoadingMapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDidFinishLoadingMapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDidFinishLoadingMap;
#pragma warning disable 0169
			static Delegate GetOnDidFinishLoadingMapHandler ()
			{
				if (cb_onDidFinishLoadingMap == null)
					cb_onDidFinishLoadingMap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidFinishLoadingMap);
				return cb_onDidFinishLoadingMap;
			}

			static void n_OnDidFinishLoadingMap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDidFinishLoadingMap ();
			}
#pragma warning restore 0169

			IntPtr id_onDidFinishLoadingMap;
			public unsafe void OnDidFinishLoadingMap ()
			{
				if (id_onDidFinishLoadingMap == IntPtr.Zero)
					id_onDidFinishLoadingMap = JNIEnv.GetMethodID (class_ref, "onDidFinishLoadingMap", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidFinishLoadingMap);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFinishLoadingMapListenerImplementor")]
		internal sealed partial class IOnDidFinishLoadingMapListenerImplementor : global::Java.Lang.Object, IOnDidFinishLoadingMapListener {

			object sender;

			public IOnDidFinishLoadingMapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFinishLoadingMapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnDidFinishLoadingMap ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnDidFinishLoadingMapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFinishLoadingStyleListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingStyleListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishLoadingStyleListenerInvoker")]
		public partial interface IOnDidFinishLoadingStyleListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFinishLoadingStyleListener']/method[@name='onDidFinishLoadingStyle' and count(parameter)=0]"
			[Register ("onDidFinishLoadingStyle", "()V", "GetOnDidFinishLoadingStyleHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishLoadingStyleListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnDidFinishLoadingStyle ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingStyleListener", DoNotGenerateAcw=true)]
		internal class IOnDidFinishLoadingStyleListenerInvoker : global::Java.Lang.Object, IOnDidFinishLoadingStyleListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingStyleListener", typeof (IOnDidFinishLoadingStyleListenerInvoker));

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

			public static IOnDidFinishLoadingStyleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDidFinishLoadingStyleListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnDidFinishLoadingStyleListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDidFinishLoadingStyleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDidFinishLoadingStyle;
#pragma warning disable 0169
			static Delegate GetOnDidFinishLoadingStyleHandler ()
			{
				if (cb_onDidFinishLoadingStyle == null)
					cb_onDidFinishLoadingStyle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidFinishLoadingStyle);
				return cb_onDidFinishLoadingStyle;
			}

			static void n_OnDidFinishLoadingStyle (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDidFinishLoadingStyle ();
			}
#pragma warning restore 0169

			IntPtr id_onDidFinishLoadingStyle;
			public unsafe void OnDidFinishLoadingStyle ()
			{
				if (id_onDidFinishLoadingStyle == IntPtr.Zero)
					id_onDidFinishLoadingStyle = JNIEnv.GetMethodID (class_ref, "onDidFinishLoadingStyle", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidFinishLoadingStyle);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFinishLoadingStyleListenerImplementor")]
		internal sealed partial class IOnDidFinishLoadingStyleListenerImplementor : global::Java.Lang.Object, IOnDidFinishLoadingStyleListener {

			object sender;

			public IOnDidFinishLoadingStyleListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFinishLoadingStyleListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnDidFinishLoadingStyle ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnDidFinishLoadingStyleListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFinishRenderingFrameListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingFrameListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishRenderingFrameListenerInvoker")]
		public partial interface IOnDidFinishRenderingFrameListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFinishRenderingFrameListener']/method[@name='onDidFinishRenderingFrame' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onDidFinishRenderingFrame", "(Z)V", "GetOnDidFinishRenderingFrame_ZHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishRenderingFrameListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnDidFinishRenderingFrame (bool p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingFrameListener", DoNotGenerateAcw=true)]
		internal class IOnDidFinishRenderingFrameListenerInvoker : global::Java.Lang.Object, IOnDidFinishRenderingFrameListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingFrameListener", typeof (IOnDidFinishRenderingFrameListenerInvoker));

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

			public static IOnDidFinishRenderingFrameListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDidFinishRenderingFrameListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingFrameListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDidFinishRenderingFrameListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDidFinishRenderingFrame_Z;
#pragma warning disable 0169
			static Delegate GetOnDidFinishRenderingFrame_ZHandler ()
			{
				if (cb_onDidFinishRenderingFrame_Z == null)
					cb_onDidFinishRenderingFrame_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnDidFinishRenderingFrame_Z);
				return cb_onDidFinishRenderingFrame_Z;
			}

			static void n_OnDidFinishRenderingFrame_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDidFinishRenderingFrame (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDidFinishRenderingFrame_Z;
			public unsafe void OnDidFinishRenderingFrame (bool p0)
			{
				if (id_onDidFinishRenderingFrame_Z == IntPtr.Zero)
					id_onDidFinishRenderingFrame_Z = JNIEnv.GetMethodID (class_ref, "onDidFinishRenderingFrame", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidFinishRenderingFrame_Z, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingFrameListener.onDidFinishRenderingFrame
		public partial class DidFinishRenderingFrameEventArgs : global::System.EventArgs {

			public DidFinishRenderingFrameEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFinishRenderingFrameListenerImplementor")]
		internal sealed partial class IOnDidFinishRenderingFrameListenerImplementor : global::Java.Lang.Object, IOnDidFinishRenderingFrameListener {

			object sender;

			public IOnDidFinishRenderingFrameListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFinishRenderingFrameListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DidFinishRenderingFrameEventArgs> Handler;
#pragma warning restore 0649

			public void OnDidFinishRenderingFrame (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DidFinishRenderingFrameEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnDidFinishRenderingFrameListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFinishRenderingMapListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingMapListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishRenderingMapListenerInvoker")]
		public partial interface IOnDidFinishRenderingMapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnDidFinishRenderingMapListener']/method[@name='onDidFinishRenderingMap' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onDidFinishRenderingMap", "(Z)V", "GetOnDidFinishRenderingMap_ZHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishRenderingMapListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnDidFinishRenderingMap (bool p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingMapListener", DoNotGenerateAcw=true)]
		internal class IOnDidFinishRenderingMapListenerInvoker : global::Java.Lang.Object, IOnDidFinishRenderingMapListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingMapListener", typeof (IOnDidFinishRenderingMapListenerInvoker));

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

			public static IOnDidFinishRenderingMapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDidFinishRenderingMapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingMapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDidFinishRenderingMapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDidFinishRenderingMap_Z;
#pragma warning disable 0169
			static Delegate GetOnDidFinishRenderingMap_ZHandler ()
			{
				if (cb_onDidFinishRenderingMap_Z == null)
					cb_onDidFinishRenderingMap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnDidFinishRenderingMap_Z);
				return cb_onDidFinishRenderingMap_Z;
			}

			static void n_OnDidFinishRenderingMap_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDidFinishRenderingMap (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDidFinishRenderingMap_Z;
			public unsafe void OnDidFinishRenderingMap (bool p0)
			{
				if (id_onDidFinishRenderingMap_Z == IntPtr.Zero)
					id_onDidFinishRenderingMap_Z = JNIEnv.GetMethodID (class_ref, "onDidFinishRenderingMap", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidFinishRenderingMap_Z, __args);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingMapListener.onDidFinishRenderingMap
		public partial class DidFinishRenderingMapEventArgs : global::System.EventArgs {

			public DidFinishRenderingMapEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFinishRenderingMapListenerImplementor")]
		internal sealed partial class IOnDidFinishRenderingMapListenerImplementor : global::Java.Lang.Object, IOnDidFinishRenderingMapListener {

			object sender;

			public IOnDidFinishRenderingMapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnDidFinishRenderingMapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DidFinishRenderingMapEventArgs> Handler;
#pragma warning restore 0649

			public void OnDidFinishRenderingMap (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DidFinishRenderingMapEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnDidFinishRenderingMapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnSourceChangedListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnSourceChangedListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnSourceChangedListenerInvoker")]
		public partial interface IOnSourceChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnSourceChangedListener']/method[@name='onSourceChangedListener' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSourceChangedListener", "(Ljava/lang/String;)V", "GetOnSourceChangedListener_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnSourceChangedListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnSourceChangedListener (string p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnSourceChangedListener", DoNotGenerateAcw=true)]
		internal class IOnSourceChangedListenerInvoker : global::Java.Lang.Object, IOnSourceChangedListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnSourceChangedListener", typeof (IOnSourceChangedListenerInvoker));

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

			public static IOnSourceChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSourceChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnSourceChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSourceChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSourceChangedListener_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSourceChangedListener_Ljava_lang_String_Handler ()
			{
				if (cb_onSourceChangedListener_Ljava_lang_String_ == null)
					cb_onSourceChangedListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSourceChangedListener_Ljava_lang_String_);
				return cb_onSourceChangedListener_Ljava_lang_String_;
			}

			static void n_OnSourceChangedListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSourceChangedListener (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSourceChangedListener_Ljava_lang_String_;
			public unsafe void OnSourceChangedListener (string p0)
			{
				if (id_onSourceChangedListener_Ljava_lang_String_ == IntPtr.Zero)
					id_onSourceChangedListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSourceChangedListener", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSourceChangedListener_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapView.OnSourceChangedListener.onSourceChangedListener
		public partial class SourceChangedEventArgs : global::System.EventArgs {

			public SourceChangedEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnSourceChangedListenerImplementor")]
		internal sealed partial class IOnSourceChangedListenerImplementor : global::Java.Lang.Object, IOnSourceChangedListener {

			object sender;

			public IOnSourceChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnSourceChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SourceChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnSourceChangedListener (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SourceChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnSourceChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnStyleImageMissingListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnStyleImageMissingListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnStyleImageMissingListenerInvoker")]
		public partial interface IOnStyleImageMissingListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnStyleImageMissingListener']/method[@name='onStyleImageMissing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onStyleImageMissing", "(Ljava/lang/String;)V", "GetOnStyleImageMissing_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnStyleImageMissingListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnStyleImageMissing (string p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnStyleImageMissingListener", DoNotGenerateAcw=true)]
		internal class IOnStyleImageMissingListenerInvoker : global::Java.Lang.Object, IOnStyleImageMissingListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnStyleImageMissingListener", typeof (IOnStyleImageMissingListenerInvoker));

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

			public static IOnStyleImageMissingListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnStyleImageMissingListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnStyleImageMissingListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnStyleImageMissingListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onStyleImageMissing_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnStyleImageMissing_Ljava_lang_String_Handler ()
			{
				if (cb_onStyleImageMissing_Ljava_lang_String_ == null)
					cb_onStyleImageMissing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStyleImageMissing_Ljava_lang_String_);
				return cb_onStyleImageMissing_Ljava_lang_String_;
			}

			static void n_OnStyleImageMissing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStyleImageMissing (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStyleImageMissing_Ljava_lang_String_;
			public unsafe void OnStyleImageMissing (string p0)
			{
				if (id_onStyleImageMissing_Ljava_lang_String_ == IntPtr.Zero)
					id_onStyleImageMissing_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStyleImageMissing", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStyleImageMissing_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.mapbox.mapboxsdk.maps.MapView.OnStyleImageMissingListener.onStyleImageMissing
		public partial class StyleImageMissingEventArgs : global::System.EventArgs {

			public StyleImageMissingEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnStyleImageMissingListenerImplementor")]
		internal sealed partial class IOnStyleImageMissingListenerImplementor : global::Java.Lang.Object, IOnStyleImageMissingListener {

			object sender;

			public IOnStyleImageMissingListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnStyleImageMissingListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<StyleImageMissingEventArgs> Handler;
#pragma warning restore 0649

			public void OnStyleImageMissing (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new StyleImageMissingEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnStyleImageMissingListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnWillStartLoadingMapListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnWillStartLoadingMapListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnWillStartLoadingMapListenerInvoker")]
		public partial interface IOnWillStartLoadingMapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnWillStartLoadingMapListener']/method[@name='onWillStartLoadingMap' and count(parameter)=0]"
			[Register ("onWillStartLoadingMap", "()V", "GetOnWillStartLoadingMapHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnWillStartLoadingMapListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnWillStartLoadingMap ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnWillStartLoadingMapListener", DoNotGenerateAcw=true)]
		internal class IOnWillStartLoadingMapListenerInvoker : global::Java.Lang.Object, IOnWillStartLoadingMapListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnWillStartLoadingMapListener", typeof (IOnWillStartLoadingMapListenerInvoker));

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

			public static IOnWillStartLoadingMapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnWillStartLoadingMapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnWillStartLoadingMapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnWillStartLoadingMapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWillStartLoadingMap;
#pragma warning disable 0169
			static Delegate GetOnWillStartLoadingMapHandler ()
			{
				if (cb_onWillStartLoadingMap == null)
					cb_onWillStartLoadingMap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWillStartLoadingMap);
				return cb_onWillStartLoadingMap;
			}

			static void n_OnWillStartLoadingMap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWillStartLoadingMap ();
			}
#pragma warning restore 0169

			IntPtr id_onWillStartLoadingMap;
			public unsafe void OnWillStartLoadingMap ()
			{
				if (id_onWillStartLoadingMap == IntPtr.Zero)
					id_onWillStartLoadingMap = JNIEnv.GetMethodID (class_ref, "onWillStartLoadingMap", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWillStartLoadingMap);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnWillStartLoadingMapListenerImplementor")]
		internal sealed partial class IOnWillStartLoadingMapListenerImplementor : global::Java.Lang.Object, IOnWillStartLoadingMapListener {

			object sender;

			public IOnWillStartLoadingMapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnWillStartLoadingMapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnWillStartLoadingMap ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnWillStartLoadingMapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnWillStartRenderingFrameListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingFrameListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnWillStartRenderingFrameListenerInvoker")]
		public partial interface IOnWillStartRenderingFrameListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnWillStartRenderingFrameListener']/method[@name='onWillStartRenderingFrame' and count(parameter)=0]"
			[Register ("onWillStartRenderingFrame", "()V", "GetOnWillStartRenderingFrameHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnWillStartRenderingFrameListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnWillStartRenderingFrame ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingFrameListener", DoNotGenerateAcw=true)]
		internal class IOnWillStartRenderingFrameListenerInvoker : global::Java.Lang.Object, IOnWillStartRenderingFrameListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingFrameListener", typeof (IOnWillStartRenderingFrameListenerInvoker));

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

			public static IOnWillStartRenderingFrameListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnWillStartRenderingFrameListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnWillStartRenderingFrameListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnWillStartRenderingFrameListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWillStartRenderingFrame;
#pragma warning disable 0169
			static Delegate GetOnWillStartRenderingFrameHandler ()
			{
				if (cb_onWillStartRenderingFrame == null)
					cb_onWillStartRenderingFrame = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWillStartRenderingFrame);
				return cb_onWillStartRenderingFrame;
			}

			static void n_OnWillStartRenderingFrame (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWillStartRenderingFrame ();
			}
#pragma warning restore 0169

			IntPtr id_onWillStartRenderingFrame;
			public unsafe void OnWillStartRenderingFrame ()
			{
				if (id_onWillStartRenderingFrame == IntPtr.Zero)
					id_onWillStartRenderingFrame = JNIEnv.GetMethodID (class_ref, "onWillStartRenderingFrame", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWillStartRenderingFrame);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnWillStartRenderingFrameListenerImplementor")]
		internal sealed partial class IOnWillStartRenderingFrameListenerImplementor : global::Java.Lang.Object, IOnWillStartRenderingFrameListener {

			object sender;

			public IOnWillStartRenderingFrameListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnWillStartRenderingFrameListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnWillStartRenderingFrame ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnWillStartRenderingFrameListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnWillStartRenderingMapListener']"
		[Register ("com/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingMapListener", "", "Com.Mapbox.Mapboxsdk.Maps.MapView/IOnWillStartRenderingMapListenerInvoker")]
		public partial interface IOnWillStartRenderingMapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/interface[@name='MapView.OnWillStartRenderingMapListener']/method[@name='onWillStartRenderingMap' and count(parameter)=0]"
			[Register ("onWillStartRenderingMap", "()V", "GetOnWillStartRenderingMapHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnWillStartRenderingMapListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnWillStartRenderingMap ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingMapListener", DoNotGenerateAcw=true)]
		internal class IOnWillStartRenderingMapListenerInvoker : global::Java.Lang.Object, IOnWillStartRenderingMapListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingMapListener", typeof (IOnWillStartRenderingMapListenerInvoker));

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

			public static IOnWillStartRenderingMapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnWillStartRenderingMapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.maps.MapView.OnWillStartRenderingMapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnWillStartRenderingMapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWillStartRenderingMap;
#pragma warning disable 0169
			static Delegate GetOnWillStartRenderingMapHandler ()
			{
				if (cb_onWillStartRenderingMap == null)
					cb_onWillStartRenderingMap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWillStartRenderingMap);
				return cb_onWillStartRenderingMap;
			}

			static void n_OnWillStartRenderingMap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWillStartRenderingMap ();
			}
#pragma warning restore 0169

			IntPtr id_onWillStartRenderingMap;
			public unsafe void OnWillStartRenderingMap ()
			{
				if (id_onWillStartRenderingMap == IntPtr.Zero)
					id_onWillStartRenderingMap = JNIEnv.GetMethodID (class_ref, "onWillStartRenderingMap", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWillStartRenderingMap);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/maps/MapView_OnWillStartRenderingMapListenerImplementor")]
		internal sealed partial class IOnWillStartRenderingMapListenerImplementor : global::Java.Lang.Object, IOnWillStartRenderingMapListener {

			object sender;

			public IOnWillStartRenderingMapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/maps/MapView_OnWillStartRenderingMapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnWillStartRenderingMap ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnWillStartRenderingMapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/MapView", typeof (MapView));
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

		protected MapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MapView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MapView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MapView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.MapboxMapOptions']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)V", "")]
		public unsafe MapView (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isDestroyed;
#pragma warning disable 0169
		static Delegate GetIsDestroyedHandler ()
		{
			if (cb_isDestroyed == null)
				cb_isDestroyed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDestroyed);
			return cb_isDestroyed;
		}

		static bool n_IsDestroyed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDestroyed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDestroyed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='isDestroyed' and count(parameter)=0]"
			[Register ("isDestroyed", "()Z", "GetIsDestroyedHandler")]
			get {
				const string __id = "isDestroyed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getViewContent;
#pragma warning disable 0169
		static Delegate GetGetViewContentHandler ()
		{
			if (cb_getViewContent == null)
				cb_getViewContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetViewContent);
			return cb_getViewContent;
		}

		static IntPtr n_GetViewContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ViewContent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap ViewContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='getViewContent' and count(parameter)=0]"
			[Register ("getViewContent", "()Landroid/graphics/Bitmap;", "GetGetViewContentHandler")]
			get {
				const string __id = "getViewContent.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_Handler ()
		{
			if (cb_addOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_ == null)
				cb_addOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_);
			return cb_addOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_;
		}

		static void n_AddOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnCameraDidChangeListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnCameraDidChangeListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnCameraDidChangeListener']]"
		[Register ("addOnCameraDidChangeListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraDidChangeListener;)V", "GetAddOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_Handler")]
		public virtual unsafe void AddOnCameraDidChangeListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener listener)
		{
			const string __id = "addOnCameraDidChangeListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraDidChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_Handler ()
		{
			if (cb_addOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_ == null)
				cb_addOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_);
			return cb_addOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_;
		}

		static void n_AddOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnCameraIsChangingListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnCameraIsChangingListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnCameraIsChangingListener']]"
		[Register ("addOnCameraIsChangingListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraIsChangingListener;)V", "GetAddOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_Handler")]
		public virtual unsafe void AddOnCameraIsChangingListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener listener)
		{
			const string __id = "addOnCameraIsChangingListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraIsChangingListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_Handler ()
		{
			if (cb_addOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_ == null)
				cb_addOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_);
			return cb_addOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_;
		}

		static void n_AddOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnCameraWillChangeListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnCameraWillChangeListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnCameraWillChangeListener']]"
		[Register ("addOnCameraWillChangeListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraWillChangeListener;)V", "GetAddOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_Handler")]
		public virtual unsafe void AddOnCameraWillChangeListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener listener)
		{
			const string __id = "addOnCameraWillChangeListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraWillChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_Handler ()
		{
			if (cb_addOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_ == null)
				cb_addOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_);
			return cb_addOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_;
		}

		static void n_AddOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnCanRemoveUnusedStyleImageListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnCanRemoveUnusedStyleImageListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnCanRemoveUnusedStyleImageListener']]"
		[Register ("addOnCanRemoveUnusedStyleImageListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnCanRemoveUnusedStyleImageListener;)V", "GetAddOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_Handler")]
		public virtual unsafe void AddOnCanRemoveUnusedStyleImageListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener listener)
		{
			const string __id = "addOnCanRemoveUnusedStyleImageListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnCanRemoveUnusedStyleImageListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_;
#pragma warning disable 0169
		static Delegate GetAddOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_Handler ()
		{
			if (cb_addOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_ == null)
				cb_addOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_);
			return cb_addOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_;
		}

		static void n_AddOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnDidBecomeIdleListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnDidBecomeIdleListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidBecomeIdleListener']]"
		[Register ("addOnDidBecomeIdleListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidBecomeIdleListener;)V", "GetAddOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_Handler")]
		public virtual unsafe void AddOnDidBecomeIdleListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener listener)
		{
			const string __id = "addOnDidBecomeIdleListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidBecomeIdleListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_;
#pragma warning disable 0169
		static Delegate GetAddOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_Handler ()
		{
			if (cb_addOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_ == null)
				cb_addOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_);
			return cb_addOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_;
		}

		static void n_AddOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnDidFailLoadingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnDidFailLoadingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFailLoadingMapListener']]"
		[Register ("addOnDidFailLoadingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFailLoadingMapListener;)V", "GetAddOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_Handler")]
		public virtual unsafe void AddOnDidFailLoadingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener listener)
		{
			const string __id = "addOnDidFailLoadingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFailLoadingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_;
#pragma warning disable 0169
		static Delegate GetAddOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_Handler ()
		{
			if (cb_addOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_ == null)
				cb_addOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_);
			return cb_addOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_;
		}

		static void n_AddOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnDidFinishLoadingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnDidFinishLoadingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFinishLoadingMapListener']]"
		[Register ("addOnDidFinishLoadingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingMapListener;)V", "GetAddOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_Handler")]
		public virtual unsafe void AddOnDidFinishLoadingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener listener)
		{
			const string __id = "addOnDidFinishLoadingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_;
#pragma warning disable 0169
		static Delegate GetAddOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_Handler ()
		{
			if (cb_addOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_ == null)
				cb_addOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_);
			return cb_addOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_;
		}

		static void n_AddOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnDidFinishLoadingStyleListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnDidFinishLoadingStyleListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFinishLoadingStyleListener']]"
		[Register ("addOnDidFinishLoadingStyleListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingStyleListener;)V", "GetAddOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_Handler")]
		public virtual unsafe void AddOnDidFinishLoadingStyleListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener listener)
		{
			const string __id = "addOnDidFinishLoadingStyleListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingStyleListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_;
#pragma warning disable 0169
		static Delegate GetAddOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_Handler ()
		{
			if (cb_addOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_ == null)
				cb_addOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_);
			return cb_addOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_;
		}

		static void n_AddOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnDidFinishRenderingFrameListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnDidFinishRenderingFrameListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingFrameListener']]"
		[Register ("addOnDidFinishRenderingFrameListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingFrameListener;)V", "GetAddOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_Handler")]
		public virtual unsafe void AddOnDidFinishRenderingFrameListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener listener)
		{
			const string __id = "addOnDidFinishRenderingFrameListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingFrameListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_;
#pragma warning disable 0169
		static Delegate GetAddOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_Handler ()
		{
			if (cb_addOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_ == null)
				cb_addOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_);
			return cb_addOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_;
		}

		static void n_AddOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnDidFinishRenderingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnDidFinishRenderingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingMapListener']]"
		[Register ("addOnDidFinishRenderingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingMapListener;)V", "GetAddOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_Handler")]
		public virtual unsafe void AddOnDidFinishRenderingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener listener)
		{
			const string __id = "addOnDidFinishRenderingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_;
#pragma warning disable 0169
		static Delegate GetAddOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_Handler ()
		{
			if (cb_addOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_ == null)
				cb_addOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_);
			return cb_addOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_;
		}

		static void n_AddOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnSourceChangedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnSourceChangedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnSourceChangedListener']]"
		[Register ("addOnSourceChangedListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnSourceChangedListener;)V", "GetAddOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_Handler")]
		public virtual unsafe void AddOnSourceChangedListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener listener)
		{
			const string __id = "addOnSourceChangedListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnSourceChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_;
#pragma warning disable 0169
		static Delegate GetAddOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_Handler ()
		{
			if (cb_addOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_ == null)
				cb_addOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_);
			return cb_addOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_;
		}

		static void n_AddOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnStyleImageMissingListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnStyleImageMissingListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnStyleImageMissingListener']]"
		[Register ("addOnStyleImageMissingListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnStyleImageMissingListener;)V", "GetAddOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_Handler")]
		public virtual unsafe void AddOnStyleImageMissingListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener listener)
		{
			const string __id = "addOnStyleImageMissingListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnStyleImageMissingListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_;
#pragma warning disable 0169
		static Delegate GetAddOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_Handler ()
		{
			if (cb_addOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_ == null)
				cb_addOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_);
			return cb_addOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_;
		}

		static void n_AddOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnWillStartLoadingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnWillStartLoadingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnWillStartLoadingMapListener']]"
		[Register ("addOnWillStartLoadingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartLoadingMapListener;)V", "GetAddOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_Handler")]
		public virtual unsafe void AddOnWillStartLoadingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener listener)
		{
			const string __id = "addOnWillStartLoadingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartLoadingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_;
#pragma warning disable 0169
		static Delegate GetAddOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_Handler ()
		{
			if (cb_addOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_ == null)
				cb_addOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_);
			return cb_addOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_;
		}

		static void n_AddOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnWillStartRenderingFrameListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnWillStartRenderingFrameListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnWillStartRenderingFrameListener']]"
		[Register ("addOnWillStartRenderingFrameListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingFrameListener;)V", "GetAddOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_Handler")]
		public virtual unsafe void AddOnWillStartRenderingFrameListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener listener)
		{
			const string __id = "addOnWillStartRenderingFrameListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingFrameListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_;
#pragma warning disable 0169
		static Delegate GetAddOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_Handler ()
		{
			if (cb_addOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_ == null)
				cb_addOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_);
			return cb_addOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_;
		}

		static void n_AddOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnWillStartRenderingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='addOnWillStartRenderingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnWillStartRenderingMapListener']]"
		[Register ("addOnWillStartRenderingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingMapListener;)V", "GetAddOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_Handler")]
		public virtual unsafe void AddOnWillStartRenderingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener listener)
		{
			const string __id = "addOnWillStartRenderingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_;
#pragma warning disable 0169
		static Delegate GetGetMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_Handler ()
		{
			if (cb_getMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_ == null)
				cb_getMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_);
			return cb_getMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_;
		}

		static void n_GetMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback @callback = (global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetMapAsync (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='getMapAsync' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.OnMapReadyCallback']]"
		[Register ("getMapAsync", "(Lcom/mapbox/mapboxsdk/maps/OnMapReadyCallback;)V", "GetGetMapAsync_Lcom_mapbox_mapboxsdk_maps_OnMapReadyCallback_Handler")]
		public virtual unsafe void GetMapAsync (global::Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallback @callback)
		{
			const string __id = "getMapAsync.(Lcom/mapbox/mapboxsdk/maps/OnMapReadyCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initialize_Landroid_content_Context_Lcom_mapbox_mapboxsdk_maps_MapboxMapOptions_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_content_Context_Lcom_mapbox_mapboxsdk_maps_MapboxMapOptions_Handler ()
		{
			if (cb_initialize_Landroid_content_Context_Lcom_mapbox_mapboxsdk_maps_MapboxMapOptions_ == null)
				cb_initialize_Landroid_content_Context_Lcom_mapbox_mapboxsdk_maps_MapboxMapOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Landroid_content_Context_Lcom_mapbox_mapboxsdk_maps_MapboxMapOptions_);
			return cb_initialize_Landroid_content_Context_Lcom_mapbox_mapboxsdk_maps_MapboxMapOptions_;
		}

		static void n_Initialize_Landroid_content_Context_Lcom_mapbox_mapboxsdk_maps_MapboxMapOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions options = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (context, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.MapboxMapOptions']]"
		[Register ("initialize", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)V", "GetInitialize_Landroid_content_Context_Lcom_mapbox_mapboxsdk_maps_MapboxMapOptions_Handler")]
		protected virtual unsafe void Initialize (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions options)
		{
			const string __id = "initialize.(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle savedInstanceState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (savedInstanceState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle savedInstanceState)
		{
			const string __id = "onCreate.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((savedInstanceState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) savedInstanceState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onLowMemory;
#pragma warning disable 0169
		static Delegate GetOnLowMemoryHandler ()
		{
			if (cb_onLowMemory == null)
				cb_onLowMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLowMemory);
			return cb_onLowMemory;
		}

		static void n_OnLowMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLowMemory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='onLowMemory' and count(parameter)=0]"
		[Register ("onLowMemory", "()V", "GetOnLowMemoryHandler")]
		public virtual unsafe void OnLowMemory ()
		{
			const string __id = "onLowMemory.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			const string __id = "onResume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_outState)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle outState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_outState, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (outState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnSaveInstanceState (global::Android.OS.Bundle outState)
		{
			const string __id = "onSaveInstanceState.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((outState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			const string __id = "onStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			const string __id = "onStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_Handler ()
		{
			if (cb_removeOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_ == null)
				cb_removeOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_);
			return cb_removeOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_;
		}

		static void n_RemoveOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnCameraDidChangeListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnCameraDidChangeListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnCameraDidChangeListener']]"
		[Register ("removeOnCameraDidChangeListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraDidChangeListener;)V", "GetRemoveOnCameraDidChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraDidChangeListener_Handler")]
		public virtual unsafe void RemoveOnCameraDidChangeListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener listener)
		{
			const string __id = "removeOnCameraDidChangeListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraDidChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_Handler ()
		{
			if (cb_removeOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_ == null)
				cb_removeOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_);
			return cb_removeOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_;
		}

		static void n_RemoveOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnCameraIsChangingListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnCameraIsChangingListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnCameraIsChangingListener']]"
		[Register ("removeOnCameraIsChangingListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraIsChangingListener;)V", "GetRemoveOnCameraIsChangingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraIsChangingListener_Handler")]
		public virtual unsafe void RemoveOnCameraIsChangingListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener listener)
		{
			const string __id = "removeOnCameraIsChangingListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraIsChangingListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_Handler ()
		{
			if (cb_removeOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_ == null)
				cb_removeOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_);
			return cb_removeOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_;
		}

		static void n_RemoveOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnCameraWillChangeListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnCameraWillChangeListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnCameraWillChangeListener']]"
		[Register ("removeOnCameraWillChangeListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraWillChangeListener;)V", "GetRemoveOnCameraWillChangeListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCameraWillChangeListener_Handler")]
		public virtual unsafe void RemoveOnCameraWillChangeListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener listener)
		{
			const string __id = "removeOnCameraWillChangeListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnCameraWillChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_Handler ()
		{
			if (cb_removeOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_ == null)
				cb_removeOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_);
			return cb_removeOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_;
		}

		static void n_RemoveOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnCanRemoveUnusedStyleImageListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnCanRemoveUnusedStyleImageListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnCanRemoveUnusedStyleImageListener']]"
		[Register ("removeOnCanRemoveUnusedStyleImageListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnCanRemoveUnusedStyleImageListener;)V", "GetRemoveOnCanRemoveUnusedStyleImageListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnCanRemoveUnusedStyleImageListener_Handler")]
		public virtual unsafe void RemoveOnCanRemoveUnusedStyleImageListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener listener)
		{
			const string __id = "removeOnCanRemoveUnusedStyleImageListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnCanRemoveUnusedStyleImageListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_Handler ()
		{
			if (cb_removeOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_ == null)
				cb_removeOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_);
			return cb_removeOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_;
		}

		static void n_RemoveOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnDidBecomeIdleListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnDidBecomeIdleListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidBecomeIdleListener']]"
		[Register ("removeOnDidBecomeIdleListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidBecomeIdleListener;)V", "GetRemoveOnDidBecomeIdleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidBecomeIdleListener_Handler")]
		public virtual unsafe void RemoveOnDidBecomeIdleListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener listener)
		{
			const string __id = "removeOnDidBecomeIdleListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidBecomeIdleListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_Handler ()
		{
			if (cb_removeOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_ == null)
				cb_removeOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_);
			return cb_removeOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_;
		}

		static void n_RemoveOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnDidFailLoadingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnDidFailLoadingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFailLoadingMapListener']]"
		[Register ("removeOnDidFailLoadingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFailLoadingMapListener;)V", "GetRemoveOnDidFailLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFailLoadingMapListener_Handler")]
		public virtual unsafe void RemoveOnDidFailLoadingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener listener)
		{
			const string __id = "removeOnDidFailLoadingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFailLoadingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_Handler ()
		{
			if (cb_removeOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_ == null)
				cb_removeOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_);
			return cb_removeOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_;
		}

		static void n_RemoveOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnDidFinishLoadingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnDidFinishLoadingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFinishLoadingMapListener']]"
		[Register ("removeOnDidFinishLoadingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingMapListener;)V", "GetRemoveOnDidFinishLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingMapListener_Handler")]
		public virtual unsafe void RemoveOnDidFinishLoadingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener listener)
		{
			const string __id = "removeOnDidFinishLoadingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_Handler ()
		{
			if (cb_removeOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_ == null)
				cb_removeOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_);
			return cb_removeOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_;
		}

		static void n_RemoveOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnDidFinishLoadingStyleListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnDidFinishLoadingStyleListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFinishLoadingStyleListener']]"
		[Register ("removeOnDidFinishLoadingStyleListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingStyleListener;)V", "GetRemoveOnDidFinishLoadingStyleListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishLoadingStyleListener_Handler")]
		public virtual unsafe void RemoveOnDidFinishLoadingStyleListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener listener)
		{
			const string __id = "removeOnDidFinishLoadingStyleListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishLoadingStyleListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_Handler ()
		{
			if (cb_removeOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_ == null)
				cb_removeOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_);
			return cb_removeOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_;
		}

		static void n_RemoveOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnDidFinishRenderingFrameListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnDidFinishRenderingFrameListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingFrameListener']]"
		[Register ("removeOnDidFinishRenderingFrameListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingFrameListener;)V", "GetRemoveOnDidFinishRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingFrameListener_Handler")]
		public virtual unsafe void RemoveOnDidFinishRenderingFrameListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener listener)
		{
			const string __id = "removeOnDidFinishRenderingFrameListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingFrameListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_Handler ()
		{
			if (cb_removeOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_ == null)
				cb_removeOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_);
			return cb_removeOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_;
		}

		static void n_RemoveOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnDidFinishRenderingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnDidFinishRenderingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingMapListener']]"
		[Register ("removeOnDidFinishRenderingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingMapListener;)V", "GetRemoveOnDidFinishRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnDidFinishRenderingMapListener_Handler")]
		public virtual unsafe void RemoveOnDidFinishRenderingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener listener)
		{
			const string __id = "removeOnDidFinishRenderingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnDidFinishRenderingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_Handler ()
		{
			if (cb_removeOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_ == null)
				cb_removeOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_);
			return cb_removeOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_;
		}

		static void n_RemoveOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnSourceChangedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnSourceChangedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnSourceChangedListener']]"
		[Register ("removeOnSourceChangedListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnSourceChangedListener;)V", "GetRemoveOnSourceChangedListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnSourceChangedListener_Handler")]
		public virtual unsafe void RemoveOnSourceChangedListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener listener)
		{
			const string __id = "removeOnSourceChangedListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnSourceChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_Handler ()
		{
			if (cb_removeOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_ == null)
				cb_removeOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_);
			return cb_removeOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_;
		}

		static void n_RemoveOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnStyleImageMissingListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnStyleImageMissingListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnStyleImageMissingListener']]"
		[Register ("removeOnStyleImageMissingListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnStyleImageMissingListener;)V", "GetRemoveOnStyleImageMissingListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnStyleImageMissingListener_Handler")]
		public virtual unsafe void RemoveOnStyleImageMissingListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener listener)
		{
			const string __id = "removeOnStyleImageMissingListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnStyleImageMissingListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_Handler ()
		{
			if (cb_removeOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_ == null)
				cb_removeOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_);
			return cb_removeOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_;
		}

		static void n_RemoveOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnWillStartLoadingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnWillStartLoadingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnWillStartLoadingMapListener']]"
		[Register ("removeOnWillStartLoadingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartLoadingMapListener;)V", "GetRemoveOnWillStartLoadingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartLoadingMapListener_Handler")]
		public virtual unsafe void RemoveOnWillStartLoadingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener listener)
		{
			const string __id = "removeOnWillStartLoadingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartLoadingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_Handler ()
		{
			if (cb_removeOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_ == null)
				cb_removeOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_);
			return cb_removeOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_;
		}

		static void n_RemoveOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnWillStartRenderingFrameListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnWillStartRenderingFrameListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnWillStartRenderingFrameListener']]"
		[Register ("removeOnWillStartRenderingFrameListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingFrameListener;)V", "GetRemoveOnWillStartRenderingFrameListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingFrameListener_Handler")]
		public virtual unsafe void RemoveOnWillStartRenderingFrameListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener listener)
		{
			const string __id = "removeOnWillStartRenderingFrameListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingFrameListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_Handler ()
		{
			if (cb_removeOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_ == null)
				cb_removeOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_);
			return cb_removeOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_;
		}

		static void n_RemoveOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener listener = (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnWillStartRenderingMapListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='removeOnWillStartRenderingMapListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapView.OnWillStartRenderingMapListener']]"
		[Register ("removeOnWillStartRenderingMapListener", "(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingMapListener;)V", "GetRemoveOnWillStartRenderingMapListener_Lcom_mapbox_mapboxsdk_maps_MapView_OnWillStartRenderingMapListener_Handler")]
		public virtual unsafe void RemoveOnWillStartRenderingMapListener (global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener listener)
		{
			const string __id = "removeOnWillStartRenderingMapListener.(Lcom/mapbox/mapboxsdk/maps/MapView$OnWillStartRenderingMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='setMapStrictModeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMapStrictModeEnabled", "(Z)V", "")]
		public static unsafe void SetMapStrictModeEnabled (bool strictModeEnabled)
		{
			const string __id = "setMapStrictModeEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (strictModeEnabled);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_setMaximumFps_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumFps_IHandler ()
		{
			if (cb_setMaximumFps_I == null)
				cb_setMaximumFps_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumFps_I);
			return cb_setMaximumFps_I;
		}

		static void n_SetMaximumFps_I (IntPtr jnienv, IntPtr native__this, int maximumFps)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaximumFps (maximumFps);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='MapView']/method[@name='setMaximumFps' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaximumFps", "(I)V", "GetSetMaximumFps_IHandler")]
		public virtual unsafe void SetMaximumFps (int maximumFps)
		{
			const string __id = "setMaximumFps.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maximumFps);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.CameraDidChangeEventArgs> CameraDidChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListenerImplementor>(
						ref weak_implementor_AddOnCameraDidChangeListener,
						__CreateIOnCameraDidChangeListenerImplementor,
						AddOnCameraDidChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListenerImplementor>(
						ref weak_implementor_AddOnCameraDidChangeListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListenerImplementor.__IsEmpty,
						__v => RemoveOnCameraDidChangeListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnCameraDidChangeListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListenerImplementor __CreateIOnCameraDidChangeListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraDidChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener"
		public event EventHandler CameraIsChanging {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListenerImplementor>(
						ref weak_implementor_AddOnCameraIsChangingListener,
						__CreateIOnCameraIsChangingListenerImplementor,
						AddOnCameraIsChangingListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListenerImplementor>(
						ref weak_implementor_AddOnCameraIsChangingListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListenerImplementor.__IsEmpty,
						__v => RemoveOnCameraIsChangingListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnCameraIsChangingListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListenerImplementor __CreateIOnCameraIsChangingListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraIsChangingListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.CameraWillChangeEventArgs> CameraWillChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListenerImplementor>(
						ref weak_implementor_AddOnCameraWillChangeListener,
						__CreateIOnCameraWillChangeListenerImplementor,
						AddOnCameraWillChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListenerImplementor>(
						ref weak_implementor_AddOnCameraWillChangeListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListenerImplementor.__IsEmpty,
						__v => RemoveOnCameraWillChangeListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnCameraWillChangeListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListenerImplementor __CreateIOnCameraWillChangeListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCameraWillChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.CanRemoveUnusedStyleImageEventArgs> CanRemoveUnusedStyleImage {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListenerImplementor>(
						ref weak_implementor_AddOnCanRemoveUnusedStyleImageListener,
						__CreateIOnCanRemoveUnusedStyleImageListenerImplementor,
						AddOnCanRemoveUnusedStyleImageListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListenerImplementor>(
						ref weak_implementor_AddOnCanRemoveUnusedStyleImageListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListenerImplementor.__IsEmpty,
						__v => RemoveOnCanRemoveUnusedStyleImageListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnCanRemoveUnusedStyleImageListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListenerImplementor __CreateIOnCanRemoveUnusedStyleImageListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnCanRemoveUnusedStyleImageListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener"
		public event EventHandler DidBecomeIdle {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListenerImplementor>(
						ref weak_implementor_AddOnDidBecomeIdleListener,
						__CreateIOnDidBecomeIdleListenerImplementor,
						AddOnDidBecomeIdleListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListenerImplementor>(
						ref weak_implementor_AddOnDidBecomeIdleListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListenerImplementor.__IsEmpty,
						__v => RemoveOnDidBecomeIdleListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnDidBecomeIdleListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListenerImplementor __CreateIOnDidBecomeIdleListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidBecomeIdleListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.DidFailLoadingMapEventArgs> DidFailLoadingMap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListenerImplementor>(
						ref weak_implementor_AddOnDidFailLoadingMapListener,
						__CreateIOnDidFailLoadingMapListenerImplementor,
						AddOnDidFailLoadingMapListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListenerImplementor>(
						ref weak_implementor_AddOnDidFailLoadingMapListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListenerImplementor.__IsEmpty,
						__v => RemoveOnDidFailLoadingMapListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnDidFailLoadingMapListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListenerImplementor __CreateIOnDidFailLoadingMapListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFailLoadingMapListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener"
		public event EventHandler DidFinishLoadingMap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListenerImplementor>(
						ref weak_implementor_AddOnDidFinishLoadingMapListener,
						__CreateIOnDidFinishLoadingMapListenerImplementor,
						AddOnDidFinishLoadingMapListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListenerImplementor>(
						ref weak_implementor_AddOnDidFinishLoadingMapListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListenerImplementor.__IsEmpty,
						__v => RemoveOnDidFinishLoadingMapListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnDidFinishLoadingMapListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListenerImplementor __CreateIOnDidFinishLoadingMapListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingMapListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener"
		public event EventHandler DidFinishLoadingStyle {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListenerImplementor>(
						ref weak_implementor_AddOnDidFinishLoadingStyleListener,
						__CreateIOnDidFinishLoadingStyleListenerImplementor,
						AddOnDidFinishLoadingStyleListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListenerImplementor>(
						ref weak_implementor_AddOnDidFinishLoadingStyleListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListenerImplementor.__IsEmpty,
						__v => RemoveOnDidFinishLoadingStyleListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnDidFinishLoadingStyleListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListenerImplementor __CreateIOnDidFinishLoadingStyleListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishLoadingStyleListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.DidFinishRenderingFrameEventArgs> DidFinishRenderingFrame {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListenerImplementor>(
						ref weak_implementor_AddOnDidFinishRenderingFrameListener,
						__CreateIOnDidFinishRenderingFrameListenerImplementor,
						AddOnDidFinishRenderingFrameListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListenerImplementor>(
						ref weak_implementor_AddOnDidFinishRenderingFrameListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListenerImplementor.__IsEmpty,
						__v => RemoveOnDidFinishRenderingFrameListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnDidFinishRenderingFrameListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListenerImplementor __CreateIOnDidFinishRenderingFrameListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingFrameListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.DidFinishRenderingMapEventArgs> DidFinishRenderingMap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListenerImplementor>(
						ref weak_implementor_AddOnDidFinishRenderingMapListener,
						__CreateIOnDidFinishRenderingMapListenerImplementor,
						AddOnDidFinishRenderingMapListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListenerImplementor>(
						ref weak_implementor_AddOnDidFinishRenderingMapListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListenerImplementor.__IsEmpty,
						__v => RemoveOnDidFinishRenderingMapListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnDidFinishRenderingMapListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListenerImplementor __CreateIOnDidFinishRenderingMapListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnDidFinishRenderingMapListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.SourceChangedEventArgs> SourceChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListenerImplementor>(
						ref weak_implementor_AddOnSourceChangedListener,
						__CreateIOnSourceChangedListenerImplementor,
						AddOnSourceChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListenerImplementor>(
						ref weak_implementor_AddOnSourceChangedListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListenerImplementor.__IsEmpty,
						__v => RemoveOnSourceChangedListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnSourceChangedListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListenerImplementor __CreateIOnSourceChangedListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnSourceChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.StyleImageMissingEventArgs> StyleImageMissing {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListenerImplementor>(
						ref weak_implementor_AddOnStyleImageMissingListener,
						__CreateIOnStyleImageMissingListenerImplementor,
						AddOnStyleImageMissingListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListenerImplementor>(
						ref weak_implementor_AddOnStyleImageMissingListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListenerImplementor.__IsEmpty,
						__v => RemoveOnStyleImageMissingListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnStyleImageMissingListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListenerImplementor __CreateIOnStyleImageMissingListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnStyleImageMissingListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener"
		public event EventHandler WillStartLoadingMap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListenerImplementor>(
						ref weak_implementor_AddOnWillStartLoadingMapListener,
						__CreateIOnWillStartLoadingMapListenerImplementor,
						AddOnWillStartLoadingMapListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListenerImplementor>(
						ref weak_implementor_AddOnWillStartLoadingMapListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListenerImplementor.__IsEmpty,
						__v => RemoveOnWillStartLoadingMapListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnWillStartLoadingMapListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListenerImplementor __CreateIOnWillStartLoadingMapListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartLoadingMapListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener"
		public event EventHandler WillStartRenderingFrame {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListenerImplementor>(
						ref weak_implementor_AddOnWillStartRenderingFrameListener,
						__CreateIOnWillStartRenderingFrameListenerImplementor,
						AddOnWillStartRenderingFrameListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListenerImplementor>(
						ref weak_implementor_AddOnWillStartRenderingFrameListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListenerImplementor.__IsEmpty,
						__v => RemoveOnWillStartRenderingFrameListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnWillStartRenderingFrameListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListenerImplementor __CreateIOnWillStartRenderingFrameListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingFrameListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener"
		public event EventHandler WillStartRenderingMap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListenerImplementor>(
						ref weak_implementor_AddOnWillStartRenderingMapListener,
						__CreateIOnWillStartRenderingMapListenerImplementor,
						AddOnWillStartRenderingMapListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListener, global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListenerImplementor>(
						ref weak_implementor_AddOnWillStartRenderingMapListener,
						global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListenerImplementor.__IsEmpty,
						__v => RemoveOnWillStartRenderingMapListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnWillStartRenderingMapListener;

		global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListenerImplementor __CreateIOnWillStartRenderingMapListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Maps.MapView.IOnWillStartRenderingMapListenerImplementor (this);
		}
#endregion
	}
}
