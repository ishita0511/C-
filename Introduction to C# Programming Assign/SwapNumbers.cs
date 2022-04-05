using System;

namespace SwapNumbers
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
            Console.WriteLine("Value of numbers after sawapping");
            Console.WriteLine("First Number =" + " " + a);
            Console.WriteLine("Second Number =" + " " + b);
            Console.ReadLine();
        }
    }
}
