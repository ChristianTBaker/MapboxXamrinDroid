package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnFpsChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnFpsChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFpsChanged:(D)V:GetOnFpsChanged_DHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnFpsChangedListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnFpsChangedListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnFpsChangedListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnFpsChangedListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnFpsChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnFpsChangedListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onFpsChanged (double p0)
	{
		n_onFpsChanged (p0);
	}

	private native void n_onFpsChanged (double p0);

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
