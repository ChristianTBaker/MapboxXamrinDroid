using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='Formatted']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/types/Formatted", DoNotGenerateAcw=true)]
	public partial class Formatted : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/types/Formatted", typeof (Formatted));
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

		protected Formatted (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='Formatted']/constructor[@name='Formatted' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.types.FormattedSection...']]"
		[Register (".ctor", "([Lcom/mapbox/mapboxsdk/style/types/FormattedSection;)V", "")]
		public unsafe Formatted (params global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection[] formattedSections)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/mapbox/mapboxsdk/style/types/FormattedSection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_formattedSections = JNIEnv.NewArray (formattedSections);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_formattedSections);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (formattedSections != null) {
					JNIEnv.CopyArray (native_formattedSections, formattedSections);
					JNIEnv.DeleteLocalRef (native_formattedSections);
				}
			}
		}

		static Delegate cb_getFormattedSections;
#pragma warning disable 0169
		static Delegate GetGetFormattedSectionsHandler ()
		{
			if (cb_getFormattedSections == null)
				cb_getFormattedSections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormattedSections);
			return cb_getFormattedSections;
		}

		static IntPtr n_GetFormattedSections (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.Formatted __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.Formatted> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFormattedSections ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='Formatted']/method[@name='getFormattedSections' and count(parameter)=0]"
		[Register ("getFormattedSections", "()[Lcom/mapbox/mapboxsdk/style/types/FormattedSection;", "GetGetFormattedSectionsHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection[] GetFormattedSections ()
		{
			const string __id = "getFormattedSections.()[Lcom/mapbox/mapboxsdk/style/types/FormattedSection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mapbox.Mapboxsdk.Style.Types.FormattedSection));
			} finally {
			}
		}

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Types.Formatted __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Types.Formatted> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.types']/class[@name='Formatted']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[Ljava/lang/Object;", "GetToArrayHandler")]
		public virtual unsafe global::Java.Lang.Object[] ToArray ()
		{
			const string __id = "toArray.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

	}
}
