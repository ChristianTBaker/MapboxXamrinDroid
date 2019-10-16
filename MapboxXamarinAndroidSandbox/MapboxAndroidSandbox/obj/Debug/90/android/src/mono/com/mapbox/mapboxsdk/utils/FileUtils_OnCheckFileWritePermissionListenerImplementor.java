package mono.com.mapbox.mapboxsdk.utils;


public class FileUtils_OnCheckFileWritePermissionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.utils.FileUtils.OnCheckFileWritePermissionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:()V:GetOnErrorHandler:Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileWritePermissionListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"n_onWritePermissionGranted:()V:GetOnWritePermissionGrantedHandler:Com.Mapbox.Mapboxsdk.Utils.FileUtils/IOnCheckFileWritePermissionListenerInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Mapboxsdk.Utils.FileUtils+IOnCheckFileWritePermissionListenerImplementor, Mapbox-SDK-8.4.0", FileUtils_OnCheckFileWritePermissionListenerImplementor.class, __md_methods);
	}


	public FileUtils_OnCheckFileWritePermissionListenerImplementor ()
	{
		super ();
		if (getClass () == FileUtils_OnCheckFileWritePermissionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Mapboxsdk.Utils.FileUtils+IOnCheckFileWritePermissionListenerImplementor, Mapbox-SDK-8.4.0", "", this, new java.lang.Object[] {  });
	}


	public void onError ()
	{
		n_onError ();
	}

	private native void n_onError ();


	public void onWritePermissionGranted ()
	{
		n_onWritePermissionGranted ();
	}

	private native void n_onWritePermissionGranted ();

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
