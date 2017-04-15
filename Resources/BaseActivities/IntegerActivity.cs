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
        MathsStructures.ValueInt2 expression = new MathsStructures.ValueInt2();
        bool flag = true; //sprawdza czy uzytkownik udzielil prawidlowej odpowiedzi

        internal IntegerFunctions.DelCompare delcom;
        internal IntegerFunctions.DelGenerate delgen;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.View_BaseMaths);

            TextView mTextView = FindViewById<TextView>(Resource.Id.textview_View_BaseMahs);
            EditText mEditText = FindViewById<EditText>(Resource.Id.edittext_View_BaseMaths);
            Button mbutton = FindViewById<Button>(Resource.Id.button_View_BaseMaths_Next);
            Initialize();

            Action(mTextView, mEditText, mbutton);
            mbutton.Click += delegate
            {
                if (flag) Action(mTextView, mEditText, mbutton);
                else FalseAnswer(mTextView, mEditText);
            };
        }

        public virtual void Initialize()
        {
            //IsEmpty
        }

        private void Action(TextView mTextView, EditText mEditText, Button mbutton) //obsluga wprowadzania danych przez uzytkownika
        {
            mbutton.Enabled = false;
            mbutton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#778899")); //gray
            mEditText.Text = "";
            expression = delgen();
            mTextView.Text = expression.displayvalue;
            mEditText.KeyPress += (object sender, View.KeyEventArgs i) =>
            {
                i.Handled = false;
                if (i.Event.Action == KeyEventActions.Down && i.KeyCode == Keycode.Enter)
                {
                    if (mEditText.Text != "")
                    {
                        if (delcom(mEditText.Text, expression))
                        {
                            mTextView.Text = "Dobrze!";
                            mbutton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#00aced")); //blue
                            mbutton.Enabled = true;
                            flag = true;
                        }
                        if (!delcom(mEditText.Text, expression))
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

        //wyswietla prawidlowa odpowiedz gdy user popelnil blad
        private void FalseAnswer(TextView mTextView, EditText mEditText)
        {
            mTextView.Text = "Poprawna odpowiedü:";
            mEditText.Text = Convert.ToString(expression.correctanswer);
            flag = true;
        }
    }
}