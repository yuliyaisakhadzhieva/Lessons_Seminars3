int Max (int arg1, int arg2, int arg3)
{
    int result_max = arg1;
    if (arg2 > result_max) result_max = arg2;
    if (arg3 > result_max) result_max = arg3;
    return result_max;
};
//               0   1   2   3   4   5   6   7   8   
int [] array = {11, 12, 25, 326, 12, 65, 78, 32, 13};
// array [0] = 12;    Позволяет обратиться к массиву и записать значение в позицию с указанным индексом [0]
// Console.WriteLine (array [4]);    Позволяет обрптиться к массиву и получить значение соответствующего элемента по указанному индексу [0]

int max = Max (
    Max (array [0], array [1], array [2]),
    Max (array [3], array [4], array [5]), 
    Max (array [6], array [7], array [8]));

Console.WriteLine (max);


