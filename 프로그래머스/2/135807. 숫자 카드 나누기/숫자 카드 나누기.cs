using System;

public class Solution {
    public int solution(int[] arrayA, int[] arrayB) 
    {
        int a = GetMaxValue(arrayA, arrayB);
        int b = GetMaxValue(arrayB, arrayA);
        return a > b ? a : b;
    }

    private int GetMaxValue(int[] my, int[] other)
    {
        int n = my[0];
        foreach(int num in my)
            n = GCD(n, num);

        foreach(int num in other)
        {
            if(num % n == 0)
                return 0;
        }
        return n;
    }

    private int GCD(int a, int b)
    {
        if(b == 0) return a;
        return GCD(b, a % b);
    }
}