using System;
using System.Linq;
//using System.Collections.Generic;
class Solution
{
    public int solution(int N, int[,] road, int K)
    {
        int answer = 0;
        int[] path = Enumerable.Repeat(int.MaxValue, N+1).ToArray();
        path[1] = 0;
        
        for(int repeat = 0; repeat < N-1; repeat++){
            for(int target = 1; target < N+1; target++){
                for(int r = 0; r < road.GetLength(0); r++){
                    
                    int a= road[r,0];
                    int b = road[r,1];
                    int dist = road[r, 2];
                    
                    if(a == target && path[a] != int.MaxValue)
                        path[b] = Math.Min(path[b], path[a] + dist);
                    else if(b == target && path[b] != int.MaxValue)
                        path[a] = Math.Min(path[a], path[b] + dist);
                }
            }
        }
        return answer = path.Count(c => c <= K);
    }
}