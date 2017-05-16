using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesFloatingPoint
{
    [Activity(Label = "Division2", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Division2 : FloatingPointActivity
    {
        protected override void Initialize()
        {
            DivisionTableOfFloatingPoints.Initialize();
            DelGen = DivisionTableOfFloatingPoints.GetValue;
            DelCom = FloatingPointNumberFunction.VerifyDivision;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}