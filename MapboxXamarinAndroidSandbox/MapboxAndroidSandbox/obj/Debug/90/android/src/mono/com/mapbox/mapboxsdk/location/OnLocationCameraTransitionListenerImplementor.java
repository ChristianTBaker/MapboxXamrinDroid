package mono.com.mapbox.mapboxsdk.location;


public class OnLocationCameraTransitionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.location.OnLocationCameraTransitionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLocationCameraTransitionCanceled:(I)V:GetOnLocationCameraTransitionCanceled_IHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"n_onLocationCameraTransitionFinished:(I)V:GetOnLocationCameraTransitionFinished_IHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListenerImplementor, Mapbox-SDK-8.4.0", OnLocationCameraTransitionListenerImplementor.class, __md_methods);
	}


	public OnLocationCameraTransitionListenerImplementor ()
	{
		super ();
		if (getClass () == OnLocationCameraTransitionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Location.IOnLocationCameraTransitionListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onLocationCameraTransitionCanceled (int p0)
	{
		n_onLocationCameraTransitionCanceled (p0);
	}

	private native void n_onLocationCameraTransitionCanceled (int p0);


	public void onLocationCameraTransitionFinished (int p0)
	{
		n_onLocationCameraTransitionFinished (p0);
	}

	private native void n_onLocationCameraTransitionFinished (int p0);

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
