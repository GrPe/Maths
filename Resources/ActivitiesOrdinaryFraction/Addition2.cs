using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesOrdinaryFraction
{
    [Activity(Label = "Addition2", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Addition2 : OrdinaryFractionsActivity
    {
        public override void Initialize()
        {
            DelCom = OrdinaryFractionsFunction.VerifyAswers;
            DelGen = OrdinaryFractionsFunction.GenerateAddition;
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}