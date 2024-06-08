using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int x, int y, int n) 
    {
        var open = new HashSet<int>();
        var openOther = new HashSet<int>();
        var close = new HashSet<int>();
        int count = 0;
        
        open.Add(x);
        
        while(open.Count > 0)
        {
            if(open.Contains(y))
                return count;
            
            ++count;
            openOther.Clear();
            foreach(var num in open)
            {
                close.Add(num);
                
                int a = num + n;
                if(a <= y && !close.Contains(a))
                    openOther.Add(a);

                int b = num * 2;
                if(b <= y && !close.Contains(b))
                    openOther.Add(b);
                
                int c = num * 3;
                if(c <= y && !close.Contains(c))
                    openOther.Add(c);
            }
            
            var temp = open;
            open = openOther;
            openOther = temp;
        }
        
        return -1;
    }
}
