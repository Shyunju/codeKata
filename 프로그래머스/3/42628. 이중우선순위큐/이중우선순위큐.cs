using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] operations) 
    {
        var queue = new MyQueue();
        foreach(string str in operations)
        {
            if(str == "D 1")
            {
                queue.DeleteMax();
            }
            else if(str == "D -1")
            {
                queue.DeleteMin();
            }
            else
            {
                int n = int.Parse(str.Split()[1]);   
                queue.Add(n);
            }
        }
        
        return queue.Count > 0 ?  new int[2]{ queue.Max, queue.Min } : new int[2]{ 0, 0 };
    }
}
    
public class MyQueue
{
    List<int> queue;

    public MyQueue()
    {
        queue = new List<int>();
    }
    
    public int Count => queue.Count;
    public int Max => queue[Count - 1];
    public int Min => queue[0];
    
    public void Add(int n)
    {
        queue.Add(n);
        queue.Sort();
    }
    
    public void DeleteMin()
    {
        if(queue.Count > 0)
            queue.RemoveAt(0);
    }
    
    public void DeleteMax()
    {
        if(queue.Count > 0)
            queue.RemoveAt(queue.Count - 1);
    }
}