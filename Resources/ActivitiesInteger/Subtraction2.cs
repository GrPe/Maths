using Android.App;
using Android.OS;
using Functionalities;
using Maths.Resources.BaseActivities;

namespace Maths.Resources.ActivitiesInteger
{
    [Activity(Label = "Subtraction2")]
    public class Subtraction2 : IntegerActivity
    {
        protected override void Initialize()
        {
            DelGen = IntegerFunctions.GenerateSubtraction;
            DelCom = IntegerFunctions.VerifySubtraction;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}