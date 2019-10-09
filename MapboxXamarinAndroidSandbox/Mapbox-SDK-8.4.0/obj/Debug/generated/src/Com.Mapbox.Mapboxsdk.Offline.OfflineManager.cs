using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineManager", DoNotGenerateAcw=true)]
	public partial class OfflineManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.CreateOfflineRegionCallback']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineManager$CreateOfflineRegionCallback", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineManager/ICreateOfflineRegionCallbackInvoker")]
		public partial interface ICreateOfflineRegionCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.CreateOfflineRegionCallback']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegion']]"
			[Register ("onCreate", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegion;)V", "GetOnCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineManager/ICreateOfflineRegionCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnCreate (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.CreateOfflineRegionCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineManager/ICreateOfflineRegionCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineManager$CreateOfflineRegionCallback", DoNotGenerateAcw=true)]
		internal class ICreateOfflineRegionCallbackInvoker : global::Java.Lang.Object, ICreateOfflineRegionCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineManager$CreateOfflineRegionCallback", typeof (ICreateOfflineRegionCallbackInvoker));

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

			public static ICreateOfflineRegionCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICreateOfflineRegionCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineManager.CreateOfflineRegionCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICreateOfflineRegionCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_;
#pragma warning disable 0169
			static Delegate GetOnCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_Handler ()
			{
				if (cb_onCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_ == null)
					cb_onCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_);
				return cb_onCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_;
			}

			static void n_OnCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.ICreateOfflineRegionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.ICreateOfflineRegionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCreate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_;
			public unsafe void OnCreate (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion p0)
			{
				if (id_onCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_ == IntPtr.Zero)
					id_onCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegion;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Lcom_mapbox_mapboxsdk_offline_OfflineRegion_, __args);
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.ICreateOfflineRegionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.ICreateOfflineRegionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.FileSourceCallback']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineManager/IFileSourceCallbackInvoker")]
		public partial interface IFileSourceCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.FileSourceCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineManager/IFileSourceCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.FileSourceCallback']/method[@name='onSuccess' and count(parameter)=0]"
			[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Mapbox.Mapboxsdk.Offline.OfflineManager/IFileSourceCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnSuccess ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback", DoNotGenerateAcw=true)]
		internal class IFileSourceCallbackInvoker : global::Java.Lang.Object, IFileSourceCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback", typeof (IFileSourceCallbackInvoker));

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

			public static IFileSourceCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFileSourceCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineManager.FileSourceCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFileSourceCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onSuccess;
#pragma warning disable 0169
			static Delegate GetOnSuccessHandler ()
			{
				if (cb_onSuccess == null)
					cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
				return cb_onSuccess;
			}

			static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess ();
			}
#pragma warning restore 0169

			IntPtr id_onSuccess;
			public unsafe void OnSuccess ()
			{
				if (id_onSuccess == IntPtr.Zero)
					id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.ListOfflineRegionsCallback']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineManager$ListOfflineRegionsCallback", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineManager/IListOfflineRegionsCallbackInvoker")]
		public partial interface IListOfflineRegionsCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.ListOfflineRegionsCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineManager/IListOfflineRegionsCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.ListOfflineRegionsCallback']/method[@name='onList' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegion[]']]"
			[Register ("onList", "([Lcom/mapbox/mapboxsdk/offline/OfflineRegion;)V", "GetOnList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineManager/IListOfflineRegionsCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnList (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion[] p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineManager$ListOfflineRegionsCallback", DoNotGenerateAcw=true)]
		internal class IListOfflineRegionsCallbackInvoker : global::Java.Lang.Object, IListOfflineRegionsCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineManager$ListOfflineRegionsCallback", typeof (IListOfflineRegionsCallbackInvoker));

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

			public static IListOfflineRegionsCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListOfflineRegionsCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineManager.ListOfflineRegionsCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListOfflineRegionsCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IListOfflineRegionsCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IListOfflineRegionsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_;
#pragma warning disable 0169
			static Delegate GetOnList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_Handler ()
			{
				if (cb_onList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ == null)
					cb_onList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_);
				return cb_onList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_;
			}

			static void n_OnList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IListOfflineRegionsCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IListOfflineRegionsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion[] p0 = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion));
				__this.OnList (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_;
			public unsafe void OnList (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion[] p0)
			{
				if (id_onList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ == IntPtr.Zero)
					id_onList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ = JNIEnv.GetMethodID (class_ref, "onList", "([Lcom/mapbox/mapboxsdk/offline/OfflineRegion;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onList_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.MergeOfflineRegionsCallback']"
		[Register ("com/mapbox/mapboxsdk/offline/OfflineManager$MergeOfflineRegionsCallback", "", "Com.Mapbox.Mapboxsdk.Offline.OfflineManager/IMergeOfflineRegionsCallbackInvoker")]
		public partial interface IMergeOfflineRegionsCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.MergeOfflineRegionsCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineManager/IMergeOfflineRegionsCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/interface[@name='OfflineManager.MergeOfflineRegionsCallback']/method[@name='onMerge' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegion[]']]"
			[Register ("onMerge", "([Lcom/mapbox/mapboxsdk/offline/OfflineRegion;)V", "GetOnMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_Handler:Com.Mapbox.Mapboxsdk.Offline.OfflineManager/IMergeOfflineRegionsCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnMerge (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion[] p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineManager$MergeOfflineRegionsCallback", DoNotGenerateAcw=true)]
		internal class IMergeOfflineRegionsCallbackInvoker : global::Java.Lang.Object, IMergeOfflineRegionsCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineManager$MergeOfflineRegionsCallback", typeof (IMergeOfflineRegionsCallbackInvoker));

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

			public static IMergeOfflineRegionsCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMergeOfflineRegionsCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.offline.OfflineManager.MergeOfflineRegionsCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMergeOfflineRegionsCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IMergeOfflineRegionsCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IMergeOfflineRegionsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_;
#pragma warning disable 0169
			static Delegate GetOnMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_Handler ()
			{
				if (cb_onMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ == null)
					cb_onMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_);
				return cb_onMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_;
			}

			static void n_OnMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IMergeOfflineRegionsCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IMergeOfflineRegionsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion[] p0 = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion));
				__this.OnMerge (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_;
			public unsafe void OnMerge (global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegion[] p0)
			{
				if (id_onMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ == IntPtr.Zero)
					id_onMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_ = JNIEnv.GetMethodID (class_ref, "onMerge", "([Lcom/mapbox/mapboxsdk/offline/OfflineRegion;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMerge_arrayLcom_mapbox_mapboxsdk_offline_OfflineRegion_, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineManager", typeof (OfflineManager));
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

		protected OfflineManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_clearAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_;
#pragma warning disable 0169
		static Delegate GetClearAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_Handler ()
		{
			if (cb_clearAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ == null)
				cb_clearAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_);
			return cb_clearAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_;
		}

		static void n_ClearAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ClearAmbientCache (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='clearAmbientCache' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineManager.FileSourceCallback']]"
		[Register ("clearAmbientCache", "(Lcom/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback;)V", "GetClearAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_Handler")]
		public virtual unsafe void ClearAmbientCache (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback @callback)
		{
			const string __id = "clearAmbientCache.(Lcom/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_arrayBLcom_mapbox_mapboxsdk_offline_OfflineManager_CreateOfflineRegionCallback_;
#pragma warning disable 0169
		static Delegate GetCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_arrayBLcom_mapbox_mapboxsdk_offline_OfflineManager_CreateOfflineRegionCallback_Handler ()
		{
			if (cb_createOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_arrayBLcom_mapbox_mapboxsdk_offline_OfflineManager_CreateOfflineRegionCallback_ == null)
				cb_createOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_arrayBLcom_mapbox_mapboxsdk_offline_OfflineManager_CreateOfflineRegionCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_arrayBLcom_mapbox_mapboxsdk_offline_OfflineManager_CreateOfflineRegionCallback_);
			return cb_createOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_arrayBLcom_mapbox_mapboxsdk_offline_OfflineManager_CreateOfflineRegionCallback_;
		}

		static void n_CreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_arrayBLcom_mapbox_mapboxsdk_offline_OfflineManager_CreateOfflineRegionCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_definition, IntPtr native_metadata, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition definition = (global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition> (native_definition, JniHandleOwnership.DoNotTransfer);
			byte[] metadata = (byte[]) JNIEnv.GetArray (native_metadata, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.ICreateOfflineRegionCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.ICreateOfflineRegionCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.ICreateOfflineRegionCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.CreateOfflineRegion (definition, metadata, @callback);
			if (metadata != null)
				JNIEnv.CopyArray (metadata, native_metadata);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='createOfflineRegion' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineRegionDefinition'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.mapbox.mapboxsdk.offline.OfflineManager.CreateOfflineRegionCallback']]"
		[Register ("createOfflineRegion", "(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;[BLcom/mapbox/mapboxsdk/offline/OfflineManager$CreateOfflineRegionCallback;)V", "GetCreateOfflineRegion_Lcom_mapbox_mapboxsdk_offline_OfflineRegionDefinition_arrayBLcom_mapbox_mapboxsdk_offline_OfflineManager_CreateOfflineRegionCallback_Handler")]
		public virtual unsafe void CreateOfflineRegion (global::Com.Mapbox.Mapboxsdk.Offline.IOfflineRegionDefinition definition, byte[] metadata, global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.ICreateOfflineRegionCallback @callback)
		{
			const string __id = "createOfflineRegion.(Lcom/mapbox/mapboxsdk/offline/OfflineRegionDefinition;[BLcom/mapbox/mapboxsdk/offline/OfflineManager$CreateOfflineRegionCallback;)V";
			IntPtr native_metadata = JNIEnv.NewArray (metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((definition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) definition).Handle);
				__args [1] = new JniArgumentValue (native_metadata);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (metadata != null) {
					JNIEnv.CopyArray (native_metadata, metadata);
					JNIEnv.DeleteLocalRef (native_metadata);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/offline/OfflineManager;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager GetInstance (global::Android.Content.Context context)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/offline/OfflineManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_invalidateAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_;
#pragma warning disable 0169
		static Delegate GetInvalidateAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_Handler ()
		{
			if (cb_invalidateAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ == null)
				cb_invalidateAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InvalidateAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_);
			return cb_invalidateAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_;
		}

		static void n_InvalidateAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateAmbientCache (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='invalidateAmbientCache' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineManager.FileSourceCallback']]"
		[Register ("invalidateAmbientCache", "(Lcom/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback;)V", "GetInvalidateAmbientCache_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_Handler")]
		public virtual unsafe void InvalidateAmbientCache (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback @callback)
		{
			const string __id = "invalidateAmbientCache.(Lcom/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_listOfflineRegions_Lcom_mapbox_mapboxsdk_offline_OfflineManager_ListOfflineRegionsCallback_;
#pragma warning disable 0169
		static Delegate GetListOfflineRegions_Lcom_mapbox_mapboxsdk_offline_OfflineManager_ListOfflineRegionsCallback_Handler ()
		{
			if (cb_listOfflineRegions_Lcom_mapbox_mapboxsdk_offline_OfflineManager_ListOfflineRegionsCallback_ == null)
				cb_listOfflineRegions_Lcom_mapbox_mapboxsdk_offline_OfflineManager_ListOfflineRegionsCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ListOfflineRegions_Lcom_mapbox_mapboxsdk_offline_OfflineManager_ListOfflineRegionsCallback_);
			return cb_listOfflineRegions_Lcom_mapbox_mapboxsdk_offline_OfflineManager_ListOfflineRegionsCallback_;
		}

		static void n_ListOfflineRegions_Lcom_mapbox_mapboxsdk_offline_OfflineManager_ListOfflineRegionsCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IListOfflineRegionsCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IListOfflineRegionsCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IListOfflineRegionsCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ListOfflineRegions (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='listOfflineRegions' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineManager.ListOfflineRegionsCallback']]"
		[Register ("listOfflineRegions", "(Lcom/mapbox/mapboxsdk/offline/OfflineManager$ListOfflineRegionsCallback;)V", "GetListOfflineRegions_Lcom_mapbox_mapboxsdk_offline_OfflineManager_ListOfflineRegionsCallback_Handler")]
		public virtual unsafe void ListOfflineRegions (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IListOfflineRegionsCallback @callback)
		{
			const string __id = "listOfflineRegions.(Lcom/mapbox/mapboxsdk/offline/OfflineManager$ListOfflineRegionsCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_mergeOfflineRegions_Ljava_lang_String_Lcom_mapbox_mapboxsdk_offline_OfflineManager_MergeOfflineRegionsCallback_;
#pragma warning disable 0169
		static Delegate GetMergeOfflineRegions_Ljava_lang_String_Lcom_mapbox_mapboxsdk_offline_OfflineManager_MergeOfflineRegionsCallback_Handler ()
		{
			if (cb_mergeOfflineRegions_Ljava_lang_String_Lcom_mapbox_mapboxsdk_offline_OfflineManager_MergeOfflineRegionsCallback_ == null)
				cb_mergeOfflineRegions_Ljava_lang_String_Lcom_mapbox_mapboxsdk_offline_OfflineManager_MergeOfflineRegionsCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeOfflineRegions_Ljava_lang_String_Lcom_mapbox_mapboxsdk_offline_OfflineManager_MergeOfflineRegionsCallback_);
			return cb_mergeOfflineRegions_Ljava_lang_String_Lcom_mapbox_mapboxsdk_offline_OfflineManager_MergeOfflineRegionsCallback_;
		}

		static void n_MergeOfflineRegions_Ljava_lang_String_Lcom_mapbox_mapboxsdk_offline_OfflineManager_MergeOfflineRegionsCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IMergeOfflineRegionsCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IMergeOfflineRegionsCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IMergeOfflineRegionsCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.MergeOfflineRegions (path, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='mergeOfflineRegions' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.offline.OfflineManager.MergeOfflineRegionsCallback']]"
		[Register ("mergeOfflineRegions", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/offline/OfflineManager$MergeOfflineRegionsCallback;)V", "GetMergeOfflineRegions_Ljava_lang_String_Lcom_mapbox_mapboxsdk_offline_OfflineManager_MergeOfflineRegionsCallback_Handler")]
		public virtual unsafe void MergeOfflineRegions (string path, global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IMergeOfflineRegionsCallback @callback)
		{
			const string __id = "mergeOfflineRegions.(Ljava/lang/String;Lcom/mapbox/mapboxsdk/offline/OfflineManager$MergeOfflineRegionsCallback;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_putResourceWithUrl_Ljava_lang_String_arrayBJJLjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutResourceWithUrl_Ljava_lang_String_arrayBJJLjava_lang_String_ZHandler ()
		{
			if (cb_putResourceWithUrl_Ljava_lang_String_arrayBJJLjava_lang_String_Z == null)
				cb_putResourceWithUrl_Ljava_lang_String_arrayBJJLjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, long, IntPtr, bool>) n_PutResourceWithUrl_Ljava_lang_String_arrayBJJLjava_lang_String_Z);
			return cb_putResourceWithUrl_Ljava_lang_String_arrayBJJLjava_lang_String_Z;
		}

		static void n_PutResourceWithUrl_Ljava_lang_String_arrayBJJLjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, long p3, IntPtr native_p4, bool p5)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.PutResourceWithUrl (p0, p1, p2, p3, p4, p5);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='putResourceWithUrl' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean']]"
		[Register ("putResourceWithUrl", "(Ljava/lang/String;[BJJLjava/lang/String;Z)V", "GetPutResourceWithUrl_Ljava_lang_String_arrayBJJLjava_lang_String_ZHandler")]
		public virtual unsafe void PutResourceWithUrl (string p0, byte[] p1, long p2, long p3, string p4, bool p5)
		{
			const string __id = "putResourceWithUrl.(Ljava/lang/String;[BJJLjava/lang/String;Z)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (p5);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_resetDatabase_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_;
#pragma warning disable 0169
		static Delegate GetResetDatabase_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_Handler ()
		{
			if (cb_resetDatabase_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ == null)
				cb_resetDatabase_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResetDatabase_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_);
			return cb_resetDatabase_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_;
		}

		static void n_ResetDatabase_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ResetDatabase (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='resetDatabase' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.offline.OfflineManager.FileSourceCallback']]"
		[Register ("resetDatabase", "(Lcom/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback;)V", "GetResetDatabase_Lcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_Handler")]
		public virtual unsafe void ResetDatabase (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback @callback)
		{
			const string __id = "resetDatabase.(Lcom/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMaximumAmbientCacheSize_JLcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_;
#pragma warning disable 0169
		static Delegate GetSetMaximumAmbientCacheSize_JLcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_Handler ()
		{
			if (cb_setMaximumAmbientCacheSize_JLcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ == null)
				cb_setMaximumAmbientCacheSize_JLcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_SetMaximumAmbientCacheSize_JLcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_);
			return cb_setMaximumAmbientCacheSize_JLcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_;
		}

		static void n_SetMaximumAmbientCacheSize_JLcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_ (IntPtr jnienv, IntPtr native__this, long size, IntPtr native__callback)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback @callback = (global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetMaximumAmbientCacheSize (size, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='setMaximumAmbientCacheSize' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.mapbox.mapboxsdk.offline.OfflineManager.FileSourceCallback']]"
		[Register ("setMaximumAmbientCacheSize", "(JLcom/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback;)V", "GetSetMaximumAmbientCacheSize_JLcom_mapbox_mapboxsdk_offline_OfflineManager_FileSourceCallback_Handler")]
		public virtual unsafe void SetMaximumAmbientCacheSize (long size, global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager.IFileSourceCallback @callback)
		{
			const string __id = "setMaximumAmbientCacheSize.(JLcom/mapbox/mapboxsdk/offline/OfflineManager$FileSourceCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (size);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOfflineMapboxTileCountLimit_J;
#pragma warning disable 0169
		static Delegate GetSetOfflineMapboxTileCountLimit_JHandler ()
		{
			if (cb_setOfflineMapboxTileCountLimit_J == null)
				cb_setOfflineMapboxTileCountLimit_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetOfflineMapboxTileCountLimit_J);
			return cb_setOfflineMapboxTileCountLimit_J;
		}

		static void n_SetOfflineMapboxTileCountLimit_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOfflineMapboxTileCountLimit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineManager']/method[@name='setOfflineMapboxTileCountLimit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setOfflineMapboxTileCountLimit", "(J)V", "GetSetOfflineMapboxTileCountLimit_JHandler")]
		public virtual unsafe void SetOfflineMapboxTileCountLimit (long p0)
		{
			const string __id = "setOfflineMapboxTileCountLimit.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
