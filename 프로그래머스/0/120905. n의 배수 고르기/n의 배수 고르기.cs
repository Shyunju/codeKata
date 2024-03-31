using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int n, int[] numlist) {
        int[] answer = new int[]{};
        //new string(code.Where((w, index) => index % q == r).ToArray())
        return answer = numlist.Where(x => x % n == 0).ToArray();
    }
}