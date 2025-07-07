//M이상 N이하의 자연수 중 소수인 것을 모두 찾아 첫째 줄에 그 합을, 둘째 줄에 그 중 최솟값을 출력한다. 

//단, M이상 N이하의 자연수 중 소수가 없을 경우는 첫째 줄에 -1을 출력한다.

using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        
        List<int> answer = new List<int>();
        for(int i = m; i <= n; i++)
        {
            if(i == 1)
                continue;
            if(p.CheckPrime(i))
                answer.Add(i);
        }
        if(answer.Count == 0)
            Console.WriteLine(-1);
        else{
            Console.WriteLine(answer.Sum());
            Console.WriteLine(answer.Min());
        }
    }
    public bool CheckPrime(int num)
    {
        for(int i= 2; i * i <= num; i++)
        {
            if(num % i == 0)
                return false;
        }
        return true;
    }
}