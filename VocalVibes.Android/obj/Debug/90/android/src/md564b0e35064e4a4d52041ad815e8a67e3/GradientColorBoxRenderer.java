package md564b0e35064e4a4d52041ad815e8a67e3;


public class GradientColorBoxRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.VisualElementRenderer_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_dispatchDraw:(Landroid/graphics/Canvas;)V:GetDispatchDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("VocalVibes.Droid.GradientColorBoxRenderer, VocalVibes.Android", GradientColorBoxRenderer.class, __md_methods);
	}


	public GradientColorBoxRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == GradientColorBoxRenderer.class)
			mono.android.TypeManager.Activate ("VocalVibes.Droid.GradientColorBoxRenderer, VocalVibes.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public GradientColorBoxRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == GradientColorBoxRenderer.class)
			mono.android.TypeManager.Activate ("VocalVibes.Droid.GradientColorBoxRenderer, VocalVibes.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public GradientColorBoxRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == GradientColorBoxRenderer.class)
			mono.android.TypeManager.Activate ("VocalVibes.Droid.GradientColorBoxRenderer, VocalVibes.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void dispatchDraw (android.graphics.Canvas p0)
	{
		n_dispatchDraw (p0);
	}

	private native void n_dispatchDraw (android.graphics.Canvas p0);

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
