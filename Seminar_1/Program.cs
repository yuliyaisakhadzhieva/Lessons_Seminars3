Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
int y = x*x;
Console.WriteLine("Вот посчитали квадрат введеного вами числа и это цифра - "+y);
if (x==8)
{
    Console.WriteLine("Вы ввели восемь");
}
else Console.WriteLine("Вы ввели число отличное от 8");
int i = 0;
while (i<x)
{
    Console.WriteLine($"счетчик цикла равен {i}");
    i=i+1;
}
