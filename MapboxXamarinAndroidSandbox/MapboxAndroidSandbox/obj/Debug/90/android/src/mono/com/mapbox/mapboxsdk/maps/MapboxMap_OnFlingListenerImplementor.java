package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnFlingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnFlingListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFling:()V:GetOnFlingHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnFlingListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnFlingListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnFlingListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnFlingListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnFlingListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnFlingListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onFling ()
	{
		n_onFling ();
	}

	private native void n_onFling ();

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
