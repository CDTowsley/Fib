using System;

namespace Fib
{
    class Fib
    {
        static void Main()
        {
            CalcFib fib = new CalcFib();
            Console.WriteLine("Fibonacci at 10: " + fib.CalculateFibonacci(10));
            Console.WriteLine("Fibonacci at 40: " + fib.CalculateFibonacci(40));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
