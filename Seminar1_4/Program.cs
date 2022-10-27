try
{
    Console.WriteLine("Введите натуральное число ");
    int x=Convert.ToInt32 ( Console.ReadLine());

    Console.WriteLine("Введите натуральное число ");
    int y=Convert.ToInt32 ( Console.ReadLine());
    if (x*x==y) Console.WriteLine ("Второе число является квадратом первого");
    else if (y*y==x) Console.WriteLine ("Первое число является квадратом второго");
    else Console.WriteLine ("No");
}
catch
{
Console.WriteLine("Вы ввели некорректные данные");
}