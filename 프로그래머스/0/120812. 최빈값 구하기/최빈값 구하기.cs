using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;

        Dictionary<int, int> pair = new Dictionary<int, int>();
        List<int> countMax = new List<int>();

        for(int i=0; i<array.Length; i++)
        {
            if (pair.ContainsKey(array[i]))
                pair[array[i]]++;
            else
                pair.Add(array[i], 1);
        }

        int max = pair.Values.Max();
        for(int i=0; i<array.Length; i++)
        {
            if (array.Count(x => x == array[i]) == max)
            {
                if (countMax.Contains(array[i]))
                    continue;
                else
                    countMax.Add(array[i]);
            }
        }

        return countMax.Count > 1 ? -1 : countMax[0];
    }
}