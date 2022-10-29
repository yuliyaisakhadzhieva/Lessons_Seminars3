Console.WriteLine("Введите число дня недели");
int x=Convert.ToInt32 ( Console.ReadLine());

if (x == 1) Console.WriteLine ("Понедельник");
else if (x == 2) Console.WriteLine ("Вторник");
else if (x == 3) Console.WriteLine ("Среда");
else if (x == 4) Console.WriteLine ("Четверг");
else if (x == 5) Console.WriteLine ("Пятница");
else if (x == 6) Console.WriteLine ("Суббота");
else if (x == 7) Console.WriteLine ("Воскресень;е");
else Console.WriteLine ("Вы ввели не то число");

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//  3 -> Среда  5 -> Пятница