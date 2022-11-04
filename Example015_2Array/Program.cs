// string [,] table = new string [2, 5];
// table [1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine ($"-{table[rows,columns]}-");
//     }
// }


// table [0,0]  table [0,1]   table [0,2] и т.д. по количеству столбцов
// table [1,0]  table [1,1]   table [0,2] и т.д.
// Индексы иеняются от 0

int [,] matrix = new int [3,4];

void PrintArray (int [,] matr)
{
for (int i =0; i < matrix.GetLength(0); i++)
{
    for (int j =0; j < matrix.GetLength(0); j++)
    {
        Console.Write ($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
}
PrintArray (matrix);
FillArray (matrix);
Console.WriteLine ();
PrintArray (matrix);

void FillArray (int [,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
     for (int j =0; j < matrix.GetLength(0); j++)
     {
        matr [i,j] = new Random ().Next(1,10);
     }   
    }
}
