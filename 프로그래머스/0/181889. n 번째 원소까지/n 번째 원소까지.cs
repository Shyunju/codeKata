using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] num_list, int n) {
        var answer = num_list.Take(n);
        return answer.ToArray();
    }
}