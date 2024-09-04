using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public int[] solution(string[] operations) {
        int[] answer = new int[2];
        var q = new List<int>();
        
        for(int i = 0; i < operations.Length; i++){
            if(operations[i][0] == 'I'){
                var sNum = operations[i].Substring(2);
                q.Add(int.Parse(sNum));
                q.Sort();
                continue;
            }
            if(q.Count > 0){
                if(operations[i].Length == 3) q.RemoveAt(q.Count -1);
                else q.RemoveAt(0);
            }
        }
        if(q.Count > 0){
            answer[0] = q[q.Count -1];
            answer[1] = q[0];
        }
        return answer;
    }
}