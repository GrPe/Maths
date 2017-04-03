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

namespace Maths.Resources.Activities
{
    [Activity(Label = "Addition2")]
    public class Addition2 : Activity
    {
        BasicMathsStructures.ValueInt2 expression = new BasicMathsStructures.ValueInt2();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.View_BaseMaths);

            TextView mTextView = FindViewById<TextView>(Resource.Id.textview_View_BaseMahs);
            EditText mEditText = FindViewById<EditText>(Resource.Id.edittext_View_BaseMaths);
            Button mbutton = FindViewById<Button>(Resource.Id.button_View_BaseMaths_Next);
            action(mTextView,mEditText,mbutton);
            bool flag = true;
            mbutton.Click += delegate
            {
                if (flag) action(mTextView, mEditText, mbutton);
                else /*code false answer*/
            };
        }

        private void action(TextView mTextView,EditText mEditText,Button mbutton)
        {

            mbutton.Enabled = false;
            mbutton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#778899")); //gray
            mEditText.Text = "";
            expression = GenerateExpression();
            mTextView.Text = expression.displayvalue;
            mEditText.KeyPress += (object sender, View.KeyEventArgs i) =>
            {
                i.Handled = false;
                if (i.Event.Action == KeyEventActions.Down && i.KeyCode == Keycode.Enter)
                {
                    if (mEditText.Text != "")
                    {
                        if (BasicMathsFunctions.VerifyAddition(mEditText.Text, expression.a, expression.b))
                        {
                            //mTextView.TextColors = Android.Graphics.Color.Green;
                            mTextView.Text = "Dobrze!";
                            mbutton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#00aced")); //blue
                            mbutton.Enabled = true;
                        }
                        if(!BasicMathsFunctions.VerifyAddition(mEditText.Text, expression.a, expression.b))
                        {
                            mTextView.Text = "èle!";
                            mbutton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#00aced")); //blue
                            mbutton.Enabled = true;
                        }
                        i.Handled = true;
                    }
                }
            };
        }

        /// <summary>
        /// Generuje dzialanie do postawienia w polu mTextView.Text;
        /// </summary>
        /// <returns></returns>
        private BasicMathsStructures.ValueInt2 GenerateExpression()
        {
            var ret = new BasicMathsStructures.ValueInt2();
            ret.a = RandValue.Rand(1, 9);
            ret.b = RandValue.Rand(1, 9);
            ret.displayvalue = Convert.ToString(ret.a) + " + " + Convert.ToString(ret.b) + " =";
            return ret;
        }

        private int ShowCorectAnswer(int a, int b)
        {
            return a+b;
        }

    }
}