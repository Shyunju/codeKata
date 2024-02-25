using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> count = new List<int>();
        for(int i = 0; i< array.Length; i++)
        {
            if(dict.ContainsKey(array[i]))
            {
                dict[array[i]]++;
            }else{
                dict.Add(array[i], 1);
            }
        }
        int max = dict.Values.Max();
        foreach(var item in dict)
        {
            if(item.Value == max)
            {
                if(answer != 0)
                {
                    answer = -1;
                    break;
                }
                answer = item.Key;
            }
        }
        return answer;
    }
}
