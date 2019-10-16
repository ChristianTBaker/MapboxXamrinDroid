package mono.com.mapbox.mapboxsdk.plugins.annotation;


public class OnAnnotationDragListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.plugins.annotation.OnAnnotationDragListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnnotationDrag:(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V:GetOnAnnotationDrag_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler:Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListenerInvoker, Mapbox-Android-Plugin -Annotation-v8-0.7.0\n" +
			"n_onAnnotationDragFinished:(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V:GetOnAnnotationDragFinished_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler:Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListenerInvoker, Mapbox-Android-Plugin -Annotation-v8-0.7.0\n" +
			"n_onAnnotationDragStarted:(Lcom/mapbox/mapboxsdk/plugins/annotation/Annotation;)V:GetOnAnnotationDragStarted_Lcom_mapbox_mapboxsdk_plugins_annotation_Annotation_Handler:Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListenerInvoker, Mapbox-Android-Plugin -Annotation-v8-0.7.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListenerImplementor, Mapbox-Android-Plugin -Annotation-v8-0.7.0", OnAnnotationDragListenerImplementor.class, __md_methods);
	}


	public OnAnnotationDragListenerImplementor ()
	{
		super ();
		if (getClass () == OnAnnotationDragListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Plugins.Annotation.IOnAnnotationDragListenerImplementor, Mapbox-Android-Plugin -Annotation-v8-0.7.0", "", this, new java.lang.Object[] {  });
	}


	public void onAnnotationDrag (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0)
	{
		n_onAnnotationDrag (p0);
	}

	private native void n_onAnnotationDrag (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0);


	public void onAnnotationDragFinished (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0)
	{
		n_onAnnotationDragFinished (p0);
	}

	private native void n_onAnnotationDragFinished (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0);


	public void onAnnotationDragStarted (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0)
	{
		n_onAnnotationDragStarted (p0);
	}

	private native void n_onAnnotationDragStarted (com.mapbox.mapboxsdk.plugins.annotation.Annotation p0);

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
