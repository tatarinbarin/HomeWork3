// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine ("Введите натуральное число: ");
int num = Convert.ToInt32 (Console.ReadLine());

int [] TableCubeNumbers = new int [num + 1];

void Cube ( int [] cube )
{
    cube [0] = 1;
    int i = cube [0];
    while ( i <= num )
    {
        cube [i] = Convert.ToInt32 (Math.Pow ( i , 3) );
        i++;
    }
}

void PrintCube ( int [] numbers )
{
    int i = numbers.Length;
    int index = 1;
    while ( index < i )
    {
        Console.WriteLine ($"{index} | {numbers [index]} ");
        index++;
    }
}

Cube (TableCubeNumbers);
PrintCube (TableCubeNumbers);
