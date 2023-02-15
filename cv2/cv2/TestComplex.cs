using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv2
{
    internal class TestComplex
    {
        private const double Epsilon = 1E-6;

        public static void Test(Complex actual, Complex expected, string name)
        {
            if (Math.Abs(expected.Real - actual.Real) < Epsilon &&
                Math.Abs(expected.Imaginary - actual.Imaginary) < Epsilon)
            {
                Console.WriteLine($"Test {name}: OK");
            }
            else
            {
                Console.WriteLine($"Test {name}: ERROR -> Actual{actual}, Expected: {expected}");
            }
        }
    }
}
