using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        extern static string gimme();

        public static void Fibonacci(int n)
        {
            string[] strings = new string[n];

            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 0; i < n; i++)
            {
                strings[i] = $"Fibonacci {i + 1} = {c}";
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine(strings[strings.Length - 1]);
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World {gimme()}");

#if MEASURE_TIME
            var stopWatch = Stopwatch.StartNew();
#endif

            for (int i = 0; i < 100; i++)
            {
                Fibonacci(150);
            }

#if MEASURE_TIME
            stopWatch.Stop();
            var elapsed = stopWatch.ElapsedMilliseconds;

            Console.WriteLine($"Elapsed: {elapsed}");
#endif
        }
    }
}
