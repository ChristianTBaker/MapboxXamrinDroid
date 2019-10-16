package md5427a32c29b6e77754a43354e2f781317;


public class MainActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		com.mapbox.mapboxsdk.maps.OnMapReadyCallback,
		com.mapbox.mapboxsdk.maps.Style.OnStyleLoaded
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateOptionsMenu:(Landroid/view/Menu;)Z:GetOnCreateOptionsMenu_Landroid_view_Menu_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"n_onStart:()V:GetOnStartHandler\n" +
			"n_onMapReady:(Lcom/mapbox/mapboxsdk/maps/MapboxMap;)V:GetOnMapReady_Lcom_mapbox_mapboxsdk_maps_MapboxMap_Handler:Com.Mapbox.Mapboxsdk.Maps.IOnMapReadyCallbackInvoker, Mapbox-SDK-8.4.0\n" +
			"n_onStyleLoaded:(Lcom/mapbox/mapboxsdk/maps/Style;)V:GetOnStyleLoaded_Lcom_mapbox_mapboxsdk_maps_Style_Handler:Com.Mapbox.Mapboxsdk.Maps.Style/IOnStyleLoadedInvoker, Mapbox-SDK-8.4.0\n" +
			"";
		mono.android.Runtime.register ("MapboxAndroidSandbox.MainActivity, MapboxAndroidSandbox", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("MapboxAndroidSandbox.MainActivity, MapboxAndroidSandbox", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public boolean onCreateOptionsMenu (android.view.Menu p0)
	{
		return n_onCreateOptionsMenu (p0);
	}

	private native boolean n_onCreateOptionsMenu (android.view.Menu p0);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();


	public void onMapReady (com.mapbox.mapboxsdk.maps.MapboxMap p0)
	{
		n_onMapReady (p0);
	}

	private native void n_onMapReady (com.mapbox.mapboxsdk.maps.MapboxMap p0);


	public void onStyleLoaded (com.mapbox.mapboxsdk.maps.Style p0)
	{
		n_onStyleLoaded (p0);
	}

	private native void n_onStyleLoaded (com.mapbox.mapboxsdk.maps.Style p0);

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
