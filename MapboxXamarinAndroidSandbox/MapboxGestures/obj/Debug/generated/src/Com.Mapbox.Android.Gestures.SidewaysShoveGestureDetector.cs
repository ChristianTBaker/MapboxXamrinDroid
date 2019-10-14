using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/SidewaysShoveGestureDetector", DoNotGenerateAcw=true)]
	public partial class SidewaysShoveGestureDetector : global::Com.Mapbox.Android.Gestures.ProgressiveGesture {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener']"
		[Register ("com/mapbox/android/gestures/SidewaysShoveGestureDetector$OnSidewaysShoveGestureListener", "", "Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector/IOnSidewaysShoveGestureListenerInvoker")]
		public partial interface IOnSidewaysShoveGestureListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener']/method[@name='onSidewaysShove' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.SidewaysShoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onSidewaysShove", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)Z", "GetOnSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector/IOnSidewaysShoveGestureListenerInvoker, MapboxGestures")]
			bool OnSidewaysShove (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0, float p1, float p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener']/method[@name='onSidewaysShoveBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.SidewaysShoveGestureDetector']]"
			[Register ("onSidewaysShoveBegin", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;)Z", "GetOnSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_Handler:Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector/IOnSidewaysShoveGestureListenerInvoker, MapboxGestures")]
			bool OnSidewaysShoveBegin (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener']/method[@name='onSidewaysShoveEnd' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.SidewaysShoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onSidewaysShoveEnd", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)V", "GetOnSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector/IOnSidewaysShoveGestureListenerInvoker, MapboxGestures")]
			void OnSidewaysShoveEnd (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0, float p1, float p2);

		}

		[global::Android.Runtime.Register ("com/mapbox/android/gestures/SidewaysShoveGestureDetector$OnSidewaysShoveGestureListener", DoNotGenerateAcw=true)]
		internal class IOnSidewaysShoveGestureListenerInvoker : global::Java.Lang.Object, IOnSidewaysShoveGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/SidewaysShoveGestureDetector$OnSidewaysShoveGestureListener", typeof (IOnSidewaysShoveGestureListenerInvoker));

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

			public static IOnSidewaysShoveGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSidewaysShoveGestureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.gestures.SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSidewaysShoveGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler ()
			{
				if (cb_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF == null)
					cb_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF);
				return cb_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
			}

			static bool n_OnSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSidewaysShove (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
			public unsafe bool OnSidewaysShove (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0, float p1, float p2)
			{
				if (id_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF == IntPtr.Zero)
					id_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF = JNIEnv.GetMethodID (class_ref, "onSidewaysShove", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF, __args);
				return __ret;
			}

			static Delegate cb_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_Handler ()
			{
				if (cb_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_ == null)
					cb_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_);
				return cb_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_;
			}

			static bool n_OnSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSidewaysShoveBegin (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_;
			public unsafe bool OnSidewaysShoveBegin (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0)
			{
				if (id_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_ == IntPtr.Zero)
					id_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_ = JNIEnv.GetMethodID (class_ref, "onSidewaysShoveBegin", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_, __args);
				return __ret;
			}

			static Delegate cb_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler ()
			{
				if (cb_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF == null)
					cb_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF);
				return cb_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
			}

			static void n_OnSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSidewaysShoveEnd (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
			public unsafe void OnSidewaysShoveEnd (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0, float p1, float p2)
			{
				if (id_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF == IntPtr.Zero)
					id_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF = JNIEnv.GetMethodID (class_ref, "onSidewaysShoveEnd", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF, __args);
			}

		}

		// event args for com.mapbox.android.gestures.SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener.onSidewaysShove
		public partial class SidewaysShoveEventArgs : global::System.EventArgs {

			public SidewaysShoveEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0, float p1, float p2)
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

			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector P0 {
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

		// event args for com.mapbox.android.gestures.SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener.onSidewaysShoveBegin
		public partial class SidewaysShoveBeginEventArgs : global::System.EventArgs {

			public SidewaysShoveBeginEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector P0 {
				get { return p0; }
			}
		}

		// event args for com.mapbox.android.gestures.SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener.onSidewaysShoveEnd
		public partial class SidewaysShoveEndEventArgs : global::System.EventArgs {

			public SidewaysShoveEndEventArgs (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0, float p1, float p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector P0 {
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

		[global::Android.Runtime.Register ("mono/com/mapbox/android/gestures/SidewaysShoveGestureDetector_OnSidewaysShoveGestureListenerImplementor")]
		internal sealed partial class IOnSidewaysShoveGestureListenerImplementor : global::Java.Lang.Object, IOnSidewaysShoveGestureListener {

			object sender;

			public IOnSidewaysShoveGestureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/android/gestures/SidewaysShoveGestureDetector_OnSidewaysShoveGestureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SidewaysShoveEventArgs> OnSidewaysShoveHandler;
#pragma warning restore 0649

			public bool OnSidewaysShove (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0, float p1, float p2)
			{
				var __h = OnSidewaysShoveHandler;
				if (__h == null)
					return false;
				var __e = new SidewaysShoveEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<SidewaysShoveBeginEventArgs> OnSidewaysShoveBeginHandler;
#pragma warning restore 0649

			public bool OnSidewaysShoveBegin (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0)
			{
				var __h = OnSidewaysShoveBeginHandler;
				if (__h == null)
					return false;
				var __e = new SidewaysShoveBeginEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<SidewaysShoveEndEventArgs> OnSidewaysShoveEndHandler;
#pragma warning restore 0649

			public void OnSidewaysShoveEnd (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector p0, float p1, float p2)
			{
				var __h = OnSidewaysShoveEndHandler;
				if (__h != null)
					__h (sender, new SidewaysShoveEndEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnSidewaysShoveGestureListenerImplementor value)
			{
				return value.OnSidewaysShoveHandler == null && value.OnSidewaysShoveBeginHandler == null && value.OnSidewaysShoveEndHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener']"
		[global::Android.Runtime.Register ("com/mapbox/android/gestures/SidewaysShoveGestureDetector$SimpleOnSidewaysShoveGestureListener", DoNotGenerateAcw=true)]
		public partial class SimpleOnSidewaysShoveGestureListener : global::Java.Lang.Object, global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/SidewaysShoveGestureDetector$SimpleOnSidewaysShoveGestureListener", typeof (SimpleOnSidewaysShoveGestureListener));
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

			protected SimpleOnSidewaysShoveGestureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener']/constructor[@name='SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SimpleOnSidewaysShoveGestureListener ()
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

			static Delegate cb_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler ()
			{
				if (cb_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF == null)
					cb_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF);
				return cb_onSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
			}

			static bool n_OnSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_detector, float deltaPixelsSinceLast, float deltaPixelsSinceStart)
			{
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSidewaysShove (detector, deltaPixelsSinceLast, deltaPixelsSinceStart);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener']/method[@name='onSidewaysShove' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.SidewaysShoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onSidewaysShove", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)Z", "GetOnSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler")]
			public virtual unsafe bool OnSidewaysShove (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector detector, float deltaPixelsSinceLast, float deltaPixelsSinceStart)
			{
				const string __id = "onSidewaysShove.(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)Z";
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

			static Delegate cb_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_Handler ()
			{
				if (cb_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_ == null)
					cb_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_);
				return cb_onSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_;
			}

			static bool n_OnSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_detector)
			{
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSidewaysShoveBegin (detector);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener']/method[@name='onSidewaysShoveBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.SidewaysShoveGestureDetector']]"
			[Register ("onSidewaysShoveBegin", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;)Z", "GetOnSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_Handler")]
			public virtual unsafe bool OnSidewaysShoveBegin (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector detector)
			{
				const string __id = "onSidewaysShoveBegin.(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler ()
			{
				if (cb_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF == null)
					cb_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF);
				return cb_onSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF;
			}

			static void n_OnSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_detector, float velocityX, float velocityY)
			{
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				__this.OnSidewaysShoveEnd (detector, velocityX, velocityY);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector.SimpleOnSidewaysShoveGestureListener']/method[@name='onSidewaysShoveEnd' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.SidewaysShoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onSidewaysShoveEnd", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)V", "GetOnSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler")]
			public virtual unsafe void OnSidewaysShoveEnd (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector detector, float velocityX, float velocityY)
			{
				const string __id = "onSidewaysShoveEnd.(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)V";
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/SidewaysShoveGestureDetector", typeof (SidewaysShoveGestureDetector));
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

		protected SidewaysShoveGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']/constructor[@name='SidewaysShoveGestureDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe SidewaysShoveGestureDetector (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager gesturesManager)
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
			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaPixelSinceLast;
		}
#pragma warning restore 0169

		public virtual unsafe float DeltaPixelSinceLast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']/method[@name='getDeltaPixelSinceLast' and count(parameter)=0]"
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
			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaPixelsSinceStart;
		}
#pragma warning restore 0169

		public virtual unsafe float DeltaPixelsSinceStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']/method[@name='getDeltaPixelsSinceStart' and count(parameter)=0]"
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
			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxShoveAngle = maxShoveAngle;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxShoveAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']/method[@name='getMaxShoveAngle' and count(parameter)=0]"
			[Register ("getMaxShoveAngle", "()F", "GetGetMaxShoveAngleHandler")]
			get {
				const string __id = "getMaxShoveAngle.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']/method[@name='setMaxShoveAngle' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PixelDeltaThreshold = pixelDeltaThreshold;
		}
#pragma warning restore 0169

		public virtual unsafe float PixelDeltaThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']/method[@name='getPixelDeltaThreshold' and count(parameter)=0]"
			[Register ("getPixelDeltaThreshold", "()F", "GetGetPixelDeltaThresholdHandler")]
			get {
				const string __id = "getPixelDeltaThreshold.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']/method[@name='setPixelDeltaThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ProvideHandledTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']/method[@name='provideHandledTypes' and count(parameter)=0]"
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
			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPixelDeltaThresholdResource (pixelDeltaThresholdDimen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='SidewaysShoveGestureDetector']/method[@name='setPixelDeltaThresholdResource' and count(parameter)=1 and parameter[1][@type='int']]"
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
