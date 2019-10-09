using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Plugins.Annotation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/plugins/annotation/AnnotationManager", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L extends com.mapbox.mapboxsdk.style.layers.Layer", "T extends com.mapbox.mapboxsdk.plugins.annotation.Annotation", "S extends com.mapbox.mapboxsdk.plugins.annotation.Options<T>", "D extends com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationDragListener<T>", "U extends com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationClickListener<T>", "V extends com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationLongClickListener<T>"})]
	public abstract partial class AnnotationManager : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/field[@name='layer']"
		[Register ("layer")]
		protected global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer Layer {
			get {
				const string __id = "layer.Lcom/mapbox/mapboxsdk/style/layers/Layer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.Layer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "layer.Lcom/mapbox/mapboxsdk/style/layers/Layer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/field[@name='mapboxMap']"
		[Register ("mapboxMap")]
		protected global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap MapboxMap {
			get {
				const string __id = "mapboxMap.Lcom/mapbox/mapboxsdk/maps/MapboxMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mapboxMap.Lcom/mapbox/mapboxsdk/maps/MapboxMap;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/plugins/annotation/AnnotationManager", typeof (AnnotationManager));
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

		protected AnnotationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_;
#pragma warning disable 0169
		static Delegate GetAddClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_Handler ()
		{
			if (cb_addClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_ == null)
				cb_addClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_);
			return cb_addClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_;
		}

		static void n_AddClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_u)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object u = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_u, JniHandleOwnership.DoNotTransfer);
			__this.AddClickListener (u);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='addClickListener' and count(parameter)=1 and parameter[1][@type='U']]"
		[Register ("addClickListener", "(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationClickListener;)V", "GetAddClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_Handler")]
		public virtual unsafe void AddClickListener (global::Java.Lang.Object u)
		{
			const string __id = "addClickListener.(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationClickListener;)V";
			IntPtr native_u = JNIEnv.ToLocalJniHandle (u);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_u);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_u);
			}
		}

		static Delegate cb_addDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_;
#pragma warning disable 0169
		static Delegate GetAddDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_Handler ()
		{
			if (cb_addDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_ == null)
				cb_addDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_);
			return cb_addDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_;
		}

		static void n_AddDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object d = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_d, JniHandleOwnership.DoNotTransfer);
			__this.AddDragListener (d);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='addDragListener' and count(parameter)=1 and parameter[1][@type='D']]"
		[Register ("addDragListener", "(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationDragListener;)V", "GetAddDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_Handler")]
		public virtual unsafe void AddDragListener (global::Java.Lang.Object d)
		{
			const string __id = "addDragListener.(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationDragListener;)V";
			IntPtr native_d = JNIEnv.ToLocalJniHandle (d);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_d);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_d);
			}
		}

		static Delegate cb_addLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_;
#pragma warning disable 0169
		static Delegate GetAddLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_Handler ()
		{
			if (cb_addLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_ == null)
				cb_addLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_);
			return cb_addLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_;
		}

		static void n_AddLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object v = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.AddLongClickListener (v);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='addLongClickListener' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register ("addLongClickListener", "(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationLongClickListener;)V", "GetAddLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_Handler")]
		public virtual unsafe void AddLongClickListener (global::Java.Lang.Object v)
		{
			const string __id = "addLongClickListener.(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationLongClickListener;)V";
			IntPtr native_v = JNIEnv.ToLocalJniHandle (v);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_v);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_v);
			}
		}

		static Delegate cb_create_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetCreate_Ljava_util_List_Handler ()
		{
			if (cb_create_Ljava_util_List_ == null)
				cb_create_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Ljava_util_List_);
			return cb_create_Ljava_util_List_;
		}

		static IntPtr n_Create_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_optionsList)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var optionsList = global::Android.Runtime.JavaList.FromJniHandle (native_optionsList, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Create (optionsList));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;S&gt;']]"
		[Register ("create", "(Ljava/util/List;)Ljava/util/List;", "GetCreate_Ljava_util_List_Handler")]
		public virtual unsafe global::System.Collections.IList Create (global::System.Collections.IList optionsList)
		{
			const string __id = "create.(Ljava/util/List;)Ljava/util/List;";
			IntPtr native_optionsList = global::Android.Runtime.JavaList.ToLocalJniHandle (optionsList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_optionsList);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_optionsList);
			}
		}

		static Delegate cb_create_Lcom_mapbox_mapboxsdk_plugins_annotation_Options_;
#pragma warning disable 0169
		static Delegate GetCreate_Lcom_mapbox_mapboxsdk_plugins_annotation_Options_Handler ()
		{
			if (cb_create_Lcom_mapbox_mapboxsdk_plugins_annotation_Options_ == null)
				cb_create_Lcom_mapbox_mapboxsdk_plugins_annotation_Options_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Lcom_mapbox_mapboxsdk_plugins_annotation_Options_);
			return cb_create_Lcom_mapbox_mapboxsdk_plugins_annotation_Options_;
		}

		static IntPtr n_Create_Lcom_mapbox_mapboxsdk_plugins_annotation_Options_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object options = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (options));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='create' and count(parameter)=1 and parameter[1][@type='S']]"
		[Register ("create", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Options;)Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;", "GetCreate_Lcom_mapbox_mapboxsdk_plugins_annotation_Options_Handler")]
		public virtual unsafe global::Java.Lang.Object Create (global::Java.Lang.Object options)
		{
			const string __id = "create.(Lcom/mapbox/mapboxsdk/plugins/annotation/Options;)Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;";
			IntPtr native_options = JNIEnv.ToLocalJniHandle (options);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_options);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_options);
			}
		}

		static Delegate cb_delete_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_util_List_Handler ()
		{
			if (cb_delete_Ljava_util_List_ == null)
				cb_delete_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_util_List_);
			return cb_delete_Ljava_util_List_;
		}

		static void n_Delete_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotationList)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var annotationList = global::Android.Runtime.JavaList.FromJniHandle (native_annotationList, JniHandleOwnership.DoNotTransfer);
			__this.Delete (annotationList);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("delete", "(Ljava/util/List;)V", "GetDelete_Ljava_util_List_Handler")]
		public virtual unsafe void Delete (global::System.Collections.IList annotationList)
		{
			const string __id = "delete.(Ljava/util/List;)V";
			IntPtr native_annotationList = global::Android.Runtime.JavaList.ToLocalJniHandle (annotationList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_annotationList);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_annotationList);
			}
		}

		static Delegate cb_delete_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler ()
		{
			if (cb_delete_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == null)
				cb_delete_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_);
			return cb_delete_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		}

		static void n_Delete_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotation)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object annotation = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_annotation, JniHandleOwnership.DoNotTransfer);
			__this.Delete (annotation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("delete", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V", "GetDelete_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler")]
		public virtual unsafe void Delete (global::Java.Lang.Object annotation)
		{
			const string __id = "delete.(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V";
			IntPtr native_annotation = JNIEnv.ToLocalJniHandle (annotation);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_annotation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_annotation);
			}
		}

		static Delegate cb_deleteAll;
#pragma warning disable 0169
		static Delegate GetDeleteAllHandler ()
		{
			if (cb_deleteAll == null)
				cb_deleteAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteAll);
			return cb_deleteAll;
		}

		static void n_DeleteAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()V", "GetDeleteAllHandler")]
		public virtual unsafe void DeleteAll ()
		{
			const string __id = "deleteAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_;
#pragma warning disable 0169
		static Delegate GetRemoveClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_Handler ()
		{
			if (cb_removeClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_ == null)
				cb_removeClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_);
			return cb_removeClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_;
		}

		static void n_RemoveClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_u)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object u = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_u, JniHandleOwnership.DoNotTransfer);
			__this.RemoveClickListener (u);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='removeClickListener' and count(parameter)=1 and parameter[1][@type='U']]"
		[Register ("removeClickListener", "(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationClickListener;)V", "GetRemoveClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationClickListener_Handler")]
		public virtual unsafe void RemoveClickListener (global::Java.Lang.Object u)
		{
			const string __id = "removeClickListener.(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationClickListener;)V";
			IntPtr native_u = JNIEnv.ToLocalJniHandle (u);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_u);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_u);
			}
		}

		static Delegate cb_removeDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_;
#pragma warning disable 0169
		static Delegate GetRemoveDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_Handler ()
		{
			if (cb_removeDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_ == null)
				cb_removeDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_);
			return cb_removeDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_;
		}

		static void n_RemoveDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object d = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_d, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDragListener (d);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='removeDragListener' and count(parameter)=1 and parameter[1][@type='D']]"
		[Register ("removeDragListener", "(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationDragListener;)V", "GetRemoveDragListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationDragListener_Handler")]
		public virtual unsafe void RemoveDragListener (global::Java.Lang.Object d)
		{
			const string __id = "removeDragListener.(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationDragListener;)V";
			IntPtr native_d = JNIEnv.ToLocalJniHandle (d);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_d);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_d);
			}
		}

		static Delegate cb_removeLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_;
#pragma warning disable 0169
		static Delegate GetRemoveLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_Handler ()
		{
			if (cb_removeLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_ == null)
				cb_removeLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_);
			return cb_removeLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_;
		}

		static void n_RemoveLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object v = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLongClickListener (v);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='removeLongClickListener' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register ("removeLongClickListener", "(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationLongClickListener;)V", "GetRemoveLongClickListener_Lcom_mapbox_mapboxsdk_plugins_annotation_OnAnnotationLongClickListener_Handler")]
		public virtual unsafe void RemoveLongClickListener (global::Java.Lang.Object v)
		{
			const string __id = "removeLongClickListener.(Lcom/mapbox/mapboxsdk/plugins/annotation/OnAnnotationLongClickListener;)V";
			IntPtr native_v = JNIEnv.ToLocalJniHandle (v);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_v);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_v);
			}
		}

		static Delegate cb_setDataDrivenPropertyIsUsed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDataDrivenPropertyIsUsed_Ljava_lang_String_Handler ()
		{
			if (cb_setDataDrivenPropertyIsUsed_Ljava_lang_String_ == null)
				cb_setDataDrivenPropertyIsUsed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataDrivenPropertyIsUsed_Ljava_lang_String_);
			return cb_setDataDrivenPropertyIsUsed_Ljava_lang_String_;
		}

		static void n_SetDataDrivenPropertyIsUsed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataDrivenPropertyIsUsed (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='setDataDrivenPropertyIsUsed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDataDrivenPropertyIsUsed", "(Ljava/lang/String;)V", "GetSetDataDrivenPropertyIsUsed_Ljava_lang_String_Handler")]
		protected abstract void SetDataDrivenPropertyIsUsed (string p0);

		static Delegate cb_update_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_util_List_Handler ()
		{
			if (cb_update_Ljava_util_List_ == null)
				cb_update_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Update_Ljava_util_List_);
			return cb_update_Ljava_util_List_;
		}

		static void n_Update_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotationList)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var annotationList = global::Android.Runtime.JavaList.FromJniHandle (native_annotationList, JniHandleOwnership.DoNotTransfer);
			__this.Update (annotationList);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='update' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("update", "(Ljava/util/List;)V", "GetUpdate_Ljava_util_List_Handler")]
		public virtual unsafe void Update (global::System.Collections.IList annotationList)
		{
			const string __id = "update.(Ljava/util/List;)V";
			IntPtr native_annotationList = global::Android.Runtime.JavaList.ToLocalJniHandle (annotationList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_annotationList);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_annotationList);
			}
		}

		static Delegate cb_update_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler ()
		{
			if (cb_update_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ == null)
				cb_update_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Update_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_);
			return cb_update_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_;
		}

		static void n_Update_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotation)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object annotation = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_annotation, JniHandleOwnership.DoNotTransfer);
			__this.Update (annotation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='update' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("update", "(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V", "GetUpdate_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler")]
		public virtual unsafe void Update (global::Java.Lang.Object annotation)
		{
			const string __id = "update.(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V";
			IntPtr native_annotation = JNIEnv.ToLocalJniHandle (annotation);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_annotation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_annotation);
			}
		}

		static Delegate cb_updateSource;
#pragma warning disable 0169
		static Delegate GetUpdateSourceHandler ()
		{
			if (cb_updateSource == null)
				cb_updateSource = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateSource);
			return cb_updateSource;
		}

		static void n_UpdateSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Annotation.AnnotationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSource ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='updateSource' and count(parameter)=0]"
		[Register ("updateSource", "()V", "GetUpdateSourceHandler")]
		public virtual unsafe void UpdateSource ()
		{
			const string __id = "updateSource.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/plugins/annotation/AnnotationManager", DoNotGenerateAcw=true)]
	internal partial class AnnotationManagerInvoker : AnnotationManager {

		public AnnotationManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mapbox/mapboxsdk/plugins/annotation/AnnotationManager", typeof (AnnotationManagerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.annotation']/class[@name='AnnotationManager']/method[@name='setDataDrivenPropertyIsUsed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDataDrivenPropertyIsUsed", "(Ljava/lang/String;)V", "GetSetDataDrivenPropertyIsUsed_Ljava_lang_String_Handler")]
		protected override unsafe void SetDataDrivenPropertyIsUsed (string p0)
		{
			const string __id = "setDataDrivenPropertyIsUsed.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
