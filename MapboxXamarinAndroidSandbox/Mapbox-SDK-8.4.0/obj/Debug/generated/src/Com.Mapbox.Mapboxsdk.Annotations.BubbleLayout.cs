using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/annotations/BubbleLayout", DoNotGenerateAcw=true)]
	public partial class BubbleLayout : global::Android.Widget.LinearLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/field[@name='DEFAULT_STROKE_WIDTH']"
		[Register ("DEFAULT_STROKE_WIDTH")]
		public const float DefaultStrokeWidth = (float) -1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/annotations/BubbleLayout", typeof (BubbleLayout));
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

		protected BubbleLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/constructor[@name='BubbleLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BubbleLayout (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/constructor[@name='BubbleLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BubbleLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/constructor[@name='BubbleLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe BubbleLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getArrowDirection;
#pragma warning disable 0169
		static Delegate GetGetArrowDirectionHandler ()
		{
			if (cb_getArrowDirection == null)
				cb_getArrowDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetArrowDirection);
			return cb_getArrowDirection;
		}

		static IntPtr n_GetArrowDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ArrowDirection);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object ArrowDirection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='getArrowDirection' and count(parameter)=0]"
			[Register ("getArrowDirection", "()Ljava/lang/Object;", "GetGetArrowDirectionHandler")]
			get {
				const string __id = "getArrowDirection.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getArrowHeight;
#pragma warning disable 0169
		static Delegate GetGetArrowHeightHandler ()
		{
			if (cb_getArrowHeight == null)
				cb_getArrowHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetArrowHeight);
			return cb_getArrowHeight;
		}

		static float n_GetArrowHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ArrowHeight;
		}
#pragma warning restore 0169

		public virtual unsafe float ArrowHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='getArrowHeight' and count(parameter)=0]"
			[Register ("getArrowHeight", "()F", "GetGetArrowHeightHandler")]
			get {
				const string __id = "getArrowHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getArrowPosition;
#pragma warning disable 0169
		static Delegate GetGetArrowPositionHandler ()
		{
			if (cb_getArrowPosition == null)
				cb_getArrowPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetArrowPosition);
			return cb_getArrowPosition;
		}

		static float n_GetArrowPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ArrowPosition;
		}
#pragma warning restore 0169

		public virtual unsafe float ArrowPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='getArrowPosition' and count(parameter)=0]"
			[Register ("getArrowPosition", "()F", "GetGetArrowPositionHandler")]
			get {
				const string __id = "getArrowPosition.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getArrowWidth;
#pragma warning disable 0169
		static Delegate GetGetArrowWidthHandler ()
		{
			if (cb_getArrowWidth == null)
				cb_getArrowWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetArrowWidth);
			return cb_getArrowWidth;
		}

		static float n_GetArrowWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ArrowWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float ArrowWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='getArrowWidth' and count(parameter)=0]"
			[Register ("getArrowWidth", "()F", "GetGetArrowWidthHandler")]
			get {
				const string __id = "getArrowWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBubbleColor;
#pragma warning disable 0169
		static Delegate GetGetBubbleColorHandler ()
		{
			if (cb_getBubbleColor == null)
				cb_getBubbleColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBubbleColor);
			return cb_getBubbleColor;
		}

		static int n_GetBubbleColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BubbleColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BubbleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='getBubbleColor' and count(parameter)=0]"
			[Register ("getBubbleColor", "()I", "GetGetBubbleColorHandler")]
			get {
				const string __id = "getBubbleColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCornersRadius;
#pragma warning disable 0169
		static Delegate GetGetCornersRadiusHandler ()
		{
			if (cb_getCornersRadius == null)
				cb_getCornersRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCornersRadius);
			return cb_getCornersRadius;
		}

		static float n_GetCornersRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CornersRadius;
		}
#pragma warning restore 0169

		public virtual unsafe float CornersRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='getCornersRadius' and count(parameter)=0]"
			[Register ("getCornersRadius", "()F", "GetGetCornersRadiusHandler")]
			get {
				const string __id = "getCornersRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStrokeColor;
#pragma warning disable 0169
		static Delegate GetGetStrokeColorHandler ()
		{
			if (cb_getStrokeColor == null)
				cb_getStrokeColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrokeColor);
			return cb_getStrokeColor;
		}

		static int n_GetStrokeColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeColor;
		}
#pragma warning restore 0169

		public virtual unsafe int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				const string __id = "getStrokeColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetStrokeWidthHandler ()
		{
			if (cb_getStrokeWidth == null)
				cb_getStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStrokeWidth);
			return cb_getStrokeWidth;
		}

		static float n_GetStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				const string __id = "getStrokeWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_setArrowHeight_F;
#pragma warning disable 0169
		static Delegate GetSetArrowHeight_FHandler ()
		{
			if (cb_setArrowHeight_F == null)
				cb_setArrowHeight_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetArrowHeight_F);
			return cb_setArrowHeight_F;
		}

		static IntPtr n_SetArrowHeight_F (IntPtr jnienv, IntPtr native__this, float arrowHeight)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetArrowHeight (arrowHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='setArrowHeight' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setArrowHeight", "(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;", "GetSetArrowHeight_FHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout SetArrowHeight (float arrowHeight)
		{
			const string __id = "setArrowHeight.(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (arrowHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setArrowPosition_F;
#pragma warning disable 0169
		static Delegate GetSetArrowPosition_FHandler ()
		{
			if (cb_setArrowPosition_F == null)
				cb_setArrowPosition_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetArrowPosition_F);
			return cb_setArrowPosition_F;
		}

		static IntPtr n_SetArrowPosition_F (IntPtr jnienv, IntPtr native__this, float arrowPosition)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetArrowPosition (arrowPosition));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='setArrowPosition' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setArrowPosition", "(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;", "GetSetArrowPosition_FHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout SetArrowPosition (float arrowPosition)
		{
			const string __id = "setArrowPosition.(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (arrowPosition);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setArrowWidth_F;
#pragma warning disable 0169
		static Delegate GetSetArrowWidth_FHandler ()
		{
			if (cb_setArrowWidth_F == null)
				cb_setArrowWidth_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetArrowWidth_F);
			return cb_setArrowWidth_F;
		}

		static IntPtr n_SetArrowWidth_F (IntPtr jnienv, IntPtr native__this, float arrowWidth)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetArrowWidth (arrowWidth));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='setArrowWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setArrowWidth", "(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;", "GetSetArrowWidth_FHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout SetArrowWidth (float arrowWidth)
		{
			const string __id = "setArrowWidth.(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (arrowWidth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBubbleColor_I;
#pragma warning disable 0169
		static Delegate GetSetBubbleColor_IHandler ()
		{
			if (cb_setBubbleColor_I == null)
				cb_setBubbleColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetBubbleColor_I);
			return cb_setBubbleColor_I;
		}

		static IntPtr n_SetBubbleColor_I (IntPtr jnienv, IntPtr native__this, int bubbleColor)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBubbleColor (bubbleColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='setBubbleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBubbleColor", "(I)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;", "GetSetBubbleColor_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout SetBubbleColor (int bubbleColor)
		{
			const string __id = "setBubbleColor.(I)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bubbleColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCornersRadius_F;
#pragma warning disable 0169
		static Delegate GetSetCornersRadius_FHandler ()
		{
			if (cb_setCornersRadius_F == null)
				cb_setCornersRadius_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetCornersRadius_F);
			return cb_setCornersRadius_F;
		}

		static IntPtr n_SetCornersRadius_F (IntPtr jnienv, IntPtr native__this, float cornersRadius)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCornersRadius (cornersRadius));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='setCornersRadius' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setCornersRadius", "(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;", "GetSetCornersRadius_FHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout SetCornersRadius (float cornersRadius)
		{
			const string __id = "setCornersRadius.(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cornersRadius);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStrokeColor_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeColor_IHandler ()
		{
			if (cb_setStrokeColor_I == null)
				cb_setStrokeColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetStrokeColor_I);
			return cb_setStrokeColor_I;
		}

		static IntPtr n_SetStrokeColor_I (IntPtr jnienv, IntPtr native__this, int strokeColor)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStrokeColor (strokeColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='setStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStrokeColor", "(I)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;", "GetSetStrokeColor_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout SetStrokeColor (int strokeColor)
		{
			const string __id = "setStrokeColor.(I)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (strokeColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStrokeWidth_F;
#pragma warning disable 0169
		static Delegate GetSetStrokeWidth_FHandler ()
		{
			if (cb_setStrokeWidth_F == null)
				cb_setStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetStrokeWidth_F);
			return cb_setStrokeWidth_F;
		}

		static IntPtr n_SetStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float strokeWidth)
		{
			global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStrokeWidth (strokeWidth));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='BubbleLayout']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setStrokeWidth", "(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;", "GetSetStrokeWidth_FHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout SetStrokeWidth (float strokeWidth)
		{
			const string __id = "setStrokeWidth.(F)Lcom/mapbox/mapboxsdk/annotations/BubbleLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (strokeWidth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.BubbleLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
