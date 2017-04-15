using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            #region button1 - Integer
            Button button1 = FindViewById<Button>(Resource.Id.buttonIntegerLearn);
            button1.Click += delegate
             {
                 StartActivity(typeof(Integer));
             };
            #endregion

        }
    }
}