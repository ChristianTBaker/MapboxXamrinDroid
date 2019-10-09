package mono.com.mapbox.mapboxsdk.location;


public class OnLocationStaleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.location.OnLocationStaleListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onStaleStateChange:(Z)V:GetOnStaleStateChange_ZHandler:Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerImplementor, Mapbox-SDK-8.4.0", OnLocationStaleListenerImplementor.class, __md_methods);
	}


	public OnLocationStaleListenerImplementor ()
	{
		super ();
		if (getClass () == OnLocationStaleListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Location.IOnLocationStaleListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onStaleStateChange (boolean p0)
	{
		n_onStaleStateChange (p0);
	}

	private native void n_onStaleStateChange (boolean p0);

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
