using System;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int t = int.Parse(Console.ReadLine());
        
        
        for(int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int x = int.Parse(input[2]);
            int y = int.Parse(input[3]);
            
            Console.WriteLine(p.solve(m, n, x, y));
        }
    }
    public int gcd(int a, int b)
    {
        if(a == 0)
            return b;
        return gcd(b%a, a);
    }
    public int lcm(int a, int b)
    {
        return a * b / gcd(a,b);
    }
    public int solve(int m, int n, int x, int y)
    {
        if(x == m) x = 0;
        if(y == n) y = 0;
        int l = lcm(m,n);
        for(int j = x; j <= l; j += m)
        {
            if(j == 0)    continue;
            if(j % n == y)
            {
                return j;
            }
        }
        return -1;
    }
}