using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] enroll, string[] referral, string[] seller, int[] amount) 
{
    var enrollDict = Enumerable.Range(0, enroll.Length)
                               .ToDictionary(e => enroll[e], e => referral[e]);

    var moneyDict = Enumerable.Range(0, enroll.Length)
                               .ToDictionary(e => enroll[e], e => 0);

    for(int i = 0; i < seller.Length; ++i)
    {
        string s = seller[i];
        int money = amount[i] * 100;

        while(true)
        {
            int tenPercent = (int)Math.Floor(money * 0.1);
            moneyDict[s] += money - tenPercent; // 자기자신에게 90% 배분

            if(tenPercent == 0) break;
            if(enrollDict[s] == "-") break;

            s = enrollDict[s];
            money = tenPercent;
        }
    }

    return enroll.Select(e => moneyDict[e]).ToArray();
}
}