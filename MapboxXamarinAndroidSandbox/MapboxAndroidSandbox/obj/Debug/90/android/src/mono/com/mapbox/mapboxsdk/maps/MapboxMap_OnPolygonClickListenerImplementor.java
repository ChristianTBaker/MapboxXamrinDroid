package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnPolygonClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnPolygonClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPolygonClick:(Lcom/mapbox/mapboxsdk/annotations/Polygon;)V:GetOnPolygonClick_Lcom_mapbox_mapboxsdk_annotations_Polygon_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnPolygonClickListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnPolygonClickListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnPolygonClickListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnPolygonClickListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnPolygonClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnPolygonClickListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onPolygonClick (com.mapbox.mapboxsdk.annotations.Polygon p0)
	{
		n_onPolygonClick (p0);
	}

	private native void n_onPolygonClick (com.mapbox.mapboxsdk.annotations.Polygon p0);

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
