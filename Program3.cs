using System;
  
class GFG { 
      
    // method for sum of elements in an array 
    static int sum(int []arr, int n)
    {
          
        int sum = 0; // initialize sum
          
        // Iterate through all elements and 
        // add them to sum
        for (int i = 0; i < n; i++)
            sum += arr[i];
          
        return sum;
    }
      
    // Driver method
    public static void Main() 
    {
          
        int []arr = {12,3,4,15};
        int n = arr.Length;
          
        Console.Write("Sum of given array is "
                               + sum(arr, n));
    }
  
}