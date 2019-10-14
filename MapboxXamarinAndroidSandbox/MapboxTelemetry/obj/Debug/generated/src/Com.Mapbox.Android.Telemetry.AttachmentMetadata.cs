using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Telemetry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']"
	[global::Android.Runtime.Register ("com/mapbox/android/telemetry/AttachmentMetadata", DoNotGenerateAcw=true)]
	public partial class AttachmentMetadata : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/telemetry/AttachmentMetadata", typeof (AttachmentMetadata));
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

		protected AttachmentMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/constructor[@name='AttachmentMetadata' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AttachmentMetadata (string name, string fileId, string format, string type, string sessionId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_fileId = JNIEnv.NewString (fileId);
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_type = JNIEnv.NewString (type);
			IntPtr native_sessionId = JNIEnv.NewString (sessionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_fileId);
				__args [2] = new JniArgumentValue (native_format);
				__args [3] = new JniArgumentValue (native_type);
				__args [4] = new JniArgumentValue (native_sessionId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_fileId);
				JNIEnv.DeleteLocalRef (native_format);
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_sessionId);
			}
		}

		static Delegate cb_getCreated;
#pragma warning disable 0169
		static Delegate GetGetCreatedHandler ()
		{
			if (cb_getCreated == null)
				cb_getCreated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreated);
			return cb_getCreated;
		}

		static IntPtr n_GetCreated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Created);
		}
#pragma warning restore 0169

		public virtual unsafe string Created {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='getCreated' and count(parameter)=0]"
			[Register ("getCreated", "()Ljava/lang/String;", "GetGetCreatedHandler")]
			get {
				const string __id = "getCreated.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEndTime;
#pragma warning disable 0169
		static Delegate GetGetEndTimeHandler ()
		{
			if (cb_getEndTime == null)
				cb_getEndTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndTime);
			return cb_getEndTime;
		}

		static IntPtr n_GetEndTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndTime);
		}
#pragma warning restore 0169

		static Delegate cb_setEndTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEndTime_Ljava_lang_String_Handler ()
		{
			if (cb_setEndTime_Ljava_lang_String_ == null)
				cb_setEndTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndTime_Ljava_lang_String_);
			return cb_setEndTime_Ljava_lang_String_;
		}

		static void n_SetEndTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_endTime)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string endTime = JNIEnv.GetString (native_endTime, JniHandleOwnership.DoNotTransfer);
			__this.EndTime = endTime;
		}
#pragma warning restore 0169

		public virtual unsafe string EndTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='getEndTime' and count(parameter)=0]"
			[Register ("getEndTime", "()Ljava/lang/String;", "GetGetEndTimeHandler")]
			get {
				const string __id = "getEndTime.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='setEndTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEndTime", "(Ljava/lang/String;)V", "GetSetEndTime_Ljava_lang_String_Handler")]
			set {
				const string __id = "setEndTime.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFileId;
#pragma warning disable 0169
		static Delegate GetGetFileIdHandler ()
		{
			if (cb_getFileId == null)
				cb_getFileId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileId);
			return cb_getFileId;
		}

		static IntPtr n_GetFileId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileId);
		}
#pragma warning restore 0169

		public virtual unsafe string FileId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='getFileId' and count(parameter)=0]"
			[Register ("getFileId", "()Ljava/lang/String;", "GetGetFileIdHandler")]
			get {
				const string __id = "getFileId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Format);
		}
#pragma warning restore 0169

		public virtual unsafe string Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ljava/lang/String;", "GetGetFormatHandler")]
			get {
				const string __id = "getFormat.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionId);
			return cb_getSessionId;
		}

		static IntPtr n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				const string __id = "getSessionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSize);
			return cb_getSize;
		}

		static IntPtr n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()Ljava/lang/Integer;", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartTime);
			return cb_getStartTime;
		}

		static IntPtr n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StartTime);
		}
#pragma warning restore 0169

		static Delegate cb_setStartTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStartTime_Ljava_lang_String_Handler ()
		{
			if (cb_setStartTime_Ljava_lang_String_ == null)
				cb_setStartTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartTime_Ljava_lang_String_);
			return cb_setStartTime_Ljava_lang_String_;
		}

		static void n_SetStartTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_startTime)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string startTime = JNIEnv.GetString (native_startTime, JniHandleOwnership.DoNotTransfer);
			__this.StartTime = startTime;
		}
#pragma warning restore 0169

		public virtual unsafe string StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()Ljava/lang/String;", "GetGetStartTimeHandler")]
			get {
				const string __id = "getStartTime.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='setStartTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStartTime", "(Ljava/lang/String;)V", "GetSetStartTime_Ljava_lang_String_Handler")]
			set {
				const string __id = "setStartTime.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setSize_I;
#pragma warning disable 0169
		static Delegate GetSetSize_IHandler ()
		{
			if (cb_setSize_I == null)
				cb_setSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSize_I);
			return cb_setSize_I;
		}

		static void n_SetSize_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			global::Com.Mapbox.Android.Telemetry.AttachmentMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Android.Telemetry.AttachmentMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSize (size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.telemetry']/class[@name='AttachmentMetadata']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSize", "(I)V", "GetSetSize_IHandler")]
		public virtual unsafe void SetSize (int size)
		{
			const string __id = "setSize.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
