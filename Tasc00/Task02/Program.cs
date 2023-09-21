
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите  число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число в");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    int max = a;
    int min = b;
    Console.WriteLine("Большее число = " + max);
    Console.WriteLine("Mеньшее число = " + min);
}
else
{
    int max = b;
    int min = a;
    Console.WriteLine("Большее число = " + max);
    Console.WriteLine("Mеньшее число = " + min);
}