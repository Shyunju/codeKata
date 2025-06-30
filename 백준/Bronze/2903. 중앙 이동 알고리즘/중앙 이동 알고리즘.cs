using System;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n+1];
        
        arr[0] = 4;
        for(int i = 1; i <= n; i++)
        {
            arr[i] = (int)Math.Pow((int)Math.Sqrt(arr[i-1])* 2 - 1, 2);
        }
        Console.WriteLine(arr[n]);
    }
}