// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1 



int Prompt(string msg)
{

System.Console.WriteLine(msg);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}
int number = Prompt("Введите трехзначное число");
if (number < 100 || number >=1000)
{

Console.WriteLine("Вы ввели не трехзначное число");
}
else

Console.WriteLine($"Ваше число `{number}`");
int secondDigit = number / 10 % 10;
Console.WriteLine ($"Вторая цифра Вашего числа `{secondDigit}`");

