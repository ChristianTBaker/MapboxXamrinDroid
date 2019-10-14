package mono.com.mapbox.android.telemetry;


public class TelemetryListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.android.telemetry.TelemetryListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onHttpFailure:(Ljava/lang/String;)V:GetOnHttpFailure_Ljava_lang_String_Handler:Com.Mapbox.Android.Telemetry.ITelemetryListenerInvoker, MapboxTelemetry\n" +
			"n_onHttpResponse:(ZI)V:GetOnHttpResponse_ZIHandler:Com.Mapbox.Android.Telemetry.ITelemetryListenerInvoker, MapboxTelemetry\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Android.Telemetry.ITelemetryListenerImplementor, MapboxTelemetry", TelemetryListenerImplementor.class, __md_methods);
	}


	public TelemetryListenerImplementor ()
	{
		super ();
		if (getClass () == TelemetryListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Android.Telemetry.ITelemetryListenerImplementor, MapboxTelemetry", "", this, new java.lang.Object[] {  });
	}


	public void onHttpFailure (java.lang.String p0)
	{
		n_onHttpFailure (p0);
	}

	private native void n_onHttpFailure (java.lang.String p0);


	public void onHttpResponse (boolean p0, int p1)
	{
		n_onHttpResponse (p0, p1);
	}

	private native void n_onHttpResponse (boolean p0, int p1);

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
