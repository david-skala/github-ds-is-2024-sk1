using System;
using System.Diagnostics;

class Program
{
    static ulong Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        ulong a = 0, b = 1, c = 0;

        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }

    static void Main()
    {
        Console.Write("Zadejte počet členů Fibonacciho posloupnosti (n): ");
        int n = int.Parse(Console.ReadLine());

        Stopwatch stopwatch = Stopwatch.StartNew();

        ulong sum = 0;
        string output = "";

        for (int i = 0; i < n; i++)
        {
            ulong fibNumber = Fibonacci(i);
            sum += fibNumber;
            output += fibNumber + "; ";
        }

        stopwatch.Stop();

        Console.WriteLine(output);
        Console.WriteLine($"{n}. prvek Fibonacciho posloupnosti je: {Fibonacci(n - 1)}");
        Console.WriteLine($"Součet posloupnosti (do {n} prvku): {sum}");
        Console.WriteLine($"Čas trvání výpočtu: {stopwatch.Elapsed}");
    }
}
