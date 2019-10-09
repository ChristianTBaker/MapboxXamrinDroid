using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser", DoNotGenerateAcw=true)]
	public partial class EGLConfigChooser : global::Java.Lang.Object, global::Android.Opengl.GLSurfaceView.IEGLConfigChooser {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.BufferFormat']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$BufferFormat", DoNotGenerateAcw=true)]
		public sealed partial class BufferFormat : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.BufferFormat']/field[@name='Format16Bit']"
			[Register ("Format16Bit")]
			public static global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat Format16Bit {
				get {
					const string __id = "Format16Bit.Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$BufferFormat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.BufferFormat']/field[@name='Format24Bit']"
			[Register ("Format24Bit")]
			public static global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat Format24Bit {
				get {
					const string __id = "Format24Bit.Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$BufferFormat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.BufferFormat']/field[@name='Format32BitAlpha']"
			[Register ("Format32BitAlpha")]
			public static global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat Format32BitAlpha {
				get {
					const string __id = "Format32BitAlpha.Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$BufferFormat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.BufferFormat']/field[@name='Format32BitNoAlpha']"
			[Register ("Format32BitNoAlpha")]
			public static global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat Format32BitNoAlpha {
				get {
					const string __id = "Format32BitNoAlpha.Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$BufferFormat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.BufferFormat']/field[@name='Unknown']"
			[Register ("Unknown")]
			public static global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat Unknown {
				get {
					const string __id = "Unknown.Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$BufferFormat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$BufferFormat", typeof (BufferFormat));
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

			internal BufferFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.BufferFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Ljava/lang/Enum;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.BufferFormat']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$BufferFormat;", "")]
			public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat[] Values ()
			{
				const string __id = "values.()[Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$BufferFormat;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.BufferFormat));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.DepthStencilFormat']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$DepthStencilFormat", DoNotGenerateAcw=true)]
		public sealed partial class DepthStencilFormat : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.DepthStencilFormat']/field[@name='Format16Depth8Stencil']"
			[Register ("Format16Depth8Stencil")]
			public static global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.DepthStencilFormat Format16Depth8Stencil {
				get {
					const string __id = "Format16Depth8Stencil.Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$DepthStencilFormat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.DepthStencilFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.DepthStencilFormat']/field[@name='Format24Depth8Stencil']"
			[Register ("Format24Depth8Stencil")]
			public static global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.DepthStencilFormat Format24Depth8Stencil {
				get {
					const string __id = "Format24Depth8Stencil.Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$DepthStencilFormat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.DepthStencilFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$DepthStencilFormat", typeof (DepthStencilFormat));
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

			internal DepthStencilFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.DepthStencilFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Ljava/lang/Enum;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser.DepthStencilFormat']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$DepthStencilFormat;", "")]
			public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.DepthStencilFormat[] Values ()
			{
				const string __id = "values.()[Lcom/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser$DepthStencilFormat;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.DepthStencilFormat[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser.DepthStencilFormat));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/renderer/egl/EGLConfigChooser", typeof (EGLConfigChooser));
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

		protected EGLConfigChooser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser']/constructor[@name='EGLConfigChooser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EGLConfigChooser ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser']/constructor[@name='EGLConfigChooser' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe EGLConfigChooser (bool translucentSurface)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (translucentSurface);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_;
#pragma warning disable 0169
		static Delegate GetChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Handler ()
		{
			if (cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_ == null)
				cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_);
			return cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_;
		}

		static IntPtr n_ChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_egl, IntPtr native_display)
		{
			global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.Renderer.Egl.EGLConfigChooser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Egl.IEGL10 egl = (global::Javax.Microedition.Khronos.Egl.IEGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.IEGL10> (native_egl, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Egl.EGLDisplay display = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLDisplay> (native_display, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ChooseConfig (egl, display));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps.renderer.egl']/class[@name='EGLConfigChooser']/method[@name='chooseConfig' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.egl.EGL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLDisplay']]"
		[Register ("chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;", "GetChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Handler")]
		public virtual unsafe global::Javax.Microedition.Khronos.Egl.EGLConfig ChooseConfig (global::Javax.Microedition.Khronos.Egl.IEGL10 egl, global::Javax.Microedition.Khronos.Egl.EGLDisplay display)
		{
			const string __id = "chooseConfig.(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((egl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) egl).Handle);
				__args [1] = new JniArgumentValue ((display == null) ? IntPtr.Zero : ((global::Java.Lang.Object) display).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
