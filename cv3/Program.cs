// See https://aka.ms/new-console-template for more information
using cv3;
using System.Runtime.InteropServices;

var myArray = new double[2, 3]
       {
            {1.3, 1.1, 7.5},
            {8, 5.4, 6.2}
       };
var myArray2 = new double[2, 3]
       {
            {1.0, 2.0, 3.0},
            {4.0, 5.0, 6.0}
       };

var myArray3 = new double[2, 2]
       {
            {1.2, 2.1},
            {4.4, 5.1}
       };
var myArray4 = new double[3, 2]
       {
            {7, 8},
            {9, 10},
            {11, 12}
       };

Matrix newMatrix = new Matrix(myArray);
Matrix newMatrix2 = new Matrix(myArray2);
Matrix newMatrix3 = new Matrix(myArray3);
Matrix newMatrix4 = new Matrix(myArray4);

Console.WriteLine(newMatrix);
Console.WriteLine(newMatrix + newMatrix2);
Console.WriteLine(newMatrix - newMatrix);
Console.WriteLine(newMatrix2 * newMatrix4);
Console.WriteLine(Matrix.squareDeterminant(newMatrix3));
Console.WriteLine("");
Console.WriteLine(-newMatrix2);
Console.WriteLine(newMatrix2 == newMatrix2);
Console.WriteLine(newMatrix2 != newMatrix2);
