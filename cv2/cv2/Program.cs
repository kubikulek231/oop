// See https://aka.ms/new-console-template for more information
using cv2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TestComplex.Test(new Complex(3.0, 5.0) + new Complex(9.1, 1.3), new Complex(12.1, 6.3), "operator +");
        TestComplex.Test(-new Complex(3.0, 5.0) , new Complex(-3.0, -5.0), "operator unary -");
        TestComplex.Test(new Complex(3.0, 5.0).Conjugate() , new Complex(3.0, -5.0), "conjugate");
        Console.WriteLine(new Complex(3.0, 5.0) == new Complex(5.0, 3.0));
        Console.WriteLine(new Complex(3.0, 5.0) != new Complex(5.0, 3.0));
        Console.WriteLine(new Complex(3, 4).Modulus());
        Console.WriteLine(new Complex(3, 4).Argument());
        Console.WriteLine(new Complex(1, 4) * new Complex(2, 1));
        Console.WriteLine(new Complex(1, 4) / new Complex(2, 1));
    }
    
}