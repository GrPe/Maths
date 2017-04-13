using Android.App;
using Android.OS;
using Functionalities;
using Maths.Resources.BaseActivities;

namespace Maths.Resources.Activities
{
    [Activity(Label = "Subtraction22")]
    public class Subtraction22 : IntegerActivity
    {
        public override void Initialize()
        {
            delgen = IntegerFunctions.GenerateSubtraction;
            delcom = IntegerFunctions.VerifySubtraction;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}