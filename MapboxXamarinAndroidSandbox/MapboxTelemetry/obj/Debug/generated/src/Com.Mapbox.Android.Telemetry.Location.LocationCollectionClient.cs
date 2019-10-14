using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='LocationCollectionClient']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/location/LocationCollectionClient", DoNotGenerateAcw=true)]
	public partial class LocationCollectionClient : global::Java.Lang.Object, global::Android.Content.ISharedPreferencesOnSharedPreferenceChangeListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='LocationCollectionClient']/field[@name='DEFAULT_SESSION_ROTATION_INTERVAL_HOURS']"
		[Register ("DEFAULT_SESSION_ROTATION_INTERVAL_HOURS")]
		public const int DefaultSessionRotationIntervalHours = (int) 24;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/location/LocationCollectionClient", typeof (LocationCollectionClient));
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

		protected LocationCollectionClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='LocationCollectionClient']/method[@name='install' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("install", "(Landroid/content/Context;J)Lcom/mapbox/android/telemetry/location/LocationCollectionClient;", "")]
		public static unsafe global::Com.Mapbox.Android.Telemetry.Location.LocationCollectionClient Install (global::Android.Content.Context context, long defaultInterval)
		{
			const string __id = "install.(Landroid/content/Context;J)Lcom/mapbox/android/telemetry/location/LocationCollectionClient;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (defaultInterval);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Location.LocationCollectionClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Mapbox.Android.Telemetry.Location.LocationCollectionClient __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Location.LocationCollectionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ISharedPreferences sharedPreferences = (global::Android.Content.ISharedPreferences)global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (native_sharedPreferences, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.OnSharedPreferenceChanged (sharedPreferences, key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.location']/class[@name='LocationCollectionClient']/method[@name='onSharedPreferenceChanged' and count(parameter)=2 and parameter[1][@type='android.content.SharedPreferences'] and parameter[2][@type='java.lang.String']]"
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

	}
}
