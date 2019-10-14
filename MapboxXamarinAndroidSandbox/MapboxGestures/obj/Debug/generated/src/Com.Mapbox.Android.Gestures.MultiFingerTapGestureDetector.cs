using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerTapGestureDetector']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/MultiFingerTapGestureDetector", DoNotGenerateAcw=true)]
	public partial class MultiFingerTapGestureDetector : global::Com.Mapbox.Android.Gestures.MultiFingerGesture {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='MultiFingerTapGestureDetector.OnMultiFingerTapGestureListener']"
		[Register ("com/mapbox/android/gestures/MultiFingerTapGestureDetector$OnMultiFingerTapGestureListener", "", "Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector/IOnMultiFingerTapGestureListenerInvoker")]
		public partial interface IOnMultiFingerTapGestureListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='MultiFingerTapGestureDetector.OnMultiFingerTapGestureListener']/method[@name='onMultiFingerTap' and count(parameter)=2 and parameter[1][@type='com.mapbox.android.gestures.MultiFingerTapGestureDetector'] and parameter[2][@type='int']]"
			[Register ("onMultiFingerTap", "(Lcom/mapbox/android/gestures/MultiFingerTapGestureDetector;I)Z", "GetOnMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_IHandler:Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector/IOnMultiFingerTapGestureListenerInvoker, MapboxGestures")]
			bool OnMultiFingerTap (global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector p0, int p1);

		}

		[global::Android.Runtime.Register ("com/mapbox/android/gestures/MultiFingerTapGestureDetector$OnMultiFingerTapGestureListener", DoNotGenerateAcw=true)]
		internal class IOnMultiFingerTapGestureListenerInvoker : global::Java.Lang.Object, IOnMultiFingerTapGestureListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/MultiFingerTapGestureDetector$OnMultiFingerTapGestureListener", typeof (IOnMultiFingerTapGestureListenerInvoker));

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

			public static IOnMultiFingerTapGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMultiFingerTapGestureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.gestures.MultiFingerTapGestureDetector.OnMultiFingerTapGestureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMultiFingerTapGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I;
#pragma warning disable 0169
			static Delegate GetOnMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_IHandler ()
			{
				if (cb_onMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I == null)
					cb_onMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_OnMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I);
				return cb_onMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I;
			}

			static bool n_OnMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMultiFingerTap (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I;
			public unsafe bool OnMultiFingerTap (global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector p0, int p1)
			{
				if (id_onMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I == IntPtr.Zero)
					id_onMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I = JNIEnv.GetMethodID (class_ref, "onMultiFingerTap", "(Lcom/mapbox/android/gestures/MultiFingerTapGestureDetector;I)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_I, __args);
				return __ret;
			}

		}

		// event args for com.mapbox.android.gestures.MultiFingerTapGestureDetector.OnMultiFingerTapGestureListener.onMultiFingerTap
		public partial class MultiFingerTapGestureEventArgs : global::System.EventArgs {

			public MultiFingerTapGestureEventArgs (bool handled, global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector p0, int p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector p0;
			public global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mapbox/android/gestures/MultiFingerTapGestureDetector_OnMultiFingerTapGestureListenerImplementor")]
		internal sealed partial class IOnMultiFingerTapGestureListenerImplementor : global::Java.Lang.Object, IOnMultiFingerTapGestureListener {

			object sender;

			public IOnMultiFingerTapGestureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/android/gestures/MultiFingerTapGestureDetector_OnMultiFingerTapGestureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MultiFingerTapGestureEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMultiFingerTap (global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector p0, int p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MultiFingerTapGestureEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMultiFingerTapGestureListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/MultiFingerTapGestureDetector", typeof (MultiFingerTapGestureDetector));
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

		protected MultiFingerTapGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerTapGestureDetector']/constructor[@name='MultiFingerTapGestureDetector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.android.gestures.AndroidGesturesManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mapbox/android/gestures/AndroidGesturesManager;)V", "")]
		public unsafe MultiFingerTapGestureDetector (global::Android.Content.Context context, global::Com.Mapbox.Android.Gestures.AndroidGesturesManager gesturesManager)
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

		static Delegate cb_getMultiFingerTapMovementThreshold;
#pragma warning disable 0169
		static Delegate GetGetMultiFingerTapMovementThresholdHandler ()
		{
			if (cb_getMultiFingerTapMovementThreshold == null)
				cb_getMultiFingerTapMovementThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMultiFingerTapMovementThreshold);
			return cb_getMultiFingerTapMovementThreshold;
		}

		static float n_GetMultiFingerTapMovementThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MultiFingerTapMovementThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setMultiFingerTapMovementThreshold_F;
#pragma warning disable 0169
		static Delegate GetSetMultiFingerTapMovementThreshold_FHandler ()
		{
			if (cb_setMultiFingerTapMovementThreshold_F == null)
				cb_setMultiFingerTapMovementThreshold_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMultiFingerTapMovementThreshold_F);
			return cb_setMultiFingerTapMovementThreshold_F;
		}

		static void n_SetMultiFingerTapMovementThreshold_F (IntPtr jnienv, IntPtr native__this, float multiFingerTapMovementThreshold)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MultiFingerTapMovementThreshold = multiFingerTapMovementThreshold;
		}
#pragma warning restore 0169

		public virtual unsafe float MultiFingerTapMovementThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerTapGestureDetector']/method[@name='getMultiFingerTapMovementThreshold' and count(parameter)=0]"
			[Register ("getMultiFingerTapMovementThreshold", "()F", "GetGetMultiFingerTapMovementThresholdHandler")]
			get {
				const string __id = "getMultiFingerTapMovementThreshold.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerTapGestureDetector']/method[@name='setMultiFingerTapMovementThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMultiFingerTapMovementThreshold", "(F)V", "GetSetMultiFingerTapMovementThreshold_FHandler")]
			set {
				const string __id = "setMultiFingerTapMovementThreshold.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMultiFingerTapTimeThreshold;
#pragma warning disable 0169
		static Delegate GetGetMultiFingerTapTimeThresholdHandler ()
		{
			if (cb_getMultiFingerTapTimeThreshold == null)
				cb_getMultiFingerTapTimeThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMultiFingerTapTimeThreshold);
			return cb_getMultiFingerTapTimeThreshold;
		}

		static long n_GetMultiFingerTapTimeThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MultiFingerTapTimeThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setMultiFingerTapTimeThreshold_J;
#pragma warning disable 0169
		static Delegate GetSetMultiFingerTapTimeThreshold_JHandler ()
		{
			if (cb_setMultiFingerTapTimeThreshold_J == null)
				cb_setMultiFingerTapTimeThreshold_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMultiFingerTapTimeThreshold_J);
			return cb_setMultiFingerTapTimeThreshold_J;
		}

		static void n_SetMultiFingerTapTimeThreshold_J (IntPtr jnienv, IntPtr native__this, long multiFingerTapTimeThreshold)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MultiFingerTapTimeThreshold = multiFingerTapTimeThreshold;
		}
#pragma warning restore 0169

		public virtual unsafe long MultiFingerTapTimeThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerTapGestureDetector']/method[@name='getMultiFingerTapTimeThreshold' and count(parameter)=0]"
			[Register ("getMultiFingerTapTimeThreshold", "()J", "GetGetMultiFingerTapTimeThresholdHandler")]
			get {
				const string __id = "getMultiFingerTapTimeThreshold.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerTapGestureDetector']/method[@name='setMultiFingerTapTimeThreshold' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMultiFingerTapTimeThreshold", "(J)V", "GetSetMultiFingerTapTimeThreshold_JHandler")]
			set {
				const string __id = "setMultiFingerTapTimeThreshold.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setMultiFingerTapMovementThresholdResource_I;
#pragma warning disable 0169
		static Delegate GetSetMultiFingerTapMovementThresholdResource_IHandler ()
		{
			if (cb_setMultiFingerTapMovementThresholdResource_I == null)
				cb_setMultiFingerTapMovementThresholdResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMultiFingerTapMovementThresholdResource_I);
			return cb_setMultiFingerTapMovementThresholdResource_I;
		}

		static void n_SetMultiFingerTapMovementThresholdResource_I (IntPtr jnienv, IntPtr native__this, int multiFingerTapMovementThresholdDimen)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMultiFingerTapMovementThresholdResource (multiFingerTapMovementThresholdDimen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerTapGestureDetector']/method[@name='setMultiFingerTapMovementThresholdResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMultiFingerTapMovementThresholdResource", "(I)V", "GetSetMultiFingerTapMovementThresholdResource_IHandler")]
		public virtual unsafe void SetMultiFingerTapMovementThresholdResource (int multiFingerTapMovementThresholdDimen)
		{
			const string __id = "setMultiFingerTapMovementThresholdResource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (multiFingerTapMovementThresholdDimen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
