using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int[] answer = Enumerable.Range(1, n).Where(x => n % x == 0).ToArray();
        return answer;
    }
}