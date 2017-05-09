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
using Maths.Resources.BaseActivities;
using Functionalities;

namespace Maths.Resources.ActivitiesOrdinaryFraction
{
    [Activity(Label = "Addition2")]
    public class Addition2 : OrdinaryFractionsActivity
    {
        public override void Inizalize()
        {
            Delcom = OrdinaryFractionsFunction.VerifyAddition;
            Delgen = OrdinaryFractionsFunction.GenerateAddition;
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}