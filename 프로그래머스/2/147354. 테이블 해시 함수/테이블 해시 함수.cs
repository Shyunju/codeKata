using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] data, int col, int row_begin, int row_end) {
        var list = new List<int[]>();
        int width = data.GetLength(1);
        
        for(int i = 0; i < data.GetLength(0); i++){
            var array = new int[width];
            for(int j = 0; j < width; j++)
                array[j] = data[i, j];
            list.Add(array);
        }
        list = list.OrderBy( o => o[col -1]).ThenByDescending(o => o[0]).ToList();
        
        int answer = list.Skip(row_begin -1).Take(row_end - row_begin +1)
            .Select((s, index) => {
                int result = 0;
                for(int i = 0; i < s.Length; i++)
                    result += s[i] % (row_begin + index);
                return result;
            }).Aggregate((cur, next) => cur ^ next);
        return answer;
    }
}