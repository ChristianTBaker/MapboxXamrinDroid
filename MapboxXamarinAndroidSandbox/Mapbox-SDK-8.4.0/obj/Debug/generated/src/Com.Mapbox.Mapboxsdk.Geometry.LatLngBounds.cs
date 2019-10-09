using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/geometry/LatLngBounds", DoNotGenerateAcw=true)]
	public partial class LatLngBounds : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/geometry/LatLngBounds$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/geometry/LatLngBounds$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds.Builder']/constructor[@name='LatLngBounds.Builder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Build ()
			{
				const string __id = "build.()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds.Builder']/method[@name='include' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
			[Register ("include", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds$Builder;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds.Builder Include (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng)
			{
				const string __id = "include.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((latLng == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLng).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds.Builder']/method[@name='includes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.mapboxsdk.geometry.LatLng&gt;']]"
			[Register ("includes", "(Ljava/util/List;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds$Builder;", "")]
			public unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds.Builder Includes (global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> latLngs)
			{
				const string __id = "includes.(Ljava/util/List;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds$Builder;";
				IntPtr native_latLngs = global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>.ToLocalJniHandle (latLngs);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_latLngs);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_latLngs);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/geometry/LatLngBounds", typeof (LatLngBounds));
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

		protected LatLngBounds (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetCenterHandler")]
			get {
				const string __id = "getCenter.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEmptySpan;
#pragma warning disable 0169
		static Delegate GetIsEmptySpanHandler ()
		{
			if (cb_isEmptySpan == null)
				cb_isEmptySpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmptySpan);
			return cb_isEmptySpan;
		}

		static bool n_IsEmptySpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmptySpan;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEmptySpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='isEmptySpan' and count(parameter)=0]"
			[Register ("isEmptySpan", "()Z", "GetIsEmptySpanHandler")]
			get {
				const string __id = "isEmptySpan.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLatNorth;
#pragma warning disable 0169
		static Delegate GetGetLatNorthHandler ()
		{
			if (cb_getLatNorth == null)
				cb_getLatNorth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatNorth);
			return cb_getLatNorth;
		}

		static double n_GetLatNorth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatNorth;
		}
#pragma warning restore 0169

		public virtual unsafe double LatNorth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getLatNorth' and count(parameter)=0]"
			[Register ("getLatNorth", "()D", "GetGetLatNorthHandler")]
			get {
				const string __id = "getLatNorth.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLatSouth;
#pragma warning disable 0169
		static Delegate GetGetLatSouthHandler ()
		{
			if (cb_getLatSouth == null)
				cb_getLatSouth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatSouth);
			return cb_getLatSouth;
		}

		static double n_GetLatSouth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatSouth;
		}
#pragma warning restore 0169

		public virtual unsafe double LatSouth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getLatSouth' and count(parameter)=0]"
			[Register ("getLatSouth", "()D", "GetGetLatSouthHandler")]
			get {
				const string __id = "getLatSouth.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLatitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLatitudeSpanHandler ()
		{
			if (cb_getLatitudeSpan == null)
				cb_getLatitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitudeSpan);
			return cb_getLatitudeSpan;
		}

		static double n_GetLatitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpan;
		}
#pragma warning restore 0169

		public virtual unsafe double LatitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getLatitudeSpan' and count(parameter)=0]"
			[Register ("getLatitudeSpan", "()D", "GetGetLatitudeSpanHandler")]
			get {
				const string __id = "getLatitudeSpan.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLonEast;
#pragma warning disable 0169
		static Delegate GetGetLonEastHandler ()
		{
			if (cb_getLonEast == null)
				cb_getLonEast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLonEast);
			return cb_getLonEast;
		}

		static double n_GetLonEast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LonEast;
		}
#pragma warning restore 0169

		public virtual unsafe double LonEast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getLonEast' and count(parameter)=0]"
			[Register ("getLonEast", "()D", "GetGetLonEastHandler")]
			get {
				const string __id = "getLonEast.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLonWest;
#pragma warning disable 0169
		static Delegate GetGetLonWestHandler ()
		{
			if (cb_getLonWest == null)
				cb_getLonWest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLonWest);
			return cb_getLonWest;
		}

		static double n_GetLonWest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LonWest;
		}
#pragma warning restore 0169

		public virtual unsafe double LonWest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getLonWest' and count(parameter)=0]"
			[Register ("getLonWest", "()D", "GetGetLonWestHandler")]
			get {
				const string __id = "getLonWest.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLongitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLongitudeSpanHandler ()
		{
			if (cb_getLongitudeSpan == null)
				cb_getLongitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitudeSpan);
			return cb_getLongitudeSpan;
		}

		static double n_GetLongitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpan;
		}
#pragma warning restore 0169

		public virtual unsafe double LongitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getLongitudeSpan' and count(parameter)=0]"
			[Register ("getLongitudeSpan", "()D", "GetGetLongitudeSpanHandler")]
			get {
				const string __id = "getLongitudeSpan.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNorthEast;
#pragma warning disable 0169
		static Delegate GetGetNorthEastHandler ()
		{
			if (cb_getNorthEast == null)
				cb_getNorthEast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNorthEast);
			return cb_getNorthEast;
		}

		static IntPtr n_GetNorthEast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NorthEast);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng NorthEast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getNorthEast' and count(parameter)=0]"
			[Register ("getNorthEast", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetNorthEastHandler")]
			get {
				const string __id = "getNorthEast.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNorthWest;
#pragma warning disable 0169
		static Delegate GetGetNorthWestHandler ()
		{
			if (cb_getNorthWest == null)
				cb_getNorthWest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNorthWest);
			return cb_getNorthWest;
		}

		static IntPtr n_GetNorthWest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NorthWest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng NorthWest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getNorthWest' and count(parameter)=0]"
			[Register ("getNorthWest", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetNorthWestHandler")]
			get {
				const string __id = "getNorthWest.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSouthEast;
#pragma warning disable 0169
		static Delegate GetGetSouthEastHandler ()
		{
			if (cb_getSouthEast == null)
				cb_getSouthEast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSouthEast);
			return cb_getSouthEast;
		}

		static IntPtr n_GetSouthEast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SouthEast);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng SouthEast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getSouthEast' and count(parameter)=0]"
			[Register ("getSouthEast", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetSouthEastHandler")]
			get {
				const string __id = "getSouthEast.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSouthWest;
#pragma warning disable 0169
		static Delegate GetGetSouthWestHandler ()
		{
			if (cb_getSouthWest == null)
				cb_getSouthWest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSouthWest);
			return cb_getSouthWest;
		}

		static IntPtr n_GetSouthWest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SouthWest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng SouthWest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getSouthWest' and count(parameter)=0]"
			[Register ("getSouthWest", "()Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetGetSouthWestHandler")]
			get {
				const string __id = "getSouthWest.()Lcom/mapbox/mapboxsdk/geometry/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSpan;
#pragma warning disable 0169
		static Delegate GetGetSpanHandler ()
		{
			if (cb_getSpan == null)
				cb_getSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpan);
			return cb_getSpan;
		}

		static IntPtr n_GetSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Span);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan Span {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='getSpan' and count(parameter)=0]"
			[Register ("getSpan", "()Lcom/mapbox/mapboxsdk/geometry/LatLngSpan;", "GetGetSpanHandler")]
			get {
				const string __id = "getSpan.()Lcom/mapbox/mapboxsdk/geometry/LatLngSpan;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngSpan> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_contains_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_contains_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_contains_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_contains_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static bool n_Contains_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_latLng)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_latLng, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (latLng);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("contains", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Z", "GetContains_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe bool Contains (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng)
		{
			const string __id = "contains.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((latLng == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLng).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contains_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler ()
		{
			if (cb_contains_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ == null)
				cb_contains_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_);
			return cb_contains_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
		}

		static bool n_Contains_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds other = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds']]"
		[Register ("contains", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Z", "GetContains_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler")]
		public virtual unsafe bool Contains (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds other)
		{
			const string __id = "contains.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='from' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("from", "(DDDD)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds From (double latNorth, double lonEast, double latSouth, double lonWest)
		{
			const string __id = "from.(DDDD)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (latNorth);
				__args [1] = new JniArgumentValue (lonEast);
				__args [2] = new JniArgumentValue (latSouth);
				__args [3] = new JniArgumentValue (lonWest);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='from' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("from", "(III)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds From (int z, int x, int y)
		{
			const string __id = "from.(III)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (z);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_include_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
#pragma warning disable 0169
		static Delegate GetInclude_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler ()
		{
			if (cb_include_Lcom_mapbox_mapboxsdk_geometry_LatLng_ == null)
				cb_include_Lcom_mapbox_mapboxsdk_geometry_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Include_Lcom_mapbox_mapboxsdk_geometry_LatLng_);
			return cb_include_Lcom_mapbox_mapboxsdk_geometry_LatLng_;
		}

		static IntPtr n_Include_Lcom_mapbox_mapboxsdk_geometry_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_latLng)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng> (native_latLng, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (latLng));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='include' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLng']]"
		[Register ("include", "(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "GetInclude_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Include (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng latLng)
		{
			const string __id = "include.(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((latLng == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latLng).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_intersect_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetIntersect_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler ()
		{
			if (cb_intersect_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ == null)
				cb_intersect_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Intersect_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_);
			return cb_intersect_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
		}

		static IntPtr n_Intersect_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_box)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds box = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (native_box, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Intersect (box));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='intersect' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds']]"
		[Register ("intersect", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "GetIntersect_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Intersect (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds box)
		{
			const string __id = "intersect.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((box == null) ? IntPtr.Zero : ((global::Java.Lang.Object) box).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_intersect_DDDD;
#pragma warning disable 0169
		static Delegate GetIntersect_DDDDHandler ()
		{
			if (cb_intersect_DDDD == null)
				cb_intersect_DDDD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, double, double, IntPtr>) n_Intersect_DDDD);
			return cb_intersect_DDDD;
		}

		static IntPtr n_Intersect_DDDD (IntPtr jnienv, IntPtr native__this, double northLat, double eastLon, double southLat, double westLon)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intersect (northLat, eastLon, southLat, westLon));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='intersect' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("intersect", "(DDDD)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "GetIntersect_DDDDHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Intersect (double northLat, double eastLon, double southLat, double westLon)
		{
			const string __id = "intersect.(DDDD)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (northLat);
				__args [1] = new JniArgumentValue (eastLon);
				__args [2] = new JniArgumentValue (southLat);
				__args [3] = new JniArgumentValue (westLon);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toLatLngs;
#pragma warning disable 0169
		static Delegate GetToLatLngsHandler ()
		{
			if (cb_toLatLngs == null)
				cb_toLatLngs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToLatLngs);
			return cb_toLatLngs;
		}

		static IntPtr n_ToLatLngs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToLatLngs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='toLatLngs' and count(parameter)=0]"
		[Register ("toLatLngs", "()[Lcom/mapbox/mapboxsdk/geometry/LatLng;", "GetToLatLngsHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLng[] ToLatLngs ()
		{
			const string __id = "toLatLngs.()[Lcom/mapbox/mapboxsdk/geometry/LatLng;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mapbox.Mapboxsdk.Geometry.LatLng));
			} finally {
			}
		}

		static Delegate cb_union_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetUnion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler ()
		{
			if (cb_union_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ == null)
				cb_union_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Union_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_);
			return cb_union_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_;
		}

		static IntPtr n_Union_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds bounds = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (native_bounds, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Union (bounds));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='union' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.geometry.LatLngBounds']]"
		[Register ("union", "(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "GetUnion_Lcom_mapbox_mapboxsdk_geometry_LatLngBounds_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Union (global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds bounds)
		{
			const string __id = "union.(Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bounds).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_union_DDDD;
#pragma warning disable 0169
		static Delegate GetUnion_DDDDHandler ()
		{
			if (cb_union_DDDD == null)
				cb_union_DDDD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, double, double, IntPtr>) n_Union_DDDD);
			return cb_union_DDDD;
		}

		static IntPtr n_Union_DDDD (IntPtr jnienv, IntPtr native__this, double northLat, double eastLon, double southLat, double westLon)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Union (northLat, eastLon, southLat, westLon));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='union' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("union", "(DDDD)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "GetUnion_DDDDHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds Union (double northLat, double eastLon, double southLat, double westLon)
		{
			const string __id = "union.(DDDD)Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (northLat);
				__args [1] = new JniArgumentValue (eastLon);
				__args [2] = new JniArgumentValue (southLat);
				__args [3] = new JniArgumentValue (westLon);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='world' and count(parameter)=0]"
		[Register ("world", "()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds World ()
		{
			const string __id = "world.()Lcom/mapbox/mapboxsdk/geometry/LatLngBounds;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Geometry.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @out = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__out, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (@out, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.geometry']/class[@name='LatLngBounds']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel @out, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
