using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Maps {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/maps/UiSettings", DoNotGenerateAcw=true)]
	public sealed partial class UiSettings : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/maps/UiSettings", typeof (UiSettings));
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

		internal UiSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager AttributionDialogManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getAttributionDialogManager' and count(parameter)=0]"
			[Register ("getAttributionDialogManager", "()Lcom/mapbox/mapboxsdk/maps/AttributionDialogManager;", "GetGetAttributionDialogManagerHandler")]
			get {
				const string __id = "getAttributionDialogManager.()Lcom/mapbox/mapboxsdk/maps/AttributionDialogManager;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Maps.AttributionDialogManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setAttributionDialogManager' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.maps.AttributionDialogManager']]"
			[Register ("setAttributionDialogManager", "(Lcom/mapbox/mapboxsdk/maps/AttributionDialogManager;)V", "GetSetAttributionDialogManager_Lcom_mapbox_mapboxsdk_maps_AttributionDialogManager_Handler")]
			set {
				const string __id = "setAttributionDialogManager.(Lcom/mapbox/mapboxsdk/maps/AttributionDialogManager;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool AttributionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isAttributionEnabled' and count(parameter)=0]"
			[Register ("isAttributionEnabled", "()Z", "GetIsAttributionEnabledHandler")]
			get {
				const string __id = "isAttributionEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setAttributionEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAttributionEnabled", "(Z)V", "GetSetAttributionEnabled_ZHandler")]
			set {
				const string __id = "setAttributionEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int AttributionGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getAttributionGravity' and count(parameter)=0]"
			[Register ("getAttributionGravity", "()I", "GetGetAttributionGravityHandler")]
			get {
				const string __id = "getAttributionGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setAttributionGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAttributionGravity", "(I)V", "GetSetAttributionGravity_IHandler")]
			set {
				const string __id = "setAttributionGravity.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int AttributionMarginBottom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getAttributionMarginBottom' and count(parameter)=0]"
			[Register ("getAttributionMarginBottom", "()I", "GetGetAttributionMarginBottomHandler")]
			get {
				const string __id = "getAttributionMarginBottom.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int AttributionMarginLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getAttributionMarginLeft' and count(parameter)=0]"
			[Register ("getAttributionMarginLeft", "()I", "GetGetAttributionMarginLeftHandler")]
			get {
				const string __id = "getAttributionMarginLeft.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int AttributionMarginRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getAttributionMarginRight' and count(parameter)=0]"
			[Register ("getAttributionMarginRight", "()I", "GetGetAttributionMarginRightHandler")]
			get {
				const string __id = "getAttributionMarginRight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int AttributionMarginTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getAttributionMarginTop' and count(parameter)=0]"
			[Register ("getAttributionMarginTop", "()I", "GetGetAttributionMarginTopHandler")]
			get {
				const string __id = "getAttributionMarginTop.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool CompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isCompassEnabled' and count(parameter)=0]"
			[Register ("isCompassEnabled", "()Z", "GetIsCompassEnabledHandler")]
			get {
				const string __id = "isCompassEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setCompassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCompassEnabled", "(Z)V", "GetSetCompassEnabled_ZHandler")]
			set {
				const string __id = "setCompassEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int CompassGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getCompassGravity' and count(parameter)=0]"
			[Register ("getCompassGravity", "()I", "GetGetCompassGravityHandler")]
			get {
				const string __id = "getCompassGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setCompassGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCompassGravity", "(I)V", "GetSetCompassGravity_IHandler")]
			set {
				const string __id = "setCompassGravity.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Android.Graphics.Drawables.Drawable CompassImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getCompassImage' and count(parameter)=0]"
			[Register ("getCompassImage", "()Landroid/graphics/drawable/Drawable;", "GetGetCompassImageHandler")]
			get {
				const string __id = "getCompassImage.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setCompassImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setCompassImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetCompassImage_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setCompassImage.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int CompassMarginBottom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getCompassMarginBottom' and count(parameter)=0]"
			[Register ("getCompassMarginBottom", "()I", "GetGetCompassMarginBottomHandler")]
			get {
				const string __id = "getCompassMarginBottom.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int CompassMarginLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getCompassMarginLeft' and count(parameter)=0]"
			[Register ("getCompassMarginLeft", "()I", "GetGetCompassMarginLeftHandler")]
			get {
				const string __id = "getCompassMarginLeft.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int CompassMarginRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getCompassMarginRight' and count(parameter)=0]"
			[Register ("getCompassMarginRight", "()I", "GetGetCompassMarginRightHandler")]
			get {
				const string __id = "getCompassMarginRight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int CompassMarginTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getCompassMarginTop' and count(parameter)=0]"
			[Register ("getCompassMarginTop", "()I", "GetGetCompassMarginTopHandler")]
			get {
				const string __id = "getCompassMarginTop.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool DeselectMarkersOnTap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isDeselectMarkersOnTap' and count(parameter)=0]"
			[Register ("isDeselectMarkersOnTap", "()Z", "GetIsDeselectMarkersOnTapHandler")]
			get {
				const string __id = "isDeselectMarkersOnTap.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setDeselectMarkersOnTap' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDeselectMarkersOnTap", "(Z)V", "GetSetDeselectMarkersOnTap_ZHandler")]
			set {
				const string __id = "setDeselectMarkersOnTap.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool DisableRotateWhenScaling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isDisableRotateWhenScaling' and count(parameter)=0]"
			[Register ("isDisableRotateWhenScaling", "()Z", "GetIsDisableRotateWhenScalingHandler")]
			get {
				const string __id = "isDisableRotateWhenScaling.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setDisableRotateWhenScaling' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDisableRotateWhenScaling", "(Z)V", "GetSetDisableRotateWhenScaling_ZHandler")]
			set {
				const string __id = "setDisableRotateWhenScaling.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool DoubleTapGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isDoubleTapGesturesEnabled' and count(parameter)=0]"
			[Register ("isDoubleTapGesturesEnabled", "()Z", "GetIsDoubleTapGesturesEnabledHandler")]
			get {
				const string __id = "isDoubleTapGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setDoubleTapGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDoubleTapGesturesEnabled", "(Z)V", "GetSetDoubleTapGesturesEnabled_ZHandler")]
			set {
				const string __id = "setDoubleTapGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool FlingVelocityAnimationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isFlingVelocityAnimationEnabled' and count(parameter)=0]"
			[Register ("isFlingVelocityAnimationEnabled", "()Z", "GetIsFlingVelocityAnimationEnabledHandler")]
			get {
				const string __id = "isFlingVelocityAnimationEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setFlingVelocityAnimationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlingVelocityAnimationEnabled", "(Z)V", "GetSetFlingVelocityAnimationEnabled_ZHandler")]
			set {
				const string __id = "setFlingVelocityAnimationEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Android.Graphics.PointF FocalPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getFocalPoint' and count(parameter)=0]"
			[Register ("getFocalPoint", "()Landroid/graphics/PointF;", "GetGetFocalPointHandler")]
			get {
				const string __id = "getFocalPoint.()Landroid/graphics/PointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setFocalPoint' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
			[Register ("setFocalPoint", "(Landroid/graphics/PointF;)V", "GetSetFocalPoint_Landroid_graphics_PointF_Handler")]
			set {
				const string __id = "setFocalPoint.(Landroid/graphics/PointF;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe bool IncreaseRotateThresholdWhenScaling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isIncreaseRotateThresholdWhenScaling' and count(parameter)=0]"
			[Register ("isIncreaseRotateThresholdWhenScaling", "()Z", "GetIsIncreaseRotateThresholdWhenScalingHandler")]
			get {
				const string __id = "isIncreaseRotateThresholdWhenScaling.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setIncreaseRotateThresholdWhenScaling' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIncreaseRotateThresholdWhenScaling", "(Z)V", "GetSetIncreaseRotateThresholdWhenScaling_ZHandler")]
			set {
				const string __id = "setIncreaseRotateThresholdWhenScaling.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool IncreaseScaleThresholdWhenRotating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isIncreaseScaleThresholdWhenRotating' and count(parameter)=0]"
			[Register ("isIncreaseScaleThresholdWhenRotating", "()Z", "GetIsIncreaseScaleThresholdWhenRotatingHandler")]
			get {
				const string __id = "isIncreaseScaleThresholdWhenRotating.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setIncreaseScaleThresholdWhenRotating' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIncreaseScaleThresholdWhenRotating", "(Z)V", "GetSetIncreaseScaleThresholdWhenRotating_ZHandler")]
			set {
				const string __id = "setIncreaseScaleThresholdWhenRotating.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool IsCompassFadeWhenFacingNorth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isCompassFadeWhenFacingNorth' and count(parameter)=0]"
			[Register ("isCompassFadeWhenFacingNorth", "()Z", "GetIsCompassFadeWhenFacingNorthHandler")]
			get {
				const string __id = "isCompassFadeWhenFacingNorth.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool LogoEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isLogoEnabled' and count(parameter)=0]"
			[Register ("isLogoEnabled", "()Z", "GetIsLogoEnabledHandler")]
			get {
				const string __id = "isLogoEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setLogoEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLogoEnabled", "(Z)V", "GetSetLogoEnabled_ZHandler")]
			set {
				const string __id = "setLogoEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int LogoGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getLogoGravity' and count(parameter)=0]"
			[Register ("getLogoGravity", "()I", "GetGetLogoGravityHandler")]
			get {
				const string __id = "getLogoGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setLogoGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLogoGravity", "(I)V", "GetSetLogoGravity_IHandler")]
			set {
				const string __id = "setLogoGravity.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int LogoMarginBottom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getLogoMarginBottom' and count(parameter)=0]"
			[Register ("getLogoMarginBottom", "()I", "GetGetLogoMarginBottomHandler")]
			get {
				const string __id = "getLogoMarginBottom.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int LogoMarginLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getLogoMarginLeft' and count(parameter)=0]"
			[Register ("getLogoMarginLeft", "()I", "GetGetLogoMarginLeftHandler")]
			get {
				const string __id = "getLogoMarginLeft.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int LogoMarginRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getLogoMarginRight' and count(parameter)=0]"
			[Register ("getLogoMarginRight", "()I", "GetGetLogoMarginRightHandler")]
			get {
				const string __id = "getLogoMarginRight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int LogoMarginTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getLogoMarginTop' and count(parameter)=0]"
			[Register ("getLogoMarginTop", "()I", "GetGetLogoMarginTopHandler")]
			get {
				const string __id = "getLogoMarginTop.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool QuickZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isQuickZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("isQuickZoomGesturesEnabled", "()Z", "GetIsQuickZoomGesturesEnabledHandler")]
			get {
				const string __id = "isQuickZoomGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setQuickZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setQuickZoomGesturesEnabled", "(Z)V", "GetSetQuickZoomGesturesEnabled_ZHandler")]
			set {
				const string __id = "setQuickZoomGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool RotateGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isRotateGesturesEnabled' and count(parameter)=0]"
			[Register ("isRotateGesturesEnabled", "()Z", "GetIsRotateGesturesEnabledHandler")]
			get {
				const string __id = "isRotateGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setRotateGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRotateGesturesEnabled", "(Z)V", "GetSetRotateGesturesEnabled_ZHandler")]
			set {
				const string __id = "setRotateGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool RotateVelocityAnimationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isRotateVelocityAnimationEnabled' and count(parameter)=0]"
			[Register ("isRotateVelocityAnimationEnabled", "()Z", "GetIsRotateVelocityAnimationEnabledHandler")]
			get {
				const string __id = "isRotateVelocityAnimationEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setRotateVelocityAnimationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRotateVelocityAnimationEnabled", "(Z)V", "GetSetRotateVelocityAnimationEnabled_ZHandler")]
			set {
				const string __id = "setRotateVelocityAnimationEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ScaleVelocityAnimationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isScaleVelocityAnimationEnabled' and count(parameter)=0]"
			[Register ("isScaleVelocityAnimationEnabled", "()Z", "GetIsScaleVelocityAnimationEnabledHandler")]
			get {
				const string __id = "isScaleVelocityAnimationEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setScaleVelocityAnimationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScaleVelocityAnimationEnabled", "(Z)V", "GetSetScaleVelocityAnimationEnabled_ZHandler")]
			set {
				const string __id = "setScaleVelocityAnimationEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("isScrollGesturesEnabled", "()Z", "GetIsScrollGesturesEnabledHandler")]
			get {
				const string __id = "isScrollGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScrollGesturesEnabled", "(Z)V", "GetSetScrollGesturesEnabled_ZHandler")]
			set {
				const string __id = "setScrollGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool TiltGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isTiltGesturesEnabled' and count(parameter)=0]"
			[Register ("isTiltGesturesEnabled", "()Z", "GetIsTiltGesturesEnabledHandler")]
			get {
				const string __id = "isTiltGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setTiltGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTiltGesturesEnabled", "(Z)V", "GetSetTiltGesturesEnabled_ZHandler")]
			set {
				const string __id = "setTiltGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool ZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='isZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("isZoomGesturesEnabled", "()Z", "GetIsZoomGesturesEnabledHandler")]
			get {
				const string __id = "isZoomGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomGesturesEnabled", "(Z)V", "GetSetZoomGesturesEnabled_ZHandler")]
			set {
				const string __id = "setZoomGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float ZoomRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='getZoomRate' and count(parameter)=0]"
			[Register ("getZoomRate", "()F", "GetGetZoomRateHandler")]
			get {
				const string __id = "getZoomRate.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setZoomRate' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZoomRate", "(F)V", "GetSetZoomRate_FHandler")]
			set {
				const string __id = "setZoomRate.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='areAllGesturesEnabled' and count(parameter)=0]"
		[Register ("areAllGesturesEnabled", "()Z", "")]
		public unsafe bool AreAllGesturesEnabled ()
		{
			const string __id = "areAllGesturesEnabled.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "")]
		public unsafe void Invalidate ()
		{
			const string __id = "invalidate.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setAllGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllGesturesEnabled", "(Z)V", "")]
		public unsafe void SetAllGesturesEnabled (bool enabled)
		{
			const string __id = "setAllGesturesEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setAllVelocityAnimationsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllVelocityAnimationsEnabled", "(Z)V", "")]
		public unsafe void SetAllVelocityAnimationsEnabled (bool allVelocityAnimationsEnabled)
		{
			const string __id = "setAllVelocityAnimationsEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (allVelocityAnimationsEnabled);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setAttributionMargins' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setAttributionMargins", "(IIII)V", "")]
		public unsafe void SetAttributionMargins (int left, int top, int right, int bottom)
		{
			const string __id = "setAttributionMargins.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setAttributionTintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAttributionTintColor", "(I)V", "")]
		public unsafe void SetAttributionTintColor (int tintColor)
		{
			const string __id = "setAttributionTintColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tintColor);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setCompassFadeFacingNorth' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCompassFadeFacingNorth", "(Z)V", "")]
		public unsafe void SetCompassFadeFacingNorth (bool compassFadeFacingNorth)
		{
			const string __id = "setCompassFadeFacingNorth.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (compassFadeFacingNorth);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setCompassMargins' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setCompassMargins", "(IIII)V", "")]
		public unsafe void SetCompassMargins (int left, int top, int right, int bottom)
		{
			const string __id = "setCompassMargins.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.maps']/class[@name='UiSettings']/method[@name='setLogoMargins' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setLogoMargins", "(IIII)V", "")]
		public unsafe void SetLogoMargins (int left, int top, int right, int bottom)
		{
			const string __id = "setLogoMargins.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
