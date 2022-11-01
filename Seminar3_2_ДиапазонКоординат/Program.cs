// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти"); 
int num = Convert.ToInt32(Console.ReadLine()); 
string res; 
if (num==1) res="x>0 и y>0"; 
else if  (num==2) res="x<0 и y>0"; 
else if  (num==3) res="x<0 и y<0"; 
else if  (num==4) res="x>0 и y<0"; 
else res = "нет такой четверти"; 
Console.WriteLine(res);
