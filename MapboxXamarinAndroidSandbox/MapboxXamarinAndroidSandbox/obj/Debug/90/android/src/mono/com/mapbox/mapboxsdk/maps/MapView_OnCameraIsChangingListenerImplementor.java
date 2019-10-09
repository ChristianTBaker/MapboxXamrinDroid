package mono.com.mapbox.mapboxsdk.maps;


public class MapView_OnCameraIsChangingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.MapView.OnCameraIsChangingListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraIsChanging:()V:GetOnCameraIsChangingHandler:Com.Mapbox.Mapboxsdk.Maps.MapView/IOnCameraIsChangingListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnCameraIsChangingListenerImplementor, Mapbox-SDK-8.4.0", MapView_OnCameraIsChangingListenerImplementor.class, __md_methods);
	}


	public MapView_OnCameraIsChangingListenerImplementor ()
	{
		super ();
		if (getClass () == MapView_OnCameraIsChangingListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.MapView+IOnCameraIsChangingListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onCameraIsChanging ()
	{
		n_onCameraIsChanging ();
	}

	private native void n_onCameraIsChanging ();

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
