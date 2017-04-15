using Android.App;
using Android.OS;
using Functionalities;
using Maths.Resources.BaseActivities;

namespace Maths.Resources.ActivitiesInteger
{
    [Activity(Label = "Multiplication2")]
    public class Multiplication2 : IntegerActivity
    {
        public override void Initialize()
        {
            delcom = IntegerFunctions.VerifyMultiplication;
            delgen = IntegerFunctions.GenerateMultiplication;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}