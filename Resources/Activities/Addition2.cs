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
            SetContentView(Resource.Layout.Addition2);

            TextView mTextView = FindViewById<TextView>(Resource.Id.textviewAddition2);
            EditText mEditText = FindViewById<EditText>(Resource.Id.edittextAddition2);
            Button mbutton = FindViewById<Button>(Resource.Id.buttonnext);
            Button showbutton = FindViewById<Button>(Resource.Id./*brak_przycisku*/);
            action(mTextView,mEditText,mbutton,showbutton);
            mbutton.Click += delegate
            {
                action(mTextView, mEditText, mbutton,showbutton);
            };
            showbutton.Click += delegate
            {
                mTextView.Text =Convert.ToString(ShowCorectAnswer(expression.a, expression.b));
            };
        }

        private void action(TextView mTextView,EditText mEditText,Button mbutton,Button showbutton)
        {

            mbutton.Enabled = false;
            showbutton.Enabled = false;
            showbutton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#778899")); //gray
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
                            showbutton.Enabled = false;
                        }
                        if(!BasicMathsFunctions.VerifyAddition(mEditText.Text, expression.a, expression.b))
                        {
                            mTextView.Text = "èle!";
                            mbutton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#00aced")); //blue
                            showbutton.SetBackgroundColor(Android.Graphics.Color.Red); //red
                            mbutton.Enabled = true;
                            showbutton.Enabled = true;
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