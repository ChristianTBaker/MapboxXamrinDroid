using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.android.core']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/mapbox/android/core/FileUtils", DoNotGenerateAcw=true)]
	public sealed partial class FileUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/android/core/FileUtils", typeof (FileUtils));
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

		internal FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core']/class[@name='FileUtils']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteFile", "(Ljava/io/File;)V", "")]
		public static unsafe void DeleteFile (global::Java.IO.File file)
		{
			const string __id = "deleteFile.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core']/class[@name='FileUtils']/method[@name='deleteFirst' and count(parameter)=3 and parameter[1][@type='java.io.File[]'] and parameter[2][@type='java.util.Comparator&lt;java.io.File&gt;'] and parameter[3][@type='int']]"
		[Register ("deleteFirst", "([Ljava/io/File;Ljava/util/Comparator;I)V", "")]
		public static unsafe void DeleteFirst (global::Java.IO.File[] files, global::Java.Util.IComparator sortedBy, int numFiles)
		{
			const string __id = "deleteFirst.([Ljava/io/File;Ljava/util/Comparator;I)V";
			IntPtr native_files = JNIEnv.NewArray (files);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_files);
				__args [1] = new JniArgumentValue ((sortedBy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sortedBy).Handle);
				__args [2] = new JniArgumentValue (numFiles);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (files != null) {
					JNIEnv.CopyArray (native_files, files);
					JNIEnv.DeleteLocalRef (native_files);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core']/class[@name='FileUtils']/method[@name='getFile' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getFile", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetFile (global::Android.Content.Context context, string fileName)
		{
			const string __id = "getFile.(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_fileName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core']/class[@name='FileUtils']/method[@name='listAllFiles' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("listAllFiles", "(Ljava/io/File;)[Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File[] ListAllFiles (global::Java.IO.File directory)
		{
			const string __id = "listAllFiles.(Ljava/io/File;)[Ljava/io/File;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core']/class[@name='FileUtils']/method[@name='readFromFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readFromFile", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string ReadFromFile (global::Java.IO.File file)
		{
			const string __id = "readFromFile.(Ljava/io/File;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.core']/class[@name='FileUtils']/method[@name='writeToFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeToFile", "(Ljava/io/File;Ljava/lang/String;)V", "")]
		public static unsafe void WriteToFile (global::Java.IO.File file, string content)
		{
			const string __id = "writeToFile.(Ljava/io/File;Ljava/lang/String;)V";
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [1] = new JniArgumentValue (native_content);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

	}
}
