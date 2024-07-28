using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] data, int col, int row_begin, int row_end) 
    {
        var list = new List<int[]>();
        int width = data.GetLength(1);
        for(int i = 0; i < data.GetLength(0); ++i)
        {
            var array = new int[width];
            for(int k = 0; k < width; ++k)
                array[k] = data[i, k];

            list.Add(array);
        }

        var orderedList = list.OrderBy(o => o[col - 1])
                          .ThenByDescending(o => o[0]); 

        var answer = orderedList.Skip(row_begin - 1)
                            .Take(row_end - row_begin + 1)
                            .Select((s, index) => 
                            {
                                int result = 0;
                                for(int k = 0; k < s.Length; ++k)
                                    result += s[k] % (row_begin + index);
                                return result;
                            })
                            .Aggregate((cur, next) => cur ^ next);
        return answer;
    }
}