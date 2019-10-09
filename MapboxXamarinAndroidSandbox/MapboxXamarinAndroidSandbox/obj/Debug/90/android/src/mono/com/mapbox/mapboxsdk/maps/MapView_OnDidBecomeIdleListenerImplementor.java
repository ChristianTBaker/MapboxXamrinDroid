package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnDidBecomeIdleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnDidBecomeIdleListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDidBecomeIdle:()V:GetOnDidBecomeIdleHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidBecomeIdleListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidBecomeIdleListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnDidBecomeIdleListenerImplementor.class, __md_methods);
	}


	public MapView_OnDidBecomeIdleListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnDidBecomeIdleListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidBecomeIdleListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onDidBecomeIdle ()
	{
		n_onDidBecomeIdle ();
	}

	private native void n_onDidBecomeIdle ();

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
