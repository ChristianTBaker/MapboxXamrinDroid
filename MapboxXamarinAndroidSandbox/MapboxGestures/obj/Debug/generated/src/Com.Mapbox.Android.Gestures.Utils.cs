using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/mapbox/android/gestures/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/gestures/Utils", typeof (Utils));
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

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Utils']/method[@name='determineFocalPoint' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("determineFocalPoint", "(Landroid/view/MotionEvent;)Landroid/graphics/PointF;", "")]
		public static unsafe global::Android.Graphics.PointF DetermineFocalPoint (global::Android.Views.MotionEvent motionEvent)
		{
			const string __id = "determineFocalPoint.(Landroid/view/MotionEvent;)Landroid/graphics/PointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((motionEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) motionEvent).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Utils']/method[@name='dpToPx' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("dpToPx", "(F)F", "")]
		public static unsafe float DpToPx (float dp)
		{
			const string __id = "dpToPx.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dp);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Utils']/method[@name='getRawX' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='int']]"
		[Register ("getRawX", "(Landroid/view/MotionEvent;I)F", "")]
		public static unsafe float GetRawX (global::Android.Views.MotionEvent e, int pointerIndex)
		{
			const string __id = "getRawX.(Landroid/view/MotionEvent;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue (pointerIndex);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Utils']/method[@name='getRawY' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='int']]"
		[Register ("getRawY", "(Landroid/view/MotionEvent;I)F", "")]
		public static unsafe float GetRawY (global::Android.Views.MotionEvent e, int pointerIndex)
		{
			const string __id = "getRawY.(Landroid/view/MotionEvent;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue (pointerIndex);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Utils']/method[@name='pxToDp' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("pxToDp", "(F)F", "")]
		public static unsafe float PxToDp (float px)
		{
			const string __id = "pxToDp.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='Utils']/method[@name='pxToMm' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("pxToMm", "(FLandroid/content/Context;)F", "")]
		public static unsafe float PxToMm (float px, global::Android.Content.Context context)
		{
			const string __id = "pxToMm.(FLandroid/content/Context;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (px);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
