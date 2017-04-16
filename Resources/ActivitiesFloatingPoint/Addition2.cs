using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesFloatingPoint
{
    [Activity(Label = "Addition2")]
    public class Addition2 : FloatingPointActivity
    {
        public override void Initialize()
        {
            delgen = FloatingPointNumberFunction.GenerateAddition;
            delcom = FloatingPointNumberFunction.VerifyAddition;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}