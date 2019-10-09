using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MapFragmentUtils']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/MapFragmentUtils", DoNotGenerateAcw=true)]
	public partial class MapFragmentUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/MapFragmentUtils", typeof (MapFragmentUtils));
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

		protected MapFragmentUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MapFragmentUtils']/constructor[@name='MapFragmentUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapFragmentUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MapFragmentUtils']/method[@name='createFragmentArgs' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMapOptions']]"
		[Register ("createFragmentArgs", "(Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle CreateFragmentArgs (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions options)
		{
			const string __id = "createFragmentArgs.(Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='MapFragmentUtils']/method[@name='resolveArgs' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("resolveArgs", "(Landroid/content/Context;Landroid/os/Bundle;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions ResolveArgs (global::Android.Content.Context context, global::Android.OS.Bundle args)
		{
			const string __id = "resolveArgs.(Landroid/content/Context;Landroid/os/Bundle;)Lcom/mapbox/mapboxsdk/maps/MapboxMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((args == null) ? IntPtr.Zero : ((global::Java.Lang.Object) args).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
