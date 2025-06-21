using System;
public class Program
{
    int n = 0;
    static void Main(string[] args)
    {
        Program p = new Program();
        string s = Console.ReadLine();
        p.n = int.Parse(s);
        
        long answer = 1;
        for(int i = p.n; i >0; i--)
        {
            answer *= i;
        }
        Console.WriteLine(answer);
    }
}