using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] lottos, int[] win_nums) 
    {
        int winCount = lottos.Intersect(win_nums).Count();
        int loseCount = lottos.Where((number) => number != 0).Count() - winCount;

        int[] answer = new int[] {WinCountToRank(6-loseCount), WinCountToRank(winCount)};
        return answer;
    }

    public int WinCountToRank(int count)
    {
        if (count <= 1)
        {
            return 6;
        }

        return 7-count;
    }
}