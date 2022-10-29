Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
int y=-x;
while (y<x)
{
    Console.Write(y + ", "); 
    y=y+1; 
}
Console.WriteLine(y);
