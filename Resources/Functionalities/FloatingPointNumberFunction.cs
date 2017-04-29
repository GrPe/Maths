using System;
using System.Collections.Generic;
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
            ret.a = UniversalFunctions.RandDouble(0.1, 9.5);
            ret.b = UniversalFunctions.RandDouble(0.1, 9.5);
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
            ret.a = UniversalFunctions.RandDouble(1, 9.5);
            ret.b = UniversalFunctions.RandDouble(1, ret.a);
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
            ret.a = UniversalFunctions.RandDouble(1, 10, 10);
            ret.b = UniversalFunctions.RandDouble(1, 10, 10);
            ret.correctanswer = ret.a * ret.b;
            ret.displayvalue = Convert.ToString(ret.a) + " * " + Convert.ToString(ret.b) + " =";
            return ret;
        }

    }


    static class DivisionTableOfFloatingPoints
    {
        static List<ValueDouble2> data = new List<ValueDouble2>();
        static int count = 0; //number of elements in data

        public static void Initialize()
        {
            for(decimal i=10;i<100;i++)
            {
                for(decimal j=10;j<1000;j++)
                {
                    if(Math.Abs(i/j-(int)i/(int)j)<0.01m && i/j != (int)i/(int)j)
                    {
                        count++;
                        data.Add(new ValueDouble2
                        {
                            a = (double)i/10,
                            b = (double)j/10,
                            correctanswer = (double)i / (double)j,
                            displayvalue = Convert.ToString(i/10) + " \u00f7 " + Convert.ToString(j/10) + " ="
                        });
                    }
                }
            }
        }

        /// <summary>
        /// Return expression of Floating Points
        /// </summary>
        /// <returns></returns>
        public static ValueDouble2 GetValue()
        {
            return data[UniversalFunctions.Rand(1, count)];
        }

    }

}