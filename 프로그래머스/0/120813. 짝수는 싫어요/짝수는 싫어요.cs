using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int[] answer = Enumerable.Range(1, n).Where(x => x % 2 == 1).ToArray();
        return answer;
    }
}