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
        OrdinaryFractionsFunction.OridinaryFractions2 expression = new OrdinaryFractionsFunction.OridinaryFractions2();
        bool flag = true; //sprawdza czy uzytkownik udzielil prawidlowej odpowiedzi
        bool main = true; //czy jest w g≥Ûwnej peltli aplikacji

        internal OrdinaryFractionsFunction.DelCompare Delcom;
        internal OrdinaryFractionsFunction.DelGenerate Delgen;
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

            Inizalize();

            //Main activity
            Action();
            if(main)
            {
                mButton.Click += delegate
                {
                    if (ifmix) Inizalize(); //Na potrzeby activity mix
                    if (flag) Action();
                    else ShowCorrectAnswer();
                };
            }
        }

        public virtual void Inizalize()
        {
            //IsEmpty
        }

        private void Action()
        {
            TurnOnVisibility();
            //bool checkcounter = false;
            //bool checkdenominator = false;
            main = false;

           // mButton.Enabled = false;
           // mButton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#778899")); //gray
            mEditTextCounter3.Text = "";
            mEditTextDenominator3.Text = "";
            expression = Delgen();

            //Set an expression
            mTextViewCounter1.Text = Convert.ToString(expression.a.counter);
            mTextViewDenominator1.Text = Convert.ToString(expression.a.denominator);
            mTextViewCounter2.Text = Convert.ToString(expression.b.counter);
            mTextViewDenominator2.Text = Convert.ToString(expression.b.denominator);
            mTextViewChar.Text = expression._operator;

            //Both textfield are full
            //mEditTextCounter3.KeyPress += (object sender, View.KeyEventArgs i) =>
            //{
            //    i.Handled = false;
            //    if (i.Event.Action == KeyEventActions.Down && i.KeyCode == Keycode.Enter)
            //    {
            //       // checkcounter = true;
            //        i.Handled = true;
            //    }

            //};
            //mEditTextDenominator3.KeyPress += (object sender, View.KeyEventArgs i) =>
            //{
            //    i.Handled = false;
            //    if (i.Event.Action == KeyEventActions.Down && i.KeyCode == Keycode.Enter)
            //    {
            //       // checkdenominator = true;
            //        i.Handled = true;
            //    }
            //};

            ////enabled button - verification
            //if (checkcounter && checkdenominator
            //    //!mEditTextCounter3.Text.Equals("") &&
            //    //!mEditTextDenominator3.Text.Equals("")
            //    ) mButton.Enabled = true;

            //mButton.Enabled = true;

            //activate verification
            mButton.Click += delegate
            {
                if (!mEditTextCounter3.Text.Equals("") &&
                !mEditTextDenominator3.Text.Equals(""))
                {
                    Verify();
                    main = true;
                }
            };
        }

        private void Verify()
        {
            if (Delcom(mEditTextCounter3.Text, mEditTextDenominator3.Text, expression))
            {
                flag = true;
                CorrectAnswer();
            }
            if (!Delcom(mEditTextCounter3.Text, mEditTextDenominator3.Text, expression))
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
            mTextViewChar.Text = "èle";
        }

        private void ShowCorrectAnswer()
        {
            TurnOffVisibility();
            mTextViewChar.Text = "Poprawna odpowiedü:";
            // mEditTextCounter3.Text = Convert.ToString(expression.)
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