package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnDidFinishRenderingMapListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingMapListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDidFinishRenderingMap:(Z)V:GetOnDidFinishRenderingMap_ZHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishRenderingMapListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFinishRenderingMapListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnDidFinishRenderingMapListenerImplementor.class, __md_methods);
	}


	public MapView_OnDidFinishRenderingMapListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnDidFinishRenderingMapListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFinishRenderingMapListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onDidFinishRenderingMap (boolean p0)
	{
		n_onDidFinishRenderingMap (p0);
	}

	private native void n_onDidFinishRenderingMap (boolean p0);

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
