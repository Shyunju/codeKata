using System;

public class Solution {
    public int solution(int number, int n, int m) {
        bool check = false;
        if(number % n == 0 && number % m == 0)
            check = true;
        return check ? 1 : 0;
    }
}