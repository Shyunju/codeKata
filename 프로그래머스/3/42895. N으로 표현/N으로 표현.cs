using System;
using System.Collections.Generic;
 
public class Solution
{
    //주어진 숫자 N을 연속적으로 붙여서 만드는 함수
    public int GetComboNumber(int N, int repeatCount)
    {
        int result = N;
 
        if (repeatCount == 1)
            return result;
 
        //2번이상 반복할 때.. N이 5라면 ex) 55, 555, 5555
        while(repeatCount > 1)
        {
            result = result * 10 + N;
            repeatCount--;
        }
        
        return result;
    }
 
    public int solution(int N, int number)
    {
        //N과 number가 같은 경우는 바로 return
        if (N == number) return 1;
 
        //N의 사용횟수별로, 만들 수 있는 수의 목록이 담긴 DP 목록 초기화
        List<HashSet<int>> DP = new List<HashSet<int>>(9);
 
        for (int i = 0; i < 9; i++)
            DP.Add(new HashSet<int>());
 
        //N을 한 번 사용한 경우의 결과 추가
        DP[1].Add(N);
 
        //n = N 사용횟수 (최대 8번까지 가능)
        for (int n = 2; n < 9; n++)
        {
            //N을 n번만큼 붙여서 만들 수 있는 연속된 수를 넣음.
            DP[n].Add(GetComboNumber(N, n));
 
            //N끼리 쌍을 지어 순회를 해야하므로..
            //N의 사용회수만큼 이중 for문
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    //목표는 N을 n번 사용했을 때의 경우를 DP[n]에 담는 것이다.
                    //i + j 가 n이 아닌데 Dp[n]에 담아버리면 안된다.
                    if (i + j!= n) continue;
 
                    //DP[i]와 DP[j]에 있는 숫자들을 조합하여 사칙연산을 수행한다.
                    foreach (int a in DP[i])
                    {
                        foreach (int b in DP[j])
                        {
                            //+ 연산
                            DP[n].Add(a + b);
 
                            //- 연산 시, 0이 되버리면, 이후에 목표한 숫자를 만들 수 없게 되므로 연산 값이 양수인것만 넣는다.
                            if (a - b > 0)
                                DP[n].Add(a - b);
 
                            //* 연산
                            DP[n].Add(a * b);
 
                            // / 연산 시, 0이 되버리면, 이후에 목표한 숫자를 만들 수 없게 되므로 연산 값이 양수인것만 넣는다.
                            if (a / b > 0) 
                                DP[n].Add(a / b);
                        }
                    }
                }
            }
 
            //만약 DP[k]에 원하는 숫자 number가 있으면 k + 1을 반환.
            if (DP[n].Contains(number))
                return n;
        }
 
        //8회까지 사용해도 원하는 숫자를 만들 수 없다면 -1을 반환.
        return -1;
    }
}
