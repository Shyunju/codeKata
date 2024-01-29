 using System;

    public class Solution
    {
        public int solution(int[] numbers, int target)
        {
            int answer = 0;
            return Dfs(numbers, target, 0, 0);
        }
        
        static int Dfs(int[] arr, int target, int idx, int num)
        {
            if(idx == arr.Length)
            {
                if(target == num) return 1;
                return 0;
            }
            return Dfs(arr, target, idx+1, num + arr[idx]) + Dfs(arr, target, idx+1, num - arr[idx]);
            
        }

        
    }