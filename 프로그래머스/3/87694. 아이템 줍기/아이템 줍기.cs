using System;
using System.Collections.Generic;

public class Solution
{
    // 좌표와 이동횟수를 담는 클래스
    public class Pos{
        public int y;
        public int x;
        public int count;

        public Pos(int y, int x, int count){
            this.y = y;
            this.x = x;
            this.count = count;
        }
}

    public int solution(int[,] rectangle, int characterX, int characterY, int itemX, int itemY){
        int answer = 0;
        // 다각형의 테두리 1 (갈 수 있음), 다각형의 테두리 안쪽 2 (갈 수 없음)
        var intArrays = new int[102, 102]; 
            
        // 한 변의 길이가 1인 사각형에 대응하기 위해 모든 좌표를 *2로 둠
        characterY *= 2;
        characterX *= 2;
        itemY *= 2;
        itemX *= 2;
            
        // 각 사각형 영역을 탐색해 다각형의 테두리와 내부를 구함
        for (int i = 0; i < rectangle.GetLength(0); i++)
        {
            // 모든 좌표 * 2
            int startPosY = rectangle[i, 1] * 2;
            int startPosX = rectangle[i, 0] * 2;
            int endPosY = rectangle[i, 3] * 2;
            int endPosX = rectangle[i, 2] * 2;

            // 현재 탐색하는 사각형의 영역 탐색
            for (int y = startPosY; y <= endPosY; y++)
            {
                for (int x = startPosX; x <= endPosX; x++)
                {
                    // 테두리인 경우
                    if (y == startPosY || y == endPosY || x == startPosX || x == endPosX)
                    {
                        // 다른 사각형의 테두리 안쪽이 아닌 경우에만 갈 수 있는 길로 체크
                        if (intArrays[y, x] != 2)
                        {
                            intArrays[y, x] = 1;
                            continue;
                        }
                    }

                    // 테두리 안쪽인 경우
                    intArrays[y, x] = 2; 
                }
            }
        }

        var queue = new Queue<Pos>();
        var dirY = new int[4] { 0, 0, 1, -1 };
        var dirX = new int[4] { 1, -1, 0, 0 };
        queue.Enqueue(new Pos(characterY, characterX, 0));

        // BFS 탐색
        while (queue.Count > 0)
        {
            Pos currPos = queue.Dequeue();
            intArrays[currPos.y, currPos.x] = 2; // 방문처리

            for (int i = 0; i < 4; i++)
            {
                // 범위를 벗어날 수 없으므로 예외처리하지 않음 (0,0 ~ 101,101)
                Pos movePos = new Pos(currPos.y + dirY[i], currPos.x + dirX[i], currPos.count + 1);

                // 목표 지점에 도착
                if (movePos.y == itemY && movePos.x == itemX)
                {
                    // 모든 좌표 * 2 였기 때문에 이동 횟수 / 2
                    answer = movePos.count / 2; 
                    queue.Clear();
                    break;
                }

                if (intArrays[movePos.y, movePos.x] == 1)
                    queue.Enqueue(movePos);
            }
        }

        return answer;
    }
}