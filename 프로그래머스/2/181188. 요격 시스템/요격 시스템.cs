using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] targets) {
        int answer = 0;
        
        var area = new List<(int, int)>();
        for(int i = 0; i < targets.GetLength(0); i++){
            area.Add((targets[i,0], targets[i,1]));
        }
        area = area.OrderBy(o => o.Item1).ToList();
        
        int tail = int.MaxValue;
        foreach((int s, int e)point in area){
            
            if(point.e < tail){
                tail = point.e;
                continue;
            }
            if(point.s >= tail){
                answer++;
                tail = point.e;
            }
        }
        return ++answer;
    }
}