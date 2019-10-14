package mono.com.mapbox.android.gestures;


public class ShoveGestureDetector_OnShoveGestureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.android.gestures.ShoveGestureDetector.OnShoveGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onShove:(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)Z:GetOnShove_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.ShoveGestureDetector/IOnShoveGestureListenerInvoker, MapboxGestures\n" +
			"n_onShoveBegin:(Lcom/mapbox/android/gestures/ShoveGestureDetector;)Z:GetOnShoveBegin_Lcom_mapbox_android_gestures_ShoveGestureDetector_Handler:Com.Mapbox.Android.Gestures.ShoveGestureDetector/IOnShoveGestureListenerInvoker, MapboxGestures\n" +
			"n_onShoveEnd:(Lcom/mapbox/android/gestures/ShoveGestureDetector;FF)V:GetOnShoveEnd_Lcom_mapbox_android_gestures_ShoveGestureDetector_FFHandler:Com.Mapbox.Android.Gestures.ShoveGestureDetector/IOnShoveGestureListenerInvoker, MapboxGestures\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Android.Gestures.ShoveGestureDetector+IOnShoveGestureListenerImplementor, MapboxGestures", ShoveGestureDetector_OnShoveGestureListenerImplementor.class, __md_methods);
	}


	public ShoveGestureDetector_OnShoveGestureListenerImplementor ()
	{
		super ();
		if (getClass () == ShoveGestureDetector_OnShoveGestureListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Android.Gestures.ShoveGestureDetector+IOnShoveGestureListenerImplementor, MapboxGestures", "", this, new java.lang.Object[] {  });
	}


	public boolean onShove (com.mapbox.android.gestures.ShoveGestureDetector p0, float p1, float p2)
	{
		return n_onShove (p0, p1, p2);
	}

	private native boolean n_onShove (com.mapbox.android.gestures.ShoveGestureDetector p0, float p1, float p2);


	public boolean onShoveBegin (com.mapbox.android.gestures.ShoveGestureDetector p0)
	{
		return n_onShoveBegin (p0);
	}

	private native boolean n_onShoveBegin (com.mapbox.android.gestures.ShoveGestureDetector p0);


	public void onShoveEnd (com.mapbox.android.gestures.ShoveGestureDetector p0, float p1, float p2)
	{
		n_onShoveEnd (p0, p1, p2);
	}

	private native void n_onShoveEnd (com.mapbox.android.gestures.ShoveGestureDetector p0, float p1, float p2);

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
