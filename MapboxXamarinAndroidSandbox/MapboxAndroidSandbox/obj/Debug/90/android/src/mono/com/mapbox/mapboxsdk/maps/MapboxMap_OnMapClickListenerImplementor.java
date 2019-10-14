package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnMapClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnMapClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMapClick:(Lcom/mapbox/mapboxsdk/geometry/LatLng;)Z:GetOnMapClick_Lcom_mapbox_mapboxsdk_geometry_LatLng_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnMapClickListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnMapClickListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnMapClickListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnMapClickListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnMapClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnMapClickListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public boolean onMapClick (com.mapbox.mapboxsdk.geometry.LatLng p0)
	{
		return n_onMapClick (p0);
	}

	private native boolean n_onMapClick (com.mapbox.mapboxsdk.geometry.LatLng p0);

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
