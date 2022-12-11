/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Является ли этот день выходным? Введите число:");
int dayNumber = int.Parse(Console.ReadLine() ?? "");

if (dayNumber >= 1 && dayNumber <= 7)
{
    if (dayNumber >= 1 && dayNumber <= 5)
    {
        Console.WriteLine ("нет");
    }

    else
    {
        Console.WriteLine ("да");
    }
}

else
{
    Console.WriteLine ("Вы ввели неправильное число");
}