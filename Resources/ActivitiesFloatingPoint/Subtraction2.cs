using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesFloatingPoint
{
    [Activity(Label = "Subtraction2")]
    public class Subtraction2 : FloatingPointActivity
    {
        protected override void Initialize()
        {
            DelGen = FloatingPointNumberFunction.GenerateSubtraction;
            DelCom = FloatingPointNumberFunction.VerifySubtraction;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}