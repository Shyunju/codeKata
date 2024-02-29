using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] dots) {

        if((dots[0,1] - dots[1,1]) / (float)(dots[0,0] - dots[1,0]) == (dots[2,1] - dots[3,1]) / (float)(dots[2,0] - dots[3,0])){
            return 1;
        }
        
        if((dots[0,1] - dots[2,1]) / (float)(dots[0,0] - dots[2,0]) == (dots[1,1] - dots[3,1]) / (float)(dots[1,0] - dots[3,0])){
            return 1;
        }
                                             
        if((dots[0,1] - dots[3,1]) / (float)(dots[3,0] - dots[1,0]) == (dots[1,1] - dots[2,1]) / (float)(dots[1,0] - dots[2,0])){
            return 1;
        }
        
        return 0;
    }
}