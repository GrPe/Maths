using Android.App;
using Android.OS;

namespace Maths.Resources.Source
{
    [Activity(Label = "AboutInfo", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Aboutinfo : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.Aboutinfo);
        }
    }
}