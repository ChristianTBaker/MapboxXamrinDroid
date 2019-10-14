using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Soloader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']"
	[global::Android.Runtime.Register ("com/facebook/soloader/UnpackingSoSource", DoNotGenerateAcw=true)]
	public abstract partial class UnpackingSoSource : global::Com.Facebook.Soloader.DirectorySoSource {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/field[@name='mCorruptedLib']"
		[Register ("mCorruptedLib")]
		protected string MCorruptedLib {
			get {
				const string __id = "mCorruptedLib.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCorruptedLib.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Dso']"
		[global::Android.Runtime.Register ("com/facebook/soloader/UnpackingSoSource$Dso", DoNotGenerateAcw=true)]
		public partial class Dso : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Dso']/field[@name='hash']"
			[Register ("hash")]
			public string Hash {
				get {
					const string __id = "hash.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "hash.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Dso']/field[@name='name']"
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
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/UnpackingSoSource$Dso", typeof (Dso));
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

			protected Dso (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Dso']/constructor[@name='UnpackingSoSource.Dso' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Dso (string name, string hash)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_hash = JNIEnv.NewString (hash);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_hash);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_hash);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.DsoManifest']"
		[global::Android.Runtime.Register ("com/facebook/soloader/UnpackingSoSource$DsoManifest", DoNotGenerateAcw=true)]
		public sealed partial class DsoManifest : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.DsoManifest']/field[@name='dsos']"
			[Register ("dsos")]
			public IList<Com.Facebook.Soloader.UnpackingSoSource.Dso> Dsos {
				get {
					const string __id = "dsos.[Lcom/facebook/soloader/UnpackingSoSource$Dso;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<global::Com.Facebook.Soloader.UnpackingSoSource.Dso>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "dsos.[Lcom/facebook/soloader/UnpackingSoSource$Dso;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Facebook.Soloader.UnpackingSoSource.Dso>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/UnpackingSoSource$DsoManifest", typeof (DsoManifest));
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

			internal DsoManifest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.DsoManifest']/constructor[@name='UnpackingSoSource.DsoManifest' and count(parameter)=1 and parameter[1][@type='com.facebook.soloader.UnpackingSoSource.Dso[]']]"
			[Register (".ctor", "([Lcom/facebook/soloader/UnpackingSoSource$Dso;)V", "")]
			public unsafe DsoManifest (global::Com.Facebook.Soloader.UnpackingSoSource.Dso[] dsos)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([Lcom/facebook/soloader/UnpackingSoSource$Dso;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_dsos = JNIEnv.NewArray (dsos);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_dsos);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (dsos != null) {
						JNIEnv.CopyArray (native_dsos, dsos);
						JNIEnv.DeleteLocalRef (native_dsos);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.DsoManifest']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.io.DataOutput']]"
			[Register ("write", "(Ljava/io/DataOutput;)V", "")]
			public unsafe void Write (global::Java.IO.IDataOutput xdo)
			{
				const string __id = "write.(Ljava/io/DataOutput;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((xdo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) xdo).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDso']"
		[global::Android.Runtime.Register ("com/facebook/soloader/UnpackingSoSource$InputDso", DoNotGenerateAcw=true)]
		protected internal sealed partial class InputDso : global::Java.Lang.Object, global::Java.IO.ICloseable {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDso']/field[@name='content']"
			[Register ("content")]
			public global::System.IO.Stream Content {
				get {
					const string __id = "content.Ljava/io/InputStream;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "content.Ljava/io/InputStream;";

					IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDso']/field[@name='dso']"
			[Register ("dso")]
			public global::Com.Facebook.Soloader.UnpackingSoSource.Dso Dso {
				get {
					const string __id = "dso.Lcom/facebook/soloader/UnpackingSoSource$Dso;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.Dso> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "dso.Lcom/facebook/soloader/UnpackingSoSource$Dso;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/UnpackingSoSource$InputDso", typeof (InputDso));
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

			internal InputDso (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDso']/constructor[@name='UnpackingSoSource.InputDso' and count(parameter)=2 and parameter[1][@type='com.facebook.soloader.UnpackingSoSource.Dso'] and parameter[2][@type='java.io.InputStream']]"
			[Register (".ctor", "(Lcom/facebook/soloader/UnpackingSoSource$Dso;Ljava/io/InputStream;)V", "")]
			public unsafe InputDso (global::Com.Facebook.Soloader.UnpackingSoSource.Dso dso, global::System.IO.Stream content)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/facebook/soloader/UnpackingSoSource$Dso;Ljava/io/InputStream;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_content = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (content);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((dso == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dso).Handle);
					__args [1] = new JniArgumentValue (native_content);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_content);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDso']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDsoIterator']"
		[global::Android.Runtime.Register ("com/facebook/soloader/UnpackingSoSource$InputDsoIterator", DoNotGenerateAcw=true)]
		protected internal abstract partial class InputDsoIterator : global::Java.Lang.Object, global::Java.IO.ICloseable {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/UnpackingSoSource$InputDsoIterator", typeof (InputDsoIterator));
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

			protected InputDsoIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDsoIterator']/constructor[@name='UnpackingSoSource.InputDsoIterator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe InputDsoIterator ()
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

			static Delegate cb_hasNext;
#pragma warning disable 0169
			static Delegate GetHasNextHandler ()
			{
				if (cb_hasNext == null)
					cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
				return cb_hasNext;
			}

			static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public abstract bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDsoIterator']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetHasNextHandler")] get;
			}

			static Delegate cb_close;
#pragma warning disable 0169
			static Delegate GetCloseHandler ()
			{
				if (cb_close == null)
					cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
				return cb_close;
			}

			static void n_Close (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDsoIterator']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public virtual unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_next;
#pragma warning disable 0169
			static Delegate GetNextHandler ()
			{
				if (cb_next == null)
					cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
				return cb_next;
			}

			static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Next ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDsoIterator']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
			public abstract global::Java.Lang.Object Next ();

		}

		[global::Android.Runtime.Register ("com/facebook/soloader/UnpackingSoSource$InputDsoIterator", DoNotGenerateAcw=true)]
		internal partial class InputDsoIteratorInvoker : InputDsoIterator {

			public InputDsoIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/facebook/soloader/UnpackingSoSource$InputDsoIterator", typeof (InputDsoIteratorInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			public override unsafe bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDsoIterator']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetHasNextHandler")]
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.InputDsoIterator']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
			public override unsafe global::Java.Lang.Object Next ()
			{
				const string __id = "next.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Unpacker']"
		[global::Android.Runtime.Register ("com/facebook/soloader/UnpackingSoSource$Unpacker", DoNotGenerateAcw=true)]
		protected internal abstract partial class Unpacker : global::Java.Lang.Object, global::Java.IO.ICloseable {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/UnpackingSoSource$Unpacker", typeof (Unpacker));
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

			protected Unpacker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Unpacker']/constructor[@name='UnpackingSoSource.Unpacker' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe Unpacker ()
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

			static Delegate cb_getDsoManifest;
#pragma warning disable 0169
			static Delegate GetGetDsoManifestHandler ()
			{
				if (cb_getDsoManifest == null)
					cb_getDsoManifest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDsoManifest);
				return cb_getDsoManifest;
			}

			static IntPtr n_GetDsoManifest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DsoManifest);
			}
#pragma warning restore 0169

			protected abstract global::Com.Facebook.Soloader.UnpackingSoSource.DsoManifest DsoManifest {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Unpacker']/method[@name='getDsoManifest' and count(parameter)=0]"
				[Register ("getDsoManifest", "()Lcom/facebook/soloader/UnpackingSoSource$DsoManifest;", "GetGetDsoManifestHandler")] get;
			}

			static Delegate cb_close;
#pragma warning disable 0169
			static Delegate GetCloseHandler ()
			{
				if (cb_close == null)
					cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
				return cb_close;
			}

			static void n_Close (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Unpacker']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public virtual unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_openDsoIterator;
#pragma warning disable 0169
			static Delegate GetOpenDsoIteratorHandler ()
			{
				if (cb_openDsoIterator == null)
					cb_openDsoIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OpenDsoIterator);
				return cb_openDsoIterator;
			}

			static IntPtr n_OpenDsoIterator (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OpenDsoIterator ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Unpacker']/method[@name='openDsoIterator' and count(parameter)=0]"
			[Register ("openDsoIterator", "()Lcom/facebook/soloader/UnpackingSoSource$InputDsoIterator;", "GetOpenDsoIteratorHandler")]
			protected abstract global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator OpenDsoIterator ();

		}

		[global::Android.Runtime.Register ("com/facebook/soloader/UnpackingSoSource$Unpacker", DoNotGenerateAcw=true)]
		internal partial class UnpackerInvoker : Unpacker {

			public UnpackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/facebook/soloader/UnpackingSoSource$Unpacker", typeof (UnpackerInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected override unsafe global::Com.Facebook.Soloader.UnpackingSoSource.DsoManifest DsoManifest {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Unpacker']/method[@name='getDsoManifest' and count(parameter)=0]"
				[Register ("getDsoManifest", "()Lcom/facebook/soloader/UnpackingSoSource$DsoManifest;", "GetGetDsoManifestHandler")]
				get {
					const string __id = "getDsoManifest.()Lcom/facebook/soloader/UnpackingSoSource$DsoManifest;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.DsoManifest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource.Unpacker']/method[@name='openDsoIterator' and count(parameter)=0]"
			[Register ("openDsoIterator", "()Lcom/facebook/soloader/UnpackingSoSource$InputDsoIterator;", "GetOpenDsoIteratorHandler")]
			protected override unsafe global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator OpenDsoIterator ()
			{
				const string __id = "openDsoIterator.()Lcom/facebook/soloader/UnpackingSoSource$InputDsoIterator;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.InputDsoIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/facebook/soloader/UnpackingSoSource", typeof (UnpackingSoSource));
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

		protected UnpackingSoSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/constructor[@name='UnpackingSoSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/io/File;)V", "")]
		protected unsafe UnpackingSoSource (global::Android.Content.Context context, global::Java.IO.File storePath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/io/File;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((storePath == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storePath).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/constructor[@name='UnpackingSoSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		protected unsafe UnpackingSoSource (global::Android.Content.Context context, string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getDepsBlock;
#pragma warning disable 0169
		static Delegate GetGetDepsBlockHandler ()
		{
			if (cb_getDepsBlock == null)
				cb_getDepsBlock = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDepsBlock);
			return cb_getDepsBlock;
		}

		static IntPtr n_GetDepsBlock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Soloader.UnpackingSoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDepsBlock ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/method[@name='getDepsBlock' and count(parameter)=0]"
		[Register ("getDepsBlock", "()[B", "GetGetDepsBlockHandler")]
		protected virtual unsafe byte[] GetDepsBlock ()
		{
			const string __id = "getDepsBlock.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/method[@name='getSoStorePath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSoStorePath", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetSoStorePath (global::Android.Content.Context context, string name)
		{
			const string __id = "getSoStorePath.(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_makeUnpacker;
#pragma warning disable 0169
		static Delegate GetMakeUnpackerHandler ()
		{
			if (cb_makeUnpacker == null)
				cb_makeUnpacker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MakeUnpacker);
			return cb_makeUnpacker;
		}

		static IntPtr n_MakeUnpacker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Soloader.UnpackingSoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MakeUnpacker ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/method[@name='makeUnpacker' and count(parameter)=0]"
		[Register ("makeUnpacker", "()Lcom/facebook/soloader/UnpackingSoSource$Unpacker;", "GetMakeUnpackerHandler")]
		protected abstract global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker MakeUnpacker ();

		static Delegate cb_prepare_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrepare_Ljava_lang_String_Handler ()
		{
			if (cb_prepare_Ljava_lang_String_ == null)
				cb_prepare_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Prepare_Ljava_lang_String_);
			return cb_prepare_Ljava_lang_String_;
		}

		static void n_Prepare_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_soName)
		{
			global::Com.Facebook.Soloader.UnpackingSoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string soName = JNIEnv.GetString (native_soName, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (soName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("prepare", "(Ljava/lang/String;)V", "GetPrepare_Ljava_lang_String_Handler")]
		protected virtual unsafe void Prepare (string soName)
		{
			const string __id = "prepare.(Ljava/lang/String;)V";
			IntPtr native_soName = JNIEnv.NewString (soName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_soName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_soName);
			}
		}

		static Delegate cb_setSoSourceAbis_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSoSourceAbis_arrayLjava_lang_String_Handler ()
		{
			if (cb_setSoSourceAbis_arrayLjava_lang_String_ == null)
				cb_setSoSourceAbis_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSoSourceAbis_arrayLjava_lang_String_);
			return cb_setSoSourceAbis_arrayLjava_lang_String_;
		}

		static void n_SetSoSourceAbis_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_abis)
		{
			global::Com.Facebook.Soloader.UnpackingSoSource __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] abis = (string[]) JNIEnv.GetArray (native_abis, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetSoSourceAbis (abis);
			if (abis != null)
				JNIEnv.CopyArray (abis, native_abis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/method[@name='setSoSourceAbis' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setSoSourceAbis", "([Ljava/lang/String;)V", "GetSetSoSourceAbis_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetSoSourceAbis (string[] abis)
		{
			const string __id = "setSoSourceAbis.([Ljava/lang/String;)V";
			IntPtr native_abis = JNIEnv.NewArray (abis);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_abis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (abis != null) {
					JNIEnv.CopyArray (native_abis, abis);
					JNIEnv.DeleteLocalRef (native_abis);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/facebook/soloader/UnpackingSoSource", DoNotGenerateAcw=true)]
	internal partial class UnpackingSoSourceInvoker : UnpackingSoSource {

		public UnpackingSoSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/facebook/soloader/UnpackingSoSource", typeof (UnpackingSoSourceInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.soloader']/class[@name='UnpackingSoSource']/method[@name='makeUnpacker' and count(parameter)=0]"
		[Register ("makeUnpacker", "()Lcom/facebook/soloader/UnpackingSoSource$Unpacker;", "GetMakeUnpackerHandler")]
		protected override unsafe global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker MakeUnpacker ()
		{
			const string __id = "makeUnpacker.()Lcom/facebook/soloader/UnpackingSoSource$Unpacker;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Soloader.UnpackingSoSource.Unpacker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
