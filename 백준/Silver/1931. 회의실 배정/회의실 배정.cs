using System;
using System.Collections.Generic;
using System.Linq;
namespace 백준
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            string num = Console.ReadLine();
            int n = int.Parse(num);
            (int start, int end)[] time = new(int, int)[n];
             
            
            for(int i = 0; i < n; i++){
                string s = Console.ReadLine();
                string[] sl = s.Split(" ");
                
                int a = int.Parse(sl[0]);
                int b = int.Parse(sl[1]);
                
                time[i] = (a, b);
            }
            Array.Sort(time, (x, y) => Compare(x, y));
            
            int answer= 0;
            int t = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (t <= time[i].start) // 회의 종료 시점이 다음 회의 시작지점보다 적다면
                {
                    t = time[i].end;
                    answer++;
                }
            }
            Console.Write(answer);
            
            int Compare((int start, int end) x, (int start, int end) y)
            {
                if (x.end == y.end) // 끝나는 순서가 같다면
                    return (x.start < y.start) ? -1 : 1; // 시작하는 순서가 빠른 순으로
                else
                    return (x.end < y.end) ? -1 : 1; // 끝나는 순서가 빠른 순으로
            }

        }
    }
}