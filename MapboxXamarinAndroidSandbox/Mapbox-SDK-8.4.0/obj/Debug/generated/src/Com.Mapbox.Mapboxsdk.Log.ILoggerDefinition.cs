using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Log {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']"
	[Register ("com/mapbox/mapboxsdk/log/LoggerDefinition", "", "Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker")]
	public partial interface ILoggerDefinition : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "GetD_Ljava_lang_String_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void D (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetD_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void D (string p0, string p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "GetE_Ljava_lang_String_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void E (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void E (string p0, string p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "GetI_Ljava_lang_String_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void I (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetI_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void I (string p0, string p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;)V", "GetV_Ljava_lang_String_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void V (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetV_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void V (string p0, string p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "GetW_Ljava_lang_String_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void W (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.log']/interface[@name='LoggerDefinition']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetW_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Mapbox.Mapboxsdk.Log.ILoggerDefinitionInvoker, Mapbox-SDK-8.4.0")]
		void W (string p0, string p1, global::Java.Lang.Throwable p2);

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/log/LoggerDefinition", DoNotGenerateAcw=true)]
	internal class ILoggerDefinitionInvoker : global::Java.Lang.Object, ILoggerDefinition {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/log/LoggerDefinition", typeof (ILoggerDefinitionInvoker));

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

		public static ILoggerDefinition GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoggerDefinition> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.log.LoggerDefinition"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerDefinitionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_d_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_Ljava_lang_String_);
			return cb_d_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.D (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_d_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void D (string p0, string p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.D (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void D (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.E (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_e_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void E (string p0, string p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.E (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void E (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_i_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_i_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_i_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_Ljava_lang_String_);
			return cb_i_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_I_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.I (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_i_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void I (string p0, string p1)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_i_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_I_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.I (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void I (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_v_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_v_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_v_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_V_Ljava_lang_String_Ljava_lang_String_);
			return cb_v_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_V_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.V (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_v_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void V (string p0, string p1)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_v_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_V_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_V_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.V (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void V (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_w_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_w_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_w_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_String_Ljava_lang_String_);
			return cb_w_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_W_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.W (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_w_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void W (string p0, string p1)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_w_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_W_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Log.ILoggerDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.W (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void W (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
