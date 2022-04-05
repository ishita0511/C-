using System;

namespace SwappingValues
{
    class Program
    {
        static void SwapNum(ref int x, ref int y)
        {
            int tempswap = x;
            x = y;
            y = tempswap;
        }
        static void Main(string[] args)
        {
            int a ,b;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());

            SwapNum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a and b after sawapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            Console.ReadLine();
        }
    }
}