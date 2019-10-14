package mono.com.mapbox.mapboxsdk.location;


public class OnRenderModeChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.location.OnRenderModeChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRenderModeChanged:(I)V:GetOnRenderModeChanged_IHandler:Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerImplementor, Mapbox-SDK-8.4.0", OnRenderModeChangedListenerImplementor.class, __md_methods);
	}


	public OnRenderModeChangedListenerImplementor ()
	{
		super ();
		if (getClass () == OnRenderModeChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Location.IOnRenderModeChangedListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onRenderModeChanged (int p0)
	{
		n_onRenderModeChanged (p0);
	}

	private native void n_onRenderModeChanged (int p0);

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
