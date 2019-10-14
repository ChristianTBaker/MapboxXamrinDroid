package mono.com.mapbox.mapboxsdk.maps;


public class MapboxMap_OnCameraIdleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapboxMap.OnCameraIdleListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraIdle:()V:GetOnCameraIdleHandler:Com.Mapbox.Mapboxsdk.Maps.MapboxMap/IOnCameraIdleListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCameraIdleListenerImplementor, Mapbox-SDK-8.4.0", MapboxMap_OnCameraIdleListenerImplementor.class, __md_methods);
	}


	public MapboxMap_OnCameraIdleListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxMap_OnCameraIdleListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapboxMap+IOnCameraIdleListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onCameraIdle ()
	{
		n_onCameraIdle ();
	}

	private native void n_onCameraIdle ();

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
