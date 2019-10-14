package mono.com.mapbox.android.gestures;


public class MoveGestureDetector_OnMoveGestureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.android.gestures.MoveGestureDetector.OnMoveGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMove:(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)Z:GetOnMove_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.MoveGestureDetector/IOnMoveGestureListenerInvoker, MapboxGestures\n" +
			"n_onMoveBegin:(Lcom/mapbox/android/gestures/MoveGestureDetector;)Z:GetOnMoveBegin_Lcom_mapbox_android_gestures_MoveGestureDetector_Handler:Com.Mapbox.Android.Gestures.MoveGestureDetector/IOnMoveGestureListenerInvoker, MapboxGestures\n" +
			"n_onMoveEnd:(Lcom/mapbox/android/gestures/MoveGestureDetector;FF)V:GetOnMoveEnd_Lcom_mapbox_android_gestures_MoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.MoveGestureDetector/IOnMoveGestureListenerInvoker, MapboxGestures\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Android.Gestures.MoveGestureDetector+IOnMoveGestureListenerImplementor, MapboxGestures", MoveGestureDetector_OnMoveGestureListenerImplementor.class, __md_methods);
	}


	public MoveGestureDetector_OnMoveGestureListenerImplementor ()
	{
		super ();
		if (getClass () == MoveGestureDetector_OnMoveGestureListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Android.Gestures.MoveGestureDetector+IOnMoveGestureListenerImplementor, MapboxGestures", "", this, new java.lang.Object[] {  });
	}


	public boolean onMove (com.mapbox.android.gestures.MoveGestureDetector p0, float p1, float p2)
	{
		return n_onMove (p0, p1, p2);
	}

	private native boolean n_onMove (com.mapbox.android.gestures.MoveGestureDetector p0, float p1, float p2);


	public boolean onMoveBegin (com.mapbox.android.gestures.MoveGestureDetector p0)
	{
		return n_onMoveBegin (p0);
	}

	private native boolean n_onMoveBegin (com.mapbox.android.gestures.MoveGestureDetector p0);


	public void onMoveEnd (com.mapbox.android.gestures.MoveGestureDetector p0, float p1, float p2)
	{
		n_onMoveEnd (p0, p1, p2);
	}

	private native void n_onMoveEnd (com.mapbox.android.gestures.MoveGestureDetector p0, float p1, float p2);

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
