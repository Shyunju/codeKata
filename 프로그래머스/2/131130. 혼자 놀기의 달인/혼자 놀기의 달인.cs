using System;
using System.Linq;
public class Solution {
    public int solution(int[] cards) 
    {
        int answer = 0;

        for(int a = 0; a < cards.Length; ++a) // 첫 상자를 완전탐색
        {
            bool[] isVisit = Enumerable.Repeat(false, cards.Length).ToArray();

            int openCountA = Check(cards, isVisit, a);
            if(openCountA == cards.Length) // 모든 상자가 다 열려있으면 0점으로 종료
                continue;

            for(int b = 0; b < cards.Length; ++b) // 상자를 완전탐색
            {
                if(isVisit[b]) continue;

                int openCountB = Check(cards, isVisit, b);
                answer = Math.Max(answer, openCountA * openCountB);
            }
        }

        return answer;
    }

    private int Check(int[] cards, bool[] isVisit, int i)
    {
        int current = cards[i];
        int openCount = 0;
        while(!isVisit[current - 1])
        {
            isVisit[current - 1] = true;
            ++openCount;
            current = cards[current - 1];
        }

        return openCount;
    }
}