using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Style.Expressions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/expressions/Expression", DoNotGenerateAcw=true)]
	public partial class Expression : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.Array']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/expressions/Expression$Array", DoNotGenerateAcw=true)]
		public partial class Array : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/expressions/Expression$Array", typeof (Array));
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

			protected Array (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.Array']/constructor[@name='Expression.Array' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Array ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.Converter']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/expressions/Expression$Converter", DoNotGenerateAcw=true)]
		public sealed partial class Converter : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/expressions/Expression$Converter", typeof (Converter));
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

			internal Converter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.Converter']/constructor[@name='Expression.Converter' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Converter ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.Converter']/method[@name='convert' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("convert", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
			public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Convert (string rawExpression)
			{
				const string __id = "convert.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
				IntPtr native_rawExpression = JNIEnv.NewString (rawExpression);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_rawExpression);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_rawExpression);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.ExpressionLiteral']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/expressions/Expression$ExpressionLiteral", DoNotGenerateAcw=true)]
		public partial class ExpressionLiteral : global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.ExpressionLiteral']/field[@name='literal']"
			[Register ("literal")]
			protected global::Java.Lang.Object Literal {
				get {
					const string __id = "literal.Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "literal.Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/expressions/Expression$ExpressionLiteral", typeof (ExpressionLiteral));
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

			protected ExpressionLiteral (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.ExpressionLiteral']/constructor[@name='Expression.ExpressionLiteral' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register (".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe ExpressionLiteral (global::Java.Lang.Object @object)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Object;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_toValue;
#pragma warning disable 0169
			static Delegate GetToValueHandler ()
			{
				if (cb_toValue == null)
					cb_toValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToValue);
				return cb_toValue;
			}

			static IntPtr n_ToValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.ExpressionLiteral __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.ExpressionLiteral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ToValue ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.ExpressionLiteral']/method[@name='toValue' and count(parameter)=0]"
			[Register ("toValue", "()Ljava/lang/Object;", "GetToValueHandler")]
			public virtual unsafe global::Java.Lang.Object ToValue ()
			{
				const string __id = "toValue.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.FormatEntry']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/expressions/Expression$FormatEntry", DoNotGenerateAcw=true)]
		public partial class FormatEntry : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/expressions/Expression$FormatEntry", typeof (FormatEntry));
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

			protected FormatEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.Interpolator']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/expressions/Expression$Interpolator", DoNotGenerateAcw=true)]
		public partial class Interpolator : global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/expressions/Expression$Interpolator", typeof (Interpolator));
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

			protected Interpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression.Stop']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/style/expressions/Expression$Stop", DoNotGenerateAcw=true)]
		public partial class Stop : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/expressions/Expression$Stop", typeof (Stop));
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

			protected Stop (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/style/expressions/Expression", typeof (Expression));
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

		protected Expression (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/constructor[@name='Expression' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register (".ctor", "(Ljava/lang/String;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)V", "")]
		public unsafe Expression (string operator_, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] arguments)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_operator = JNIEnv.NewString (operator_);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_operator);
				__args [1] = new JniArgumentValue (native_arguments);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_operator);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='abs' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("abs", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Abs (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "abs.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='abs' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("abs", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Abs (global::Java.Lang.Number number)
		{
			const string __id = "abs.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='accumulated' and count(parameter)=0]"
		[Register ("accumulated", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Accumulated ()
		{
			const string __id = "accumulated.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='acos' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("acos", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Acos (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "acos.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='acos' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("acos", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Acos (global::Java.Lang.Number number)
		{
			const string __id = "acos.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='all' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("all", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression All (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "all.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='any' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("any", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Any (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "any.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='array' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("array", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression InvokeArray (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "array.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='asin' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("asin", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Asin (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "asin.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='asin' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("asin", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Asin (global::Java.Lang.Number number)
		{
			const string __id = "asin.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='at' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("at", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression At (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "at.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				__args [1] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='at' and count(parameter)=2 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("at", "(Ljava/lang/Number;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression At (global::Java.Lang.Number number, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "at.(Ljava/lang/Number;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				__args [1] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='atan' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("atan", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Atan (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "atan.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='atan' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("atan", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Atan (global::Java.Lang.Number number)
		{
			const string __id = "atan.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='bool' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("bool", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Bool (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "bool.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='ceil' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("ceil", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Ceil (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "ceil.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='ceil' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("ceil", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Ceil (global::Java.Lang.Number number)
		{
			const string __id = "ceil.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='coalesce' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("coalesce", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Coalesce (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "coalesce.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='collator' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("collator", "(ZZ)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Collator (bool caseSensitive, bool diacriticSensitive)
		{
			const string __id = "collator.(ZZ)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (caseSensitive);
				__args [1] = new JniArgumentValue (diacriticSensitive);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='collator' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.util.Locale']]"
		[Register ("collator", "(ZZLjava/util/Locale;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Collator (bool caseSensitive, bool diacriticSensitive, global::Java.Util.Locale locale)
		{
			const string __id = "collator.(ZZLjava/util/Locale;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (caseSensitive);
				__args [1] = new JniArgumentValue (diacriticSensitive);
				__args [2] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='collator' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("collator", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Collator (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression caseSensitive, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression diacriticSensitive)
		{
			const string __id = "collator.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((caseSensitive == null) ? IntPtr.Zero : ((global::Java.Lang.Object) caseSensitive).Handle);
				__args [1] = new JniArgumentValue ((diacriticSensitive == null) ? IntPtr.Zero : ((global::Java.Lang.Object) diacriticSensitive).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='collator' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("collator", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Collator (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression caseSensitive, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression diacriticSensitive, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression locale)
		{
			const string __id = "collator.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((caseSensitive == null) ? IntPtr.Zero : ((global::Java.Lang.Object) caseSensitive).Handle);
				__args [1] = new JniArgumentValue ((diacriticSensitive == null) ? IntPtr.Zero : ((global::Java.Lang.Object) diacriticSensitive).Handle);
				__args [2] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("color", "(I)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Color (int color)
		{
			const string __id = "color.(I)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='concat' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("concat", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Concat (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "concat.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='concat' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("concat", "([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Concat (params string[] input)
		{
			const string __id = "concat.([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='cos' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("cos", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Cos (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "cos.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='cos' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("cos", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Cos (global::Java.Lang.Number number)
		{
			const string __id = "cos.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='cubicBezier' and count(parameter)=4 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[4][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("cubicBezier", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator CubicBezier (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression x1, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression y1, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression x2, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression y2)
		{
			const string __id = "cubicBezier.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((x1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) x1).Handle);
				__args [1] = new JniArgumentValue ((y1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) y1).Handle);
				__args [2] = new JniArgumentValue ((x2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) x2).Handle);
				__args [3] = new JniArgumentValue ((y2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) y2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='cubicBezier' and count(parameter)=4 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='java.lang.Number'] and parameter[4][@type='java.lang.Number']]"
		[Register ("cubicBezier", "(Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator CubicBezier (global::Java.Lang.Number x1, global::Java.Lang.Number y1, global::Java.Lang.Number x2, global::Java.Lang.Number y2)
		{
			const string __id = "cubicBezier.(Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((x1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) x1).Handle);
				__args [1] = new JniArgumentValue ((y1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) y1).Handle);
				__args [2] = new JniArgumentValue ((x2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) x2).Handle);
				__args [3] = new JniArgumentValue ((y2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) y2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='division' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("division", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Division (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression first, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression second)
		{
			const string __id = "division.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='division' and count(parameter)=2 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='java.lang.Number']]"
		[Register ("division", "(Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Division (global::Java.Lang.Number first, global::Java.Lang.Number second)
		{
			const string __id = "division.(Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='downcase' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("downcase", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Downcase (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "downcase.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='downcase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("downcase", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Downcase (string input)
		{
			const string __id = "downcase.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression E ()
		{
			const string __id = "e.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='eq' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='boolean']]"
		[Register ("eq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Z)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Eq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, bool compareTwo)
		{
			const string __id = "eq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Z)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (compareTwo);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='eq' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("eq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Eq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo)
		{
			const string __id = "eq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='eq' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("eq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Eq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "eq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='eq' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.Number']]"
		[Register ("eq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Eq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Java.Lang.Number compareTwo)
		{
			const string __id = "eq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='eq' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String']]"
		[Register ("eq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Eq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo)
		{
			const string __id = "eq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='eq' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("eq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Eq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "eq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='exponential' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("exponential", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator Exponential (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "exponential.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='exponential' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("exponential", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator Exponential (global::Java.Lang.Number @base)
		{
			const string __id = "exponential.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='floor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("floor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Floor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "floor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='floor' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("floor", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Floor (global::Java.Lang.Number number)
		{
			const string __id = "floor.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='format' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression.FormatEntry...']]"
		[Register ("format", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression$FormatEntry;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Format (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.FormatEntry[] formatEntries)
		{
			const string __id = "format.([Lcom/mapbox/mapboxsdk/style/expressions/Expression$FormatEntry;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_formatEntries = JNIEnv.NewArray (formatEntries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_formatEntries);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (formatEntries != null) {
					JNIEnv.CopyArray (native_formatEntries, formatEntries);
					JNIEnv.DeleteLocalRef (native_formatEntries);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='formatEntry' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("formatEntry", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$FormatEntry;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.FormatEntry InvokeFormatEntry (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression text)
		{
			const string __id = "formatEntry.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$FormatEntry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.FormatEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='formatEntry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("formatEntry", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$FormatEntry;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.FormatEntry InvokeFormatEntry (string text)
		{
			const string __id = "formatEntry.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$FormatEntry;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.FormatEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='geometryType' and count(parameter)=0]"
		[Register ("geometryType", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression GeometryType ()
		{
			const string __id = "geometryType.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("get", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Get (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "get.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='get' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("get", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Get (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression key, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression @object)
		{
			const string __id = "get.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Get (string input)
		{
			const string __id = "get.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("get", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Get (string key, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression @object)
		{
			const string __id = "get.(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gt' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("gt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo)
		{
			const string __id = "gt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gt' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("gt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "gt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gt' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.Number']]"
		[Register ("gt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Java.Lang.Number compareTwo)
		{
			const string __id = "gt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gt' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String']]"
		[Register ("gt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo)
		{
			const string __id = "gt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gt' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("gt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "gt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gte' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("gte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo)
		{
			const string __id = "gte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gte' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("gte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "gte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gte' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.Number']]"
		[Register ("gte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Java.Lang.Number compareTwo)
		{
			const string __id = "gte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gte' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String']]"
		[Register ("gte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo)
		{
			const string __id = "gte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='gte' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("gte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Gte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "gte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='has' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("has", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Has (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression key)
		{
			const string __id = "has.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='has' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("has", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Has (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression key, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression @object)
		{
			const string __id = "has.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='has' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("has", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Has (string key)
		{
			const string __id = "has.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='has' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("has", "(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Has (string key, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression @object)
		{
			const string __id = "has.(Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='heatmapDensity' and count(parameter)=0]"
		[Register ("heatmapDensity", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression HeatmapDensity ()
		{
			const string __id = "heatmapDensity.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Id ()
		{
			const string __id = "id.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='interpolate' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression.Interpolator'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("interpolate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Interpolate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator interpolation, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] stops)
		{
			const string __id = "interpolate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((interpolation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolation).Handle);
				__args [1] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='interpolate' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression.Interpolator'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression.Stop...']]"
		[Register ("interpolate", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Interpolate (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator interpolation, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Stop[] stops)
		{
			const string __id = "interpolate.(Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((interpolation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolation).Handle);
				__args [1] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='isSupportedScript' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("isSupportedScript", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression IsSupportedScript (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "isSupportedScript.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='isSupportedScript' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSupportedScript", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression IsSupportedScript (string @string)
		{
			const string __id = "isSupportedScript.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='length' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("length", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Length (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "length.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='length' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("length", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Length (string input)
		{
			const string __id = "length.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='let' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("let", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Let (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "let.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lineProgress' and count(parameter)=0]"
		[Register ("lineProgress", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression LineProgress ()
		{
			const string __id = "lineProgress.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='linear' and count(parameter)=0]"
		[Register ("linear", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator Linear ()
		{
			const string __id = "linear.()Lcom/mapbox/mapboxsdk/style/expressions/Expression$Interpolator;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Interpolator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='literal' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("literal", "(Z)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Literal (bool @bool)
		{
			const string __id = "literal.(Z)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (@bool);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='literal' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("literal", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Literal (global::Java.Lang.Number number)
		{
			const string __id = "literal.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='literal' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("literal", "(Ljava/lang/Object;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Literal (global::Java.Lang.Object @object)
		{
			const string __id = "literal.(Ljava/lang/Object;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='literal' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("literal", "([Ljava/lang/Object;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Literal (global::Java.Lang.Object[] array)
		{
			const string __id = "literal.([Ljava/lang/Object;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='literal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("literal", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Literal (string @string)
		{
			const string __id = "literal.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='ln' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("ln", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Ln (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "ln.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='ln' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("ln", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Ln (global::Java.Lang.Number number)
		{
			const string __id = "ln.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='ln2' and count(parameter)=0]"
		[Register ("ln2", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Ln2 ()
		{
			const string __id = "ln2.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='log10' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("log10", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Log10 (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "log10.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='log10' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("log10", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Log10 (global::Java.Lang.Number number)
		{
			const string __id = "log10.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='log2' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("log2", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Log2 (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "log2.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='log2' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("log2", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Log2 (global::Java.Lang.Number number)
		{
			const string __id = "log2.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lt' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo)
		{
			const string __id = "lt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lt' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "lt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lt' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.Number']]"
		[Register ("lt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Java.Lang.Number compareTwo)
		{
			const string __id = "lt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lt' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String']]"
		[Register ("lt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo)
		{
			const string __id = "lt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lt' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "lt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lte' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo)
		{
			const string __id = "lte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lte' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "lte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lte' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.Number']]"
		[Register ("lte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Java.Lang.Number compareTwo)
		{
			const string __id = "lte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lte' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String']]"
		[Register ("lte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo)
		{
			const string __id = "lte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='lte' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("lte", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Lte (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "lte.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='match' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression.Stop...']]"
		[Register ("match", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Match (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression defaultOutput, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Stop[] stops)
		{
			const string __id = "match.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((defaultOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultOutput).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='match' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("match", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Match (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "match.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='max' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("max", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Max (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] numbers)
		{
			const string __id = "max.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_numbers = JNIEnv.NewArray (numbers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_numbers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (numbers != null) {
					JNIEnv.CopyArray (native_numbers, numbers);
					JNIEnv.DeleteLocalRef (native_numbers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='max' and count(parameter)=1 and parameter[1][@type='java.lang.Number...']]"
		[Register ("max", "([Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Max (params global::Java.Lang.Number[] numbers)
		{
			const string __id = "max.([Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_numbers = JNIEnv.NewArray (numbers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_numbers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (numbers != null) {
					JNIEnv.CopyArray (native_numbers, numbers);
					JNIEnv.DeleteLocalRef (native_numbers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='min' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("min", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Min (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] numbers)
		{
			const string __id = "min.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_numbers = JNIEnv.NewArray (numbers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_numbers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (numbers != null) {
					JNIEnv.CopyArray (native_numbers, numbers);
					JNIEnv.DeleteLocalRef (native_numbers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='min' and count(parameter)=1 and parameter[1][@type='java.lang.Number...']]"
		[Register ("min", "([Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Min (params global::Java.Lang.Number[] numbers)
		{
			const string __id = "min.([Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_numbers = JNIEnv.NewArray (numbers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_numbers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (numbers != null) {
					JNIEnv.CopyArray (native_numbers, numbers);
					JNIEnv.DeleteLocalRef (native_numbers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='mod' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("mod", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Mod (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression first, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression second)
		{
			const string __id = "mod.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='mod' and count(parameter)=2 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='java.lang.Number']]"
		[Register ("mod", "(Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Mod (global::Java.Lang.Number first, global::Java.Lang.Number second)
		{
			const string __id = "mod.(Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='neq' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='boolean']]"
		[Register ("neq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Z)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Neq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, bool compareTwo)
		{
			const string __id = "neq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Z)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (compareTwo);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='neq' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("neq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Neq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo)
		{
			const string __id = "neq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='neq' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("neq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Neq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "neq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='neq' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.Number']]"
		[Register ("neq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Neq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, global::Java.Lang.Number compareTwo)
		{
			const string __id = "neq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue ((compareTwo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareTwo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='neq' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String']]"
		[Register ("neq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Neq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo)
		{
			const string __id = "neq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='neq' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("neq", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Neq (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression compareOne, string compareTwo, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "neq.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/String;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_compareTwo = JNIEnv.NewString (compareTwo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compareOne == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compareOne).Handle);
				__args [1] = new JniArgumentValue (native_compareTwo);
				__args [2] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compareTwo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='not' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("not", "(Z)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Not (bool input)
		{
			const string __id = "not.(Z)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='not' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("not", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Not (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "not.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='number' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("number", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Number (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "number.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='object' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("object", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Object (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "object.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='pi' and count(parameter)=0]"
		[Register ("pi", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Pi ()
		{
			const string __id = "pi.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='pow' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("pow", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Pow (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression first, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression second)
		{
			const string __id = "pow.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='pow' and count(parameter)=2 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='java.lang.Number']]"
		[Register ("pow", "(Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Pow (global::Java.Lang.Number first, global::Java.Lang.Number second)
		{
			const string __id = "pow.(Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='product' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("product", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Product (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] numbers)
		{
			const string __id = "product.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_numbers = JNIEnv.NewArray (numbers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_numbers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (numbers != null) {
					JNIEnv.CopyArray (native_numbers, numbers);
					JNIEnv.DeleteLocalRef (native_numbers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='product' and count(parameter)=1 and parameter[1][@type='java.lang.Number...']]"
		[Register ("product", "([Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Product (params global::Java.Lang.Number[] numbers)
		{
			const string __id = "product.([Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_numbers = JNIEnv.NewArray (numbers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_numbers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (numbers != null) {
					JNIEnv.CopyArray (native_numbers, numbers);
					JNIEnv.DeleteLocalRef (native_numbers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='properties' and count(parameter)=0]"
		[Register ("properties", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Properties ()
		{
			const string __id = "properties.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='raw' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("raw", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Raw (string rawExpression)
		{
			const string __id = "raw.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_rawExpression = JNIEnv.NewString (rawExpression);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawExpression);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rawExpression);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='resolvedLocale' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("resolvedLocale", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression ResolvedLocale (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression collator)
		{
			const string __id = "resolvedLocale.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((collator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='rgb' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rgb", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Rgb (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression red, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression green, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression blue)
		{
			const string __id = "rgb.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((red == null) ? IntPtr.Zero : ((global::Java.Lang.Object) red).Handle);
				__args [1] = new JniArgumentValue ((green == null) ? IntPtr.Zero : ((global::Java.Lang.Object) green).Handle);
				__args [2] = new JniArgumentValue ((blue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) blue).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='rgb' and count(parameter)=3 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='java.lang.Number']]"
		[Register ("rgb", "(Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Rgb (global::Java.Lang.Number red, global::Java.Lang.Number green, global::Java.Lang.Number blue)
		{
			const string __id = "rgb.(Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((red == null) ? IntPtr.Zero : ((global::Java.Lang.Object) red).Handle);
				__args [1] = new JniArgumentValue ((green == null) ? IntPtr.Zero : ((global::Java.Lang.Object) green).Handle);
				__args [2] = new JniArgumentValue ((blue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) blue).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='rgba' and count(parameter)=4 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[4][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("rgba", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Rgba (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression red, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression green, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression blue, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression alpha)
		{
			const string __id = "rgba.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((red == null) ? IntPtr.Zero : ((global::Java.Lang.Object) red).Handle);
				__args [1] = new JniArgumentValue ((green == null) ? IntPtr.Zero : ((global::Java.Lang.Object) green).Handle);
				__args [2] = new JniArgumentValue ((blue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) blue).Handle);
				__args [3] = new JniArgumentValue ((alpha == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alpha).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='rgba' and count(parameter)=4 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='java.lang.Number'] and parameter[4][@type='java.lang.Number']]"
		[Register ("rgba", "(Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Rgba (global::Java.Lang.Number red, global::Java.Lang.Number green, global::Java.Lang.Number blue, global::Java.Lang.Number alpha)
		{
			const string __id = "rgba.(Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((red == null) ? IntPtr.Zero : ((global::Java.Lang.Object) red).Handle);
				__args [1] = new JniArgumentValue ((green == null) ? IntPtr.Zero : ((global::Java.Lang.Object) green).Handle);
				__args [2] = new JniArgumentValue ((blue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) blue).Handle);
				__args [3] = new JniArgumentValue ((alpha == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alpha).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='round' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("round", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Round (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "round.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='round' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("round", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Round (global::Java.Lang.Number number)
		{
			const string __id = "round.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='sin' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("sin", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Sin (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "sin.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='sin' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("sin", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Sin (global::Java.Lang.Number number)
		{
			const string __id = "sin.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='sqrt' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("sqrt", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Sqrt (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "sqrt.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='sqrt' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("sqrt", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Sqrt (global::Java.Lang.Number number)
		{
			const string __id = "sqrt.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='step' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("step", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Step (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression defaultOutput, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] stops)
		{
			const string __id = "step.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((defaultOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultOutput).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='step' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression.Stop...']]"
		[Register ("step", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Step (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression defaultOutput, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Stop[] stops)
		{
			const string __id = "step.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((defaultOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultOutput).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='step' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("step", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Step (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input, global::Java.Lang.Number defaultOutput, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] stops)
		{
			const string __id = "step.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((defaultOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultOutput).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='step' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression.Stop...']]"
		[Register ("step", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Step (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input, global::Java.Lang.Number defaultOutput, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Stop[] stops)
		{
			const string __id = "step.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Ljava/lang/Number;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((defaultOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultOutput).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='step' and count(parameter)=3 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("step", "(Ljava/lang/Number;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Step (global::Java.Lang.Number input, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression defaultOutput, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] stops)
		{
			const string __id = "step.(Ljava/lang/Number;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((defaultOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultOutput).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='step' and count(parameter)=3 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression.Stop...']]"
		[Register ("step", "(Ljava/lang/Number;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Step (global::Java.Lang.Number input, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression defaultOutput, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Stop[] stops)
		{
			const string __id = "step.(Ljava/lang/Number;Lcom/mapbox/mapboxsdk/style/expressions/Expression;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((defaultOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultOutput).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='step' and count(parameter)=3 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("step", "(Ljava/lang/Number;Ljava/lang/Number;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Step (global::Java.Lang.Number input, global::Java.Lang.Number defaultOutput, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] stops)
		{
			const string __id = "step.(Ljava/lang/Number;Ljava/lang/Number;[Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((defaultOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultOutput).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='step' and count(parameter)=3 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='com.mapbox.mapboxsdk.style.expressions.Expression.Stop...']]"
		[Register ("step", "(Ljava/lang/Number;Ljava/lang/Number;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Step (global::Java.Lang.Number input, global::Java.Lang.Number defaultOutput, params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Stop[] stops)
		{
			const string __id = "step.(Ljava/lang/Number;Ljava/lang/Number;[Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_stops = JNIEnv.NewArray (stops);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((defaultOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultOutput).Handle);
				__args [2] = new JniArgumentValue (native_stops);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (stops != null) {
					JNIEnv.CopyArray (native_stops, stops);
					JNIEnv.DeleteLocalRef (native_stops);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='stop' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("stop", "(Ljava/lang/Object;Ljava/lang/Object;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Stop InvokeStop (global::Java.Lang.Object stop, global::Java.Lang.Object value)
		{
			const string __id = "stop.(Ljava/lang/Object;Ljava/lang/Object;)Lcom/mapbox/mapboxsdk/style/expressions/Expression$Stop;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((stop == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stop).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression.Stop> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='string' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("string", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression String (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "string.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("subtract", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Subtract (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "subtract.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='subtract' and count(parameter)=2 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression'] and parameter[2][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("subtract", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Subtract (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression first, global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression second)
		{
			const string __id = "subtract.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("subtract", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Subtract (global::Java.Lang.Number number)
		{
			const string __id = "subtract.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='subtract' and count(parameter)=2 and parameter[1][@type='java.lang.Number'] and parameter[2][@type='java.lang.Number']]"
		[Register ("subtract", "(Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Subtract (global::Java.Lang.Number first, global::Java.Lang.Number second)
		{
			const string __id = "subtract.(Ljava/lang/Number;Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='sum' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("sum", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Sum (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] numbers)
		{
			const string __id = "sum.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_numbers = JNIEnv.NewArray (numbers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_numbers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (numbers != null) {
					JNIEnv.CopyArray (native_numbers, numbers);
					JNIEnv.DeleteLocalRef (native_numbers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='sum' and count(parameter)=1 and parameter[1][@type='java.lang.Number...']]"
		[Register ("sum", "([Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Sum (params global::Java.Lang.Number[] numbers)
		{
			const string __id = "sum.([Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_numbers = JNIEnv.NewArray (numbers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_numbers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (numbers != null) {
					JNIEnv.CopyArray (native_numbers, numbers);
					JNIEnv.DeleteLocalRef (native_numbers);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='switchCase' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression...']]"
		[Register ("switchCase", "([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression SwitchCase (params global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression[] input)
		{
			const string __id = "switchCase.([Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='tan' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("tan", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Tan (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression number)
		{
			const string __id = "tan.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='tan' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("tan", "(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Tan (global::Java.Lang.Number number)
		{
			const string __id = "tan.(Ljava/lang/Number;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((number == null) ? IntPtr.Zero : ((global::Java.Lang.Object) number).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='toArray' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='toBool' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("toBool", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression ToBool (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "toBool.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='toColor' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("toColor", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression ToColor (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "toColor.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='toNumber' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("toNumber", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression ToNumber (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "toNumber.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='toRgba' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("toRgba", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression ToRgba (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "toRgba.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("toString", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static new unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression ToString (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "toString.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='typeOf' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("typeOf", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression TypeOf (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression input)
		{
			const string __id = "typeOf.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='upcase' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("upcase", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Upcase (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression @string)
		{
			const string __id = "upcase.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@string == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @string).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='upcase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("upcase", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Upcase (string @string)
		{
			const string __id = "upcase.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='var' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.style.expressions.Expression']]"
		[Register ("var", "(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Var (global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression expression)
		{
			const string __id = "var.(Lcom/mapbox/mapboxsdk/style/expressions/Expression;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expression == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expression).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='var' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("var", "(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Var (string variableName)
		{
			const string __id = "var.(Ljava/lang/String;)Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			IntPtr native_variableName = JNIEnv.NewString (variableName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_variableName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_variableName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.style.expressions']/class[@name='Expression']/method[@name='zoom' and count(parameter)=0]"
		[Register ("zoom", "()Lcom/mapbox/mapboxsdk/style/expressions/Expression;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression Zoom ()
		{
			const string __id = "zoom.()Lcom/mapbox/mapboxsdk/style/expressions/Expression;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Style.Expressions.Expression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
