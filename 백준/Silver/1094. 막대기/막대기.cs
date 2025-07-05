using System;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int x = int.Parse(Console.ReadLine());
        int n = 64;
        int answer = 0;
        
        while(x >0)
        {
            if( x / n > 0)
            {
                answer += x / n;
                x %= n;
            }
            n /= 2;
        }
        Console.WriteLine(answer);
    }
}