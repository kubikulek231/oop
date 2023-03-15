// See https://aka.ms/new-console-template for more information
using cv6;

Console.WriteLine("Hello, World!");
ObjectGr[] models = new ObjectGr[8];
models[0] = new Circle(1);
models[1] = new Rectangle(2,2);
models[2] = new Elipse(3,3);
models[3] = new Triangle(4,4);
models[4] = new RecCuboid(5,5,5);
models[5] = new Cylinder(6,6);
models[6] = new Sphere(7);
models[7] = new Pyramid(8, 8);


double volume = 0;
double surface = 0;
double area = 0;
for (int i = 0; i < 8; i++)
{
    if (models[i] is Object2D model)
    {
        area += model.calcArea();
        model.draw();
    }
    if (models[i] is Object3D model3D)
    {
        surface += model3D.calcSurface();
        volume += model3D.calcVolume();
        model3D.draw();
    }

}
Console.WriteLine("area: " + area);
Console.WriteLine("surface: " + surface);
Console.WriteLine("volume: " + volume);