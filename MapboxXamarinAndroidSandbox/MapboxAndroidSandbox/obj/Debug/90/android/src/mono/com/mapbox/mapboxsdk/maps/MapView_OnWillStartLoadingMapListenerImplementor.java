package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnWillStartLoadingMapListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnWillStartLoadingMapListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onWillStartLoadingMap:()V:GetOnWillStartLoadingMapHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnWillStartLoadingMapListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnWillStartLoadingMapListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnWillStartLoadingMapListenerImplementor.class, __md_methods);
	}


	public MapView_OnWillStartLoadingMapListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnWillStartLoadingMapListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnWillStartLoadingMapListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onWillStartLoadingMap ()
	{
		n_onWillStartLoadingMap ();
	}

	private native void n_onWillStartLoadingMap ();

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
