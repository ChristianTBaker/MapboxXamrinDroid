using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/Utils", DoNotGenerateAcw=true)]
	public sealed partial class Utils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/location/Utils", typeof (Utils));
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

		internal Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='Utils']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("normalize", "(F)F", "")]
		public static unsafe float Normalize (float angle)
		{
			const string __id = "normalize.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (angle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='Utils']/method[@name='shortestRotation' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("shortestRotation", "(FF)F", "")]
		public static unsafe float ShortestRotation (float heading, float previousHeading)
		{
			const string __id = "shortestRotation.(FF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (heading);
				__args [1] = new JniArgumentValue (previousHeading);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
