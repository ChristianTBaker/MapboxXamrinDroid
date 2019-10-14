package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnDidFailLoadingMapListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnDidFailLoadingMapListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDidFailLoadingMap:(Ljava/lang/String;)V:GetOnDidFailLoadingMap_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnDidFailLoadingMapListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFailLoadingMapListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnDidFailLoadingMapListenerImplementor.class, __md_methods);
	}


	public MapView_OnDidFailLoadingMapListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnDidFailLoadingMapListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnDidFailLoadingMapListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onDidFailLoadingMap (java.lang.String p0)
	{
		n_onDidFailLoadingMap (p0);
	}

	private native void n_onDidFailLoadingMap (java.lang.String p0);

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
