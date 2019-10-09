using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionError']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegionError", DoNotGenerateAcw=true)]
	public partial class OfflineRegionError : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionError']/field[@name='REASON_CONNECTION']"
		[Register ("REASON_CONNECTION")]
		public const string ReasonConnection = (string) "REASON_CONNECTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionError']/field[@name='REASON_NOT_FOUND']"
		[Register ("REASON_NOT_FOUND")]
		public const string ReasonNotFound = (string) "REASON_NOT_FOUND";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionError']/field[@name='REASON_OTHER']"
		[Register ("REASON_OTHER")]
		public const string ReasonOther = (string) "REASON_OTHER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionError']/field[@name='REASON_SERVER']"
		[Register ("REASON_SERVER")]
		public const string ReasonServer = (string) "REASON_SERVER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionError']/field[@name='REASON_SUCCESS']"
		[Register ("REASON_SUCCESS")]
		public const string ReasonSuccess = (string) "REASON_SUCCESS";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegionError.ErrorReason']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineRegionError$ErrorReason", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError/IErrorReasonInvoker")]
		public partial interface IErrorReason : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegionError$ErrorReason", DoNotGenerateAcw=true)]
		internal class IErrorReasonInvoker : global::Java.Lang.Object, IErrorReason {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegionError$ErrorReason", typeof (IErrorReasonInvoker));

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

			public static IErrorReason GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IErrorReason> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineRegionError.ErrorReason"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IErrorReasonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError.IErrorReason __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError.IErrorReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError.IErrorReason __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError.IErrorReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError.IErrorReason __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError.IErrorReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError.IErrorReason __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError.IErrorReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegionError", typeof (OfflineRegionError));
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

		protected OfflineRegionError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionError']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReason;
#pragma warning disable 0169
		static Delegate GetGetReasonHandler ()
		{
			if (cb_getReason == null)
				cb_getReason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReason);
			return cb_getReason;
		}

		static IntPtr n_GetReason (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Reason);
		}
#pragma warning restore 0169

		[global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError", Fields = new string [] {"ReasonSuccess", "ReasonNotFound", "ReasonServer", "ReasonConnection", "ReasonOther"})]
		public virtual unsafe string Reason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionError']/method[@name='getReason' and count(parameter)=0]"
			[Register ("getReason", "()Ljava/lang/String;", "GetGetReasonHandler")]
			get {
				const string __id = "getReason.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
