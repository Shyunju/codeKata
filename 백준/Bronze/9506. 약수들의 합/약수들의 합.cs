using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        List<int> m = new List<int>();
        while(true)
        {
            int n = int.Parse(Console.ReadLine());
            if(n == -1)
                return;
            m.Clear();
            for(int i = 1; i <= n/2; i++)
            {
                if(n % i == 0)
                    m.Add(i);
            }
            if(m.Sum() == n)
            {
                Console.Write($"{n} = ");
                int i = 1;
                StringBuilder sb = new StringBuilder();
                sb.Append(m[0].ToString());
                while(i < m.Count)
                {
                    sb.Append(" + " + m[i].ToString());
                    i++;
                }
                Console.WriteLine(sb.ToString());
            }else{
                Console.WriteLine($"{n} is NOT perfect.");
            }
        }
    }
}