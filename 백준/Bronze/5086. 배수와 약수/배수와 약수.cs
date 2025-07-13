// 첫 번째 숫자가 두 번째 숫자의 약수라면 factor를, 배수라면 multiple을, 둘 다 아니라면 neither를 출력한다.
using System;

public class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            string s = Console.ReadLine();
            string[] sl = s.Split();
            int a = int.Parse(sl[0]);
            int b = int.Parse(sl[1]);
            
            if(a == b)
                return;
            if(a % b == 0)
            {
                Console.WriteLine("multiple");
                continue;
            }
            if(b % a == 0)
            {
                Console.WriteLine("factor");
                continue;
            }
            Console.WriteLine("neither");
        }
    }
}