package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnDidFinishLoadingMapListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnDidFinishLoadingMapListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDidFinishLoadingMap:()V:GetOnDidFinishLoadingMapHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishLoadingMapListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFinishLoadingMapListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnDidFinishLoadingMapListenerImplementor.class, __md_methods);
	}


	public MapView_OnDidFinishLoadingMapListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnDidFinishLoadingMapListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFinishLoadingMapListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onDidFinishLoadingMap ()
	{
		n_onDidFinishLoadingMap ();
	}

	private native void n_onDidFinishLoadingMap ();

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
