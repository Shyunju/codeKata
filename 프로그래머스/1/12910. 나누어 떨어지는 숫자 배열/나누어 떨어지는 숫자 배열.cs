using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = arr.Where(s => s % divisor == 0).OrderBy(o => o).ToArray();
        int[] fail = {-1};
        return answer.Length > 0 ? answer : fail;
    }
}