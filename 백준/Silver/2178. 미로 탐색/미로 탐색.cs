using System;
namespace 백준
{
    internal class Program
    {
        int n, m;
        
        int[] dx = {-1, 1, 0, 0};
        int[] dy = {0, 0, -1, 1,};
        
        Queue<(int, int)> q = new Queue<(int, int)>();
        
        static void Main(string[] args)
        {
            Program p = new Program(); //전역변수 사용을 위한 인스턴스 화
            
            string s = Console.ReadLine();
            string[] sl = s.Split(" "); 
            p.n = int.Parse(sl[0]);
            p.m = int.Parse(sl[1]);
            
            int[,] arr = new int[p.n, p.m];

            for (int i = 0; i < p.n; i++)
            {
                string input = Console.ReadLine();
                for (int k = 0; k < input.Length; k++)
                {
                    //입력값을 2차원배열에 넣음
                    arr[i, k] = int.Parse(input[k].ToString()); 
                }
            }
            p.bfs(arr);
            
            Console.WriteLine("{0}", arr[p.n-1, p.m-1]);
        }
        public void bfs(int[,] arr)
        {
            q.Enqueue((0, 0));
            
            while(q.Count != 0)
            {
                (int a, int b) = q.Dequeue();
                
                for(int k = 0; k < 4; k++)
                {
                    int nx = a + dx[k];
                    int ny = b + dy[k];
                    
                    if(nx < 0 || nx >= n || ny < 0 || ny >= m)
                        continue;
                    if(arr[nx, ny] == 0)
                        continue;
                    if(arr[nx, ny] == 1)
                    {
                        arr[nx, ny] = arr[a, b] +1;
                        q.Enqueue((nx, ny));
                    }
                }
            }
        }
    }
}