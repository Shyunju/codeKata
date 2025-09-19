using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[,] points, int[,] routes)
    {
        // 좌표별 최대 크기 가정(100 이하)
        int gridSize = 101;

        // (시간, 좌표)별 방문 횟수를 저장하는 딕셔너리
        Dictionary<(int time, int pos), int> visited = new Dictionary<(int, int), int>();

        int robotCount = routes.GetLength(0);
        int routeLength = routes.GetLength(1);

        // 각 로봇마다 이동 경로를 시뮬레이션하여 초 당 위치 기록
        for (int r = 0; r < robotCount; r++)
        {
            int sec = 0;

            for (int i = 0; i < routeLength - 1; i++)
            {
                // 시작 좌표
                int curY = points[routes[r, i] - 1, 0];
                int curX = points[routes[r, i] - 1, 1];

                // 목표 좌표
                int nextY = points[routes[r, i + 1] - 1, 0];
                int nextX = points[routes[r, i + 1] - 1, 1];

                // 현재 위치 초기 기록(출발점 포함)
                if (i == 0 && sec == 0)
                {
                    int pos = (curY - 1) * gridSize + curX;
                    var key = (sec, pos);
                    visited[key] = visited.ContainsKey(key) ? visited[key] + 1 : 1;
                }

                // r 좌표 이동 (우선)
                while (curY != nextY)
                {
                    sec++;
                    curY = curY < nextY ? curY + 1 : curY - 1;

                    int pos = (curY - 1) * gridSize + curX;
                    var key = (sec, pos);
                    visited[key] = visited.ContainsKey(key) ? visited[key] + 1 : 1;
                }

                // c 좌표 이동
                while (curX != nextX)
                {
                    sec++;
                    curX = curX < nextX ? curX + 1 : curX - 1;

                    int pos = (curY - 1) * gridSize + curX;
                    var key = (sec, pos);
                    visited[key] = visited.ContainsKey(key) ? visited[key] + 1 : 1;
                }
            }
        }

        // 위험 상황 : 같은 시간, 같은 좌표에 두 대 이상 로봇이 있는 경우의 총 횟수
        int dangerCount = visited.Count(kv => kv.Value >= 2);

        return dangerCount;
    }
}
