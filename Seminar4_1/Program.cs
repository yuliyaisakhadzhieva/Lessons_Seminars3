// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А. 7 -> 28 4 -> 10 8 -> 36

// Console.WriteLine("Введите целое число"); 
// int n = Convert.ToInt32(Console.ReadLine());
// int sum=0;
// for (int i =1; i<=n;i++) sum=sum+i;
// Console.WriteLine($"Сумма всех чисел от 1 до {n} равна {sum}");  
// void SumNumbers(int x) 
// {     
//     int sum=0;     
//     for (int i =1; i<=x;i++)          
//         sum=sum+i;     
//         Console.WriteLine($"Сумма всех чисел от 1 до {x} равна {sum}");
// }  
// int SumNumbers2(int x)
// {     
//     int sum=0;     
//     for (int i =1; i<=x;i++)          
//     sum=sum+i;     
//     return sum; 
// }   
// Console.WriteLine("Введите целое число"); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// SumNumbers(n); 
// Console.WriteLine(SumNumbers2(n));





// Задача 26: Напишите программу, которая принимает на вход число и выдаёт
// количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5

// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine()); 
// int i = 0;

// while (n>0)
// {
//     n /= 10;
//     i++;
// }
// Console.WriteLine (i);


// Console.WriteLine("Введите вещественное (дробное) число");
// double n = Convert.ToDouble(Console.ReadLine()); 
// int i = 0;

// while (n>0)
// {
//     n /= 0.10;
//     i++;
// }
// Console.WriteLine (i);

// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N. 4 -> 24  5 -> 120

// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine()); 

// int CompNumbers(int x)
//  {     
//     int comp = 1;
//     for (int i =1; i<=x;i++)          
//     comp = comp * i;
//     return comp;
// } 
// Console.WriteLine($"Произведение всех чисел от 1 до {n} равна {CompNumbers (n)}"); 

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]


int [] arr = new int[8];

for (int i = 0; i < 8; i++)
{
    int x=new Random().Next(0, 2);
    arr [i] = x;
    Console.Write ($"{arr[i]} ");
}

bool Method (int array)
{
    int c1, c0 = 0;
    for (int i = 0; i < 8; i++)
    {
        if (array [i] == 0) c0++;
        else c1++;
    }
    return c0 < c1;
}

