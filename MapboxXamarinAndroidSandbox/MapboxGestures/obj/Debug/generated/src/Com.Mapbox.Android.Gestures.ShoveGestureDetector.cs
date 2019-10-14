using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/ShoveGestureDetector", DoNotGenerateAcw=true)]
	public partial class ShoveGestureDetector : global::Com.Mapbox.Android.Gestures.ProgressiveGesture {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='ShoveGestureDetector.OnShoveGestureListener']"
		[Register ("com/mapbox/android/gestures/ShoveGestureDetector$OnShoveGestureListener", "", "Com.Mapbox.Android.Gestures.ShoveGestureDetector/IOnShoveGestureListenerInvoker")]
		public partial interface IOnShoveGestureListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='ShoveGestureDetector.OnShoveGestureListener']/method[@name='onShove' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.ShoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onShove", "(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)Z", "GetOnShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.ShoveGestureDetector/IOnShoveGestureListenerInvoker, MapboxGestures")]
			bool OnShove (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0, float p1, float p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='ShoveGestureDetector.OnShoveGestureListener']/method[@name='onShoveBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.ShoveGestureDetector']]"
			[Register ("onShoveBegin", "(Lcom/mapbox/android/gestures/ShoveGestureDetector;)Z", "GetOnShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_Handler:Com.Mapbox.Android.Gestures.ShoveGestureDetector/IOnShoveGestureListenerInvoker, MapboxGestures")]
			bool OnShoveBegin (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='ShoveGestureDetector.OnShoveGestureListener']/method[@name='onShoveEnd' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.ShoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onShoveEnd", "(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)V", "GetOnShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.ShoveGestureDetector/IOnShoveGestureListenerInvoker, MapboxGestures")]
			void OnShoveEnd (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0, float p1, float p2);

		}

		[global::Android.Runtime.Register ("com/mapbox/android/gestures/ShoveGestureDetector$OnShoveGestureListener", DoNotGenerateAcw=true)]
		internal class IOnShoveGestureListenerInvoker : global::Java.Lang.Object, IOnShoveGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/ShoveGestureDetector$OnShoveGestureListener", typeof (IOnShoveGestureListenerInvoker));

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

			public static IOnShoveGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnShoveGestureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.gestures.ShoveGestureDetector.OnShoveGestureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnShoveGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler ()
			{
				if (cb_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF == null)
					cb_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF);
				return cb_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
			}

			static bool n_OnShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnShove (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
			public unsafe bool OnShove (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0, float p1, float p2)
			{
				if (id_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF == IntPtr.Zero)
					id_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF = JNIEnv.GetMethodID (class_ref, "onShove", "(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF, __args);
				return __ret;
			}

			static Delegate cb_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_Handler ()
			{
				if (cb_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_ == null)
					cb_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_);
				return cb_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_;
			}

			static bool n_OnShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnShoveBegin (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_;
			public unsafe bool OnShoveBegin (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0)
			{
				if (id_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_ == IntPtr.Zero)
					id_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_ = JNIEnv.GetMethodID (class_ref, "onShoveBegin", "(Lcom/mapbox/android/gestures/ShoveGestureDetector;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_, __args);
				return __ret;
			}

			static Delegate cb_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler ()
			{
				if (cb_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF == null)
					cb_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF);
				return cb_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
			}

			static void n_OnShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnShoveEnd (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
			public unsafe void OnShoveEnd (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0, float p1, float p2)
			{
				if (id_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF == IntPtr.Zero)
					id_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF = JNIEnv.GetMethodID (class_ref, "onShoveEnd", "(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF, __args);
			}

		}

		// event args for com.mapbox.android.gestures.ShoveGestureDetector.OnShoveGestureListener.onShove
		public partial class ShoveEventArgs : global::System.EventArgs {

			public ShoveEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0, float p1, float p2)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.ShoveGestureDetector P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}

			float p2;
			public float P2 {
				get { return p2; }
			}
		}

		// event args for com.mapbox.android.gestures.ShoveGestureDetector.OnShoveGestureListener.onShoveBegin
		public partial class ShoveBeginEventArgs : global::System.EventArgs {

			public ShoveBeginEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.ShoveGestureDetector P0 {
				get { return p0; }
			}
		}

		// event args for com.mapbox.android.gestures.ShoveGestureDetector.OnShoveGestureListener.onShoveEnd
		public partial class ShoveEndEventArgs : global::System.EventArgs {

			public ShoveEndEventArgs (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0, float p1, float p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.ShoveGestureDetector P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}

			float p2;
			public float P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/android/gestures/ShoveGestureDetector_OnShoveGestureListenerImplementor")]
		internal sealed partial class IOnShoveGestureListenerImplementor : global::Java.Lang.Object, IOnShoveGestureListener {

			object sender;

			public IOnShoveGestureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/android/gestures/ShoveGestureDetector_OnShoveGestureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ShoveEventArgs> OnShoveHandler;
#pragma warning restore 0649

			public bool OnShove (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0, float p1, float p2)
			{
				var __h = OnShoveHandler;
				if (__h == null)
					return false;
				var __e = new ShoveEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<ShoveBeginEventArgs> OnShoveBeginHandler;
#pragma warning restore 0649

			public bool OnShoveBegin (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0)
			{
				var __h = OnShoveBeginHandler;
				if (__h == null)
					return false;
				var __e = new ShoveBeginEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<ShoveEndEventArgs> OnShoveEndHandler;
#pragma warning restore 0649

			public void OnShoveEnd (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector p0, float p1, float p2)
			{
				var __h = OnShoveEndHandler;
				if (__h != null)
					__h (sender, new ShoveEndEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnShoveGestureListenerImplementor value)
			{
				return value.OnShoveHandler == null && value.OnShoveBeginHandler == null && value.OnShoveEndHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector.SimpleOnShoveGestureListener']"
		[global::Android.Runtime.Register ("com/mapbox/android/gestures/ShoveGestureDetector$SimpleOnShoveGestureListener", DoNotGenerateAcw=true)]
		public partial class SimpleOnShoveGestureListener : global::Java.Lang.Object, global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/ShoveGestureDetector$SimpleOnShoveGestureListener", typeof (SimpleOnShoveGestureListener));
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

			protected SimpleOnShoveGestureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector.SimpleOnShoveGestureListener']/constructor[@name='ShoveGestureDetector.SimpleOnShoveGestureListener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SimpleOnShoveGestureListener ()
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

			static Delegate cb_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler ()
			{
				if (cb_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF == null)
					cb_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF);
				return cb_onShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
			}

			static bool n_OnShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_detector, float deltaPixelsSinceLast, float deltaPixelsSinceStart)
			{
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.SimpleOnShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.SimpleOnShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnShove (detector, deltaPixelsSinceLast, deltaPixelsSinceStart);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector.SimpleOnShoveGestureListener']/method[@name='onShove' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.ShoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onShove", "(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)Z", "GetOnShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler")]
			public virtual unsafe bool OnShove (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector detector, float deltaPixelsSinceLast, float deltaPixelsSinceStart)
			{
				const string __id = "onShove.(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					__args [1] = new JniArgumentValue (deltaPixelsSinceLast);
					__args [2] = new JniArgumentValue (deltaPixelsSinceStart);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_Handler ()
			{
				if (cb_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_ == null)
					cb_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_);
				return cb_onShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_;
			}

			static bool n_OnShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_detector)
			{
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.SimpleOnShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.SimpleOnShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnShoveBegin (detector);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector.SimpleOnShoveGestureListener']/method[@name='onShoveBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.ShoveGestureDetector']]"
			[Register ("onShoveBegin", "(Lcom/mapbox/android/gestures/ShoveGestureDetector;)Z", "GetOnShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_Handler")]
			public virtual unsafe bool OnShoveBegin (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector detector)
			{
				const string __id = "onShoveBegin.(Lcom/mapbox/android/gestures/ShoveGestureDetector;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler ()
			{
				if (cb_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF == null)
					cb_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF);
				return cb_onShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF;
			}

			static void n_OnShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_detector, float velocityX, float velocityY)
			{
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.SimpleOnShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.SimpleOnShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.ShoveGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				__this.OnShoveEnd (detector, velocityX, velocityY);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector.SimpleOnShoveGestureListener']/method[@name='onShoveEnd' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.ShoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onShoveEnd", "(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)V", "GetOnShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler")]
			public virtual unsafe void OnShoveEnd (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector detector, float velocityX, float velocityY)
			{
				const string __id = "onShoveEnd.(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					__args [1] = new JniArgumentValue (velocityX);
					__args [2] = new JniArgumentValue (velocityY);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/ShoveGestureDetector", typeof (ShoveGestureDetector));
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

		protected ShoveGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']/constructor[@name='ShoveGestureDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe ShoveGestureDetector (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager gesturesManager)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((gesturesManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gesturesManager).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDeltaPixelSinceLast;
#pragma warning disable 0169
		static Delegate GetGetDeltaPixelSinceLastHandler ()
		{
			if (cb_getDeltaPixelSinceLast == null)
				cb_getDeltaPixelSinceLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDeltaPixelSinceLast);
			return cb_getDeltaPixelSinceLast;
		}

		static float n_GetDeltaPixelSinceLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaPixelSinceLast;
		}
#pragma warning restore 0169

		public virtual unsafe float DeltaPixelSinceLast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']/method[@name='getDeltaPixelSinceLast' and count(parameter)=0]"
			[Register ("getDeltaPixelSinceLast", "()F", "GetGetDeltaPixelSinceLastHandler")]
			get {
				const string __id = "getDeltaPixelSinceLast.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDeltaPixelsSinceStart;
#pragma warning disable 0169
		static Delegate GetGetDeltaPixelsSinceStartHandler ()
		{
			if (cb_getDeltaPixelsSinceStart == null)
				cb_getDeltaPixelsSinceStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDeltaPixelsSinceStart);
			return cb_getDeltaPixelsSinceStart;
		}

		static float n_GetDeltaPixelsSinceStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaPixelsSinceStart;
		}
#pragma warning restore 0169

		public virtual unsafe float DeltaPixelsSinceStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']/method[@name='getDeltaPixelsSinceStart' and count(parameter)=0]"
			[Register ("getDeltaPixelsSinceStart", "()F", "GetGetDeltaPixelsSinceStartHandler")]
			get {
				const string __id = "getDeltaPixelsSinceStart.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxShoveAngle;
#pragma warning disable 0169
		static Delegate GetGetMaxShoveAngleHandler ()
		{
			if (cb_getMaxShoveAngle == null)
				cb_getMaxShoveAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxShoveAngle);
			return cb_getMaxShoveAngle;
		}

		static float n_GetMaxShoveAngle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxShoveAngle;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxShoveAngle_F;
#pragma warning disable 0169
		static Delegate GetSetMaxShoveAngle_FHandler ()
		{
			if (cb_setMaxShoveAngle_F == null)
				cb_setMaxShoveAngle_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxShoveAngle_F);
			return cb_setMaxShoveAngle_F;
		}

		static void n_SetMaxShoveAngle_F (IntPtr jnienv, IntPtr native__this, float maxShoveAngle)
		{
			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxShoveAngle = maxShoveAngle;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxShoveAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']/method[@name='getMaxShoveAngle' and count(parameter)=0]"
			[Register ("getMaxShoveAngle", "()F", "GetGetMaxShoveAngleHandler")]
			get {
				const string __id = "getMaxShoveAngle.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']/method[@name='setMaxShoveAngle' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxShoveAngle", "(F)V", "GetSetMaxShoveAngle_FHandler")]
			set {
				const string __id = "setMaxShoveAngle.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPixelDeltaThreshold;
#pragma warning disable 0169
		static Delegate GetGetPixelDeltaThresholdHandler ()
		{
			if (cb_getPixelDeltaThreshold == null)
				cb_getPixelDeltaThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPixelDeltaThreshold);
			return cb_getPixelDeltaThreshold;
		}

		static float n_GetPixelDeltaThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelDeltaThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setPixelDeltaThreshold_F;
#pragma warning disable 0169
		static Delegate GetSetPixelDeltaThreshold_FHandler ()
		{
			if (cb_setPixelDeltaThreshold_F == null)
				cb_setPixelDeltaThreshold_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPixelDeltaThreshold_F);
			return cb_setPixelDeltaThreshold_F;
		}

		static void n_SetPixelDeltaThreshold_F (IntPtr jnienv, IntPtr native__this, float pixelDeltaThreshold)
		{
			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PixelDeltaThreshold = pixelDeltaThreshold;
		}
#pragma warning restore 0169

		public virtual unsafe float PixelDeltaThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']/method[@name='getPixelDeltaThreshold' and count(parameter)=0]"
			[Register ("getPixelDeltaThreshold", "()F", "GetGetPixelDeltaThresholdHandler")]
			get {
				const string __id = "getPixelDeltaThreshold.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']/method[@name='setPixelDeltaThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPixelDeltaThreshold", "(F)V", "GetSetPixelDeltaThreshold_FHandler")]
			set {
				const string __id = "setPixelDeltaThreshold.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_provideHandledTypes;
#pragma warning disable 0169
		static Delegate GetProvideHandledTypesHandler ()
		{
			if (cb_provideHandledTypes == null)
				cb_provideHandledTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ProvideHandledTypes);
			return cb_provideHandledTypes;
		}

		static IntPtr n_ProvideHandledTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ProvideHandledTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']/method[@name='provideHandledTypes' and count(parameter)=0]"
		[Register ("provideHandledTypes", "()Ljava/util/Set;", "GetProvideHandledTypesHandler")]
		protected override unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> ProvideHandledTypes ()
		{
			const string __id = "provideHandledTypes.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPixelDeltaThresholdResource_I;
#pragma warning disable 0169
		static Delegate GetSetPixelDeltaThresholdResource_IHandler ()
		{
			if (cb_setPixelDeltaThresholdResource_I == null)
				cb_setPixelDeltaThresholdResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPixelDeltaThresholdResource_I);
			return cb_setPixelDeltaThresholdResource_I;
		}

		static void n_SetPixelDeltaThresholdResource_I (IntPtr jnienv, IntPtr native__this, int pixelDeltaThresholdDimen)
		{
			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPixelDeltaThresholdResource (pixelDeltaThresholdDimen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ShoveGestureDetector']/method[@name='setPixelDeltaThresholdResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPixelDeltaThresholdResource", "(I)V", "GetSetPixelDeltaThresholdResource_IHandler")]
		public virtual unsafe void SetPixelDeltaThresholdResource (int pixelDeltaThresholdDimen)
		{
			const string __id = "setPixelDeltaThresholdResource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pixelDeltaThresholdDimen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
