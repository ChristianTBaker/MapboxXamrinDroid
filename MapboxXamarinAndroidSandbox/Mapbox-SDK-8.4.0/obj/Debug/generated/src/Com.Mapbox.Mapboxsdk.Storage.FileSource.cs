using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/storage/FileSource", DoNotGenerateAcw=true)]
	public partial class FileSource : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/interface[@name='FileSource.ResourcesCachePathChangeCallback']"
		[Register ("com/mapbox/mapboxsdk/storage/FileSource$ResourcesCachePathChangeCallback", "", "Com.Mapbox.Mapboxsdk.Storage.FileSource/IResourcesCachePathChangeCallbackInvoker")]
		public partial interface IResourcesCachePathChangeCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/interface[@name='FileSource.ResourcesCachePathChangeCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Storage.FileSource/IResourcesCachePathChangeCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/interface[@name='FileSource.ResourcesCachePathChangeCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Storage.FileSource/IResourcesCachePathChangeCallbackInvoker, Mapbox-SDK-8.4.0")]
			void OnSuccess (string p0);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/storage/FileSource$ResourcesCachePathChangeCallback", DoNotGenerateAcw=true)]
		internal class IResourcesCachePathChangeCallbackInvoker : global::Java.Lang.Object, IResourcesCachePathChangeCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/storage/FileSource$ResourcesCachePathChangeCallback", typeof (IResourcesCachePathChangeCallbackInvoker));

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

			public static IResourcesCachePathChangeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResourcesCachePathChangeCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.storage.FileSource.ResourcesCachePathChangeCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResourcesCachePathChangeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourcesCachePathChangeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourcesCachePathChangeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_String_ == null)
					cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
				return cb_onSuccess_Ljava_lang_String_;
			}

			static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourcesCachePathChangeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourcesCachePathChangeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Ljava_lang_String_;
			public unsafe void OnSuccess (string p0)
			{
				if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
					id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/interface[@name='FileSource.ResourceTransformCallback']"
		[Register ("com/mapbox/mapboxsdk/storage/FileSource$ResourceTransformCallback", "", "Com.Mapbox.Mapboxsdk.Storage.FileSource/IResourceTransformCallbackInvoker")]
		public partial interface IResourceTransformCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/interface[@name='FileSource.ResourceTransformCallback']/method[@name='onURL' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onURL", "(ILjava/lang/String;)Ljava/lang/String;", "GetOnURL_ILjava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Storage.FileSource/IResourceTransformCallbackInvoker, Mapbox-SDK-8.4.0")]
			string OnURL (int p0, string p1);

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/storage/FileSource$ResourceTransformCallback", DoNotGenerateAcw=true)]
		internal class IResourceTransformCallbackInvoker : global::Java.Lang.Object, IResourceTransformCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/storage/FileSource$ResourceTransformCallback", typeof (IResourceTransformCallbackInvoker));

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

			public static IResourceTransformCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResourceTransformCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.storage.FileSource.ResourceTransformCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResourceTransformCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onURL_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnURL_ILjava_lang_String_Handler ()
			{
				if (cb_onURL_ILjava_lang_String_ == null)
					cb_onURL_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnURL_ILjava_lang_String_);
				return cb_onURL_ILjava_lang_String_;
			}

			static IntPtr n_OnURL_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourceTransformCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourceTransformCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.OnURL (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onURL_ILjava_lang_String_;
			public unsafe string OnURL (int p0, string p1)
			{
				if (id_onURL_ILjava_lang_String_ == IntPtr.Zero)
					id_onURL_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onURL", "(ILjava/lang/String;)Ljava/lang/String;");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onURL_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/storage/FileSource", typeof (FileSource));
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

		protected FileSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Storage.FileSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessToken_Ljava_lang_String_ == null)
				cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_);
			return cb_setAccessToken_Ljava_lang_String_;
		}

		static void n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Storage.FileSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AccessToken = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				const string __id = "getAccessToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)V", "GetSetAccessToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccessToken.(Ljava/lang/String;)V";
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

		static Delegate cb_isActivated;
#pragma warning disable 0169
		static Delegate GetIsActivatedHandler ()
		{
			if (cb_isActivated == null)
				cb_isActivated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActivated);
			return cb_isActivated;
		}

		static bool n_IsActivated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Storage.FileSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActivated;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsActivated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='isActivated' and count(parameter)=0]"
			[Register ("isActivated", "()Z", "GetIsActivatedHandler")]
			get {
				const string __id = "isActivated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsExternalStorageReadable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='isExternalStorageReadable' and count(parameter)=0]"
			[Register ("isExternalStorageReadable", "()Z", "GetIsExternalStorageReadableHandler")]
			get {
				const string __id = "isExternalStorageReadable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_activate;
#pragma warning disable 0169
		static Delegate GetActivateHandler ()
		{
			if (cb_activate == null)
				cb_activate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Activate);
			return cb_activate;
		}

		static void n_Activate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Storage.FileSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Activate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='activate' and count(parameter)=0]"
		[Register ("activate", "()V", "GetActivateHandler")]
		public virtual unsafe void Activate ()
		{
			const string __id = "activate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_deactivate;
#pragma warning disable 0169
		static Delegate GetDeactivateHandler ()
		{
			if (cb_deactivate == null)
				cb_deactivate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Deactivate);
			return cb_deactivate;
		}

		static void n_Deactivate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Storage.FileSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deactivate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='deactivate' and count(parameter)=0]"
		[Register ("deactivate", "()V", "GetDeactivateHandler")]
		public virtual unsafe void Deactivate ()
		{
			const string __id = "deactivate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/storage/FileSource;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Storage.FileSource GetInstance (global::Android.Content.Context context)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/mapbox/mapboxsdk/storage/FileSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='getInternalCachePath' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInternalCachePath", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetInternalCachePath (global::Android.Content.Context context)
		{
			const string __id = "getInternalCachePath.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='getResourcesCachePath' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getResourcesCachePath", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetResourcesCachePath (global::Android.Content.Context context)
		{
			const string __id = "getResourcesCachePath.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='initializeFileDirsPaths' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initializeFileDirsPaths", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitializeFileDirsPaths (global::Android.Content.Context context)
		{
			const string __id = "initializeFileDirsPaths.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_setApiBaseUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApiBaseUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setApiBaseUrl_Ljava_lang_String_ == null)
				cb_setApiBaseUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApiBaseUrl_Ljava_lang_String_);
			return cb_setApiBaseUrl_Ljava_lang_String_;
		}

		static void n_SetApiBaseUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Storage.FileSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetApiBaseUrl (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='setApiBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setApiBaseUrl", "(Ljava/lang/String;)V", "GetSetApiBaseUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetApiBaseUrl (string p0)
		{
			const string __id = "setApiBaseUrl.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setResourceTransform_Lcom_mapbox_mapboxsdk_storage_FileSource_ResourceTransformCallback_;
#pragma warning disable 0169
		static Delegate GetSetResourceTransform_Lcom_mapbox_mapboxsdk_storage_FileSource_ResourceTransformCallback_Handler ()
		{
			if (cb_setResourceTransform_Lcom_mapbox_mapboxsdk_storage_FileSource_ResourceTransformCallback_ == null)
				cb_setResourceTransform_Lcom_mapbox_mapboxsdk_storage_FileSource_ResourceTransformCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResourceTransform_Lcom_mapbox_mapboxsdk_storage_FileSource_ResourceTransformCallback_);
			return cb_setResourceTransform_Lcom_mapbox_mapboxsdk_storage_FileSource_ResourceTransformCallback_;
		}

		static void n_SetResourceTransform_Lcom_mapbox_mapboxsdk_storage_FileSource_ResourceTransformCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Storage.FileSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourceTransformCallback p0 = (global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourceTransformCallback)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourceTransformCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResourceTransform (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='setResourceTransform' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.storage.FileSource.ResourceTransformCallback']]"
		[Register ("setResourceTransform", "(Lcom/mapbox/mapboxsdk/storage/FileSource$ResourceTransformCallback;)V", "GetSetResourceTransform_Lcom_mapbox_mapboxsdk_storage_FileSource_ResourceTransformCallback_Handler")]
		public virtual unsafe void SetResourceTransform (global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourceTransformCallback p0)
		{
			const string __id = "setResourceTransform.(Lcom/mapbox/mapboxsdk/storage/FileSource$ResourceTransformCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='setResourcesCachePath' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mapbox.mapboxsdk.storage.FileSource.ResourcesCachePathChangeCallback']]"
		[Obsolete (@"deprecated")]
		[Register ("setResourcesCachePath", "(Landroid/content/Context;Ljava/lang/String;Lcom/mapbox/mapboxsdk/storage/FileSource$ResourcesCachePathChangeCallback;)V", "")]
		public static unsafe void SetResourcesCachePath (global::Android.Content.Context context, string path, global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourcesCachePathChangeCallback @callback)
		{
			const string __id = "setResourcesCachePath.(Landroid/content/Context;Ljava/lang/String;Lcom/mapbox/mapboxsdk/storage/FileSource$ResourcesCachePathChangeCallback;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.storage']/class[@name='FileSource']/method[@name='setResourcesCachePath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.storage.FileSource.ResourcesCachePathChangeCallback']]"
		[Register ("setResourcesCachePath", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/storage/FileSource$ResourcesCachePathChangeCallback;)V", "")]
		public static unsafe void SetResourcesCachePath (string path, global::Com.Mapbox.Mapboxsdk.Storage.FileSource.IResourcesCachePathChangeCallback @callback)
		{
			const string __id = "setResourcesCachePath.(Ljava/lang/String;Lcom/mapbox/mapboxsdk/storage/FileSource$ResourcesCachePathChangeCallback;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

	}
}
