using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps.Widgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/widgets/CompassView", DoNotGenerateAcw=true)]
	public sealed partial class CompassView : global::Android.Widget.ImageView, global::Java.Lang.IRunnable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/field[@name='TIME_MAP_NORTH_ANIMATION']"
		[Register ("TIME_MAP_NORTH_ANIMATION")]
		public const long TimeMapNorthAnimation = (long) 150;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/field[@name='TIME_WAIT_IDLE']"
		[Register ("TIME_WAIT_IDLE")]
		public const long TimeWaitIdle = (long) 500;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/widgets/CompassView", typeof (CompassView));
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

		internal CompassView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/constructor[@name='CompassView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CompassView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/constructor[@name='CompassView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CompassView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/constructor[@name='CompassView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CompassView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		public unsafe global::Android.Graphics.Drawables.Drawable CompassImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='getCompassImage' and count(parameter)=0]"
			[Register ("getCompassImage", "()Landroid/graphics/drawable/Drawable;", "GetGetCompassImageHandler")]
			get {
				const string __id = "getCompassImage.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='setCompassImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setCompassImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetCompassImage_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setCompassImage.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool IsFacingNorth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='isFacingNorth' and count(parameter)=0]"
			[Register ("isFacingNorth", "()Z", "GetIsFacingNorthHandler")]
			get {
				const string __id = "isFacingNorth.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsFadeCompassViewFacingNorth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='isFadeCompassViewFacingNorth' and count(parameter)=0]"
			[Register ("isFadeCompassViewFacingNorth", "()Z", "GetIsFadeCompassViewFacingNorthHandler")]
			get {
				const string __id = "isFadeCompassViewFacingNorth.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsHidden {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='isHidden' and count(parameter)=0]"
			[Register ("isHidden", "()Z", "GetIsHiddenHandler")]
			get {
				const string __id = "isHidden.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='fadeCompassViewFacingNorth' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("fadeCompassViewFacingNorth", "(Z)V", "")]
		public unsafe void FadeCompassViewFacingNorth (bool compassFadeFacingNorth)
		{
			const string __id = "fadeCompassViewFacingNorth.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (compassFadeFacingNorth);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='injectCompassAnimationListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap.OnCompassAnimationListener']]"
		[Register ("injectCompassAnimationListener", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCompassAnimationListener;)V", "")]
		public unsafe void InjectCompassAnimationListener (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnCompassAnimationListener compassAnimationListener)
		{
			const string __id = "injectCompassAnimationListener.(Lcom/mapbox/mapboxsdk/maps/MapboxMap$OnCompassAnimationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((compassAnimationListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compassAnimationListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='isAnimating' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isAnimating", "(Z)V", "")]
		public unsafe void IsAnimating (bool isAnimating)
		{
			const string __id = "isAnimating.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isAnimating);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='resetAnimation' and count(parameter)=0]"
		[Register ("resetAnimation", "()V", "")]
		public unsafe void ResetAnimation ()
		{
			const string __id = "resetAnimation.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "")]
		public unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.widgets']/class[@name='CompassView']/method[@name='update' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("update", "(D)V", "")]
		public unsafe void Update (double bearing)
		{
			const string __id = "update.(D)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bearing);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
