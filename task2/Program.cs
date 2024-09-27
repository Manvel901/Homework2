// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Введите первое число: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Y = Convert.ToInt32(Console.ReadLine());
if (X == 0 && Y == 0)
{
    Console.Write("Ошибка данных !");
}
else if (X > 0 && Y > 0)
{
    Console.Write("Первая четверть");
}
else if (X > 0 && Y < 0)
{
    Console.Write("Четвёртая четверть");
}
else if (X < 0 && Y < 0)
{
    Console.Write("Третья четверть");
}
else
{
    Console.Write("Вторая четверть");
}