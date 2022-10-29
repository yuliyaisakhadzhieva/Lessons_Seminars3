int [] array = {18, 6, 32, 47, 225, 63, 522, 568};

int n = array.Length;
int find = 225;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine (index);
        // break;  Усли в массиве несколько одинаковый элементов, но нужно найти только первый с таким значением
    }
    index ++;
}

