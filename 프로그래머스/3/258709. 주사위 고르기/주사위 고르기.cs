using System;

public class Solution
{
    public int[] solution(int[,] dice)
    {
        double maxRatio = 0;
        int selected = 0;

        int cnt = dice.GetLength(0);
        int half = cnt / 2;

        // 모든 조합 탐색
        for (int i = 0; i < (1 << cnt); i++)
        {
            if (CountBit(i) == half) // 정확히 반씩 나누는 경우만 처리
            {
                double ratio = GetRatio(dice, i);
                if (maxRatio < ratio)
                {
                    maxRatio = ratio;
                    selected = i; // 최대 승률 조합 저장
                }
            }
        }

        // 선택된 조합에서 주사위 번호 반환
        int[] answer = new int[half];
        for (int i = 0, idx = 0; i < cnt; i++)
        {
            if ((selected & (1 << i)) > 0)
                answer[idx++] = i + 1;
        }

        return answer;
    }

    int CountBit(int val)
    {
        int cnt = 0;
        while (val > 0)
        {
            cnt += (val & 1);
            val >>= 1;
        }
        return cnt;
    }

    double GetRatio(int[,] dice, int selected)
    {
        int cnt = dice.GetLength(0);
        int half = cnt / 2;

        int[,] dice1 = new int[half, 6];
        int[,] dice2 = new int[half, 6];

        // 선택된 주사위 분할
        for (int i = 0, i1 = 0, i2 = 0; i < cnt; i++)
        {
            if ((selected & (1 << i)) > 0)
            {
                for (int j = 0; j < 6; j++)
                    dice1[i1, j] = dice[i, j];
                i1++;
            }
            else
            {
                for (int j = 0; j < 6; j++)
                    dice2[i2, j] = dice[i, j];
                i2++;
            }
        }

        // 점수 조합 계산
        int[] score1 = new int[500];
        int[] score2 = new int[500];

        DFS(score1, dice1, half, 0, 0);
        DFS(score2, dice2, half, 0, 0);

        // 승률 계산
        int total = (int)Math.Pow(6, cnt);
        int win = 0, pre = 0;

        for (int i = 1; i < 500; i++)
        {
            if (score1[i] > 0)
                win += score1[i] * pre; // 이길 수 있는 경우의 수 누적
            pre += score2[i]; // 이전 점수 누적
        }

        return (double)win / total;
    }

    void DFS(int[] scores, int[,] dice, int n, int depth, int sum)
    {
        if (depth == n)
        {
            scores[sum]++;
            return;
        }

        for (int i = 0; i < 6; i++)
            DFS(scores, dice, n, depth + 1, sum + dice[depth, i]);
    }
}
