using System;

namespace Functionalities
{
    public static class RandValue
    {
        private static Random NValue = new Random();

        /// <summary>
        /// Return Random value from the specified range
        /// </summary>
        /// <param name="min">minimal value</param>
        /// <param name="max">maximal value</param>
        /// <returns></returns>
        public static int Rand(int min, int max)
        {
            return NValue.Next(min, max);
        }

        /// <summary>
        /// Return Random value from the specified range
        /// </summary>
        /// <param name="min">minimal value</param>
        /// <param name="max">maximal value</param>
        /// <returns></returns>
        public static double RandDouble(double min,double max)
        {
            return NValue.NextDouble() * (max - min) + min;
        }
    }
}
