package mono.com.mapbox.mapboxsdk.plugins.annotation;


public class OnAnnotationClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnnotationClick:(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V:GetOnAnnotationClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler:Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationClickListenerInvoker, Mapbox-Android-Plugin -Annotation-v8-0.7.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationClickListenerImplementor, Mapbox-Android-Plugin -Annotation-v8-0.7.0", OnAnnotationClickListenerImplementor.class, __md_methods);
	}


	public OnAnnotationClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnAnnotationClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationClickListenerImplementor, Mapbox-Android-Plugin -Annotation-v8-0.7.0", "", this, new java.lang.Object[] {  });
	}


	public void onAnnotationClick (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0)
	{
		n_onAnnotationClick (p0);
	}

	private native void n_onAnnotationClick (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0);

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
