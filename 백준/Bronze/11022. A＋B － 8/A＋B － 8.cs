//"Case #x: A + B = C" 형식으로 출력한다. x는 테스트 케이스 번호이고 1부터 시작하며

using System;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 1; i <= n; i++){
            string s = Console.ReadLine();
            string[] sl = s.Split();
            
            int a = int.Parse(sl[0]);
            int b = int.Parse(sl[1]);
            
            Console.WriteLine("Case #" + i + ": " + a + " + " + b + " = " + (a+b));
        }
    }
}