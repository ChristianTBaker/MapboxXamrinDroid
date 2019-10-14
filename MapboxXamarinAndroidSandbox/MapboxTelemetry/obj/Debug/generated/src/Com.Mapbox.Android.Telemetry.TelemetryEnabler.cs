using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryEnabler']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/TelemetryEnabler", DoNotGenerateAcw=true)]
	public partial class TelemetryEnabler : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryEnabler.State']"
		[global::Android.Runtime.Register ("com/mapbox/android/telemetry/TelemetryEnabler$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryEnabler.State']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State Disabled {
				get {
					const string __id = "DISABLED.Lcom/mapbox/android/telemetry/TelemetryEnabler$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryEnabler.State']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State Enabled {
				get {
					const string __id = "ENABLED.Lcom/mapbox/android/telemetry/TelemetryEnabler$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/TelemetryEnabler$State", typeof (State));
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

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryEnabler.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mapbox/android/telemetry/TelemetryEnabler$State;", "")]
			public static unsafe global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/mapbox/android/telemetry/TelemetryEnabler$State;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryEnabler.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mapbox/android/telemetry/TelemetryEnabler$State;", "")]
			public static unsafe global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State[] Values ()
			{
				const string __id = "values.()[Lcom/mapbox/android/telemetry/TelemetryEnabler$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/TelemetryEnabler", typeof (TelemetryEnabler));
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

		protected TelemetryEnabler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryEnabler']/method[@name='retrieveTelemetryStateFromPreferences' and count(parameter)=0]"
		[Register ("retrieveTelemetryStateFromPreferences", "()Lcom/mapbox/android/telemetry/TelemetryEnabler$State;", "")]
		public static unsafe global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State RetrieveTelemetryStateFromPreferences ()
		{
			const string __id = "retrieveTelemetryStateFromPreferences.()Lcom/mapbox/android/telemetry/TelemetryEnabler$State;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='TelemetryEnabler']/method[@name='updateTelemetryState' and count(parameter)=1 and parameter[1][@type='com.mapbox.android.telemetry.TelemetryEnabler.State']]"
		[Register ("updateTelemetryState", "(Lcom/mapbox/android/telemetry/TelemetryEnabler$State;)Lcom/mapbox/android/telemetry/TelemetryEnabler$State;", "")]
		public static unsafe global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State UpdateTelemetryState (global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State telemetryState)
		{
			const string __id = "updateTelemetryState.(Lcom/mapbox/android/telemetry/TelemetryEnabler$State;)Lcom/mapbox/android/telemetry/TelemetryEnabler$State;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((telemetryState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) telemetryState).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.TelemetryEnabler.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
