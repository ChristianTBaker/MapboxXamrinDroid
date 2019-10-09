using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='TransitionOptions']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/TransitionOptions", DoNotGenerateAcw=true)]
	public partial class TransitionOptions : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/TransitionOptions", typeof (TransitionOptions));
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

		protected TransitionOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='TransitionOptions']/constructor[@name='TransitionOptions' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register (".ctor", "(JJ)V", "")]
		public unsafe TransitionOptions (long duration, long delay)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (duration);
				__args [1] = new JniArgumentValue (delay);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='TransitionOptions']/constructor[@name='TransitionOptions' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(JJZ)V", "")]
		public unsafe TransitionOptions (long duration, long delay, bool enablePlacementTransitions)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (duration);
				__args [1] = new JniArgumentValue (delay);
				__args [2] = new JniArgumentValue (enablePlacementTransitions);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDelay;
#pragma warning disable 0169
		static Delegate GetGetDelayHandler ()
		{
			if (cb_getDelay == null)
				cb_getDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDelay);
			return cb_getDelay;
		}

		static long n_GetDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Delay;
		}
#pragma warning restore 0169

		public virtual unsafe long Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='TransitionOptions']/method[@name='getDelay' and count(parameter)=0]"
			[Register ("getDelay", "()J", "GetGetDelayHandler")]
			get {
				const string __id = "getDelay.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='TransitionOptions']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				const string __id = "getDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnablePlacementTransitions;
#pragma warning disable 0169
		static Delegate GetIsEnablePlacementTransitionsHandler ()
		{
			if (cb_isEnablePlacementTransitions == null)
				cb_isEnablePlacementTransitions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnablePlacementTransitions);
			return cb_isEnablePlacementTransitions;
		}

		static bool n_IsEnablePlacementTransitions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnablePlacementTransitions;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnablePlacementTransitions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='TransitionOptions']/method[@name='isEnablePlacementTransitions' and count(parameter)=0]"
			[Register ("isEnablePlacementTransitions", "()Z", "GetIsEnablePlacementTransitionsHandler")]
			get {
				const string __id = "isEnablePlacementTransitions.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='TransitionOptions']/method[@name='fromTransitionOptions' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Obsolete (@"deprecated")]
		[Register ("fromTransitionOptions", "(JJ)Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions FromTransitionOptions (long duration, long delay)
		{
			const string __id = "fromTransitionOptions.(JJ)Lcom/mapbox/mapboxsdk/style/layers/TransitionOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (duration);
				__args [1] = new JniArgumentValue (delay);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.TransitionOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
