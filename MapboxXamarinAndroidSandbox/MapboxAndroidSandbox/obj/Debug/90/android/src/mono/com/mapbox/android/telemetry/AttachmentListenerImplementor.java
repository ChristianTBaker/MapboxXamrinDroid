package mono.com.mapbox.android.telemetry;


public class AttachmentListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mapbox.android.telemetry.AttachmentListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttachmentFailure:(Ljava/lang/String;Ljava/util/List;)V:GetOnAttachmentFailure_Ljava_lang_String_Ljava_util_List_Handler:Com.Mapbox.Android.Telemetry.IAttachmentListenerInvoker, MapboxTelemetry\n" +
			"n_onAttachmentResponse:(Ljava/lang/String;ILjava/util/List;)V:GetOnAttachmentResponse_Ljava_lang_String_ILjava_util_List_Handler:Com.Mapbox.Android.Telemetry.IAttachmentListenerInvoker, MapboxTelemetry\n" +
			"";
		mono.android.Runtime.register ("Com.Mapbox.Android.Telemetry.IAttachmentListenerImplementor, MapboxTelemetry", AttachmentListenerImplementor.class, __md_methods);
	}


	public AttachmentListenerImplementor ()
	{
		super ();
		if (getClass () == AttachmentListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mapbox.Android.Telemetry.IAttachmentListenerImplementor, MapboxTelemetry", "", this, new java.lang.Object[] {  });
	}


	public void onAttachmentFailure (java.lang.String p0, java.util.List p1)
	{
		n_onAttachmentFailure (p0, p1);
	}

	private native void n_onAttachmentFailure (java.lang.String p0, java.util.List p1);


	public void onAttachmentResponse (java.lang.String p0, int p1, java.util.List p2)
	{
		n_onAttachmentResponse (p0, p1, p2);
	}

	private native void n_onAttachmentResponse (java.lang.String p0, int p1, java.util.List p2);

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
