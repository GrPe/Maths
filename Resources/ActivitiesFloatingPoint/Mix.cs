using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesFloatingPoint
{
    [Activity(Label = "Mix")]
    public class Mix : FloatingPointActivity
    {
        protected override void Initialize()
        {
            int tmp = UniversalFunctions.Rand(1, 100);
            tmp %= 4 + 1;
            DivisionTable.Initialize();
            switch (tmp)
            {
                case 1:
                    DelGen = FloatingPointNumberFunction.GenerateAddition;
                    DelCom = FloatingPointNumberFunction.VerifyAddition;
                    break;
                case 2:
                    DelGen = FloatingPointNumberFunction.GenerateSubtraction;
                    DelCom = FloatingPointNumberFunction.VerifySubtraction;
                    break;
                case 3:
                    DelGen = FloatingPointNumberFunction.GenerateMultiplication;
                    DelCom = FloatingPointNumberFunction.VerifyMultiplication;
                    break;
                case 4:
                    DelGen = DivisionTableOfFloatingPoints.GetValue;
                    DelCom = FloatingPointNumberFunction.VerifyDivision;
                    break;
                default:
                    break;
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ifmix = true;
        }
    }
}