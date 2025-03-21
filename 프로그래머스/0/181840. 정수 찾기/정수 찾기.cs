using System;

public class Solution {
    public int solution(int[] num_list, int n) {
        return Array.IndexOf(num_list, n) != -1 ? 1 : 0;
    }
}