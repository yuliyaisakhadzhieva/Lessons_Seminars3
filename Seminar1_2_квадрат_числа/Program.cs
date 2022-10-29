Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());

Console.WriteLine("Введите натуральное число ");
int y=Convert.ToInt32 ( Console.ReadLine());
if (x*x==y) Console.WriteLine ("Второе число является квадратом первого");
else if (y*y==x) Console.WriteLine ("Первое число является квадратом второго");
else Console.WriteLine ("No");

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго. 
// a = 25, b = 5 -> да  a = 2, b = 10 -> нет  a = 9, b = -3 -> да  a = -3 b = 9 -> нет 