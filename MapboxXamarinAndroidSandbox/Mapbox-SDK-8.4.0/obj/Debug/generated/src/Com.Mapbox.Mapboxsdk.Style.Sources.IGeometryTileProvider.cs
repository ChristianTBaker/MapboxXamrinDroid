using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/interface[@name='GeometryTileProvider']"
	[Register ("com/mapbox/mapboxsdk/style/sources/GeometryTileProvider", "", "Com.Mapbox.Mapboxsdk.Style.Sources.IGeometryTileProviderInvoker")]
	public partial interface IGeometryTileProvider : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/GeometryTileProvider", DoNotGenerateAcw=true)]
	internal class IGeometryTileProviderInvoker : global::Java.Lang.Object, IGeometryTileProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/style/sources/GeometryTileProvider", typeof (IGeometryTileProviderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IGeometryTileProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGeometryTileProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.style.sources.GeometryTileProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGeometryTileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
