using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/Mapbox", DoNotGenerateAcw=true)]
	public sealed partial class Mapbox : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/Mapbox", typeof (Mapbox));
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

		internal Mapbox (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				const string __id = "getAccessToken.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)V", "GetSetAccessToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccessToken.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				const string __id = "getApplicationContext.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool HasInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='hasInstance' and count(parameter)=0]"
			[Register ("hasInstance", "()Z", "GetHasInstanceHandler")]
			get {
				const string __id = "hasInstance.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Com.Mapbox.Mapboxsdk.IModuleProvider ModuleProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='getModuleProvider' and count(parameter)=0]"
			[Register ("getModuleProvider", "()Lcom/mapbox/mapboxsdk/ModuleProvider;", "GetGetModuleProviderHandler")]
			get {
				const string __id = "getModuleProvider.()Lcom/mapbox/mapboxsdk/ModuleProvider;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.IModuleProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string SkuToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='getSkuToken' and count(parameter)=0]"
			[Register ("getSkuToken", "()Ljava/lang/String;", "GetGetSkuTokenHandler")]
			get {
				const string __id = "getSkuToken.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition Telemetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='getTelemetry' and count(parameter)=0]"
			[Register ("getTelemetry", "()Lcom/mapbox/mapboxsdk/maps/TelemetryDefinition;", "GetGetTelemetryHandler")]
			get {
				const string __id = "getTelemetry.()Lcom/mapbox/mapboxsdk/maps/TelemetryDefinition;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.ITelemetryDefinition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstance", "(Landroid/content/Context;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/Mapbox;", "")]
		public static unsafe global::Com.Mapbox.Mapboxsdk.Mapbox GetInstance (global::Android.Content.Context context, string accessToken)
		{
			const string __id = "getInstance.(Landroid/content/Context;Ljava/lang/String;)Lcom/mapbox/mapboxsdk/Mapbox;";
			IntPtr native_accessToken = JNIEnv.NewString (accessToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_accessToken);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Mapbox> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accessToken);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='isConnected' and count(parameter)=0]"
		[Register ("isConnected", "()Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean IsConnected ()
		{
			const string __id = "isConnected.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk']/class[@name='Mapbox']/method[@name='setConnected' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setConnected", "(Ljava/lang/Boolean;)V", "")]
		public static unsafe void SetConnected (global::Java.Lang.Boolean connected)
		{
			const string __id = "setConnected.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((connected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connected).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
