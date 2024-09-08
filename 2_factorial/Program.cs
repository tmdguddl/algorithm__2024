using System;

namespace FactorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요: ");
            long num = Convert.ToInt64(Console.ReadLine()); 

            Console.WriteLine($"{num}의 팩토리얼: {Factorial(num)}");
        }

        static long Factorial(long f)      //반복문 
        {
            if (f == 1)
                return 1;
            else
                return Factorial(f - 1) * f;
        }
    }
}

/*static long Factorial(long f)     //재귀 사용 
{
    long fact = 1;
    for (int i = 2; i <= f; i++) // 2부터 f까지 곱셈
    {
        fact *= i;
    }
    return fact;
}*/
