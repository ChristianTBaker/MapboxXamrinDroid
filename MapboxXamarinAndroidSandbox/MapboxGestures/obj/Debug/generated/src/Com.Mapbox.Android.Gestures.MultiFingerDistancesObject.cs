using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerDistancesObject']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/MultiFingerDistancesObject", DoNotGenerateAcw=true)]
	public partial class MultiFingerDistancesObject : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/MultiFingerDistancesObject", typeof (MultiFingerDistancesObject));
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

		protected MultiFingerDistancesObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerDistancesObject']/constructor[@name='MultiFingerDistancesObject' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(FFFF)V", "")]
		public unsafe MultiFingerDistancesObject (float prevFingersDiffX, float prevFingersDiffY, float currFingersDiffX, float currFingersDiffY)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (prevFingersDiffX);
				__args [1] = new JniArgumentValue (prevFingersDiffY);
				__args [2] = new JniArgumentValue (currFingersDiffX);
				__args [3] = new JniArgumentValue (currFingersDiffY);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrFingersDiffX;
#pragma warning disable 0169
		static Delegate GetGetCurrFingersDiffXHandler ()
		{
			if (cb_getCurrFingersDiffX == null)
				cb_getCurrFingersDiffX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrFingersDiffX);
			return cb_getCurrFingersDiffX;
		}

		static float n_GetCurrFingersDiffX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrFingersDiffX;
		}
#pragma warning restore 0169

		public virtual unsafe float CurrFingersDiffX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerDistancesObject']/method[@name='getCurrFingersDiffX' and count(parameter)=0]"
			[Register ("getCurrFingersDiffX", "()F", "GetGetCurrFingersDiffXHandler")]
			get {
				const string __id = "getCurrFingersDiffX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCurrFingersDiffXY;
#pragma warning disable 0169
		static Delegate GetGetCurrFingersDiffXYHandler ()
		{
			if (cb_getCurrFingersDiffXY == null)
				cb_getCurrFingersDiffXY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrFingersDiffXY);
			return cb_getCurrFingersDiffXY;
		}

		static float n_GetCurrFingersDiffXY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrFingersDiffXY;
		}
#pragma warning restore 0169

		public virtual unsafe float CurrFingersDiffXY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerDistancesObject']/method[@name='getCurrFingersDiffXY' and count(parameter)=0]"
			[Register ("getCurrFingersDiffXY", "()F", "GetGetCurrFingersDiffXYHandler")]
			get {
				const string __id = "getCurrFingersDiffXY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCurrFingersDiffY;
#pragma warning disable 0169
		static Delegate GetGetCurrFingersDiffYHandler ()
		{
			if (cb_getCurrFingersDiffY == null)
				cb_getCurrFingersDiffY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrFingersDiffY);
			return cb_getCurrFingersDiffY;
		}

		static float n_GetCurrFingersDiffY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrFingersDiffY;
		}
#pragma warning restore 0169

		public virtual unsafe float CurrFingersDiffY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerDistancesObject']/method[@name='getCurrFingersDiffY' and count(parameter)=0]"
			[Register ("getCurrFingersDiffY", "()F", "GetGetCurrFingersDiffYHandler")]
			get {
				const string __id = "getCurrFingersDiffY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPrevFingersDiffX;
#pragma warning disable 0169
		static Delegate GetGetPrevFingersDiffXHandler ()
		{
			if (cb_getPrevFingersDiffX == null)
				cb_getPrevFingersDiffX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPrevFingersDiffX);
			return cb_getPrevFingersDiffX;
		}

		static float n_GetPrevFingersDiffX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrevFingersDiffX;
		}
#pragma warning restore 0169

		public virtual unsafe float PrevFingersDiffX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerDistancesObject']/method[@name='getPrevFingersDiffX' and count(parameter)=0]"
			[Register ("getPrevFingersDiffX", "()F", "GetGetPrevFingersDiffXHandler")]
			get {
				const string __id = "getPrevFingersDiffX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPrevFingersDiffXY;
#pragma warning disable 0169
		static Delegate GetGetPrevFingersDiffXYHandler ()
		{
			if (cb_getPrevFingersDiffXY == null)
				cb_getPrevFingersDiffXY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPrevFingersDiffXY);
			return cb_getPrevFingersDiffXY;
		}

		static float n_GetPrevFingersDiffXY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrevFingersDiffXY;
		}
#pragma warning restore 0169

		public virtual unsafe float PrevFingersDiffXY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerDistancesObject']/method[@name='getPrevFingersDiffXY' and count(parameter)=0]"
			[Register ("getPrevFingersDiffXY", "()F", "GetGetPrevFingersDiffXYHandler")]
			get {
				const string __id = "getPrevFingersDiffXY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPrevFingersDiffY;
#pragma warning disable 0169
		static Delegate GetGetPrevFingersDiffYHandler ()
		{
			if (cb_getPrevFingersDiffY == null)
				cb_getPrevFingersDiffY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPrevFingersDiffY);
			return cb_getPrevFingersDiffY;
		}

		static float n_GetPrevFingersDiffY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Gestures.MultiFingerDistancesObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrevFingersDiffY;
		}
#pragma warning restore 0169

		public virtual unsafe float PrevFingersDiffY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='MultiFingerDistancesObject']/method[@name='getPrevFingersDiffY' and count(parameter)=0]"
			[Register ("getPrevFingersDiffY", "()F", "GetGetPrevFingersDiffYHandler")]
			get {
				const string __id = "getPrevFingersDiffY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
