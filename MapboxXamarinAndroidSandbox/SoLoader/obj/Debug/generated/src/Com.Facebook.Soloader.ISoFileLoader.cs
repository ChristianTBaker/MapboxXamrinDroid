using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.soloader']/interface[@name='SoFileLoader']"
	[Register ("com/facebook/soloader/SoFileLoader", "", "Com.Facebook.Soloader.ISoFileLoaderInvoker")]
	public partial interface ISoFileLoader : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/interface[@name='SoFileLoader']/method[@name='load' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("load", "(Ljava/lang/String;I)V", "GetLoad_Ljava_lang_String_IHandler:Com.Facebook.Soloader.ISoFileLoaderInvoker, SoLoader")]
		void Load (string p0, int p1);

	}

	[global::Android.Runtime.Register ("com/facebook/soloader/SoFileLoader", DoNotGenerateAcw=true)]
	internal class ISoFileLoaderInvoker : global::Java.Lang.Object, ISoFileLoader {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/facebook/soloader/SoFileLoader", typeof (ISoFileLoaderInvoker));

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

		public static ISoFileLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISoFileLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.soloader.SoFileLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISoFileLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_load_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_IHandler ()
		{
			if (cb_load_Ljava_lang_String_I == null)
				cb_load_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Load_Ljava_lang_String_I);
			return cb_load_Ljava_lang_String_I;
		}

		static void n_Load_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Facebook.Soloader.ISoFileLoader __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.ISoFileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_load_Ljava_lang_String_I;
		public unsafe void Load (string p0, int p1)
		{
			if (id_load_Ljava_lang_String_I == IntPtr.Zero)
				id_load_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
