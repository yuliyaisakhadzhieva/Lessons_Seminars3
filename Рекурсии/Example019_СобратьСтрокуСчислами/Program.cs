﻿// Итерации
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)        // (int i = a; i>=b; i--)
    {
        result += $"{i}";
    }
    return result;
}

// Рекурсия
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a}" + NumbersRec(a + 1, b);
    else return string.Empty;
}
Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));

