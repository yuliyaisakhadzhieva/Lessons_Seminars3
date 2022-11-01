// Вид 1 - ничего не принимают, ничего не возвращают

// void Method1()
// {
//     Console.WriteLine ("Автор ...");
// };
// Method1();
    

// Вид 2 - что-то принимают, ничего не возвращают

// void Method2 (string msg)
// {
//     Console.WriteLine (msg);
// }
// Method2 ("Текст сообщения");


// void Method2 (string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine (msg);
//         i++;
//     }
// }
// // Method2 (msg: "Текст", count: 4);    ИЛИ
// Method2 (count: 4, msg: "Новый текст");


// Вид 3 - ничего не принимают, что-то возвращают

// int Method3 ()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3 ();
// Console.WriteLine (year);


// Вид 4 - что-то принимают, что-то возвращают

// string Method4 (int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4 (10, "abc");
// Console.WriteLine (res);


string Method4 (int count, string text)
{
    string result = string.Empty;
    for( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4 (5,"abc");
Console.WriteLine (res);

