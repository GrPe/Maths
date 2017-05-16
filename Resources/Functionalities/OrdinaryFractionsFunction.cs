using System;

namespace Functionalities
{
    static class OrdinaryFractionsFunction
    {
        /// <summary>
        /// Ordinary Fraction Structure
        /// </summary>
        public struct SimpleOrdinaryFractions
        {
            public int counter;
            public int denominator;
        }


        /// <summary>
        /// Expression with 2 Ordinary Fractions
        /// </summary>
        public struct OrdinaryFractions2
        {
            public SimpleOrdinaryFractions a;
            public SimpleOrdinaryFractions b;
            public SimpleOrdinaryFractions correctanswer;
            public string _operator;
        }

        public delegate bool DelCompare(string valuecounter, string valuedenominator, OrdinaryFractions2 exp);

        /// <summary>
        /// Verify correctness of Addition Ordinary Fractions
        /// </summary>
        /// <param name="valuecounter">counter of result</param>
        /// <param name="valuedenominator">denominator of result</param>
        /// <param name="exp">original value</param>
        /// <returns></returns>
        public static bool VerifyAswers(string valuecounter, string valuedenominator, OrdinaryFractions2 exp)
        {
            return (valuecounter.Equals(Convert.ToString(exp.correctanswer.counter)) &&
                valuedenominator.Equals(Convert.ToString(exp.correctanswer.denominator)));
        }


        public delegate OrdinaryFractions2 DelGenerate();


        /// <summary>
        /// Return an expression of two Ordinary Fractions
        /// </summary>
        /// <returns></returns>
        public static OrdinaryFractions2 GenerateAddition()
        {
            OrdinaryFractions2 ret;
            ret.a.counter = UniversalFunctions.Rand(1, 8);
            ret.a.denominator = UniversalFunctions.Rand(1, 9);
            ret.b.counter = UniversalFunctions.Rand(1, 8);
            ret.b.denominator = UniversalFunctions.Rand(1, 9);
            ret._operator = "+";

            ret.correctanswer.denominator = UniversalFunctions.LCM(ret.a.denominator, ret.b.denominator);
            int tmpCounterA = ret.a.counter * (ret.correctanswer.denominator / ret.a.denominator);
            int tmpCounterB = ret.b.counter * (ret.correctanswer.denominator / ret.b.denominator);

            ret.correctanswer.counter = tmpCounterA + tmpCounterB;
            int tmpGCD = UniversalFunctions.GCD(ret.correctanswer.counter, ret.correctanswer.denominator);
            ret.correctanswer.counter /= tmpGCD;
            ret.correctanswer.denominator /= tmpGCD;

            return ret;
        }

        public static OrdinaryFractions2 GenerateSubtraction()
        {
            OrdinaryFractions2 ret;
            do
            {
                ret.a.counter = UniversalFunctions.Rand(3, 10);
                ret.a.denominator = UniversalFunctions.Rand(2, 10);
                ret.b.counter = UniversalFunctions.Rand(1, 9);
                ret.b.denominator = UniversalFunctions.Rand(1, 9);
                ret._operator = "-";

                ret.correctanswer.denominator = UniversalFunctions.LCM(ret.a.denominator, ret.b.denominator);
                int tmpCounterA = ret.a.counter * (ret.correctanswer.denominator / ret.a.denominator);
                int tmpCounterB = ret.b.counter * (ret.correctanswer.denominator / ret.b.denominator);

                ret.correctanswer.counter = tmpCounterA - tmpCounterB;
                if (ret.correctanswer.counter < 0) continue;
                int tmpGCD = UniversalFunctions.GCD(ret.correctanswer.counter, ret.correctanswer.denominator);
                ret.correctanswer.counter /= tmpGCD;
                ret.correctanswer.denominator /= tmpGCD;
            } while (ret.correctanswer.counter < 0);

            return ret;
        }

        public static OrdinaryFractions2 GenerateMultiplication()
        {
            OrdinaryFractions2 ret;
            ret.a.counter = UniversalFunctions.Rand(1, 8);
            ret.a.denominator = UniversalFunctions.Rand(1, 9);
            ret.b.counter = UniversalFunctions.Rand(1, 8);
            ret.b.denominator = UniversalFunctions.Rand(1, 9);
            ret._operator = "*";

            ret.correctanswer.counter = ret.a.counter * ret.b.counter;
            ret.correctanswer.denominator = ret.a.denominator * ret.b.denominator;
            int tmpGCD = UniversalFunctions.GCD(ret.correctanswer.counter, ret.correctanswer.denominator);
            ret.correctanswer.counter /= tmpGCD;
            ret.correctanswer.denominator /= tmpGCD;

            return ret;
        }

        public static OrdinaryFractions2 GenerateDivision()
        {
            OrdinaryFractions2 ret;
            ret.a.counter = UniversalFunctions.Rand(1, 8);
            ret.a.denominator = UniversalFunctions.Rand(1, 9);
            ret.b.counter = UniversalFunctions.Rand(1, 8);
            ret.b.denominator = UniversalFunctions.Rand(1, 9);
            ret._operator = "\u00f7";

            ret.correctanswer.counter = ret.a.counter * ret.b.denominator;
            ret.correctanswer.denominator = ret.a.denominator * ret.b.counter;
            int tmpGCD = UniversalFunctions.GCD(ret.correctanswer.counter, ret.correctanswer.denominator);
            ret.correctanswer.counter /= tmpGCD;
            ret.correctanswer.denominator /= tmpGCD;

            return ret;
        }


    }
}