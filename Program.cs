//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine());
        PrintNumbers(N);
    }
static void PrintNumbers(int number)
    {
        if (number < 1) // базовый случай - если число меньше 1, то рекурсия завершается
            return;
        Console.Write(number + " ");
        PrintNumbers(number-1); // рекурсивный вызов функции для числа на 1 меньше
    }
}
