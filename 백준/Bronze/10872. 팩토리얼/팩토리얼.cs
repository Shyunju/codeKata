using System;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int answer = 1;
        if(n == 0){
            Console.WriteLine(1);
            return;
        }
        for(int i = n; i > 0; i--)
        {
            answer *= i;
        }
        Console.WriteLine(answer);
    }
}