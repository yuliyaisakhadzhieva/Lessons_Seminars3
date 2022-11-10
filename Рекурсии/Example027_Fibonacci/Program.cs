﻿decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}
decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

Console.ReadLine();
DateTime dt = DateTime.Now;
for (int n = 1; n < 5; n++)
{
    Console.WriteLine($"FibonacciIteration ({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();

Console.ReadLine();
dt = DateTime.Now;
for (int n = 1; n < 5; n++)
{
    Console.WriteLine($"FibonacciRecurcion ({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.ReadLine();
