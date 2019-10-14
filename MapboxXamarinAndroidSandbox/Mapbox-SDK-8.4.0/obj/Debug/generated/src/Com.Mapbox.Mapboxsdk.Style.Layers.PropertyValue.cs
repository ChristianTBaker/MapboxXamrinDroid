using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Layers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/layers/PropertyValue", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class PropertyValue : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']/field[@name='value']"
		[Register ("value")]
		public global::Java.Lang.Object _value {
			get {
				const string __id = "value.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "value.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/layers/PropertyValue", typeof (PropertyValue));
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

		protected PropertyValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']/constructor[@name='PropertyValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe PropertyValue (string name, global::Java.Lang.Object value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getColorInt;
#pragma warning disable 0169
		static Delegate GetGetColorIntHandler ()
		{
			if (cb_getColorInt == null)
				cb_getColorInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColorInt);
			return cb_getColorInt;
		}

		static IntPtr n_GetColorInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ColorInt);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer ColorInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']/method[@name='getColorInt' and count(parameter)=0]"
			[Register ("getColorInt", "()Ljava/lang/Integer;", "GetGetColorIntHandler")]
			get {
				const string __id = "getColorInt.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExpression;
#pragma warning disable 0169
		static Delegate GetGetExpressionHandler ()
		{
			if (cb_getExpression == null)
				cb_getExpression = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpression);
			return cb_getExpression;
		}

		static IntPtr n_GetExpression (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Expression);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Expression {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']/method[@name='getExpression' and count(parameter)=0]"
			[Register ("getExpression", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "GetGetExpressionHandler")]
			get {
				const string __id = "getExpression.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isExpression;
#pragma warning disable 0169
		static Delegate GetIsExpressionHandler ()
		{
			if (cb_isExpression == null)
				cb_isExpression = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpression);
			return cb_isExpression;
		}

		static bool n_IsExpression (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpression;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsExpression {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']/method[@name='isExpression' and count(parameter)=0]"
			[Register ("isExpression", "()Z", "GetIsExpressionHandler")]
			get {
				const string __id = "isExpression.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isNull;
#pragma warning disable 0169
		static Delegate GetIsNullHandler ()
		{
			if (cb_isNull == null)
				cb_isNull = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNull);
			return cb_isNull;
		}

		static bool n_IsNull (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNull;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNull {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']/method[@name='isNull' and count(parameter)=0]"
			[Register ("isNull", "()Z", "GetIsNullHandler")]
			get {
				const string __id = "isNull.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isValue;
#pragma warning disable 0169
		static Delegate GetIsValueHandler ()
		{
			if (cb_isValue == null)
				cb_isValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValue);
			return cb_isValue;
		}

		static bool n_IsValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValue;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']/method[@name='isValue' and count(parameter)=0]"
			[Register ("isValue", "()Z", "GetIsValueHandler")]
			get {
				const string __id = "isValue.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Layers.PropertyValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.layers']/class[@name='PropertyValue']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
