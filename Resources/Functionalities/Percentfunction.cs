using System;
using static Functionalities.MathsStructures;

namespace Functionalities
{
    static class PercentFunction
    {
        public delegate bool DelCompare(string value, Percents2 exp);

        /// <summary>
        /// Verify Correctness of Expression1 
        /// </summary>
        /// <param name="value">Value from user</param>
        /// <param name="exp">original expression</param>
        /// <returns></returns>
        public static bool CompareExpression1(string value, Percents2 exp)
        {
            return value == Convert.ToString(exp.Value * exp.Percent);
        }
        
        public delegate Percents2 DelGenerate();

        /// <summary>
        /// Generate Expression 
        /// for example: 15% z 6 =
        /// </summary>
        /// <returns></returns>
        public static Percents2 GenerateExpression1()
        {
            Percents2 exp;
            exp.Value = UniversalFunctions.Rand(5, 100);
            do
            {
                exp.Percent = UniversalFunctions.RandDecimal(0.01m, 1.0m, 100);
            } while ((exp.Value * exp.Percent) != (int)(exp.Value * exp.Percent));

            exp.correctvalue = exp.Value * exp.Percent;
            exp.displayvalue = Convert.ToString((int)(exp.Percent * 100)) + "% z " + Convert.ToString(exp.Value) + " =";

            return exp;
        }
    }
}