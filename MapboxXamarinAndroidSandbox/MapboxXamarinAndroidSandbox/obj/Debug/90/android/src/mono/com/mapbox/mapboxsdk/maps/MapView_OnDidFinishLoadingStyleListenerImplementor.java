package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnDidFinishLoadingStyleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnDidFinishLoadingStyleListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDidFinishLoadingStyle:()V:GetOnDidFinishLoadingStyleHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishLoadingStyleListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFinishLoadingStyleListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnDidFinishLoadingStyleListenerImplementor.class, __md_methods);
	}


	public MapView_OnDidFinishLoadingStyleListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnDidFinishLoadingStyleListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFinishLoadingStyleListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onDidFinishLoadingStyle ()
	{
		n_onDidFinishLoadingStyle ();
	}

	private native void n_onDidFinishLoadingStyle ();

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
