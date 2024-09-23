using System;
using System.Collections.Generic;

public class Solution {
    public int[,] cost = 
    {
        { 1, 7, 6, 7, 5, 4, 5, 3, 2, 3 },
        { 7, 1, 2, 4, 2, 3, 5, 4, 5, 6 },
        { 6, 2, 1, 2, 3, 2, 3, 5, 4, 5 },
        { 7, 4, 2, 1, 5, 3, 2, 6, 5, 4 },
        { 5, 2, 3, 5, 1, 2, 4, 2, 3, 5 },
        { 4, 3, 2, 3, 2, 1, 2, 3, 2, 3 },
        { 5, 5, 3, 2, 4, 2, 1, 5, 3, 2 },
        { 3, 4, 5, 6, 2, 3, 5, 1, 2, 4 },
        { 2, 5, 4, 5, 3, 2, 3, 2, 1, 2 },
        { 3, 6, 5, 4, 5, 3, 2, 4, 2, 1 }
    };
    
    int numberLength;
    int[,] minDistFromFingerToDest;
    int[,,] dp;
    string numbersCopy;
    Dictionary<string, int> numbersToIndex;
    public int solution(string numbers) {   
        // 누를 숫자 인덱스, 왼쪽 위치, 오른쪽 위치
        // 왼손, 오른손 누르는 경우의 수 => 다른 손가락이 올라간 위치 제외
        
        numberLength = numbers.Length;
        numbersCopy = numbers;
        dp = new int[numberLength,10,10];
        
        for (int i = 0; i < numberLength; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    dp[i, j, k] = -1;
                }
            }
        }

        return GetMinDist(0, 4, 6);
    }
    
    int GetMinDist(int index, int left, int right)
    {
        if (index == numberLength) return 0;
        
        if (dp[index, left, right] != -1) return dp[index, left, right];
        
        int numberToIndex = numbersCopy[index] - '0';
        int result = Int32.MaxValue;
        
        if (numberToIndex != right) // 왼쪽 엄지 이동
        {
            result = Math.Min(GetMinDist(index + 1, numberToIndex, right) + cost[left, numberToIndex], result);
        }
        
        if (numberToIndex != left) // 오른쪽 엄지 이동
        {
            result = Math.Min(GetMinDist(index + 1, left, numberToIndex) + cost[right, numberToIndex], result);
        }
        
        dp[index, left, right] = result;
        
        return dp[index, left, right];
    }
}