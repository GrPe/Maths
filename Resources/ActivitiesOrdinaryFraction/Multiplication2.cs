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
    [Activity(Label = "Multiplication2")]
    public class Multiplication2 : OrdinaryFractionsActivity
    {
        public override void Inizalize()
        {
            Delgen = OrdinaryFractionsFunction.GenerateMultiplication;
            Delcom = OrdinaryFractionsFunction.VerifyAswers;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}