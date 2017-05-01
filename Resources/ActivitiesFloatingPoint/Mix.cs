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
                    delgen = FloatingPointNumberFunction.GenerateAddition;
                    DelCom = FloatingPointNumberFunction.VerifyAddition;
                    break;
                case 2:
                    delgen = FloatingPointNumberFunction.GenerateSubtraction;
                    DelCom = FloatingPointNumberFunction.VerifySubtraction;
                    break;
                case 3:
                    delgen = FloatingPointNumberFunction.GenerateMultiplication;
                    DelCom = FloatingPointNumberFunction.VerifyMultiplication;
                    break;
                case 4:
                    delgen = DivisionTableOfFloatingPoints.GetValue;
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