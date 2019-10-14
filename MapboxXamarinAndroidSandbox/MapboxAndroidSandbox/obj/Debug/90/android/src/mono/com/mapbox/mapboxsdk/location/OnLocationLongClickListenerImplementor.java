package mono.com.mapbox.mapboxsdk.location;


public class OnLocationLongClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.location.OnLocationLongClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLocationComponentLongClick:()V:GetOnLocationComponentLongClickHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerImplementor, Mapbox-SDK-8.4.0", OnLocationLongClickListenerImplementor.class, __md_methods);
	}


	public OnLocationLongClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnLocationLongClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Location.IOnLocationLongClickListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onLocationComponentLongClick ()
	{
		n_onLocationComponentLongClick ();
	}

	private native void n_onLocationComponentLongClick ();

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
