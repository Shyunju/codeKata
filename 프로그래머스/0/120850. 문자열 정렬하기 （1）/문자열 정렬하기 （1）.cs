using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string my_string) {
        List<int> answer = new List<int>();
        foreach(var ch in my_string){
            int num = 0;
            bool isInt = int.TryParse(ch.ToString(), out num);
            if(isInt)
                answer.Add(num);
        }
        answer.Sort();
        return answer.ToArray();
    }
}