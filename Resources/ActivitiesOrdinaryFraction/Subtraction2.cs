using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesOrdinaryFraction
{
    [Activity(Label = "Subtraction2")]
    public class Subtraction2 : OrdinaryFractionsActivity
    {
        public override void Inizalize()
        {
            Delcom = OrdinaryFractionsFunction.VerifyAswers;
            Delgen = OrdinaryFractionsFunction.GenerateSubtraction2;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}