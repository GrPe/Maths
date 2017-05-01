using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesInteger
{
    [Activity(Label = "Mix")]
    public class Mix : IntegerActivity
    {
        protected override void Initialize()
        {
            int tmp = UniversalFunctions.Rand(1, 100);
            tmp %= 4 +1;
            DivisionTable.Initialize();
            switch (tmp)
            {
                case 1:
                    DelGen = IntegerFunctions.GenerateAddition;
                    DelCom = IntegerFunctions.VerifyAddition;
                    break;
                case 2:
                    DelGen = IntegerFunctions.GenerateSubtraction;
                    DelCom = IntegerFunctions.VerifySubtraction;
                    break;
                case 3:
                    DelGen = IntegerFunctions.GenerateMultiplication;
                    DelCom = IntegerFunctions.VerifyMultiplication;
                    break;
                case 4:
                    DelGen = DivisionTable.GetValue;
                    DelCom = IntegerFunctions.VerifyDivision;
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