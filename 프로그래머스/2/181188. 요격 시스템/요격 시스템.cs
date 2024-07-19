using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] targets) 
    {
        var list = new List<(int, int)>();
        for(int i = 0; i < targets.GetLength(0); ++i)
            list.Add((targets[i, 0], targets[i, 1]));

        list = list.OrderBy(o => o.Item1).ToList();

        int answer = 0;
        int tail = int.MaxValue;
        foreach((int start, int end) point in list)
        {
            if(point.end < tail)
            {
                tail = point.end;
                continue;
            }

            if(point.start >= tail) // 같이 요격될 수 없음
            {
                ++answer;
                tail = point.end;
            }
        }

        return answer + 1; // 마지막 그룹은 요격안했으니 + 1
    }
}