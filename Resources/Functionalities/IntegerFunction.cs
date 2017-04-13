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
    static class IntegerFunctions
    {

        public delegate bool DelCompare(string value, ValueInt2 exp);

        /// <summary>
        /// Verify correctness of Addition
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">original value</param>
        /// <returns></returns>
        public static bool VerifyAddition(string value,ValueInt2 exp )
        {
            return (exp.a + exp.b == Convert.ToInt32(value));
        }

        /// <summary>
        /// Verify correctness of Subtraction
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">original value</param>
        /// <returns></returns>
        public static bool VerifySubtraction(string value, ValueInt2 exp)
        {
            return (exp.a - exp.b == Convert.ToInt32(value));
        }

        /// <summary>
        /// Verify correctness of Multiplication
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">original value</param>
        /// <returns></returns>
        public static bool VerifyMultiplication(string value, ValueInt2 exp)
        {
            return (exp.a * exp.b == Convert.ToInt32(value));
        }

        /// <summary>
        /// Verify correctness of Division (only integer value)
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">original value</param>
        /// <returns></returns>
        public static bool VerifyDivision(string value, ValueInt2 exp)
        {
            int tmp;
            try
            {
                tmp = exp.a /exp.b;
            }
            catch(Exception e)
            {
                return false;
            }

            return value == Convert.ToString(tmp);
        }
    }
}