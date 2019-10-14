using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry.Provider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry.provider']/class[@name='MapboxTelemetryInitProvider']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/provider/MapboxTelemetryInitProvider", DoNotGenerateAcw=true)]
	public partial class MapboxTelemetryInitProvider : global::Android.Content.ContentProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/provider/MapboxTelemetryInitProvider", typeof (MapboxTelemetryInitProvider));
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

		protected MapboxTelemetryInitProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry.provider']/class[@name='MapboxTelemetryInitProvider']/constructor[@name='MapboxTelemetryInitProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapboxTelemetryInitProvider ()
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

		static Delegate cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_selection, IntPtr native_selectionArgs)
		{
			global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			string selection = JNIEnv.GetString (native_selection, JniHandleOwnership.DoNotTransfer);
			string[] selectionArgs = (string[]) JNIEnv.GetArray (native_selectionArgs, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Delete (uri, selection, selectionArgs);
			if (selectionArgs != null)
				JNIEnv.CopyArray (selectionArgs, native_selectionArgs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.provider']/class[@name='MapboxTelemetryInitProvider']/method[@name='delete' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", "GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override unsafe int Delete (global::Android.Net.Uri uri, string selection, string[] selectionArgs)
		{
			const string __id = "delete.(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I";
			IntPtr native_selection = JNIEnv.NewString (selection);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_selection);
				__args [2] = new JniArgumentValue (native_selectionArgs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_selection);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
			}
		}

		static Delegate cb_getType_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetType_Landroid_net_Uri_Handler ()
		{
			if (cb_getType_Landroid_net_Uri_ == null)
				cb_getType_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetType_Landroid_net_Uri_);
			return cb_getType_Landroid_net_Uri_;
		}

		static IntPtr n_GetType_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetType (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.provider']/class[@name='MapboxTelemetryInitProvider']/method[@name='getType' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getType", "(Landroid/net/Uri;)Ljava/lang/String;", "GetGetType_Landroid_net_Uri_Handler")]
		public override unsafe string GetType (global::Android.Net.Uri uri)
		{
			const string __id = "getType.(Landroid/net/Uri;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler ()
		{
			if (cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ == null)
				cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_);
			return cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		}

		static IntPtr n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_values)
		{
			global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues values = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_values, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (uri, values));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.provider']/class[@name='MapboxTelemetryInitProvider']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentValues']]"
		[Register ("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", "GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler")]
		public override unsafe global::Android.Net.Uri Insert (global::Android.Net.Uri uri, global::Android.Content.ContentValues values)
		{
			const string __id = "insert.(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue ((values == null) ? IntPtr.Zero : ((global::Java.Lang.Object) values).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnCreate);
			return cb_onCreate;
		}

		static bool n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnCreate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.provider']/class[@name='MapboxTelemetryInitProvider']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()Z", "GetOnCreateHandler")]
		public override unsafe bool OnCreate ()
		{
			const string __id = "onCreate.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
				cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_);
			return cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_projection, IntPtr native_selection, IntPtr native_selectionArgs, IntPtr native_sortOrder)
		{
			global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			string[] projection = (string[]) JNIEnv.GetArray (native_projection, JniHandleOwnership.DoNotTransfer, typeof (string));
			string selection = JNIEnv.GetString (native_selection, JniHandleOwnership.DoNotTransfer);
			string[] selectionArgs = (string[]) JNIEnv.GetArray (native_selectionArgs, JniHandleOwnership.DoNotTransfer, typeof (string));
			string sortOrder = JNIEnv.GetString (native_sortOrder, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (uri, projection, selection, selectionArgs, sortOrder));
			if (projection != null)
				JNIEnv.CopyArray (projection, native_projection);
			if (selectionArgs != null)
				JNIEnv.CopyArray (selectionArgs, native_selectionArgs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.provider']/class[@name='MapboxTelemetryInitProvider']/method[@name='query' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String']]"
		[Register ("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Android.Database.ICursor Query (global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder)
		{
			const string __id = "query.(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;";
			IntPtr native_projection = JNIEnv.NewArray (projection);
			IntPtr native_selection = JNIEnv.NewString (selection);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			IntPtr native_sortOrder = JNIEnv.NewString (sortOrder);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_projection);
				__args [2] = new JniArgumentValue (native_selection);
				__args [3] = new JniArgumentValue (native_selectionArgs);
				__args [4] = new JniArgumentValue (native_sortOrder);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (projection != null) {
					JNIEnv.CopyArray (native_projection, projection);
					JNIEnv.DeleteLocalRef (native_projection);
				}
				JNIEnv.DeleteLocalRef (native_selection);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
				JNIEnv.DeleteLocalRef (native_sortOrder);
			}
		}

		static Delegate cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_values, IntPtr native_selection, IntPtr native_selectionArgs)
		{
			global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.Provider.MapboxTelemetryInitProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues values = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_values, JniHandleOwnership.DoNotTransfer);
			string selection = JNIEnv.GetString (native_selection, JniHandleOwnership.DoNotTransfer);
			string[] selectionArgs = (string[]) JNIEnv.GetArray (native_selectionArgs, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Update (uri, values, selection, selectionArgs);
			if (selectionArgs != null)
				JNIEnv.CopyArray (selectionArgs, native_selectionArgs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry.provider']/class[@name='MapboxTelemetryInitProvider']/method[@name='update' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentValues'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override unsafe int Update (global::Android.Net.Uri uri, global::Android.Content.ContentValues values, string selection, string[] selectionArgs)
		{
			const string __id = "update.(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I";
			IntPtr native_selection = JNIEnv.NewString (selection);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue ((values == null) ? IntPtr.Zero : ((global::Java.Lang.Object) values).Handle);
				__args [2] = new JniArgumentValue (native_selection);
				__args [3] = new JniArgumentValue (native_selectionArgs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_selection);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
			}
		}

	}
}
