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
    [Activity(Label = "IntegerActivity")]
    public class IntegerActivity : Activity
    {
        BasicMathsStructures.ValueInt2 expression = new BasicMathsStructures.ValueInt2();
        bool flag = true; //sprawdza czy uzytkownik udzielil prawidlowej odpowiedzi


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.View_BaseMaths);

            TextView mTextView = FindViewById<TextView>(Resource.Id.textview_View_BaseMahs);
            EditText mEditText = FindViewById<EditText>(Resource.Id.edittext_View_BaseMaths);
            Button mbutton = FindViewById<Button>(Resource.Id.button_View_BaseMaths_Next);

            Action(mTextView, mEditText, mbutton);
            mbutton.Click += delegate
            {
                if (flag) Action(mTextView, mEditText, mbutton);
                else FalseAnswer(mTextView, mEditText);
            };
        }

        protected void InitializeCompare()
        {

        }

        private void Action(TextView mTextView, EditText mEditText, Button mbutton) //obsluga wprowadzania danych przez uzytkownika
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
                        if (IntegerFunctions.DelCompare(mEditText.Text, expression))
                        {
                            mTextView.Text = "Dobrze!";
                            mbutton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#00aced")); //blue
                            mbutton.Enabled = true;
                            flag = true;
                        }
                        if (!IntegerFunctions.DelCompare(mEditText.Text, expression))
                        {
                            mTextView.Text = "èle!";
                            mbutton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#00aced")); //blue
                            mbutton.Enabled = true;
                            flag = false;
                        }
                        i.Handled = true;
                    }
                }
            };
        }
    }
}