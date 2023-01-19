// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число диапазона : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число диапазона : ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum(int m, int n)
{
    if (n == m) return m;
    return n + Sum(m, n - 1);
}
Console.WriteLine($"Сумма чисел в диапазоне: {Sum(m, n)}");