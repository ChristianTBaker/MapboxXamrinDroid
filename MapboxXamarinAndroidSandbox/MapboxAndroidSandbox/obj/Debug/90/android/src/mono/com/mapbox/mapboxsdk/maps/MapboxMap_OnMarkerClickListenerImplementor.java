package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnMarkerClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnMarkerClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMarkerClick:(Lcom/mapbox/mapboxsdk/annotations/Marker;)Z:GetOnMarkerClick_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnMarkerClickListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnMarkerClickListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnMarkerClickListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnMarkerClickListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnMarkerClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnMarkerClickListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public boolean onMarkerClick (com.mapbox.mapboxsdk.annotations.Marker p0)
	{
		return n_onMarkerClick (p0);
	}

	private native boolean n_onMarkerClick (com.mapbox.mapboxsdk.annotations.Marker p0);

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
