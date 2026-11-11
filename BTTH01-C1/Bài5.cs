using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH01_C1
{
    internal class Bài5
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập n (n >= 0): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                long result = GetFibonacci(n);
                Console.WriteLine($"Số Fibonacci thứ {n} là: {result}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ!");
            }
        }

        static long GetFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            long a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
