package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnInfoWindowCloseListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowCloseListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInfoWindowClose:(Lcom/mapbox/mapboxsdk/annotations/Marker;)V:GetOnInfoWindowClose_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnInfoWindowCloseListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnInfoWindowCloseListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnInfoWindowCloseListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnInfoWindowCloseListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnInfoWindowCloseListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnInfoWindowCloseListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onInfoWindowClose (com.mapbox.mapboxsdk.annotations.Marker p0)
	{
		n_onInfoWindowClose (p0);
	}

	private native void n_onInfoWindowClose (com.mapbox.mapboxsdk.annotations.Marker p0);

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
