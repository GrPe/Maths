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
        private List<Activity> Activities = new List<Activity>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Learn);
        }

        private void Set()
        {
            //Activities.Add()
        }
    }
}