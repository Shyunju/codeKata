using System;

public class Solution {
    public int solution(string number) {
        int sum = 0;
        for(int i = 0; i < number.Length; i++)
        {
            sum += int.Parse(number[i].ToString());
        }
        return sum % 9;
    }
}