package mono.com.mapbox.android.gestures;


public class RotateGestureDetector_OnRotateGestureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.android.gestures.RotateGestureDetector.OnRotateGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRotate:(Lcom/mapbox/android/gestures/RotateGestureDetector;FF)Z:GetOnRotate_Lcom_mapbox_android_gestures_RotateGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.RotateGestureDetector/IOnRotateGestureListenerInvoker, MapboxGestures\n" +
			"n_onRotateBegin:(Lcom/mapbox/android/gestures/RotateGestureDetector;)Z:GetOnRotateBegin_Lcom_mapbox_android_gestures_RotateGestureDetector_Handler:Com.Mapbox.Android.Gestures.RotateGestureDetector/IOnRotateGestureListenerInvoker, MapboxGestures\n" +
			"n_onRotateEnd:(Lcom/mapbox/android/gestures/RotateGestureDetector;FFF)V:GetOnRotateEnd_Lcom_mapbox_android_gestures_RotateGestureDetector_FFFHandler:Com.Mapbox.Android.Gestures.RotateGestureDetector/IOnRotateGestureListenerInvoker, MapboxGestures\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Android.Gestures.RotateGestureDetector+IOnRotateGestureListenerImplementor, MapboxGestures", RotateGestureDetector_OnRotateGestureListenerImplementor.class, __md_methods);
	}


	public RotateGestureDetector_OnRotateGestureListenerImplementor ()
	{
		super ();
		if (getClass () == RotateGestureDetector_OnRotateGestureListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Android.Gestures.RotateGestureDetector+IOnRotateGestureListenerImplementor, MapboxGestures", "", this, new java.lang.Object[] {  });
	}


	public boolean onRotate (com.mapbox.android.gestures.RotateGestureDetector p0, float p1, float p2)
	{
		return n_onRotate (p0, p1, p2);
	}

	private native boolean n_onRotate (com.mapbox.android.gestures.RotateGestureDetector p0, float p1, float p2);


	public boolean onRotateBegin (com.mapbox.android.gestures.RotateGestureDetector p0)
	{
		return n_onRotateBegin (p0);
	}

	private native boolean n_onRotateBegin (com.mapbox.android.gestures.RotateGestureDetector p0);


	public void onRotateEnd (com.mapbox.android.gestures.RotateGestureDetector p0, float p1, float p2, float p3)
	{
		n_onRotateEnd (p0, p1, p2, p3);
	}

	private native void n_onRotateEnd (com.mapbox.android.gestures.RotateGestureDetector p0, float p1, float p2, float p3);

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
