using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Functionalities;

namespace Maths.Resources.BaseActivities
{
    [Activity(Label = "IntegerActivity")]
    public class IntegerActivity : Activity
    {
        //initialize components
        MathsStructures.ValueInt2 expression = new MathsStructures.ValueInt2();
        bool flag = true; //sprawdza czy uzytkownik udzielil prawidlowej odpowiedzi
        TextView mTextView;
        EditText mEditText;
        Button mButton;

        //initialize  variable to be used by derived class
        internal IntegerFunctions.DelCompare DelCom;
        internal IntegerFunctions.DelGenerate DelGen;
        internal bool ifmix = false; //czy aktywna jest activity mix

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.View_BaseMaths);

            //set default components
            mTextView = FindViewById<TextView>(Resource.Id.textview_View_BaseMahs);
            mEditText = FindViewById<EditText>(Resource.Id.edittext_View_BaseMaths);
            mButton = FindViewById<Button>(Resource.Id.button_View_BaseMaths_Next);
            mEditText.InputType = Android.Text.InputTypes.ClassNumber;
            Initialize();

            //Main activity
            Action();
            mButton.Click += delegate
            {
                if (ifmix) Initialize(); //Na potrzeby activity mix
                if (flag) Action();
                else ShowCorrectAnswer();
            };
        }

        protected virtual void Initialize()
        {
            //IsEmpty
        }

        void Action()
        {
            mButton.Enabled = false;
            mButton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#778899")); //gray
            mEditText.Text = "";
            expression = DelGen();
            mTextView.Text = expression.displayvalue;
            mEditText.KeyPress += (object sender, View.KeyEventArgs i) =>
            {
                i.Handled = false;
                if (i.Event.Action == KeyEventActions.Down && i.KeyCode == Keycode.Enter)
                {
                    if (mEditText.Text != "")
                    {
                        mButton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#00aced")); //blue
                        mButton.Enabled = true;
                        if (DelCom(mEditText.Text, expression))
                        {
                            mTextView.Text = "Dobrze!";
                            flag = true;
                        }
                        if (!DelCom(mEditText.Text, expression))
                        {
                            mTextView.Text = "èle!";
                            flag = false;
                        }
                        i.Handled = true;
                    }
                }
            };
        }
        
        private void ShowCorrectAnswer()
        {
            mTextView.Text = "Poprawna odpowiedü:";
            mEditText.Text = Convert.ToString(expression.correctanswer);
            flag = true;
        }
    }
}