using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesOrdinaryFraction
{
    [Activity(Label = "Mix")]
    public class Mix : OrdinaryFractionsActivity
    {
        public override void Initialize()
        {
            int tmp = UniversalFunctions.Rand(1, 100);
            tmp %= 4 + 1;
            DivisionTable.Initialize();
            switch (tmp)
            {
                case 1:
                    DelGen = OrdinaryFractionsFunction.GenerateAddition;
                    DelCom = OrdinaryFractionsFunction.VerifyAswers;
                    break;
                case 2:
                    DelGen = OrdinaryFractionsFunction.GenerateSubtraction;
                    DelCom = OrdinaryFractionsFunction.VerifyAswers;
                    break;
                case 3:
                    DelGen = OrdinaryFractionsFunction.GenerateMultiplication;
                    DelCom = OrdinaryFractionsFunction.VerifyAswers;
                    break;
                case 4:
                    DelGen = OrdinaryFractionsFunction.GenerateDivision;
                    DelCom = OrdinaryFractionsFunction.VerifyAswers;
                    break;
                default:
                    break;
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}