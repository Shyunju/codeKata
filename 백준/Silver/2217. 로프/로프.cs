using System;
namespace 백준
{
    internal class Program
    {            
        static void Main(string[] args)
        {            
            int n = int.Parse(Console.ReadLine());
            int[] w = new int[n];
            for(int i = 0; i < n; i++){
                int weight = int.Parse(Console.ReadLine());
                w[i] = weight;
            } 
            Array.Sort(w);
            int answer = 0;
            for(int j = 1; j <= n; j++){
                answer = Math.Max(answer, w[n - j] * j);
            }
            Console.WriteLine(answer);            
        }
    }
}