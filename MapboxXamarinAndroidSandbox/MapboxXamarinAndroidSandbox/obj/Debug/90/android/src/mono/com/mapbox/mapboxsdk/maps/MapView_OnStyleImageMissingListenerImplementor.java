package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnStyleImageMissingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnStyleImageMissingListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onStyleImageMissing:(Ljava/lang/String;)V:GetOnStyleImageMissing_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnStyleImageMissingListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnStyleImageMissingListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnStyleImageMissingListenerImplementor.class, __md_methods);
	}


	public MapView_OnStyleImageMissingListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnStyleImageMissingListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnStyleImageMissingListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onStyleImageMissing (java.lang.String p0)
	{
		n_onStyleImageMissing (p0);
	}

	private native void n_onStyleImageMissing (java.lang.String p0);

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
