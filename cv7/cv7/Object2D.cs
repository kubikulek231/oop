using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    abstract internal class Object2D :  IComparable, I2D
    {
        public abstract double Area();


        public int CompareTo(object? obj)
        {
            if (obj is Object2D obj2D)
            {
                double ours = this.Area();
                double theirs = obj2D.Area();
                return ours.CompareTo(theirs);
            }
            throw new Exception("Incompatible types!");
        }
    }
}
