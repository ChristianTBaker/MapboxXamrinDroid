package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnCameraMoveListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraMove:()V:GetOnCameraMoveHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraMoveListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCameraMoveListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnCameraMoveListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnCameraMoveListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnCameraMoveListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCameraMoveListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onCameraMove ()
	{
		n_onCameraMove ();
	}

	private native void n_onCameraMove ();

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
