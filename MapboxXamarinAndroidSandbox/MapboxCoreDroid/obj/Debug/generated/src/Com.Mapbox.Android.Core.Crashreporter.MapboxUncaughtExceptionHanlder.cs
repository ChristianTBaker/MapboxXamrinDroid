using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Crashreporter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='MapboxUncaughtExceptionHanlder']"
	[global::Android.Runtime.Register ("com/mapbox/android/core/crashreporter/MapboxUncaughtExceptionHanlder", DoNotGenerateAcw=true)]
	public partial class MapboxUncaughtExceptionHanlder : global::Java.Lang.Object, global::Android.Content.ISharedPreferencesOnSharedPreferenceChangeListener, global::Java.Lang.Thread.IUncaughtExceptionHandler {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='MapboxUncaughtExceptionHanlder']/field[@name='MAPBOX_CRASH_REPORTER_PREFERENCES']"
		[Register ("MAPBOX_CRASH_REPORTER_PREFERENCES")]
		public const string MapboxCrashReporterPreferences = (string) "MapboxCrashReporterPrefs";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='MapboxUncaughtExceptionHanlder']/field[@name='MAPBOX_PREF_ENABLE_CRASH_REPORTER']"
		[Register ("MAPBOX_PREF_ENABLE_CRASH_REPORTER")]
		public const string MapboxPrefEnableCrashReporter = (string) "mapbox.crash.enable";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/crashreporter/MapboxUncaughtExceptionHanlder", typeof (MapboxUncaughtExceptionHanlder));
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

		protected MapboxUncaughtExceptionHanlder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='MapboxUncaughtExceptionHanlder']/method[@name='install' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("install", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Install (global::Android.Content.Context context, string mapboxPackage, string version)
		{
			const string __id = "install.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_mapboxPackage = JNIEnv.NewString (mapboxPackage);
			IntPtr native_version = JNIEnv.NewString (version);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_mapboxPackage);
				__args [2] = new JniArgumentValue (native_version);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mapboxPackage);
				JNIEnv.DeleteLocalRef (native_version);
			}
		}

		static Delegate cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_Handler ()
		{
			if (cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ == null)
				cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_);
			return cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_;
		}

		static void n_OnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sharedPreferences, IntPtr native_key)
		{
			global::Com.Mapbox.Android.Core.Crashreporter.MapboxUncaughtExceptionHanlder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Crashreporter.MapboxUncaughtExceptionHanlder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ISharedPreferences sharedPreferences = (global::Android.Content.ISharedPreferences)global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (native_sharedPreferences, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.OnSharedPreferenceChanged (sharedPreferences, key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='MapboxUncaughtExceptionHanlder']/method[@name='onSharedPreferenceChanged' and count(parameter)=2 and parameter[1][@type='android.content.SharedPreferences'] and parameter[2][@type='java.lang.String']]"
		[Register ("onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V", "GetOnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_Handler")]
		public virtual unsafe void OnSharedPreferenceChanged (global::Android.Content.ISharedPreferences sharedPreferences, string key)
		{
			const string __id = "onSharedPreferenceChanged.(Landroid/content/SharedPreferences;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sharedPreferences == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedPreferences).Handle);
				__args [1] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler ()
		{
			if (cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
				cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_);
			return cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		static void n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_throwable)
		{
			global::Com.Mapbox.Android.Core.Crashreporter.MapboxUncaughtExceptionHanlder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Crashreporter.MapboxUncaughtExceptionHanlder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_thread, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			__this.UncaughtException (thread, throwable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.crashreporter']/class[@name='MapboxUncaughtExceptionHanlder']/method[@name='uncaughtException' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void UncaughtException (global::Java.Lang.Thread thread, global::Java.Lang.Throwable throwable)
		{
			const string __id = "uncaughtException.(Ljava/lang/Thread;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
