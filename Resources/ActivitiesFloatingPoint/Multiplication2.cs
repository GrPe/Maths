using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesFloatingPoint
{
    [Activity(Label = "Multiplication2", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Multiplication2 : FloatingPointActivity
    {
        protected override void Initialize()
        {
            DelCom = FloatingPointNumberFunction.VerifyMultiplication;
            DelGen = FloatingPointNumberFunction.GenerateMultiplication;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}