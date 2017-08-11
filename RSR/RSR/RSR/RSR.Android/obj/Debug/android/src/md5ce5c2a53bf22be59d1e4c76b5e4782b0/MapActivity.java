package md5ce5c2a53bf22be59d1e4c76b5e4782b0;


public class MapActivity
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.FormsAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("RSR.Droid.MapActivity, RSR.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MapActivity.class, __md_methods);
	}


	public MapActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MapActivity.class)
			mono.android.TypeManager.Activate ("RSR.Droid.MapActivity, RSR.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
