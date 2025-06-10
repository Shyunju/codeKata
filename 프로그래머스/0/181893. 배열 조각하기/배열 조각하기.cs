using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int[] query) {
        List<int> answer = arr.ToList();
        for(int i = 0; i < query.Length; i++)
        {
            if(i % 2 == 0)
            {
                while(answer.Count() > query[i] + 1)
                {
                    answer.RemoveAt(answer.Count() -1);
                }
            }else{
                for(int j = 0; j < query[i]; j++)
                {
                    answer.RemoveAt(0);
                }
            }
        }
        return answer.ToArray();
    }
}