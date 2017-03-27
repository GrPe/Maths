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
    static class BasicMathsFunctions
    {

        /// <summary>
        /// Verify correctness of Addition
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="a">original value a</param>
        /// <param name="b">original value b</param>
        /// <returns></returns>
        public static bool VerifyAddition(string value, int a, int b)
        {
            int tmp = Convert.ToInt32(value);
            return (a+b == tmp);
        }

        /// <summary>
        /// Verify correctness of Subtraction
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="a">original value a</param>
        /// <param name="b">original value b</param>
        /// <returns></returns>
        public static bool VerifySubtraction(string value, int a, int b)
        {
            int tmp = Convert.ToInt32(value);
            return (a - b == tmp);
        }

        /// <summary>
        /// Verify correctness of Multiplication
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="a">original value a</param>
        /// <param name="b">original value b</param>
        /// <returns></returns>
        public static bool VerifyMultiplication(string value, int a, int b)
        {
            int tmp = Convert.ToInt32(value);
            return (a * b == tmp);
        }
    }
}