using System;
using System.Collections.Generic;
using static Functionalities.FloatingPointNumberFunction;

namespace Functionalities
{
    static class FloatingPointNumberFunction
    {
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

        public delegate bool DelCompare(string value, ValueDecimal2 exp);

        /// <summary>
        /// Verify correctness of Addition
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifyAddition(string value, ValueDecimal2 exp)
        {
            return exp.correctanswer == Convert.ToDecimal(value);
        }

        /// <summary>
        /// Verify correctness of Subtraction
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifySubtraction(string value, ValueDecimal2 exp)
        {
            return exp.correctanswer == Convert.ToDecimal(value);
        }

        /// <summary>
        /// Verify correctness of Multiplication
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifyMultiplication(string value, ValueDecimal2 exp)
        {
            return exp.correctanswer == Convert.ToDecimal(value);
        }

        /// <summary>
        /// Verify correctness of Division
        /// </summary>
        /// <param name="value">value from user</param>
        /// <param name="exp">real value</param>
        /// <returns></returns>
        public static bool VerifyDivision(string value, ValueDecimal2 exp)
        {
            return Convert.ToDecimal(value) == exp.correctanswer;
        }


        public delegate ValueDecimal2 DelGenerate();


        /// <summary>
        /// Generate Addition Expression (Floating Points value)
        /// </summary>
        /// <returns></returns>
        public static ValueDecimal2 GenerateAddition()
        {
            ValueDecimal2 ret;
            ret.a = UniversalFunctions.RandDecimal(0.1m, 9.5m);
            ret.b = UniversalFunctions.RandDecimal(0.1m, 9.5m);
            ret.correctanswer = ret.a + ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " + " + Convert.ToString(ret.b) + " =";
            return ret;
        }

        /// <summary>
        /// Generate Subtraction Expression (Floating Points value)
        /// </summary>
        /// <returns></returns>
        public static ValueDecimal2 GenerateSubtraction()
        {
            ValueDecimal2 ret;
            ret.a = UniversalFunctions.RandDecimal(1, 9.5m);
            ret.b = UniversalFunctions.RandDecimal(1, ret.a);
            ret.correctanswer = ret.a - ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " - " + Convert.ToString(ret.b) + " =";
            return ret;
        }

        /// <summary>
        /// Generate Multiplication Expression (Floating Points value)
        /// </summary>
        /// <returns></returns>
        public static ValueDecimal2 GenerateMultiplication()
        {
            ValueDecimal2 ret;
            ret.a = UniversalFunctions.RandDecimal(1, 10, 10);
            ret.b = UniversalFunctions.RandDecimal(1, 10, 10);
            ret.correctanswer = ret.a * ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " * " + Convert.ToString(ret.b) + " =";
            return ret;
        }

    }


    static class DivisionTableOfFloatingPoints
    {
        static List<ValueDecimal2> data = new List<ValueDecimal2>();
        static int count = 0; //number of elements in data

        public static void Initialize()
        {
            for (decimal i = 1.0m; i <= 10.0m; i += 0.05m)
            {
                for (decimal j = 5.5m; j >= 0.1m; j -= 0.1m)
                {
                    decimal tmp = i / j;
                    if (tmp * 10 == (int)(tmp * 10))
                    {
                        count++;
                        data.Add(new ValueDecimal2
                        {
                            a = i,
                            b = j,
                            correctanswer = i / j,
                            displayvalue = Convert.ToString(i) + " \u00f7 " + Convert.ToString(j) + " ="
                        });
                    }
                }
            }
        }

        /// <summary>
        /// Return expression of Floating Points
        /// </summary>
        /// <returns></returns>
        public static ValueDecimal2 GetValue()
        {
            return data[UniversalFunctions.Rand(1, count)];
        }

    }

}