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
using static Functionalities.MathsStructures;

namespace Functionalities
{
    static class OrdinaryFractionsFunction
    {
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
            SimpleOrdinaryFractions result;

            result.denominator = UniversalFunctions.LCM(exp.a.denominator, exp.b.denominator);
            int tmpcountera = exp.a.counter * (result.denominator / exp.a.counter);
            int tmpcounterb = exp.b.counter * (result.denominator / exp.b.counter);

            result.counter = tmpcountera + tmpcounterb;

            result.counter /= UniversalFunctions.GCD(result.counter, result.denominator);
            result.denominator /= UniversalFunctions.GCD(result.counter, result.denominator);

            return (Convert.ToInt32(valuecounter) == result.counter &&
                Convert.ToInt32(valuedenominator) == result.denominator);
        }


        public delegate OridinaryFractions2 DelGenerate();


        /// <summary>
        /// Return an expression of two Ordinary Fractions
        /// </summary>
        /// <returns></returns>
        public static OridinaryFractions2 GenerateAddition()
        {
            OridinaryFractions2 ret;
            ret.a.counter = UniversalFunctions.Rand(1, 9);
            ret.a.denominator = UniversalFunctions.Rand(1, 9);
            ret.b.counter = UniversalFunctions.Rand(1, 9);
            ret.b.denominator = UniversalFunctions.Rand(1, 9);
            ret._operator = "+";

            return ret;
        }


    }
}