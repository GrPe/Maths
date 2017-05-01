using Android.App;
using Android.OS;
using Functionalities;
using Maths.Resources.BaseActivities;

namespace Maths.Resources.ActivitiesInteger
{
    [Activity(Label = "Division2")]
    public class Division2 : IntegerActivity
    {
        protected override void Initialize()
        {
            DivisionTable.Initialize();
            DelCom = IntegerFunctions.VerifyDivision;
            DelGen = DivisionTable.GetValue;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}