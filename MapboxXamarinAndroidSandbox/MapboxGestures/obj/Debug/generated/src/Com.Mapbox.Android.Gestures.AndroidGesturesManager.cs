using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/AndroidGesturesManager", DoNotGenerateAcw=true)]
	public partial class AndroidGesturesManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_DOUBLE_TAP']"
		[Register ("GESTURE_TYPE_DOUBLE_TAP")]
		public const int GestureTypeDoubleTap = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_DOUBLE_TAP_EVENT']"
		[Register ("GESTURE_TYPE_DOUBLE_TAP_EVENT")]
		public const int GestureTypeDoubleTapEvent = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_DOWN']"
		[Register ("GESTURE_TYPE_DOWN")]
		public const int GestureTypeDown = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_FLING']"
		[Register ("GESTURE_TYPE_FLING")]
		public const int GestureTypeFling = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_LONG_PRESS']"
		[Register ("GESTURE_TYPE_LONG_PRESS")]
		public const int GestureTypeLongPress = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_MOVE']"
		[Register ("GESTURE_TYPE_MOVE")]
		public const int GestureTypeMove = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_MULTI_FINGER_TAP']"
		[Register ("GESTURE_TYPE_MULTI_FINGER_TAP")]
		public const int GestureTypeMultiFingerTap = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_QUICK_SCALE']"
		[Register ("GESTURE_TYPE_QUICK_SCALE")]
		public const int GestureTypeQuickScale = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_ROTATE']"
		[Register ("GESTURE_TYPE_ROTATE")]
		public const int GestureTypeRotate = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_SCALE']"
		[Register ("GESTURE_TYPE_SCALE")]
		public const int GestureTypeScale = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_SCROLL']"
		[Register ("GESTURE_TYPE_SCROLL")]
		public const int GestureTypeScroll = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_SHOVE']"
		[Register ("GESTURE_TYPE_SHOVE")]
		public const int GestureTypeShove = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_SHOW_PRESS']"
		[Register ("GESTURE_TYPE_SHOW_PRESS")]
		public const int GestureTypeShowPress = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_SIDEWAYS_SHOVE']"
		[Register ("GESTURE_TYPE_SIDEWAYS_SHOVE")]
		public const int GestureTypeSidewaysShove = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_SINGLE_TAP_CONFIRMED']"
		[Register ("GESTURE_TYPE_SINGLE_TAP_CONFIRMED")]
		public const int GestureTypeSingleTapConfirmed = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/field[@name='GESTURE_TYPE_SINGLE_TAP_UP']"
		[Register ("GESTURE_TYPE_SINGLE_TAP_UP")]
		public const int GestureTypeSingleTapUp = (int) 5;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.android.gestures']/interface[@name='AndroidGesturesManager.GestureType']"
		[Register ("com/mapbox/android/gestures/AndroidGesturesManager$GestureType", "", "Com.Mapbox.Android.Gestures.AndroidGesturesManager/IGestureTypeInvoker")]
		public partial interface IGestureType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/mapbox/android/gestures/AndroidGesturesManager$GestureType", DoNotGenerateAcw=true)]
		internal class IGestureTypeInvoker : global::Java.Lang.Object, IGestureType {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/gestures/AndroidGesturesManager$GestureType", typeof (IGestureTypeInvoker));

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

			public static IGestureType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGestureType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.android.gestures.AndroidGesturesManager.GestureType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGestureTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Android.Gestures.AndroidGesturesManager.IGestureType __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager.IGestureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Mapbox.Android.Gestures.AndroidGesturesManager.IGestureType __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager.IGestureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Android.Gestures.AndroidGesturesManager.IGestureType __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager.IGestureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Android.Gestures.AndroidGesturesManager.IGestureType __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager.IGestureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/AndroidGesturesManager", typeof (AndroidGesturesManager));
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

		protected AndroidGesturesManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/constructor[@name='AndroidGesturesManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AndroidGesturesManager (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/constructor[@name='AndroidGesturesManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Z)V", "")]
		public unsafe AndroidGesturesManager (global::Android.Content.Context context, bool applyDefaultThresholds)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (applyDefaultThresholds);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/constructor[@name='AndroidGesturesManager' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;java.util.Set&lt;java.lang.Integer&gt;&gt;'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Z)V", "")]
		public unsafe AndroidGesturesManager (global::Android.Content.Context context, global::System.Collections.Generic.IList<global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>> exclusiveGestures, bool applyDefaultThresholds)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/util/List;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_exclusiveGestures = global::Android.Runtime.JavaList<global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.ToLocalJniHandle (exclusiveGestures);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_exclusiveGestures);
				__args [2] = new JniArgumentValue (applyDefaultThresholds);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_exclusiveGestures);
			}
		}

		static Delegate cb_getDetectors;
#pragma warning disable 0169
		static Delegate GetGetDetectorsHandler ()
		{
			if (cb_getDetectors == null)
				cb_getDetectors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDetectors);
			return cb_getDetectors;
		}

		static IntPtr n_GetDetectors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Android.Gestures.BaseGesture>.ToLocalJniHandle (__this.Detectors);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Android.Gestures.BaseGesture> Detectors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='getDetectors' and count(parameter)=0]"
			[Register ("getDetectors", "()Ljava/util/List;", "GetGetDetectorsHandler")]
			get {
				const string __id = "getDetectors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Android.Gestures.BaseGesture>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMoveGestureDetector;
#pragma warning disable 0169
		static Delegate GetGetMoveGestureDetectorHandler ()
		{
			if (cb_getMoveGestureDetector == null)
				cb_getMoveGestureDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMoveGestureDetector);
			return cb_getMoveGestureDetector;
		}

		static IntPtr n_GetMoveGestureDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoveGestureDetector);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Android.Gestures.MoveGestureDetector MoveGestureDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='getMoveGestureDetector' and count(parameter)=0]"
			[Register ("getMoveGestureDetector", "()Lcom/mapbox/android/gestures/MoveGestureDetector;", "GetGetMoveGestureDetectorHandler")]
			get {
				const string __id = "getMoveGestureDetector.()Lcom/mapbox/android/gestures/MoveGestureDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMultiFingerTapGestureDetector;
#pragma warning disable 0169
		static Delegate GetGetMultiFingerTapGestureDetectorHandler ()
		{
			if (cb_getMultiFingerTapGestureDetector == null)
				cb_getMultiFingerTapGestureDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMultiFingerTapGestureDetector);
			return cb_getMultiFingerTapGestureDetector;
		}

		static IntPtr n_GetMultiFingerTapGestureDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MultiFingerTapGestureDetector);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector MultiFingerTapGestureDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='getMultiFingerTapGestureDetector' and count(parameter)=0]"
			[Register ("getMultiFingerTapGestureDetector", "()Lcom/mapbox/android/gestures/MultiFingerTapGestureDetector;", "GetGetMultiFingerTapGestureDetectorHandler")]
			get {
				const string __id = "getMultiFingerTapGestureDetector.()Lcom/mapbox/android/gestures/MultiFingerTapGestureDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMutuallyExclusiveGestures;
#pragma warning disable 0169
		static Delegate GetGetMutuallyExclusiveGesturesHandler ()
		{
			if (cb_getMutuallyExclusiveGestures == null)
				cb_getMutuallyExclusiveGestures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMutuallyExclusiveGestures);
			return cb_getMutuallyExclusiveGestures;
		}

		static IntPtr n_GetMutuallyExclusiveGestures (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.ToLocalJniHandle (__this.MutuallyExclusiveGestures);
		}
#pragma warning restore 0169

		static Delegate cb_setMutuallyExclusiveGestures_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetMutuallyExclusiveGestures_Ljava_util_List_Handler ()
		{
			if (cb_setMutuallyExclusiveGestures_Ljava_util_List_ == null)
				cb_setMutuallyExclusiveGestures_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMutuallyExclusiveGestures_Ljava_util_List_);
			return cb_setMutuallyExclusiveGestures_Ljava_util_List_;
		}

		static void n_SetMutuallyExclusiveGestures_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exclusiveGestures)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exclusiveGestures = global::Android.Runtime.JavaList<global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.FromJniHandle (native_exclusiveGestures, JniHandleOwnership.DoNotTransfer);
			__this.MutuallyExclusiveGestures = exclusiveGestures;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>> MutuallyExclusiveGestures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='getMutuallyExclusiveGestures' and count(parameter)=0]"
			[Register ("getMutuallyExclusiveGestures", "()Ljava/util/List;", "GetGetMutuallyExclusiveGesturesHandler")]
			get {
				const string __id = "getMutuallyExclusiveGestures.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='setMutuallyExclusiveGestures' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Set&lt;java.lang.Integer&gt;&gt;']]"
			[Register ("setMutuallyExclusiveGestures", "(Ljava/util/List;)V", "GetSetMutuallyExclusiveGestures_Ljava_util_List_Handler")]
			set {
				const string __id = "setMutuallyExclusiveGestures.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRotateGestureDetector;
#pragma warning disable 0169
		static Delegate GetGetRotateGestureDetectorHandler ()
		{
			if (cb_getRotateGestureDetector == null)
				cb_getRotateGestureDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotateGestureDetector);
			return cb_getRotateGestureDetector;
		}

		static IntPtr n_GetRotateGestureDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotateGestureDetector);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Android.Gestures.RotateGestureDetector RotateGestureDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='getRotateGestureDetector' and count(parameter)=0]"
			[Register ("getRotateGestureDetector", "()Lcom/mapbox/android/gestures/RotateGestureDetector;", "GetGetRotateGestureDetectorHandler")]
			get {
				const string __id = "getRotateGestureDetector.()Lcom/mapbox/android/gestures/RotateGestureDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShoveGestureDetector;
#pragma warning disable 0169
		static Delegate GetGetShoveGestureDetectorHandler ()
		{
			if (cb_getShoveGestureDetector == null)
				cb_getShoveGestureDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShoveGestureDetector);
			return cb_getShoveGestureDetector;
		}

		static IntPtr n_GetShoveGestureDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShoveGestureDetector);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Android.Gestures.ShoveGestureDetector ShoveGestureDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='getShoveGestureDetector' and count(parameter)=0]"
			[Register ("getShoveGestureDetector", "()Lcom/mapbox/android/gestures/ShoveGestureDetector;", "GetGetShoveGestureDetectorHandler")]
			get {
				const string __id = "getShoveGestureDetector.()Lcom/mapbox/android/gestures/ShoveGestureDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSidewaysShoveGestureDetector;
#pragma warning disable 0169
		static Delegate GetGetSidewaysShoveGestureDetectorHandler ()
		{
			if (cb_getSidewaysShoveGestureDetector == null)
				cb_getSidewaysShoveGestureDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSidewaysShoveGestureDetector);
			return cb_getSidewaysShoveGestureDetector;
		}

		static IntPtr n_GetSidewaysShoveGestureDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SidewaysShoveGestureDetector);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector SidewaysShoveGestureDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='getSidewaysShoveGestureDetector' and count(parameter)=0]"
			[Register ("getSidewaysShoveGestureDetector", "()Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;", "GetGetSidewaysShoveGestureDetectorHandler")]
			get {
				const string __id = "getSidewaysShoveGestureDetector.()Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStandardGestureDetector;
#pragma warning disable 0169
		static Delegate GetGetStandardGestureDetectorHandler ()
		{
			if (cb_getStandardGestureDetector == null)
				cb_getStandardGestureDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStandardGestureDetector);
			return cb_getStandardGestureDetector;
		}

		static IntPtr n_GetStandardGestureDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StandardGestureDetector);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Android.Gestures.StandardGestureDetector StandardGestureDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='getStandardGestureDetector' and count(parameter)=0]"
			[Register ("getStandardGestureDetector", "()Lcom/mapbox/android/gestures/StandardGestureDetector;", "GetGetStandardGestureDetectorHandler")]
			get {
				const string __id = "getStandardGestureDetector.()Lcom/mapbox/android/gestures/StandardGestureDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStandardScaleGestureDetector;
#pragma warning disable 0169
		static Delegate GetGetStandardScaleGestureDetectorHandler ()
		{
			if (cb_getStandardScaleGestureDetector == null)
				cb_getStandardScaleGestureDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStandardScaleGestureDetector);
			return cb_getStandardScaleGestureDetector;
		}

		static IntPtr n_GetStandardScaleGestureDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StandardScaleGestureDetector);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector StandardScaleGestureDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='getStandardScaleGestureDetector' and count(parameter)=0]"
			[Register ("getStandardScaleGestureDetector", "()Lcom/mapbox/android/gestures/StandardScaleGestureDetector;", "GetGetStandardScaleGestureDetectorHandler")]
			get {
				const string __id = "getStandardScaleGestureDetector.()Lcom/mapbox/android/gestures/StandardScaleGestureDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent motionEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_motionEvent, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (motionEvent);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouchEvent (global::Android.Views.MotionEvent motionEvent)
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

		static Delegate cb_removeMoveGestureListener;
#pragma warning disable 0169
		static Delegate GetRemoveMoveGestureListenerHandler ()
		{
			if (cb_removeMoveGestureListener == null)
				cb_removeMoveGestureListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveMoveGestureListener);
			return cb_removeMoveGestureListener;
		}

		static void n_RemoveMoveGestureListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMoveGestureListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='removeMoveGestureListener' and count(parameter)=0]"
		[Register ("removeMoveGestureListener", "()V", "GetRemoveMoveGestureListenerHandler")]
		public virtual unsafe void RemoveMoveGestureListener ()
		{
			const string __id = "removeMoveGestureListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeMultiFingerTapGestureListener;
#pragma warning disable 0169
		static Delegate GetRemoveMultiFingerTapGestureListenerHandler ()
		{
			if (cb_removeMultiFingerTapGestureListener == null)
				cb_removeMultiFingerTapGestureListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveMultiFingerTapGestureListener);
			return cb_removeMultiFingerTapGestureListener;
		}

		static void n_RemoveMultiFingerTapGestureListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMultiFingerTapGestureListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='removeMultiFingerTapGestureListener' and count(parameter)=0]"
		[Register ("removeMultiFingerTapGestureListener", "()V", "GetRemoveMultiFingerTapGestureListenerHandler")]
		public virtual unsafe void RemoveMultiFingerTapGestureListener ()
		{
			const string __id = "removeMultiFingerTapGestureListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeRotateGestureListener;
#pragma warning disable 0169
		static Delegate GetRemoveRotateGestureListenerHandler ()
		{
			if (cb_removeRotateGestureListener == null)
				cb_removeRotateGestureListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveRotateGestureListener);
			return cb_removeRotateGestureListener;
		}

		static void n_RemoveRotateGestureListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRotateGestureListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='removeRotateGestureListener' and count(parameter)=0]"
		[Register ("removeRotateGestureListener", "()V", "GetRemoveRotateGestureListenerHandler")]
		public virtual unsafe void RemoveRotateGestureListener ()
		{
			const string __id = "removeRotateGestureListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeShoveGestureListener;
#pragma warning disable 0169
		static Delegate GetRemoveShoveGestureListenerHandler ()
		{
			if (cb_removeShoveGestureListener == null)
				cb_removeShoveGestureListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveShoveGestureListener);
			return cb_removeShoveGestureListener;
		}

		static void n_RemoveShoveGestureListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveShoveGestureListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='removeShoveGestureListener' and count(parameter)=0]"
		[Register ("removeShoveGestureListener", "()V", "GetRemoveShoveGestureListenerHandler")]
		public virtual unsafe void RemoveShoveGestureListener ()
		{
			const string __id = "removeShoveGestureListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeSidewaysShoveGestureListener;
#pragma warning disable 0169
		static Delegate GetRemoveSidewaysShoveGestureListenerHandler ()
		{
			if (cb_removeSidewaysShoveGestureListener == null)
				cb_removeSidewaysShoveGestureListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveSidewaysShoveGestureListener);
			return cb_removeSidewaysShoveGestureListener;
		}

		static void n_RemoveSidewaysShoveGestureListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSidewaysShoveGestureListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='removeSidewaysShoveGestureListener' and count(parameter)=0]"
		[Register ("removeSidewaysShoveGestureListener", "()V", "GetRemoveSidewaysShoveGestureListenerHandler")]
		public virtual unsafe void RemoveSidewaysShoveGestureListener ()
		{
			const string __id = "removeSidewaysShoveGestureListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeStandardGestureListener;
#pragma warning disable 0169
		static Delegate GetRemoveStandardGestureListenerHandler ()
		{
			if (cb_removeStandardGestureListener == null)
				cb_removeStandardGestureListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveStandardGestureListener);
			return cb_removeStandardGestureListener;
		}

		static void n_RemoveStandardGestureListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveStandardGestureListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='removeStandardGestureListener' and count(parameter)=0]"
		[Register ("removeStandardGestureListener", "()V", "GetRemoveStandardGestureListenerHandler")]
		public virtual unsafe void RemoveStandardGestureListener ()
		{
			const string __id = "removeStandardGestureListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeStandardScaleGestureListener;
#pragma warning disable 0169
		static Delegate GetRemoveStandardScaleGestureListenerHandler ()
		{
			if (cb_removeStandardScaleGestureListener == null)
				cb_removeStandardScaleGestureListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveStandardScaleGestureListener);
			return cb_removeStandardScaleGestureListener;
		}

		static void n_RemoveStandardScaleGestureListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveStandardScaleGestureListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='removeStandardScaleGestureListener' and count(parameter)=0]"
		[Register ("removeStandardScaleGestureListener", "()V", "GetRemoveStandardScaleGestureListenerHandler")]
		public virtual unsafe void RemoveStandardScaleGestureListener ()
		{
			const string __id = "removeStandardScaleGestureListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setMoveGestureListener_Lcom_mapbox_android_gestures_MoveGestureDetector_OnMoveGestureListener_;
#pragma warning disable 0169
		static Delegate GetSetMoveGestureListener_Lcom_mapbox_android_gestures_MoveGestureDetector_OnMoveGestureListener_Handler ()
		{
			if (cb_setMoveGestureListener_Lcom_mapbox_android_gestures_MoveGestureDetector_OnMoveGestureListener_ == null)
				cb_setMoveGestureListener_Lcom_mapbox_android_gestures_MoveGestureDetector_OnMoveGestureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMoveGestureListener_Lcom_mapbox_android_gestures_MoveGestureDetector_OnMoveGestureListener_);
			return cb_setMoveGestureListener_Lcom_mapbox_android_gestures_MoveGestureDetector_OnMoveGestureListener_;
		}

		static void n_SetMoveGestureListener_Lcom_mapbox_android_gestures_MoveGestureDetector_OnMoveGestureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener listener = (global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetMoveGestureListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='setMoveGestureListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.MoveGestureDetector.OnMoveGestureListener']]"
		[Register ("setMoveGestureListener", "(Lcom/mapbox/android/gestures/MoveGestureDetector$OnMoveGestureListener;)V", "GetSetMoveGestureListener_Lcom_mapbox_android_gestures_MoveGestureDetector_OnMoveGestureListener_Handler")]
		public virtual unsafe void SetMoveGestureListener (global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener listener)
		{
			const string __id = "setMoveGestureListener.(Lcom/mapbox/android/gestures/MoveGestureDetector$OnMoveGestureListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMultiFingerTapGestureListener_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_OnMultiFingerTapGestureListener_;
#pragma warning disable 0169
		static Delegate GetSetMultiFingerTapGestureListener_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_OnMultiFingerTapGestureListener_Handler ()
		{
			if (cb_setMultiFingerTapGestureListener_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_OnMultiFingerTapGestureListener_ == null)
				cb_setMultiFingerTapGestureListener_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_OnMultiFingerTapGestureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMultiFingerTapGestureListener_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_OnMultiFingerTapGestureListener_);
			return cb_setMultiFingerTapGestureListener_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_OnMultiFingerTapGestureListener_;
		}

		static void n_SetMultiFingerTapGestureListener_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_OnMultiFingerTapGestureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListener listener = (global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetMultiFingerTapGestureListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='setMultiFingerTapGestureListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.MultiFingerTapGestureDetector.OnMultiFingerTapGestureListener']]"
		[Register ("setMultiFingerTapGestureListener", "(Lcom/mapbox/android/gestures/MultiFingerTapGestureDetector$OnMultiFingerTapGestureListener;)V", "GetSetMultiFingerTapGestureListener_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_OnMultiFingerTapGestureListener_Handler")]
		public virtual unsafe void SetMultiFingerTapGestureListener (global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListener listener)
		{
			const string __id = "setMultiFingerTapGestureListener.(Lcom/mapbox/android/gestures/MultiFingerTapGestureDetector$OnMultiFingerTapGestureListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRotateGestureListener_Lcom_mapbox_android_gestures_RotateGestureDetector_OnRotateGestureListener_;
#pragma warning disable 0169
		static Delegate GetSetRotateGestureListener_Lcom_mapbox_android_gestures_RotateGestureDetector_OnRotateGestureListener_Handler ()
		{
			if (cb_setRotateGestureListener_Lcom_mapbox_android_gestures_RotateGestureDetector_OnRotateGestureListener_ == null)
				cb_setRotateGestureListener_Lcom_mapbox_android_gestures_RotateGestureDetector_OnRotateGestureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRotateGestureListener_Lcom_mapbox_android_gestures_RotateGestureDetector_OnRotateGestureListener_);
			return cb_setRotateGestureListener_Lcom_mapbox_android_gestures_RotateGestureDetector_OnRotateGestureListener_;
		}

		static void n_SetRotateGestureListener_Lcom_mapbox_android_gestures_RotateGestureDetector_OnRotateGestureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener listener = (global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetRotateGestureListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='setRotateGestureListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.RotateGestureDetector.OnRotateGestureListener']]"
		[Register ("setRotateGestureListener", "(Lcom/mapbox/android/gestures/RotateGestureDetector$OnRotateGestureListener;)V", "GetSetRotateGestureListener_Lcom_mapbox_android_gestures_RotateGestureDetector_OnRotateGestureListener_Handler")]
		public virtual unsafe void SetRotateGestureListener (global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener listener)
		{
			const string __id = "setRotateGestureListener.(Lcom/mapbox/android/gestures/RotateGestureDetector$OnRotateGestureListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShoveGestureListener_Lcom_mapbox_android_gestures_ShoveGestureDetector_OnShoveGestureListener_;
#pragma warning disable 0169
		static Delegate GetSetShoveGestureListener_Lcom_mapbox_android_gestures_ShoveGestureDetector_OnShoveGestureListener_Handler ()
		{
			if (cb_setShoveGestureListener_Lcom_mapbox_android_gestures_ShoveGestureDetector_OnShoveGestureListener_ == null)
				cb_setShoveGestureListener_Lcom_mapbox_android_gestures_ShoveGestureDetector_OnShoveGestureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShoveGestureListener_Lcom_mapbox_android_gestures_ShoveGestureDetector_OnShoveGestureListener_);
			return cb_setShoveGestureListener_Lcom_mapbox_android_gestures_ShoveGestureDetector_OnShoveGestureListener_;
		}

		static void n_SetShoveGestureListener_Lcom_mapbox_android_gestures_ShoveGestureDetector_OnShoveGestureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener listener = (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetShoveGestureListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='setShoveGestureListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.ShoveGestureDetector.OnShoveGestureListener']]"
		[Register ("setShoveGestureListener", "(Lcom/mapbox/android/gestures/ShoveGestureDetector$OnShoveGestureListener;)V", "GetSetShoveGestureListener_Lcom_mapbox_android_gestures_ShoveGestureDetector_OnShoveGestureListener_Handler")]
		public virtual unsafe void SetShoveGestureListener (global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener listener)
		{
			const string __id = "setShoveGestureListener.(Lcom/mapbox/android/gestures/ShoveGestureDetector$OnShoveGestureListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSidewaysShoveGestureListener_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_OnSidewaysShoveGestureListener_;
#pragma warning disable 0169
		static Delegate GetSetSidewaysShoveGestureListener_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_OnSidewaysShoveGestureListener_Handler ()
		{
			if (cb_setSidewaysShoveGestureListener_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_OnSidewaysShoveGestureListener_ == null)
				cb_setSidewaysShoveGestureListener_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_OnSidewaysShoveGestureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSidewaysShoveGestureListener_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_OnSidewaysShoveGestureListener_);
			return cb_setSidewaysShoveGestureListener_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_OnSidewaysShoveGestureListener_;
		}

		static void n_SetSidewaysShoveGestureListener_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_OnSidewaysShoveGestureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener listener = (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetSidewaysShoveGestureListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='setSidewaysShoveGestureListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener']]"
		[Register ("setSidewaysShoveGestureListener", "(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector$OnSidewaysShoveGestureListener;)V", "GetSetSidewaysShoveGestureListener_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_OnSidewaysShoveGestureListener_Handler")]
		public virtual unsafe void SetSidewaysShoveGestureListener (global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener listener)
		{
			const string __id = "setSidewaysShoveGestureListener.(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector$OnSidewaysShoveGestureListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStandardGestureListener_Lcom_mapbox_android_gestures_StandardGestureDetector_StandardOnGestureListener_;
#pragma warning disable 0169
		static Delegate GetSetStandardGestureListener_Lcom_mapbox_android_gestures_StandardGestureDetector_StandardOnGestureListener_Handler ()
		{
			if (cb_setStandardGestureListener_Lcom_mapbox_android_gestures_StandardGestureDetector_StandardOnGestureListener_ == null)
				cb_setStandardGestureListener_Lcom_mapbox_android_gestures_StandardGestureDetector_StandardOnGestureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStandardGestureListener_Lcom_mapbox_android_gestures_StandardGestureDetector_StandardOnGestureListener_);
			return cb_setStandardGestureListener_Lcom_mapbox_android_gestures_StandardGestureDetector_StandardOnGestureListener_;
		}

		static void n_SetStandardGestureListener_Lcom_mapbox_android_gestures_StandardGestureDetector_StandardOnGestureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener listener = (global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetStandardGestureListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='setStandardGestureListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.StandardGestureDetector.StandardOnGestureListener']]"
		[Register ("setStandardGestureListener", "(Lcom/mapbox/android/gestures/StandardGestureDetector$StandardOnGestureListener;)V", "GetSetStandardGestureListener_Lcom_mapbox_android_gestures_StandardGestureDetector_StandardOnGestureListener_Handler")]
		public virtual unsafe void SetStandardGestureListener (global::Com.Mapbox.Android.Gestures.StandardGestureDetector.IStandardOnGestureListener listener)
		{
			const string __id = "setStandardGestureListener.(Lcom/mapbox/android/gestures/StandardGestureDetector$StandardOnGestureListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStandardScaleGestureListener_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_StandardOnScaleGestureListener_;
#pragma warning disable 0169
		static Delegate GetSetStandardScaleGestureListener_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_StandardOnScaleGestureListener_Handler ()
		{
			if (cb_setStandardScaleGestureListener_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_StandardOnScaleGestureListener_ == null)
				cb_setStandardScaleGestureListener_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_StandardOnScaleGestureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStandardScaleGestureListener_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_StandardOnScaleGestureListener_);
			return cb_setStandardScaleGestureListener_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_StandardOnScaleGestureListener_;
		}

		static void n_SetStandardScaleGestureListener_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_StandardOnScaleGestureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Mapbox.Android.Gestures.AndroidGesturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.AndroidGesturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener listener = (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetStandardScaleGestureListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='setStandardScaleGestureListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.gestures.StandardScaleGestureDetector.StandardOnScaleGestureListener']]"
		[Register ("setStandardScaleGestureListener", "(Lcom/mapbox/android/gestures/StandardScaleGestureDetector$StandardOnScaleGestureListener;)V", "GetSetStandardScaleGestureListener_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_StandardOnScaleGestureListener_Handler")]
		public virtual unsafe void SetStandardScaleGestureListener (global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener listener)
		{
			const string __id = "setStandardScaleGestureListener.(Lcom/mapbox/android/gestures/StandardScaleGestureDetector$StandardOnScaleGestureListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener"
		public event EventHandler<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.MoveEventArgs> Move {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener, global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor>(
						ref weak_implementor_SetMoveGestureListener,
						__CreateIOnMoveGestureListenerImplementor,
						SetMoveGestureListener,
						__h => __h.OnMoveHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener, global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor>(
						ref weak_implementor_SetMoveGestureListener,
						global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor.__IsEmpty,
						__v => SetMoveGestureListener (null),
						__h => __h.OnMoveHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.MoveBeginEventArgs> MoveBegin {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener, global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor>(
						ref weak_implementor_SetMoveGestureListener,
						__CreateIOnMoveGestureListenerImplementor,
						SetMoveGestureListener,
						__h => __h.OnMoveBeginHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener, global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor>(
						ref weak_implementor_SetMoveGestureListener,
						global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor.__IsEmpty,
						__v => SetMoveGestureListener (null),
						__h => __h.OnMoveBeginHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.MoveEndEventArgs> MoveEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener, global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor>(
						ref weak_implementor_SetMoveGestureListener,
						__CreateIOnMoveGestureListenerImplementor,
						SetMoveGestureListener,
						__h => __h.OnMoveEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListener, global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor>(
						ref weak_implementor_SetMoveGestureListener,
						global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor.__IsEmpty,
						__v => SetMoveGestureListener (null),
						__h => __h.OnMoveEndHandler -= value);
			}
		}

		WeakReference weak_implementor_SetMoveGestureListener;

		global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor __CreateIOnMoveGestureListenerImplementor ()
		{
			return new global::Com.Mapbox.Android.Gestures.MoveGestureDetector.IOnMoveGestureListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListener"
		public event EventHandler<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.MultiFingerTapGestureEventArgs> MultiFingerTapGesture {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListener, global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListenerImplementor>(
						ref weak_implementor_SetMultiFingerTapGestureListener,
						__CreateIOnMultiFingerTapGestureListenerImplementor,
						SetMultiFingerTapGestureListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListener, global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListenerImplementor>(
						ref weak_implementor_SetMultiFingerTapGestureListener,
						global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListenerImplementor.__IsEmpty,
						__v => SetMultiFingerTapGestureListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetMultiFingerTapGestureListener;

		global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListenerImplementor __CreateIOnMultiFingerTapGestureListenerImplementor ()
		{
			return new global::Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector.IOnMultiFingerTapGestureListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener"
		public event EventHandler<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.RotateEventArgs> Rotate {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener, global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor>(
						ref weak_implementor_SetRotateGestureListener,
						__CreateIOnRotateGestureListenerImplementor,
						SetRotateGestureListener,
						__h => __h.OnRotateHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener, global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor>(
						ref weak_implementor_SetRotateGestureListener,
						global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor.__IsEmpty,
						__v => SetRotateGestureListener (null),
						__h => __h.OnRotateHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.RotateBeginEventArgs> RotateBegin {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener, global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor>(
						ref weak_implementor_SetRotateGestureListener,
						__CreateIOnRotateGestureListenerImplementor,
						SetRotateGestureListener,
						__h => __h.OnRotateBeginHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener, global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor>(
						ref weak_implementor_SetRotateGestureListener,
						global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor.__IsEmpty,
						__v => SetRotateGestureListener (null),
						__h => __h.OnRotateBeginHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.RotateEndEventArgs> RotateEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener, global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor>(
						ref weak_implementor_SetRotateGestureListener,
						__CreateIOnRotateGestureListenerImplementor,
						SetRotateGestureListener,
						__h => __h.OnRotateEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListener, global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor>(
						ref weak_implementor_SetRotateGestureListener,
						global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor.__IsEmpty,
						__v => SetRotateGestureListener (null),
						__h => __h.OnRotateEndHandler -= value);
			}
		}

		WeakReference weak_implementor_SetRotateGestureListener;

		global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor __CreateIOnRotateGestureListenerImplementor ()
		{
			return new global::Com.Mapbox.Android.Gestures.RotateGestureDetector.IOnRotateGestureListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener"
		public event EventHandler<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.ShoveEventArgs> Shove {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener, global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor>(
						ref weak_implementor_SetShoveGestureListener,
						__CreateIOnShoveGestureListenerImplementor,
						SetShoveGestureListener,
						__h => __h.OnShoveHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener, global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor>(
						ref weak_implementor_SetShoveGestureListener,
						global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor.__IsEmpty,
						__v => SetShoveGestureListener (null),
						__h => __h.OnShoveHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.ShoveBeginEventArgs> ShoveBegin {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener, global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor>(
						ref weak_implementor_SetShoveGestureListener,
						__CreateIOnShoveGestureListenerImplementor,
						SetShoveGestureListener,
						__h => __h.OnShoveBeginHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener, global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor>(
						ref weak_implementor_SetShoveGestureListener,
						global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor.__IsEmpty,
						__v => SetShoveGestureListener (null),
						__h => __h.OnShoveBeginHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.ShoveEndEventArgs> ShoveEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener, global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor>(
						ref weak_implementor_SetShoveGestureListener,
						__CreateIOnShoveGestureListenerImplementor,
						SetShoveGestureListener,
						__h => __h.OnShoveEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListener, global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor>(
						ref weak_implementor_SetShoveGestureListener,
						global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor.__IsEmpty,
						__v => SetShoveGestureListener (null),
						__h => __h.OnShoveEndHandler -= value);
			}
		}

		WeakReference weak_implementor_SetShoveGestureListener;

		global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor __CreateIOnShoveGestureListenerImplementor ()
		{
			return new global::Com.Mapbox.Android.Gestures.ShoveGestureDetector.IOnShoveGestureListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener"
		public event EventHandler<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.SidewaysShoveEventArgs> SidewaysShove {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener, global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor>(
						ref weak_implementor_SetSidewaysShoveGestureListener,
						__CreateIOnSidewaysShoveGestureListenerImplementor,
						SetSidewaysShoveGestureListener,
						__h => __h.OnSidewaysShoveHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener, global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor>(
						ref weak_implementor_SetSidewaysShoveGestureListener,
						global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor.__IsEmpty,
						__v => SetSidewaysShoveGestureListener (null),
						__h => __h.OnSidewaysShoveHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.SidewaysShoveBeginEventArgs> SidewaysShoveBegin {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener, global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor>(
						ref weak_implementor_SetSidewaysShoveGestureListener,
						__CreateIOnSidewaysShoveGestureListenerImplementor,
						SetSidewaysShoveGestureListener,
						__h => __h.OnSidewaysShoveBeginHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener, global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor>(
						ref weak_implementor_SetSidewaysShoveGestureListener,
						global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor.__IsEmpty,
						__v => SetSidewaysShoveGestureListener (null),
						__h => __h.OnSidewaysShoveBeginHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.SidewaysShoveEndEventArgs> SidewaysShoveEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener, global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor>(
						ref weak_implementor_SetSidewaysShoveGestureListener,
						__CreateIOnSidewaysShoveGestureListenerImplementor,
						SetSidewaysShoveGestureListener,
						__h => __h.OnSidewaysShoveEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListener, global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor>(
						ref weak_implementor_SetSidewaysShoveGestureListener,
						global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor.__IsEmpty,
						__v => SetSidewaysShoveGestureListener (null),
						__h => __h.OnSidewaysShoveEndHandler -= value);
			}
		}

		WeakReference weak_implementor_SetSidewaysShoveGestureListener;

		global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor __CreateIOnSidewaysShoveGestureListenerImplementor ()
		{
			return new global::Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector.IOnSidewaysShoveGestureListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener"
		public event EventHandler<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.ScaleEventArgs> Scale {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener, global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor>(
						ref weak_implementor_SetStandardScaleGestureListener,
						__CreateIStandardOnScaleGestureListenerImplementor,
						SetStandardScaleGestureListener,
						__h => __h.OnScaleHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener, global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor>(
						ref weak_implementor_SetStandardScaleGestureListener,
						global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor.__IsEmpty,
						__v => SetStandardScaleGestureListener (null),
						__h => __h.OnScaleHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.ScaleBeginEventArgs> ScaleBegin {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener, global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor>(
						ref weak_implementor_SetStandardScaleGestureListener,
						__CreateIStandardOnScaleGestureListenerImplementor,
						SetStandardScaleGestureListener,
						__h => __h.OnScaleBeginHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener, global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor>(
						ref weak_implementor_SetStandardScaleGestureListener,
						global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor.__IsEmpty,
						__v => SetStandardScaleGestureListener (null),
						__h => __h.OnScaleBeginHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.ScaleEndEventArgs> ScaleEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener, global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor>(
						ref weak_implementor_SetStandardScaleGestureListener,
						__CreateIStandardOnScaleGestureListenerImplementor,
						SetStandardScaleGestureListener,
						__h => __h.OnScaleEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListener, global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor>(
						ref weak_implementor_SetStandardScaleGestureListener,
						global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor.__IsEmpty,
						__v => SetStandardScaleGestureListener (null),
						__h => __h.OnScaleEndHandler -= value);
			}
		}

		WeakReference weak_implementor_SetStandardScaleGestureListener;

		global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor __CreateIStandardOnScaleGestureListenerImplementor ()
		{
			return new global::Com.Mapbox.Android.Gestures.StandardScaleGestureDetector.IStandardOnScaleGestureListenerImplementor (this);
		}
#endregion
	}
}
