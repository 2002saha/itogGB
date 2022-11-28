using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
var str = string.Join(" ", array1);
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayWithIF(array1, array2);
Console.ResetColor();
Console.Clear();
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine($"\nЗначения из вашего массива:");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine(str);

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"\nНайдено:");
Console.WriteLine();
Console.ResetColor();
PrintArray(array2);

Console.WriteLine();
Console.ReadKey();
Console.Clear();