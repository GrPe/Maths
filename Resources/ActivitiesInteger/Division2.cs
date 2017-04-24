using Android.App;
using Android.OS;
using Functionalities;
using Maths.Resources.BaseActivities;

namespace Maths.Resources.ActivitiesInteger
{
    [Activity(Label = "Division2")]
    public class Division2 : IntegerActivity
    {
        public override void Initialize()
        {
            DivisionTable.initialize();
            delcom = IntegerFunctions.VerifyDivision;
            //delgen = IntegerFunctions.GenerateDivision;
            delgen = DivisionTable.GetValue;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}