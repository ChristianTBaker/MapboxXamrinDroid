using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/BaseGesture", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L"})]
	public abstract partial class BaseGesture : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				const string __id = "context.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "context.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/field[@name='listener']"
		[Register ("listener")]
		protected global::Java.Lang.Object Listener {
			get {
				const string __id = "listener.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "listener.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/field[@name='windowManager']"
		[Register ("windowManager")]
		protected global::Android.Views.IWindowManager WindowManager {
			get {
				const string __id = "windowManager.Landroid/view/WindowManager;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.IWindowManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "windowManager.Landroid/view/WindowManager;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/BaseGesture", typeof (BaseGesture));
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

		protected BaseGesture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/constructor[@name='BaseGesture' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe BaseGesture (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager gesturesManager)
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

		static Delegate cb_getCurrentEvent;
#pragma warning disable 0169
		static Delegate GetGetCurrentEventHandler ()
		{
			if (cb_getCurrentEvent == null)
				cb_getCurrentEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentEvent);
			return cb_getCurrentEvent;
		}

		static IntPtr n_GetCurrentEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentEvent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.MotionEvent CurrentEvent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='getCurrentEvent' and count(parameter)=0]"
			[Register ("getCurrentEvent", "()Landroid/view/MotionEvent;", "GetGetCurrentEventHandler")]
			get {
				const string __id = "getCurrentEvent.()Landroid/view/MotionEvent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled;
		}
#pragma warning restore 0169

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				const string __id = "isEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
			set {
				const string __id = "setEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGestureDuration;
#pragma warning disable 0169
		static Delegate GetGetGestureDurationHandler ()
		{
			if (cb_getGestureDuration == null)
				cb_getGestureDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetGestureDuration);
			return cb_getGestureDuration;
		}

		static long n_GetGestureDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GestureDuration;
		}
#pragma warning restore 0169

		public virtual unsafe long GestureDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='getGestureDuration' and count(parameter)=0]"
			[Register ("getGestureDuration", "()J", "GetGetGestureDurationHandler")]
			get {
				const string __id = "getGestureDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPreviousEvent;
#pragma warning disable 0169
		static Delegate GetGetPreviousEventHandler ()
		{
			if (cb_getPreviousEvent == null)
				cb_getPreviousEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreviousEvent);
			return cb_getPreviousEvent;
		}

		static IntPtr n_GetPreviousEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreviousEvent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.MotionEvent PreviousEvent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='getPreviousEvent' and count(parameter)=0]"
			[Register ("getPreviousEvent", "()Landroid/view/MotionEvent;", "GetGetPreviousEventHandler")]
			get {
				const string __id = "getPreviousEvent.()Landroid/view/MotionEvent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		static bool n_AnalyzeEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AnalyzeEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='analyzeEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("analyzeEvent", "(Landroid/view/MotionEvent;)Z", "GetAnalyzeEvent_Landroid_view_MotionEvent_Handler")]
		protected abstract bool AnalyzeEvent (global::Android.Views.MotionEvent p0);

		static Delegate cb_canExecute_I;
#pragma warning disable 0169
		static Delegate GetCanExecute_IHandler ()
		{
			if (cb_canExecute_I == null)
				cb_canExecute_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_CanExecute_I);
			return cb_canExecute_I;
		}

		static bool n_CanExecute_I (IntPtr jnienv, IntPtr native__this, int invokedGestureType)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanExecute (invokedGestureType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='canExecute' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("canExecute", "(I)Z", "GetCanExecute_IHandler")]
		protected virtual unsafe bool CanExecute ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Android.Gestures.AndroidGesturesManager", Fields = new string [] {"GestureTypeScroll", "GestureTypeScale", "GestureTypeRotate", "GestureTypeShove", "GestureTypeMultiFingerTap", "GestureTypeSingleTapUp", "GestureTypeLongPress", "GestureTypeFling", "GestureTypeShowPress", "GestureTypeDown", "GestureTypeDoubleTap", "GestureTypeDoubleTapEvent", "GestureTypeSingleTapConfirmed", "GestureTypeMove", "GestureTypeSidewaysShove", "GestureTypeQuickScale"})]int invokedGestureType)
		{
			const string __id = "canExecute.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (invokedGestureType);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_motionEvent)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent motionEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_motionEvent, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (motionEvent);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		protected virtual unsafe bool OnTouchEvent (global::Android.Views.MotionEvent motionEvent)
		{
			const string __id = "onTouchEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((motionEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) motionEvent).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeListener;
#pragma warning disable 0169
		static Delegate GetRemoveListenerHandler ()
		{
			if (cb_removeListener == null)
				cb_removeListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveListener);
			return cb_removeListener;
		}

		static void n_RemoveListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='removeListener' and count(parameter)=0]"
		[Register ("removeListener", "()V", "GetRemoveListenerHandler")]
		protected virtual unsafe void RemoveListener ()
		{
			const string __id = "removeListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetListener_Ljava_lang_Object_Handler ()
		{
			if (cb_setListener_Ljava_lang_Object_ == null)
				cb_setListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Ljava_lang_Object_);
			return cb_setListener_Ljava_lang_Object_;
		}

		static void n_SetListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Gestures.BaseGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.BaseGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='L']]"
		[Register ("setListener", "(Ljava/lang/Object;)V", "GetSetListener_Ljava_lang_Object_Handler")]
		protected virtual unsafe void SetListener (global::Java.Lang.Object listener)
		{
			const string __id = "setListener.(Ljava/lang/Object;)V";
			IntPtr native_listener = JNIEnv.ToLocalJniHandle (listener);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_listener);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_listener);
			}
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/android/gestures/BaseGesture", DoNotGenerateAcw=true)]
	internal partial class BaseGestureInvoker : BaseGesture {

		public BaseGestureInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/BaseGesture", typeof (BaseGestureInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='BaseGesture']/method[@name='analyzeEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("analyzeEvent", "(Landroid/view/MotionEvent;)Z", "GetAnalyzeEvent_Landroid_view_MotionEvent_Handler")]
		protected override unsafe bool AnalyzeEvent (global::Android.Views.MotionEvent p0)
		{
			const string __id = "analyzeEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

}
