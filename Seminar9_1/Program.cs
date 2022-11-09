// посчитаем сумму всех  целых чисел от 1 до N, которое вводит пользователь

// Console.Write ("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumDigits(int n)
// {
//     int sum = 0;
//     while (n>0)
//     {
//         sum=sum+n;
//         n--;
//     }
//     return sum;
// }

// int SumRec(int n)
// {
//     if (n==0) return 0;
//     return n + SumRec(n-1);
// }

// Console.WriteLine(SumDigits(n));
// Console.WriteLine(SumRec(n));

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());
// string RecNat(int n)
// {
//     if (n == 0) return "";
//     return RecNat(n - 1) + Convert.ToString(n) +  ", ";
// }
// Console.WriteLine($"{RecNat(n)}");


// Второй вариант

//  Console.Write ("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());

// string SumRec(int n)
// {
//     if (n==0) return " ";
//     return SumRec(n-1) + " " + Convert.ToString(n);
    
// }


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

//  Console.Write ("Введите целое число M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите целое число N ");
// int n = Convert.ToInt32(Console.ReadLine());

// string SumRec(int n)
// {
//     if (n==m) return " ";
//     return SumRec(n-1) + "  " + Convert.ToString(n);
    
// }

// Console.WriteLine($" {SumRec(n)} ");


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите целое число  ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Sum(int n)
// {
//     if (n == 0) return 0;
//     return Sum(n / 10) + n % 10;

// }
// Console.WriteLine($" {Sum(n)} ");


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Введите целое число M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число N ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumRec(int n, int m)
// {
//     if (m == 0) return 1;
//     else return SumRec(n, m-1) * n ;
// }
// Console.WriteLine($" {SumRec(n, m)} ");

