package mono.com.mapbox.android.gestures;


public class MultiFingerTapGestureDetector_OnMultiFingerTapGestureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.android.gestures.MultiFingerTapGestureDetector.OnMultiFingerTapGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMultiFingerTap:(Lcom/mapbox/android/gestures/MultiFingerTapGestureDetector;I)Z:GetOnMultiFingerTap_Lcom_mapbox_android_gestures_MultiFingerTapGestureDetector_IHandler:Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector/IOnMultiFingerTapGestureListenerInvoker, MapboxGestures\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector+IOnMultiFingerTapGestureListenerImplementor, MapboxGestures", MultiFingerTapGestureDetector_OnMultiFingerTapGestureListenerImplementor.class, __md_methods);
	}


	public MultiFingerTapGestureDetector_OnMultiFingerTapGestureListenerImplementor ()
	{
		super ();
		if (getClass () == MultiFingerTapGestureDetector_OnMultiFingerTapGestureListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Android.Gestures.MultiFingerTapGestureDetector+IOnMultiFingerTapGestureListenerImplementor, MapboxGestures", "", this, new java.lang.Object[] {  });
	}


	public boolean onMultiFingerTap (com.mapbox.android.gestures.MultiFingerTapGestureDetector p0, int p1)
	{
		return n_onMultiFingerTap (p0, p1);
	}

	private native boolean n_onMultiFingerTap (com.mapbox.android.gestures.MultiFingerTapGestureDetector p0, int p1);

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
