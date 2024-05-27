using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] order) 
{
    int orderIndex = 0; 
    var stack = new Stack<int>(); 
    for(int i = 0; i < order.Length; ++i)
    {
        int box = i + 1; 
        if(box == order[orderIndex])
            ++orderIndex;
        else
            stack.Push(box);

        while(stack.Count > 0 && stack.Peek() == order[orderIndex])
        {
            stack.Pop();
            ++orderIndex;
        }
    }

    return orderIndex;
}
}