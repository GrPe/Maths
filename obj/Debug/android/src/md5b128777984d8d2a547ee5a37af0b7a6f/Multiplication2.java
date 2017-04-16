package md5b128777984d8d2a547ee5a37af0b7a6f;


public class Multiplication2
	extends md5bf7134fd40824433040c991a616c493c.IntegerActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Maths.Resources.ActivitiesInteger.Multiplication2, Maths, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Multiplication2.class, __md_methods);
	}


	public Multiplication2 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Multiplication2.class)
			mono.android.TypeManager.Activate ("Maths.Resources.ActivitiesInteger.Multiplication2, Maths, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
