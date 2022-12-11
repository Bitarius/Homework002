/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/



Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "");

if (number >= 100 || number <= -100)
    {
        while (number > 999 || number < -999)
        {
            number = number / 10;
        }
        int result = Math.Abs(number % 10);
        Console.WriteLine ($"Третья цифра: {result}");
    }
else
{
    Console.WriteLine ("Третьей цифры нет");
}
