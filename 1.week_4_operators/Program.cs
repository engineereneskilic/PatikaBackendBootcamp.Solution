using System;

namespace _1.week_4_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            int sum = a + b;
            int diff = a - b;
            int quatient = a / b;

            Console.WriteLine(sum);

            int remainder = b % a;

            bool isEqual = a == b;
            bool isNotEqual = a != b;

            bool isGreaterThan = a > b;

            bool isLessThan = a < b;

            bool lessThanOrEqual = a <= b;

            bool isGreaterThanOrEqual = a >= b;

            bool result = (a > 0) && (b > 0);

            bool result2 = a > 0 || b > 0;

            bool notResult = !(a > b);

            a = a + 5;
            a += 10;
        }
    }
}
