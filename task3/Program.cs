// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите целое число из промежутка [10, 99]: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 10 && num <= 99)
{
    int firstDigit = num / 10;
    int lastDigit = num % 10;
    int max = firstDigit;
    if (max > lastDigit)
    {
        Console.Write(max);
    }
    else
    {
        Console.Write(lastDigit);
    }
}
else
{
    Console.Write("Ошибка ввода!");
}