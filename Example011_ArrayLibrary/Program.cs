﻿void FillArray (int [] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection [index] = new Random().Next(1, 10);
        index ++;
    }
}

void PrintArray (int [] collect)
{
    int count = collect.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (collect [position]);
        position ++;
    }
}


int IndexOf (int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    // int position = 0; Если мы ставим в значении "-1", то можно принимать как результат "Элемента нет"

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            // break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];

FillArray (array);
// array [4] = 4;
// array [6] = 4;
PrintArray (array);
Console.WriteLine ();

int pos = IndexOf (array, 44);
Console.WriteLine (pos);
