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

namespace Maths.Resources.Functionalities
{
    [Activity(Label = "Addition2")]
    public class Addition2 : Activity
    {
        //struktura przechowujaca dane wylosowanego dzialania
        private struct exp 
        {
            public int a;
            public int b;
            public string retvalue;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Addition2);

            TextView mTextView = FindViewById<TextView>(Resource.Id.textviewAddition2);
            EditText mEditText = FindViewById<EditText>(Resource.Id.edittextAddition2);
            Button mbutton = FindViewById<Button>(Resource.Id.buttonaddition2next);
            action(mTextView,mEditText,mbutton);
            mbutton.Click += delegate
            {
                action(mTextView, mEditText, mbutton);
            };
        }

        private void action(TextView mTextView,EditText mEditText,Button mbutton)
        {
            mbutton.Enabled = false;
            mEditText.Text = "";
            exp expression = GenerateExpression();
            mTextView.Text = expression.retvalue;
            mEditText.KeyPress += (object sender, View.KeyEventArgs i) =>
            {
                i.Handled = false;
                if (i.Event.Action == KeyEventActions.Down && i.KeyCode == Keycode.Enter)
                {
                    if (mEditText.Text != "")
                    {
                        mTextView.Text = Convert.ToString(Verify(mEditText.Text, expression));
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
        private exp GenerateExpression()
        {
            exp ret = new exp();
            ret.a = RandValue.Rand(1, 9);
            ret.b = RandValue.Rand(1, 9);
            ret.retvalue = Convert.ToString(ret.a) + " + " + Convert.ToString(ret.b) + " =";
            return ret;
        }

        /// <summary>
        /// Verify correctness of reply
        /// </summary>
        /// <param name="value">Value from user</param>
        /// <param name="original">Original numbers</param>
        /// <returns></returns>
        private bool Verify(string value, exp original)
        {
            int tmp = Convert.ToInt32(value);
            if ((original.a + original.b) == tmp) return true;
            else return false;
        }

    }
}