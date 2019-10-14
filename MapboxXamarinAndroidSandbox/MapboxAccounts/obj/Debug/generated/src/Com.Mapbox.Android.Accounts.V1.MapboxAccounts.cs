using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Accounts.V1 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']"
	[global::Android.Runtime.Register ("com/mapbox/android/accounts/v1/MapboxAccounts", DoNotGenerateAcw=true)]
	public partial class MapboxAccounts : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']/field[@name='SKU_ID_MAPS_MAUS']"
		[Register ("SKU_ID_MAPS_MAUS")]
		public const string SkuIdMapsMaus = (string) "00";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']/field[@name='SKU_ID_NAVIGATION_MAUS']"
		[Register ("SKU_ID_NAVIGATION_MAUS")]
		public const string SkuIdNavigationMaus = (string) "02";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']/field[@name='SKU_ID_NAVIGATION_TRIPS']"
		[Register ("SKU_ID_NAVIGATION_TRIPS")]
		public const string SkuIdNavigationTrips = (string) "03";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/accounts/v1/MapboxAccounts", typeof (MapboxAccounts));
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

		protected MapboxAccounts (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']/constructor[@name='MapboxAccounts' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapboxAccounts ()
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

		public static unsafe long Now {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']/method[@name='getNow' and count(parameter)=0]"
			[Register ("getNow", "()J", "GetGetNowHandler")]
			get {
				const string __id = "getNow.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']/method[@name='obtainEndUserId' and count(parameter)=0]"
		[Register ("obtainEndUserId", "()Ljava/lang/String;", "")]
		public static unsafe string ObtainEndUserId ()
		{
			const string __id = "obtainEndUserId.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']/method[@name='obtainMapsSkuUserToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("obtainMapsSkuUserToken", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ObtainMapsSkuUserToken (string p0)
		{
			const string __id = "obtainMapsSkuUserToken.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']/method[@name='obtainNavigationSkuSessionToken' and count(parameter)=0]"
		[Register ("obtainNavigationSkuSessionToken", "()Ljava/lang/String;", "")]
		public static unsafe string ObtainNavigationSkuSessionToken ()
		{
			const string __id = "obtainNavigationSkuSessionToken.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.accounts.v1']/class[@name='MapboxAccounts']/method[@name='obtainNavigationSkuUserToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("obtainNavigationSkuUserToken", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ObtainNavigationSkuUserToken (string p0)
		{
			const string __id = "obtainNavigationSkuUserToken.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
