package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnMapLongClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnMapLongClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMapLongClick:(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Z:GetOnMapLongClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnMapLongClickListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnMapLongClickListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnMapLongClickListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnMapLongClickListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnMapLongClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnMapLongClickListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public boolean onMapLongClick (com.mapbox.mapboxsdk.geometry.LatLng p0)
	{
		return n_onMapLongClick (p0);
	}

	private native boolean n_onMapLongClick (com.mapbox.mapboxsdk.geometry.LatLng p0);

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
