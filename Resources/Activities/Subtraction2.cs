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
    [Activity(Label = "Subtraction2")]
    public class Subtraction2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Addition2);

            TextView mTextView = FindViewById<TextView>(Resource.Id.textviewAddition2);
            EditText mEditText = FindViewById<EditText>(Resource.Id.edittextAddition2);
            Button mbutton = FindViewById<Button>(Resource.Id.buttonaddition2next);
            action(mTextView, mEditText, mbutton);
            mbutton.Click += delegate
            {
                action(mTextView, mEditText, mbutton);
            };
        }

        private void action(TextView mTextView, EditText mEditText, Button mbutton)
        {

            mbutton.Enabled = false;
            mEditText.Text = "";
            var expression = GenerateExpression();
            mTextView.Text = expression.displayvalue;
            mEditText.KeyPress += (object sender, View.KeyEventArgs i) =>
            {
                i.Handled = false;
                if (i.Event.Action == KeyEventActions.Down && i.KeyCode == Keycode.Enter)
                {
                    if (mEditText.Text != "")
                    {
                        mTextView.Text = Convert.ToString(BasicMathsFunctions.VerifySubtraction(mEditText.Text, expression.a,expression.b));
                        mbutton.Enabled = true;
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
            ret.b = RandValue.Rand(1, ret.a);
            ret.displayvalue = Convert.ToString(ret.a) + " - " + Convert.ToString(ret.b) + " =";
            return ret;
        }
    }
}