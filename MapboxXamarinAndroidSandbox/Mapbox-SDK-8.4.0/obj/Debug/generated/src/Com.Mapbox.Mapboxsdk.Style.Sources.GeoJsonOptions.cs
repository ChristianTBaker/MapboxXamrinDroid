using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Sources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/sources/GeoJsonOptions", DoNotGenerateAcw=true)]
	public partial class GeoJsonOptions : global::Java.Util.HashMap {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/sources/GeoJsonOptions", typeof (GeoJsonOptions));
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

		protected GeoJsonOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/constructor[@name='GeoJsonOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeoJsonOptions ()
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

		static Delegate cb_withBuffer_I;
#pragma warning disable 0169
		static Delegate GetWithBuffer_IHandler ()
		{
			if (cb_withBuffer_I == null)
				cb_withBuffer_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithBuffer_I);
			return cb_withBuffer_I;
		}

		static IntPtr n_WithBuffer_I (IntPtr jnienv, IntPtr native__this, int buffer)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithBuffer (buffer));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/method[@name='withBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withBuffer", "(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;", "GetWithBuffer_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions WithBuffer (int buffer)
		{
			const string __id = "withBuffer.(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (buffer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withCluster_Z;
#pragma warning disable 0169
		static Delegate GetWithCluster_ZHandler ()
		{
			if (cb_withCluster_Z == null)
				cb_withCluster_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithCluster_Z);
			return cb_withCluster_Z;
		}

		static IntPtr n_WithCluster_Z (IntPtr jnienv, IntPtr native__this, bool cluster)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCluster (cluster));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/method[@name='withCluster' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withCluster", "(Z)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;", "GetWithCluster_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions WithCluster (bool cluster)
		{
			const string __id = "withCluster.(Z)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cluster);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withClusterMaxZoom_I;
#pragma warning disable 0169
		static Delegate GetWithClusterMaxZoom_IHandler ()
		{
			if (cb_withClusterMaxZoom_I == null)
				cb_withClusterMaxZoom_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithClusterMaxZoom_I);
			return cb_withClusterMaxZoom_I;
		}

		static IntPtr n_WithClusterMaxZoom_I (IntPtr jnienv, IntPtr native__this, int clusterMaxZoom)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithClusterMaxZoom (clusterMaxZoom));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/method[@name='withClusterMaxZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withClusterMaxZoom", "(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;", "GetWithClusterMaxZoom_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions WithClusterMaxZoom (int clusterMaxZoom)
		{
			const string __id = "withClusterMaxZoom.(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (clusterMaxZoom);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withClusterProperty_Ljava_lang_String_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Lcom_mapbox_mapboxsdk_style_expressions_Expression_;
#pragma warning disable 0169
		static Delegate GetWithClusterProperty_Ljava_lang_String_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Handler ()
		{
			if (cb_withClusterProperty_Ljava_lang_String_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Lcom_mapbox_mapboxsdk_style_expressions_Expression_ == null)
				cb_withClusterProperty_Ljava_lang_String_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Lcom_mapbox_mapboxsdk_style_expressions_Expression_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithClusterProperty_Ljava_lang_String_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Lcom_mapbox_mapboxsdk_style_expressions_Expression_);
			return cb_withClusterProperty_Ljava_lang_String_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Lcom_mapbox_mapboxsdk_style_expressions_Expression_;
		}

		static IntPtr n_WithClusterProperty_Ljava_lang_String_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Lcom_mapbox_mapboxsdk_style_expressions_Expression_ (IntPtr jnienv, IntPtr native__this, IntPtr native_propertyName, IntPtr native_operatorExpr, IntPtr native_mapExpr)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string propertyName = JNIEnv.GetString (native_propertyName, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression operatorExpr = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_operatorExpr, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression mapExpr = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (native_mapExpr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithClusterProperty (propertyName, operatorExpr, mapExpr));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/method[@name='withClusterProperty' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("withClusterProperty", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;", "GetWithClusterProperty_Ljava_lang_String_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Lcom_mapbox_mapboxsdk_style_expressions_Expression_Handler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions WithClusterProperty (string propertyName, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression operatorExpr, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression mapExpr)
		{
			const string __id = "withClusterProperty.(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;";
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_propertyName);
				__args [1] = new JniArgumentValue ((operatorExpr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) operatorExpr).Handle);
				__args [2] = new JniArgumentValue ((mapExpr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapExpr).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
			}
		}

		static Delegate cb_withClusterRadius_I;
#pragma warning disable 0169
		static Delegate GetWithClusterRadius_IHandler ()
		{
			if (cb_withClusterRadius_I == null)
				cb_withClusterRadius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithClusterRadius_I);
			return cb_withClusterRadius_I;
		}

		static IntPtr n_WithClusterRadius_I (IntPtr jnienv, IntPtr native__this, int clusterRadius)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithClusterRadius (clusterRadius));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/method[@name='withClusterRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withClusterRadius", "(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;", "GetWithClusterRadius_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions WithClusterRadius (int clusterRadius)
		{
			const string __id = "withClusterRadius.(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (clusterRadius);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withLineMetrics_Z;
#pragma warning disable 0169
		static Delegate GetWithLineMetrics_ZHandler ()
		{
			if (cb_withLineMetrics_Z == null)
				cb_withLineMetrics_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithLineMetrics_Z);
			return cb_withLineMetrics_Z;
		}

		static IntPtr n_WithLineMetrics_Z (IntPtr jnienv, IntPtr native__this, bool lineMetrics)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithLineMetrics (lineMetrics));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/method[@name='withLineMetrics' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withLineMetrics", "(Z)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;", "GetWithLineMetrics_ZHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions WithLineMetrics (bool lineMetrics)
		{
			const string __id = "withLineMetrics.(Z)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (lineMetrics);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withMaxZoom_I;
#pragma warning disable 0169
		static Delegate GetWithMaxZoom_IHandler ()
		{
			if (cb_withMaxZoom_I == null)
				cb_withMaxZoom_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithMaxZoom_I);
			return cb_withMaxZoom_I;
		}

		static IntPtr n_WithMaxZoom_I (IntPtr jnienv, IntPtr native__this, int maxZoom)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithMaxZoom (maxZoom));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/method[@name='withMaxZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withMaxZoom", "(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;", "GetWithMaxZoom_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions WithMaxZoom (int maxZoom)
		{
			const string __id = "withMaxZoom.(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxZoom);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withMinZoom_I;
#pragma warning disable 0169
		static Delegate GetWithMinZoom_IHandler ()
		{
			if (cb_withMinZoom_I == null)
				cb_withMinZoom_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithMinZoom_I);
			return cb_withMinZoom_I;
		}

		static IntPtr n_WithMinZoom_I (IntPtr jnienv, IntPtr native__this, int minZoom)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithMinZoom (minZoom));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/method[@name='withMinZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withMinZoom", "(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;", "GetWithMinZoom_IHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions WithMinZoom (int minZoom)
		{
			const string __id = "withMinZoom.(I)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minZoom);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withTolerance_F;
#pragma warning disable 0169
		static Delegate GetWithTolerance_FHandler ()
		{
			if (cb_withTolerance_F == null)
				cb_withTolerance_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_WithTolerance_F);
			return cb_withTolerance_F;
		}

		static IntPtr n_WithTolerance_F (IntPtr jnienv, IntPtr native__this, float tolerance)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTolerance (tolerance));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.sources']/class[@name='GeoJsonOptions']/method[@name='withTolerance' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("withTolerance", "(F)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;", "GetWithTolerance_FHandler")]
		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions WithTolerance (float tolerance)
		{
			const string __id = "withTolerance.(F)Lcom/mapbox/mapboxsdk/style/sources/GeoJsonOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tolerance);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Sources.GeoJsonOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
