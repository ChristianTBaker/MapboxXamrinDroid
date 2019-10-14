package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnDidFinishRenderingFrameListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnDidFinishRenderingFrameListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDidFinishRenderingFrame:(Z)V:GetOnDidFinishRenderingFrame_ZHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFinishRenderingFrameListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFinishRenderingFrameListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnDidFinishRenderingFrameListenerImplementor.class, __md_methods);
	}


	public MapView_OnDidFinishRenderingFrameListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnDidFinishRenderingFrameListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFinishRenderingFrameListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onDidFinishRenderingFrame (boolean p0)
	{
		n_onDidFinishRenderingFrame (p0);
	}

	private native void n_onDidFinishRenderingFrame (boolean p0);

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
