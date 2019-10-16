using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/PolygonOptions", DoNotGenerateAcw=true)]
	public sealed partial class PolygonOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/PolygonOptions", typeof (PolygonOptions));
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

		internal PolygonOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/constructor[@name='PolygonOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PolygonOptions ()
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

		public unsafe float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				const string __id = "getAlpha.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				const string __id = "getFillColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>> Holes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='getHoles' and count(parameter)=0]"
			[Register ("getHoles", "()Ljava/util/List;", "GetGetHolesHandler")]
			get {
				const string __id = "getHoles.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				const string __id = "getPoints.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.Polygon Polygon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='getPolygon' and count(parameter)=0]"
			[Register ("getPolygon", "()Lcom/mapbox/mapboxsdk/annotations/Polygon;", "GetGetPolygonHandler")]
			get {
				const string __id = "getPolygon.()Lcom/mapbox/mapboxsdk/annotations/Polygon;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.Polygon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				const string __id = "getStrokeColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("add", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions Add (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng point)
		{
			const string __id = "add.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((point == null) ? IntPtr.Zero : ((global::Java.Lang.Object) point).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng...']]"
		[Register ("add", "([Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions Add (params global::Com.Mapbox.Mapboxsdk.Geometry.LatLng[] points)
		{
			const string __id = "add.([Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;";
			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_points);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;com.mapbox.mapboxsdk.geometry.LatLng&gt;']]"
		[Register ("addAll", "(Ljava/lang/Iterable;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions AddAll (global::Java.Lang.IIterable points)
		{
			const string __id = "addAll.(Ljava/lang/Iterable;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((points == null) ? IntPtr.Zero : ((global::Java.Lang.Object) points).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='addAllHoles' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;java.util.List&lt;com.mapbox.mapboxsdk.geometry.LatLng&gt;&gt;']]"
		[Register ("addAllHoles", "(Ljava/lang/Iterable;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions AddAllHoles (global::Java.Lang.IIterable holes)
		{
			const string __id = "addAllHoles.(Ljava/lang/Iterable;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holes).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='addHole' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.mapboxsdk.geometry.LatLng&gt;']]"
		[Register ("addHole", "(Ljava/util/List;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions AddHole (global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> hole)
		{
			const string __id = "addHole.(Ljava/util/List;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;";
			IntPtr native_hole = global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>.ToLocalJniHandle (hole);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hole);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hole);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='alpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alpha", "(F)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions InvokeAlpha (float alpha)
		{
			const string __id = "alpha.(F)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='describeContents' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='fillColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fillColor", "(I)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions InvokeFillColor (int color)
		{
			const string __id = "fillColor.(I)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='strokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("strokeColor", "(I)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions InvokeStrokeColor (int color)
		{
			const string __id = "strokeColor.(I)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
