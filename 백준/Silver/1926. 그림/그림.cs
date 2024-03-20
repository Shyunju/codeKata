using System;
using System.Collections.Generic;
namespace 백준
{
    internal class Program
    {
        Queue<(int, int)> q = new Queue<(int, int)>();
        int max = 0;
        int a, b;
        int picture = 0;
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        static void Main(string[] args)
        {
            Program p = new Program();
            string s = Console.ReadLine();
            string[] sl = s.Split(" ");

            p.a = int.Parse(sl[0]);
            p.b = int.Parse(sl[1]);  // a= 행 b=열

            int[,] arr = new int[p.a, p.b];
            bool[,] check = new bool[p.a, p.b];

            for (int i = 0; i < p.a; i++)
            {
                string input = Console.ReadLine();
                string[] inputl = input.Split(" ");
                for (int k = 0; k < inputl.Length; k++)
                {
                    //입력값을 2차원배열에 넣음
                    arr[i, k] = int.Parse(inputl[k].ToString());
                }
            }

            for (int i = 0; i < p.a; i++)
            {
                for (int j = 0; j < p.b; j++)
                {
                    if (arr[i, j] == 1 && !check[i, j])
                    {
                        check[i,j]= true;
                        p.bfs(i, j, arr, check);
                        p.picture++;
                    }
                }
            }
            Console.WriteLine("{0}", p.picture);
            Console.Write("{0}", p.max);
        }

        public void bfs(int i, int j, int[,] arr, bool[,] check)//시작점
        {
            int count = 0;

            q.Enqueue((i, j));

            while (q.Count != 0)
            {
                (int n, int m) = q.Dequeue();
                count++;

                for (int k = 0; k < 4; k++)
                {
                    int nx = n + dx[k];
                    int ny = m + dy[k];

                    if (nx < 0 || nx >= a || ny < 0 || ny >= b)
                        continue;
                    if (arr[nx, ny] == 0)
                        continue;
                    if (arr[nx, ny] == 1 && !check[nx, ny])
                    {
                        check[nx, ny] = true;
                        q.Enqueue((nx, ny));
                    }
                }
            }
            if (count > max)
                max = count;

        }
    }
}