using System;
using System.Linq;
public class Solution {
    public string solution(string s) {
        int[] num = Array.ConvertAll(s.Split(), int.Parse);
        int min = num.Min();
        int max = num.Max();
        return min + " " + max;
    }
}