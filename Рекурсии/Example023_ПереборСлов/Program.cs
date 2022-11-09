// В некотором машинном алфавите имеются 4 буквы: а, и, с и в. 
// Покажите все слова состоящие из Т букв, которые можно постороить из букв этого алфавита.

// Итерации
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5} {s[i]} {s[j]} {s[k]}{s[l]}{s[m]}");
                }
            }
        }
    }
}

// Рекурсия

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new string(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[2]);

