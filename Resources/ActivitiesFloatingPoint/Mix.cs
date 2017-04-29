using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesFloatingPoint
{
    [Activity(Label = "Mix")]
    public class Mix : FloatingPointActivity
    {
        public override void Initialize()
        {
            int tmp = UniversalFunctions.Rand(1, 100);
            tmp %= 4 + 1;
            DivisionTable.Initialize();
            switch (tmp)
            {
                case 1:
                    delgen = FloatingPointNumberFunction.GenerateAddition;
                    delcom = FloatingPointNumberFunction.VerifyAddition;
                    break;
                case 2:
                    delgen = FloatingPointNumberFunction.GenerateSubtraction;
                    delcom = FloatingPointNumberFunction.VerifySubtraction;
                    break;
                case 3:
                    delgen = FloatingPointNumberFunction.GenerateMultiplication;
                    delcom = FloatingPointNumberFunction.VerifyMultiplication;
                    break;
                case 4:
                    delgen = DivisionTableOfFloatingPoints.GetValue;
                    delcom = FloatingPointNumberFunction.VerifyDivision;
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