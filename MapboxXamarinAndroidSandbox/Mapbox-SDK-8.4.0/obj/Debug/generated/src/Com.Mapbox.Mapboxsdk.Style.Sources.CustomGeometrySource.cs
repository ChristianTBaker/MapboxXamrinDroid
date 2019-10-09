using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/CustomGeometrySource", DoNotGenerateAcw=true)]
	public partial class CustomGeometrySource : global::Com.Mapbox.Mapboxsdk.Style.Sources.Source {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource']/field[@name='THREAD_POOL_LIMIT']"
		[Register ("THREAD_POOL_LIMIT")]
		public const int ThreadPoolLimit = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource']/field[@name='THREAD_PREFIX']"
		[Register ("THREAD_PREFIX")]
		public const string ThreadPrefix = (string) "CustomGeom";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource.GeometryTileRequest']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/CustomGeometrySource$GeometryTileRequest", DoNotGenerateAcw=true)]
		public partial class GeometryTileRequest : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/CustomGeometrySource$GeometryTileRequest", typeof (GeometryTileRequest));
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

			protected GeometryTileRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySource.GeometryTileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySource.GeometryTileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource.GeometryTileRequest']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource.TileID']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/CustomGeometrySource$TileID", DoNotGenerateAcw=true)]
		public partial class TileID : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource.TileID']/field[@name='x']"
			[Register ("x")]
			public int X {
				get {
					const string __id = "x.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "x.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource.TileID']/field[@name='y']"
			[Register ("y")]
			public int Y {
				get {
					const string __id = "y.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "y.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource.TileID']/field[@name='z']"
			[Register ("z")]
			public int Z {
				get {
					const string __id = "z.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "z.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/CustomGeometrySource$TileID", typeof (TileID));
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

			protected TileID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/CustomGeometrySource", typeof (CustomGeometrySource));
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

		protected CustomGeometrySource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource']/constructor[@name='CustomGeometrySource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.style.sources.CustomGeometrySourceOptions'] and parameter[3][@type='com.mapbox.mapboxsdk.style.sources.GeometryTileProvider']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;Lcom/mapbox/mapboxsdk/style/sources/GeometryTileProvider;)V", "")]
		public unsafe CustomGeometrySource (string id, global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySourceOptions options, global::Com.Mapbox.Mapboxsdk.Style.Sources.IGeometryTileProvider provider)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/CustomGeometrySourceOptions;Lcom/mapbox/mapboxsdk/style/sources/GeometryTileProvider;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((provider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provider).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource']/constructor[@name='CustomGeometrySource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.style.sources.GeometryTileProvider']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/GeometryTileProvider;)V", "")]
		public unsafe CustomGeometrySource (string id, global::Com.Mapbox.Mapboxsdk.Style.Sources.IGeometryTileProvider provider)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/sources/GeometryTileProvider;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((provider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provider).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_initialize_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_initialize_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_initialize_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_lang_String_Ljava_lang_Object_);
			return cb_initialize_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Initialize_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("initialize", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetInitialize_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void Initialize (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "initialize.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_invalidateRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetInvalidateRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler ()
		{
			if (cb_invalidateRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ == null)
				cb_invalidateRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InvalidateRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_);
			return cb_invalidateRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
		}

		static void n_InvalidateRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds bounds = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (native_bounds, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateRegion (bounds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource']/method[@name='invalidateRegion' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds']]"
		[Register ("invalidateRegion", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)V", "GetInvalidateRegion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler")]
		public virtual unsafe void InvalidateRegion (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds bounds)
		{
			const string __id = "invalidateRegion.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bounds).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_invalidateTile_III;
#pragma warning disable 0169
		static Delegate GetInvalidateTile_IIIHandler ()
		{
			if (cb_invalidateTile_III == null)
				cb_invalidateTile_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_InvalidateTile_III);
			return cb_invalidateTile_III;
		}

		static void n_InvalidateTile_III (IntPtr jnienv, IntPtr native__this, int zoomLevel, int x, int y)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.CustomGeometrySource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateTile (zoomLevel, x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='CustomGeometrySource']/method[@name='invalidateTile' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("invalidateTile", "(III)V", "GetInvalidateTile_IIIHandler")]
		public virtual unsafe void InvalidateTile (int zoomLevel, int x, int y)
		{
			const string __id = "invalidateTile.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (zoomLevel);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
