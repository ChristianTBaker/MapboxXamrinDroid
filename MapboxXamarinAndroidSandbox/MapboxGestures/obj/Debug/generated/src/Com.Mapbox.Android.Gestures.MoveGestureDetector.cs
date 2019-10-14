using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/MoveGestureDetector", DoNotGenerateAcw=true)]
	public partial class MoveGestureDetector : global::Com.Mapbox.Android.Gestures.ProgressiveGesture {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='MoveGestureDetector.OnMoveGestureListener']"
		[Register ("com/mapbox/android/gestures/MoveGestureDetector$OnMoveGestureListener", "", "Com.Mapbox.Android.Gestures.MoveGestureDetector/IOnMoveGestureListenerInvoker")]
		public partial interface IOnMoveGestureListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='MoveGestureDetector.OnMoveGestureListener']/method[@name='onMove' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.MoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onMove", "(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)Z", "GetOnMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.MoveGestureDetector/IOnMoveGestureListenerInvoker, MapboxGestures")]
			bool OnMove (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0, float p1, float p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='MoveGestureDetector.OnMoveGestureListener']/method[@name='onMoveBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.MoveGestureDetector']]"
			[Register ("onMoveBegin", "(Lcom/mapbox/android/gestures/MoveGestureDetector;)Z", "GetOnMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_Handler:Com.Mapbox.Android.Gestures.MoveGestureDetector/IOnMoveGestureListenerInvoker, MapboxGestures")]
			bool OnMoveBegin (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='MoveGestureDetector.OnMoveGestureListener']/method[@name='onMoveEnd' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.MoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onMoveEnd", "(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)V", "GetOnMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.MoveGestureDetector/IOnMoveGestureListenerInvoker, MapboxGestures")]
			void OnMoveEnd (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0, float p1, float p2);

		}

		[global::Android.Runtime.Register ("com/mapbox/android/gestures/MoveGestureDetector$OnMoveGestureListener", DoNotGenerateAcw=true)]
		internal class IOnMoveGestureListenerInvoker : global::Java.Lang.Object, IOnMoveGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/MoveGestureDetector$OnMoveGestureListener", typeof (IOnMoveGestureListenerInvoker));

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

			public static IOnMoveGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMoveGestureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.gestures.MoveGestureDetector.OnMoveGestureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMoveGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler ()
			{
				if (cb_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF == null)
					cb_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF);
				return cb_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
			}

			static bool n_OnMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMove (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
			public unsafe bool OnMove (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0, float p1, float p2)
			{
				if (id_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF == IntPtr.Zero)
					id_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF = JNIEnv.GetMethodID (class_ref, "onMove", "(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF, __args);
				return __ret;
			}

			static Delegate cb_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_Handler ()
			{
				if (cb_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_ == null)
					cb_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_);
				return cb_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_;
			}

			static bool n_OnMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMoveBegin (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_;
			public unsafe bool OnMoveBegin (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0)
			{
				if (id_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_ == IntPtr.Zero)
					id_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_ = JNIEnv.GetMethodID (class_ref, "onMoveBegin", "(Lcom/mapbox/android/gestures/MoveGestureDetector;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_, __args);
				return __ret;
			}

			static Delegate cb_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler ()
			{
				if (cb_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF == null)
					cb_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF);
				return cb_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
			}

			static void n_OnMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMoveEnd (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
			public unsafe void OnMoveEnd (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0, float p1, float p2)
			{
				if (id_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF == IntPtr.Zero)
					id_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF = JNIEnv.GetMethodID (class_ref, "onMoveEnd", "(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF, __args);
			}

		}

		// event args for com.mapbox.android.gestures.MoveGestureDetector.OnMoveGestureListener.onMove
		public partial class MoveEventArgs : global::System.EventArgs {

			public MoveEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0, float p1, float p2)
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

			global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.MoveGestureDetector P0 {
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

		// event args for com.mapbox.android.gestures.MoveGestureDetector.OnMoveGestureListener.onMoveBegin
		public partial class MoveBeginEventArgs : global::System.EventArgs {

			public MoveBeginEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.MoveGestureDetector P0 {
				get { return p0; }
			}
		}

		// event args for com.mapbox.android.gestures.MoveGestureDetector.OnMoveGestureListener.onMoveEnd
		public partial class MoveEndEventArgs : global::System.EventArgs {

			public MoveEndEventArgs (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0, float p1, float p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.MoveGestureDetector P0 {
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

		[global::Android.Runtime.Register ("mono/com/mapbox/android/gestures/MoveGestureDetector_OnMoveGestureListenerImplementor")]
		internal sealed partial class IOnMoveGestureListenerImplementor : global::Java.Lang.Object, IOnMoveGestureListener {

			object sender;

			public IOnMoveGestureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/android/gestures/MoveGestureDetector_OnMoveGestureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MoveEventArgs> OnMoveHandler;
#pragma warning restore 0649

			public bool OnMove (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0, float p1, float p2)
			{
				var __h = OnMoveHandler;
				if (__h == null)
					return false;
				var __e = new MoveEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<MoveBeginEventArgs> OnMoveBeginHandler;
#pragma warning restore 0649

			public bool OnMoveBegin (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0)
			{
				var __h = OnMoveBeginHandler;
				if (__h == null)
					return false;
				var __e = new MoveBeginEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<MoveEndEventArgs> OnMoveEndHandler;
#pragma warning restore 0649

			public void OnMoveEnd (global::Com.Mapbox.Android.Gestures.MoveGestureDetector p0, float p1, float p2)
			{
				var __h = OnMoveEndHandler;
				if (__h != null)
					__h (sender, new MoveEndEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnMoveGestureListenerImplementor value)
			{
				return value.OnMoveHandler == null && value.OnMoveBeginHandler == null && value.OnMoveEndHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector.SimpleOnMoveGestureListener']"
		[global::Android.Runtime.Register ("com/mapbox/android/gestures/MoveGestureDetector$SimpleOnMoveGestureListener", DoNotGenerateAcw=true)]
		public partial class SimpleOnMoveGestureListener : global::Java.Lang.Object, global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/MoveGestureDetector$SimpleOnMoveGestureListener", typeof (SimpleOnMoveGestureListener));
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

			protected SimpleOnMoveGestureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector.SimpleOnMoveGestureListener']/constructor[@name='MoveGestureDetector.SimpleOnMoveGestureListener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SimpleOnMoveGestureListener ()
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

			static Delegate cb_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler ()
			{
				if (cb_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF == null)
					cb_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF);
				return cb_onMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
			}

			static bool n_OnMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_detector, float distanceX, float distanceY)
			{
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector.SimpleOnMoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.SimpleOnMoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMove (detector, distanceX, distanceY);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector.SimpleOnMoveGestureListener']/method[@name='onMove' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.MoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onMove", "(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)Z", "GetOnMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler")]
			public virtual unsafe bool OnMove (global::Com.Mapbox.Android.Gestures.MoveGestureDetector detector, float distanceX, float distanceY)
			{
				const string __id = "onMove.(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					__args [1] = new JniArgumentValue (distanceX);
					__args [2] = new JniArgumentValue (distanceY);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_Handler ()
			{
				if (cb_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_ == null)
					cb_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_);
				return cb_onMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_;
			}

			static bool n_OnMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_detector)
			{
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector.SimpleOnMoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.SimpleOnMoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMoveBegin (detector);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector.SimpleOnMoveGestureListener']/method[@name='onMoveBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.MoveGestureDetector']]"
			[Register ("onMoveBegin", "(Lcom/mapbox/android/gestures/MoveGestureDetector;)Z", "GetOnMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_Handler")]
			public virtual unsafe bool OnMoveBegin (global::Com.Mapbox.Android.Gestures.MoveGestureDetector detector)
			{
				const string __id = "onMoveBegin.(Lcom/mapbox/android/gestures/MoveGestureDetector;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler ()
			{
				if (cb_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF == null)
					cb_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF);
				return cb_onMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF;
			}

			static void n_OnMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_detector, float velocityX, float velocityY)
			{
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector.SimpleOnMoveGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.SimpleOnMoveGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.MoveGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				__this.OnMoveEnd (detector, velocityX, velocityY);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector.SimpleOnMoveGestureListener']/method[@name='onMoveEnd' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.MoveGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onMoveEnd", "(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)V", "GetOnMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler")]
			public virtual unsafe void OnMoveEnd (global::Com.Mapbox.Android.Gestures.MoveGestureDetector detector, float velocityX, float velocityY)
			{
				const string __id = "onMoveEnd.(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)V";
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/MoveGestureDetector", typeof (MoveGestureDetector));
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

		protected MoveGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector']/constructor[@name='MoveGestureDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe MoveGestureDetector (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager gesturesManager)
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

		static Delegate cb_getLastDistanceX;
#pragma warning disable 0169
		static Delegate GetGetLastDistanceXHandler ()
		{
			if (cb_getLastDistanceX == null)
				cb_getLastDistanceX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLastDistanceX);
			return cb_getLastDistanceX;
		}

		static float n_GetLastDistanceX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastDistanceX;
		}
#pragma warning restore 0169

		public virtual unsafe float LastDistanceX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector']/method[@name='getLastDistanceX' and count(parameter)=0]"
			[Register ("getLastDistanceX", "()F", "GetGetLastDistanceXHandler")]
			get {
				const string __id = "getLastDistanceX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastDistanceY;
#pragma warning disable 0169
		static Delegate GetGetLastDistanceYHandler ()
		{
			if (cb_getLastDistanceY == null)
				cb_getLastDistanceY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLastDistanceY);
			return cb_getLastDistanceY;
		}

		static float n_GetLastDistanceY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastDistanceY;
		}
#pragma warning restore 0169

		public virtual unsafe float LastDistanceY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector']/method[@name='getLastDistanceY' and count(parameter)=0]"
			[Register ("getLastDistanceY", "()F", "GetGetLastDistanceYHandler")]
			get {
				const string __id = "getLastDistanceY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMoveThreshold;
#pragma warning disable 0169
		static Delegate GetGetMoveThresholdHandler ()
		{
			if (cb_getMoveThreshold == null)
				cb_getMoveThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMoveThreshold);
			return cb_getMoveThreshold;
		}

		static float n_GetMoveThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoveThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setMoveThreshold_F;
#pragma warning disable 0169
		static Delegate GetSetMoveThreshold_FHandler ()
		{
			if (cb_setMoveThreshold_F == null)
				cb_setMoveThreshold_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMoveThreshold_F);
			return cb_setMoveThreshold_F;
		}

		static void n_SetMoveThreshold_F (IntPtr jnienv, IntPtr native__this, float moveThreshold)
		{
			global::Com.Mapbox.Android.Gestures.MoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveThreshold = moveThreshold;
		}
#pragma warning restore 0169

		public virtual unsafe float MoveThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector']/method[@name='getMoveThreshold' and count(parameter)=0]"
			[Register ("getMoveThreshold", "()F", "GetGetMoveThresholdHandler")]
			get {
				const string __id = "getMoveThreshold.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector']/method[@name='setMoveThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMoveThreshold", "(F)V", "GetSetMoveThreshold_FHandler")]
			set {
				const string __id = "setMoveThreshold.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMoveObject_I;
#pragma warning disable 0169
		static Delegate GetGetMoveObject_IHandler ()
		{
			if (cb_getMoveObject_I == null)
				cb_getMoveObject_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMoveObject_I);
			return cb_getMoveObject_I;
		}

		static IntPtr n_GetMoveObject_I (IntPtr jnienv, IntPtr native__this, int pointerIndex)
		{
			global::Com.Mapbox.Android.Gestures.MoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMoveObject (pointerIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector']/method[@name='getMoveObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMoveObject", "(I)Lcom/mapbox/android/gestures/MoveDistancesObject;", "GetGetMoveObject_IHandler")]
		public virtual unsafe global::Com.Mapbox.Android.Gestures.MoveDistancesObject GetMoveObject (int pointerIndex)
		{
			const string __id = "getMoveObject.(I)Lcom/mapbox/android/gestures/MoveDistancesObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pointerIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveDistancesObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Mapbox.Android.Gestures.MoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ProvideHandledTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector']/method[@name='provideHandledTypes' and count(parameter)=0]"
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

		static Delegate cb_setMoveThresholdResource_I;
#pragma warning disable 0169
		static Delegate GetSetMoveThresholdResource_IHandler ()
		{
			if (cb_setMoveThresholdResource_I == null)
				cb_setMoveThresholdResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMoveThresholdResource_I);
			return cb_setMoveThresholdResource_I;
		}

		static void n_SetMoveThresholdResource_I (IntPtr jnienv, IntPtr native__this, int moveThresholdDimen)
		{
			global::Com.Mapbox.Android.Gestures.MoveGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMoveThresholdResource (moveThresholdDimen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveGestureDetector']/method[@name='setMoveThresholdResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMoveThresholdResource", "(I)V", "GetSetMoveThresholdResource_IHandler")]
		public virtual unsafe void SetMoveThresholdResource (int moveThresholdDimen)
		{
			const string __id = "setMoveThresholdResource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (moveThresholdDimen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
