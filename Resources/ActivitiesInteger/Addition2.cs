using Android.App;
using Android.OS;
using Functionalities;
using Maths.Resources.BaseActivities;

namespace Maths.Resources.Activities
{
    [Activity(Label = "Addition2")]
    public class Addition2 : IntegerActivity
    {
        public override void Initialize()
        {
            delcom = IntegerFunctions.VerifyAddition;
            delgen = IntegerFunctions.GenerateAddition;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}