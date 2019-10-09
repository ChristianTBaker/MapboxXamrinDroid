using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='InfoWindow']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/InfoWindow", DoNotGenerateAcw=true)]
	public partial class InfoWindow : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/InfoWindow", typeof (InfoWindow));
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

		protected InfoWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='InfoWindow']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				const string __id = "getView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Update);
			return cb_update;
		}

		static void n_Update (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='InfoWindow']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()V", "GetUpdateHandler")]
		public virtual unsafe void Update ()
		{
			const string __id = "update.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
