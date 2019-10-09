using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Polyline']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/Polyline", DoNotGenerateAcw=true)]
	public sealed partial class Polyline : global::Com.Mapbox.Mapboxsdk.Annotations.BasePointCollection {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/Polyline", typeof (Polyline));
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

		internal Polyline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Polyline']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Polyline']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				const string __id = "setColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Polyline']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='Polyline']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWidth", "(F)V", "GetSetWidth_FHandler")]
			set {
				const string __id = "setWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
