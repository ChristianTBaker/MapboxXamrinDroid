package mono.com.mapbox.android.gestures;


public class SidewaysShoveGestureDetector_OnSidewaysShoveGestureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.android.gestures.SidewaysShoveGestureDetector.OnSidewaysShoveGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSidewaysShove:(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)Z:GetOnSidewaysShove_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector/IOnSidewaysShoveGestureListenerInvoker, MapboxGestures\n" +
			"n_onSidewaysShoveBegin:(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;)Z:GetOnSidewaysShoveBegin_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_Handler:Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector/IOnSidewaysShoveGestureListenerInvoker, MapboxGestures\n" +
			"n_onSidewaysShoveEnd:(Lcom/mapbox/android/gestures/SidewaysShoveGestureDetector;FF)V:GetOnSidewaysShoveEnd_Lcom_mapbox_android_gestures_SidewaysShoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector/IOnSidewaysShoveGestureListenerInvoker, MapboxGestures\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector+IOnSidewaysShoveGestureListenerImplementor, MapboxGestures", SidewaysShoveGestureDetector_OnSidewaysShoveGestureListenerImplementor.class, __md_methods);
	}


	public SidewaysShoveGestureDetector_OnSidewaysShoveGestureListenerImplementor ()
	{
		super ();
		if (getClass () == SidewaysShoveGestureDetector_OnSidewaysShoveGestureListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Android.Gestures.SidewaysShoveGestureDetector+IOnSidewaysShoveGestureListenerImplementor, MapboxGestures", "", this, new java.lang.Object[] {  });
	}


	public boolean onSidewaysShove (com.mapbox.android.gestures.SidewaysShoveGestureDetector p0, float p1, float p2)
	{
		return n_onSidewaysShove (p0, p1, p2);
	}

	private native boolean n_onSidewaysShove (com.mapbox.android.gestures.SidewaysShoveGestureDetector p0, float p1, float p2);


	public boolean onSidewaysShoveBegin (com.mapbox.android.gestures.SidewaysShoveGestureDetector p0)
	{
		return n_onSidewaysShoveBegin (p0);
	}

	private native boolean n_onSidewaysShoveBegin (com.mapbox.android.gestures.SidewaysShoveGestureDetector p0);


	public void onSidewaysShoveEnd (com.mapbox.android.gestures.SidewaysShoveGestureDetector p0, float p1, float p2)
	{
		n_onSidewaysShoveEnd (p0, p1, p2);
	}

	private native void n_onSidewaysShoveEnd (com.mapbox.android.gestures.SidewaysShoveGestureDetector p0, float p1, float p2);

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
