﻿// 1! = 1    0!=1

double Factorial (double n)
{
    if (n == 1) return 1;
    else return n * Factorial (n-1);
}
for (double i = 1; i < 50; i++)
{
    Console.WriteLine ($"{i}! = {Factorial (i)}");
}