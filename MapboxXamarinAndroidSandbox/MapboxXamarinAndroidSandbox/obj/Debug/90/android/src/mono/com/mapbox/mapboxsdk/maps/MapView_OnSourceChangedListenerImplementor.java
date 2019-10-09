package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnSourceChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnSourceChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSourceChangedListener:(Ljava/lang/String;)V:GetOnSourceChangedListener_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnSourceChangedListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnSourceChangedListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnSourceChangedListenerImplementor.class, __md_methods);
	}


	public MapView_OnSourceChangedListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnSourceChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnSourceChangedListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onSourceChangedListener (java.lang.String p0)
	{
		n_onSourceChangedListener (p0);
	}

	private native void n_onSourceChangedListener (java.lang.String p0);

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
