using System;
using static Functionalities.MathsStructures;

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

        public delegate ValueInt2 DelGenerate();


        /// <summary>
        /// Generate Addition Expression
        /// </summary>
        /// <returns></returns>
        public static ValueInt2 GenerateAddition()
        {
            var ret = new ValueInt2();
            ret.a = UniversalFunctions.Rand(1, 20);
            ret.b = UniversalFunctions.Rand(1, 20);
            ret.correctanswer = ret.a + ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " + " + Convert.ToString(ret.b) + " =";
            return ret;
        }

        /// <summary>
        /// Generate Subtraction Expression 
        /// </summary>
        /// <returns></returns>
        public static ValueInt2 GenerateSubtraction()
        {
            var ret = new ValueInt2();
            ret.a = UniversalFunctions.Rand(1, 100);
            ret.b = UniversalFunctions.Rand(1, ret.a);
            ret.correctanswer = ret.a - ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " - " + Convert.ToString(ret.b) + " =";
            return ret;
        }

        /// <summary>
        /// Generate Multiplication Expression
        /// </summary>
        /// <returns></returns>
        public static ValueInt2 GenerateMultiplication()
        {
            var ret = new ValueInt2();
            ret.a = UniversalFunctions.Rand(1, 10);
            ret.b = UniversalFunctions.Rand(1, 10);
            ret.correctanswer = ret.a * ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " * " + Convert.ToString(ret.b) + " =";
            return ret;
        }

        /// <summary>
        /// Generate Division Expression
        /// </summary>
        /// <returns></returns>
        public static ValueInt2 GenerateDivision()
        {
            var ret = new ValueInt2();
            ret.a = UniversalFunctions.Rand(2, 100);
            while (true)
            {
                ret.b = UniversalFunctions.Rand(2, 100);
                if (ret.a % ret.b == 0) break;
            }
            ret.correctanswer = ret.a / ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " \u00f7 " + Convert.ToString(ret.b) + " =";
            return ret;
        }
    }
}