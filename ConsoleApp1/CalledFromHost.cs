using System;

namespace ConsoleApp1
{
    public class CalledFromHost
    {
        public int Value;

        public static void ExecuteScript(string param)
        {
            Console.WriteLine($"Called by the C++ host with value `{param}`");
        }
    }
}
