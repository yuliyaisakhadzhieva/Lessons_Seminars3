// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел  от 1 до N.  5 -> 1, 4, 9, 16, 25. 2 -> 1,4

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) 
Console.Write($"{i*i} ");

// Второй вариант решения задачи

// Console.WriteLine("Введите число N");         
// int n = int.Parse(Console.ReadLine());         
// for (int i = 1; i <= n; i++)             
// Console.WriteLine("{0}^2 = {1}", i, i*i);         
// Console.ReadKey(true);