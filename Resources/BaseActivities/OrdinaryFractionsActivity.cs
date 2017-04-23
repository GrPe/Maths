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
using Functionalities;

namespace Maths.Resources.BaseActivities
{
    [Activity(Label = "OrdinaryFractionsActivity")]
    public class OrdinaryFractionsActivity : Activity
    {
        MathsStructures.OridinaryFractions2 expression = new MathsStructures.OridinaryFractions2();
        bool flag = true; //sprawdza czy uzytkownik udzielil prawidlowej odpowiedzi

        internal OrdinaryFractionsFunction.DelCompare delcom;
        internal OrdinaryFractionsFunction.DelGenerate delgen;
        internal bool ifmix = false; //czy aktywna jest activity mix

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.OrdinaryFlactions);

            TextView mTextViewCounter1 = FindViewById<TextView>(Resource.Id.OFCounter1);
            TextView mTextViewDenominator1 = FindViewById<TextView>(Resource.Id.OFDenominator1);
            TextView mTextViewCounter2 = FindViewById<TextView>(Resource.Id.OFCounter2);
            TextView mTextViewDenominator2 = FindViewById<TextView>(Resource.Id.OFDenominator2);
            EditText mEditTextCounter3 = FindViewById<EditText>(Resource.Id.OFCounter3);
            EditText mEditTextDenominator3 = FindViewById<EditText>(Resource.Id.OFDenominator3);
            

        }
    }
}