using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(string[] maps) 
    {
        int width = maps[0].Length;
        int height = maps.Length;

        var answer = new List<int>();
        var closed = new HashSet<(int, int)>();

        for(int iy = 0; iy < height; ++iy)
        {
            for(int ix = 0; ix < width; ++ix)
            {
                (int y, int x) cur = (iy, ix);
                if(maps[iy][ix] == 'X') 
                {
                    closed.Add(cur);
                    continue;
                }

                if(closed.Contains(cur)) continue;
                int food = 0;

                var openStack = new Stack<(int, int)>();
                openStack.Push(cur);
                closed.Add(cur);

                while(openStack.Count > 0)
                {
                    (int y, int x) open = openStack.Pop();
                    food += (maps[open.y][open.x] - '0'); 

                    var pointList = new List<(int, int)>();
                    if(open.x > 0)          pointList.Add((open.y, open.x - 1));
                    if(open.x < width - 1)  pointList.Add((open.y, open.x + 1));
                    if(open.y > 0)          pointList.Add((open.y - 1, open.x));
                    if(open.y < height - 1) pointList.Add((open.y + 1, open.x));

                    foreach((int y, int x) point in pointList)
                    {
                        if(closed.Contains(point)) continue;
                        if(maps[point.y][point.x] == 'X') continue;

                        openStack.Push(point);
                        closed.Add(point);
                    }
                }
                answer.Add(food);
            } 
        }

        if(answer.Count == 0) 
            answer.Add(-1);

        return answer.OrderBy(o => o).ToArray();
    }

}