using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int a, int b, int c, int d) {
        var dic = new Dictionary<int, int>();
        for(int i = 1; i<= 6; i++)
        {
            dic.Add(i, 0);
        }
        dic[a]++;
        dic[b]++;
        dic[c]++;
        dic[d]++;
        
        int four = 0;
        int triple = 0;
        var doub = new List<int>();
        var ones = new List<int>();
        
        for(int i = 1; i <= 6; i++)
        {
            if(dic[i] == 4){
                return 1111 * i;
            }
            else if(dic[i] == 3){
                triple = i;
            }else if(dic[i] == 2)
            {
                doub.Add(i);
            }else if(dic[i] == 1){
                ones.Add(i);
            }
        }
        if(triple > 0)
            return (int)Math.Pow(10 * triple + ones[0], 2);
        if(doub.Count == 2)
            return (doub[0] + doub[1]) * Math.Abs(doub[0] - doub[1]);
        if(doub.Count == 1)
            return ones[0] * ones[1];
        ones.Sort();
        return ones[0];
        
    }
}