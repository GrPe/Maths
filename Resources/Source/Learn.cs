using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maths.Resources.Activities;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Maths.Resources.Source
{
    [Activity(Label = "Learn")]
    public class Learn : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
             SetContentView(Resource.Layout.Learn);
            #region button1 - Addition2
            Button button1 = FindViewById<Button>(Resource.Id.buttonAddiction2);
            button1.Click += delegate
            {
                StartActivity(typeof(Addition2));
            };
            #endregion

            #region button2 - Subtraction2
            Button button2 = FindViewById<Button>(Resource.Id.buttonSubtraction2);
            button2.Click += delegate
            {
                StartActivity(typeof(Subtraction2));
            };
            #endregion

            #region button3 - Multiplication2
            Button button3 = FindViewById<Button>(Resource.Id.buttonMultiplication2);
            button3.Click += delegate
            {
                StartActivity(typeof(Multiplication2));
            };
            #endregion
        }
    }
}