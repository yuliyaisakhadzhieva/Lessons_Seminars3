// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.  
// 5, 25  ->  да -4, 16  ->  да 25, 5  ->  да 8,9  ->  нет

Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите натуральное число ");
int y=Convert.ToInt32 ( Console.ReadLine());
if (x*x == y ) Console.Write("Да");
else if ( y*y == x) Console.Write("Да");
else Console.Write("Нет");