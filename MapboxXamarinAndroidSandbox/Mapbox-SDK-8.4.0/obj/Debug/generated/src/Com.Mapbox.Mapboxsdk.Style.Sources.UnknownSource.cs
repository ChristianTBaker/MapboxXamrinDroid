using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='UnknownSource']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/UnknownSource", DoNotGenerateAcw=true)]
	public partial class UnknownSource : global::Com.Mapbox.Mapboxsdk.Style.Sources.Source {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/UnknownSource", typeof (UnknownSource));
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

		protected UnknownSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Initialize);
			return cb_initialize;
		}

		static void n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.UnknownSource __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.UnknownSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='UnknownSource']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "GetInitializeHandler")]
		protected virtual unsafe void Initialize ()
		{
			const string __id = "initialize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
