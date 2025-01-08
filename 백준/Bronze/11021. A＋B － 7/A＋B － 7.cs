//각 테스트 케이스마다 "Case #x: "를 출력한 다음, A+B를 출력한다. 테스트 케이스 번호는 1부터 시작한다.

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
            
            Console.WriteLine("Case #" + i + ": " + (a+b));
        }
    }
}