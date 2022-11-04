﻿// Метод вывода картинки с закрашенной областью. Массив обычно задается изначально.

int [,] pic = new int [23,25];

void PrintImage (int [,] image)
{
    for (int i = 0; i < image.GetLength (0); i++)
    {
      for (int j = 0; j < image.GetLength (1); j++)
      {
        if (image [i,j] == 0) Console.Write ($" ");
        else Console.Write ($"+");
      }  
      Console.WriteLine ();
    }
}
void FullImage (int row, int col)
{
    if (pic [row, col] == 0)
    {
        pic [row, col] = 1;
        FillImage (row-1, col);
        FillImage (row, col-1);
        FillImage (row+1, col);
        FillImage (row, col+1);
    }
}
PrintImage (pic);
FillImage (13, 13);
PrintImage (pic);
