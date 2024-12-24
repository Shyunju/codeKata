using System;
namespace 백준
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Program p = new Program(); //전역변수 사용을 위한 인스턴스 화
            
            string s = Console.ReadLine();
            string[] sl = s.Split(" "); 

            int a = int.Parse(sl[0]);
            int b = int.Parse(sl[1]);
            
            Console.WriteLine(a*b);
        }
    }
}