using Android.App;
using Android.OS;
using Functionalities;
using Maths.Resources.BaseActivities;

namespace Maths.Resources.Activities
{
    [Activity(Label = "Subtraction2")]
    public class Subtraction2 : IntegerActivity
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