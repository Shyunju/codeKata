using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] numlist, int n) {
        return numlist.OrderBy(o => Math.Abs(o-n)).ThenByDescending(x =>x).ToArray();
    }
}