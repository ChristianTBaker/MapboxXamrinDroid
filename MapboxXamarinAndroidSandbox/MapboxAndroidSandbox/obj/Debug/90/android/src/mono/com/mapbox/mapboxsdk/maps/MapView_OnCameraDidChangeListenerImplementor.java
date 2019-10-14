package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnCameraDidChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnCameraDidChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraDidChange:(Z)V:GetOnCameraDidChange_ZHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCameraDidChangeListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnCameraDidChangeListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnCameraDidChangeListenerImplementor.class, __md_methods);
	}


	public MapView_OnCameraDidChangeListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnCameraDidChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnCameraDidChangeListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onCameraDidChange (boolean p0)
	{
		n_onCameraDidChange (p0);
	}

	private native void n_onCameraDidChange (boolean p0);

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
