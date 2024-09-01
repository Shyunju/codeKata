using System;
using System.Linq;
public class Solution {
    public long solution(int n, int[] works) 
    {
        Array.Sort(works);

        for(int i = 0; i < n; ++i)
        {
            int maxIndex = works.Length - 1;
            while(maxIndex > 0 && works[maxIndex - 1] >= works[maxIndex])
                --maxIndex;

            if(works[maxIndex] == 0) return 0;
            --works[maxIndex];
        }

        return works.Select(s => (long)s * s).Sum();
    }
}