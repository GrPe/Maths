package md5230d9ba631e4ee85b4463801f1dec6e9;


public class Division2
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Maths.Resources.Activities.Division2, Maths, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Division2.class, __md_methods);
	}


	public Division2 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Division2.class)
			mono.android.TypeManager.Activate ("Maths.Resources.Activities.Division2, Maths, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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