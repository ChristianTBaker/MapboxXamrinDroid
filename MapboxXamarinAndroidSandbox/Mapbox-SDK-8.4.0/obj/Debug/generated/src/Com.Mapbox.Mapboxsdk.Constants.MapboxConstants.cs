using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']"
	[global::Android.Runtime.Register ("com/mapbox/mapboxsdk/constants/MapboxConstants", DoNotGenerateAcw=true)]
	public partial class MapboxConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='ANIMATION_DURATION']"
		[Register ("ANIMATION_DURATION")]
		public const int AnimationDuration = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='ANIMATION_DURATION_FLING_BASE']"
		[Register ("ANIMATION_DURATION_FLING_BASE")]
		public const long AnimationDurationFlingBase = (long) 150;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='ANIMATION_DURATION_SHORT']"
		[Register ("ANIMATION_DURATION_SHORT")]
		public const int AnimationDurationShort = (int) 150;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='DEFAULT_FONT']"
		[Register ("DEFAULT_FONT")]
		public const string DefaultFont = (string) "sans-serif";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='DEFAULT_MANAGE_SKU_TOKEN']"
		[Register ("DEFAULT_MANAGE_SKU_TOKEN")]
		public const bool DefaultManageSkuToken = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='DEFAULT_MEASURE_TILE_DOWNLOAD_ON']"
		[Register ("DEFAULT_MEASURE_TILE_DOWNLOAD_ON")]
		public const bool DefaultMeasureTileDownloadOn = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='DEFAULT_SET_STORAGE_EXTERNAL']"
		[Register ("DEFAULT_SET_STORAGE_EXTERNAL")]
		public const bool DefaultSetStorageExternal = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='FRAG_ARG_MAPBOXMAPOPTIONS']"
		[Register ("FRAG_ARG_MAPBOXMAPOPTIONS")]
		public const string FragArgMapboxmapoptions = (string) "MapboxMapOptions";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='KEY_META_DATA_MANAGE_SKU_TOKEN']"
		[Register ("KEY_META_DATA_MANAGE_SKU_TOKEN")]
		public const string KeyMetaDataManageSkuToken = (string) "com.mapbox.ManageSkuToken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='KEY_META_DATA_MEASURE_TILE_DOWNLOAD_ON']"
		[Register ("KEY_META_DATA_MEASURE_TILE_DOWNLOAD_ON")]
		public const string KeyMetaDataMeasureTileDownloadOn = (string) "com.mapbox.MeasureTileDownloadOn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='KEY_META_DATA_SET_STORAGE_EXTERNAL']"
		[Register ("KEY_META_DATA_SET_STORAGE_EXTERNAL")]
		public const string KeyMetaDataSetStorageExternal = (string) "com.mapbox.SetStorageExternal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='KEY_PREFERENCE_SKU_TOKEN']"
		[Register ("KEY_PREFERENCE_SKU_TOKEN")]
		public const string KeyPreferenceSkuToken = (string) "com.mapbox.mapboxsdk.accounts.skutoken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='LAYER_ID_ANNOTATIONS']"
		[Register ("LAYER_ID_ANNOTATIONS")]
		public const string LayerIdAnnotations = (string) "com.mapbox.annotations.points";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MAPBOX_LOCALE']"
		[Register ("MAPBOX_LOCALE")]
		public static global::Java.Util.Locale MapboxLocale {
			get {
				const string __id = "MAPBOX_LOCALE.Ljava/util/Locale;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MAPBOX_SHARED_PREFERENCES']"
		[Register ("MAPBOX_SHARED_PREFERENCES")]
		public const string MapboxSharedPreferences = (string) "MapboxSharedPreferences";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MAXIMUM_ANGULAR_VELOCITY']"
		[Register ("MAXIMUM_ANGULAR_VELOCITY")]
		public const float MaximumAngularVelocity = (float) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MAXIMUM_DIRECTION']"
		[Register ("MAXIMUM_DIRECTION")]
		public const double MaximumDirection = (double) 360;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MAXIMUM_SCALE_FACTOR_CLAMP']"
		[Register ("MAXIMUM_SCALE_FACTOR_CLAMP")]
		[Obsolete ("deprecated")]
		public const float MaximumScaleFactorClamp = (float) 0.15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MAXIMUM_TILT']"
		[Register ("MAXIMUM_TILT")]
		public const double MaximumTilt = (double) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MAXIMUM_ZOOM']"
		[Register ("MAXIMUM_ZOOM")]
		public const float MaximumZoom = (float) 25.5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MAX_ABSOLUTE_SCALE_VELOCITY_CHANGE']"
		[Register ("MAX_ABSOLUTE_SCALE_VELOCITY_CHANGE")]
		public const double MaxAbsoluteScaleVelocityChange = (double) 2.5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MINIMUM_ANGULAR_VELOCITY']"
		[Register ("MINIMUM_ANGULAR_VELOCITY")]
		[Obsolete ("deprecated")]
		public const float MinimumAngularVelocity = (float) 1.5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MINIMUM_DIRECTION']"
		[Register ("MINIMUM_DIRECTION")]
		public const double MinimumDirection = (double) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MINIMUM_SCALE_FACTOR_CLAMP']"
		[Register ("MINIMUM_SCALE_FACTOR_CLAMP")]
		[Obsolete ("deprecated")]
		public const float MinimumScaleFactorClamp = (float) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MINIMUM_TILT']"
		[Register ("MINIMUM_TILT")]
		public const double MinimumTilt = (double) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='MINIMUM_ZOOM']"
		[Register ("MINIMUM_ZOOM")]
		public const float MinimumZoom = (float) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='QUICK_ZOOM_MAX_ZOOM_CHANGE']"
		[Register ("QUICK_ZOOM_MAX_ZOOM_CHANGE")]
		public const double QuickZoomMaxZoomChange = (double) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='ROTATE_VELOCITY_RATIO_THRESHOLD']"
		[Register ("ROTATE_VELOCITY_RATIO_THRESHOLD")]
		public const double RotateVelocityRatioThreshold = (double) 0.00022000000000000004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='ROTATION_THRESHOLD_INCREASE_WHEN_SCALING']"
		[Register ("ROTATION_THRESHOLD_INCREASE_WHEN_SCALING")]
		[Obsolete ("deprecated")]
		public const float RotationThresholdIncreaseWhenScaling = (float) 25;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='SCALE_VELOCITY_ANIMATION_DURATION_MULTIPLIER']"
		[Register ("SCALE_VELOCITY_ANIMATION_DURATION_MULTIPLIER")]
		public const double ScaleVelocityAnimationDurationMultiplier = (double) 150;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='SCALE_VELOCITY_RATIO_THRESHOLD']"
		[Register ("SCALE_VELOCITY_RATIO_THRESHOLD")]
		public const double ScaleVelocityRatioThreshold = (double) 0.004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='SCHEDULED_ANIMATION_TIMEOUT']"
		[Register ("SCHEDULED_ANIMATION_TIMEOUT")]
		public const long ScheduledAnimationTimeout = (long) 150;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='SHOVE_PIXEL_CHANGE_FACTOR']"
		[Register ("SHOVE_PIXEL_CHANGE_FACTOR")]
		public const float ShovePixelChangeFactor = (float) 0.1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ATTRIBUTION_ENABLED']"
		[Register ("STATE_ATTRIBUTION_ENABLED")]
		public const string StateAttributionEnabled = (string) "mapbox_atrrEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ATTRIBUTION_GRAVITY']"
		[Register ("STATE_ATTRIBUTION_GRAVITY")]
		public const string StateAttributionGravity = (string) "mapbox_attrGravity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ATTRIBUTION_MARGIN_BOTTOM']"
		[Register ("STATE_ATTRIBUTION_MARGIN_BOTTOM")]
		public const string StateAttributionMarginBottom = (string) "mapbox_atrrMarginBottom";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ATTRIBUTION_MARGIN_LEFT']"
		[Register ("STATE_ATTRIBUTION_MARGIN_LEFT")]
		public const string StateAttributionMarginLeft = (string) "mapbox_attrMarginLeft";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ATTRIBUTION_MARGIN_RIGHT']"
		[Register ("STATE_ATTRIBUTION_MARGIN_RIGHT")]
		public const string StateAttributionMarginRight = (string) "mapbox_attrMarginRight";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ATTRIBUTION_MARGIN_TOP']"
		[Register ("STATE_ATTRIBUTION_MARGIN_TOP")]
		public const string StateAttributionMarginTop = (string) "mapbox_attrMarginTop";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_CAMERA_POSITION']"
		[Register ("STATE_CAMERA_POSITION")]
		public const string StateCameraPosition = (string) "mapbox_cameraPosition";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_COMPASS_ENABLED']"
		[Register ("STATE_COMPASS_ENABLED")]
		public const string StateCompassEnabled = (string) "mapbox_compassEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_COMPASS_FADE_WHEN_FACING_NORTH']"
		[Register ("STATE_COMPASS_FADE_WHEN_FACING_NORTH")]
		public const string StateCompassFadeWhenFacingNorth = (string) "mapbox_compassFade";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_COMPASS_GRAVITY']"
		[Register ("STATE_COMPASS_GRAVITY")]
		public const string StateCompassGravity = (string) "mapbox_compassGravity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_COMPASS_IMAGE_BITMAP']"
		[Register ("STATE_COMPASS_IMAGE_BITMAP")]
		public const string StateCompassImageBitmap = (string) "mapbox_compassImage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_COMPASS_MARGIN_BOTTOM']"
		[Register ("STATE_COMPASS_MARGIN_BOTTOM")]
		public const string StateCompassMarginBottom = (string) "mapbox_compassMarginBottom";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_COMPASS_MARGIN_LEFT']"
		[Register ("STATE_COMPASS_MARGIN_LEFT")]
		public const string StateCompassMarginLeft = (string) "mapbox_compassMarginLeft";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_COMPASS_MARGIN_RIGHT']"
		[Register ("STATE_COMPASS_MARGIN_RIGHT")]
		public const string StateCompassMarginRight = (string) "mapbox_compassMarginRight";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_COMPASS_MARGIN_TOP']"
		[Register ("STATE_COMPASS_MARGIN_TOP")]
		public const string StateCompassMarginTop = (string) "mapbox_compassMarginTop";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_DEBUG_ACTIVE']"
		[Register ("STATE_DEBUG_ACTIVE")]
		public const string StateDebugActive = (string) "mapbox_debugActive";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_DESELECT_MARKER_ON_TAP']"
		[Register ("STATE_DESELECT_MARKER_ON_TAP")]
		public const string StateDeselectMarkerOnTap = (string) "mapbox_deselectMarkerOnTap";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_DISABLE_ROTATE_WHEN_SCALING']"
		[Register ("STATE_DISABLE_ROTATE_WHEN_SCALING")]
		public const string StateDisableRotateWhenScaling = (string) "mapbox_disableRotateWhenScaling";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_DOUBLE_TAP_ENABLED']"
		[Register ("STATE_DOUBLE_TAP_ENABLED")]
		public const string StateDoubleTapEnabled = (string) "mapbox_doubleTapEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_FLING_ANIMATION_ENABLED']"
		[Register ("STATE_FLING_ANIMATION_ENABLED")]
		public const string StateFlingAnimationEnabled = (string) "mapbox_flingAnimationEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_HAS_SAVED_STATE']"
		[Register ("STATE_HAS_SAVED_STATE")]
		public const string StateHasSavedState = (string) "mapbox_savedState";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_INCREASE_ROTATE_THRESHOLD']"
		[Register ("STATE_INCREASE_ROTATE_THRESHOLD")]
		public const string StateIncreaseRotateThreshold = (string) "mapbox_increaseRotateThreshold";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_INCREASE_SCALE_THRESHOLD']"
		[Register ("STATE_INCREASE_SCALE_THRESHOLD")]
		public const string StateIncreaseScaleThreshold = (string) "mapbox_increaseScaleThreshold";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_LOGO_ENABLED']"
		[Register ("STATE_LOGO_ENABLED")]
		public const string StateLogoEnabled = (string) "mapbox_logoEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_LOGO_GRAVITY']"
		[Register ("STATE_LOGO_GRAVITY")]
		public const string StateLogoGravity = (string) "mapbox_logoGravity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_LOGO_MARGIN_BOTTOM']"
		[Register ("STATE_LOGO_MARGIN_BOTTOM")]
		public const string StateLogoMarginBottom = (string) "mapbox_logoMarginBottom";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_LOGO_MARGIN_LEFT']"
		[Register ("STATE_LOGO_MARGIN_LEFT")]
		public const string StateLogoMarginLeft = (string) "mapbox_logoMarginLeft";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_LOGO_MARGIN_RIGHT']"
		[Register ("STATE_LOGO_MARGIN_RIGHT")]
		public const string StateLogoMarginRight = (string) "mapbox_logoMarginRight";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_LOGO_MARGIN_TOP']"
		[Register ("STATE_LOGO_MARGIN_TOP")]
		public const string StateLogoMarginTop = (string) "mapbox_logoMarginTop";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_QUICK_ZOOM_ENABLED']"
		[Register ("STATE_QUICK_ZOOM_ENABLED")]
		public const string StateQuickZoomEnabled = (string) "mapbox_quickZoom";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ROTATE_ANIMATION_ENABLED']"
		[Register ("STATE_ROTATE_ANIMATION_ENABLED")]
		public const string StateRotateAnimationEnabled = (string) "mapbox_rotateAnimationEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ROTATE_ENABLED']"
		[Register ("STATE_ROTATE_ENABLED")]
		public const string StateRotateEnabled = (string) "mapbox_rotateEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_SCALE_ANIMATION_ENABLED']"
		[Register ("STATE_SCALE_ANIMATION_ENABLED")]
		public const string StateScaleAnimationEnabled = (string) "mapbox_scaleAnimationEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_SCROLL_ENABLED']"
		[Register ("STATE_SCROLL_ENABLED")]
		public const string StateScrollEnabled = (string) "mapbox_scrollEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_TILT_ENABLED']"
		[Register ("STATE_TILT_ENABLED")]
		public const string StateTiltEnabled = (string) "mapbox_tiltEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_USER_FOCAL_POINT']"
		[Register ("STATE_USER_FOCAL_POINT")]
		public const string StateUserFocalPoint = (string) "mapbox_userFocalPoint";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ZOOM_ENABLED']"
		[Register ("STATE_ZOOM_ENABLED")]
		public const string StateZoomEnabled = (string) "mapbox_zoomEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='STATE_ZOOM_RATE']"
		[Register ("STATE_ZOOM_RATE")]
		public const string StateZoomRate = (string) "mapbox_zoomRate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='UNMEASURED']"
		[Register ("UNMEASURED")]
		public const float Unmeasured = (float) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='VELOCITY_THRESHOLD_IGNORE_FLING']"
		[Register ("VELOCITY_THRESHOLD_IGNORE_FLING")]
		public const long VelocityThresholdIgnoreFling = (long) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/field[@name='ZOOM_RATE']"
		[Register ("ZOOM_RATE")]
		public const float ZoomRate = (float) 0.65;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mapbox/mapboxsdk/constants/MapboxConstants", typeof (MapboxConstants));
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

		protected MapboxConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.mapboxsdk.constants']/class[@name='MapboxConstants']/constructor[@name='MapboxConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapboxConstants ()
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
}
