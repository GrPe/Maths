using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesFloatingPoint
{
    [Activity(Label = "Addition2", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Addition2 : FloatingPointActivity
    {
        protected override void Initialize()
        {
            DelGen = FloatingPointNumberFunction.GenerateAddition;
            DelCom = FloatingPointNumberFunction.VerifyAddition;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}