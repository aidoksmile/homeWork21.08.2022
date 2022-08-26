// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти: ");
int n = int.Parse(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("Диапазоны для возможных координат: x > 0, y > 0");
}
else if (n == 2)
{
    Console.WriteLine("Диапазоны для возможных координат: x < 0, y > 0");
}
else if (n == 3)
{
    Console.WriteLine("Диапазоны для возможных координат: x < 0, y < 0");
}
else
{
    Console.WriteLine("Диапазоны для возможных координат: x > 0, y < 0");
}