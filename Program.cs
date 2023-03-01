// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 - > 1
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1000 || number < 100)
{
    Console.WriteLine(" Вы ввели не корректное число. Введите трехзначное число");
    return;
}
int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа - {secondDigit}");

int SecondDigit(int number)
{
    int result = number / 10 % 10;
    return result;
}