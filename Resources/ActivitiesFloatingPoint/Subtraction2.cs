using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesFloatingPoint
{
    [Activity(Label = "Subtraction2")]
    public class Subtraction2 : FloatingPointActivity
    {
        public override void Initialize()
        {
            delgen = FloatingPointNumberFunction.GenerateSubtraction;
            delcom = FloatingPointNumberFunction.VerifySubtraction;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}