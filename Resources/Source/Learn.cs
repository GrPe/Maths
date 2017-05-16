using Android.App;
using Android.OS;
using Android.Widget;
using Maths.Resources.ActivitiesLearn;

namespace Maths.Resources.Source
{
    [Activity(Label = "Learn", Theme = "@android:style/Theme.DeviceDefault.DialogWhenLarge.NoActionBar")]
    public class Learn : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Learn);

            #region button1 - Integer
            Button button1 = FindViewById<Button>(Resource.Id.buttonIntegerLearn);
            button1.Click += delegate
             {
                 StartActivity(typeof(Integer));
             };
            #endregion

            #region button2 - Floating Point
            Button button2 = FindViewById<Button>(Resource.Id.buttonFloatingPointLearn);
            button2.Click += delegate
            {
                StartActivity(typeof(FloatingPoint));
            };
            #endregion

            #region button3 - Ordinary Fractions
            Button button3 = FindViewById<Button>(Resource.Id.buttonOrdinaryFractions);
            button3.Click += delegate
            {
                StartActivity(typeof(OrdinaryFractions));
            };
            #endregion

            #region button4 - Percents
            Button button4 = FindViewById<Button>(Resource.Id.buttonPercents);
            button4.Click += delegate
             {
                 StartActivity(typeof(Percents));
             };
            #endregion

        }
    }
}