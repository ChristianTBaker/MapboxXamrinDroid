using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils.CheckFileReadPermissionTask']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/FileUtils$CheckFileReadPermissionTask", DoNotGenerateAcw=true)]
		public partial class CheckFileReadPermissionTask : global::Android.OS.AsyncTask {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/FileUtils$CheckFileReadPermissionTask", typeof (CheckFileReadPermissionTask));
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

			protected CheckFileReadPermissionTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils.CheckFileReadPermissionTask']/constructor[@name='FileUtils.CheckFileReadPermissionTask' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.utils.FileUtils.OnCheckFileReadPermissionListener']]"
			[Register (".ctor", "(Lcom/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileReadPermissionListener;)V", "")]
			public unsafe CheckFileReadPermissionTask (global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileReadPermissionListener listener)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileReadPermissionListener;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_doInBackground_arrayLjava_io_File_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_io_File_Handler ()
			{
				if (cb_doInBackground_arrayLjava_io_File_ == null)
					cb_doInBackground_arrayLjava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_io_File_);
				return cb_doInBackground_arrayLjava_io_File_;
			}

			static IntPtr n_DoInBackground_arrayLjava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_files)
			{
				global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.CheckFileReadPermissionTask __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.CheckFileReadPermissionTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.IO.File[] files = (global::Java.IO.File[]) JNIEnv.GetArray (native_files, JniHandleOwnership.DoNotTransfer, typeof (global::Java.IO.File));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (files));
				if (files != null)
					JNIEnv.CopyArray (files, native_files);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils.CheckFileReadPermissionTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.io.File...']]"
			[Register ("doInBackground", "([Ljava/io/File;)Ljava/lang/Boolean;", "GetDoInBackground_arrayLjava_io_File_Handler")]
			protected virtual unsafe global::Java.Lang.Boolean DoInBackground (params global::Java.IO.File[] files)
			{
				const string __id = "doInBackground.([Ljava/io/File;)Ljava/lang/Boolean;";
				IntPtr native_files = JNIEnv.NewArray (files);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_files);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (files != null) {
						JNIEnv.CopyArray (native_files, files);
						JNIEnv.DeleteLocalRef (native_files);
					}
				}
			}

			static Delegate cb_onPostExecute_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Ljava_lang_Boolean_Handler ()
			{
				if (cb_onPostExecute_Ljava_lang_Boolean_ == null)
					cb_onPostExecute_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Boolean_);
				return cb_onPostExecute_Ljava_lang_Boolean_;
			}

			static void n_OnPostExecute_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
			{
				global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.CheckFileReadPermissionTask __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.CheckFileReadPermissionTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean result = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils.CheckFileReadPermissionTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("onPostExecute", "(Ljava/lang/Boolean;)V", "GetOnPostExecute_Ljava_lang_Boolean_Handler")]
			protected virtual unsafe void OnPostExecute (global::Java.Lang.Boolean result)
			{
				const string __id = "onPostExecute.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils.CheckFileWritePermissionTask']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/FileUtils$CheckFileWritePermissionTask", DoNotGenerateAcw=true)]
		public partial class CheckFileWritePermissionTask : global::Android.OS.AsyncTask {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/FileUtils$CheckFileWritePermissionTask", typeof (CheckFileWritePermissionTask));
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

			protected CheckFileWritePermissionTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils.CheckFileWritePermissionTask']/constructor[@name='FileUtils.CheckFileWritePermissionTask' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.utils.FileUtils.OnCheckFileWritePermissionListener']]"
			[Register (".ctor", "(Lcom/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileWritePermissionListener;)V", "")]
			public unsafe CheckFileWritePermissionTask (global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileWritePermissionListener listener)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileWritePermissionListener;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_doInBackground_arrayLjava_io_File_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_io_File_Handler ()
			{
				if (cb_doInBackground_arrayLjava_io_File_ == null)
					cb_doInBackground_arrayLjava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_io_File_);
				return cb_doInBackground_arrayLjava_io_File_;
			}

			static IntPtr n_DoInBackground_arrayLjava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_files)
			{
				global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.CheckFileWritePermissionTask __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.CheckFileWritePermissionTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.IO.File[] files = (global::Java.IO.File[]) JNIEnv.GetArray (native_files, JniHandleOwnership.DoNotTransfer, typeof (global::Java.IO.File));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (files));
				if (files != null)
					JNIEnv.CopyArray (files, native_files);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils.CheckFileWritePermissionTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.io.File...']]"
			[Register ("doInBackground", "([Ljava/io/File;)Ljava/lang/Boolean;", "GetDoInBackground_arrayLjava_io_File_Handler")]
			protected virtual unsafe global::Java.Lang.Boolean DoInBackground (params global::Java.IO.File[] files)
			{
				const string __id = "doInBackground.([Ljava/io/File;)Ljava/lang/Boolean;";
				IntPtr native_files = JNIEnv.NewArray (files);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_files);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (files != null) {
						JNIEnv.CopyArray (native_files, files);
						JNIEnv.DeleteLocalRef (native_files);
					}
				}
			}

			static Delegate cb_onPostExecute_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Ljava_lang_Boolean_Handler ()
			{
				if (cb_onPostExecute_Ljava_lang_Boolean_ == null)
					cb_onPostExecute_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Boolean_);
				return cb_onPostExecute_Ljava_lang_Boolean_;
			}

			static void n_OnPostExecute_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
			{
				global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.CheckFileWritePermissionTask __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.CheckFileWritePermissionTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean result = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (result);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils.CheckFileWritePermissionTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("onPostExecute", "(Ljava/lang/Boolean;)V", "GetOnPostExecute_Ljava_lang_Boolean_Handler")]
			protected virtual unsafe void OnPostExecute (global::Java.Lang.Boolean result)
			{
				const string __id = "onPostExecute.(Ljava/lang/Boolean;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/interface[@name='FileUtils.OnCheckFileReadPermissionListener']"
		[Register ("com/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileReadPermissionListener", "", "Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileReadPermissionListenerInvoker")]
		public partial interface IOnCheckFileReadPermissionListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/interface[@name='FileUtils.OnCheckFileReadPermissionListener']/method[@name='onError' and count(parameter)=0]"
			[Register ("onError", "()V", "GetOnErrorHandler:Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileReadPermissionListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnError ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/interface[@name='FileUtils.OnCheckFileReadPermissionListener']/method[@name='onReadPermissionGranted' and count(parameter)=0]"
			[Register ("onReadPermissionGranted", "()V", "GetOnReadPermissionGrantedHandler:Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileReadPermissionListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnReadPermissionGranted ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileReadPermissionListener", DoNotGenerateAcw=true)]
		internal class IOnCheckFileReadPermissionListenerInvoker : global::Java.Lang.Object, IOnCheckFileReadPermissionListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileReadPermissionListener", typeof (IOnCheckFileReadPermissionListenerInvoker));

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

			public static IOnCheckFileReadPermissionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCheckFileReadPermissionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.utils.FileUtils.OnCheckFileReadPermissionListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCheckFileReadPermissionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError;
#pragma warning disable 0169
			static Delegate GetOnErrorHandler ()
			{
				if (cb_onError == null)
					cb_onError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnError);
				return cb_onError;
			}

			static void n_OnError (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileReadPermissionListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileReadPermissionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnError ();
			}
#pragma warning restore 0169

			IntPtr id_onError;
			public unsafe void OnError ()
			{
				if (id_onError == IntPtr.Zero)
					id_onError = JNIEnv.GetMethodID (class_ref, "onError", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError);
			}

			static Delegate cb_onReadPermissionGranted;
#pragma warning disable 0169
			static Delegate GetOnReadPermissionGrantedHandler ()
			{
				if (cb_onReadPermissionGranted == null)
					cb_onReadPermissionGranted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnReadPermissionGranted);
				return cb_onReadPermissionGranted;
			}

			static void n_OnReadPermissionGranted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileReadPermissionListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileReadPermissionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnReadPermissionGranted ();
			}
#pragma warning restore 0169

			IntPtr id_onReadPermissionGranted;
			public unsafe void OnReadPermissionGranted ()
			{
				if (id_onReadPermissionGranted == IntPtr.Zero)
					id_onReadPermissionGranted = JNIEnv.GetMethodID (class_ref, "onReadPermissionGranted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadPermissionGranted);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/utils/FileUtils_OnCheckFileReadPermissionListenerImplementor")]
		internal sealed partial class IOnCheckFileReadPermissionListenerImplementor : global::Java.Lang.Object, IOnCheckFileReadPermissionListener {

			object sender;

			public IOnCheckFileReadPermissionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/utils/FileUtils_OnCheckFileReadPermissionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnErrorHandler;
#pragma warning restore 0649

			public void OnError ()
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnReadPermissionGrantedHandler;
#pragma warning restore 0649

			public void OnReadPermissionGranted ()
			{
				var __h = OnReadPermissionGrantedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnCheckFileReadPermissionListenerImplementor value)
			{
				return value.OnErrorHandler == null && value.OnReadPermissionGrantedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/interface[@name='FileUtils.OnCheckFileWritePermissionListener']"
		[Register ("com/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileWritePermissionListener", "", "Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileWritePermissionListenerInvoker")]
		public partial interface IOnCheckFileWritePermissionListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/interface[@name='FileUtils.OnCheckFileWritePermissionListener']/method[@name='onError' and count(parameter)=0]"
			[Register ("onError", "()V", "GetOnErrorHandler:Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileWritePermissionListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnError ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/interface[@name='FileUtils.OnCheckFileWritePermissionListener']/method[@name='onWritePermissionGranted' and count(parameter)=0]"
			[Register ("onWritePermissionGranted", "()V", "GetOnWritePermissionGrantedHandler:Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileWritePermissionListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnWritePermissionGranted ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileWritePermissionListener", DoNotGenerateAcw=true)]
		internal class IOnCheckFileWritePermissionListenerInvoker : global::Java.Lang.Object, IOnCheckFileWritePermissionListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/utils/FileUtils$OnCheckFileWritePermissionListener", typeof (IOnCheckFileWritePermissionListenerInvoker));

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

			public static IOnCheckFileWritePermissionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCheckFileWritePermissionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.utils.FileUtils.OnCheckFileWritePermissionListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCheckFileWritePermissionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError;
#pragma warning disable 0169
			static Delegate GetOnErrorHandler ()
			{
				if (cb_onError == null)
					cb_onError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnError);
				return cb_onError;
			}

			static void n_OnError (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileWritePermissionListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileWritePermissionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnError ();
			}
#pragma warning restore 0169

			IntPtr id_onError;
			public unsafe void OnError ()
			{
				if (id_onError == IntPtr.Zero)
					id_onError = JNIEnv.GetMethodID (class_ref, "onError", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError);
			}

			static Delegate cb_onWritePermissionGranted;
#pragma warning disable 0169
			static Delegate GetOnWritePermissionGrantedHandler ()
			{
				if (cb_onWritePermissionGranted == null)
					cb_onWritePermissionGranted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWritePermissionGranted);
				return cb_onWritePermissionGranted;
			}

			static void n_OnWritePermissionGranted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileWritePermissionListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Utils.FileUtils.IOnCheckFileWritePermissionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWritePermissionGranted ();
			}
#pragma warning restore 0169

			IntPtr id_onWritePermissionGranted;
			public unsafe void OnWritePermissionGranted ()
			{
				if (id_onWritePermissionGranted == IntPtr.Zero)
					id_onWritePermissionGranted = JNIEnv.GetMethodID (class_ref, "onWritePermissionGranted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWritePermissionGranted);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/utils/FileUtils_OnCheckFileWritePermissionListenerImplementor")]
		internal sealed partial class IOnCheckFileWritePermissionListenerImplementor : global::Java.Lang.Object, IOnCheckFileWritePermissionListener {

			object sender;

			public IOnCheckFileWritePermissionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/utils/FileUtils_OnCheckFileWritePermissionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnErrorHandler;
#pragma warning restore 0649

			public void OnError ()
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnWritePermissionGrantedHandler;
#pragma warning restore 0649

			public void OnWritePermissionGranted ()
			{
				var __h = OnWritePermissionGrantedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnCheckFileWritePermissionListenerImplementor value)
			{
				return value.OnErrorHandler == null && value.OnWritePermissionGrantedHandler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/FileUtils", typeof (FileUtils));
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

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils']/constructor[@name='FileUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='FileUtils']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFile", "(Ljava/lang/String;)V", "")]
		public static unsafe void DeleteFile (string path)
		{
			const string __id = "deleteFile.(Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

	}
}
