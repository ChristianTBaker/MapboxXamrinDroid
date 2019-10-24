package mono.com.mapbox.mapboxsdk.plugins.annotation;


public class OnAnnotationLongClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationLongClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnnotationLongClick:(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V:GetOnAnnotationLongClick_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler:Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationLongClickListenerInvoker, Mapbox-Android-Annotation-Plugin-v8\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationLongClickListenerImplementor, Mapbox-Android-Annotation-Plugin-v8", OnAnnotationLongClickListenerImplementor.class, __md_methods);
	}


	public OnAnnotationLongClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnAnnotationLongClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationLongClickListenerImplementor, Mapbox-Android-Annotation-Plugin-v8", "", this, new java.lang.Object[] {  });
	}


	public void onAnnotationLongClick (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0)
	{
		n_onAnnotationLongClick (p0);
	}

	private native void n_onAnnotationLongClick (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0);

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
