// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. 
//  456 -> 46 782 -> 72 918 -> 98

int x=new Random().Next(100, 999);

int x1=x/100;
int x2=x/10;
int x3=x%10;

Console.WriteLine(x);
Console.Write(x1);
Console.Write(x3);

