using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int n = int.Parse(Console.ReadLine());
        int i = 2;
        while(n > 1)
        {
            if(i*i > n)
            {
                Console.WriteLine(n);
                break;
            }
            if(n % i == 0)
            {
                Console.WriteLine(i);
                n /= i;
                
                continue;
            }
            i++;
        }
    }
}