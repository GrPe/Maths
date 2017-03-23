using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maths.Resources.Functionalities;

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
        private Dictionary<int,Button> buttons = new Dictionary<int,Button>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
             SetContentView(Resource.Layout.Learn);
            Set();
            buttons[1].Click += delegate
             {
                 StartActivity(typeof(Addition2));
             };
        }


        private void Set()
        {
            Button tmpbutton = FindViewById<Button>(Resource.Id.buttonAddiction2);
            buttons.Add(1,tmpbutton);
        }
    }
}