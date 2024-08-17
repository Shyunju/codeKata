using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[,] places) 
    {
        int[] answer = new int[5];
        for(int room = 0; room < places.GetLength(0); ++room)
        {
            char[,] matrix = new char[5, 5];
            for(int k = 0; k < 5; ++k)
            {
                string str = places[room, k];
                for(int s = 0; s < str.Length; ++s)
                    matrix[k, s] = str[s];
            }

            answer[room] = IsCollectSpace(room, matrix);
        }

        return answer;
    }

    private int IsCollectSpace(int index, char[,] matrix)
    {
        for(int y = 0; y < 5; ++y)
        {
            for(int x = 0; x < 5; ++x)
            {
                // P를 기준으로 길찾기해서 2거리에 다른 P가 발견되면 거리두기 안한 것.
                if(matrix[y, x] != 'P') 
                    continue; 

                var stack = new Stack<(int, int)>();
                var close = new HashSet<(int, int)>();
                stack.Push((y, x));
                close.Add((y, x));

                while(stack.Count > 0)
                {
                    (int y, int x) cur = stack.Pop();

                    if(!(cur.y == y && cur.x == x) && matrix[cur.y, cur.x] == 'P')
                        return 0; // 거리두기 안지킴!

                    if(Math.Abs(y - cur.y) + Math.Abs(x - cur.x) >= 2)
                        continue; // 거리가 이미 2라면 더 먼곳은 체크할 필요없음.

                    var pointList = new List<(int, int)>(); 
                    if(cur.y > 0) pointList.Add((cur.y - 1, cur.x));
                    if(cur.y < 4) pointList.Add((cur.y + 1, cur.x));
                    if(cur.x > 0) pointList.Add((cur.y, cur.x - 1));
                    if(cur.x < 4) pointList.Add((cur.y, cur.x + 1));

                    foreach((int y, int x) point in pointList)
                    {
                        if(close.Contains(point)) continue;
                        if(matrix[point.y, point.x] == 'X') continue;
                        stack.Push(point);
                        close.Add(point);
                    }
                }
            }
        }

        return 1;
    }
}