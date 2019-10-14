using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/MultiFingerGesture", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L"})]
	public abstract partial class MultiFingerGesture : global::Com.Mapbox.Android.Gestures.BaseGesture {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/MultiFingerGesture", typeof (MultiFingerGesture));
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

		protected MultiFingerGesture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/constructor[@name='MultiFingerGesture' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe MultiFingerGesture (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager gesturesManager)
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

		static Delegate cb_getFocalPoint;
#pragma warning disable 0169
		static Delegate GetGetFocalPointHandler ()
		{
			if (cb_getFocalPoint == null)
				cb_getFocalPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocalPoint);
			return cb_getFocalPoint;
		}

		static IntPtr n_GetFocalPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FocalPoint);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.PointF FocalPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getFocalPoint' and count(parameter)=0]"
			[Register ("getFocalPoint", "()Landroid/graphics/PointF;", "GetGetFocalPointHandler")]
			get {
				const string __id = "getFocalPoint.()Landroid/graphics/PointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isSloppyGesture;
#pragma warning disable 0169
		static Delegate GetIsSloppyGestureHandler ()
		{
			if (cb_isSloppyGesture == null)
				cb_isSloppyGesture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSloppyGesture);
			return cb_isSloppyGesture;
		}

		static bool n_IsSloppyGesture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSloppyGesture;
		}
#pragma warning restore 0169

		protected virtual unsafe bool IsSloppyGesture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='isSloppyGesture' and count(parameter)=0]"
			[Register ("isSloppyGesture", "()Z", "GetIsSloppyGestureHandler")]
			get {
				const string __id = "isSloppyGesture.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPointersCount;
#pragma warning disable 0169
		static Delegate GetGetPointersCountHandler ()
		{
			if (cb_getPointersCount == null)
				cb_getPointersCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPointersCount);
			return cb_getPointersCount;
		}

		static int n_GetPointersCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PointersCount;
		}
#pragma warning restore 0169

		public virtual unsafe int PointersCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getPointersCount' and count(parameter)=0]"
			[Register ("getPointersCount", "()I", "GetGetPointersCountHandler")]
			get {
				const string __id = "getPointersCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequiredPointersCount;
#pragma warning disable 0169
		static Delegate GetGetRequiredPointersCountHandler ()
		{
			if (cb_getRequiredPointersCount == null)
				cb_getRequiredPointersCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRequiredPointersCount);
			return cb_getRequiredPointersCount;
		}

		static int n_GetRequiredPointersCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiredPointersCount;
		}
#pragma warning restore 0169

		protected virtual unsafe int RequiredPointersCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getRequiredPointersCount' and count(parameter)=0]"
			[Register ("getRequiredPointersCount", "()I", "GetGetRequiredPointersCountHandler")]
			get {
				const string __id = "getRequiredPointersCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSpanThreshold;
#pragma warning disable 0169
		static Delegate GetGetSpanThresholdHandler ()
		{
			if (cb_getSpanThreshold == null)
				cb_getSpanThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSpanThreshold);
			return cb_getSpanThreshold;
		}

		static float n_GetSpanThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpanThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setSpanThreshold_F;
#pragma warning disable 0169
		static Delegate GetSetSpanThreshold_FHandler ()
		{
			if (cb_setSpanThreshold_F == null)
				cb_setSpanThreshold_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSpanThreshold_F);
			return cb_setSpanThreshold_F;
		}

		static void n_SetSpanThreshold_F (IntPtr jnienv, IntPtr native__this, float spanThreshold)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpanThreshold = spanThreshold;
		}
#pragma warning restore 0169

		public virtual unsafe float SpanThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getSpanThreshold' and count(parameter)=0]"
			[Register ("getSpanThreshold", "()F", "GetGetSpanThresholdHandler")]
			get {
				const string __id = "getSpanThreshold.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='setSpanThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSpanThreshold", "(F)V", "GetSetSpanThreshold_FHandler")]
			set {
				const string __id = "setSpanThreshold.(F)V";
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
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent motionEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_motionEvent, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AnalyzeEvent (motionEvent);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='analyzeEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
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

		static Delegate cb_analyzeMovement;
#pragma warning disable 0169
		static Delegate GetAnalyzeMovementHandler ()
		{
			if (cb_analyzeMovement == null)
				cb_analyzeMovement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AnalyzeMovement);
			return cb_analyzeMovement;
		}

		static bool n_AnalyzeMovement (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnalyzeMovement ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='analyzeMovement' and count(parameter)=0]"
		[Register ("analyzeMovement", "()Z", "GetAnalyzeMovementHandler")]
		protected virtual unsafe bool AnalyzeMovement ()
		{
			const string __id = "analyzeMovement.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getCurrentSpan_II;
#pragma warning disable 0169
		static Delegate GetGetCurrentSpan_IIHandler ()
		{
			if (cb_getCurrentSpan_II == null)
				cb_getCurrentSpan_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetCurrentSpan_II);
			return cb_getCurrentSpan_II;
		}

		static float n_GetCurrentSpan_II (IntPtr jnienv, IntPtr native__this, int firstPointerIndex, int secondPointerIndex)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCurrentSpan (firstPointerIndex, secondPointerIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getCurrentSpan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getCurrentSpan", "(II)F", "GetGetCurrentSpan_IIHandler")]
		public virtual unsafe float GetCurrentSpan (int firstPointerIndex, int secondPointerIndex)
		{
			const string __id = "getCurrentSpan.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (firstPointerIndex);
				__args [1] = new JniArgumentValue (secondPointerIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getCurrentSpanX_II;
#pragma warning disable 0169
		static Delegate GetGetCurrentSpanX_IIHandler ()
		{
			if (cb_getCurrentSpanX_II == null)
				cb_getCurrentSpanX_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetCurrentSpanX_II);
			return cb_getCurrentSpanX_II;
		}

		static float n_GetCurrentSpanX_II (IntPtr jnienv, IntPtr native__this, int firstPointerIndex, int secondPointerIndex)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCurrentSpanX (firstPointerIndex, secondPointerIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getCurrentSpanX' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getCurrentSpanX", "(II)F", "GetGetCurrentSpanX_IIHandler")]
		public virtual unsafe float GetCurrentSpanX (int firstPointerIndex, int secondPointerIndex)
		{
			const string __id = "getCurrentSpanX.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (firstPointerIndex);
				__args [1] = new JniArgumentValue (secondPointerIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getCurrentSpanY_II;
#pragma warning disable 0169
		static Delegate GetGetCurrentSpanY_IIHandler ()
		{
			if (cb_getCurrentSpanY_II == null)
				cb_getCurrentSpanY_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetCurrentSpanY_II);
			return cb_getCurrentSpanY_II;
		}

		static float n_GetCurrentSpanY_II (IntPtr jnienv, IntPtr native__this, int firstPointerIndex, int secondPointerIndex)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCurrentSpanY (firstPointerIndex, secondPointerIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getCurrentSpanY' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getCurrentSpanY", "(II)F", "GetGetCurrentSpanY_IIHandler")]
		public virtual unsafe float GetCurrentSpanY (int firstPointerIndex, int secondPointerIndex)
		{
			const string __id = "getCurrentSpanY.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (firstPointerIndex);
				__args [1] = new JniArgumentValue (secondPointerIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPreviousSpan_II;
#pragma warning disable 0169
		static Delegate GetGetPreviousSpan_IIHandler ()
		{
			if (cb_getPreviousSpan_II == null)
				cb_getPreviousSpan_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPreviousSpan_II);
			return cb_getPreviousSpan_II;
		}

		static float n_GetPreviousSpan_II (IntPtr jnienv, IntPtr native__this, int firstPointerIndex, int secondPointerIndex)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPreviousSpan (firstPointerIndex, secondPointerIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getPreviousSpan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPreviousSpan", "(II)F", "GetGetPreviousSpan_IIHandler")]
		public virtual unsafe float GetPreviousSpan (int firstPointerIndex, int secondPointerIndex)
		{
			const string __id = "getPreviousSpan.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (firstPointerIndex);
				__args [1] = new JniArgumentValue (secondPointerIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPreviousSpanX_II;
#pragma warning disable 0169
		static Delegate GetGetPreviousSpanX_IIHandler ()
		{
			if (cb_getPreviousSpanX_II == null)
				cb_getPreviousSpanX_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPreviousSpanX_II);
			return cb_getPreviousSpanX_II;
		}

		static float n_GetPreviousSpanX_II (IntPtr jnienv, IntPtr native__this, int firstPointerIndex, int secondPointerIndex)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPreviousSpanX (firstPointerIndex, secondPointerIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getPreviousSpanX' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPreviousSpanX", "(II)F", "GetGetPreviousSpanX_IIHandler")]
		public virtual unsafe float GetPreviousSpanX (int firstPointerIndex, int secondPointerIndex)
		{
			const string __id = "getPreviousSpanX.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (firstPointerIndex);
				__args [1] = new JniArgumentValue (secondPointerIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPreviousSpanY_II;
#pragma warning disable 0169
		static Delegate GetGetPreviousSpanY_IIHandler ()
		{
			if (cb_getPreviousSpanY_II == null)
				cb_getPreviousSpanY_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPreviousSpanY_II);
			return cb_getPreviousSpanY_II;
		}

		static float n_GetPreviousSpanY_II (IntPtr jnienv, IntPtr native__this, int firstPointerIndex, int secondPointerIndex)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPreviousSpanY (firstPointerIndex, secondPointerIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='getPreviousSpanY' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPreviousSpanY", "(II)F", "GetGetPreviousSpanY_IIHandler")]
		public virtual unsafe float GetPreviousSpanY (int firstPointerIndex, int secondPointerIndex)
		{
			const string __id = "getPreviousSpanY.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (firstPointerIndex);
				__args [1] = new JniArgumentValue (secondPointerIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		protected virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setSpanThresholdResource_I;
#pragma warning disable 0169
		static Delegate GetSetSpanThresholdResource_IHandler ()
		{
			if (cb_setSpanThresholdResource_I == null)
				cb_setSpanThresholdResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSpanThresholdResource_I);
			return cb_setSpanThresholdResource_I;
		}

		static void n_SetSpanThresholdResource_I (IntPtr jnienv, IntPtr native__this, int spanThresholdDimen)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSpanThresholdResource (spanThresholdDimen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerGesture']/method[@name='setSpanThresholdResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSpanThresholdResource", "(I)V", "GetSetSpanThresholdResource_IHandler")]
		public virtual unsafe void SetSpanThresholdResource (int spanThresholdDimen)
		{
			const string __id = "setSpanThresholdResource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (spanThresholdDimen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/android/gestures/MultiFingerGesture", DoNotGenerateAcw=true)]
	internal partial class MultiFingerGestureInvoker : MultiFingerGesture {

		public MultiFingerGestureInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/MultiFingerGesture", typeof (MultiFingerGestureInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
