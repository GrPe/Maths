using System;
using static Functionalities.MathsStructures;

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
            return (Convert.ToString(exp.a + exp.b) == value);
        }

        /// <summary>
        /// Verify correctness of Subtraction
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifySubtraction(string value, ValueDouble2 exp)
        {
            return Convert.ToString(exp.a - exp.b) == value;
        }

        /// <summary>
        /// Verify correctness of Multiplication
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifyMultiplication(string value, ValueDouble2 exp)
        {
            return Convert.ToString(exp.a * exp.b) == value;
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


        public delegate ValueDouble2 DelGenerate();


        /// <summary>
        /// Generate Addition Expression (Floating Points value)
        /// </summary>
        /// <returns></returns>
        public static ValueDouble2 GenerateAddition()
        {
            ValueDouble2 ret;
            ret.a = RandValue.RandDouble(0.1, 9.5);
            ret.b = RandValue.RandDouble(0.1, 9.5);
            ret.correctanswer = ret.a + ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " + " + Convert.ToString(ret.b) + " =";
            return ret;
        }

        /// <summary>
        /// Generate Subtraction Expression (Floating Points value)
        /// </summary>
        /// <returns></returns>
        public static ValueDouble2 GenerateSubtraction()
        {
            ValueDouble2 ret;
            ret.a = RandValue.RandDouble(1, 9.5);
            ret.b = RandValue.RandDouble(1, ret.a);
            ret.correctanswer = ret.a - ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " - " + Convert.ToString(ret.b) + " =";
            return ret;
        }

        /// <summary>
        /// Generate Multiplication Expression (Floating Points value)
        /// </summary>
        /// <returns></returns>
        public static ValueDouble2 GenerateMultiplication()
        {
            ValueDouble2 ret;
            ret.a = RandValue.RandDouble(1, 10, 10);
            ret.b = RandValue.RandDouble(1, 10, 10);
            ret.correctanswer = ret.a * ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " * " + Convert.ToString(ret.b) + " =";
            return ret;
        }

    }

}