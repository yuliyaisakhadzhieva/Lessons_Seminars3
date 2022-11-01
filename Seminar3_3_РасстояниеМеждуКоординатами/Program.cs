// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.  
// A (3,6); B (2,1) -> 5,09  
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координату x1");  
// int x1 = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Введите координату y1");  
// int y1 = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Введите координату x2");  
// int x2 = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Введите координату y2");  
// int y2 = Convert.ToInt32(Console.ReadLine());  
// int xa = (x1 - x2); 
// int ya = (y1 - y2); 
// double c =  Math.Pow(xa, 2); 
// double b =  Math.Pow(ya, (2)); 
// double d = Math.Sqrt(c+b); 
// Console.Write($"{d}");

// Второй вариант решения

Console.WriteLine("Введите координаты x точки a"); 
int ax = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты y точки a"); 
int ay = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты x точки b"); 
int bx = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты y точки b"); 
int by = Convert.ToInt32(Console.ReadLine());  

double dist = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)); 
Console.WriteLine($"Расстояние между двумя точками равно  {dist}");