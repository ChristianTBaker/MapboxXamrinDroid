using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory", DoNotGenerateAcw=true)]
	public sealed partial class CameraUpdateFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraBoundsUpdate']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory$CameraBoundsUpdate", DoNotGenerateAcw=true)]
		public sealed partial class CameraBoundsUpdate : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory$CameraBoundsUpdate", typeof (CameraBoundsUpdate));
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

			internal CameraBoundsUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Bounds {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraBoundsUpdate']/method[@name='getBounds' and count(parameter)=0]"
				[Register ("getBounds", "()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "GetGetBoundsHandler")]
				get {
					const string __id = "getBounds.()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraBoundsUpdate']/method[@name='getCameraPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
			[Register ("getCameraPosition", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraPosition (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap)
			{
				const string __id = "getCameraPosition.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraBoundsUpdate']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()[I", "")]
			public unsafe int[] GetPadding ()
			{
				const string __id = "getPadding.()[I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraMoveUpdate']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory$CameraMoveUpdate", DoNotGenerateAcw=true)]
		public sealed partial class CameraMoveUpdate : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory$CameraMoveUpdate", typeof (CameraMoveUpdate));
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

			internal CameraMoveUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraMoveUpdate']/method[@name='getCameraPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
			[Register ("getCameraPosition", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraPosition (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap)
			{
				const string __id = "getCameraPosition.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraPositionUpdate']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory$CameraPositionUpdate", DoNotGenerateAcw=true)]
		public sealed partial class CameraPositionUpdate : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory$CameraPositionUpdate", typeof (CameraPositionUpdate));
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

			internal CameraPositionUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe double Bearing {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraPositionUpdate']/method[@name='getBearing' and count(parameter)=0]"
				[Register ("getBearing", "()D", "GetGetBearingHandler")]
				get {
					const string __id = "getBearing.()D";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng Target {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraPositionUpdate']/method[@name='getTarget' and count(parameter)=0]"
				[Register ("getTarget", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetTargetHandler")]
				get {
					const string __id = "getTarget.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe double Tilt {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraPositionUpdate']/method[@name='getTilt' and count(parameter)=0]"
				[Register ("getTilt", "()D", "GetGetTiltHandler")]
				get {
					const string __id = "getTilt.()D";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe double Zoom {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraPositionUpdate']/method[@name='getZoom' and count(parameter)=0]"
				[Register ("getZoom", "()D", "GetGetZoomHandler")]
				get {
					const string __id = "getZoom.()D";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraPositionUpdate']/method[@name='getCameraPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
			[Register ("getCameraPosition", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraPosition (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap)
			{
				const string __id = "getCameraPosition.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.CameraPositionUpdate']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()[D", "")]
			public unsafe double[] GetPadding ()
			{
				const string __id = "getPadding.()[D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.ZoomUpdate']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory$ZoomUpdate", DoNotGenerateAcw=true)]
		public sealed partial class ZoomUpdate : global::Java.Lang.Object, global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory$ZoomUpdate", typeof (ZoomUpdate));
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

			internal ZoomUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.ZoomUpdate']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()I", "GetGetTypeHandler")]
				get {
					const string __id = "getType.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe double Zoom {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.ZoomUpdate']/method[@name='getZoom' and count(parameter)=0]"
				[Register ("getZoom", "()D", "GetGetZoomHandler")]
				get {
					const string __id = "getZoom.()D";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.ZoomUpdate']/method[@name='getCameraPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap']]"
			[Register ("getCameraPosition", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition GetCameraPosition (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap)
			{
				const string __id = "getCameraPosition.(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)Lcom/mapbox/mapboxsdk/camera/CameraPosition;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.ZoomUpdate']/method[@name='getX' and count(parameter)=0]"
			[Register ("getX", "()F", "")]
			public unsafe float GetX ()
			{
				const string __id = "getX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory.ZoomUpdate']/method[@name='getY' and count(parameter)=0]"
			[Register ("getY", "()F", "")]
			public unsafe float GetY ()
			{
				const string __id = "getY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/camera/CameraUpdateFactory", typeof (CameraUpdateFactory));
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

		internal CameraUpdateFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/constructor[@name='CameraUpdateFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CameraUpdateFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='bearingTo' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("bearingTo", "(D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate BearingTo (double bearing)
		{
			const string __id = "bearingTo.(D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bearing);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='newCameraPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.camera.CameraPosition']]"
		[Register ("newCameraPosition", "(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate NewCameraPosition (global::Com.Mapbox.Mapboxsdk.Camera.CameraPosition cameraPosition)
		{
			const string __id = "newCameraPosition.(Lcom/mapbox/mapboxsdk/camera/CameraPosition;)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cameraPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cameraPosition).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='newLatLng' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("newLatLng", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate NewLatLng (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng)
		{
			const string __id = "newLatLng.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((latLng == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLng).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=4 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;DDI)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate NewLatLngBounds (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds bounds, double bearing, double tilt, int padding)
		{
			const string __id = "newLatLngBounds.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;DDI)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((bounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bounds).Handle);
				__args [1] = new JniArgumentValue (bearing);
				__args [2] = new JniArgumentValue (tilt);
				__args [3] = new JniArgumentValue (padding);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=7 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;DDIIII)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate NewLatLngBounds (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds bounds, double bearing, double tilt, int paddingLeft, int paddingTop, int paddingRight, int paddingBottom)
		{
			const string __id = "newLatLngBounds.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;DDIIII)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((bounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bounds).Handle);
				__args [1] = new JniArgumentValue (bearing);
				__args [2] = new JniArgumentValue (tilt);
				__args [3] = new JniArgumentValue (paddingLeft);
				__args [4] = new JniArgumentValue (paddingTop);
				__args [5] = new JniArgumentValue (paddingRight);
				__args [6] = new JniArgumentValue (paddingBottom);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds'] and parameter[2][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;I)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate NewLatLngBounds (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds bounds, int padding)
		{
			const string __id = "newLatLngBounds.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;I)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bounds).Handle);
				__args [1] = new JniArgumentValue (padding);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=5 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;IIII)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate NewLatLngBounds (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds bounds, int paddingLeft, int paddingTop, int paddingRight, int paddingBottom)
		{
			const string __id = "newLatLngBounds.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;IIII)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((bounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bounds).Handle);
				__args [1] = new JniArgumentValue (paddingLeft);
				__args [2] = new JniArgumentValue (paddingTop);
				__args [3] = new JniArgumentValue (paddingRight);
				__args [4] = new JniArgumentValue (paddingBottom);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='newLatLngPadding' and count(parameter)=5 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register ("newLatLngPadding", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;DDDD)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate NewLatLngPadding (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng, double left, double top, double right, double bottom)
		{
			const string __id = "newLatLngPadding.(Lcom/mapbox/mapboxsdk/geometry/LatLng;DDDD)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((latLng == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLng).Handle);
				__args [1] = new JniArgumentValue (left);
				__args [2] = new JniArgumentValue (top);
				__args [3] = new JniArgumentValue (right);
				__args [4] = new JniArgumentValue (bottom);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='newLatLngZoom' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng'] and parameter[2][@type='double']]"
		[Register ("newLatLngZoom", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate NewLatLngZoom (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng, double zoom)
		{
			const string __id = "newLatLngZoom.(Lcom/mapbox/mapboxsdk/geometry/LatLng;D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((latLng == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLng).Handle);
				__args [1] = new JniArgumentValue (zoom);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='paddingTo' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("paddingTo", "(DDDD)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate PaddingTo (double left, double top, double right, double bottom)
		{
			const string __id = "paddingTo.(DDDD)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='paddingTo' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("paddingTo", "([D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate PaddingTo (double[] padding)
		{
			const string __id = "paddingTo.([D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			IntPtr native_padding = JNIEnv.NewArray (padding);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_padding);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (padding != null) {
					JNIEnv.CopyArray (native_padding, padding);
					JNIEnv.DeleteLocalRef (native_padding);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='tiltTo' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("tiltTo", "(D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate TiltTo (double tilt)
		{
			const string __id = "tiltTo.(D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tilt);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='zoomBy' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("zoomBy", "(D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate ZoomBy (double amount)
		{
			const string __id = "zoomBy.(D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (amount);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='zoomBy' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("zoomBy", "(DLandroid/graphics/Point;)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate ZoomBy (double amount, global::Android.Graphics.Point focus)
		{
			const string __id = "zoomBy.(DLandroid/graphics/Point;)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (amount);
				__args [1] = new JniArgumentValue ((focus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) focus).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate ZoomIn ()
		{
			const string __id = "zoomIn.()Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate ZoomOut ()
		{
			const string __id = "zoomOut.()Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.camera']/class[@name='CameraUpdateFactory']/method[@name='zoomTo' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("zoomTo", "(D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate ZoomTo (double zoom)
		{
			const string __id = "zoomTo.(D)Lcom/mapbox/mapboxsdk/camera/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (zoom);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Camera.ICameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
