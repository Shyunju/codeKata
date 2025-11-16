using System;

public class Solution {
    public int solution(int angle) {
        if(angle / 90 == 2)
            return 4;
        if(angle / 90 == 1)
        {
            if(angle % 90 > 0)
                return 3;
            return 2;
        }
        return 1;
    }
}