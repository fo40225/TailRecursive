using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFibonacci
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // use release build and Debug > run without debugger
            Debugger.Launch();

            // 9X will arithmetic overflow, BigInteger will not trigger Tail call optimization
            var f = Fibonacci(90);
            Console.WriteLine(f.ToString());
        }

        public static long Fibonacci(long n)
        {
            var f0 = 0;
            var f1 = 1;
            return tailRecursiveAux(f0, f1, n);
        }

        private static long tailRecursiveAux(long a, long b, long count)
        {
            if (count < 1)
            {
                return a;
            }
            else
            {
                return tailRecursiveAux(b, a + b, count - 1);
            }
        }
    }
}