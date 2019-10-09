using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/LocationComponent", DoNotGenerateAcw=true)]
	public sealed partial class LocationComponent : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent.InternalLocationEngineProvider']"
		[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/location/LocationComponent$InternalLocationEngineProvider", DoNotGenerateAcw=true)]
		public partial class InternalLocationEngineProvider : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/location/LocationComponent$InternalLocationEngineProvider", typeof (InternalLocationEngineProvider));
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

			protected InternalLocationEngineProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/location/LocationComponent", typeof (LocationComponent));
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

		internal LocationComponent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/constructor[@name='LocationComponent' and count(parameter)=3 and parameter[1][@type='com.mapbox.mapboxsdk.maps.MapboxMap'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Transform'] and parameter[3][@type='java.util.List&lt;com.mapbox.mapboxsdk.maps.MapboxMap.OnDeveloperAnimationListener&gt;']]"
		[Register (".ctor", "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;Lcom/mapbox/mapboxsdk/maps/Transform;Ljava/util/List;)V", "")]
		public unsafe LocationComponent (global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap mapboxMap, global::Com.Mapbox.Mapboxsdk.Maps.Transform transform, global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnDeveloperAnimationListener> developerAnimationListeners)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/mapbox/mapboxsdk/maps/MapboxMap;Lcom/mapbox/mapboxsdk/maps/Transform;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_developerAnimationListeners = global::Android.Runtime.JavaList<global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.IOnDeveloperAnimationListener>.ToLocalJniHandle (developerAnimationListeners);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mapboxMap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapboxMap).Handle);
				__args [1] = new JniArgumentValue ((transform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transform).Handle);
				__args [2] = new JniArgumentValue (native_developerAnimationListeners);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_developerAnimationListeners);
			}
		}

		public unsafe int CameraMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='getCameraMode' and count(parameter)=0]"
			[Register ("getCameraMode", "()I", "GetGetCameraModeHandler")]
			get {
				const string __id = "getCameraMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='setCameraMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCameraMode", "(I)V", "GetSetCameraMode_IHandler")]
			set {
				const string __id = "setCameraMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine CompassEngine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='getCompassEngine' and count(parameter)=0]"
			[Register ("getCompassEngine", "()Lcom/mapbox/mapboxsdk/location/CompassEngine;", "GetGetCompassEngineHandler")]
			get {
				const string __id = "getCompassEngine.()Lcom/mapbox/mapboxsdk/location/CompassEngine;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.ICompassEngine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='setCompassEngine' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.CompassEngine']]"
			[Register ("setCompassEngine", "(Lcom/mapbox/mapboxsdk/location/CompassEngine;)V", "GetSetCompassEngine_Lcom_mapbox_mapboxsdk_location_CompassEngine_Handler")]
			set {
				const string __id = "setCompassEngine.(Lcom/mapbox/mapboxsdk/location/CompassEngine;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool IsLocationComponentActivated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='isLocationComponentActivated' and count(parameter)=0]"
			[Register ("isLocationComponentActivated", "()Z", "GetIsLocationComponentActivatedHandler")]
			get {
				const string __id = "isLocationComponentActivated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Locations.Location LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Landroid/location/Location;", "GetGetLastKnownLocationHandler")]
			get {
				const string __id = "getLastKnownLocation.()Landroid/location/Location;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool LocationComponentEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='isLocationComponentEnabled' and count(parameter)=0]"
			[Register ("isLocationComponentEnabled", "()Z", "GetIsLocationComponentEnabledHandler")]
			get {
				const string __id = "isLocationComponentEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='setLocationComponentEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLocationComponentEnabled", "(Z)V", "GetSetLocationComponentEnabled_ZHandler")]
			set {
				const string __id = "setLocationComponentEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions LocationComponentOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='getLocationComponentOptions' and count(parameter)=0]"
			[Register ("getLocationComponentOptions", "()Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;", "GetGetLocationComponentOptionsHandler")]
			get {
				const string __id = "getLocationComponentOptions.()Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int RenderMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='getRenderMode' and count(parameter)=0]"
			[Register ("getRenderMode", "()I", "GetGetRenderModeHandler")]
			get {
				const string __id = "getRenderMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='setRenderMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRenderMode", "(I)V", "GetSetRenderMode_IHandler")]
			set {
				const string __id = "setRenderMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='activateLocationComponent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Style']]"
		[Obsolete (@"deprecated")]
		[Register ("activateLocationComponent", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;)V", "")]
		public unsafe void ActivateLocationComponent (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.Style style)
		{
			const string __id = "activateLocationComponent.(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((style == null) ? IntPtr.Zero : ((global::Java.Lang.Object) style).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='activateLocationComponent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Style'] and parameter[3][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("activateLocationComponent", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;Z)V", "")]
		public unsafe void ActivateLocationComponent (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.Style style, bool useDefaultLocationEngine)
		{
			const string __id = "activateLocationComponent.(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((style == null) ? IntPtr.Zero : ((global::Java.Lang.Object) style).Handle);
				__args [2] = new JniArgumentValue (useDefaultLocationEngine);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='activateLocationComponent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Style'] and parameter[3][@type='com.mapbox.mapboxsdk.location.LocationComponentOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("activateLocationComponent", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;)V", "")]
		public unsafe void ActivateLocationComponent (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.Style style, global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions options)
		{
			const string __id = "activateLocationComponent.(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((style == null) ? IntPtr.Zero : ((global::Java.Lang.Object) style).Handle);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='activateLocationComponent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mapbox.mapboxsdk.maps.Style'] and parameter[3][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("activateLocationComponent", "(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;I)V", "")]
		public unsafe void ActivateLocationComponent (global::Android.Content.Context context, global::Com.Mapbox.Mapboxsdk.Maps.Style style, int styleRes)
		{
			const string __id = "activateLocationComponent.(Landroid/content/Context;Lcom/mapbox/mapboxsdk/maps/Style;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((style == null) ? IntPtr.Zero : ((global::Java.Lang.Object) style).Handle);
				__args [2] = new JniArgumentValue (styleRes);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='activateLocationComponent' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.LocationComponentActivationOptions']]"
		[Register ("activateLocationComponent", "(Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions;)V", "")]
		public unsafe void ActivateLocationComponent (global::Com.Mapbox.Mapboxsdk.Location.LocationComponentActivationOptions activationOptions)
		{
			const string __id = "activateLocationComponent.(Lcom/mapbox/mapboxsdk/location/LocationComponentActivationOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activationOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activationOptions).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='addOnCameraTrackingChangedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnCameraTrackingChangedListener']]"
		[Register ("addOnCameraTrackingChangedListener", "(Lcom/mapbox/mapboxsdk/location/OnCameraTrackingChangedListener;)V", "")]
		public unsafe void AddOnCameraTrackingChangedListener (global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener listener)
		{
			const string __id = "addOnCameraTrackingChangedListener.(Lcom/mapbox/mapboxsdk/location/OnCameraTrackingChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='addOnLocationClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnLocationClickListener']]"
		[Register ("addOnLocationClickListener", "(Lcom/mapbox/mapboxsdk/location/OnLocationClickListener;)V", "")]
		public unsafe void AddOnLocationClickListener (global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListener listener)
		{
			const string __id = "addOnLocationClickListener.(Lcom/mapbox/mapboxsdk/location/OnLocationClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='addOnLocationLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnLocationLongClickListener']]"
		[Register ("addOnLocationLongClickListener", "(Lcom/mapbox/mapboxsdk/location/OnLocationLongClickListener;)V", "")]
		public unsafe void AddOnLocationLongClickListener (global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListener listener)
		{
			const string __id = "addOnLocationLongClickListener.(Lcom/mapbox/mapboxsdk/location/OnLocationLongClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='addOnLocationStaleListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnLocationStaleListener']]"
		[Register ("addOnLocationStaleListener", "(Lcom/mapbox/mapboxsdk/location/OnLocationStaleListener;)V", "")]
		public unsafe void AddOnLocationStaleListener (global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListener listener)
		{
			const string __id = "addOnLocationStaleListener.(Lcom/mapbox/mapboxsdk/location/OnLocationStaleListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='addOnRenderModeChangedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnRenderModeChangedListener']]"
		[Register ("addOnRenderModeChangedListener", "(Lcom/mapbox/mapboxsdk/location/OnRenderModeChangedListener;)V", "")]
		public unsafe void AddOnRenderModeChangedListener (global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListener listener)
		{
			const string __id = "addOnRenderModeChangedListener.(Lcom/mapbox/mapboxsdk/location/OnRenderModeChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='applyStyle' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("applyStyle", "(Landroid/content/Context;I)V", "")]
		public unsafe void ApplyStyle (global::Android.Content.Context context, int styleRes)
		{
			const string __id = "applyStyle.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (styleRes);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='applyStyle' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.LocationComponentOptions']]"
		[Register ("applyStyle", "(Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;)V", "")]
		public unsafe void ApplyStyle (global::Com.Mapbox.Mapboxsdk.Location.LocationComponentOptions options)
		{
			const string __id = "applyStyle.(Lcom/mapbox/mapboxsdk/location/LocationComponentOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='cancelTiltWhileTrackingAnimation' and count(parameter)=0]"
		[Register ("cancelTiltWhileTrackingAnimation", "()V", "")]
		public unsafe void CancelTiltWhileTrackingAnimation ()
		{
			const string __id = "cancelTiltWhileTrackingAnimation.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='cancelZoomWhileTrackingAnimation' and count(parameter)=0]"
		[Register ("cancelZoomWhileTrackingAnimation", "()V", "")]
		public unsafe void CancelZoomWhileTrackingAnimation ()
		{
			const string __id = "cancelZoomWhileTrackingAnimation.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='forceLocationUpdate' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("forceLocationUpdate", "(Landroid/location/Location;)V", "")]
		public unsafe void ForceLocationUpdate (global::Android.Locations.Location location)
		{
			const string __id = "forceLocationUpdate.(Landroid/location/Location;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((location == null) ? IntPtr.Zero : ((global::Java.Lang.Object) location).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		public unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='onFinishLoadingStyle' and count(parameter)=0]"
		[Register ("onFinishLoadingStyle", "()V", "")]
		public unsafe void OnFinishLoadingStyle ()
		{
			const string __id = "onFinishLoadingStyle.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "")]
		public unsafe void OnStart ()
		{
			const string __id = "onStart.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='onStartLoadingMap' and count(parameter)=0]"
		[Register ("onStartLoadingMap", "()V", "")]
		public unsafe void OnStartLoadingMap ()
		{
			const string __id = "onStartLoadingMap.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "")]
		public unsafe void OnStop ()
		{
			const string __id = "onStop.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='removeOnCameraTrackingChangedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnCameraTrackingChangedListener']]"
		[Register ("removeOnCameraTrackingChangedListener", "(Lcom/mapbox/mapboxsdk/location/OnCameraTrackingChangedListener;)V", "")]
		public unsafe void RemoveOnCameraTrackingChangedListener (global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener listener)
		{
			const string __id = "removeOnCameraTrackingChangedListener.(Lcom/mapbox/mapboxsdk/location/OnCameraTrackingChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='removeOnLocationClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnLocationClickListener']]"
		[Register ("removeOnLocationClickListener", "(Lcom/mapbox/mapboxsdk/location/OnLocationClickListener;)V", "")]
		public unsafe void RemoveOnLocationClickListener (global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListener listener)
		{
			const string __id = "removeOnLocationClickListener.(Lcom/mapbox/mapboxsdk/location/OnLocationClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='removeOnLocationLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnLocationLongClickListener']]"
		[Register ("removeOnLocationLongClickListener", "(Lcom/mapbox/mapboxsdk/location/OnLocationLongClickListener;)V", "")]
		public unsafe void RemoveOnLocationLongClickListener (global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListener listener)
		{
			const string __id = "removeOnLocationLongClickListener.(Lcom/mapbox/mapboxsdk/location/OnLocationLongClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='removeOnLocationStaleListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnLocationStaleListener']]"
		[Register ("removeOnLocationStaleListener", "(Lcom/mapbox/mapboxsdk/location/OnLocationStaleListener;)V", "")]
		public unsafe void RemoveOnLocationStaleListener (global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListener listener)
		{
			const string __id = "removeOnLocationStaleListener.(Lcom/mapbox/mapboxsdk/location/OnLocationStaleListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='removeRenderModeChangedListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.location.OnRenderModeChangedListener']]"
		[Register ("removeRenderModeChangedListener", "(Lcom/mapbox/mapboxsdk/location/OnRenderModeChangedListener;)V", "")]
		public unsafe void RemoveRenderModeChangedListener (global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListener listener)
		{
			const string __id = "removeRenderModeChangedListener.(Lcom/mapbox/mapboxsdk/location/OnRenderModeChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='setCameraMode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.mapbox.mapboxsdk.location.OnLocationCameraTransitionListener']]"
		[Register ("setCameraMode", "(ILcom/mapbox/mapboxsdk/location/OnLocationCameraTransitionListener;)V", "")]
		public unsafe void SetCameraMode ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int cameraMode, global::Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListener transitionListener)
		{
			const string __id = "setCameraMode.(ILcom/mapbox/mapboxsdk/location/OnLocationCameraTransitionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (cameraMode);
				__args [1] = new JniArgumentValue ((transitionListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transitionListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='setCameraMode' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Double'] and parameter[4][@type='java.lang.Double'] and parameter[5][@type='java.lang.Double'] and parameter[6][@type='com.mapbox.mapboxsdk.location.OnLocationCameraTransitionListener']]"
		[Register ("setCameraMode", "(IJLjava/lang/Double;Ljava/lang/Double;Ljava/lang/Double;Lcom/mapbox/mapboxsdk/location/OnLocationCameraTransitionListener;)V", "")]
		public unsafe void SetCameraMode ([global::Android.Runtime.IntDef (Type = "Com.Mapbox.Mapboxsdk.Location.Modes.CameraMode", Fields = new string [] {"None", "NoneCompass", "NoneGps", "Tracking", "TrackingCompass", "TrackingGps", "TrackingGpsNorth"})]int cameraMode, long transitionDuration, global::Java.Lang.Double zoom, global::Java.Lang.Double bearing, global::Java.Lang.Double tilt, global::Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListener transitionListener)
		{
			const string __id = "setCameraMode.(IJLjava/lang/Double;Ljava/lang/Double;Ljava/lang/Double;Lcom/mapbox/mapboxsdk/location/OnLocationCameraTransitionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (cameraMode);
				__args [1] = new JniArgumentValue (transitionDuration);
				__args [2] = new JniArgumentValue ((zoom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) zoom).Handle);
				__args [3] = new JniArgumentValue ((bearing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bearing).Handle);
				__args [4] = new JniArgumentValue ((tilt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tilt).Handle);
				__args [5] = new JniArgumentValue ((transitionListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transitionListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='setMaxAnimationFps' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxAnimationFps", "(I)V", "")]
		public unsafe void SetMaxAnimationFps (int maxAnimationFps)
		{
			const string __id = "setMaxAnimationFps.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxAnimationFps);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='tiltWhileTracking' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("tiltWhileTracking", "(D)V", "")]
		public unsafe void TiltWhileTracking (double tilt)
		{
			const string __id = "tiltWhileTracking.(D)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tilt);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='tiltWhileTracking' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='long']]"
		[Register ("tiltWhileTracking", "(DJ)V", "")]
		public unsafe void TiltWhileTracking (double tilt, long animationDuration)
		{
			const string __id = "tiltWhileTracking.(DJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (tilt);
				__args [1] = new JniArgumentValue (animationDuration);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='tiltWhileTracking' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='long'] and parameter[3][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("tiltWhileTracking", "(DJLcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void TiltWhileTracking (double tilt, long animationDuration, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "tiltWhileTracking.(DJLcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (tilt);
				__args [1] = new JniArgumentValue (animationDuration);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='zoomWhileTracking' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("zoomWhileTracking", "(D)V", "")]
		public unsafe void ZoomWhileTracking (double zoomLevel)
		{
			const string __id = "zoomWhileTracking.(D)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (zoomLevel);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='zoomWhileTracking' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='long']]"
		[Register ("zoomWhileTracking", "(DJ)V", "")]
		public unsafe void ZoomWhileTracking (double zoomLevel, long animationDuration)
		{
			const string __id = "zoomWhileTracking.(DJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (zoomLevel);
				__args [1] = new JniArgumentValue (animationDuration);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.location']/class[@name='LocationComponent']/method[@name='zoomWhileTracking' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='long'] and parameter[3][@type='com.mapbox.mapboxsdk.maps.MapboxMap.CancelableCallback']]"
		[Register ("zoomWhileTracking", "(DJLcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V", "")]
		public unsafe void ZoomWhileTracking (double zoomLevel, long animationDuration, global::Com.Mapbox.Mapboxsdk.Maps.MapboxMap.ICancelableCallback @callback)
		{
			const string __id = "zoomWhileTracking.(DJLcom/mapbox/mapboxsdk/maps/MapboxMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (zoomLevel);
				__args [1] = new JniArgumentValue (animationDuration);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Location.CameraTrackingChangedEventArgs> CameraTrackingChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener, global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor>(
						ref weak_implementor_AddOnCameraTrackingChangedListener,
						__CreateIOnCameraTrackingChangedListenerImplementor,
						AddOnCameraTrackingChangedListener,
						__h => __h.OnCameraTrackingChangedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener, global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor>(
						ref weak_implementor_AddOnCameraTrackingChangedListener,
						global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor.__IsEmpty,
						__v => RemoveOnCameraTrackingChangedListener (__v),
						__h => __h.OnCameraTrackingChangedHandler -= value);
			}
		}

		public event EventHandler CameraTrackingDismissed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener, global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor>(
						ref weak_implementor_AddOnCameraTrackingChangedListener,
						__CreateIOnCameraTrackingChangedListenerImplementor,
						AddOnCameraTrackingChangedListener,
						__h => __h.OnCameraTrackingDismissedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListener, global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor>(
						ref weak_implementor_AddOnCameraTrackingChangedListener,
						global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor.__IsEmpty,
						__v => RemoveOnCameraTrackingChangedListener (__v),
						__h => __h.OnCameraTrackingDismissedHandler -= value);
			}
		}

		WeakReference weak_implementor_AddOnCameraTrackingChangedListener;

		global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor __CreateIOnCameraTrackingChangedListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListener"
		public event EventHandler LocationClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListener, global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerImplementor>(
						ref weak_implementor_AddOnLocationClickListener,
						__CreateIOnLocationClickListenerImplementor,
						AddOnLocationClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListener, global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerImplementor>(
						ref weak_implementor_AddOnLocationClickListener,
						global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerImplementor.__IsEmpty,
						__v => RemoveOnLocationClickListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnLocationClickListener;

		global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerImplementor __CreateIOnLocationClickListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListener"
		public event EventHandler LocationLongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListener, global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerImplementor>(
						ref weak_implementor_AddOnLocationLongClickListener,
						__CreateIOnLocationLongClickListenerImplementor,
						AddOnLocationLongClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListener, global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerImplementor>(
						ref weak_implementor_AddOnLocationLongClickListener,
						global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerImplementor.__IsEmpty,
						__v => RemoveOnLocationLongClickListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnLocationLongClickListener;

		global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerImplementor __CreateIOnLocationLongClickListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Location.LocationStaleEventArgs> LocationStale {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListener, global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerImplementor>(
						ref weak_implementor_AddOnLocationStaleListener,
						__CreateIOnLocationStaleListenerImplementor,
						AddOnLocationStaleListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListener, global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerImplementor>(
						ref weak_implementor_AddOnLocationStaleListener,
						global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerImplementor.__IsEmpty,
						__v => RemoveOnLocationStaleListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnLocationStaleListener;

		global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerImplementor __CreateIOnLocationStaleListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListener"
		public event EventHandler<global::Com.Mapbox.Mapboxsdk.Location.RenderModeChangedEventArgs> RenderModeChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListener, global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerImplementor>(
						ref weak_implementor_AddOnRenderModeChangedListener,
						__CreateIOnRenderModeChangedListenerImplementor,
						AddOnRenderModeChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListener, global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerImplementor>(
						ref weak_implementor_AddOnRenderModeChangedListener,
						global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListener.AddOnRenderModeChangedListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnRenderModeChangedListener;

		global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerImplementor __CreateIOnRenderModeChangedListenerImplementor ()
		{
			return new global::Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerImplementor (this);
		}
#endregion
	}
}
