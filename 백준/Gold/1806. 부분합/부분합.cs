//10,000 이하의 자연수로 이루어진 길이 N짜리 수열이 주어진다.
//이 수열에서 연속된 수들의 부분합 중에 그 합이 S 이상이 되는 것 중, 
//가장 짧은 것의 길이를 구하는 프로그램을 작성하시오.

using System;
using System.Collections.Generic;

public class Solution
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = input[0];
        int s = input[1];
        
        List<int> num = new List<int>();
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for(int i =0; i < n; i++)
        {
            num.Add(nums[i]);
        }
        int ans = int.MaxValue;
        int en = 0;
        int sum = num[0];
        for(int st = 0; st < n; st++)
        {            
            while(en < n && sum< s)
            {
                en++;
                if(en < n)
                    sum += num[en];
            }
            if(en == n) break;
            ans = Math.Min(ans, en - st+1);
            sum -= num[st];
        }
        if(ans == int.MaxValue)
            ans = 0;
        Console.Write(ans);
    }
}