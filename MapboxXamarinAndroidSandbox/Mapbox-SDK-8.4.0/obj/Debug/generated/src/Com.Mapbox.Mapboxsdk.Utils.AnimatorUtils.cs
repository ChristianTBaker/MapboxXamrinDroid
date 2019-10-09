using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/AnimatorUtils", DoNotGenerateAcw=true)]
	public partial class AnimatorUtils : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/interface[@name='AnimatorUtils.OnAnimationEndListener']"
		[Register ("com/mapbox/mapboxsdk/utils/AnimatorUtils$OnAnimationEndListener", "", "Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils/IOnAnimationEndListenerInvoker")]
		public partial interface IOnAnimationEndListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/interface[@name='AnimatorUtils.OnAnimationEndListener']/method[@name='onAnimationEnd' and count(parameter)=0]"
			[Register ("onAnimationEnd", "()V", "GetOnAnimationEndHandler:Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils/IOnAnimationEndListenerInvoker, Mapbox-SDK-8.4.0")]
			void OnAnimationEnd ();

		}

		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/utils/AnimatorUtils$OnAnimationEndListener", DoNotGenerateAcw=true)]
		internal class IOnAnimationEndListenerInvoker : global::Java.Lang.Object, IOnAnimationEndListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/utils/AnimatorUtils$OnAnimationEndListener", typeof (IOnAnimationEndListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnAnimationEndListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAnimationEndListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.mapboxsdk.utils.AnimatorUtils.OnAnimationEndListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAnimationEndListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onAnimationEnd;
#pragma warning disable 0169
			static Delegate GetOnAnimationEndHandler ()
			{
				if (cb_onAnimationEnd == null)
					cb_onAnimationEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationEnd);
				return cb_onAnimationEnd;
			}

			static void n_OnAnimationEnd (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils.IOnAnimationEndListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils.IOnAnimationEndListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationEnd ();
			}
#pragma warning restore 0169

			IntPtr id_onAnimationEnd;
			public unsafe void OnAnimationEnd ()
			{
				if (id_onAnimationEnd == IntPtr.Zero)
					id_onAnimationEnd = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnimationEnd);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mapbox/mapboxsdk/utils/AnimatorUtils_OnAnimationEndListenerImplementor")]
		internal sealed partial class IOnAnimationEndListenerImplementor : global::Java.Lang.Object, IOnAnimationEndListener {

			object sender;

			public IOnAnimationEndListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mapbox/mapboxsdk/utils/AnimatorUtils_OnAnimationEndListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnAnimationEnd ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnAnimationEndListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/utils/AnimatorUtils", typeof (AnimatorUtils));
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

		protected AnimatorUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']/constructor[@name='AnimatorUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimatorUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']/method[@name='alpha' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("alpha", "(Landroid/view/View;F)V", "")]
		public static unsafe void Alpha (global::Android.Views.View convertView, float alpha)
		{
			const string __id = "alpha.(Landroid/view/View;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((convertView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) convertView).Handle);
				__args [1] = new JniArgumentValue (alpha);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']/method[@name='alpha' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='com.mapbox.mapboxsdk.utils.AnimatorUtils.OnAnimationEndListener']]"
		[Register ("alpha", "(Landroid/view/View;FLcom/mapbox/mapboxsdk/utils/AnimatorUtils$OnAnimationEndListener;)V", "")]
		public static unsafe void Alpha (global::Android.Views.View convertView, float alpha, global::Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils.IOnAnimationEndListener listener)
		{
			const string __id = "alpha.(Landroid/view/View;FLcom/mapbox/mapboxsdk/utils/AnimatorUtils$OnAnimationEndListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((convertView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) convertView).Handle);
				__args [1] = new JniArgumentValue (alpha);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']/method[@name='animate' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("animate", "(Landroid/view/View;I)V", "")]
		public static unsafe void Animate (global::Android.Views.View view, int animatorRes)
		{
			const string __id = "animate.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (animatorRes);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']/method[@name='animate' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='com.mapbox.mapboxsdk.utils.AnimatorUtils.OnAnimationEndListener']]"
		[Register ("animate", "(Landroid/view/View;ILcom/mapbox/mapboxsdk/utils/AnimatorUtils$OnAnimationEndListener;)V", "")]
		public static unsafe void Animate (global::Android.Views.View view, int animatorRes, global::Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils.IOnAnimationEndListener listener)
		{
			const string __id = "animate.(Landroid/view/View;ILcom/mapbox/mapboxsdk/utils/AnimatorUtils$OnAnimationEndListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (animatorRes);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']/method[@name='animate' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("animate", "(Landroid/view/View;II)V", "")]
		public static unsafe void Animate (global::Android.Views.View view, int animatorRes, int duration)
		{
			const string __id = "animate.(Landroid/view/View;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (animatorRes);
				__args [2] = new JniArgumentValue (duration);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']/method[@name='animate' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.mapbox.mapboxsdk.utils.AnimatorUtils.OnAnimationEndListener']]"
		[Register ("animate", "(Landroid/view/View;IILcom/mapbox/mapboxsdk/utils/AnimatorUtils$OnAnimationEndListener;)V", "")]
		public static unsafe void Animate (global::Android.Views.View view, int animatorRes, int duration, global::Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils.IOnAnimationEndListener listener)
		{
			const string __id = "animate.(Landroid/view/View;IILcom/mapbox/mapboxsdk/utils/AnimatorUtils$OnAnimationEndListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (animatorRes);
				__args [2] = new JniArgumentValue (duration);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']/method[@name='rotate' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("rotate", "(Landroid/view/View;F)V", "")]
		public static unsafe void Rotate (global::Android.Views.View view, float rotation)
		{
			const string __id = "rotate.(Landroid/view/View;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (rotation);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.utils']/class[@name='AnimatorUtils']/method[@name='rotateBy' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("rotateBy", "(Landroid/view/View;F)V", "")]
		public static unsafe void RotateBy (global::Android.Views.View view, float rotationBy)
		{
			const string __id = "rotateBy.(Landroid/view/View;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (rotationBy);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
