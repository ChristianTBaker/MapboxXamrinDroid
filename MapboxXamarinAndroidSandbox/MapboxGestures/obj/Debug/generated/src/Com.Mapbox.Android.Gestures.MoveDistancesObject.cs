using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/MoveDistancesObject", DoNotGenerateAcw=true)]
	public sealed partial class MoveDistancesObject : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/MoveDistancesObject", typeof (MoveDistancesObject));
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

		internal MoveDistancesObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/constructor[@name='MoveDistancesObject' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe MoveDistancesObject (float initialX, float initialY)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (initialX);
				__args [1] = new JniArgumentValue (initialY);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe float CurrentX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getCurrentX' and count(parameter)=0]"
			[Register ("getCurrentX", "()F", "GetGetCurrentXHandler")]
			get {
				const string __id = "getCurrentX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float CurrentY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getCurrentY' and count(parameter)=0]"
			[Register ("getCurrentY", "()F", "GetGetCurrentYHandler")]
			get {
				const string __id = "getCurrentY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float DistanceXSinceLast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getDistanceXSinceLast' and count(parameter)=0]"
			[Register ("getDistanceXSinceLast", "()F", "GetGetDistanceXSinceLastHandler")]
			get {
				const string __id = "getDistanceXSinceLast.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float DistanceXSinceStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getDistanceXSinceStart' and count(parameter)=0]"
			[Register ("getDistanceXSinceStart", "()F", "GetGetDistanceXSinceStartHandler")]
			get {
				const string __id = "getDistanceXSinceStart.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float DistanceYSinceLast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getDistanceYSinceLast' and count(parameter)=0]"
			[Register ("getDistanceYSinceLast", "()F", "GetGetDistanceYSinceLastHandler")]
			get {
				const string __id = "getDistanceYSinceLast.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float DistanceYSinceStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getDistanceYSinceStart' and count(parameter)=0]"
			[Register ("getDistanceYSinceStart", "()F", "GetGetDistanceYSinceStartHandler")]
			get {
				const string __id = "getDistanceYSinceStart.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float InitialX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getInitialX' and count(parameter)=0]"
			[Register ("getInitialX", "()F", "GetGetInitialXHandler")]
			get {
				const string __id = "getInitialX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float InitialY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getInitialY' and count(parameter)=0]"
			[Register ("getInitialY", "()F", "GetGetInitialYHandler")]
			get {
				const string __id = "getInitialY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float PreviousX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getPreviousX' and count(parameter)=0]"
			[Register ("getPreviousX", "()F", "GetGetPreviousXHandler")]
			get {
				const string __id = "getPreviousX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float PreviousY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='getPreviousY' and count(parameter)=0]"
			[Register ("getPreviousY", "()F", "GetGetPreviousYHandler")]
			get {
				const string __id = "getPreviousY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MoveDistancesObject']/method[@name='addNewPosition' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("addNewPosition", "(FF)V", "")]
		public unsafe void AddNewPosition (float x, float y)
		{
			const string __id = "addNewPosition.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
