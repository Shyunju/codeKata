using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (IsPrime(nums[i] + nums[j] + nums[k]))
                    {
                        answer++;
                    }
                }
            }
        }

        return answer;
    }

    private bool IsPrime(int num)
    {
        // 제곱근을 내림한 값까지 돌며 소수인지 확인
        int sqrNum = (int)Math.Sqrt(num);

        // 0, 1은 확인x
        for (int i = 2; i <= sqrNum; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}