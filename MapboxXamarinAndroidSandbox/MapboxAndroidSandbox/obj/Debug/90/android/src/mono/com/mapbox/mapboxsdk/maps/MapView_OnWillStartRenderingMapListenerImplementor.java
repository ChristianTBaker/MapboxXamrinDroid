package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnWillStartRenderingMapListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnWillStartRenderingMapListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onWillStartRenderingMap:()V:GetOnWillStartRenderingMapHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnWillStartRenderingMapListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnWillStartRenderingMapListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnWillStartRenderingMapListenerImplementor.class, __md_methods);
	}


	public MapView_OnWillStartRenderingMapListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnWillStartRenderingMapListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnWillStartRenderingMapListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onWillStartRenderingMap ()
	{
		n_onWillStartRenderingMap ();
	}

	private native void n_onWillStartRenderingMap ();

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
