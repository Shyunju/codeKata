using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int[,] wires) 
{
    int answer = int.MaxValue;

    for(int i = 0; i < wires.GetLength(0); ++i)
    {
        int a = wires[i, 0];
        int b = wires[i, 1];
        var setA = new HashSet<int>();
        setA.Add(a);
        var setB = new HashSet<int>();
        setB.Add(b);

        FindConnect(wires, setA, a, i);
        FindConnect(wires, setB, b, i);

        int diff = Math.Abs(setA.Count - setB.Count);
        if(diff < answer)
            answer = diff;                
    }

    return answer;
}

private void FindConnect(int[,] wires, HashSet<int> hashSet, int find, int except)
{
    for(int k = 0; k < wires.GetLength(0); ++k)
    {
        if(k == except)
            continue;

        if(hashSet.Contains(wires[k, 0]) && !hashSet.Contains(wires[k, 1]))
        {
            hashSet.Add(wires[k, 1]);
            FindConnect(wires, hashSet, wires[k, 1], except);
        }
        if(hashSet.Contains(wires[k, 1]) && !hashSet.Contains(wires[k, 0]))
        {
            hashSet.Add(wires[k, 0]);
            FindConnect(wires, hashSet, wires[k, 0], except);
        }
    }
}
}