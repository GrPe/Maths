using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesOrdinaryFraction
{
    [Activity(Label = "DIvision2", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Division2 : OrdinaryFractionsActivity
    {
        public override void Initialize()
        {
            DelCom = OrdinaryFractionsFunction.VerifyAswers;
            DelGen = OrdinaryFractionsFunction.GenerateDivision;
        }
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}