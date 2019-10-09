using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Attribution {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/attribution/AttributionParser", DoNotGenerateAcw=true)]
	public partial class AttributionParser : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser.Options']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/attribution/AttributionParser$Options", DoNotGenerateAcw=true)]
		public partial class Options : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/attribution/AttributionParser$Options", typeof (Options));
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

			protected Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser.Options']/constructor[@name='AttributionParser.Options' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Options (global::Android.Content.Context context)
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser.Options']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/mapboxsdk/attribution/AttributionParser;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser Build ()
			{
				const string __id = "build.()Lcom/mapbox/mapboxsdk/attribution/AttributionParser;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withAttributionData_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithAttributionData_arrayLjava_lang_String_Handler ()
			{
				if (cb_withAttributionData_arrayLjava_lang_String_ == null)
					cb_withAttributionData_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAttributionData_arrayLjava_lang_String_);
				return cb_withAttributionData_arrayLjava_lang_String_;
			}

			static IntPtr n_WithAttributionData_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attributionData)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] attributionData = (string[]) JNIEnv.GetArray (native_attributionData, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAttributionData (attributionData));
				if (attributionData != null)
					JNIEnv.CopyArray (attributionData, native_attributionData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser.Options']/method[@name='withAttributionData' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
			[Register ("withAttributionData", "([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;", "GetWithAttributionData_arrayLjava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options WithAttributionData (params string[] attributionData)
			{
				const string __id = "withAttributionData.([Ljava/lang/String;)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;";
				IntPtr native_attributionData = JNIEnv.NewArray (attributionData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_attributionData);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (attributionData != null) {
						JNIEnv.CopyArray (native_attributionData, attributionData);
						JNIEnv.DeleteLocalRef (native_attributionData);
					}
				}
			}

			static Delegate cb_withCopyrightSign_Z;
#pragma warning disable 0169
			static Delegate GetWithCopyrightSign_ZHandler ()
			{
				if (cb_withCopyrightSign_Z == null)
					cb_withCopyrightSign_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithCopyrightSign_Z);
				return cb_withCopyrightSign_Z;
			}

			static IntPtr n_WithCopyrightSign_Z (IntPtr jnienv, IntPtr native__this, bool withCopyrightSign)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WithCopyrightSign (withCopyrightSign));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser.Options']/method[@name='withCopyrightSign' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("withCopyrightSign", "(Z)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;", "GetWithCopyrightSign_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options WithCopyrightSign (bool withCopyrightSign)
			{
				const string __id = "withCopyrightSign.(Z)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (withCopyrightSign);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withImproveMap_Z;
#pragma warning disable 0169
			static Delegate GetWithImproveMap_ZHandler ()
			{
				if (cb_withImproveMap_Z == null)
					cb_withImproveMap_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithImproveMap_Z);
				return cb_withImproveMap_Z;
			}

			static IntPtr n_WithImproveMap_Z (IntPtr jnienv, IntPtr native__this, bool withImproveMap)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WithImproveMap (withImproveMap));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser.Options']/method[@name='withImproveMap' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("withImproveMap", "(Z)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;", "GetWithImproveMap_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options WithImproveMap (bool withImproveMap)
			{
				const string __id = "withImproveMap.(Z)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (withImproveMap);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withMapboxAttribution_Z;
#pragma warning disable 0169
			static Delegate GetWithMapboxAttribution_ZHandler ()
			{
				if (cb_withMapboxAttribution_Z == null)
					cb_withMapboxAttribution_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithMapboxAttribution_Z);
				return cb_withMapboxAttribution_Z;
			}

			static IntPtr n_WithMapboxAttribution_Z (IntPtr jnienv, IntPtr native__this, bool withMapboxAttribution)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WithMapboxAttribution (withMapboxAttribution));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser.Options']/method[@name='withMapboxAttribution' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("withMapboxAttribution", "(Z)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;", "GetWithMapboxAttribution_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options WithMapboxAttribution (bool withMapboxAttribution)
			{
				const string __id = "withMapboxAttribution.(Z)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (withMapboxAttribution);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withTelemetryAttribution_Z;
#pragma warning disable 0169
			static Delegate GetWithTelemetryAttribution_ZHandler ()
			{
				if (cb_withTelemetryAttribution_Z == null)
					cb_withTelemetryAttribution_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithTelemetryAttribution_Z);
				return cb_withTelemetryAttribution_Z;
			}

			static IntPtr n_WithTelemetryAttribution_Z (IntPtr jnienv, IntPtr native__this, bool withTelemetryAttribution)
			{
				global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WithTelemetryAttribution (withTelemetryAttribution));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser.Options']/method[@name='withTelemetryAttribution' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("withTelemetryAttribution", "(Z)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;", "GetWithTelemetryAttribution_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options WithTelemetryAttribution (bool withTelemetryAttribution)
			{
				const string __id = "withTelemetryAttribution.(Z)Lcom/mapbox/mapboxsdk/attribution/AttributionParser$Options;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (withTelemetryAttribution);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/attribution/AttributionParser", typeof (AttributionParser));
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

		protected AttributionParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAttributions;
#pragma warning disable 0169
		static Delegate GetGetAttributionsHandler ()
		{
			if (cb_getAttributions == null)
				cb_getAttributions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributions);
			return cb_getAttributions;
		}

		static IntPtr n_GetAttributions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Mapbox.Mapboxsdk.Attribution.Attribution>.ToLocalJniHandle (__this.Attributions);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Mapbox.Mapboxsdk.Attribution.Attribution> Attributions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser']/method[@name='getAttributions' and count(parameter)=0]"
			[Register ("getAttributions", "()Ljava/util/Set;", "GetGetAttributionsHandler")]
			get {
				const string __id = "getAttributions.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Mapbox.Mapboxsdk.Attribution.Attribution>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createAttributionString;
#pragma warning disable 0169
		static Delegate GetCreateAttributionStringHandler ()
		{
			if (cb_createAttributionString == null)
				cb_createAttributionString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateAttributionString);
			return cb_createAttributionString;
		}

		static IntPtr n_CreateAttributionString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateAttributionString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser']/method[@name='createAttributionString' and count(parameter)=0]"
		[Register ("createAttributionString", "()Ljava/lang/String;", "GetCreateAttributionStringHandler")]
		public virtual unsafe string CreateAttributionString ()
		{
			const string __id = "createAttributionString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createAttributionString_Z;
#pragma warning disable 0169
		static Delegate GetCreateAttributionString_ZHandler ()
		{
			if (cb_createAttributionString_Z == null)
				cb_createAttributionString_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_CreateAttributionString_Z);
			return cb_createAttributionString_Z;
		}

		static IntPtr n_CreateAttributionString_Z (IntPtr jnienv, IntPtr native__this, bool shortenedOutput)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateAttributionString (shortenedOutput));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser']/method[@name='createAttributionString' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("createAttributionString", "(Z)Ljava/lang/String;", "GetCreateAttributionString_ZHandler")]
		public virtual unsafe string CreateAttributionString (bool shortenedOutput)
		{
			const string __id = "createAttributionString.(Z)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shortenedOutput);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_parse;
#pragma warning disable 0169
		static Delegate GetParseHandler ()
		{
			if (cb_parse == null)
				cb_parse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Parse);
			return cb_parse;
		}

		static void n_Parse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Attribution.AttributionParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Parse ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.attribution']/class[@name='AttributionParser']/method[@name='parse' and count(parameter)=0]"
		[Register ("parse", "()V", "GetParseHandler")]
		protected virtual unsafe void Parse ()
		{
			const string __id = "parse.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
