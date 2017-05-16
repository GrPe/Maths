using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesOrdinaryFraction
{
    [Activity(Label = "Multiplication2")]
    public class Multiplication2 : OrdinaryFractionsActivity
    {
        public override void Initialize()
        {
            DelGen = OrdinaryFractionsFunction.GenerateMultiplication;
            DelCom = OrdinaryFractionsFunction.VerifyAswers;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}