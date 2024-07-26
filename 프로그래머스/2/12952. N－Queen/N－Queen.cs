using System;
using System.Linq;
public class Solution {
    public int solution(int n) 
    {
        int answer = 0;
        int[] arr = Enumerable.Range(0, n).ToArray();
        Perm(arr, 0, n, ref answer);

        return answer;
    }

    private void Perm(int[] arr, int depth, int n, ref int answer)
    {
        if(depth == n)
        {
            ++answer;
            return;
        }

        for(int i = depth; i < n; ++i)
        {
            Swap(arr, i, depth);

            if(IsValid(arr, depth))
                Perm(arr, depth + 1, n, ref answer);

            Swap(arr, i, depth);
        }
    }

    private void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    private bool IsValid(int[] arr, int depth)
    {
        for(int x = 0; x < depth; ++x)
        {
            if(Math.Abs(x - depth) == Math.Abs(arr[x] - arr[depth]))
                return false;
        }
        return true;
    }
}