using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int bridge_length, int weight, int[] truck_weights)
    {
        int answer = 0;
        int truckCount = 0;
        int allweight = 0;
        int time = 0;
        
        Queue<int> q = new Queue<int>();
        
        while(true)
        {
            if(truckCount == truck_weights.Length) break;
            
            if(q.Count == bridge_length) allweight -= q.Dequeue();
            
            if(allweight + truck_weights[truckCount] <= weight)
            {
                allweight += truck_weights[truckCount];
                q.Enqueue(truck_weights[truckCount]);
                truckCount++;
            }
            else{
                q.Enqueue(0);
            }
            time++;
        }
        answer = time + bridge_length;
        return answer;
    }
}