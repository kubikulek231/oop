using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cv3
{
    public class Matrix
    {
        public double[,] MatrixArray { get; set; }
        int Rows => MatrixArray.GetLength(0);
        int Cols => MatrixArray.GetLength(1);

        public Matrix(double[,] matrix_array)
        {
            MatrixArray = matrix_array;
           
        }
        public static double squareDeterminant(Matrix a)
        {
            if ((a.Cols != a.Rows) || a.Rows > 3 || a.Cols > 3)
            {
                throw new ArgumentException("Matrix is bigger than 3x3 or not square!");
            }
            
                int n = a.MatrixArray.GetLength(1);
                double num1, num2, det = 1, total = 1; // Initialize result
                int index;

                // temporary array for storing row
                double[] temp = new double[n + 1];

                // loop for traversing the diagonal elements
                for (int i = 0; i < n; i++)
                {
                    index = i; // initialize the index

                    // finding the index which has non zero value
                    while (index < n && a.MatrixArray[index, i] == 0)
                    {
                        index++;
                    }
                    if (index == n) // if there is non zero element
                    {
                        // the determinant of matrix as zero
                        continue;
                    }
                    if (index != i)
                    {
                        // loop for swapping the diagonal element row
                        // and index row
                        for (int j = 0; j < n; j++)
                        {
                            swap(a.MatrixArray, index, j, i, j);
                    }
                        // determinant sign changes when we shift
                        // rows go through determinant properties
                        det = (int)(det * Math.Pow(-1, index - i));
                    }

                    // storing the values of diagonal row elements
                    for (int j = 0; j < n; j++)
                    {
                        temp[j] = a.MatrixArray[i, j];
                    }

                    // traversing every row below the diagonal
                    // element
                    for (int j = i + 1; j < n; j++)
                    {
                        num1 = temp[i]; // value of diagonal element
                        num2 = a.MatrixArray[j,i]; // value of next row element

                        // traversing every column of row
                        // and multiplying to every row
                        for (int k = 0; k < n; k++)
                        {

                            // multiplying to make the diagonal
                            // element and next row element equal
                            a.MatrixArray[j, k] = (num1 * a.MatrixArray[j, k])
                                        - (num2 * temp[k]);
                        }
                        total = total * num1; // Det(kA)=kDet(A);
                    }
                }
            // multiplying the diagonal elements to get
            // determinant
            for (int i = 0; i < n; i++)
            {
                det = det * a.MatrixArray[i, i];
            }
            return (det / total); // Det(kA)/k=Det(A);
        


    }
        static double[,] swap(double[,] arr, int i1, int j1, int i2,
                        int j2)
        {
            double temp = arr[i1, j1];
            arr[i1, j1] = arr[i2, j2];
            arr[i2, j2] = temp;
            return arr;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols) 
            {
                throw new ArgumentException("Invalid matrix sizes!");
            }
            var result = new double[a.Rows, a.Cols];
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result[i, j] = a.MatrixArray[i,j] + b.MatrixArray[i,j];
                }
            }
            return new Matrix(result);
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentException("Invalid matrix sizes!");
            }

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    if (a.MatrixArray[i,j] != b.MatrixArray[i, j]){
                        return false;
                    }

                }
            }
            return true;
        }
        public static Matrix operator -(Matrix a)
        {
            double[,] temp = new double[a.Rows, a.Cols];
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    temp[i,j] = -a.MatrixArray[i,j];
                }
            }
            return new Matrix(temp);
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentException("Invalid matrix sizes!");
            }
            var result = new double[a.Rows, a.Cols];
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result[i, j] = a.MatrixArray[i, j] - b.MatrixArray[i, j];
                }
            }
            return new Matrix(result);
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Cols != b.Rows)
            {
                throw new ArgumentException("Invalid matrix sizes!");
            }
            double temp = 0.0;
            var result = new double[a.Rows, b.Cols];
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    temp = 0;
                    for (int k = 0; k < a.Cols; k++)
                    {
                        temp = temp + a.MatrixArray[i, k] * b.MatrixArray[k, j];
                    }
                    result[i, j] = temp;
                    
                }
            }
            return new Matrix(result);
        }

        public override string ToString()
        {
            int row_num = MatrixArray.GetLength(0);
            int col_num = MatrixArray.GetLength(1);
            string returnString = "";
            for (int i = 0; i < row_num; i++)
            {
                for (int j = 0; j < col_num; j++)
                {
                    returnString = returnString + MatrixArray[i, j].ToString() + " ";
                   
                }
                returnString = returnString + "\n";
            }
            return returnString;
        }

    }
}
