package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnCanRemoveUnusedStyleImageListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnCanRemoveUnusedStyleImageListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCanRemoveUnusedStyleImage:(Ljava/lang/String;)Z:GetOnCanRemoveUnusedStyleImage_Ljava_lang_String_Handler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCanRemoveUnusedStyleImageListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnCanRemoveUnusedStyleImageListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnCanRemoveUnusedStyleImageListenerImplementor.class, __md_methods);
	}


	public MapView_OnCanRemoveUnusedStyleImageListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnCanRemoveUnusedStyleImageListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnCanRemoveUnusedStyleImageListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public boolean onCanRemoveUnusedStyleImage (java.lang.String p0)
	{
		return n_onCanRemoveUnusedStyleImage (p0);
	}

	private native boolean n_onCanRemoveUnusedStyleImage (java.lang.String p0);

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
