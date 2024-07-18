using System;
using System.Collections.Generic;
namespace 백준
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Program p = new Program(); //전역변수 사용을 위한 인스턴스 화
            int answer = 0;
            string s = Console.ReadLine();
            string[] sl = s.Split(" "); 
            
            int n = int.Parse(sl[0]);
            int k = int.Parse(sl[1]);
            
            List<int> coin = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int money = int.Parse(input);
                coin.Add(money);                
            }
            coin.Reverse();
            while( k > 0){
                if( k / coin[0] > 0){
                    answer += k / coin[0];
                    k %= coin[0];
                }
                coin.RemoveAt(0);
            }
            
            Console.Write(answer);
        }
    }
}