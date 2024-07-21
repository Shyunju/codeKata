using System;
namespace 백준
{
    internal class Program
    {
        
        static void Main(string[] args)
        {            
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];

            string num = Console.ReadLine();
            string[] input = num.Split(' ');
            for(int i = 0; i < n; i++){
                a[i] = int.Parse(input[i]);
            }
            Array.Sort(a);
            
            num = Console.ReadLine();
            string[] input2 = num.Split(' ');
            for(int j = 0; j < n; j++){
                b[j] = int.Parse(input2[j]);
            }
            Array.Sort(b);
            Array.Reverse(b);
            
            int s = 0;
            for(int k = 0; k < n; k++){
                s += a[k] * b[k];
            }
            Console.WriteLine(s);
        }
    }
}