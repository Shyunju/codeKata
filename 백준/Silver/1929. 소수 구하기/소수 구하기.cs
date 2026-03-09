using System;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        bool[] state = new bool[1000001];
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        
        state[0] = true;
        state[1] = true;
        for(int i = 2; i*i <= m; i++)
        {
            if(state[i])    continue;
            for(int j = i*i; j<=m; j+=i)
            {
                state[j] = true;
            }
        }
        for(int i = n; i <= m; i++)
        {
            if(!state[i])
                Console.WriteLine(i);
        }
    }
}