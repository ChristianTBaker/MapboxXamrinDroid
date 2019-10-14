package mono.com.mapbox.mapboxsdk.maps.renderer.glsurfaceview;


public class MapboxGLSurfaceView_OnGLSurfaceViewDetachedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.renderer.glsurfaceview.MapboxGLSurfaceView.OnGLSurfaceViewDetachedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGLSurfaceViewDetached:()V:GetOnGLSurfaceViewDetachedHandler:Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView/IOnGLSurfaceViewDetachedListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView+IOnGLSurfaceViewDetachedListenerImplementor, Mapbox-SDK-8.4.0", MapboxGLSurfaceView_OnGLSurfaceViewDetachedListenerImplementor.class, __md_methods);
	}


	public MapboxGLSurfaceView_OnGLSurfaceViewDetachedListenerImplementor ()
	{
		super ();
		if (getClass () == MapboxGLSurfaceView_OnGLSurfaceViewDetachedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Maps.Renderer.Glsurfaceview.MapboxGLSurfaceView+IOnGLSurfaceViewDetachedListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onGLSurfaceViewDetached ()
	{
		n_onGLSurfaceViewDetached ();
	}

	private native void n_onGLSurfaceViewDetached ();

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
