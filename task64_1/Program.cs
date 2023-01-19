// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> 1,2,3,4,5
// M = 4; N = 8. -> 4,6,7,8

// В семинаре вы сказали не делать тоже самое, а сделать, например умножене чисел

Console.Write("Введите первое число диапазона : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число диапазона : ");
int n = Convert.ToInt32(Console.ReadLine());

int Mult(int m, int n)
{
    if (n == m) return m;
    return n * Mult(m, n - 1);
}
Console.WriteLine($"Произведение чисел в диапазоне: {Mult(m, n)}");