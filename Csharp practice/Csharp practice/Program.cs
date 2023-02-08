using System;

namespace Csharp_practice
{
    class Program
    {
        static void Main()

        {
            var x = Convert.ToInt32("1010", 2);
            var y = Convert.ToInt32("0101", 2);

            var and = x & y;
            Console.WriteLine($"{and}:{Convert.ToString(and, 2)}");

            var or = x | y;



        }
    }
}
