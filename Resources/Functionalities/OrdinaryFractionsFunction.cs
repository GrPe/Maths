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
    static class OrdinaryFractionsFunction
    {
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
            public SimpleOrdinaryFractions correctanswer;
            public string _operator;
        }

        public delegate bool DelCompare(string valuecounter, string valuedenominator, OridinaryFractions2 exp);

        /// <summary>
        /// Verify correctness of Addition Ordinary Fractions
        /// </summary>
        /// <param name="valuecounter">counter of result</param>
        /// <param name="valuedenominator">denominator of result</param>
        /// <param name="exp">original value</param>
        /// <returns></returns>
        public static bool VerifyAddition(string valuecounter, string valuedenominator, OridinaryFractions2 exp)
        {
           // SimpleOrdinaryFractions result;

            //result.denominator = UniversalFunctions.LCM(exp.a.denominator, exp.b.denominator);
            //int tmpCounterA = exp.a.counter * (result.denominator / exp.a.denominator);
            //int tmpCounterB = exp.b.counter * (result.denominator / exp.b.denominator);

            //result.counter = tmpCounterA + tmpCounterB;
            //result.counter /= UniversalFunctions.GCD(result.counter, result.denominator);
            //result.denominator /= UniversalFunctions.GCD(result.counter, result.denominator);

            return (valuecounter.Equals(Convert.ToString(exp.correctanswer.counter)) &&
                valuedenominator.Equals(Convert.ToString(exp.correctanswer.denominator)));
        }


        public delegate OridinaryFractions2 DelGenerate();


        /// <summary>
        /// Return an expression of two Ordinary Fractions
        /// </summary>
        /// <returns></returns>
        public static OridinaryFractions2 GenerateAddition()
        {
            OridinaryFractions2 ret;
            ret.a.counter = UniversalFunctions.Rand(1, 8);
            ret.a.denominator = UniversalFunctions.Rand(1, 9);
            ret.b.counter = UniversalFunctions.Rand(1, 8);
            ret.b.denominator = UniversalFunctions.Rand(1, 9);
            ret._operator = "+";

            ret.correctanswer.denominator = UniversalFunctions.LCM(ret.a.denominator, ret.b.denominator);
            int tmpCounterA = ret.a.counter * (ret.correctanswer.denominator / ret.a.denominator);
            int tmpCounterB = ret.b.counter * (ret.correctanswer.denominator / ret.b.denominator);

            ret.correctanswer.counter = tmpCounterA + tmpCounterB;
            ret.correctanswer.counter /= UniversalFunctions.GCD(ret.correctanswer.counter, ret.correctanswer.denominator);
            ret.correctanswer.denominator /= UniversalFunctions.GCD(ret.correctanswer.counter, ret.correctanswer.denominator);

            return ret;
        }


    }
}