using Android.App;
using Android.OS;
using Functionalities;
using Maths.Resources.BaseActivities;

namespace Maths.Resources.ActivitiesInteger
{
    [Activity(Label = "Addition2", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Addition2 : IntegerActivity
    {
        protected override void Initialize()
        {
            DelCom = IntegerFunctions.VerifyAddition;
            DelGen = IntegerFunctions.GenerateAddition;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}