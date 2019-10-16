package mono.com.mapbox.mapboxsdk.utils;


public class FileUtils_OnCheckFileReadPermissionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.utils.FileUtils.OnCheckFileReadPermissionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:()V:GetOnErrorHandler:Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileReadPermissionListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"n_onReadPermissionGranted:()V:GetOnReadPermissionGrantedHandler:Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileReadPermissionListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Utils.FileUtils+IOnCheckFileReadPermissionListenerImplementor, Mapbox-SDK-8.4.0", FileUtils_OnCheckFileReadPermissionListenerImplementor.class, __md_methods);
	}


	public FileUtils_OnCheckFileReadPermissionListenerImplementor ()
	{
		super ();
		if (getClass () == FileUtils_OnCheckFileReadPermissionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Utils.FileUtils+IOnCheckFileReadPermissionListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onError ()
	{
		n_onError ();
	}

	private native void n_onError ();


	public void onReadPermissionGranted ()
	{
		n_onReadPermissionGranted ();
	}

	private native void n_onReadPermissionGranted ();

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
