using System;
  
namespace Circle  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Console.WriteLine("Please enter radius for circle");  
            double radius = Convert.ToDouble(Console.ReadLine());  
            double circumference = CalculateCircle(radius, out double area);  
            Console.WriteLine($"Circle's circumference is {circumference}");  
            Console.WriteLine($"Circle's Area is {area}");  
            Console.ReadKey();  
        }  
  
       static double CalculateCircle(double radius, out double area)  
        {  
            double PI = 3.14;
            area = PI * radius * radius;  
            double circumference = 2 * PI * radius;  
            return circumference;  
        }  
    }  
}
