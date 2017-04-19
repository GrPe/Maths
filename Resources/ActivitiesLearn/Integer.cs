using Maths.Resources.ActivitiesInteger;
using Android.App;
using Android.OS;
using Android.Widget;

namespace Maths.Resources.ActivitiesLearn
{
    [Activity(Label = "Integer")]
    public class Integer : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

             SetContentView(Resource.Layout.Integer);
            #region button1 - Addition2
            Button button1 = FindViewById<Button>(Resource.Id.buttonIntegerAddiction2);
            button1.Click += delegate
            {
                StartActivity(typeof(Addition2));
            };
            #endregion

            #region button2 - Subtraction2
            Button button2 = FindViewById<Button>(Resource.Id.buttonIntegerSubtraction2);
            button2.Click += delegate
            {
                StartActivity(typeof(Subtraction2));
            };
            #endregion

            #region button3 - Multiplication2
            Button button3 = FindViewById<Button>(Resource.Id.buttonIntegerMultiplication2);
            button3.Click += delegate
            {
                StartActivity(typeof(Multiplication2));
            };
            #endregion

            #region button4 - Division2
            Button button4 = FindViewById<Button>(Resource.Id.buttonIntegerDivision2);
            button4.Click += delegate
            {
                StartActivity(typeof(Division2));
            };
            #endregion

            #region button5 - Mix
            Button button5 = FindViewById<Button>(Resource.Id.buttonIntegerCombinedBasic2);
            button5.Click += delegate
             {
                 StartActivity(typeof(Mix));
             };

            #endregion
        }
    }
}