using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int n = int.Parse(Console.ReadLine());
        
        List<int> num = new List<int>();
        HashSet<int> two = new HashSet<int>();
        for(int i = 0; i < n; i++)
        {
            num.Add(int.Parse(Console.ReadLine()));
        }
        for(int i = 0; i < n; i++)
        {
            for(int j = i; j < n; j++)
            {
                two.Add(num[i] + num[j]);
            }
        }
        num.Sort();
        for(int i = n-1; i > 0; i--)
        {
            for(int j = 0; j < i; j++)
            {
                if(two.Contains(num[i]-num[j]))
                {
                    Console.Write(num[i]);
                    return;
                }
            }
        }
    }
}