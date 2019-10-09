package mono.com.mapbox.mapboxsdk.location;


public class OnLocationClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.location.OnLocationClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLocationComponentClick:()V:GetOnLocationComponentClickHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerImplementor, Mapbox-SDK-8.4.0", OnLocationClickListenerImplementor.class, __md_methods);
	}


	public OnLocationClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnLocationClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Location.IOnLocationClickListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onLocationComponentClick ()
	{
		n_onLocationComponentClick ();
	}

	private native void n_onLocationComponentClick ();

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
