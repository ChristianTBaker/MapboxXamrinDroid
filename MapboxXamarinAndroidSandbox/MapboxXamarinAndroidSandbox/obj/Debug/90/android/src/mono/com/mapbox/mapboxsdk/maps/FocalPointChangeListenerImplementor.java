package mono.com.mapbox.mapboxsdk.maps;


public class FocalPointChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.FocalPointChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFocalPointChanged:(Landroid/graphics/PointF;)V:GetOnFocalPointChanged_Landroid_graphics_PointF_Handler:Com.Mapbox.Mapboxsdk.Maps.IFocalPointChangeListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.IFocalPointChangeListenerImplementor, Mapbox-SDK-8.4.0", FocalPointChangeListenerImplementor.class, __md_methods);
	}


	public FocalPointChangeListenerImplementor ()
	{
		super ();
		if (getClass () == FocalPointChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.IFocalPointChangeListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onFocalPointChanged (android.graphics.PointF p0)
	{
		n_onFocalPointChanged (p0);
	}

	private native void n_onFocalPointChanged (android.graphics.PointF p0);

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
