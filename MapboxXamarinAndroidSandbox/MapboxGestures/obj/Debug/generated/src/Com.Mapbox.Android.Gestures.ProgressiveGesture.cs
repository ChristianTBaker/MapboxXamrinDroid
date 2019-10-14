using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ProgressiveGesture']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/ProgressiveGesture", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L"})]
	public abstract partial class ProgressiveGesture : global::Com.Mapbox.Android.Gestures.MultiFingerGesture {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/ProgressiveGesture", typeof (ProgressiveGesture));
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

		protected ProgressiveGesture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ProgressiveGesture']/constructor[@name='ProgressiveGesture' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe ProgressiveGesture (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager gesturesManager)
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

		static Delegate cb_isInProgress;
#pragma warning disable 0169
		static Delegate GetIsInProgressHandler ()
		{
			if (cb_isInProgress == null)
				cb_isInProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInProgress);
			return cb_isInProgress;
		}

		static bool n_IsInProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.ProgressiveGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ProgressiveGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInProgress;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ProgressiveGesture']/method[@name='isInProgress' and count(parameter)=0]"
			[Register ("isInProgress", "()Z", "GetIsInProgressHandler")]
			get {
				const string __id = "isInProgress.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_gestureStarted;
#pragma warning disable 0169
		static Delegate GetGestureStartedHandler ()
		{
			if (cb_gestureStarted == null)
				cb_gestureStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GestureStarted);
			return cb_gestureStarted;
		}

		static void n_GestureStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.ProgressiveGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ProgressiveGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GestureStarted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ProgressiveGesture']/method[@name='gestureStarted' and count(parameter)=0]"
		[Register ("gestureStarted", "()V", "GetGestureStartedHandler")]
		protected virtual unsafe void GestureStarted ()
		{
			const string __id = "gestureStarted.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_gestureStopped;
#pragma warning disable 0169
		static Delegate GetGestureStoppedHandler ()
		{
			if (cb_gestureStopped == null)
				cb_gestureStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GestureStopped);
			return cb_gestureStopped;
		}

		static void n_GestureStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.ProgressiveGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ProgressiveGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GestureStopped ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ProgressiveGesture']/method[@name='gestureStopped' and count(parameter)=0]"
		[Register ("gestureStopped", "()V", "GetGestureStoppedHandler")]
		protected virtual unsafe void GestureStopped ()
		{
			const string __id = "gestureStopped.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_interrupt;
#pragma warning disable 0169
		static Delegate GetInterruptHandler ()
		{
			if (cb_interrupt == null)
				cb_interrupt = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Interrupt);
			return cb_interrupt;
		}

		static void n_Interrupt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.ProgressiveGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ProgressiveGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Interrupt ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ProgressiveGesture']/method[@name='interrupt' and count(parameter)=0]"
		[Register ("interrupt", "()V", "GetInterruptHandler")]
		public virtual unsafe void Interrupt ()
		{
			const string __id = "interrupt.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Mapbox.Android.Gestures.ProgressiveGesture __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ProgressiveGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ProvideHandledTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ProgressiveGesture']/method[@name='provideHandledTypes' and count(parameter)=0]"
		[Register ("provideHandledTypes", "()Ljava/util/Set;", "GetProvideHandledTypesHandler")]
		protected abstract global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> ProvideHandledTypes ();

	}

	[global::Android.Runtime.Register ("com/mapbox/android/gestures/ProgressiveGesture", DoNotGenerateAcw=true)]
	internal partial class ProgressiveGestureInvoker : ProgressiveGesture {

		public ProgressiveGestureInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/ProgressiveGesture", typeof (ProgressiveGestureInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='ProgressiveGesture']/method[@name='provideHandledTypes' and count(parameter)=0]"
		[Register ("provideHandledTypes", "()Ljava/util/Set;", "GetProvideHandledTypesHandler")]
		protected override unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> ProvideHandledTypes ()
		{
			const string __id = "provideHandledTypes.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
