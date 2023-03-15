using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv6
{
    internal class Circle : Object2D
    {
        private const double PI = 3.14;
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double calcArea()
        {
            return PI * r * r;
        }
        public override void draw()
        {
            Console.WriteLine("Circle, radius: " + r + " area: " + calcArea());
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
        public override double calcArea()
        {
            return l * h;
        }
        public override void draw()
        {
            Console.WriteLine("Rectangle, length: " + l +"height: "+ h +" area: " + calcArea());
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
        public override double calcArea()
        {
            return PI * a * b;
        }
        public override void draw()
        {
            Console.WriteLine("Elipse, axis 1: " + a + " axis 2: " + b + " area: " + calcArea());
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
        public override double calcArea()
        {
            return b * h / 2;
        }
        public override void draw()
        {
            Console.WriteLine("Triangle, base: " + b + " height: " + h + " area: " + calcArea());
        }
    }
    internal class RecCuboid : Object3D
    {
        private double a;
        private double b;
        private double c;

        public RecCuboid(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double calcSurface()
        {
            return 2 * ((a * b) + (b * c) + (c * a));
        }
        public override double calcVolume()
        {
            return a * b * c;
        }
        public override void draw()
        {
            Console.WriteLine("Rectangular cuboid, a: " + a + " b: " + b + " c: " + c + " surface: " + calcSurface() + " volume: " + calcVolume());
        }
    }

    internal class Cylinder : Object3D
    {
        private const double PI = 3.14;
        private double r;
        private double h;

        public Cylinder(double r, double h)
        {
            this.h = h;
            this.r = r;
        }
        public override double calcSurface()
        {
            return r * r * PI * 2 + PI * 2 * r * h;
        }
        public override double calcVolume()
        {
            return r * r * PI * h;
        }
        public override void draw()
        {
            Console.WriteLine("Cylinder, radius: " + r + " height: " + h + " surface: " + calcSurface() + " volume: " + calcVolume());
        }
    }
    internal class Sphere : Object3D
    {
        private const double PI = 3.14;
        private double r;

        public Sphere(double r)
        {
            this.r = r;
        }
        public override double calcSurface()
        {
            return 4*PI*r;
        }
        public override double calcVolume()
        {
            return r * r * r * PI * 4/3;
        }
        public override void draw()
        {
            Console.WriteLine("Sphere, radius: " + r + " surface: " + calcSurface() + " volume: " + calcVolume());
        }
    }
    internal class Pyramid : Object3D
    {
        private double h;
        private double a;

        public Pyramid(double a, double h)
        {
            this.a = a;
            this.h = h;
        }
        public override double calcSurface()
        {
            return a*(a + Math.Sqrt(4*h*h+a*a));
        }
        public override double calcVolume()
        {
            return 1 / 3 * a * a * h; 
        }
        public override void draw()
        {
            Console.WriteLine("Pyramid, a: " + a + " h: " + h + " surface: " + calcSurface() + " volume: " + calcVolume());
        }
    }
}
