//두 개의 자연수 N과 K가 주어졌을 때, N의 약수들 중 K번째로 작은 수를 출력하는 프로그램을 작성하시오.

using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args){
        string[] sl = Console.ReadLine().Split();
        int n = int.Parse(sl[0]);
        int k = int.Parse(sl[1]);
        var list = new List<int>();
        
        list.Add(n);
        for(int i = 1; i <= n / 2; i++){
            if(n % i== 0)
                list.Add(i);
        }
        list.Sort();
        if(k > list.Count())
            Console.Write(0);
        else
            Console.Write(list[k-1]);
    }
}