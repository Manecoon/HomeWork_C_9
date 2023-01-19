// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите первое число отсчета до 1: ");
int k = Convert.ToInt32(Console.ReadLine());

void RowOfNumbers(int n)
{
    Console.Write($"{n} ");
    if (n == 1) return;
    RowOfNumbers(n - 1);
}

RowOfNumbers(k);