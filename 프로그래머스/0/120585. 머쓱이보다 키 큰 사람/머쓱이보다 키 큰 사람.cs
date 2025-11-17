using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] array, int height) {
        var answer = array.Where(w => w > height).ToList();
        return answer.Count;
    }
}