using System;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sqrt = (int)Math.Sqrt(n);
        
        int d = 2;
        while(d <= sqrt)
        {
            if(n % d != 0)
            {
                d++;
            }else{
                Console.WriteLine(d);
                n /= d;
            }
        }
        if(n > 1)
            Console.WriteLine(n);
    }
}