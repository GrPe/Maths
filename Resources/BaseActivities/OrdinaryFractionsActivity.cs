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
        TextView mTextViewCounter1;
        TextView mTextViewDenominator1;
        TextView mTextViewCounter2;
        TextView mTextViewDenominator2;
        EditText mEditTextCounter3;
        EditText mEditTextDenominator3;
        TextView mTextViewChar;
        Button mButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.OrdinaryFractions);

            mTextViewCounter1 = FindViewById<TextView>(Resource.Id.OFCounter1);
            mTextViewDenominator1 = FindViewById<TextView>(Resource.Id.OFDenominator1);
            mTextViewCounter2 = FindViewById<TextView>(Resource.Id.OFCounter2);
            mTextViewDenominator2 = FindViewById<TextView>(Resource.Id.OFDenominator2);
            mEditTextCounter3 = FindViewById<EditText>(Resource.Id.OFCounter3);
            mEditTextDenominator3 = FindViewById<EditText>(Resource.Id.OFDenominator3);
            mTextViewChar = FindViewById<TextView>(Resource.Id.OFchar);
            mButton = FindViewById<Button>(Resource.Id.OFButtonNext);

            Inizalize();

            //Action
            mButton.Click += delegate
             {
                 if (ifmix) Inizalize(); //Na potrzeby activity mix
                 //if Action
             };
            

        }

        public virtual void Inizalize()
        {
            //IsEmpty
        }

        private void Action()
        {
            mButton.Enabled = false;
            mButton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#778899")); //gray
            mEditTextCounter3.Text = "";
            mEditTextDenominator3.Text = "";
            expression = delgen();

            //Set an expression
            mTextViewCounter1.Text = Convert.ToString(expression.a.counter);
            mTextViewDenominator1.Text = Convert.ToString(expression.a.denominator);
            mTextViewCounter2.Text = Convert.ToString(expression.b.counter);
            mTextViewDenominator2.Text = Convert.ToString(expression.b.denominator);
            mTextViewChar.Text = expression._operator;

            

        }
    }
}