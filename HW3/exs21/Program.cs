// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Coordinates("x", "A");
int y1 = Coordinates("y", "A");
int z1 = Coordinates("z", "A");
int x2 = Coordinates("x", "B");
int y2 = Coordinates("y", "B");
int z2 = Coordinates("z", "B");

int Coordinates ( string coordinate, string point )
{
    Console.Write ($"Введите координату {coordinate} точки {point} ->  ");
    return Convert.ToInt32 (Console.ReadLine());
}

double MethodDecision ( double a1, double b1, double c1, double a2, double b2, double c2 )
{
    return Math.Sqrt ( Math.Pow ( (x2 - x1), 2) + 
                       Math.Pow ( (y2 - y1), 2) + 
                       Math.Pow ( (z2 - z1), 2) ); 
}

double result = Math.Round ( MethodDecision ( x1, x2, y1, y2, z1, z2 ), 2 );

Console.WriteLine ($"По заданным координатам длина отрезка, равна: -> {result}");
