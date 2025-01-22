using System;

namespace BaekjoonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split();

            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            int[] N = new int[n];

            int i;
            int temp;
            for(i = 0; i < N.Length; i++)
            {
                N[i] = i + 1;
            }
            for(i = 0; i<m; i++)
            {
                string[] ab = Console.ReadLine().Split();
                int a = int.Parse(ab[0])-1;
                int b = int.Parse(ab[1])-1;

                while (a < b)
                {
                    temp = N[a];
                    N[a++] = N[b];
                    N[b--] = temp;
                }
            }
            for(i = 0; i < N.Length; i++)
            {
                Console.Write(N[i] + " ");
            }
        }
    }
}
