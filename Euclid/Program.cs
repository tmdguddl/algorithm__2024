using System;

class Program
{
    static void Main()
    {
        // 사용자로부터 a 값을 입력받기
        Console.Write("a 값을 써주시오: ");
        int a = int.Parse(Console.ReadLine());

        // 사용자로부터 b 값을 입력받기
        Console.Write("b 값을 써주시오: ");
        int b = int.Parse(Console.ReadLine());

        // 최대 공약수 계산 및 출력
        Console.WriteLine($"{a}와 {b}의 최대 공약수는 {GCD(a, b)}입니다.");
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}
