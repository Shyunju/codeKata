using System;

public class Solution {
    public int solution(int[] num_list) {
        int sum = 0;
        int pro = 1;
        foreach(int i in num_list){
            sum += i;
            pro *= i;
        }
        return pro < Math.Pow(sum, 2) ? 1 : 0;
    }
}