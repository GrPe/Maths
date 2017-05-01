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
    [Activity(Label = "PercentsActivity")]
    public class PercentsActivity : Activity
    {
        //initialize components
        MathsStructures.Percents2 expression = new MathsStructures.Percents2();
        bool flag = true;
        TextView mTextView;
        EditText mEditText;
        Button mButton;

        //initialize  variable to be used by derived class
        internal PercentFunction.DelCompare DelCom;
        internal PercentFunction.DelGenerate DelGen;
        internal bool ifmix = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.View_BaseMaths);

            //set default components
            mTextView = FindViewById<TextView>(Resource.Id.textview_View_BaseMahs);
            mEditText = FindViewById<EditText>(Resource.Id.edittext_View_BaseMaths);
            mButton = FindViewById<Button>(Resource.Id.button_View_BaseMaths_Next);
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
                 if(i.Event.Action == KeyEventActions.Down && i.KeyCode == Keycode.Enter)
                 {
                     if(mEditText.Text!="")
                     {
                         mButton.SetBackgroundColor(Android.Graphics.Color.ParseColor("#00aced"));//blue
                         mButton.Enabled = true;
                         if (DelCom(mEditText.Text, expression))
                         {
                             mTextView.Text = "Dobrze!";
                             flag = true;
                         }
                         if(!DelCom(mEditText.Text,expression))
                         {
                             mTextView.Text = "�le!";
                             flag = false;
                         }
                         i.Handled = true;
                     }
                 }
             };
        }

        void ShowCorrectAnswer()
        {
            mTextView.Text = "Poprawna odpowied�:";
            mEditText.Text = Convert.ToString(expression.correctvalue);
            flag = true;
        }
    }
}