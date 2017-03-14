using System;

namespace Engine.Functionalities
{
    public static class RandValue
    {
        private static Random NValue = new Random();
        private static int VRet;
        /// <summary>
        /// Return Radom value from the specified range
        /// </summary>
        /// <param name="min">minimal value</param>
        /// <param name="max">maximal value</param>
        /// <returns></returns>
        public static int Rand(int min, int max)
        {
            VRet = NValue.Next(min, max);
            return VRet;
        }
    }
}
