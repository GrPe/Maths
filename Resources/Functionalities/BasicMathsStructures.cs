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
    class BasicMathsStructures
    { 

      /// <summary>
      /// Przechowuje wyrazenie zlozone z 2 liczb
      /// </summary>
        public struct ValueInt2
        {
            public int a;
            public int b;
            public int correctanswer;
            public string displayvalue;
        }

        /// <summary>
        /// Przechowuje wyrazenie zlozone z 2 liczby double
        /// </summary>
        public struct ValueDouble2
        {
            public double a;
            public double b;
            public double correctanswer;
            public string displayvalue;
        }
    }
}