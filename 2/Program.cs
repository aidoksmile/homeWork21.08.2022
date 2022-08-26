// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine($"Число {number1} является квадратом {number2}");
}
else if (number2 == number1 * number1)
{
    Console.WriteLine($"Число {number2} является квадратом {number1}");
}
else
{
    Console.WriteLine("Нет, числа не являются квадратами друг друга");   
}