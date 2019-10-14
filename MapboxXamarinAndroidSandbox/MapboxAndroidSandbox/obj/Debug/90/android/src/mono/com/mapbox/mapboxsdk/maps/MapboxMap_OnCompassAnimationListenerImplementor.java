package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnCompassAnimationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnCompassAnimationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCompassAnimation:()V:GetOnCompassAnimationHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCompassAnimationListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"n_onCompassAnimationFinished:()V:GetOnCompassAnimationFinishedHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCompassAnimationListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCompassAnimationListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnCompassAnimationListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnCompassAnimationListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnCompassAnimationListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCompassAnimationListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onCompassAnimation ()
	{
		n_onCompassAnimation ();
	}

	private native void n_onCompassAnimation ();


	public void onCompassAnimationFinished ()
	{
		n_onCompassAnimationFinished ();
	}

	private native void n_onCompassAnimationFinished ();

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
