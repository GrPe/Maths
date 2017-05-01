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

namespace Functionalities
{
    class MathsStructures
    { 

      /// <summary>
      /// Przechowuje wyrazenie zlozone z 2 liczb
      /// </summary>
        public struct ValueInt2
        {
            public int a;
            public int b;
            public int correctanswer;
            public string displayvalue;
        }

        /// <summary>
        /// Przechowuje wyrazenie zlozone z 2 liczby double
        /// </summary>
        public struct ValueDecimal2
        {
            public decimal a;
            public decimal b;
            public decimal correctanswer;
            public string displayvalue;
        }

        /// <summary>
        /// Ordinary Fraction Structure
        /// </summary>
        public struct SimpleOrdinaryFractions
        {
            public int counter;
            public int denominator;
        }


        /// <summary>
        /// Expression with 2 Ordinary Fractions
        /// </summary>
        public struct OridinaryFractions2
        {
            public SimpleOrdinaryFractions a;
            public SimpleOrdinaryFractions b;
            public string _operator;
        }


        /// <summary>
        /// Expression of Percents
        /// </summary>
        public struct Percents2
        {
            public int Value;
            public decimal Percent;
            public decimal correctvalue;
            public string displayvalue;
        }
    }
}