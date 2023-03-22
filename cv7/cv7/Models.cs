using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    internal class Circle : Object2D
    {
        private const double PI = 3.14;
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            return PI * r * r;
        }
        public override string ToString()
        {
            return "Circle, radius: " + r + " area: " + Area();
        }
    }
    internal class Rectangle : Object2D
    {
        private double l;
        private double h;
        public Rectangle(double l, double h)
        {
            this.l = l;
            this.h = h;
        }
        public override double Area()
        {
            return l * h;
        }
        public override string ToString()
        {
            return "Rectangle, length: " + l +"height: "+ h +" area: " + Area();
        }
    }
    internal class Elipse : Object2D
    {
        private const double PI = 3.14;
        private double a;
        private double b;
        public Elipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return PI * a * b;
        }
        public override string ToString()
        {
            return "Elipse, axis 1: " + a + " axis 2: " + b + " area: " + Area();
        }
    }
    internal class Triangle : Object2D
    {
        private double b;
        private double h;
        public Triangle(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public override double Area()
        {
            return b * h / 2;
        }
        public override string ToString()
        {
            return ("Triangle, base: " + b + " height: " + h + " area: " + Area());
        }
    }

}
