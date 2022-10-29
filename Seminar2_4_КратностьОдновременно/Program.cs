// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно  7 и 23.  14 -> нет  46 -> нет  161 -> да

Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
if (x % 7 == 0 && x % 23 ==0) Console.Write("Да");
else Console.Write("Нет");
