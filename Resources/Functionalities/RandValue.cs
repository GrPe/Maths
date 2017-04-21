using System;

namespace Functionalities
{
    public static class UniversalFunctions
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
        /// MAX RANGE: 0.01 - 10.00
        /// </summary>
        /// <param name="min">minimal value</param>
        /// <param name="max">maximal value</param>
        /// <returns></returns>
        public static double RandDouble(double min,double max)
        {
            min *= 100;
            max *= 100;
            int imin = (int)min;
            int imax = (int)max;
            double ret = NValue.Next(imin, imax);
            return (ret / 100);
        }

        /// <summary>
        /// Return Random value from the specified range
        /// MAX RANGE: 0.0001 - 100.00
        /// </summary>
        /// <param name="min">minimal value</param>
        /// <param name="max">maximal value</param>
        /// <param name="acc">accuracy of randomized number (format - 10/100) 10 = 0.1</param>
        /// <returns></returns>
        public static double RandDouble(double min,double max, int acc)
        {
            min *= acc;
            max *= acc;
            int imin = (int)min;
            int imax = (int)max;
            double ret = NValue.Next(imin, imax);
            return (ret / acc);
        }



    }
}
