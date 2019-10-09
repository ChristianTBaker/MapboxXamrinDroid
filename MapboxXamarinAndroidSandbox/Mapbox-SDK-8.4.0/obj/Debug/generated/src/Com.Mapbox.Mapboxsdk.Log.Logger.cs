using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/log/Logger", DoNotGenerateAcw=true)]
	public sealed partial class Logger : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const int Debug = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/field[@name='INFO']"
		[Register ("INFO")]
		public const int Info = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/field[@name='NONE']"
		[Register ("NONE")]
		public const int None = (int) 99;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public const int Verbose = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/field[@name='WARN']"
		[Register ("WARN")]
		public const int Warn = (int) 5;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='Logger.LogLevel']"
		[Register ("com/mapbox/mapboxsdk/log/Logger$LogLevel", "", "Com.Mapbox.Mapboxsdk.Log.Logger/ILogLevelInvoker")]
		public partial interface ILogLevel : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/log/Logger$LogLevel", DoNotGenerateAcw=true)]
		internal class ILogLevelInvoker : global::Java.Lang.Object, ILogLevel {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/log/Logger$LogLevel", typeof (ILogLevelInvoker));

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

			public static ILogLevel GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILogLevel> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.log.Logger.LogLevel"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILogLevelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Mapbox.Mapboxsdk.Log.Logger.ILogLevel __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.Logger.ILogLevel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Mapbox.Mapboxsdk.Log.Logger.ILogLevel __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.Logger.ILogLevel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Mapbox.Mapboxsdk.Log.Logger.ILogLevel __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.Logger.ILogLevel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Mapbox.Mapboxsdk.Log.Logger.ILogLevel __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.Logger.ILogLevel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/log/Logger", typeof (Logger));
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

		internal Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Logger ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string tag, string msg)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void D (string tag, string msg, global::Java.Lang.Throwable tr)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((tr == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) tr).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string tag, string msg)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (string tag, string msg, global::Java.Lang.Throwable tr)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((tr == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) tr).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void I (string tag, string msg)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void I (string tag, string msg, global::Java.Lang.Throwable tr)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((tr == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) tr).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Log (int severity, string tag, string message)
		{
			const string __id = "log.(ILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (severity);
				__args [1] = new JniArgumentValue (native_tag);
				__args [2] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='setLoggerDefinition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.log.LoggerDefinition']]"
		[Register ("setLoggerDefinition", "(Lcom/mapbox/mapboxsdk/log/LoggerDefinition;)V", "")]
		public static unsafe void SetLoggerDefinition (global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition loggerDefinition)
		{
			const string __id = "setLoggerDefinition.(Lcom/mapbox/mapboxsdk/log/LoggerDefinition;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((loggerDefinition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loggerDefinition).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='setVerbosity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setVerbosity", "(I)V", "")]
		public static unsafe void SetVerbosity ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Log.Logger", Fields = new string [] {"Verbose", "Debug", "Info", "Warn", "Error", "None"})]int logLevel)
		{
			const string __id = "setVerbosity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (logLevel);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void V (string tag, string msg)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void V (string tag, string msg, global::Java.Lang.Throwable tr)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((tr == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) tr).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void W (string tag, string msg)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/class[@name='Logger']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void W (string tag, string msg, global::Java.Lang.Throwable tr)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((tr == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) tr).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
