using System;
namespace 백준
{
    internal class Program
    {
        Queue<int> q = new Queue<int>();
        static void Main(string[] args)
        {
            Program p = new Program();
            
            string s = Console.ReadLine();
            string[] sl = s.Split(" "); 
            
            int n = int.Parse(sl[0]);
            int k = int.Parse(sl[1]);
            
            int[] dir = new int[]{-1, 1};
            
            int[] dist = Enumerable.Repeat(-1, 100002).ToArray();
            dist[n] = 0;
            
            p.q.Enqueue(n);
            
            while(dist[k] == -1)
            {
                int cur = p.q.Dequeue();
                int nxt = 0;
                for(int i = 0; i < 3; i++)
                {
                    if(i == 2)
                    {
                        nxt = cur * 2;
                    }else{
                        nxt = cur + dir[i];
                    }
                    
                    if(nxt < 0 || nxt > 100000) continue;
                    if(dist[nxt] != -1) continue;
                    
                    dist[nxt] = dist[cur] +1;
                    p.q.Enqueue(nxt);
                }
            }
            Console.WriteLine("{0}", dist[k]);
        }
    }
}