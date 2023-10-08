// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        double A = double.Parse(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int B = int.Parse(Console.ReadLine());

        double result = Power(A, B);

        Console.WriteLine($"{A} в степени {B} равно {result}");
    }

    static double Power(double A, int B)
    {
        double result = 1;
        for (int i = 0; i < B; i++)
        {
            result *= A;
        }
        return result;
    }
}