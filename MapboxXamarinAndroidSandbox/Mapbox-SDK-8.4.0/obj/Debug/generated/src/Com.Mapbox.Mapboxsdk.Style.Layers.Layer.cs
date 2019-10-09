using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/Layer", DoNotGenerateAcw=true)]
	public abstract partial class Layer : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/Layer", typeof (Layer));
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

		protected Layer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/constructor[@name='Layer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Layer ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/constructor[@name='Layer' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe Layer (long nativePtr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativePtr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDetached;
#pragma warning disable 0169
		static Delegate GetIsDetachedHandler ()
		{
			if (cb_isDetached == null)
				cb_isDetached = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDetached);
			return cb_isDetached;
		}

		static bool n_IsDetached (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDetached;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDetached {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='isDetached' and count(parameter)=0]"
			[Register ("isDetached", "()Z", "GetIsDetachedHandler")]
			get {
				const string __id = "isDetached.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxZoom;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomHandler ()
		{
			if (cb_getMaxZoom == null)
				cb_getMaxZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxZoom);
			return cb_getMaxZoom;
		}

		static float n_GetMaxZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoom;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxZoom_F;
#pragma warning disable 0169
		static Delegate GetSetMaxZoom_FHandler ()
		{
			if (cb_setMaxZoom_F == null)
				cb_setMaxZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxZoom_F);
			return cb_setMaxZoom_F;
		}

		static void n_SetMaxZoom_F (IntPtr jnienv, IntPtr native__this, float zoom)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxZoom = zoom;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='getMaxZoom' and count(parameter)=0]"
			[Register ("getMaxZoom", "()F", "GetGetMaxZoomHandler")]
			get {
				const string __id = "getMaxZoom.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='setMaxZoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxZoom", "(F)V", "GetSetMaxZoom_FHandler")]
			set {
				const string __id = "setMaxZoom.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinZoom;
#pragma warning disable 0169
		static Delegate GetGetMinZoomHandler ()
		{
			if (cb_getMinZoom == null)
				cb_getMinZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinZoom);
			return cb_getMinZoom;
		}

		static float n_GetMinZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoom;
		}
#pragma warning restore 0169

		static Delegate cb_setMinZoom_F;
#pragma warning disable 0169
		static Delegate GetSetMinZoom_FHandler ()
		{
			if (cb_setMinZoom_F == null)
				cb_setMinZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinZoom_F);
			return cb_setMinZoom_F;
		}

		static void n_SetMinZoom_F (IntPtr jnienv, IntPtr native__this, float zoom)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinZoom = zoom;
		}
#pragma warning restore 0169

		public virtual unsafe float MinZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='getMinZoom' and count(parameter)=0]"
			[Register ("getMinZoom", "()F", "GetGetMinZoomHandler")]
			get {
				const string __id = "getMinZoom.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='setMinZoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinZoom", "(F)V", "GetSetMinZoom_FHandler")]
			set {
				const string __id = "setMinZoom.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNativePtr;
#pragma warning disable 0169
		static Delegate GetGetNativePtrHandler ()
		{
			if (cb_getNativePtr == null)
				cb_getNativePtr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativePtr);
			return cb_getNativePtr;
		}

		static long n_GetNativePtr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativePtr;
		}
#pragma warning restore 0169

		public virtual unsafe long NativePtr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='getNativePtr' and count(parameter)=0]"
			[Register ("getNativePtr", "()J", "GetGetNativePtrHandler")]
			get {
				const string __id = "getNativePtr.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVisibility;
#pragma warning disable 0169
		static Delegate GetGetVisibilityHandler ()
		{
			if (cb_getVisibility == null)
				cb_getVisibility = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisibility);
			return cb_getVisibility;
		}

		static IntPtr n_GetVisibility (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Visibility);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue Visibility {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='getVisibility' and count(parameter)=0]"
			[Register ("getVisibility", "()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "GetGetVisibilityHandler")]
			get {
				const string __id = "getVisibility.()Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkThread;
#pragma warning disable 0169
		static Delegate GetCheckThreadHandler ()
		{
			if (cb_checkThread == null)
				cb_checkThread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckThread);
			return cb_checkThread;
		}

		static void n_CheckThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckThread ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='checkThread' and count(parameter)=0]"
		[Register ("checkThread", "()V", "GetCheckThreadHandler")]
		protected virtual unsafe void CheckThread ()
		{
			const string __id = "checkThread.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_nativeGetId;
#pragma warning disable 0169
		static Delegate GetNativeGetIdHandler ()
		{
			if (cb_nativeGetId == null)
				cb_nativeGetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NativeGetId);
			return cb_nativeGetId;
		}

		static IntPtr n_NativeGetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NativeGetId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeGetId' and count(parameter)=0]"
		[Register ("nativeGetId", "()Ljava/lang/String;", "GetNativeGetIdHandler")]
		protected virtual unsafe string NativeGetId ()
		{
			const string __id = "nativeGetId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nativeGetMaxZoom;
#pragma warning disable 0169
		static Delegate GetNativeGetMaxZoomHandler ()
		{
			if (cb_nativeGetMaxZoom == null)
				cb_nativeGetMaxZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_NativeGetMaxZoom);
			return cb_nativeGetMaxZoom;
		}

		static float n_NativeGetMaxZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeGetMaxZoom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeGetMaxZoom' and count(parameter)=0]"
		[Register ("nativeGetMaxZoom", "()F", "GetNativeGetMaxZoomHandler")]
		protected virtual unsafe float NativeGetMaxZoom ()
		{
			const string __id = "nativeGetMaxZoom.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nativeGetMinZoom;
#pragma warning disable 0169
		static Delegate GetNativeGetMinZoomHandler ()
		{
			if (cb_nativeGetMinZoom == null)
				cb_nativeGetMinZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_NativeGetMinZoom);
			return cb_nativeGetMinZoom;
		}

		static float n_NativeGetMinZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeGetMinZoom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeGetMinZoom' and count(parameter)=0]"
		[Register ("nativeGetMinZoom", "()F", "GetNativeGetMinZoomHandler")]
		protected virtual unsafe float NativeGetMinZoom ()
		{
			const string __id = "nativeGetMinZoom.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nativeGetSourceId;
#pragma warning disable 0169
		static Delegate GetNativeGetSourceIdHandler ()
		{
			if (cb_nativeGetSourceId == null)
				cb_nativeGetSourceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NativeGetSourceId);
			return cb_nativeGetSourceId;
		}

		static IntPtr n_NativeGetSourceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NativeGetSourceId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeGetSourceId' and count(parameter)=0]"
		[Register ("nativeGetSourceId", "()Ljava/lang/String;", "GetNativeGetSourceIdHandler")]
		protected virtual unsafe string NativeGetSourceId ()
		{
			const string __id = "nativeGetSourceId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nativeGetSourceLayer;
#pragma warning disable 0169
		static Delegate GetNativeGetSourceLayerHandler ()
		{
			if (cb_nativeGetSourceLayer == null)
				cb_nativeGetSourceLayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NativeGetSourceLayer);
			return cb_nativeGetSourceLayer;
		}

		static IntPtr n_NativeGetSourceLayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NativeGetSourceLayer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeGetSourceLayer' and count(parameter)=0]"
		[Register ("nativeGetSourceLayer", "()Ljava/lang/String;", "GetNativeGetSourceLayerHandler")]
		protected virtual unsafe string NativeGetSourceLayer ()
		{
			const string __id = "nativeGetSourceLayer.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nativeGetVisibility;
#pragma warning disable 0169
		static Delegate GetNativeGetVisibilityHandler ()
		{
			if (cb_nativeGetVisibility == null)
				cb_nativeGetVisibility = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NativeGetVisibility);
			return cb_nativeGetVisibility;
		}

		static IntPtr n_NativeGetVisibility (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NativeGetVisibility ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeGetVisibility' and count(parameter)=0]"
		[Register ("nativeGetVisibility", "()Ljava/lang/Object;", "GetNativeGetVisibilityHandler")]
		protected virtual unsafe global::Java.Lang.Object NativeGetVisibility ()
		{
			const string __id = "nativeGetVisibility.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nativeSetFilter_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetNativeSetFilter_arrayLjava_lang_Object_Handler ()
		{
			if (cb_nativeSetFilter_arrayLjava_lang_Object_ == null)
				cb_nativeSetFilter_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NativeSetFilter_arrayLjava_lang_Object_);
			return cb_nativeSetFilter_arrayLjava_lang_Object_;
		}

		static void n_NativeSetFilter_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.NativeSetFilter (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeSetFilter' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("nativeSetFilter", "([Ljava/lang/Object;)V", "GetNativeSetFilter_arrayLjava_lang_Object_Handler")]
		protected virtual unsafe void NativeSetFilter (global::Java.Lang.Object[] p0)
		{
			const string __id = "nativeSetFilter.([Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_nativeSetLayoutProperty_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetNativeSetLayoutProperty_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_nativeSetLayoutProperty_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_nativeSetLayoutProperty_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_NativeSetLayoutProperty_Ljava_lang_String_Ljava_lang_Object_);
			return cb_nativeSetLayoutProperty_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_NativeSetLayoutProperty_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetLayoutProperty (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeSetLayoutProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("nativeSetLayoutProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetNativeSetLayoutProperty_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void NativeSetLayoutProperty (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "nativeSetLayoutProperty.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_nativeSetMaxZoom_F;
#pragma warning disable 0169
		static Delegate GetNativeSetMaxZoom_FHandler ()
		{
			if (cb_nativeSetMaxZoom_F == null)
				cb_nativeSetMaxZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_NativeSetMaxZoom_F);
			return cb_nativeSetMaxZoom_F;
		}

		static void n_NativeSetMaxZoom_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetMaxZoom (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeSetMaxZoom' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("nativeSetMaxZoom", "(F)V", "GetNativeSetMaxZoom_FHandler")]
		protected virtual unsafe void NativeSetMaxZoom (float p0)
		{
			const string __id = "nativeSetMaxZoom.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_nativeSetMinZoom_F;
#pragma warning disable 0169
		static Delegate GetNativeSetMinZoom_FHandler ()
		{
			if (cb_nativeSetMinZoom_F == null)
				cb_nativeSetMinZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_NativeSetMinZoom_F);
			return cb_nativeSetMinZoom_F;
		}

		static void n_NativeSetMinZoom_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetMinZoom (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeSetMinZoom' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("nativeSetMinZoom", "(F)V", "GetNativeSetMinZoom_FHandler")]
		protected virtual unsafe void NativeSetMinZoom (float p0)
		{
			const string __id = "nativeSetMinZoom.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_nativeSetPaintProperty_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetNativeSetPaintProperty_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_nativeSetPaintProperty_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_nativeSetPaintProperty_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_NativeSetPaintProperty_Ljava_lang_String_Ljava_lang_Object_);
			return cb_nativeSetPaintProperty_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_NativeSetPaintProperty_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetPaintProperty (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeSetPaintProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("nativeSetPaintProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetNativeSetPaintProperty_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void NativeSetPaintProperty (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "nativeSetPaintProperty.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_nativeSetSourceLayer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNativeSetSourceLayer_Ljava_lang_String_Handler ()
		{
			if (cb_nativeSetSourceLayer_Ljava_lang_String_ == null)
				cb_nativeSetSourceLayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NativeSetSourceLayer_Ljava_lang_String_);
			return cb_nativeSetSourceLayer_Ljava_lang_String_;
		}

		static void n_NativeSetSourceLayer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetSourceLayer (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='nativeSetSourceLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("nativeSetSourceLayer", "(Ljava/lang/String;)V", "GetNativeSetSourceLayer_Ljava_lang_String_Handler")]
		protected virtual unsafe void NativeSetSourceLayer (string p0)
		{
			const string __id = "nativeSetSourceLayer.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDetached;
#pragma warning disable 0169
		static Delegate GetSetDetachedHandler ()
		{
			if (cb_setDetached == null)
				cb_setDetached = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetDetached);
			return cb_setDetached;
		}

		static void n_SetDetached (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDetached ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='setDetached' and count(parameter)=0]"
		[Register ("setDetached", "()V", "GetSetDetachedHandler")]
		public virtual unsafe void SetDetached ()
		{
			const string __id = "setDetached.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_;
#pragma warning disable 0169
		static Delegate GetSetProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_Handler ()
		{
			if (cb_setProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_ == null)
				cb_setProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_);
			return cb_setProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_;
		}

		static void n_SetProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_properties)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties = (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[]) JNIEnv.GetArray (native_properties, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue));
			__this.SetProperties (properties);
			if (properties != null)
				JNIEnv.CopyArray (properties, native_properties);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='Layer']/method[@name='setProperties' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.layers.PropertyValue&lt;?&gt;...']]"
		[Register ("setProperties", "([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)V", "GetSetProperties_arrayLcom_mapbox_mapboxsdk_style_layers_PropertyValue_Handler")]
		public virtual unsafe void SetProperties (params global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue[] properties)
		{
			const string __id = "setProperties.([Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;)V";
			IntPtr native_properties = JNIEnv.NewArray (properties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_properties);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (properties != null) {
					JNIEnv.CopyArray (native_properties, properties);
					JNIEnv.DeleteLocalRef (native_properties);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/Layer", DoNotGenerateAcw=true)]
	internal partial class LayerInvoker : Layer {

		public LayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/style/layers/Layer", typeof (LayerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
