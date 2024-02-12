using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array, int n) {
        List<int> answer = array.Where(num => num == n).ToList();
        return answer.Count();
    }
}