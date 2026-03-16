using System;
using System.Collections.Generic;
using System.Text;
public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        HashSet<int> hash = new HashSet<int>();
        List<int> ori = new List<int>();
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        for(int i = 0; i< n; i++)
        {
            int num = int.Parse(input[i]);
            hash.Add(num);
            ori.Add(num);
        }
        
        List<int> arr = new List<int>(hash.ToList());
        arr.Sort();
        
        StringBuilder sb = new StringBuilder();
        foreach(int i in ori)
        {
            int idx = arr.BinarySearch(i);
            if(idx >= 0)
            {
                sb.Append(idx + " ");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}