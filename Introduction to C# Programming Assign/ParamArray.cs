using System;
  
class ParamArray {   
    static int sum(int []arr, int n)
    { 
        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += arr[i];         
        return sum;
    }
      
    public static void Main() 
    {
        Console.WriteLine("Enter the number of elements: ");
        int n= Convert.ToInt32(Console.ReadLine());
        int []arr = new int[n];
        Console.WriteLine("Enter the numbers: ");
        for(int i = 0;i<n;i++)
        {
            arr[i]= Convert.ToInt32(Console.ReadLine());
        } 
        Console.Write("Sum of given array is "+ sum(arr, n));
    }
  
}
