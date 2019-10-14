package mono.com.mapbox.mapboxsdk.net;


public class ConnectivityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.net.ConnectivityListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onNetworkStateChanged:(Z)V:GetOnNetworkStateChanged_ZHandler:Com.Mapbox.Mapboxsdk.Net.IConnectivityListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Net.IConnectivityListenerImplementor, Mapbox-SDK-8.4.0", ConnectivityListenerImplementor.class, __md_methods);
	}


	public ConnectivityListenerImplementor ()
	{
		super ();
		if (getClass () == ConnectivityListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Net.IConnectivityListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onNetworkStateChanged (boolean p0)
	{
		n_onNetworkStateChanged (p0);
	}

	private native void n_onNetworkStateChanged (boolean p0);

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
