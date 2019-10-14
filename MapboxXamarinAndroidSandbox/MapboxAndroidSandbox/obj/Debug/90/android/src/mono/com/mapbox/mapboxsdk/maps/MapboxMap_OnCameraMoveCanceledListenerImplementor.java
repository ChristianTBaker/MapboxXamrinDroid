package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnCameraMoveCanceledListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraMoveCanceledListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraMoveCanceled:()V:GetOnCameraMoveCanceledHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraMoveCanceledListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCameraMoveCanceledListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnCameraMoveCanceledListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnCameraMoveCanceledListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnCameraMoveCanceledListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCameraMoveCanceledListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onCameraMoveCanceled ()
	{
		n_onCameraMoveCanceled ();
	}

	private native void n_onCameraMoveCanceled ();

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
