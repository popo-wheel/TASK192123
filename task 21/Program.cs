// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance (int a1 , int a2 , int a3 , int b1 , int b2 , int b3)
{
    int side1 = a1 - b1;
    int side2 = a2 - b2;
    int side3 = a3 - b3;
    double distance = Math.Sqrt(side1side1 + side2side2 + side3*side3);
    return distance;
}

Console.WriteLine( "введите координаты 1 точки");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "введите координаты 2 точки");
Console.Write("x: ");
int x2= Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, z1, x2, y2, z2 );
double resultRound = Math.Round (result, 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);