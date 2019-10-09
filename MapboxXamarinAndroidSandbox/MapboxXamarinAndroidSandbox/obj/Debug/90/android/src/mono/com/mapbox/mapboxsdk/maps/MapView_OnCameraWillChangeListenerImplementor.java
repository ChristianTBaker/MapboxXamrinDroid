package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnCameraWillChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnCameraWillChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraWillChange:(Z)V:GetOnCameraWillChange_ZHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCameraWillChangeListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnCameraWillChangeListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnCameraWillChangeListenerImplementor.class, __md_methods);
	}


	public MapView_OnCameraWillChangeListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnCameraWillChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnCameraWillChangeListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onCameraWillChange (boolean p0)
	{
		n_onCameraWillChange (p0);
	}

	private native void n_onCameraWillChange (boolean p0);

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
