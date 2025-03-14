using System;

public class Solution {
    public int solution(int a, int b) {
        string s1 = a.ToString() + b.ToString();
        string s2 = b.ToString() + a.ToString();
        
        int num1 = int.Parse(s1);
        int num2 = int.Parse(s2);
        
        return num1 >= num2 ? num1 : num2;
        
    }
}