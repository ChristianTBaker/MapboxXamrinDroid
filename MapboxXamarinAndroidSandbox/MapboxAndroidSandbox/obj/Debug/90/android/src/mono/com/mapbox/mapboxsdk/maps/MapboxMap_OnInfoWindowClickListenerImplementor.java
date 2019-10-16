package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnInfoWindowClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInfoWindowClick:(Lcom/mapbox/mapboxsdk/annotations/Marker;)Z:GetOnInfoWindowClick_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnInfoWindowClickListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnInfoWindowClickListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnInfoWindowClickListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnInfoWindowClickListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnInfoWindowClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnInfoWindowClickListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public boolean onInfoWindowClick (com.mapbox.mapboxsdk.annotations.Marker p0)
	{
		return n_onInfoWindowClick (p0);
	}

	private native boolean n_onInfoWindowClick (com.mapbox.mapboxsdk.annotations.Marker p0);

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
