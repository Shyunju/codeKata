using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n) {
        List<int> fibo = new List<int>();
        fibo.Add(1);
        fibo.Add(1);
        while(fibo.Count < n)
        {
            fibo.Add((fibo[fibo.Count -2] + fibo[fibo.Count-1]) % 1234567);
        }
        return fibo[fibo.Count-1];
    }
}