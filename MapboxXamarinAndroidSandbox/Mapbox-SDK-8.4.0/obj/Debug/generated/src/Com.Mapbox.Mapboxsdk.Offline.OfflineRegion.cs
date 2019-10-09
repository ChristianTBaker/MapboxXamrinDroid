using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegion", DoNotGenerateAcw=true)]
	public partial class OfflineRegion : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/field[@name='STATE_ACTIVE']"
		[Register ("STATE_ACTIVE")]
		public const int StateActive = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/field[@name='STATE_INACTIVE']"
		[Register ("STATE_INACTIVE")]
		public const int StateInactive = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.DownloadState']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$DownloadState", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IDownloadStateInvoker")]
		public partial interface IDownloadState : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$DownloadState", DoNotGenerateAcw=true)]
		internal class IDownloadStateInvoker : global::Java.Lang.Object, IDownloadState {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegion$DownloadState", typeof (IDownloadStateInvoker));

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

			public static IDownloadState GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDownloadState> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineRegion.DownloadState"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDownloadStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IDownloadState __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IDownloadState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IDownloadState __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IDownloadState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IDownloadState __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IDownloadState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IDownloadState __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IDownloadState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionDeleteCallback']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionDeleteCallback", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionDeleteCallbackInvoker")]
		public partial interface IOfflineRegionDeleteCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionDeleteCallback']/method[@name='onDelete' and count(parameter)=0]"
			[Register ("onDelete", "()V", "GetOnDeleteHandler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionDeleteCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnDelete ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionDeleteCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionDeleteCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionDeleteCallback", DoNotGenerateAcw=true)]
		internal class IOfflineRegionDeleteCallbackInvoker : global::Java.Lang.Object, IOfflineRegionDeleteCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionDeleteCallback", typeof (IOfflineRegionDeleteCallbackInvoker));

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

			public static IOfflineRegionDeleteCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOfflineRegionDeleteCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionDeleteCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOfflineRegionDeleteCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDelete;
#pragma warning disable 0169
			static Delegate GetOnDeleteHandler ()
			{
				if (cb_onDelete == null)
					cb_onDelete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDelete);
				return cb_onDelete;
			}

			static void n_OnDelete (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionDeleteCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionDeleteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDelete ();
			}
#pragma warning restore 0169

			IntPtr id_onDelete;
			public unsafe void OnDelete ()
			{
				if (id_onDelete == IntPtr.Zero)
					id_onDelete = JNIEnv.GetMethodID (class_ref, "onDelete", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDelete);
			}

			static Delegate cb_onError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_String_Handler ()
			{
				if (cb_onError_Ljava_lang_String_ == null)
					cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_String_);
				return cb_onError_Ljava_lang_String_;
			}

			static void n_OnError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionDeleteCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionDeleteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_String_;
			public unsafe void OnError (string p0)
			{
				if (id_onError_Ljava_lang_String_ == IntPtr.Zero)
					id_onError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionInvalidateCallback']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionInvalidateCallback", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionInvalidateCallbackInvoker")]
		public partial interface IOfflineRegionInvalidateCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionInvalidateCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionInvalidateCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionInvalidateCallback']/method[@name='onInvalidate' and count(parameter)=0]"
			[Register ("onInvalidate", "()V", "GetOnInvalidateHandler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionInvalidateCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnInvalidate ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionInvalidateCallback", DoNotGenerateAcw=true)]
		internal class IOfflineRegionInvalidateCallbackInvoker : global::Java.Lang.Object, IOfflineRegionInvalidateCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionInvalidateCallback", typeof (IOfflineRegionInvalidateCallbackInvoker));

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

			public static IOfflineRegionInvalidateCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOfflineRegionInvalidateCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionInvalidateCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOfflineRegionInvalidateCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_String_Handler ()
			{
				if (cb_onError_Ljava_lang_String_ == null)
					cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_String_);
				return cb_onError_Ljava_lang_String_;
			}

			static void n_OnError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionInvalidateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionInvalidateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_String_;
			public unsafe void OnError (string p0)
			{
				if (id_onError_Ljava_lang_String_ == IntPtr.Zero)
					id_onError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onInvalidate;
#pragma warning disable 0169
			static Delegate GetOnInvalidateHandler ()
			{
				if (cb_onInvalidate == null)
					cb_onInvalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInvalidate);
				return cb_onInvalidate;
			}

			static void n_OnInvalidate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionInvalidateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionInvalidateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInvalidate ();
			}
#pragma warning restore 0169

			IntPtr id_onInvalidate;
			public unsafe void OnInvalidate ()
			{
				if (id_onInvalidate == IntPtr.Zero)
					id_onInvalidate = JNIEnv.GetMethodID (class_ref, "onInvalidate", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInvalidate);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionObserver']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionObserver", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionObserverInvoker")]
		public partial interface IOfflineRegionObserver : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionObserver']/method[@name='mapboxTileCountLimitExceeded' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("mapboxTileCountLimitExceeded", "(J)V", "GetMapboxTileCountLimitExceeded_JHandler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionObserverInvoker, Mapbox-SDK-8.4.0")]
			void MapboxTileCountLimitExceeded (long p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegionError']]"
			[Register ("onError", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionError;)V", "GetOnError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionObserverInvoker, Mapbox-SDK-8.4.0")]
			void OnError (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionObserver']/method[@name='onStatusChanged' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegionStatus']]"
			[Register ("onStatusChanged", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionStatus;)V", "GetOnStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionObserverInvoker, Mapbox-SDK-8.4.0")]
			void OnStatusChanged (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionObserver", DoNotGenerateAcw=true)]
		internal class IOfflineRegionObserverInvoker : global::Java.Lang.Object, IOfflineRegionObserver {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionObserver", typeof (IOfflineRegionObserverInvoker));

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

			public static IOfflineRegionObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOfflineRegionObserver> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionObserver"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOfflineRegionObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_mapboxTileCountLimitExceeded_J;
#pragma warning disable 0169
			static Delegate GetMapboxTileCountLimitExceeded_JHandler ()
			{
				if (cb_mapboxTileCountLimitExceeded_J == null)
					cb_mapboxTileCountLimitExceeded_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_MapboxTileCountLimitExceeded_J);
				return cb_mapboxTileCountLimitExceeded_J;
			}

			static void n_MapboxTileCountLimitExceeded_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.MapboxTileCountLimitExceeded (p0);
			}
#pragma warning restore 0169

			IntPtr id_mapboxTileCountLimitExceeded_J;
			public unsafe void MapboxTileCountLimitExceeded (long p0)
			{
				if (id_mapboxTileCountLimitExceeded_J == IntPtr.Zero)
					id_mapboxTileCountLimitExceeded_J = JNIEnv.GetMethodID (class_ref, "mapboxTileCountLimitExceeded", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mapboxTileCountLimitExceeded_J, __args);
			}

			static Delegate cb_onError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_Handler ()
			{
				if (cb_onError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_ == null)
					cb_onError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_);
				return cb_onError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_;
			}

			static void n_OnError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_;
			public unsafe void OnError (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionError p0)
			{
				if (id_onError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_ == IntPtr.Zero)
					id_onError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_mapbox_mapboxsdk_offline_OfflineRegionError_, __args);
			}

			static Delegate cb_onStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_;
#pragma warning disable 0169
			static Delegate GetOnStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_Handler ()
			{
				if (cb_onStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ == null)
					cb_onStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_);
				return cb_onStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_;
			}

			static void n_OnStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStatusChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_;
			public unsafe void OnStatusChanged (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus p0)
			{
				if (id_onStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ == IntPtr.Zero)
					id_onStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ = JNIEnv.GetMethodID (class_ref, "onStatusChanged", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatusChanged_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionStatusCallback']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionStatusCallback", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionStatusCallbackInvoker")]
		public partial interface IOfflineRegionStatusCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionStatusCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionStatusCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionStatusCallback']/method[@name='onStatus' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegionStatus']]"
			[Register ("onStatus", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionStatus;)V", "GetOnStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionStatusCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnStatus (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionStatusCallback", DoNotGenerateAcw=true)]
		internal class IOfflineRegionStatusCallbackInvoker : global::Java.Lang.Object, IOfflineRegionStatusCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionStatusCallback", typeof (IOfflineRegionStatusCallbackInvoker));

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

			public static IOfflineRegionStatusCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOfflineRegionStatusCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionStatusCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOfflineRegionStatusCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_String_Handler ()
			{
				if (cb_onError_Ljava_lang_String_ == null)
					cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_String_);
				return cb_onError_Ljava_lang_String_;
			}

			static void n_OnError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionStatusCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionStatusCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_String_;
			public unsafe void OnError (string p0)
			{
				if (id_onError_Ljava_lang_String_ == IntPtr.Zero)
					id_onError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_;
#pragma warning disable 0169
			static Delegate GetOnStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_Handler ()
			{
				if (cb_onStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ == null)
					cb_onStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_);
				return cb_onStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_;
			}

			static void n_OnStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionStatusCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionStatusCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStatus (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_;
			public unsafe void OnStatus (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus p0)
			{
				if (id_onStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ == IntPtr.Zero)
					id_onStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_ = JNIEnv.GetMethodID (class_ref, "onStatus", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegionStatus_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionUpdateMetadataCallback']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionUpdateMetadataCallback", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionUpdateMetadataCallbackInvoker")]
		public partial interface IOfflineRegionUpdateMetadataCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionUpdateMetadataCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionUpdateMetadataCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineRegion.OfflineRegionUpdateMetadataCallback']/method[@name='onUpdate' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("onUpdate", "([B)V", "GetOnUpdate_arrayBHandler:Com.Mapbox.Mapboxsdk.Offline.OfflineRegion/IOfflineRegionUpdateMetadataCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnUpdate (byte[] p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionUpdateMetadataCallback", DoNotGenerateAcw=true)]
		internal class IOfflineRegionUpdateMetadataCallbackInvoker : global::Java.Lang.Object, IOfflineRegionUpdateMetadataCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionUpdateMetadataCallback", typeof (IOfflineRegionUpdateMetadataCallbackInvoker));

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

			public static IOfflineRegionUpdateMetadataCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOfflineRegionUpdateMetadataCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionUpdateMetadataCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOfflineRegionUpdateMetadataCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_String_Handler ()
			{
				if (cb_onError_Ljava_lang_String_ == null)
					cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_String_);
				return cb_onError_Ljava_lang_String_;
			}

			static void n_OnError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionUpdateMetadataCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionUpdateMetadataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_String_;
			public unsafe void OnError (string p0)
			{
				if (id_onError_Ljava_lang_String_ == IntPtr.Zero)
					id_onError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onUpdate_arrayB;
#pragma warning disable 0169
			static Delegate GetOnUpdate_arrayBHandler ()
			{
				if (cb_onUpdate_arrayB == null)
					cb_onUpdate_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdate_arrayB);
				return cb_onUpdate_arrayB;
			}

			static void n_OnUpdate_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionUpdateMetadataCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionUpdateMetadataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnUpdate (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onUpdate_arrayB;
			public unsafe void OnUpdate (byte[] p0)
			{
				if (id_onUpdate_arrayB == IntPtr.Zero)
					id_onUpdate_arrayB = JNIEnv.GetMethodID (class_ref, "onUpdate", "([B)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdate_arrayB, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegion", typeof (OfflineRegion));
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

		protected OfflineRegion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDefinition;
#pragma warning disable 0169
		static Delegate GetGetDefinitionHandler ()
		{
			if (cb_getDefinition == null)
				cb_getDefinition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefinition);
			return cb_getDefinition;
		}

		static IntPtr n_GetDefinition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Definition);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition Definition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='getDefinition' and count(parameter)=0]"
			[Register ("getDefinition", "()Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;", "GetGetDefinitionHandler")]
			get {
				const string __id = "getDefinition.()Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getID;
#pragma warning disable 0169
		static Delegate GetGetIDHandler ()
		{
			if (cb_getID == null)
				cb_getID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetID);
			return cb_getID;
		}

		static long n_GetID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ID;
		}
#pragma warning restore 0169

		public virtual unsafe long ID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='getID' and count(parameter)=0]"
			[Register ("getID", "()J", "GetGetIDHandler")]
			get {
				const string __id = "getID.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDeliveringInactiveMessages;
#pragma warning disable 0169
		static Delegate GetIsDeliveringInactiveMessagesHandler ()
		{
			if (cb_isDeliveringInactiveMessages == null)
				cb_isDeliveringInactiveMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeliveringInactiveMessages);
			return cb_isDeliveringInactiveMessages;
		}

		static bool n_IsDeliveringInactiveMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeliveringInactiveMessages;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDeliveringInactiveMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='isDeliveringInactiveMessages' and count(parameter)=0]"
			[Register ("isDeliveringInactiveMessages", "()Z", "GetIsDeliveringInactiveMessagesHandler")]
			get {
				const string __id = "isDeliveringInactiveMessages.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_delete_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionDeleteCallback_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionDeleteCallback_Handler ()
		{
			if (cb_delete_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionDeleteCallback_ == null)
				cb_delete_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionDeleteCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionDeleteCallback_);
			return cb_delete_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionDeleteCallback_;
		}

		static void n_Delete_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionDeleteCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionDeleteCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionDeleteCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionDeleteCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Delete (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionDeleteCallback']]"
		[Register ("delete", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionDeleteCallback;)V", "GetDelete_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionDeleteCallback_Handler")]
		public virtual unsafe void Delete (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionDeleteCallback @callback)
		{
			const string __id = "delete.(Lcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionDeleteCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMetadata ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='getMetadata' and count(parameter)=0]"
		[Register ("getMetadata", "()[B", "GetGetMetadataHandler")]
		public virtual unsafe byte[] GetMetadata ()
		{
			const string __id = "getMetadata.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionStatusCallback_;
#pragma warning disable 0169
		static Delegate GetGetStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionStatusCallback_Handler ()
		{
			if (cb_getStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionStatusCallback_ == null)
				cb_getStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionStatusCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionStatusCallback_);
			return cb_getStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionStatusCallback_;
		}

		static void n_GetStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionStatusCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionStatusCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionStatusCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionStatusCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetStatus (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='getStatus' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionStatusCallback']]"
		[Register ("getStatus", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionStatusCallback;)V", "GetGetStatus_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionStatusCallback_Handler")]
		public virtual unsafe void GetStatus (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionStatusCallback @callback)
		{
			const string __id = "getStatus.(Lcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionStatusCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_invalidate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionInvalidateCallback_;
#pragma warning disable 0169
		static Delegate GetInvalidate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionInvalidateCallback_Handler ()
		{
			if (cb_invalidate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionInvalidateCallback_ == null)
				cb_invalidate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionInvalidateCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Invalidate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionInvalidateCallback_);
			return cb_invalidate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionInvalidateCallback_;
		}

		static void n_Invalidate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionInvalidateCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionInvalidateCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionInvalidateCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionInvalidateCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='invalidate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionInvalidateCallback']]"
		[Register ("invalidate", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionInvalidateCallback;)V", "GetInvalidate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionInvalidateCallback_Handler")]
		public virtual unsafe void Invalidate (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionInvalidateCallback @callback)
		{
			const string __id = "invalidate.(Lcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionInvalidateCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDeliverInactiveMessages_Z;
#pragma warning disable 0169
		static Delegate GetSetDeliverInactiveMessages_ZHandler ()
		{
			if (cb_setDeliverInactiveMessages_Z == null)
				cb_setDeliverInactiveMessages_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDeliverInactiveMessages_Z);
			return cb_setDeliverInactiveMessages_Z;
		}

		static void n_SetDeliverInactiveMessages_Z (IntPtr jnienv, IntPtr native__this, bool deliverInactiveMessages)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDeliverInactiveMessages (deliverInactiveMessages);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='setDeliverInactiveMessages' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDeliverInactiveMessages", "(Z)V", "GetSetDeliverInactiveMessages_ZHandler")]
		public virtual unsafe void SetDeliverInactiveMessages (bool deliverInactiveMessages)
		{
			const string __id = "setDeliverInactiveMessages.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (deliverInactiveMessages);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDownloadState_I;
#pragma warning disable 0169
		static Delegate GetSetDownloadState_IHandler ()
		{
			if (cb_setDownloadState_I == null)
				cb_setDownloadState_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownloadState_I);
			return cb_setDownloadState_I;
		}

		static void n_SetDownloadState_I (IntPtr jnienv, IntPtr native__this, int state)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDownloadState (state);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='setDownloadState' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDownloadState", "(I)V", "GetSetDownloadState_IHandler")]
		public virtual unsafe void SetDownloadState ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Offline.OfflineRegion", Fields = new string [] {"StateInactive", "StateActive"})]int state)
		{
			const string __id = "setDownloadState.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (state);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setObserver_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionObserver_;
#pragma warning disable 0169
		static Delegate GetSetObserver_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionObserver_Handler ()
		{
			if (cb_setObserver_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionObserver_ == null)
				cb_setObserver_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObserver_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionObserver_);
			return cb_setObserver_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionObserver_;
		}

		static void n_SetObserver_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver observer = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.SetObserver (observer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='setObserver' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionObserver']]"
		[Register ("setObserver", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionObserver;)V", "GetSetObserver_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionObserver_Handler")]
		public virtual unsafe void SetObserver (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionObserver observer)
		{
			const string __id = "setObserver.(Lcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateMetadata_arrayBLcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionUpdateMetadataCallback_;
#pragma warning disable 0169
		static Delegate GetUpdateMetadata_arrayBLcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionUpdateMetadataCallback_Handler ()
		{
			if (cb_updateMetadata_arrayBLcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionUpdateMetadataCallback_ == null)
				cb_updateMetadata_arrayBLcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionUpdateMetadataCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMetadata_arrayBLcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionUpdateMetadataCallback_);
			return cb_updateMetadata_arrayBLcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionUpdateMetadataCallback_;
		}

		static void n_UpdateMetadata_arrayBLcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionUpdateMetadataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionUpdateMetadataCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionUpdateMetadataCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionUpdateMetadataCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMetadata (bytes, @callback);
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegion']/method[@name='updateMetadata' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.mapbox.mapboxsdk.offline.OfflineRegion.OfflineRegionUpdateMetadataCallback']]"
		[Register ("updateMetadata", "([BLcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionUpdateMetadataCallback;)V", "GetUpdateMetadata_arrayBLcom_mapbox_mapboxsdk_offline_OfflineRegion_OfflineRegionUpdateMetadataCallback_Handler")]
		public virtual unsafe void UpdateMetadata (byte[] bytes, global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion.IOfflineRegionUpdateMetadataCallback @callback)
		{
			const string __id = "updateMetadata.([BLcom/mapbox/mapboxsdk/offline/OfflineRegion$OfflineRegionUpdateMetadataCallback;)V";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

	}
}
