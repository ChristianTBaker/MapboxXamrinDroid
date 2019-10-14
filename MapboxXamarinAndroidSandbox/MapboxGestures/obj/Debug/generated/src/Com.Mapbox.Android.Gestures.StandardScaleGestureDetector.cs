using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/StandardScaleGestureDetector", DoNotGenerateAcw=true)]
	public partial class StandardScaleGestureDetector : global::Com.Mapbox.Android.Gestures.ProgressiveGesture {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener']"
		[global::Android.Runtime.Register ("com/mapbox/android/gestures/StandardScaleGestureDetector$SimpleStandardOnScaleGestureListener", DoNotGenerateAcw=true)]
		public partial class SimpleStandardOnScaleGestureListener : global::Java.Lang.Object, global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/StandardScaleGestureDetector$SimpleStandardOnScaleGestureListener", typeof (SimpleStandardOnScaleGestureListener));
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

			protected SimpleStandardOnScaleGestureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener']/constructor[@name='StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SimpleStandardOnScaleGestureListener ()
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

			static Delegate cb_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler ()
			{
				if (cb_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ == null)
					cb_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_);
				return cb_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
			}

			static bool n_OnScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_detector)
			{
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnScale (detector);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener']/method[@name='onScale' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.StandardScaleGestureDetector']]"
			[Register ("onScale", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z", "GetOnScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler")]
			public virtual unsafe bool OnScale (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector detector)
			{
				const string __id = "onScale.(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler ()
			{
				if (cb_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ == null)
					cb_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_);
				return cb_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
			}

			static bool n_OnScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_detector)
			{
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnScaleBegin (detector);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener']/method[@name='onScaleBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.StandardScaleGestureDetector']]"
			[Register ("onScaleBegin", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z", "GetOnScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler")]
			public virtual unsafe bool OnScaleBegin (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector detector)
			{
				const string __id = "onScaleBegin.(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((detector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) detector).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FFHandler ()
			{
				if (cb_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF == null)
					cb_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF);
				return cb_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF;
			}

			static void n_OnScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_detector, float velocityX, float velocityY)
			{
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector detector = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (native_detector, JniHandleOwnership.DoNotTransfer);
				__this.OnScaleEnd (detector, velocityX, velocityY);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector.SimpleStandardOnScaleGestureListener']/method[@name='onScaleEnd' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.StandardScaleGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onScaleEnd", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;FF)V", "GetOnScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FFHandler")]
			public virtual unsafe void OnScaleEnd (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector detector, float velocityX, float velocityY)
			{
				const string __id = "onScaleEnd.(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;FF)V";
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='StandardScaleGestureDetector.StandardOnScaleGestureListener']"
		[Register ("com/mapbox/android/gestures/StandardScaleGestureDetector$StandardOnScaleGestureListener", "", "Com.Mapbox.Android.Gestures.StandardScaleGestureDetector/IStandardOnScaleGestureListenerInvoker")]
		public partial interface IStandardOnScaleGestureListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='StandardScaleGestureDetector.StandardOnScaleGestureListener']/method[@name='onScale' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.StandardScaleGestureDetector']]"
			[Register ("onScale", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z", "GetOnScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler:Com.Mapbox.Android.Gestures.StandardScaleGestureDetector/IStandardOnScaleGestureListenerInvoker, MapboxGestures")]
			bool OnScale (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='StandardScaleGestureDetector.StandardOnScaleGestureListener']/method[@name='onScaleBegin' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.StandardScaleGestureDetector']]"
			[Register ("onScaleBegin", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z", "GetOnScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler:Com.Mapbox.Android.Gestures.StandardScaleGestureDetector/IStandardOnScaleGestureListenerInvoker, MapboxGestures")]
			bool OnScaleBegin (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='StandardScaleGestureDetector.StandardOnScaleGestureListener']/method[@name='onScaleEnd' and count(parameter)=3 and parameter[1][@type='com.mapbox.android.gestures.StandardScaleGestureDetector'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onScaleEnd", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;FF)V", "GetOnScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.StandardScaleGestureDetector/IStandardOnScaleGestureListenerInvoker, MapboxGestures")]
			void OnScaleEnd (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0, float p1, float p2);

		}

		[global::Android.Runtime.Register ("com/mapbox/android/gestures/StandardScaleGestureDetector$StandardOnScaleGestureListener", DoNotGenerateAcw=true)]
		internal class IStandardOnScaleGestureListenerInvoker : global::Java.Lang.Object, IStandardOnScaleGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/StandardScaleGestureDetector$StandardOnScaleGestureListener", typeof (IStandardOnScaleGestureListenerInvoker));

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

			public static IStandardOnScaleGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStandardOnScaleGestureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.gestures.StandardScaleGestureDetector.StandardOnScaleGestureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStandardOnScaleGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler ()
			{
				if (cb_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ == null)
					cb_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_);
				return cb_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
			}

			static bool n_OnScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnScale (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
			public unsafe bool OnScale (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0)
			{
				if (id_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ == IntPtr.Zero)
					id_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ = JNIEnv.GetMethodID (class_ref, "onScale", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_, __args);
				return __ret;
			}

			static Delegate cb_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
#pragma warning disable 0169
			static Delegate GetOnScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler ()
			{
				if (cb_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ == null)
					cb_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_);
				return cb_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
			}

			static bool n_OnScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnScaleBegin (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_;
			public unsafe bool OnScaleBegin (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0)
			{
				if (id_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ == IntPtr.Zero)
					id_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_ = JNIEnv.GetMethodID (class_ref, "onScaleBegin", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_, __args);
				return __ret;
			}

			static Delegate cb_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF;
#pragma warning disable 0169
			static Delegate GetOnScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FFHandler ()
			{
				if (cb_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF == null)
					cb_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF);
				return cb_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF;
			}

			static void n_OnScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
			{
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnScaleEnd (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF;
			public unsafe void OnScaleEnd (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0, float p1, float p2)
			{
				if (id_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF == IntPtr.Zero)
					id_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF = JNIEnv.GetMethodID (class_ref, "onScaleEnd", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;FF)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FF, __args);
			}

		}

		// event args for com.mapbox.android.gestures.StandardScaleGestureDetector.StandardOnScaleGestureListener.onScale
		public partial class ScaleEventArgs : global::System.EventArgs {

			public ScaleEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector P0 {
				get { return p0; }
			}
		}

		// event args for com.mapbox.android.gestures.StandardScaleGestureDetector.StandardOnScaleGestureListener.onScaleBegin
		public partial class ScaleBeginEventArgs : global::System.EventArgs {

			public ScaleBeginEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector P0 {
				get { return p0; }
			}
		}

		// event args for com.mapbox.android.gestures.StandardScaleGestureDetector.StandardOnScaleGestureListener.onScaleEnd
		public partial class ScaleEndEventArgs : global::System.EventArgs {

			public ScaleEndEventArgs (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0, float p1, float p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector P0 {
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

		[global::Android.Runtime.Register ("mono/com/mapbox/android/gestures/StandardScaleGestureDetector_StandardOnScaleGestureListenerImplementor")]
		internal sealed partial class IStandardOnScaleGestureListenerImplementor : global::Java.Lang.Object, IStandardOnScaleGestureListener {

			object sender;

			public IStandardOnScaleGestureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/android/gestures/StandardScaleGestureDetector_StandardOnScaleGestureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ScaleEventArgs> OnScaleHandler;
#pragma warning restore 0649

			public bool OnScale (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0)
			{
				var __h = OnScaleHandler;
				if (__h == null)
					return false;
				var __e = new ScaleEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<ScaleBeginEventArgs> OnScaleBeginHandler;
#pragma warning restore 0649

			public bool OnScaleBegin (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0)
			{
				var __h = OnScaleBeginHandler;
				if (__h == null)
					return false;
				var __e = new ScaleBeginEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<ScaleEndEventArgs> OnScaleEndHandler;
#pragma warning restore 0649

			public void OnScaleEnd (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector p0, float p1, float p2)
			{
				var __h = OnScaleEndHandler;
				if (__h != null)
					__h (sender, new ScaleEndEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IStandardOnScaleGestureListenerImplementor value)
			{
				return value.OnScaleHandler == null && value.OnScaleBeginHandler == null && value.OnScaleEndHandler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/StandardScaleGestureDetector", typeof (StandardScaleGestureDetector));
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

		protected StandardScaleGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/constructor[@name='StandardScaleGestureDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe StandardScaleGestureDetector (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager androidGesturesManager)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((androidGesturesManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) androidGesturesManager).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentSpan;
#pragma warning disable 0169
		static Delegate GetGetCurrentSpanHandler ()
		{
			if (cb_getCurrentSpan == null)
				cb_getCurrentSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrentSpan);
			return cb_getCurrentSpan;
		}

		static float n_GetCurrentSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSpan;
		}
#pragma warning restore 0169

		public virtual unsafe float CurrentSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getCurrentSpan' and count(parameter)=0]"
			[Register ("getCurrentSpan", "()F", "GetGetCurrentSpanHandler")]
			get {
				const string __id = "getCurrentSpan.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentSpanX;
#pragma warning disable 0169
		static Delegate GetGetCurrentSpanXHandler ()
		{
			if (cb_getCurrentSpanX == null)
				cb_getCurrentSpanX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrentSpanX);
			return cb_getCurrentSpanX;
		}

		static float n_GetCurrentSpanX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSpanX;
		}
#pragma warning restore 0169

		public virtual unsafe float CurrentSpanX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getCurrentSpanX' and count(parameter)=0]"
			[Register ("getCurrentSpanX", "()F", "GetGetCurrentSpanXHandler")]
			get {
				const string __id = "getCurrentSpanX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentSpanY;
#pragma warning disable 0169
		static Delegate GetGetCurrentSpanYHandler ()
		{
			if (cb_getCurrentSpanY == null)
				cb_getCurrentSpanY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrentSpanY);
			return cb_getCurrentSpanY;
		}

		static float n_GetCurrentSpanY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSpanY;
		}
#pragma warning restore 0169

		public virtual unsafe float CurrentSpanY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getCurrentSpanY' and count(parameter)=0]"
			[Register ("getCurrentSpanY", "()F", "GetGetCurrentSpanYHandler")]
			get {
				const string __id = "getCurrentSpanY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isScalingOut;
#pragma warning disable 0169
		static Delegate GetIsScalingOutHandler ()
		{
			if (cb_isScalingOut == null)
				cb_isScalingOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScalingOut);
			return cb_isScalingOut;
		}

		static bool n_IsScalingOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsScalingOut;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsScalingOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='isScalingOut' and count(parameter)=0]"
			[Register ("isScalingOut", "()Z", "GetIsScalingOutHandler")]
			get {
				const string __id = "isScalingOut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPreviousSpan;
#pragma warning disable 0169
		static Delegate GetGetPreviousSpanHandler ()
		{
			if (cb_getPreviousSpan == null)
				cb_getPreviousSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPreviousSpan);
			return cb_getPreviousSpan;
		}

		static float n_GetPreviousSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousSpan;
		}
#pragma warning restore 0169

		public virtual unsafe float PreviousSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getPreviousSpan' and count(parameter)=0]"
			[Register ("getPreviousSpan", "()F", "GetGetPreviousSpanHandler")]
			get {
				const string __id = "getPreviousSpan.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPreviousSpanX;
#pragma warning disable 0169
		static Delegate GetGetPreviousSpanXHandler ()
		{
			if (cb_getPreviousSpanX == null)
				cb_getPreviousSpanX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPreviousSpanX);
			return cb_getPreviousSpanX;
		}

		static float n_GetPreviousSpanX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousSpanX;
		}
#pragma warning restore 0169

		public virtual unsafe float PreviousSpanX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getPreviousSpanX' and count(parameter)=0]"
			[Register ("getPreviousSpanX", "()F", "GetGetPreviousSpanXHandler")]
			get {
				const string __id = "getPreviousSpanX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPreviousSpanY;
#pragma warning disable 0169
		static Delegate GetGetPreviousSpanYHandler ()
		{
			if (cb_getPreviousSpanY == null)
				cb_getPreviousSpanY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPreviousSpanY);
			return cb_getPreviousSpanY;
		}

		static float n_GetPreviousSpanY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousSpanY;
		}
#pragma warning restore 0169

		public virtual unsafe float PreviousSpanY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getPreviousSpanY' and count(parameter)=0]"
			[Register ("getPreviousSpanY", "()F", "GetGetPreviousSpanYHandler")]
			get {
				const string __id = "getPreviousSpanY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScaleFactor;
#pragma warning disable 0169
		static Delegate GetGetScaleFactorHandler ()
		{
			if (cb_getScaleFactor == null)
				cb_getScaleFactor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScaleFactor);
			return cb_getScaleFactor;
		}

		static float n_GetScaleFactor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleFactor;
		}
#pragma warning restore 0169

		public virtual unsafe float ScaleFactor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getScaleFactor' and count(parameter)=0]"
			[Register ("getScaleFactor", "()F", "GetGetScaleFactorHandler")]
			get {
				const string __id = "getScaleFactor.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSpanSinceStartThreshold;
#pragma warning disable 0169
		static Delegate GetGetSpanSinceStartThresholdHandler ()
		{
			if (cb_getSpanSinceStartThreshold == null)
				cb_getSpanSinceStartThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSpanSinceStartThreshold);
			return cb_getSpanSinceStartThreshold;
		}

		static float n_GetSpanSinceStartThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpanSinceStartThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setSpanSinceStartThreshold_F;
#pragma warning disable 0169
		static Delegate GetSetSpanSinceStartThreshold_FHandler ()
		{
			if (cb_setSpanSinceStartThreshold_F == null)
				cb_setSpanSinceStartThreshold_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSpanSinceStartThreshold_F);
			return cb_setSpanSinceStartThreshold_F;
		}

		static void n_SetSpanSinceStartThreshold_F (IntPtr jnienv, IntPtr native__this, float spanSinceStartThreshold)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpanSinceStartThreshold = spanSinceStartThreshold;
		}
#pragma warning restore 0169

		public virtual unsafe float SpanSinceStartThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getSpanSinceStartThreshold' and count(parameter)=0]"
			[Register ("getSpanSinceStartThreshold", "()F", "GetGetSpanSinceStartThresholdHandler")]
			get {
				const string __id = "getSpanSinceStartThreshold.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='setSpanSinceStartThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSpanSinceStartThreshold", "(F)V", "GetSetSpanSinceStartThreshold_FHandler")]
			set {
				const string __id = "setSpanSinceStartThreshold.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStartSpan;
#pragma warning disable 0169
		static Delegate GetGetStartSpanHandler ()
		{
			if (cb_getStartSpan == null)
				cb_getStartSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStartSpan);
			return cb_getStartSpan;
		}

		static float n_GetStartSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartSpan;
		}
#pragma warning restore 0169

		public virtual unsafe float StartSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getStartSpan' and count(parameter)=0]"
			[Register ("getStartSpan", "()F", "GetGetStartSpanHandler")]
			get {
				const string __id = "getStartSpan.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStartSpanX;
#pragma warning disable 0169
		static Delegate GetGetStartSpanXHandler ()
		{
			if (cb_getStartSpanX == null)
				cb_getStartSpanX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStartSpanX);
			return cb_getStartSpanX;
		}

		static float n_GetStartSpanX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartSpanX;
		}
#pragma warning restore 0169

		public virtual unsafe float StartSpanX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getStartSpanX' and count(parameter)=0]"
			[Register ("getStartSpanX", "()F", "GetGetStartSpanXHandler")]
			get {
				const string __id = "getStartSpanX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStartSpanY;
#pragma warning disable 0169
		static Delegate GetGetStartSpanYHandler ()
		{
			if (cb_getStartSpanY == null)
				cb_getStartSpanY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStartSpanY);
			return cb_getStartSpanY;
		}

		static float n_GetStartSpanY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartSpanY;
		}
#pragma warning restore 0169

		public virtual unsafe float StartSpanY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='getStartSpanY' and count(parameter)=0]"
			[Register ("getStartSpanY", "()F", "GetGetStartSpanYHandler")]
			get {
				const string __id = "getStartSpanY.()F";
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
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ProvideHandledTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='provideHandledTypes' and count(parameter)=0]"
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

		static Delegate cb_setSpanSinceStartThresholdResource_I;
#pragma warning disable 0169
		static Delegate GetSetSpanSinceStartThresholdResource_IHandler ()
		{
			if (cb_setSpanSinceStartThresholdResource_I == null)
				cb_setSpanSinceStartThresholdResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSpanSinceStartThresholdResource_I);
			return cb_setSpanSinceStartThresholdResource_I;
		}

		static void n_SetSpanSinceStartThresholdResource_I (IntPtr jnienv, IntPtr native__this, int spanSinceStartThresholdDimen)
		{
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSpanSinceStartThresholdResource (spanSinceStartThresholdDimen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardScaleGestureDetector']/method[@name='setSpanSinceStartThresholdResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSpanSinceStartThresholdResource", "(I)V", "GetSetSpanSinceStartThresholdResource_IHandler")]
		public virtual unsafe void SetSpanSinceStartThresholdResource (int spanSinceStartThresholdDimen)
		{
			const string __id = "setSpanSinceStartThresholdResource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (spanSinceStartThresholdDimen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
