using Android.App;
using Android.OS;
using Android.Widget;
using Maths.Resources.ActivitiesPercents;

namespace Maths.Resources.ActivitiesLearn
{
    [Activity(Label = "Percents")]
    public class Percents : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Percents);

            #region button1 - Percent with from number
            Button button1 = FindViewById<Button>(Resource.Id.buttonPercentsExp1);
            button1.Click += delegate
             {
                 StartActivity(typeof(Expression1));
             };
            #endregion
        }
    }
}