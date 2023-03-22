// See https://aka.ms/new-console-template for more information
using cv7;
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Hello, World!");
Object2D[] models = new Object2D[4];
models[0] = new Circle(1);
models[1] = new Rectangle(2,2);
models[2] = new Elipse(3,3);
models[3] = new Triangle(4,4);

int[] Integers = new int[5];
string[] Strings = new string[3];
Circle[] Circles = new Circle[3];
Rectangle[] Rectangles = new Rectangle[3];
Integers[0] = 1;
Integers[1] = 3;
Integers[2] = 5;
Integers[3] = 7;
Integers[4] = 9;
Strings[0] = "pepa";
Strings[1] = "zdepa";
Strings[2] = "rajce123";
Circles[0] = new Circle(5);
Circles[1] = new Circle(10);
Circles[2] = new Circle(2);
Rectangles[0] = new Rectangle(5,5);
Rectangles[1] = new Rectangle(10,5);
Rectangles[2] = new Rectangle(9, 5);

foreach (Object2D model in models)
{
    Console.WriteLine(model);
}

Console.WriteLine(Extreme.MaxArea(models));
Console.WriteLine(Extreme.MinArea(models));
IEnumerable<int> intQuerry =
    from integer in Integers
    where integer > 4 && integer < 8
    select integer;
foreach (int integer in intQuerry)
{
    Console.WriteLine(integer);
}