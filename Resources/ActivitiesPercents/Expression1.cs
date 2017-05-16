using Android.App;
using Android.OS;
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesPercents
{
    [Activity(Label = "Expression1", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Expression1 : PercentsActivity
    {
        protected override void Initialize()
        {
            DelCom = PercentFunction.CompareExpression1;
            DelGen = PercentFunction.GenerateExpression1;
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}