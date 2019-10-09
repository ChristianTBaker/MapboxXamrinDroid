package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnWillStartRenderingFrameListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnWillStartRenderingFrameListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onWillStartRenderingFrame:()V:GetOnWillStartRenderingFrameHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnWillStartRenderingFrameListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnWillStartRenderingFrameListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnWillStartRenderingFrameListenerImplementor.class, __md_methods);
	}


	public MapView_OnWillStartRenderingFrameListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnWillStartRenderingFrameListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnWillStartRenderingFrameListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onWillStartRenderingFrame ()
	{
		n_onWillStartRenderingFrame ();
	}

	private native void n_onWillStartRenderingFrame ();

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
