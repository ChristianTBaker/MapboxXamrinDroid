package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnCameraMoveStartedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveStartedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraMoveStarted:(I)V:GetOnCameraMoveStarted_IHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraMoveStartedListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCameraMoveStartedListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnCameraMoveStartedListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnCameraMoveStartedListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnCameraMoveStartedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCameraMoveStartedListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onCameraMoveStarted (int p0)
	{
		n_onCameraMoveStarted (p0);
	}

	private native void n_onCameraMoveStarted (int p0);

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
