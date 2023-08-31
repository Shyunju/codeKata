using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long sum =0;
        for(int i = 0; i <= count; i++){
            sum += price * i;
        }
        if( sum > money){
            sum -= money;
        }else{
            return 0;
        }
        return sum;
    }
}