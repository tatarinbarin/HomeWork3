// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Решение задачи
Console.WriteLine ("Введите натуральное пятизначное число: ");
int num = Convert.ToInt32 (Console.ReadLine());

int TimeNum1 = num / 1000;
int TimeNum2 = num / 10;

int num1 = num / 10000;
int num2 = TimeNum1 % 10;
int num4 = TimeNum2 % 10;
int num5 = num % 10;

// Метод решения
if ( num >= 10000 && num < 100000 && num > 0 )
{
    bool pal = Palindrome ( num1, num2, num4, num5 );

    bool Palindrome ( int numb1, int numb2, int numb4, int numb5 )
    {
        if ( num1 == num5 && num2 == num4 )
        {
            Console.WriteLine ($"Данное число {num}, является палиндромом");
            return true;
        }
        else
        {
            Console.WriteLine ($"Данное число {num}, не является палиндромом");
            return false;
        }
    }
}
else
{
    Console.WriteLine ("Некорректные данные, введите пятизначное и натуральное число");
}
