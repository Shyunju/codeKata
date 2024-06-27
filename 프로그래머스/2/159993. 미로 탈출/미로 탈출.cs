using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] maps) 
    {
        var startPoint = FindChar(maps, 'S');

        int dist = MoveTo(maps, 'L', startPoint, out var leverPoint);
        if(dist == -1)
            return -1;
        else
        {
            int dist2 = MoveTo(maps, 'E', leverPoint, out var _);
            return dist2 == -1 ? -1 : dist + dist2;
        }
    }

    private (int, int) FindChar(string[] maps, char c)
    {
        for(int y = 0; y < maps.Length; ++y)
        {
            int x = maps[y].IndexOf(c);
            if(x != -1)
                return (y, x);
        }
        return (-1, -1);
    }

    private int MoveTo(string[] maps, char target, (int y, int x) start, out (int, int) end)
    {
        int[] dy = { 0, 0, -1, 1 };
        int[] dx = { -1, 1, 0, 0 };

        var dist = new int[maps.Length, maps[0].Length];
        var queue = new Queue<(int, int)>();
        queue.Enqueue(start);

        while(queue.Count > 0)
        {
            (int y, int x) cur = queue.Dequeue();
            if(maps[cur.y][cur.x] == target) // 도달
            {
                end = cur;
                return dist[cur.y, cur.x];
            }

            for(int i = 0; i < 4; ++i)
            {
                int moveToY = cur.y + dy[i];
                int moveToX = cur.x + dx[i];

                if(moveToY >= maps.Length || moveToY < 0) continue;
                if(moveToX >= maps[0].Length || moveToX < 0) continue;

                if(maps[moveToY][moveToX] == 'X') continue;
                if(dist[moveToY, moveToX] != 0) continue;

                queue.Enqueue((moveToY, moveToX));
                dist[moveToY, moveToX] = dist[cur.y, cur.x] + 1;
            }
        }

        end = (-1, -1);
        return -1;
    }
}