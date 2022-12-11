/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine() ??"");

int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}

int InCenter(int a)
{
    int result = ((a / 10) % 10);
    return result;
}