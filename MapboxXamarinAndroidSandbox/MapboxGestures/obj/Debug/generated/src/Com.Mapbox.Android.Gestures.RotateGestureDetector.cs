using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/RotateGestureDetector", DoNotGenerateAcw=true)]
	public partial class RotateGestureDetector : global::Com.Mapbox.Android.Gestures.ProgressiveGesture {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='RotateGestureDetector.OnRotateGestureListener']"
		[Register ("com/mapbox/android/gestures/RotateGestureDetector$OnRotateGestureListener", "", "Com.Mapbox.Android.Gestures.RotateGestureDetector/IOnRotateGestureListenerInvoker")]
		public partial interface IOnRotateGestureListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='RotateGestureDetector.OnRotateGestureListener']/method[@name='onRotate' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.RotateGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onRotate", "(Lcom/mapbox/android/gestures/RotateGestureDetector;FF)Z", "GetOnRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.RotateGestureDetector/IOnRotateGestureListenerInvoker, MapboxGestures")]
			bool OnRotate (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0, float p1, float p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='RotateGestureDetector.OnRotateGestureListener']/method[@name='onRotateBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.RotateGestureDetector']]"
			[Register ("onRotateBegin", "(Lcom/mapbox/android/gestures/RotateGestureDetector;)Z", "GetOnRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_Handler:Com.Mapbox.Android.Gestures.RotateGestureDetector/IOnRotateGestureListenerInvoker, MapboxGestures")]
			bool OnRotateBegin (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='RotateGestureDetector.OnRotateGestureListener']/method[@name='onRotateEnd' and count(parameter)=4 and parameter[1][@type='com.mapbox.android.gestures.RotateGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("onRotateEnd", "(Lcom/mapbox/android/gestures/RotateGestureDetector;FFF)V", "GetOnRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFFHandler:Com.Mapbox.Android.Gestures.RotateGestureDetector/IOnRotateGestureListenerInvoker, MapboxGestures")]
			void OnRotateEnd (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0, float p1, float p2, float p3);

		}

		[global::Android.Runtime.Register ("com/mapbox/android/gestures/RotateGestureDetector$OnRotateGestureListener", DoNotGenerateAcw=true)]
		internal class IOnRotateGestureListenerInvoker : global::Java.Lang.Object, IOnRotateGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/RotateGestureDetector$OnRotateGestureListener", typeof (IOnRotateGestureListenerInvoker));

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

			public static IOnRotateGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRotateGestureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.gestures.RotateGestureDetector.OnRotateGestureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRotateGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FFHandler ()
			{
				if (cb_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF == null)
					cb_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF);
				return cb_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF;
			}

			static bool n_OnRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnRotate (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF;
			public unsafe bool OnRotate (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0, float p1, float p2)
			{
				if (id_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF == IntPtr.Zero)
					id_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF = JNIEnv.GetMethodID (class_ref, "onRotate", "(Lcom/mapbox/android/gestures/RotateGestureDetector;FF)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF, __args);
				return __ret;
			}

			static Delegate cb_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_Handler ()
			{
				if (cb_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_ == null)
					cb_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_);
				return cb_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_;
			}

			static bool n_OnRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnRotateBegin (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_;
			public unsafe bool OnRotateBegin (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0)
			{
				if (id_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_ == IntPtr.Zero)
					id_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_ = JNIEnv.GetMethodID (class_ref, "onRotateBegin", "(Lcom/mapbox/android/gestures/RotateGestureDetector;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_, __args);
				return __ret;
			}

			static Delegate cb_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF;
#pragma warning disable 0169
			static Delegate GetOnRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFFHandler ()
			{
				if (cb_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF == null)
					cb_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float, float>) n_OnRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF);
				return cb_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF;
			}

			static void n_OnRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2, float p3)
			{
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRotateEnd (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF;
			public unsafe void OnRotateEnd (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0, float p1, float p2, float p3)
			{
				if (id_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF == IntPtr.Zero)
					id_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF = JNIEnv.GetMethodID (class_ref, "onRotateEnd", "(Lcom/mapbox/android/gestures/RotateGestureDetector;FFF)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF, __args);
			}

		}

		// event args for com.mapbox.android.gestures.RotateGestureDetector.OnRotateGestureListener.onRotate
		public partial class RotateEventArgs : global::System.EventArgs {

			public RotateEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0, float p1, float p2)
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

			global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.RotateGestureDetector P0 {
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

		// event args for com.mapbox.android.gestures.RotateGestureDetector.OnRotateGestureListener.onRotateBegin
		public partial class RotateBeginEventArgs : global::System.EventArgs {

			public RotateBeginEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.RotateGestureDetector P0 {
				get { return p0; }
			}
		}

		// event args for com.mapbox.android.gestures.RotateGestureDetector.OnRotateGestureListener.onRotateEnd
		public partial class RotateEndEventArgs : global::System.EventArgs {

			public RotateEndEventArgs (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0, float p1, float p2, float p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.RotateGestureDetector P0 {
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

			float p3;
			public float P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/android/gestures/RotateGestureDetector_OnRotateGestureListenerImplementor")]
		internal sealed partial class IOnRotateGestureListenerImplementor : global::Java.Lang.Object, IOnRotateGestureListener {

			object sender;

			public IOnRotateGestureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/android/gestures/RotateGestureDetector_OnRotateGestureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RotateEventArgs> OnRotateHandler;
#pragma warning restore 0649

			public bool OnRotate (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0, float p1, float p2)
			{
				var __h = OnRotateHandler;
				if (__h == null)
					return false;
				var __e = new RotateEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<RotateBeginEventArgs> OnRotateBeginHandler;
#pragma warning restore 0649

			public bool OnRotateBegin (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0)
			{
				var __h = OnRotateBeginHandler;
				if (__h == null)
					return false;
				var __e = new RotateBeginEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<RotateEndEventArgs> OnRotateEndHandler;
#pragma warning restore 0649

			public void OnRotateEnd (global::Com.Mapbox.Android.Gestures.RotateGestureDetector p0, float p1, float p2, float p3)
			{
				var __h = OnRotateEndHandler;
				if (__h != null)
					__h (sender, new RotateEndEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IOnRotateGestureListenerImplementor value)
			{
				return value.OnRotateHandler == null && value.OnRotateBeginHandler == null && value.OnRotateEndHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector.SimpleOnRotateGestureListener']"
		[global::Android.Runtime.Register ("com/mapbox/android/gestures/RotateGestureDetector$SimpleOnRotateGestureListener", DoNotGenerateAcw=true)]
		public partial class SimpleOnRotateGestureListener : global::Java.Lang.Object, global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/RotateGestureDetector$SimpleOnRotateGestureListener", typeof (SimpleOnRotateGestureListener));
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

			protected SimpleOnRotateGestureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector.SimpleOnRotateGestureListener']/constructor[@name='RotateGestureDetector.SimpleOnRotateGestureListener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SimpleOnRotateGestureListener ()
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

			static Delegate cb_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FFHandler ()
			{
				if (cb_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF == null)
					cb_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF);
				return cb_onRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF;
			}

			static bool n_OnRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_detector, float rotationDegreesSinceLast, float rotationDegreesSinceFirst)
			{
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector.SimpleOnRotateGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.SimpleOnRotateGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnRotate (detector, rotationDegreesSinceLast, rotationDegreesSinceFirst);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector.SimpleOnRotateGestureListener']/method[@name='onRotate' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.RotateGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onRotate", "(Lcom/mapbox/android/gestures/RotateGestureDetector;FF)Z", "GetOnRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FFHandler")]
			public virtual unsafe bool OnRotate (global::Com.Mapbox.Android.Gestures.RotateGestureDetector detector, float rotationDegreesSinceLast, float rotationDegreesSinceFirst)
			{
				const string __id = "onRotate.(Lcom/mapbox/android/gestures/RotateGestureDetector;FF)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					__args [1] = new JniArgumentValue (rotationDegreesSinceLast);
					__args [2] = new JniArgumentValue (rotationDegreesSinceFirst);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_Handler ()
			{
				if (cb_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_ == null)
					cb_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_);
				return cb_onRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_;
			}

			static bool n_OnRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_detector)
			{
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector.SimpleOnRotateGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.SimpleOnRotateGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnRotateBegin (detector);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector.SimpleOnRotateGestureListener']/method[@name='onRotateBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.RotateGestureDetector']]"
			[Register ("onRotateBegin", "(Lcom/mapbox/android/gestures/RotateGestureDetector;)Z", "GetOnRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_Handler")]
			public virtual unsafe bool OnRotateBegin (global::Com.Mapbox.Android.Gestures.RotateGestureDetector detector)
			{
				const string __id = "onRotateBegin.(Lcom/mapbox/android/gestures/RotateGestureDetector;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF;
#pragma warning disable 0169
			static Delegate GetOnRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFFHandler ()
			{
				if (cb_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF == null)
					cb_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float, float>) n_OnRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF);
				return cb_onRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF;
			}

			static void n_OnRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFF (IntPtr jnienv, IntPtr native__this, IntPtr native_detector, float velocityX, float velocityY, float angularVelocity)
			{
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector.SimpleOnRotateGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.SimpleOnRotateGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.RotateGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				__this.OnRotateEnd (detector, velocityX, velocityY, angularVelocity);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector.SimpleOnRotateGestureListener']/method[@name='onRotateEnd' and count(parameter)=4 and parameter[1][@type='com.mapbox.android.gestures.RotateGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("onRotateEnd", "(Lcom/mapbox/android/gestures/RotateGestureDetector;FFF)V", "GetOnRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFFHandler")]
			public virtual unsafe void OnRotateEnd (global::Com.Mapbox.Android.Gestures.RotateGestureDetector detector, float velocityX, float velocityY, float angularVelocity)
			{
				const string __id = "onRotateEnd.(Lcom/mapbox/android/gestures/RotateGestureDetector;FFF)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					__args [1] = new JniArgumentValue (velocityX);
					__args [2] = new JniArgumentValue (velocityY);
					__args [3] = new JniArgumentValue (angularVelocity);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/RotateGestureDetector", typeof (RotateGestureDetector));
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

		protected RotateGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector']/constructor[@name='RotateGestureDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe RotateGestureDetector (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager gesturesManager)
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

		static Delegate cb_getAngleThreshold;
#pragma warning disable 0169
		static Delegate GetGetAngleThresholdHandler ()
		{
			if (cb_getAngleThreshold == null)
				cb_getAngleThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAngleThreshold);
			return cb_getAngleThreshold;
		}

		static float n_GetAngleThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.RotateGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AngleThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setAngleThreshold_F;
#pragma warning disable 0169
		static Delegate GetSetAngleThreshold_FHandler ()
		{
			if (cb_setAngleThreshold_F == null)
				cb_setAngleThreshold_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAngleThreshold_F);
			return cb_setAngleThreshold_F;
		}

		static void n_SetAngleThreshold_F (IntPtr jnienv, IntPtr native__this, float angleThreshold)
		{
			global::Com.Mapbox.Android.Gestures.RotateGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AngleThreshold = angleThreshold;
		}
#pragma warning restore 0169

		public virtual unsafe float AngleThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector']/method[@name='getAngleThreshold' and count(parameter)=0]"
			[Register ("getAngleThreshold", "()F", "GetGetAngleThresholdHandler")]
			get {
				const string __id = "getAngleThreshold.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector']/method[@name='setAngleThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAngleThreshold", "(F)V", "GetSetAngleThreshold_FHandler")]
			set {
				const string __id = "setAngleThreshold.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeltaSinceLast;
#pragma warning disable 0169
		static Delegate GetGetDeltaSinceLastHandler ()
		{
			if (cb_getDeltaSinceLast == null)
				cb_getDeltaSinceLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDeltaSinceLast);
			return cb_getDeltaSinceLast;
		}

		static float n_GetDeltaSinceLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.RotateGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaSinceLast;
		}
#pragma warning restore 0169

		public virtual unsafe float DeltaSinceLast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector']/method[@name='getDeltaSinceLast' and count(parameter)=0]"
			[Register ("getDeltaSinceLast", "()F", "GetGetDeltaSinceLastHandler")]
			get {
				const string __id = "getDeltaSinceLast.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDeltaSinceStart;
#pragma warning disable 0169
		static Delegate GetGetDeltaSinceStartHandler ()
		{
			if (cb_getDeltaSinceStart == null)
				cb_getDeltaSinceStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDeltaSinceStart);
			return cb_getDeltaSinceStart;
		}

		static float n_GetDeltaSinceStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.RotateGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaSinceStart;
		}
#pragma warning restore 0169

		public virtual unsafe float DeltaSinceStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector']/method[@name='getDeltaSinceStart' and count(parameter)=0]"
			[Register ("getDeltaSinceStart", "()F", "GetGetDeltaSinceStartHandler")]
			get {
				const string __id = "getDeltaSinceStart.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
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
			global::Com.Mapbox.Android.Gestures.RotateGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ProvideHandledTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='RotateGestureDetector']/method[@name='provideHandledTypes' and count(parameter)=0]"
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

	}
}
