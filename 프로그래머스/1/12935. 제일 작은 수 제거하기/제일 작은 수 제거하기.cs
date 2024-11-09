using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int v = arr.Min();
        
        if (arr.Length == 1)
        {
            arr[0] = -1;
            return arr;
        }
        int[] answer = arr.Where(x => x != v).ToArray();
        return answer;
    }
}