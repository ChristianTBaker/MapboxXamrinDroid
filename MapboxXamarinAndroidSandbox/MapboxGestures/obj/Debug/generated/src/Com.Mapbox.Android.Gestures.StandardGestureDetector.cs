using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/StandardGestureDetector", DoNotGenerateAcw=true)]
	public partial class StandardGestureDetector : global::Com.Mapbox.Android.Gestures.BaseGesture {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']"
		[global::Android.Runtime.Register ("com/mapbox/android/gestures/StandardGestureDetector$SimpleStandardOnGestureListener", DoNotGenerateAcw=true)]
		public partial class SimpleStandardOnGestureListener : global::Java.Lang.Object, global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/StandardGestureDetector$SimpleStandardOnGestureListener", typeof (SimpleStandardOnGestureListener));
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

			protected SimpleStandardOnGestureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/constructor[@name='StandardGestureDetector.SimpleStandardOnGestureListener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SimpleStandardOnGestureListener ()
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

			static Delegate cb_onDoubleTap_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnDoubleTap_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onDoubleTap_Landroid_view_MotionEvent_ == null)
					cb_onDoubleTap_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTap_Landroid_view_MotionEvent_);
				return cb_onDoubleTap_Landroid_view_MotionEvent_;
			}

			static bool n_OnDoubleTap_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnDoubleTap (e);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/method[@name='onDoubleTap' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onDoubleTap", "(Landroid/view/MotionEvent;)Z", "GetOnDoubleTap_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnDoubleTap (global::Android.Views.MotionEvent e)
			{
				const string __id = "onDoubleTap.(Landroid/view/MotionEvent;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onDoubleTapEvent_Landroid_view_MotionEvent_ == null)
					cb_onDoubleTapEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTapEvent_Landroid_view_MotionEvent_);
				return cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
			}

			static bool n_OnDoubleTapEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnDoubleTapEvent (e);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/method[@name='onDoubleTapEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", "GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnDoubleTapEvent (global::Android.Views.MotionEvent e)
			{
				const string __id = "onDoubleTapEvent.(Landroid/view/MotionEvent;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onDown_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnDown_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onDown_Landroid_view_MotionEvent_ == null)
					cb_onDown_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDown_Landroid_view_MotionEvent_);
				return cb_onDown_Landroid_view_MotionEvent_;
			}

			static bool n_OnDown_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnDown (e);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/method[@name='onDown' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onDown", "(Landroid/view/MotionEvent;)Z", "GetOnDown_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnDown (global::Android.Views.MotionEvent e)
			{
				const string __id = "onDown.(Landroid/view/MotionEvent;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
			static Delegate GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
			{
				if (cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
					cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
				return cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			}

			static bool n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_e1, IntPtr native_e2, float velocityX, float velocityY)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e1, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e2 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnFling (e1, e2, velocityX, velocityY);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/method[@name='onFling' and count(parameter)=4 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", "GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler")]
			public virtual unsafe bool OnFling (global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float velocityX, float velocityY)
			{
				const string __id = "onFling.(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((e1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e1).Handle);
					__args [1] = new JniArgumentValue ((e2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e2).Handle);
					__args [2] = new JniArgumentValue (velocityX);
					__args [3] = new JniArgumentValue (velocityY);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onLongPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnLongPress_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onLongPress_Landroid_view_MotionEvent_ == null)
					cb_onLongPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLongPress_Landroid_view_MotionEvent_);
				return cb_onLongPress_Landroid_view_MotionEvent_;
			}

			static void n_OnLongPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				__this.OnLongPress (e);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/method[@name='onLongPress' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onLongPress", "(Landroid/view/MotionEvent;)V", "GetOnLongPress_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe void OnLongPress (global::Android.Views.MotionEvent e)
			{
				const string __id = "onLongPress.(Landroid/view/MotionEvent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
			static Delegate GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
			{
				if (cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
					cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
				return cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			}

			static bool n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_e1, IntPtr native_e2, float distanceX, float distanceY)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e1, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e2 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnScroll (e1, e2, distanceX, distanceY);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", "GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler")]
			public virtual unsafe bool OnScroll (global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float distanceX, float distanceY)
			{
				const string __id = "onScroll.(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((e1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e1).Handle);
					__args [1] = new JniArgumentValue ((e2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e2).Handle);
					__args [2] = new JniArgumentValue (distanceX);
					__args [3] = new JniArgumentValue (distanceY);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onShowPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnShowPress_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onShowPress_Landroid_view_MotionEvent_ == null)
					cb_onShowPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnShowPress_Landroid_view_MotionEvent_);
				return cb_onShowPress_Landroid_view_MotionEvent_;
			}

			static void n_OnShowPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				__this.OnShowPress (e);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/method[@name='onShowPress' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onShowPress", "(Landroid/view/MotionEvent;)V", "GetOnShowPress_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe void OnShowPress (global::Android.Views.MotionEvent e)
			{
				const string __id = "onShowPress.(Landroid/view/MotionEvent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ == null)
					cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapConfirmed_Landroid_view_MotionEvent_);
				return cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
			}

			static bool n_OnSingleTapConfirmed_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSingleTapConfirmed (e);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/method[@name='onSingleTapConfirmed' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", "GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnSingleTapConfirmed (global::Android.Views.MotionEvent e)
			{
				const string __id = "onSingleTapConfirmed.(Landroid/view/MotionEvent;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onSingleTapUp_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnSingleTapUp_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onSingleTapUp_Landroid_view_MotionEvent_ == null)
					cb_onSingleTapUp_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapUp_Landroid_view_MotionEvent_);
				return cb_onSingleTapUp_Landroid_view_MotionEvent_;
			}

			static bool n_OnSingleTapUp_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.SimpleStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSingleTapUp (e);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector.SimpleStandardOnGestureListener']/method[@name='onSingleTapUp' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", "GetOnSingleTapUp_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnSingleTapUp (global::Android.Views.MotionEvent e)
			{
				const string __id = "onSingleTapUp.(Landroid/view/MotionEvent;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='StandardGestureDetector.StandardOnGestureListener']"
		[Register ("com/mapbox/android/gestures/StandardGestureDetector$StandardOnGestureListener", "", "Com.Mapbox.Android.Gestures.StandardGestureDetector/IStandardOnGestureListenerInvoker")]
		public partial interface IStandardOnGestureListener : global::Android.Views.GestureDetector.IOnDoubleTapListener, global::Android.Views.GestureDetector.IOnGestureListener {

		}

		[global::Android.Runtime.Register ("com/mapbox/android/gestures/StandardGestureDetector$StandardOnGestureListener", DoNotGenerateAcw=true)]
		internal class IStandardOnGestureListenerInvoker : global::Java.Lang.Object, IStandardOnGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/StandardGestureDetector$StandardOnGestureListener", typeof (IStandardOnGestureListenerInvoker));

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

			public static IStandardOnGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStandardOnGestureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.gestures.StandardGestureDetector.StandardOnGestureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStandardOnGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDoubleTap_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnDoubleTap_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onDoubleTap_Landroid_view_MotionEvent_ == null)
					cb_onDoubleTap_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTap_Landroid_view_MotionEvent_);
				return cb_onDoubleTap_Landroid_view_MotionEvent_;
			}

			static bool n_OnDoubleTap_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnDoubleTap (e);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onDoubleTap_Landroid_view_MotionEvent_;
			public unsafe global::System.Boolean OnDoubleTap (global::Android.Views.MotionEvent e)
			{
				if (id_onDoubleTap_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onDoubleTap_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onDoubleTap_Landroid_view_MotionEvent_, __args);
				return __ret;
			}

			static Delegate cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onDoubleTapEvent_Landroid_view_MotionEvent_ == null)
					cb_onDoubleTapEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTapEvent_Landroid_view_MotionEvent_);
				return cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
			}

			static bool n_OnDoubleTapEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnDoubleTapEvent (e);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onDoubleTapEvent_Landroid_view_MotionEvent_;
			public unsafe global::System.Boolean OnDoubleTapEvent (global::Android.Views.MotionEvent e)
			{
				if (id_onDoubleTapEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onDoubleTapEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onDoubleTapEvent_Landroid_view_MotionEvent_, __args);
				return __ret;
			}

			static Delegate cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ == null)
					cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapConfirmed_Landroid_view_MotionEvent_);
				return cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
			}

			static bool n_OnSingleTapConfirmed_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSingleTapConfirmed (e);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onSingleTapConfirmed_Landroid_view_MotionEvent_;
			public unsafe global::System.Boolean OnSingleTapConfirmed (global::Android.Views.MotionEvent e)
			{
				if (id_onSingleTapConfirmed_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onSingleTapConfirmed_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSingleTapConfirmed_Landroid_view_MotionEvent_, __args);
				return __ret;
			}

			static Delegate cb_onDown_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnDown_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onDown_Landroid_view_MotionEvent_ == null)
					cb_onDown_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDown_Landroid_view_MotionEvent_);
				return cb_onDown_Landroid_view_MotionEvent_;
			}

			static bool n_OnDown_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnDown (e);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onDown_Landroid_view_MotionEvent_;
			public unsafe global::System.Boolean OnDown (global::Android.Views.MotionEvent e)
			{
				if (id_onDown_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onDown_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDown", "(Landroid/view/MotionEvent;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onDown_Landroid_view_MotionEvent_, __args);
				return __ret;
			}

			static Delegate cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
			static Delegate GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
			{
				if (cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
					cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
				return cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			}

			static bool n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_e1, IntPtr native_e2, float velocityX, float velocityY)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e1, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e2 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnFling (e1, e2, velocityX, velocityY);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			public unsafe global::System.Boolean OnFling (global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float velocityX, float velocityY)
			{
				if (id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == IntPtr.Zero)
					id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue ((e1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e1).Handle);
				__args [1] = new JValue ((e2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e2).Handle);
				__args [2] = new JValue (velocityX);
				__args [3] = new JValue (velocityY);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF, __args);
				return __ret;
			}

			static Delegate cb_onLongPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnLongPress_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onLongPress_Landroid_view_MotionEvent_ == null)
					cb_onLongPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLongPress_Landroid_view_MotionEvent_);
				return cb_onLongPress_Landroid_view_MotionEvent_;
			}

			static void n_OnLongPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				__this.OnLongPress (e);
			}
#pragma warning restore 0169

			IntPtr id_onLongPress_Landroid_view_MotionEvent_;
			public unsafe void OnLongPress (global::Android.Views.MotionEvent e)
			{
				if (id_onLongPress_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onLongPress_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onLongPress", "(Landroid/view/MotionEvent;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLongPress_Landroid_view_MotionEvent_, __args);
			}

			static Delegate cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
			static Delegate GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
			{
				if (cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
					cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
				return cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			}

			static bool n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_e1, IntPtr native_e2, float distanceX, float distanceY)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e1, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e2 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnScroll (e1, e2, distanceX, distanceY);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			public unsafe global::System.Boolean OnScroll (global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float distanceX, float distanceY)
			{
				if (id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == IntPtr.Zero)
					id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue ((e1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e1).Handle);
				__args [1] = new JValue ((e2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e2).Handle);
				__args [2] = new JValue (distanceX);
				__args [3] = new JValue (distanceY);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF, __args);
				return __ret;
			}

			static Delegate cb_onShowPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnShowPress_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onShowPress_Landroid_view_MotionEvent_ == null)
					cb_onShowPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnShowPress_Landroid_view_MotionEvent_);
				return cb_onShowPress_Landroid_view_MotionEvent_;
			}

			static void n_OnShowPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				__this.OnShowPress (e);
			}
#pragma warning restore 0169

			IntPtr id_onShowPress_Landroid_view_MotionEvent_;
			public unsafe void OnShowPress (global::Android.Views.MotionEvent e)
			{
				if (id_onShowPress_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onShowPress_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onShowPress", "(Landroid/view/MotionEvent;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShowPress_Landroid_view_MotionEvent_, __args);
			}

			static Delegate cb_onSingleTapUp_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnSingleTapUp_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onSingleTapUp_Landroid_view_MotionEvent_ == null)
					cb_onSingleTapUp_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapUp_Landroid_view_MotionEvent_);
				return cb_onSingleTapUp_Landroid_view_MotionEvent_;
			}

			static bool n_OnSingleTapUp_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSingleTapUp (e);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onSingleTapUp_Landroid_view_MotionEvent_;
			public unsafe global::System.Boolean OnSingleTapUp (global::Android.Views.MotionEvent e)
			{
				if (id_onSingleTapUp_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onSingleTapUp_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSingleTapUp_Landroid_view_MotionEvent_, __args);
				return __ret;
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/StandardGestureDetector", typeof (StandardGestureDetector));
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

		protected StandardGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector']/constructor[@name='StandardGestureDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe StandardGestureDetector (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager androidGesturesManager)
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

		static Delegate cb_isLongpressEnabled;
#pragma warning disable 0169
		static Delegate GetIsLongpressEnabledHandler ()
		{
			if (cb_isLongpressEnabled == null)
				cb_isLongpressEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLongpressEnabled);
			return cb_isLongpressEnabled;
		}

		static bool n_IsLongpressEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.StandardGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLongpressEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setIsLongpressEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetIsLongpressEnabled_ZHandler ()
		{
			if (cb_setIsLongpressEnabled_Z == null)
				cb_setIsLongpressEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsLongpressEnabled_Z);
			return cb_setIsLongpressEnabled_Z;
		}

		static void n_SetIsLongpressEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Android.Gestures.StandardGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsLongpressEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLongpressEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector']/method[@name='isLongpressEnabled' and count(parameter)=0]"
			[Register ("isLongpressEnabled", "()Z", "GetIsLongpressEnabledHandler")]
			get {
				const string __id = "isLongpressEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector']/method[@name='setIsLongpressEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsLongpressEnabled", "(Z)V", "GetSetIsLongpressEnabled_ZHandler")]
			set {
				const string __id = "setIsLongpressEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_analyzeEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetAnalyzeEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_analyzeEvent_Landroid_view_MotionEvent_ == null)
				cb_analyzeEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AnalyzeEvent_Landroid_view_MotionEvent_);
			return cb_analyzeEvent_Landroid_view_MotionEvent_;
		}

		static bool n_AnalyzeEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_motionEvent)
		{
			global::Com.Mapbox.Android.Gestures.StandardGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent motionEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_motionEvent, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AnalyzeEvent (motionEvent);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='StandardGestureDetector']/method[@name='analyzeEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("analyzeEvent", "(Landroid/view/MotionEvent;)Z", "GetAnalyzeEvent_Landroid_view_MotionEvent_Handler")]
		protected override unsafe bool AnalyzeEvent (global::Android.Views.MotionEvent motionEvent)
		{
			const string __id = "analyzeEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((motionEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) motionEvent).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
