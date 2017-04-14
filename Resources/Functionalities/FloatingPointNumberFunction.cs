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
using static Functionalities.BasicMathsStructures;

namespace Functionalities
{
    static class FloatingPointNumberFunction
    {
        public delegate bool DelCompare(string value, ValueDouble2 exp);

        /// <summary>
        /// Verify correctness of Addition
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifyAddition(string value, ValueDouble2 exp)
        {
            return (exp.a + exp.b == Convert.ToDouble(value));
        }

        /// <summary>
        /// Verify correctness of Subtraction
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifySubtraction(string value, ValueDouble2 exp)
        {
            return (exp.a - exp.b == Convert.ToDouble(value));
        }

        /// <summary>
        /// Verify correctness of Multiplication
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifyMultiplication(string value, ValueDouble2 exp)
        {
            return (exp.a * exp.b == Convert.ToDouble(value));
        }

        /// <summary>
        /// Verify correctness of Division
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifyDivision(string value, ValueDouble2 exp)
        {
            double tmp;
            try
            {
                tmp = exp.a / exp.b;
            }
            catch (Exception e)
            {
                return false;
            }
            return value == Convert.ToString(tmp);
        }
    }

}