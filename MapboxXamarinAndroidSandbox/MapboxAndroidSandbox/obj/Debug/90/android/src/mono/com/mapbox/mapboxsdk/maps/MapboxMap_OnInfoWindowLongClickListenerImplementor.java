package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnInfoWindowLongClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnInfoWindowLongClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInfoWindowLongClick:(Lcom/mapbox/mapboxsdk/annotations/Marker;)V:GetOnInfoWindowLongClick_Lcom_mapbox_mapboxsdk_annotations_Marker_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnInfoWindowLongClickListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnInfoWindowLongClickListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnInfoWindowLongClickListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnInfoWindowLongClickListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnInfoWindowLongClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnInfoWindowLongClickListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onInfoWindowLongClick (com.mapbox.mapboxsdk.annotations.Marker p0)
	{
		n_onInfoWindowLongClick (p0);
	}

	private native void n_onInfoWindowLongClick (com.mapbox.mapboxsdk.annotations.Marker p0);

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
