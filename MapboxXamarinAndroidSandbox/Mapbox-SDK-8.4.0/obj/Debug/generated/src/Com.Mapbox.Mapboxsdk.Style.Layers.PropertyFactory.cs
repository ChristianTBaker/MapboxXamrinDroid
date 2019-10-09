using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/PropertyFactory", DoNotGenerateAcw=true)]
	public partial class PropertyFactory : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/PropertyFactory", typeof (PropertyFactory));
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

		protected PropertyFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/constructor[@name='PropertyFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PropertyFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='backgroundColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("backgroundColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue BackgroundColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "backgroundColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='backgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("backgroundColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue BackgroundColor (int value)
		{
			const string __id = "backgroundColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='backgroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("backgroundColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue BackgroundColor (string value)
		{
			const string __id = "backgroundColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='backgroundOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("backgroundOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue BackgroundOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "backgroundOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='backgroundOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("backgroundOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue BackgroundOpacity (global::Java.Lang.Float value)
		{
			const string __id = "backgroundOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='backgroundPattern' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("backgroundPattern", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue BackgroundPattern (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "backgroundPattern.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='backgroundPattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("backgroundPattern", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue BackgroundPattern (string value)
		{
			const string __id = "backgroundPattern.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleBlur' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circleBlur", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleBlur (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circleBlur.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleBlur' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("circleBlur", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleBlur (global::Java.Lang.Float value)
		{
			const string __id = "circleBlur.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circleColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circleColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("circleColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleColor (int value)
		{
			const string __id = "circleColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("circleColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleColor (string value)
		{
			const string __id = "circleColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circleOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circleOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("circleOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleOpacity (global::Java.Lang.Float value)
		{
			const string __id = "circleOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circlePitchAlignment' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circlePitchAlignment", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CirclePitchAlignment (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circlePitchAlignment.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circlePitchAlignment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("circlePitchAlignment", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CirclePitchAlignment ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"CirclePitchAlignmentMap", "CirclePitchAlignmentViewport"})]string value)
		{
			const string __id = "circlePitchAlignment.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circlePitchScale' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circlePitchScale", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CirclePitchScale (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circlePitchScale.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circlePitchScale' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("circlePitchScale", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CirclePitchScale ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"CirclePitchScaleMap", "CirclePitchScaleViewport"})]string value)
		{
			const string __id = "circlePitchScale.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleRadius' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circleRadius", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleRadius (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circleRadius.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleRadius' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("circleRadius", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleRadius (global::Java.Lang.Float value)
		{
			const string __id = "circleRadius.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleStrokeColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circleStrokeColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circleStrokeColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("circleStrokeColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeColor (int value)
		{
			const string __id = "circleStrokeColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleStrokeColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("circleStrokeColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeColor (string value)
		{
			const string __id = "circleStrokeColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleStrokeOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circleStrokeOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circleStrokeOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleStrokeOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("circleStrokeOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeOpacity (global::Java.Lang.Float value)
		{
			const string __id = "circleStrokeOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleStrokeWidth' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circleStrokeWidth", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeWidth (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circleStrokeWidth.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleStrokeWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("circleStrokeWidth", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleStrokeWidth (global::Java.Lang.Float value)
		{
			const string __id = "circleStrokeWidth.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleTranslate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circleTranslate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleTranslate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circleTranslate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleTranslate' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("circleTranslate", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleTranslate (global::Java.Lang.Float[] value)
		{
			const string __id = "circleTranslate.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleTranslateAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("circleTranslateAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleTranslateAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "circleTranslateAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='circleTranslateAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("circleTranslateAnchor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue CircleTranslateAnchor ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"CircleTranslateAnchorMap", "CircleTranslateAnchorViewport"})]string value)
		{
			const string __id = "circleTranslateAnchor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillAntialias' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillAntialias", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillAntialias (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillAntialias.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillAntialias' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("fillAntialias", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillAntialias (global::Java.Lang.Boolean value)
		{
			const string __id = "fillAntialias.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fillColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillColor (int value)
		{
			const string __id = "fillColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fillColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillColor (string value)
		{
			const string __id = "fillColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionBase' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillExtrusionBase", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionBase (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillExtrusionBase.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionBase' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("fillExtrusionBase", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionBase (global::Java.Lang.Float value)
		{
			const string __id = "fillExtrusionBase.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillExtrusionColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillExtrusionColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fillExtrusionColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionColor (int value)
		{
			const string __id = "fillExtrusionColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fillExtrusionColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionColor (string value)
		{
			const string __id = "fillExtrusionColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionHeight' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillExtrusionHeight", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionHeight (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillExtrusionHeight.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionHeight' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("fillExtrusionHeight", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionHeight (global::Java.Lang.Float value)
		{
			const string __id = "fillExtrusionHeight.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillExtrusionOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillExtrusionOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("fillExtrusionOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionOpacity (global::Java.Lang.Float value)
		{
			const string __id = "fillExtrusionOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionPattern' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillExtrusionPattern", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionPattern (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillExtrusionPattern.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionPattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fillExtrusionPattern", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionPattern (string value)
		{
			const string __id = "fillExtrusionPattern.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionTranslate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillExtrusionTranslate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionTranslate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillExtrusionTranslate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionTranslate' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("fillExtrusionTranslate", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionTranslate (global::Java.Lang.Float[] value)
		{
			const string __id = "fillExtrusionTranslate.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionTranslateAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillExtrusionTranslateAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionTranslateAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillExtrusionTranslateAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionTranslateAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fillExtrusionTranslateAnchor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionTranslateAnchor ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"FillExtrusionTranslateAnchorMap", "FillExtrusionTranslateAnchorViewport"})]string value)
		{
			const string __id = "fillExtrusionTranslateAnchor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionVerticalGradient' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillExtrusionVerticalGradient", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionVerticalGradient (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillExtrusionVerticalGradient.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillExtrusionVerticalGradient' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("fillExtrusionVerticalGradient", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillExtrusionVerticalGradient (global::Java.Lang.Boolean value)
		{
			const string __id = "fillExtrusionVerticalGradient.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("fillOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillOpacity (global::Java.Lang.Float value)
		{
			const string __id = "fillOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillOutlineColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillOutlineColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillOutlineColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillOutlineColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillOutlineColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fillOutlineColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillOutlineColor (int value)
		{
			const string __id = "fillOutlineColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillOutlineColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fillOutlineColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillOutlineColor (string value)
		{
			const string __id = "fillOutlineColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillPattern' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillPattern", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillPattern (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillPattern.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillPattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fillPattern", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillPattern (string value)
		{
			const string __id = "fillPattern.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillTranslate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillTranslate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillTranslate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillTranslate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillTranslate' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("fillTranslate", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillTranslate (global::Java.Lang.Float[] value)
		{
			const string __id = "fillTranslate.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillTranslateAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("fillTranslateAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillTranslateAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "fillTranslateAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='fillTranslateAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fillTranslateAnchor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue FillTranslateAnchor ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"FillTranslateAnchorMap", "FillTranslateAnchorViewport"})]string value)
		{
			const string __id = "fillTranslateAnchor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("heatmapColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "heatmapColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("heatmapColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapColor (int value)
		{
			const string __id = "heatmapColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("heatmapColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapColor (string value)
		{
			const string __id = "heatmapColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapIntensity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("heatmapIntensity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapIntensity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "heatmapIntensity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapIntensity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("heatmapIntensity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapIntensity (global::Java.Lang.Float value)
		{
			const string __id = "heatmapIntensity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("heatmapOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "heatmapOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("heatmapOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapOpacity (global::Java.Lang.Float value)
		{
			const string __id = "heatmapOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapRadius' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("heatmapRadius", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapRadius (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "heatmapRadius.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapRadius' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("heatmapRadius", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapRadius (global::Java.Lang.Float value)
		{
			const string __id = "heatmapRadius.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapWeight' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("heatmapWeight", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapWeight (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "heatmapWeight.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='heatmapWeight' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("heatmapWeight", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HeatmapWeight (global::Java.Lang.Float value)
		{
			const string __id = "heatmapWeight.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeAccentColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("hillshadeAccentColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeAccentColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "hillshadeAccentColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeAccentColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hillshadeAccentColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeAccentColor (int value)
		{
			const string __id = "hillshadeAccentColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeAccentColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hillshadeAccentColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeAccentColor (string value)
		{
			const string __id = "hillshadeAccentColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeExaggeration' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("hillshadeExaggeration", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeExaggeration (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "hillshadeExaggeration.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeExaggeration' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("hillshadeExaggeration", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeExaggeration (global::Java.Lang.Float value)
		{
			const string __id = "hillshadeExaggeration.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeHighlightColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("hillshadeHighlightColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeHighlightColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "hillshadeHighlightColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeHighlightColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hillshadeHighlightColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeHighlightColor (int value)
		{
			const string __id = "hillshadeHighlightColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeHighlightColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hillshadeHighlightColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeHighlightColor (string value)
		{
			const string __id = "hillshadeHighlightColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeIlluminationAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("hillshadeIlluminationAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeIlluminationAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "hillshadeIlluminationAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeIlluminationAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hillshadeIlluminationAnchor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeIlluminationAnchor ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"HillshadeIlluminationAnchorMap", "HillshadeIlluminationAnchorViewport"})]string value)
		{
			const string __id = "hillshadeIlluminationAnchor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeIlluminationDirection' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("hillshadeIlluminationDirection", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeIlluminationDirection (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "hillshadeIlluminationDirection.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeIlluminationDirection' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("hillshadeIlluminationDirection", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeIlluminationDirection (global::Java.Lang.Float value)
		{
			const string __id = "hillshadeIlluminationDirection.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeShadowColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("hillshadeShadowColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeShadowColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "hillshadeShadowColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeShadowColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hillshadeShadowColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeShadowColor (int value)
		{
			const string __id = "hillshadeShadowColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='hillshadeShadowColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hillshadeShadowColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue HillshadeShadowColor (string value)
		{
			const string __id = "hillshadeShadowColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconAllowOverlap' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconAllowOverlap", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconAllowOverlap (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconAllowOverlap.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconAllowOverlap' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("iconAllowOverlap", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconAllowOverlap (global::Java.Lang.Boolean value)
		{
			const string __id = "iconAllowOverlap.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("iconAnchor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconAnchor ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"IconAnchorCenter", "IconAnchorLeft", "IconAnchorRight", "IconAnchorTop", "IconAnchorBottom", "IconAnchorTopLeft", "IconAnchorTopRight", "IconAnchorBottomLeft", "IconAnchorBottomRight"})]string value)
		{
			const string __id = "iconAnchor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "iconColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("iconColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconColor (int value)
		{
			const string __id = "iconColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("iconColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconColor (string value)
		{
			const string __id = "iconColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconHaloBlur' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconHaloBlur", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloBlur (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "iconHaloBlur.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconHaloBlur' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("iconHaloBlur", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloBlur (global::Java.Lang.Float value)
		{
			const string __id = "iconHaloBlur.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconHaloColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconHaloColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "iconHaloColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconHaloColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("iconHaloColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloColor (int value)
		{
			const string __id = "iconHaloColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconHaloColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("iconHaloColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloColor (string value)
		{
			const string __id = "iconHaloColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconHaloWidth' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconHaloWidth", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloWidth (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "iconHaloWidth.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconHaloWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("iconHaloWidth", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconHaloWidth (global::Java.Lang.Float value)
		{
			const string __id = "iconHaloWidth.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconIgnorePlacement' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconIgnorePlacement", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconIgnorePlacement (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconIgnorePlacement.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconIgnorePlacement' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("iconIgnorePlacement", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconIgnorePlacement (global::Java.Lang.Boolean value)
		{
			const string __id = "iconIgnorePlacement.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconImage' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconImage", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconImage (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconImage.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("iconImage", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconImage (string value)
		{
			const string __id = "iconImage.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconKeepUpright' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconKeepUpright", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconKeepUpright (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconKeepUpright.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconKeepUpright' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("iconKeepUpright", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconKeepUpright (global::Java.Lang.Boolean value)
		{
			const string __id = "iconKeepUpright.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconOffset' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconOffset", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconOffset (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconOffset.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconOffset' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("iconOffset", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconOffset (global::Java.Lang.Float[] value)
		{
			const string __id = "iconOffset.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "iconOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("iconOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconOpacity (global::Java.Lang.Float value)
		{
			const string __id = "iconOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconOptional' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconOptional", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconOptional (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconOptional.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconOptional' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("iconOptional", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconOptional (global::Java.Lang.Boolean value)
		{
			const string __id = "iconOptional.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconPadding' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconPadding", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconPadding (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconPadding.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconPadding' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("iconPadding", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconPadding (global::Java.Lang.Float value)
		{
			const string __id = "iconPadding.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconPitchAlignment' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconPitchAlignment", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconPitchAlignment (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconPitchAlignment.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconPitchAlignment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("iconPitchAlignment", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconPitchAlignment ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"IconPitchAlignmentMap", "IconPitchAlignmentViewport", "IconPitchAlignmentAuto"})]string value)
		{
			const string __id = "iconPitchAlignment.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconRotate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconRotate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconRotate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconRotate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconRotate' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("iconRotate", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconRotate (global::Java.Lang.Float value)
		{
			const string __id = "iconRotate.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconRotationAlignment' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconRotationAlignment", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconRotationAlignment (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconRotationAlignment.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconRotationAlignment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("iconRotationAlignment", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconRotationAlignment ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"IconRotationAlignmentMap", "IconRotationAlignmentViewport", "IconRotationAlignmentAuto"})]string value)
		{
			const string __id = "iconRotationAlignment.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconSize' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconSize", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconSize (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconSize.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconSize' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("iconSize", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconSize (global::Java.Lang.Float value)
		{
			const string __id = "iconSize.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconTextFit' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconTextFit", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTextFit (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconTextFit.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconTextFit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("iconTextFit", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTextFit ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"IconTextFitNone", "IconTextFitWidth", "IconTextFitHeight", "IconTextFitBoth"})]string value)
		{
			const string __id = "iconTextFit.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconTextFitPadding' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconTextFitPadding", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTextFitPadding (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "iconTextFitPadding.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconTextFitPadding' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("iconTextFitPadding", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTextFitPadding (global::Java.Lang.Float[] value)
		{
			const string __id = "iconTextFitPadding.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconTranslate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconTranslate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTranslate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "iconTranslate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconTranslate' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("iconTranslate", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTranslate (global::Java.Lang.Float[] value)
		{
			const string __id = "iconTranslate.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconTranslateAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("iconTranslateAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTranslateAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "iconTranslateAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='iconTranslateAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("iconTranslateAnchor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue IconTranslateAnchor ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"IconTranslateAnchorMap", "IconTranslateAnchorViewport"})]string value)
		{
			const string __id = "iconTranslateAnchor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineBlur' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineBlur", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineBlur (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineBlur.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineBlur' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("lineBlur", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineBlur (global::Java.Lang.Float value)
		{
			const string __id = "lineBlur.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineCap' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineCap", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineCap (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "lineCap.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineCap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lineCap", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineCap ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"LineCapButt", "LineCapRound", "LineCapSquare"})]string value)
		{
			const string __id = "lineCap.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("lineColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineColor (int value)
		{
			const string __id = "lineColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lineColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineColor (string value)
		{
			const string __id = "lineColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineDasharray' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineDasharray", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineDasharray (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineDasharray.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineDasharray' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("lineDasharray", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineDasharray (global::Java.Lang.Float[] value)
		{
			const string __id = "lineDasharray.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineGapWidth' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineGapWidth", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineGapWidth (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineGapWidth.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineGapWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("lineGapWidth", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineGapWidth (global::Java.Lang.Float value)
		{
			const string __id = "lineGapWidth.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineGradient' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineGradient", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineGradient (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineGradient.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineGradient' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("lineGradient", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineGradient (int value)
		{
			const string __id = "lineGradient.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineGradient' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lineGradient", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineGradient (string value)
		{
			const string __id = "lineGradient.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineJoin' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineJoin", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineJoin (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "lineJoin.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineJoin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lineJoin", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineJoin ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"LineJoinBevel", "LineJoinRound", "LineJoinMiter"})]string value)
		{
			const string __id = "lineJoin.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineMiterLimit' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineMiterLimit", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineMiterLimit (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "lineMiterLimit.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineMiterLimit' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("lineMiterLimit", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineMiterLimit (global::Java.Lang.Float value)
		{
			const string __id = "lineMiterLimit.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineOffset' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineOffset", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineOffset (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineOffset.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineOffset' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("lineOffset", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineOffset (global::Java.Lang.Float value)
		{
			const string __id = "lineOffset.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("lineOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineOpacity (global::Java.Lang.Float value)
		{
			const string __id = "lineOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='linePattern' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("linePattern", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LinePattern (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "linePattern.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='linePattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("linePattern", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LinePattern (string value)
		{
			const string __id = "linePattern.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineRoundLimit' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineRoundLimit", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineRoundLimit (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "lineRoundLimit.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineRoundLimit' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("lineRoundLimit", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineRoundLimit (global::Java.Lang.Float value)
		{
			const string __id = "lineRoundLimit.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineTranslate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineTranslate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineTranslate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineTranslate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineTranslate' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("lineTranslate", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineTranslate (global::Java.Lang.Float[] value)
		{
			const string __id = "lineTranslate.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineTranslateAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineTranslateAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineTranslateAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineTranslateAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineTranslateAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lineTranslateAnchor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineTranslateAnchor ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"LineTranslateAnchorMap", "LineTranslateAnchorViewport"})]string value)
		{
			const string __id = "lineTranslateAnchor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineWidth' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lineWidth", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineWidth (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "lineWidth.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='lineWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("lineWidth", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue LineWidth (global::Java.Lang.Float value)
		{
			const string __id = "lineWidth.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterBrightnessMax' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rasterBrightnessMax", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterBrightnessMax (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "rasterBrightnessMax.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterBrightnessMax' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("rasterBrightnessMax", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterBrightnessMax (global::Java.Lang.Float value)
		{
			const string __id = "rasterBrightnessMax.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterBrightnessMin' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rasterBrightnessMin", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterBrightnessMin (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "rasterBrightnessMin.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterBrightnessMin' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("rasterBrightnessMin", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterBrightnessMin (global::Java.Lang.Float value)
		{
			const string __id = "rasterBrightnessMin.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterContrast' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rasterContrast", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterContrast (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "rasterContrast.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterContrast' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("rasterContrast", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterContrast (global::Java.Lang.Float value)
		{
			const string __id = "rasterContrast.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterFadeDuration' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rasterFadeDuration", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterFadeDuration (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "rasterFadeDuration.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterFadeDuration' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("rasterFadeDuration", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterFadeDuration (global::Java.Lang.Float value)
		{
			const string __id = "rasterFadeDuration.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterHueRotate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rasterHueRotate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterHueRotate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "rasterHueRotate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterHueRotate' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("rasterHueRotate", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterHueRotate (global::Java.Lang.Float value)
		{
			const string __id = "rasterHueRotate.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rasterOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "rasterOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("rasterOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterOpacity (global::Java.Lang.Float value)
		{
			const string __id = "rasterOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterResampling' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rasterResampling", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterResampling (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "rasterResampling.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterResampling' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rasterResampling", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterResampling ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"RasterResamplingLinear", "RasterResamplingNearest"})]string value)
		{
			const string __id = "rasterResampling.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterSaturation' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rasterSaturation", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterSaturation (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "rasterSaturation.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='rasterSaturation' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("rasterSaturation", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue RasterSaturation (global::Java.Lang.Float value)
		{
			const string __id = "rasterSaturation.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolAvoidEdges' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("symbolAvoidEdges", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolAvoidEdges (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "symbolAvoidEdges.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolAvoidEdges' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("symbolAvoidEdges", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolAvoidEdges (global::Java.Lang.Boolean value)
		{
			const string __id = "symbolAvoidEdges.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolPlacement' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("symbolPlacement", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolPlacement (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "symbolPlacement.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolPlacement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("symbolPlacement", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolPlacement ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"SymbolPlacementPoint", "SymbolPlacementLine", "SymbolPlacementLineCenter"})]string value)
		{
			const string __id = "symbolPlacement.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolSortKey' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("symbolSortKey", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolSortKey (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "symbolSortKey.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolSortKey' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("symbolSortKey", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolSortKey (global::Java.Lang.Float value)
		{
			const string __id = "symbolSortKey.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolSpacing' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("symbolSpacing", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolSpacing (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "symbolSpacing.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolSpacing' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("symbolSpacing", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolSpacing (global::Java.Lang.Float value)
		{
			const string __id = "symbolSpacing.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolZOrder' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("symbolZOrder", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolZOrder (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "symbolZOrder.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='symbolZOrder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("symbolZOrder", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue SymbolZOrder ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"SymbolZOrderAuto", "SymbolZOrderViewportY", "SymbolZOrderSource"})]string value)
		{
			const string __id = "symbolZOrder.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textAllowOverlap' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textAllowOverlap", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextAllowOverlap (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textAllowOverlap.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textAllowOverlap' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("textAllowOverlap", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextAllowOverlap (global::Java.Lang.Boolean value)
		{
			const string __id = "textAllowOverlap.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textAnchor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextAnchor ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"TextAnchorCenter", "TextAnchorLeft", "TextAnchorRight", "TextAnchorTop", "TextAnchorBottom", "TextAnchorTopLeft", "TextAnchorTopRight", "TextAnchorBottomLeft", "TextAnchorBottomRight"})]string value)
		{
			const string __id = "textAnchor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "textColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextColor (int value)
		{
			const string __id = "textColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextColor (string value)
		{
			const string __id = "textColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textField' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textField", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextField (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textField.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textField' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.types.Formatted']]"
		[Register ("textField", "(Lcom/mapbox/mapboxsdk/style/types/Formatted;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextField (global::Com.Mapbox.Mapboxsdk.Style.Types.Formatted value)
		{
			const string __id = "textField.(Lcom/mapbox/mapboxsdk/style/types/Formatted;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textField", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextField (string value)
		{
			const string __id = "textField.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textFont' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textFont", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextFont (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textFont.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textFont' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("textFont", "([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextFont (string[] value)
		{
			const string __id = "textFont.([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textHaloBlur' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textHaloBlur", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloBlur (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "textHaloBlur.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textHaloBlur' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textHaloBlur", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloBlur (global::Java.Lang.Float value)
		{
			const string __id = "textHaloBlur.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textHaloColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textHaloColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "textHaloColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textHaloColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textHaloColor", "(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloColor (int value)
		{
			const string __id = "textHaloColor.(I)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textHaloColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textHaloColor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloColor (string value)
		{
			const string __id = "textHaloColor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textHaloWidth' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textHaloWidth", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloWidth (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "textHaloWidth.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textHaloWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textHaloWidth", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextHaloWidth (global::Java.Lang.Float value)
		{
			const string __id = "textHaloWidth.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textIgnorePlacement' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textIgnorePlacement", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextIgnorePlacement (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textIgnorePlacement.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textIgnorePlacement' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("textIgnorePlacement", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextIgnorePlacement (global::Java.Lang.Boolean value)
		{
			const string __id = "textIgnorePlacement.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textJustify' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textJustify", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextJustify (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textJustify.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textJustify' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textJustify", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextJustify ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"TextJustifyAuto", "TextJustifyLeft", "TextJustifyCenter", "TextJustifyRight"})]string value)
		{
			const string __id = "textJustify.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textKeepUpright' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textKeepUpright", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextKeepUpright (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textKeepUpright.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textKeepUpright' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("textKeepUpright", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextKeepUpright (global::Java.Lang.Boolean value)
		{
			const string __id = "textKeepUpright.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textLetterSpacing' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textLetterSpacing", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextLetterSpacing (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textLetterSpacing.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textLetterSpacing' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textLetterSpacing", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextLetterSpacing (global::Java.Lang.Float value)
		{
			const string __id = "textLetterSpacing.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textLineHeight' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textLineHeight", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextLineHeight (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textLineHeight.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textLineHeight' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textLineHeight", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextLineHeight (global::Java.Lang.Float value)
		{
			const string __id = "textLineHeight.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textMaxAngle' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textMaxAngle", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextMaxAngle (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textMaxAngle.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textMaxAngle' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textMaxAngle", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextMaxAngle (global::Java.Lang.Float value)
		{
			const string __id = "textMaxAngle.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textMaxWidth' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textMaxWidth", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextMaxWidth (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textMaxWidth.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textMaxWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textMaxWidth", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextMaxWidth (global::Java.Lang.Float value)
		{
			const string __id = "textMaxWidth.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textOffset' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textOffset", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextOffset (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textOffset.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textOffset' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("textOffset", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextOffset (global::Java.Lang.Float[] value)
		{
			const string __id = "textOffset.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textOpacity' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textOpacity", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextOpacity (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "textOpacity.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textOpacity' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textOpacity", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextOpacity (global::Java.Lang.Float value)
		{
			const string __id = "textOpacity.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textOptional' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textOptional", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextOptional (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textOptional.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textOptional' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("textOptional", "(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextOptional (global::Java.Lang.Boolean value)
		{
			const string __id = "textOptional.(Ljava/lang/Boolean;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textPadding' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textPadding", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextPadding (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textPadding.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textPadding' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textPadding", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextPadding (global::Java.Lang.Float value)
		{
			const string __id = "textPadding.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textPitchAlignment' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textPitchAlignment", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextPitchAlignment (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textPitchAlignment.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textPitchAlignment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textPitchAlignment", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextPitchAlignment ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"TextPitchAlignmentMap", "TextPitchAlignmentViewport", "TextPitchAlignmentAuto"})]string value)
		{
			const string __id = "textPitchAlignment.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textRadialOffset' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textRadialOffset", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextRadialOffset (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textRadialOffset.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textRadialOffset' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textRadialOffset", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextRadialOffset (global::Java.Lang.Float value)
		{
			const string __id = "textRadialOffset.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textRotate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textRotate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextRotate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textRotate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textRotate' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textRotate", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextRotate (global::Java.Lang.Float value)
		{
			const string __id = "textRotate.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textRotationAlignment' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textRotationAlignment", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextRotationAlignment (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textRotationAlignment.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textRotationAlignment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textRotationAlignment", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextRotationAlignment ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"TextRotationAlignmentMap", "TextRotationAlignmentViewport", "TextRotationAlignmentAuto"})]string value)
		{
			const string __id = "textRotationAlignment.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textSize' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textSize", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextSize (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textSize.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textSize' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
		[Register ("textSize", "(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextSize (global::Java.Lang.Float value)
		{
			const string __id = "textSize.(Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textTransform' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textTransform", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextTransform (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textTransform.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textTransform' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textTransform", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextTransform ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"TextTransformNone", "TextTransformUppercase", "TextTransformLowercase"})]string value)
		{
			const string __id = "textTransform.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textTranslate' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textTranslate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextTranslate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "textTranslate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textTranslate' and count(parameter)=1 and parameter[1][@type='java.lang.Float[]']]"
		[Register ("textTranslate", "([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextTranslate (global::Java.Lang.Float[] value)
		{
			const string __id = "textTranslate.([Ljava/lang/Float;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textTranslateAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textTranslateAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextTranslateAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "textTranslateAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textTranslateAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textTranslateAnchor", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextTranslateAnchor ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"TextTranslateAnchorMap", "TextTranslateAnchorViewport"})]string value)
		{
			const string __id = "textTranslateAnchor.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textVariableAnchor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textVariableAnchor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextVariableAnchor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textVariableAnchor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textVariableAnchor' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("textVariableAnchor", "([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextVariableAnchor (string[] value)
		{
			const string __id = "textVariableAnchor.([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textWritingMode' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("textWritingMode", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextWritingMode (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression value)
		{
			const string __id = "textWritingMode.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='textWritingMode' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("textWritingMode", "([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue TextWritingMode (string[] value)
		{
			const string __id = "textWritingMode.([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyFactory']/method[@name='visibility' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("visibility", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue Visibility ([global::Android.Runtime.StringDef (Type = "Com.Mapbox.Mapboxsdk.Style.Layers.Property", Fields = new string [] {"Visible", "None"})]string value)
		{
			const string __id = "visibility.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/layers/PropertyValue;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
