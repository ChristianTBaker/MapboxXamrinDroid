using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Attribution {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionLayout']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/attribution/AttributionLayout", DoNotGenerateAcw=true)]
	public partial class AttributionLayout : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/attribution/AttributionLayout", typeof (AttributionLayout));
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

		protected AttributionLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionLayout']/constructor[@name='AttributionLayout' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.PointF'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;Landroid/graphics/PointF;Z)V", "")]
		public unsafe AttributionLayout (global::Android.Graphics.Bitmap logo, global::Android.Graphics.PointF anchorPoint, bool shortText)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/Bitmap;Landroid/graphics/PointF;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((logo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logo).Handle);
				__args [1] = new JniArgumentValue ((anchorPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchorPoint).Handle);
				__args [2] = new JniArgumentValue (shortText);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAnchorPoint;
#pragma warning disable 0169
		static Delegate GetGetAnchorPointHandler ()
		{
			if (cb_getAnchorPoint == null)
				cb_getAnchorPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnchorPoint);
			return cb_getAnchorPoint;
		}

		static IntPtr n_GetAnchorPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnchorPoint);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.PointF AnchorPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionLayout']/method[@name='getAnchorPoint' and count(parameter)=0]"
			[Register ("getAnchorPoint", "()Landroid/graphics/PointF;", "GetGetAnchorPointHandler")]
			get {
				const string __id = "getAnchorPoint.()Landroid/graphics/PointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isShortText;
#pragma warning disable 0169
		static Delegate GetIsShortTextHandler ()
		{
			if (cb_isShortText == null)
				cb_isShortText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShortText);
			return cb_isShortText;
		}

		static bool n_IsShortText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShortText;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsShortText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionLayout']/method[@name='isShortText' and count(parameter)=0]"
			[Register ("isShortText", "()Z", "GetIsShortTextHandler")]
			get {
				const string __id = "isShortText.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLogo;
#pragma warning disable 0169
		static Delegate GetGetLogoHandler ()
		{
			if (cb_getLogo == null)
				cb_getLogo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogo);
			return cb_getLogo;
		}

		static IntPtr n_GetLogo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Logo);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap Logo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionLayout']/method[@name='getLogo' and count(parameter)=0]"
			[Register ("getLogo", "()Landroid/graphics/Bitmap;", "GetGetLogoHandler")]
			get {
				const string __id = "getLogo.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
