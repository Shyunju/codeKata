using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        List<string> list = new List<string>();
        for(int i = 0; i < want.Length; i++)
        {
            for(int j = 0; j < number[i]; j++)
            {
                list.Add(want[i]);
            }
        }
        list.Sort();
        
        for(int i = 0; i <= discount.Length - 10; i++)
        {
            List<string> result = discount.Skip(i).Take(10).ToList();
            result.Sort();
            if(list.SequenceEqual(result))
                answer++;
        }
        return answer;
    }
}