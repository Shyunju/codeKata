using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] topping) 
    {
        int answer = 0;

        var stack = new Stack<int>(topping);
        var leftDict = topping.GroupBy(g => g)
                              .ToDictionary(g => g.Key, g => g.Count());
        var rightSet = new HashSet<int>();

        while(stack.Count > 1)
        {
            int pop = stack.Pop();
            rightSet.Add(pop);

            if(leftDict[pop] == 1)
                leftDict.Remove(pop);
            else
                leftDict[pop]--;

            if(leftDict.Count == rightSet.Count)
                ++answer;
        }

        return answer;
    }
}