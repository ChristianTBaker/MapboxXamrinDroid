using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']"
	[global::Android.Runtime.Register ("com/mapbox/android/core/location/LocationEngineRequest", DoNotGenerateAcw=true)]
	public partial class LocationEngineRequest : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']/field[@name='PRIORITY_BALANCED_POWER_ACCURACY']"
		[Register ("PRIORITY_BALANCED_POWER_ACCURACY")]
		public const int PriorityBalancedPowerAccuracy = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']/field[@name='PRIORITY_HIGH_ACCURACY']"
		[Register ("PRIORITY_HIGH_ACCURACY")]
		public const int PriorityHighAccuracy = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']/field[@name='PRIORITY_LOW_POWER']"
		[Register ("PRIORITY_LOW_POWER")]
		public const int PriorityLowPower = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']/field[@name='PRIORITY_NO_POWER']"
		[Register ("PRIORITY_NO_POWER")]
		public const int PriorityNoPower = (int) 3;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/android/core/location/LocationEngineRequest$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/location/LocationEngineRequest$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest.Builder']/constructor[@name='LocationEngineRequest.Builder' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe Builder (long interval)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(J)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (interval);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/android/core/location/LocationEngineRequest;", "")]
			public unsafe global::Com.Mapbox.Android.Core.Location.LocationEngineRequest Build ()
			{
				const string __id = "build.()Lcom/mapbox/android/core/location/LocationEngineRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest.Builder']/method[@name='setDisplacement' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setDisplacement", "(F)Lcom/mapbox/android/core/location/LocationEngineRequest$Builder;", "")]
			public unsafe global::Com.Mapbox.Android.Core.Location.LocationEngineRequest.Builder SetDisplacement (float displacement)
			{
				const string __id = "setDisplacement.(F)Lcom/mapbox/android/core/location/LocationEngineRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (displacement);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest.Builder']/method[@name='setFastestInterval' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setFastestInterval", "(J)Lcom/mapbox/android/core/location/LocationEngineRequest$Builder;", "")]
			public unsafe global::Com.Mapbox.Android.Core.Location.LocationEngineRequest.Builder SetFastestInterval (long interval)
			{
				const string __id = "setFastestInterval.(J)Lcom/mapbox/android/core/location/LocationEngineRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (interval);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest.Builder']/method[@name='setMaxWaitTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxWaitTime", "(J)Lcom/mapbox/android/core/location/LocationEngineRequest$Builder;", "")]
			public unsafe global::Com.Mapbox.Android.Core.Location.LocationEngineRequest.Builder SetMaxWaitTime (long maxWaitTime)
			{
				const string __id = "setMaxWaitTime.(J)Lcom/mapbox/android/core/location/LocationEngineRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxWaitTime);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest.Builder']/method[@name='setPriority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPriority", "(I)Lcom/mapbox/android/core/location/LocationEngineRequest$Builder;", "")]
			public unsafe global::Com.Mapbox.Android.Core.Location.LocationEngineRequest.Builder SetPriority (int priority)
			{
				const string __id = "setPriority.(I)Lcom/mapbox/android/core/location/LocationEngineRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (priority);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/location/LocationEngineRequest", typeof (LocationEngineRequest));
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

		protected LocationEngineRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDisplacemnt;
#pragma warning disable 0169
		static Delegate GetGetDisplacemntHandler ()
		{
			if (cb_getDisplacemnt == null)
				cb_getDisplacemnt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDisplacemnt);
			return cb_getDisplacemnt;
		}

		static float n_GetDisplacemnt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Location.LocationEngineRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Displacemnt;
		}
#pragma warning restore 0169

		public virtual unsafe float Displacemnt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']/method[@name='getDisplacemnt' and count(parameter)=0]"
			[Register ("getDisplacemnt", "()F", "GetGetDisplacemntHandler")]
			get {
				const string __id = "getDisplacemnt.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFastestInterval;
#pragma warning disable 0169
		static Delegate GetGetFastestIntervalHandler ()
		{
			if (cb_getFastestInterval == null)
				cb_getFastestInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFastestInterval);
			return cb_getFastestInterval;
		}

		static long n_GetFastestInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Location.LocationEngineRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FastestInterval;
		}
#pragma warning restore 0169

		public virtual unsafe long FastestInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']/method[@name='getFastestInterval' and count(parameter)=0]"
			[Register ("getFastestInterval", "()J", "GetGetFastestIntervalHandler")]
			get {
				const string __id = "getFastestInterval.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getInterval;
#pragma warning disable 0169
		static Delegate GetGetIntervalHandler ()
		{
			if (cb_getInterval == null)
				cb_getInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetInterval);
			return cb_getInterval;
		}

		static long n_GetInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Location.LocationEngineRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Interval;
		}
#pragma warning restore 0169

		public virtual unsafe long Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']/method[@name='getInterval' and count(parameter)=0]"
			[Register ("getInterval", "()J", "GetGetIntervalHandler")]
			get {
				const string __id = "getInterval.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxWaitTime;
#pragma warning disable 0169
		static Delegate GetGetMaxWaitTimeHandler ()
		{
			if (cb_getMaxWaitTime == null)
				cb_getMaxWaitTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxWaitTime);
			return cb_getMaxWaitTime;
		}

		static long n_GetMaxWaitTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Location.LocationEngineRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxWaitTime;
		}
#pragma warning restore 0169

		public virtual unsafe long MaxWaitTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']/method[@name='getMaxWaitTime' and count(parameter)=0]"
			[Register ("getMaxWaitTime", "()J", "GetGetMaxWaitTimeHandler")]
			get {
				const string __id = "getMaxWaitTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPriority;
#pragma warning disable 0169
		static Delegate GetGetPriorityHandler ()
		{
			if (cb_getPriority == null)
				cb_getPriority = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPriority);
			return cb_getPriority;
		}

		static int n_GetPriority (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Core.Location.LocationEngineRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Core.Location.LocationEngineRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Priority;
		}
#pragma warning restore 0169

		public virtual unsafe int Priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core.location']/class[@name='LocationEngineRequest']/method[@name='getPriority' and count(parameter)=0]"
			[Register ("getPriority", "()I", "GetGetPriorityHandler")]
			get {
				const string __id = "getPriority.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
