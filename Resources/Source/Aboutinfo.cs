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
{//??
    public class Aboutinfo : Activity
    {
        public void OpenInfo(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Aboutinfo);


        }
    }
}