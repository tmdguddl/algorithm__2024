using System;

class Program
{
    static int Fibonacci(int i)
    {
        if (i == 1 || i == 2)
            return 1;
        else
            return Fibonacci(i - 1) + Fibonacci(i - 2);
    }

    static void Main()
    {
        Console.Write("숫자를 입력하세요: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("피보나치 수열은: ");
        for (int i = 1; i <= n; ++i)
        {
            Console.Write(Fibonacci(i));
            if (i < n)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
