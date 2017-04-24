using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Functionalities;

namespace Maths.Resources.BaseActivities
{
    [Activity(Label = "FloatingPointActivity")]
    public class FloatingPointActivity : Activity
    {
        MathsStructures.ValueDouble2 expression = new MathsStructures.ValueDouble2();
        bool flag = true; //sprawdza czy uzytkownik udzielil prawidlowej odpowiedzi

        internal FloatingPointNumberFunction.DelCompare delcom;
        internal FloatingPointNumberFunction.DelGenerate delgen;
        internal bool ifmix = false; //czy aktywna jest activity mix

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.View_BaseMaths);

            TextView mTextView = FindViewById<TextView>(Resource.Id.textview_View_BaseMahs);
            EditText mEditText = FindViewById<EditText>(Resource.Id.edittext_View_BaseMaths);
            Button mButton = FindViewById<Button>(Resource.Id.button_View_BaseMaths_Next);
            Initialize();

            Action(mTextView, mEditText, mButton);
            mButton.Click += delegate
            {
                if (ifmix) Initialize(); //Na potrzeby activity mix
                if (flag) Action(mTextView, mEditText, mButton);
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