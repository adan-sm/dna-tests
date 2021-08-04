using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class CalledFromHost
    {
        public int Value;

        public static void ExecuteScript(string param)
        {
            var list = new List<string>
            {
                "test 1", 
                "test 2", 
                "test 3"
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Called by the C++ host with value `{param}`");
        }
    }
}
