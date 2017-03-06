using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Maths.Resources.Source;

namespace Maths
{
    [Activity(Label = "Maths", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            #region LearnMenuStart
            Button mbuttonlearn = FindViewById<Button>(Resource.Id.buttonlearn);
            mbuttonlearn.Click += delegate
             {
                 StartActivity(typeof(Learn));
             };
            #endregion

            #region Stats
            Button mbuttonstatistics = FindViewById<Button>(Resource.Id.buttonstatistics);
            mbuttonstatistics.Click += delegate
            {
                //
            };
            #endregion

            #region Info
            Button mbuttoninfo = FindViewById<Button>(Resource.Id.buttoninfo);
            mbuttoninfo.Click += delegate
            {
                StartActivity(typeof(Aboutinfo));
            };
            #endregion

            #region Exit an app
            Button mbuttonexit = FindViewById<Button>(Resource.Id.buttonexit);
            mbuttonexit.Click += delegate
            {
                System.Environment.Exit(0);
            };
            #endregion
        }
    }
}

