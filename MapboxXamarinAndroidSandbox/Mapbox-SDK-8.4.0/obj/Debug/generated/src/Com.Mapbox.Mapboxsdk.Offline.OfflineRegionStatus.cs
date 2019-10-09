using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionStatus']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/offline/OfflineRegionStatus", DoNotGenerateAcw=true)]
	public partial class OfflineRegionStatus : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/offline/OfflineRegionStatus", typeof (OfflineRegionStatus));
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

		protected OfflineRegionStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCompletedResourceCount;
#pragma warning disable 0169
		static Delegate GetGetCompletedResourceCountHandler ()
		{
			if (cb_getCompletedResourceCount == null)
				cb_getCompletedResourceCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCompletedResourceCount);
			return cb_getCompletedResourceCount;
		}

		static long n_GetCompletedResourceCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompletedResourceCount;
		}
#pragma warning restore 0169

		public virtual unsafe long CompletedResourceCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionStatus']/method[@name='getCompletedResourceCount' and count(parameter)=0]"
			[Register ("getCompletedResourceCount", "()J", "GetGetCompletedResourceCountHandler")]
			get {
				const string __id = "getCompletedResourceCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCompletedResourceSize;
#pragma warning disable 0169
		static Delegate GetGetCompletedResourceSizeHandler ()
		{
			if (cb_getCompletedResourceSize == null)
				cb_getCompletedResourceSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCompletedResourceSize);
			return cb_getCompletedResourceSize;
		}

		static long n_GetCompletedResourceSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompletedResourceSize;
		}
#pragma warning restore 0169

		public virtual unsafe long CompletedResourceSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionStatus']/method[@name='getCompletedResourceSize' and count(parameter)=0]"
			[Register ("getCompletedResourceSize", "()J", "GetGetCompletedResourceSizeHandler")]
			get {
				const string __id = "getCompletedResourceSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCompletedTileCount;
#pragma warning disable 0169
		static Delegate GetGetCompletedTileCountHandler ()
		{
			if (cb_getCompletedTileCount == null)
				cb_getCompletedTileCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCompletedTileCount);
			return cb_getCompletedTileCount;
		}

		static long n_GetCompletedTileCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompletedTileCount;
		}
#pragma warning restore 0169

		public virtual unsafe long CompletedTileCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionStatus']/method[@name='getCompletedTileCount' and count(parameter)=0]"
			[Register ("getCompletedTileCount", "()J", "GetGetCompletedTileCountHandler")]
			get {
				const string __id = "getCompletedTileCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCompletedTileSize;
#pragma warning disable 0169
		static Delegate GetGetCompletedTileSizeHandler ()
		{
			if (cb_getCompletedTileSize == null)
				cb_getCompletedTileSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCompletedTileSize);
			return cb_getCompletedTileSize;
		}

		static long n_GetCompletedTileSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompletedTileSize;
		}
#pragma warning restore 0169

		public virtual unsafe long CompletedTileSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionStatus']/method[@name='getCompletedTileSize' and count(parameter)=0]"
			[Register ("getCompletedTileSize", "()J", "GetGetCompletedTileSizeHandler")]
			get {
				const string __id = "getCompletedTileSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDownloadState;
#pragma warning disable 0169
		static Delegate GetGetDownloadStateHandler ()
		{
			if (cb_getDownloadState == null)
				cb_getDownloadState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownloadState);
			return cb_getDownloadState;
		}

		static int n_GetDownloadState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DownloadState;
		}
#pragma warning restore 0169

		public virtual unsafe int DownloadState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionStatus']/method[@name='getDownloadState' and count(parameter)=0]"
			[Register ("getDownloadState", "()I", "GetGetDownloadStateHandler")]
			get {
				const string __id = "getDownloadState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isComplete;
#pragma warning disable 0169
		static Delegate GetIsCompleteHandler ()
		{
			if (cb_isComplete == null)
				cb_isComplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsComplete);
			return cb_isComplete;
		}

		static bool n_IsComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionStatus']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler")]
			get {
				const string __id = "isComplete.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRequiredResourceCountPrecise;
#pragma warning disable 0169
		static Delegate GetIsRequiredResourceCountPreciseHandler ()
		{
			if (cb_isRequiredResourceCountPrecise == null)
				cb_isRequiredResourceCountPrecise = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRequiredResourceCountPrecise);
			return cb_isRequiredResourceCountPrecise;
		}

		static bool n_IsRequiredResourceCountPrecise (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRequiredResourceCountPrecise;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRequiredResourceCountPrecise {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionStatus']/method[@name='isRequiredResourceCountPrecise' and count(parameter)=0]"
			[Register ("isRequiredResourceCountPrecise", "()Z", "GetIsRequiredResourceCountPreciseHandler")]
			get {
				const string __id = "isRequiredResourceCountPrecise.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequiredResourceCount;
#pragma warning disable 0169
		static Delegate GetGetRequiredResourceCountHandler ()
		{
			if (cb_getRequiredResourceCount == null)
				cb_getRequiredResourceCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRequiredResourceCount);
			return cb_getRequiredResourceCount;
		}

		static long n_GetRequiredResourceCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Offline.OfflineRegionStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiredResourceCount;
		}
#pragma warning restore 0169

		public virtual unsafe long RequiredResourceCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.offline']/class[@name='OfflineRegionStatus']/method[@name='getRequiredResourceCount' and count(parameter)=0]"
			[Register ("getRequiredResourceCount", "()J", "GetGetRequiredResourceCountHandler")]
			get {
				const string __id = "getRequiredResourceCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
