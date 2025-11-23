using System;

public class Solution {
    public int solution(int price) {
        float sale = 1f;
        if(price >= 500000)
            sale = 0.8f;
        else if(price >= 300000)
            sale = 0.9f;
        else if(price >= 100000)
            sale = 0.95f;
        return (int)(price * sale);
    }
}