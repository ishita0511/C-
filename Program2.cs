using System;
public class HighestMarks
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5]; 
            int i, max;
            Console.WriteLine("Enter the Marks of Students");
            for(i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[i];
            for(i=0;i<arr.Length;i++){
                if(max<arr[i])
                    max = arr[i];
            }
            Console.WriteLine("The maximum marks is {0}",max);
        }
    }