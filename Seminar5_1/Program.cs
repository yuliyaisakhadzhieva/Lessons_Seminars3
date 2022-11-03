﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20

// int[] arr = new int[12];
// for (int i=0;i<12;i++) 
// {
//     arr[i]= new Random().Next(-9,10);
//     Console.Write($"{arr[i]} ");
// }
// Console.WriteLine();
// int sumP=0;
// int sumN=0;
// foreach (int el in arr)
// {
//      if (el>=0) sumP=sumP+el;
//      else sumN=sumN+el;
// }
// Console.WriteLine($"Сумма положительных чисел равна {sumP}");
// Console.WriteLine($"Сумма отрицательных чисел равна {sumN}");

// int[] CreateFillArray()

// {
//     int[] arr = new int[12];
//     for (int i=0;i<12;i++) 
//     {
//         arr[i]= new Random().Next(-9,10);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     return arr;
// }

// void FindSums(int[] arr)
// {
//     int sumP=0;
//     int sumN=0;
//     foreach (int el in arr)
//     {
//         if (el>=0) sumP=sumP+el;
//         else sumN=sumN+el;
//     }
//     Console.WriteLine($"Сумма положительных чисел равна {sumP}");
//     Console.WriteLine($"Сумма отрицательных чисел равна {sumN}");
// }

// int[] mas = CreateFillArray();
// FindSums(mas);


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] arr = {-4, -8, 8, 2};  
// for (int i=0;i<4;i++)     
// {
//     arr [i] = 0-arr[i];     
//     Console.Write($"{arr[i]}  ");     
// }


// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да

// int[] arr = { 6, 7, 19, 345, 3 };
// foreach (int el in arr)
// {
//     Console.Write($"{el} ");
// }
// Console.WriteLine();
// Console.WriteLine("Введите искомое число");
// int x = Convert.ToInt32(Console.ReadLine());
// bool find = false; for (int i = 0; i < 5; i++)
// {
//     if (arr[i] == x)
//     {
//         find = true;
//         break;
//     }
// }
// if (find) Console.WriteLine("Данное число есть в массиве");
// else Console.WriteLine("Такого числа нет в массиве");


// Задача 35: Задайте одномерный массив из 13 случайных чисел от 0 до 100. Найдите количество элементов массива, 
// значения которых лежат в отрезке [40,99]. 

int[] CreateFillArray()

{
int[] arr = new int[13];
for (int i=0;i<13;i++)
{
arr[i]= new Random().Next(0,101);
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
return arr;
}

void FindCount(int[] arr)
{
int count=0;
foreach (int el in arr)
{
if (el>=40 && el<=99) count++;
}
Console.WriteLine(count);
}
int [] arr = CreateFillArray();
FindCount(arr);





// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21

