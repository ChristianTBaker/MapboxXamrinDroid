using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineProvider']"
	[global::Android.Runtime.Register ("com/mapbox/android/core/location/LocationEngineProvider", DoNotGenerateAcw=true)]
	public sealed partial class LocationEngineProvider : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/location/LocationEngineProvider", typeof (LocationEngineProvider));
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

		internal LocationEngineProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineProvider']/method[@name='getBestLocationEngine' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBestLocationEngine", "(Landroid/content/Context;)Lcom/mapbox/android/core/location/LocationEngine;", "")]
		public static unsafe global::Com.Mapbox.Android.Core.Location.ILocationEngine GetBestLocationEngine (global::Android.Content.Context context)
		{
			const string __id = "getBestLocationEngine.(Landroid/content/Context;)Lcom/mapbox/android/core/location/LocationEngine;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineProvider']/method[@name='getBestLocationEngine' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("getBestLocationEngine", "(Landroid/content/Context;Z)Lcom/mapbox/android/core/location/LocationEngine;", "")]
		public static unsafe global::Com.Mapbox.Android.Core.Location.ILocationEngine GetBestLocationEngine (global::Android.Content.Context context, bool background)
		{
			const string __id = "getBestLocationEngine.(Landroid/content/Context;Z)Lcom/mapbox/android/core/location/LocationEngine;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (background);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.ILocationEngine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
