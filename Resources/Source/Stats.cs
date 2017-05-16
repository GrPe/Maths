using Android.App;
using Android.OS;

namespace Maths.Resources.Source
{
    [Activity(Label = "Stats", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Stats : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Stats);


        }
    }
}