using System;

public class Solution {
    public int[] solution(int denum1, int num1, int denum2, int num2) {
        var num3 = num1 * num2;
        var denum3 = denum1 * num2 + denum2 * num1;
        var gcd = getgcd(num3, denum3);
        num3 /= gcd;
        denum3 /= gcd;

        int[] answer = new int[] {denum3, num3};
        return answer;
    }

    public int getgcd(int n, int m)
    {
        if(m==0) return n;
        else return getgcd(m, n%m);
    }
}