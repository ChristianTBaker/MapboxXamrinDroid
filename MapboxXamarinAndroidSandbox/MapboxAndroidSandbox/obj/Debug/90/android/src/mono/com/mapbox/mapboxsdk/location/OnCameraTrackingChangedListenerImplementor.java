package mono.com.mapbox.mapboxsdk.location;


public class OnCameraTrackingChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.location.OnCameraTrackingChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraTrackingChanged:(I)V:GetOnCameraTrackingChanged_IHandler:Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"n_onCameraTrackingDismissed:()V:GetOnCameraTrackingDismissedHandler:Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor, Mapbox-SDK-8.4.0", OnCameraTrackingChangedListenerImplementor.class, __md_methods);
	}


	public OnCameraTrackingChangedListenerImplementor ()
	{
		super ();
		if (getClass () == OnCameraTrackingChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Location.IOnCameraTrackingChangedListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onCameraTrackingChanged (int p0)
	{
		n_onCameraTrackingChanged (p0);
	}

	private native void n_onCameraTrackingChanged (int p0);


	public void onCameraTrackingDismissed ()
	{
		n_onCameraTrackingDismissed ();
	}

	private native void n_onCameraTrackingDismissed ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
