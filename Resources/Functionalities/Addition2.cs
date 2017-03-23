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

            TextView mTextView = FindViewById<TextView>(Resource.Id.textView1); //Rename!!!
            EditText mEditText = FindViewById<EditText>(Resource.Id.editText); //Rename !!!
            
                exp expression = GenerateExpression();
                mTextView.Text = expression.retvalue;

       
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

    }
}