using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesInteger
{
    [Activity(Label = "Mix")]
    public class Mix : IntegerActivity
    {
        public override void Initialize()
        {
            int tmp = UniversalFunctions.Rand(1, 100);
            tmp %= 4 +1;
            DivisionTable.Initialize();
            switch (tmp)
            {
                case 1:
                    delgen = IntegerFunctions.GenerateAddition;
                    delcom = IntegerFunctions.VerifyAddition;
                    break;
                case 2:
                    delgen = IntegerFunctions.GenerateSubtraction;
                    delcom = IntegerFunctions.VerifySubtraction;
                    break;
                case 3:
                    delgen = IntegerFunctions.GenerateMultiplication;
                    delcom = IntegerFunctions.VerifyMultiplication;
                    break;
                case 4:
                    delgen = DivisionTable.GetValue;
                    delcom = IntegerFunctions.VerifyDivision;
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