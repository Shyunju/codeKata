using System;

public class Solution {
    public int solution(int coin, int[] cards) {
        int targetNum = cards.Length + 1;
        int firstCardNum = cards.Length/3;
        int round = 1;
        int combiNum = 0;
        int specialCase = 0;
        
        for(int i = 0; i < firstCardNum -1; i++){
            for(int j = i+1; j < firstCardNum; j++){
                if(cards[i] + cards[j] == targetNum){
                    combiNum++;
                    break;
                }
            }
        }
        for(int i = firstCardNum; i< cards.Length; i += 2){
            for(int j = 0; j < i; j++){
                if(j < firstCardNum){
                    if(cards[i] + cards[j] == targetNum && coin >= 1){
                        combiNum++;
                        coin--;
                    }
                    if(cards[i+1] + cards[j] == targetNum && coin >= 1){
                        combiNum++;
                        coin--;
                    }
                }else{ //코인을 2개사용하는 경우
                    if(cards[i] + cards[j] == targetNum)
                        specialCase++;
                    if(cards[i+1] + cards[j] == targetNum)
                        specialCase++;
                }
            }
            //예외처리
            if(cards[i] + cards[i+1] == targetNum)
                specialCase++;
            if(combiNum > 0){
                round++;
                combiNum--;
            }else{
                if (specialCase>0&&coin>=2){
                    specialCase--;
                    round++;
                    coin-=2;
                }else
                    break;
            }
        }
        return round;
    }
}
