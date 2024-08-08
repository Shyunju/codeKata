using System;

public class Solution {
    public int solution(int[] cards) {
        int answer = 0;
        
        for(int a = 0; a < cards.Length; a++){
            bool[] isVisit = new bool[cards.Length];
            int cntA = Pick(cards, isVisit, a);
            
            if(cntA == cards.Length) continue;
            
            for(int b = 0; b < cards.Length; b++){
                if(isVisit[b]) continue;
                
                int cntB = Pick(cards, isVisit, b);
                answer = Math.Max(answer, cntA * cntB);
            }
        }
        return answer;
    }
    private int Pick(int[] cards, bool[] isVisit, int i){
        int cur = cards[i];
        int cnt = 0;
        
        while(!isVisit[cur-1]){
            isVisit[cur-1] = true;
            ++cnt;
            cur = cards[cur-1];
        }
        return cnt;
    }
}