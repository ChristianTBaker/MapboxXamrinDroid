using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/BuildConfig", DoNotGenerateAcw=true)]
	public sealed partial class BuildConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='APPLICATION_ID']"
		[Register ("APPLICATION_ID")]
		[Obsolete ("deprecated")]
		public const string ApplicationId = (string) "com.mapbox.mapboxsdk";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='BUILD_TYPE']"
		[Register ("BUILD_TYPE")]
		public const string BuildType = (string) "release";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const bool Debug = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='FLAVOR']"
		[Register ("FLAVOR")]
		public const string Flavor = (string) "";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='GIT_REVISION_SHORT']"
		[Register ("GIT_REVISION_SHORT")]
		public const string GitRevisionShort = (string) "c0f3031";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='LIBRARY_PACKAGE_NAME']"
		[Register ("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = (string) "com.mapbox.mapboxsdk";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='MAPBOX_EVENTS_USER_AGENT']"
		[Register ("MAPBOX_EVENTS_USER_AGENT")]
		public const string MapboxEventsUserAgent = (string) "mapbox-maps-android/8.4.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='MAPBOX_SDK_IDENTIFIER']"
		[Register ("MAPBOX_SDK_IDENTIFIER")]
		public const string MapboxSdkIdentifier = (string) "mapbox-maps-android";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='MAPBOX_SDK_VERSION']"
		[Register ("MAPBOX_SDK_VERSION")]
		public const string MapboxSdkVersion = (string) "8.4.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='MAPBOX_VERSION_STRING']"
		[Register ("MAPBOX_VERSION_STRING")]
		public const string MapboxVersionString = (string) "Mapbox/8.4.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='VERSION_CODE']"
		[Register ("VERSION_CODE")]
		public const int VersionCode = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/field[@name='VERSION_NAME']"
		[Register ("VERSION_NAME")]
		public const string VersionName = (string) "";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/BuildConfig", typeof (BuildConfig));
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

		internal BuildConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='BuildConfig']/constructor[@name='BuildConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BuildConfig ()
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

	}
}
