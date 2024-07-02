using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public long[] solution(long[] numbers) {
        long[] answer = new long[numbers.Length];
        List<char> sen = new List<char>();
        for(long i=0; i<numbers.Length; i++)
        {
            string n_string = Convert.ToString(numbers[i], 2);
            sen= n_string.ToList();
            int onecount =0;
            for(int j = sen.Count-1; j>=0; j--)
            {
                if(sen[j] == '1')
                {
                    onecount++;
                }
                else break;
            }
            if(onecount<2) 
            {
                answer[i] =numbers[i]+1;
                continue;
            }
            else 
            {
                if(sen.Count ==onecount)
                {
                    sen.Insert(0,'0');
                }
                sen[sen.Count-onecount]='0';
                sen[sen.Count-onecount-1] = '1';
                long result =0;
                int count =0;
                for(int k=sen.Count-1;k>=0; k--)
                {
                    if(sen[k]=='1') result += MyPow(2,count);
                    count++;
                }
                answer[i] = result;
            }
        }
        return answer;
    }
        public static long MyPow(long to1, long to2)
    {
        long num = 1;
        for (long i = 0; i < to2; i++)
        {
            num = num * to1;
        }
        return num;
    }
}