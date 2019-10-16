package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnPolylineClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnPolylineClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPolylineClick:(Lcom/mapbox/mapboxsdk/annotations/Polyline;)V:GetOnPolylineClick_Lcom_mapbox_mapboxsdk_annotations_Polyline_Handler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnPolylineClickListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnPolylineClickListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnPolylineClickListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnPolylineClickListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnPolylineClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnPolylineClickListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onPolylineClick (com.mapbox.mapboxsdk.annotations.Polyline p0)
	{
		n_onPolylineClick (p0);
	}

	private native void n_onPolylineClick (com.mapbox.mapboxsdk.annotations.Polyline p0);

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
