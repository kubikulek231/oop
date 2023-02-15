using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv2
{
    internal class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        // 
        public static Complex operator -(Complex a)
        {
            return new Complex(-a.Real, -a.Imaginary);
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return a.Real == b.Real && a.Imaginary == b.Imaginary;
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }
        
        public static Complex operator / (Complex a, Complex b)
        {
            return new Complex((a.Real * b.Real + a.Imaginary * b.Imaginary)/(Math.Pow(b.Real, 2) + Math.Pow(b.Imaginary, 2)), (a.Imaginary*b.Real - a.Real*b.Imaginary)/ (Math.Pow(b.Real, 2) + Math.Pow(b.Imaginary, 2)));
        }
        public static Complex operator * (Complex a, Complex b)
        {
            return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
        }
        
        public override string ToString()
        {
            if (Imaginary < 0)
            {
                return $"{Real}{Imaginary}j";
            }
            else
            {
                return $"{Real}+{Imaginary}j";
            }
        }

        public Complex Conjugate()
        {
            return new Complex(Real, -Imaginary);
        }

        public double Modulus()
        {
            return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
        }

        public double Argument()
        {
            return Math.Atan2(Imaginary, Real);

        }
    }

}
