package mono.com.mapbox.android.gestures;


public class StandardScaleGestureDetector_StandardOnScaleGestureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.android.gestures.StandardScaleGestureDetector.StandardOnScaleGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScale:(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z:GetOnScale_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler:Com.Mapbox.Android.Gestures.StandardScaleGestureDetector/IStandardOnScaleGestureListenerInvoker, MapboxGestures\n" +
			"n_onScaleBegin:(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;)Z:GetOnScaleBegin_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_Handler:Com.Mapbox.Android.Gestures.StandardScaleGestureDetector/IStandardOnScaleGestureListenerInvoker, MapboxGestures\n" +
			"n_onScaleEnd:(Lcom/mapbox/android/gestures/StandardScaleGestureDetector;FF)V:GetOnScaleEnd_Lcom_mapbox_android_gestures_StandardScaleGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.StandardScaleGestureDetector/IStandardOnScaleGestureListenerInvoker, MapboxGestures\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Android.Gestures.StandardScaleGestureDetector+IStandardOnScaleGestureListenerImplementor, MapboxGestures", StandardScaleGestureDetector_StandardOnScaleGestureListenerImplementor.class, __md_methods);
	}


	public StandardScaleGestureDetector_StandardOnScaleGestureListenerImplementor ()
	{
		super ();
		if (getClass () == StandardScaleGestureDetector_StandardOnScaleGestureListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Android.Gestures.StandardScaleGestureDetector+IStandardOnScaleGestureListenerImplementor, MapboxGestures", "", this, new java.lang.Object[] {  });
	}


	public boolean onScale (com.mapbox.android.gestures.StandardScaleGestureDetector p0)
	{
		return n_onScale (p0);
	}

	private native boolean n_onScale (com.mapbox.android.gestures.StandardScaleGestureDetector p0);


	public boolean onScaleBegin (com.mapbox.android.gestures.StandardScaleGestureDetector p0)
	{
		return n_onScaleBegin (p0);
	}

	private native boolean n_onScaleBegin (com.mapbox.android.gestures.StandardScaleGestureDetector p0);


	public void onScaleEnd (com.mapbox.android.gestures.StandardScaleGestureDetector p0, float p1, float p2)
	{
		n_onScaleEnd (p0, p1, p2);
	}

	private native void n_onScaleEnd (com.mapbox.android.gestures.StandardScaleGestureDetector p0, float p1, float p2);

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
