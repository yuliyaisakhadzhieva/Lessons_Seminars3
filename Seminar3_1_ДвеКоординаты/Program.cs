// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),  
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату x");
int x = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату y"); 
int y = Convert.ToInt32(Console.ReadLine()); 
string res; 
if (x>0 && y>0) res="Это первая четверть"; 
else if  (x<0 && y>0) res="Это вторая четверть"; 
else if  (x<0 && y<0) res="Это третья четверть"; 
else if  (x>0 && y<0) res="Это четвертая четверть"; 
else res = "точка находится на оси";
Console.WriteLine(res);


// Решение через функцию

// void CheckKoord(int x, int y)    //этот тип функции ничего не возвращает в основную программу, но что-то делает 
// {     
// string res;     
// if (x>0 && y>0) res="Это первая четверть";     
// else if  (x<0 && y>0) res="Это вторая четверть";     
// else if  (x<0 && y<0) res="Это третья четверть";     
// else if  (x>0 && y<0) res="Это четвертая четверть";     
// else res = "точка находится на оси";     
// Console.WriteLine(res);  
// }  
// try 
// {     
// Console.WriteLine("Введите координату x");     
// int xx = Convert.ToInt32(Console.ReadLine());     
// Console.WriteLine("Введите координату y");     
// int yy = Convert.ToInt32(Console.ReadLine());     
// CheckKoord(xx,yy); 
// } 
// catch  
// {     
// Console.WriteLine("Введены некорректные данные");
// }

