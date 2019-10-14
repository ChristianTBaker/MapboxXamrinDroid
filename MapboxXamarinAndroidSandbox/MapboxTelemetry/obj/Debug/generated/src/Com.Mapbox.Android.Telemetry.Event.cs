using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/Event", DoNotGenerateAcw=true)]
	public abstract partial class Event : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[global::Android.Runtime.Register ("com/mapbox/android/telemetry/Event$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='CRASH']"
			[Register ("CRASH")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type Crash {
				get {
					const string __id = "CRASH.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='LOCATION']"
			[Register ("LOCATION")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type Location {
				get {
					const string __id = "LOCATION.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='MAP_CLICK']"
			[Register ("MAP_CLICK")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type MapClick {
				get {
					const string __id = "MAP_CLICK.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='MAP_DRAGEND']"
			[Register ("MAP_DRAGEND")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type MapDragend {
				get {
					const string __id = "MAP_DRAGEND.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='MAP_LOAD']"
			[Register ("MAP_LOAD")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type MapLoad {
				get {
					const string __id = "MAP_LOAD.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='NAV_ARRIVE']"
			[Register ("NAV_ARRIVE")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type NavArrive {
				get {
					const string __id = "NAV_ARRIVE.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='NAV_CANCEL']"
			[Register ("NAV_CANCEL")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type NavCancel {
				get {
					const string __id = "NAV_CANCEL.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='NAV_DEPART']"
			[Register ("NAV_DEPART")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type NavDepart {
				get {
					const string __id = "NAV_DEPART.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='NAV_FASTER_ROUTE']"
			[Register ("NAV_FASTER_ROUTE")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type NavFasterRoute {
				get {
					const string __id = "NAV_FASTER_ROUTE.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='NAV_FEEDBACK']"
			[Register ("NAV_FEEDBACK")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type NavFeedback {
				get {
					const string __id = "NAV_FEEDBACK.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='NAV_REROUTE']"
			[Register ("NAV_REROUTE")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type NavReroute {
				get {
					const string __id = "NAV_REROUTE.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='NO_OP']"
			[Register ("NO_OP")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type NoOp {
				get {
					const string __id = "NO_OP.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='OFFLINE_DOWNLOAD_COMPLETE']"
			[Register ("OFFLINE_DOWNLOAD_COMPLETE")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type OfflineDownloadComplete {
				get {
					const string __id = "OFFLINE_DOWNLOAD_COMPLETE.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='OFFLINE_DOWNLOAD_START']"
			[Register ("OFFLINE_DOWNLOAD_START")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type OfflineDownloadStart {
				get {
					const string __id = "OFFLINE_DOWNLOAD_START.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='TURNSTILE']"
			[Register ("TURNSTILE")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type Turnstile {
				get {
					const string __id = "TURNSTILE.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='VIS_ATTACHMENT']"
			[Register ("VIS_ATTACHMENT")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type VisAttachment {
				get {
					const string __id = "VIS_ATTACHMENT.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='VIS_GENERAL']"
			[Register ("VIS_GENERAL")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type VisGeneral {
				get {
					const string __id = "VIS_GENERAL.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/field[@name='VIS_OBJ_DETECTION']"
			[Register ("VIS_OBJ_DETECTION")]
			public static global::Com.Mapbox.Android.Telemetry.Event.Type VisObjDetection {
				get {
					const string __id = "VIS_OBJ_DETECTION.Lcom/mapbox/android/telemetry/Event$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/Event$Type", typeof (Type));
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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mapbox/android/telemetry/Event$Type;", "")]
			public static unsafe global::Com.Mapbox.Android.Telemetry.Event.Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/mapbox/android/telemetry/Event$Type;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mapbox/android/telemetry/Event$Type;", "")]
			public static unsafe global::Com.Mapbox.Android.Telemetry.Event.Type[] Values ()
			{
				const string __id = "values.()[Lcom/mapbox/android/telemetry/Event$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Mapbox.Android.Telemetry.Event.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mapbox.Android.Telemetry.Event.Type));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/Event", typeof (Event));
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

		protected Event (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='Event']/constructor[@name='Event' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Event ()
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
			global::Com.Mapbox.Android.Telemetry.Event __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public abstract global::System.Int32 DescribeContents ();

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Mapbox.Android.Telemetry.Event __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/Event", DoNotGenerateAcw=true)]
	internal partial class EventInvoker : Event {

		public EventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/android/telemetry/Event", typeof (EventInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override unsafe global::System.Int32 DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
