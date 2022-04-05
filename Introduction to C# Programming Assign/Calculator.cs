using System;
namespace Calc{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the action ");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch(num){
                case 1:
                result = Addition(a,b);
                break;
                case 2:
                result = Substraction(a,b);
                break;
                case 3:
                result = Multiplication(a,b);
                break;
                case 4:
                result = Division(a,b);
                break;
                default:
                Console.WriteLine("Incorrect action choosed");
                break;
            }
            Console.WriteLine("The Result is {0}", result);
            Console.ReadKey();
        }
        public static int Addition(int a, int b){
            int result = a+b;
            return result;
        }
         public static int Substraction(int a, int b){
            int result = a-b;
            return result;
        }
         public static int Multiplication(int a, int b){
            int result = a*b;
            return result;
        }
         public static int Division(int a, int b){
            int result = a/b;
            return result;
        }
    }
}
