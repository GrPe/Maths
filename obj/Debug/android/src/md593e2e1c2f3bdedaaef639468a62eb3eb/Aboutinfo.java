package md593e2e1c2f3bdedaaef639468a62eb3eb;


public class Aboutinfo
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Maths.Resources.Source.Aboutinfo, Maths, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Aboutinfo.class, __md_methods);
	}


	public Aboutinfo () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Aboutinfo.class)
			mono.android.TypeManager.Activate ("Maths.Resources.Source.Aboutinfo, Maths, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
