using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/VisionObjectDetectionEvent", DoNotGenerateAcw=true)]
	public partial class VisionObjectDetectionEvent : global::Com.Mapbox.Android.Telemetry.Event, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/VisionObjectDetectionEvent", typeof (VisionObjectDetectionEvent));
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

		protected VisionObjectDetectionEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/constructor[@name='VisionObjectDetectionEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe VisionObjectDetectionEvent (string created)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_created = JNIEnv.NewString (created);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_created);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_created);
			}
		}

		static Delegate cb_getClazz;
#pragma warning disable 0169
		static Delegate GetGetClazzHandler ()
		{
			if (cb_getClazz == null)
				cb_getClazz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClazz);
			return cb_getClazz;
		}

		static IntPtr n_GetClazz (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Clazz);
		}
#pragma warning restore 0169

		static Delegate cb_setClazz_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClazz_Ljava_lang_String_Handler ()
		{
			if (cb_setClazz_Ljava_lang_String_ == null)
				cb_setClazz_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClazz_Ljava_lang_String_);
			return cb_setClazz_Ljava_lang_String_;
		}

		static void n_SetClazz_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clazz)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string clazz = JNIEnv.GetString (native_clazz, JniHandleOwnership.DoNotTransfer);
			__this.Clazz = clazz;
		}
#pragma warning restore 0169

		public virtual unsafe string Clazz {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getClazz' and count(parameter)=0]"
			[Register ("getClazz", "()Ljava/lang/String;", "GetGetClazzHandler")]
			get {
				const string __id = "getClazz.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setClazz' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClazz", "(Ljava/lang/String;)V", "GetSetClazz_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClazz.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCreated;
#pragma warning disable 0169
		static Delegate GetGetCreatedHandler ()
		{
			if (cb_getCreated == null)
				cb_getCreated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreated);
			return cb_getCreated;
		}

		static IntPtr n_GetCreated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Created);
		}
#pragma warning restore 0169

		public virtual unsafe string Created {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getCreated' and count(parameter)=0]"
			[Register ("getCreated", "()Ljava/lang/String;", "GetGetCreatedHandler")]
			get {
				const string __id = "getCreated.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDistanceFromCamera;
#pragma warning disable 0169
		static Delegate GetGetDistanceFromCameraHandler ()
		{
			if (cb_getDistanceFromCamera == null)
				cb_getDistanceFromCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDistanceFromCamera);
			return cb_getDistanceFromCamera;
		}

		static double n_GetDistanceFromCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DistanceFromCamera;
		}
#pragma warning restore 0169

		static Delegate cb_setDistanceFromCamera_D;
#pragma warning disable 0169
		static Delegate GetSetDistanceFromCamera_DHandler ()
		{
			if (cb_setDistanceFromCamera_D == null)
				cb_setDistanceFromCamera_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetDistanceFromCamera_D);
			return cb_setDistanceFromCamera_D;
		}

		static void n_SetDistanceFromCamera_D (IntPtr jnienv, IntPtr native__this, double distance_from_camera)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DistanceFromCamera = distance_from_camera;
		}
#pragma warning restore 0169

		public virtual unsafe double DistanceFromCamera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getDistanceFromCamera' and count(parameter)=0]"
			[Register ("getDistanceFromCamera", "()D", "GetGetDistanceFromCameraHandler")]
			get {
				const string __id = "getDistanceFromCamera.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setDistanceFromCamera' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setDistanceFromCamera", "(D)V", "GetSetDistanceFromCamera_DHandler")]
			set {
				const string __id = "setDistanceFromCamera.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEvent;
#pragma warning disable 0169
		static Delegate GetGetEventHandler ()
		{
			if (cb_getEvent == null)
				cb_getEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEvent);
			return cb_getEvent;
		}

		static IntPtr n_GetEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Event);
		}
#pragma warning restore 0169

		public virtual unsafe string Event {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getEvent' and count(parameter)=0]"
			[Register ("getEvent", "()Ljava/lang/String;", "GetGetEventHandler")]
			get {
				const string __id = "getEvent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectLatitude;
#pragma warning disable 0169
		static Delegate GetGetObjectLatitudeHandler ()
		{
			if (cb_getObjectLatitude == null)
				cb_getObjectLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetObjectLatitude);
			return cb_getObjectLatitude;
		}

		static double n_GetObjectLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectLatitude;
		}
#pragma warning restore 0169

		static Delegate cb_setObjectLatitude_D;
#pragma warning disable 0169
		static Delegate GetSetObjectLatitude_DHandler ()
		{
			if (cb_setObjectLatitude_D == null)
				cb_setObjectLatitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetObjectLatitude_D);
			return cb_setObjectLatitude_D;
		}

		static void n_SetObjectLatitude_D (IntPtr jnienv, IntPtr native__this, double latitude)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ObjectLatitude = latitude;
		}
#pragma warning restore 0169

		public virtual unsafe double ObjectLatitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getObjectLatitude' and count(parameter)=0]"
			[Register ("getObjectLatitude", "()D", "GetGetObjectLatitudeHandler")]
			get {
				const string __id = "getObjectLatitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setObjectLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setObjectLatitude", "(D)V", "GetSetObjectLatitude_DHandler")]
			set {
				const string __id = "setObjectLatitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectLongitude;
#pragma warning disable 0169
		static Delegate GetGetObjectLongitudeHandler ()
		{
			if (cb_getObjectLongitude == null)
				cb_getObjectLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetObjectLongitude);
			return cb_getObjectLongitude;
		}

		static double n_GetObjectLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectLongitude;
		}
#pragma warning restore 0169

		static Delegate cb_setObjectLongitude_D;
#pragma warning disable 0169
		static Delegate GetSetObjectLongitude_DHandler ()
		{
			if (cb_setObjectLongitude_D == null)
				cb_setObjectLongitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetObjectLongitude_D);
			return cb_setObjectLongitude_D;
		}

		static void n_SetObjectLongitude_D (IntPtr jnienv, IntPtr native__this, double longitude)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ObjectLongitude = longitude;
		}
#pragma warning restore 0169

		public virtual unsafe double ObjectLongitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getObjectLongitude' and count(parameter)=0]"
			[Register ("getObjectLongitude", "()D", "GetGetObjectLongitudeHandler")]
			get {
				const string __id = "getObjectLongitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setObjectLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setObjectLongitude", "(D)V", "GetSetObjectLongitude_DHandler")]
			set {
				const string __id = "setObjectLongitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectPositionHeight;
#pragma warning disable 0169
		static Delegate GetGetObjectPositionHeightHandler ()
		{
			if (cb_getObjectPositionHeight == null)
				cb_getObjectPositionHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetObjectPositionHeight);
			return cb_getObjectPositionHeight;
		}

		static double n_GetObjectPositionHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectPositionHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setObjectPositionHeight_D;
#pragma warning disable 0169
		static Delegate GetSetObjectPositionHeight_DHandler ()
		{
			if (cb_setObjectPositionHeight_D == null)
				cb_setObjectPositionHeight_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetObjectPositionHeight_D);
			return cb_setObjectPositionHeight_D;
		}

		static void n_SetObjectPositionHeight_D (IntPtr jnienv, IntPtr native__this, double object_pos_height)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ObjectPositionHeight = object_pos_height;
		}
#pragma warning restore 0169

		public virtual unsafe double ObjectPositionHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getObjectPositionHeight' and count(parameter)=0]"
			[Register ("getObjectPositionHeight", "()D", "GetGetObjectPositionHeightHandler")]
			get {
				const string __id = "getObjectPositionHeight.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setObjectPositionHeight' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setObjectPositionHeight", "(D)V", "GetSetObjectPositionHeight_DHandler")]
			set {
				const string __id = "setObjectPositionHeight.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectSizeHeight;
#pragma warning disable 0169
		static Delegate GetGetObjectSizeHeightHandler ()
		{
			if (cb_getObjectSizeHeight == null)
				cb_getObjectSizeHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetObjectSizeHeight);
			return cb_getObjectSizeHeight;
		}

		static double n_GetObjectSizeHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectSizeHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setObjectSizeHeight_D;
#pragma warning disable 0169
		static Delegate GetSetObjectSizeHeight_DHandler ()
		{
			if (cb_setObjectSizeHeight_D == null)
				cb_setObjectSizeHeight_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetObjectSizeHeight_D);
			return cb_setObjectSizeHeight_D;
		}

		static void n_SetObjectSizeHeight_D (IntPtr jnienv, IntPtr native__this, double object_size_height)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ObjectSizeHeight = object_size_height;
		}
#pragma warning restore 0169

		public virtual unsafe double ObjectSizeHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getObjectSizeHeight' and count(parameter)=0]"
			[Register ("getObjectSizeHeight", "()D", "GetGetObjectSizeHeightHandler")]
			get {
				const string __id = "getObjectSizeHeight.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setObjectSizeHeight' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setObjectSizeHeight", "(D)V", "GetSetObjectSizeHeight_DHandler")]
			set {
				const string __id = "setObjectSizeHeight.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectSizeWidth;
#pragma warning disable 0169
		static Delegate GetGetObjectSizeWidthHandler ()
		{
			if (cb_getObjectSizeWidth == null)
				cb_getObjectSizeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetObjectSizeWidth);
			return cb_getObjectSizeWidth;
		}

		static double n_GetObjectSizeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectSizeWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setObjectSizeWidth_D;
#pragma warning disable 0169
		static Delegate GetSetObjectSizeWidth_DHandler ()
		{
			if (cb_setObjectSizeWidth_D == null)
				cb_setObjectSizeWidth_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetObjectSizeWidth_D);
			return cb_setObjectSizeWidth_D;
		}

		static void n_SetObjectSizeWidth_D (IntPtr jnienv, IntPtr native__this, double object_size_width)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ObjectSizeWidth = object_size_width;
		}
#pragma warning restore 0169

		public virtual unsafe double ObjectSizeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getObjectSizeWidth' and count(parameter)=0]"
			[Register ("getObjectSizeWidth", "()D", "GetGetObjectSizeWidthHandler")]
			get {
				const string __id = "getObjectSizeWidth.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setObjectSizeWidth' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setObjectSizeWidth", "(D)V", "GetSetObjectSizeWidth_DHandler")]
			set {
				const string __id = "setObjectSizeWidth.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSignValue;
#pragma warning disable 0169
		static Delegate GetGetSignValueHandler ()
		{
			if (cb_getSignValue == null)
				cb_getSignValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignValue);
			return cb_getSignValue;
		}

		static IntPtr n_GetSignValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SignValue);
		}
#pragma warning restore 0169

		static Delegate cb_setSignValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSignValue_Ljava_lang_String_Handler ()
		{
			if (cb_setSignValue_Ljava_lang_String_ == null)
				cb_setSignValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSignValue_Ljava_lang_String_);
			return cb_setSignValue_Ljava_lang_String_;
		}

		static void n_SetSignValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sign_value)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sign_value = JNIEnv.GetString (native_sign_value, JniHandleOwnership.DoNotTransfer);
			__this.SignValue = sign_value;
		}
#pragma warning restore 0169

		public virtual unsafe string SignValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getSignValue' and count(parameter)=0]"
			[Register ("getSignValue", "()Ljava/lang/String;", "GetGetSignValueHandler")]
			get {
				const string __id = "getSignValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setSignValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSignValue", "(Ljava/lang/String;)V", "GetSetSignValue_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSignValue.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVehicleLatitude;
#pragma warning disable 0169
		static Delegate GetGetVehicleLatitudeHandler ()
		{
			if (cb_getVehicleLatitude == null)
				cb_getVehicleLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetVehicleLatitude);
			return cb_getVehicleLatitude;
		}

		static double n_GetVehicleLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VehicleLatitude;
		}
#pragma warning restore 0169

		static Delegate cb_setVehicleLatitude_D;
#pragma warning disable 0169
		static Delegate GetSetVehicleLatitude_DHandler ()
		{
			if (cb_setVehicleLatitude_D == null)
				cb_setVehicleLatitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetVehicleLatitude_D);
			return cb_setVehicleLatitude_D;
		}

		static void n_SetVehicleLatitude_D (IntPtr jnienv, IntPtr native__this, double latitude)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VehicleLatitude = latitude;
		}
#pragma warning restore 0169

		public virtual unsafe double VehicleLatitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getVehicleLatitude' and count(parameter)=0]"
			[Register ("getVehicleLatitude", "()D", "GetGetVehicleLatitudeHandler")]
			get {
				const string __id = "getVehicleLatitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setVehicleLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setVehicleLatitude", "(D)V", "GetSetVehicleLatitude_DHandler")]
			set {
				const string __id = "setVehicleLatitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVehicleLongitude;
#pragma warning disable 0169
		static Delegate GetGetVehicleLongitudeHandler ()
		{
			if (cb_getVehicleLongitude == null)
				cb_getVehicleLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetVehicleLongitude);
			return cb_getVehicleLongitude;
		}

		static double n_GetVehicleLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VehicleLongitude;
		}
#pragma warning restore 0169

		static Delegate cb_setVehicleLongitude_D;
#pragma warning disable 0169
		static Delegate GetSetVehicleLongitude_DHandler ()
		{
			if (cb_setVehicleLongitude_D == null)
				cb_setVehicleLongitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetVehicleLongitude_D);
			return cb_setVehicleLongitude_D;
		}

		static void n_SetVehicleLongitude_D (IntPtr jnienv, IntPtr native__this, double longitude)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VehicleLongitude = longitude;
		}
#pragma warning restore 0169

		public virtual unsafe double VehicleLongitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='getVehicleLongitude' and count(parameter)=0]"
			[Register ("getVehicleLongitude", "()D", "GetGetVehicleLongitudeHandler")]
			get {
				const string __id = "getVehicleLongitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='setVehicleLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setVehicleLongitude", "(D)V", "GetSetVehicleLongitude_DHandler")]
			set {
				const string __id = "setVehicleLongitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.VisionObjectDetectionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='VisionObjectDetectionEvent']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
