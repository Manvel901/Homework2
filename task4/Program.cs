// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10)
{
    Console.Write(num);
}
else
{
    while (num > 0)
    {
        int digits = num % 10;
        num /= 10;
        if (num > 0)
        {
            Console.Write(digits + ",");
        }
        else
        {
            Console.Write(digits);
        }
    }
}

