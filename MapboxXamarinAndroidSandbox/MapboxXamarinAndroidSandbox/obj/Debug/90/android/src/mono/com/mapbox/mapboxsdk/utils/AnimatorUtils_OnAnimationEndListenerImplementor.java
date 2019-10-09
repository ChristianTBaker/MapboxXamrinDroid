package mono.com.mapbox.mapboxsdk.utils;


public class AnimatorUtils_OnAnimationEndListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.utils.AnimatorUtils.OnAnimationEndListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnimationEnd:()V:GetOnAnimationEndHandler:Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils/IOnAnimationEndListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils+IOnAnimationEndListenerImplementor, Mapbox-SDK-8.4.0", AnimatorUtils_OnAnimationEndListenerImplementor.class, __md_methods);
	}


	public AnimatorUtils_OnAnimationEndListenerImplementor ()
	{
		super ();
		if (getClass () == AnimatorUtils_OnAnimationEndListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Utils.AnimatorUtils+IOnAnimationEndListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onAnimationEnd ()
	{
		n_onAnimationEnd ();
	}

	private native void n_onAnimationEnd ();

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
