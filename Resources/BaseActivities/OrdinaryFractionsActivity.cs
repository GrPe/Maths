using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Functionalities;

namespace Maths.Resources.BaseActivities
{
    [Activity(Label = "OrdinaryFractionsActivity")]
    public class OrdinaryFractionsActivity : Activity
    {
        OrdinaryFractionsFunction.OrdinaryFractions2 expression = new OrdinaryFractionsFunction.OrdinaryFractions2();
        bool flag = true; //sprawdza czy uzytkownik udzielil prawidlowej odpowiedzi
        bool main = true; //czy jest w g��wnej petli aplikacji

        internal OrdinaryFractionsFunction.DelCompare DelCom;
        internal OrdinaryFractionsFunction.DelGenerate DelGen;
        internal bool ifmix = false; //czy aktywna jest activity mix

        TextView mTextViewCounter1;
        TextView mTextViewDenominator1;
        TextView mTextViewCounter2;
        TextView mTextViewDenominator2;
        EditText mEditTextCounter3;
        EditText mEditTextDenominator3;
        TextView mTextViewChar;
        TextView mTextViewEqual;
        TextView mTextViewFractionalMark1;
        TextView mTextViewFractionalMark2;
        Button mButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.OrdinaryFractions);

            //set default components
            mTextViewCounter1 = FindViewById<TextView>(Resource.Id.OFCounter1);
            mTextViewDenominator1 = FindViewById<TextView>(Resource.Id.OFDenominator1);
            mTextViewCounter2 = FindViewById<TextView>(Resource.Id.OFCounter2);
            mTextViewDenominator2 = FindViewById<TextView>(Resource.Id.OFDenominator2);
            mEditTextCounter3 = FindViewById<EditText>(Resource.Id.OFCounter3);
            mEditTextDenominator3 = FindViewById<EditText>(Resource.Id.OFDenominator3);
            mTextViewChar = FindViewById<TextView>(Resource.Id.OFchar);
            mTextViewEqual = FindViewById<TextView>(Resource.Id.OFEqual);
            mTextViewFractionalMark1 = FindViewById<TextView>(Resource.Id.OFFractionalMark1);
            mTextViewFractionalMark2 = FindViewById<TextView>(Resource.Id.OFFractionalMark2);
            mButton = FindViewById<Button>(Resource.Id.OFButtonNext);
            mEditTextCounter3.InputType = Android.Text.InputTypes.ClassNumber;
            mEditTextDenominator3.InputType = Android.Text.InputTypes.ClassNumber;

            Initialize();

            //Main activity
            Action();
            mButton.Click += delegate
            {
                if (main)
                {
                    if (ifmix) Initialize(); // na potrzeby mix
                    if (flag)
                    {
                        Action();
                        main = false;
                    }
                    else
                    {
                        ShowCorrectAnswer();
                        flag = true;
                    }
                }
                else
                {
                    Verify();
                    main = true;
                }
            };
        }

        public virtual void Initialize()
        {
            //IsEmpty
        }

        private void Action()
        {
            TurnOnVisibility();
            main = false;
            mEditTextCounter3.Text = "";
            mEditTextDenominator3.Text = "";
            expression = DelGen();

            //Set an expression
            mTextViewCounter1.Text = Convert.ToString(expression.a.counter);
            mTextViewDenominator1.Text = Convert.ToString(expression.a.denominator);
            mTextViewCounter2.Text = Convert.ToString(expression.b.counter);
            mTextViewDenominator2.Text = Convert.ToString(expression.b.denominator);
            mTextViewChar.Text = expression._operator;
        }

        private void Verify()
        {
            if (DelCom(mEditTextCounter3.Text, mEditTextDenominator3.Text, expression))
            {
                flag = true;
                CorrectAnswer();
            }
            if (!DelCom(mEditTextCounter3.Text, mEditTextDenominator3.Text, expression))
            {
                flag = false;
                WrongAnswer();
            }
        }

        private void CorrectAnswer()
        {
            TurnOffVisibility();
            mTextViewChar.Text = "Dobrze!";
        }

        private void WrongAnswer()
        {
            TurnOffVisibility();
            mTextViewChar.Text = "�le";
        }

        private void ShowCorrectAnswer()
        {
            TurnOffVisibility();
            mTextViewChar.Text = "Poprawna odpowied�:";
            mEditTextCounter3.Text = Convert.ToString(expression.correctanswer.counter);
            mEditTextDenominator3.Text = Convert.ToString(expression.correctanswer.denominator);
        }

        private void TurnOffVisibility()
        {
            mTextViewCounter1.Visibility = ViewStates.Gone;
            mTextViewCounter2.Visibility = ViewStates.Gone;
            mTextViewDenominator1.Visibility = ViewStates.Gone;
            mTextViewDenominator2.Visibility = ViewStates.Gone;
            mTextViewEqual.Visibility = ViewStates.Gone;
            mTextViewFractionalMark1.Visibility = ViewStates.Gone;
            mTextViewFractionalMark2.Visibility = ViewStates.Gone;
        }

        private void TurnOnVisibility()
        {
            mTextViewCounter1.Visibility = ViewStates.Visible;
            mTextViewCounter2.Visibility = ViewStates.Visible;
            mTextViewDenominator1.Visibility = ViewStates.Visible;
            mTextViewDenominator2.Visibility = ViewStates.Visible;
            mTextViewEqual.Visibility = ViewStates.Visible;
            mTextViewFractionalMark1.Visibility = ViewStates.Visible;
            mTextViewFractionalMark2.Visibility = ViewStates.Visible;
        }

    }
}