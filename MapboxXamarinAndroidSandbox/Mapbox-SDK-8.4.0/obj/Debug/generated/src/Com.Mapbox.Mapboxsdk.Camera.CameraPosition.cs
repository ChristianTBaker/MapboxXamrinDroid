using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/camera/CameraPosition", DoNotGenerateAcw=true)]
	public sealed partial class CameraPosition : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition Default {
			get {
				const string __id = "DEFAULT.Lcom/mapbox/mapboxsdk/camera/CameraPosition;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']/field[@name='bearing']"
		[Register ("bearing")]
		public double Bearing {
			get {
				const string __id = "bearing.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "bearing.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']/field[@name='padding']"
		[Register ("padding")]
		public IList<double> Padding {
			get {
				const string __id = "padding.[D";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "padding.[D";

				IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']/field[@name='target']"
		[Register ("target")]
		public global::Com.Mapbox.Mapboxsdk.Geometry.LatLng Target {
			get {
				const string __id = "target.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "target.Lcom/mapbox/mapboxsdk/geometry/LatLng;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']/field[@name='tilt']"
		[Register ("tilt")]
		public double Tilt {
			get {
				const string __id = "tilt.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "tilt.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']/field[@name='zoom']"
		[Register ("zoom")]
		public double Zoom {
			get {
				const string __id = "zoom.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "zoom.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/camera/CameraPosition$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/camera/CameraPosition$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/constructor[@name='CameraPosition.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/constructor[@name='CameraPosition.Builder' and count(parameter)=1 and parameter[1][@type='android.content.res.TypedArray']]"
			[Register (".ctor", "(Landroid/content/res/TypedArray;)V", "")]
			public unsafe Builder (global::Android.Content.Res.TypedArray typedArray)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/res/TypedArray;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((typedArray == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typedArray).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/constructor[@name='CameraPosition.Builder' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraPosition']]"
			[Register (".ctor", "(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)V", "")]
			public unsafe Builder (global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition previous)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((previous == null) ? IntPtr.Zero : ((global::Java.Lang.Object) previous).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/method[@name='bearing' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("bearing", "(D)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder Bearing (double bearing)
			{
				const string __id = "bearing.(D)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (bearing);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition Build ()
			{
				const string __id = "build.()Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/method[@name='padding' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
			[Register ("padding", "(DDDD)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder Padding (double left, double top, double right, double bottom)
			{
				const string __id = "padding.(DDDD)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (left);
					__args [1] = new JniArgumentValue (top);
					__args [2] = new JniArgumentValue (right);
					__args [3] = new JniArgumentValue (bottom);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/method[@name='padding' and count(parameter)=1 and parameter[1][@type='double[]']]"
			[Register ("padding", "([D)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder Padding (double[] padding)
			{
				const string __id = "padding.([D)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;";
				IntPtr native_padding = JNIEnv.NewArray (padding);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_padding);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (padding != null) {
						JNIEnv.CopyArray (native_padding, padding);
						JNIEnv.DeleteLocalRef (native_padding);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/method[@name='target' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
			[Register ("target", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder Target (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng location)
			{
				const string __id = "target.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((location == null) ? IntPtr.Zero : ((global::Java.Lang.Object) location).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/method[@name='tilt' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("tilt", "(D)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder Tilt (double tilt)
			{
				const string __id = "tilt.(D)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (tilt);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition.Builder']/method[@name='zoom' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("zoom", "(D)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder Zoom (double zoom)
			{
				const string __id = "zoom.(D)Lcom/mapbox/mapboxsdk/camera/CameraPosition$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (zoom);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/camera/CameraPosition", typeof (CameraPosition));
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

		internal CameraPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraPosition']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel @out, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
