// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberС = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > numberA)
{
    max = numberB;
}
if (numberС > numberA)
{
    max = numberС;
}

Console.WriteLine($"Максимальное значение числа: {max}");
