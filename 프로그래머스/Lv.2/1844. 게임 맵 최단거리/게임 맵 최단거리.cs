using System;
    using System.Collections.Generic;

    class Solution
    {
        public class Pos
        {
            public int y;
            public int x;
            public int count; // 이동 횟수

            public Pos(int y, int x, int count)
            {
                this.y = y;
                this.x = x;
                this.count = count;
            }
        }

        public int solution(int[,] maps)
        {
            // maps를 방문배열로 활용 (방문 : 0, 미방문 : 1)
            var dirY = new int[4] { 0, 0, 1, -1 };
            var dirX = new int[4] { 1, -1, 0, 0 };
            var queue = new Queue<Pos>();

            // 시작좌표
            queue.Enqueue(new Pos(0, 0, 1));
            maps[0, 0] = 0;
           
            // BFS
            while (queue.Count != 0)
            {
                // 현재 위치
                Pos currPos = queue.Dequeue();
                
                // dirX, dirY를 이용해 현재 위치에서 이동 가능한 4방향을 나타냄
                for (int i = 0; i < 4; i++)
                {
                    // 이동하려는 위치
                    Pos movePos = new Pos(currPos.y + dirY[i], currPos.x + dirX[i], currPos.count + 1);

                    // 배열 범위 범어남 (게임 맵을 벗어남)
                    if (movePos.y < 0 || movePos.y >= maps.GetLength(0) ||
                       movePos.x < 0 || movePos.x >= maps.GetLength(1))
                        continue;

                    // 적 진영에 도착
                    if (movePos.y == maps.GetLength(0) - 1 &&
                       movePos.x == maps.GetLength(1) - 1)
                        return movePos.count;

                    // 벽이거나 이미 탐색된 길
                    if (maps[movePos.y, movePos.x] == 0)
                        continue;

                    maps[movePos.y, movePos.x] = 0; // 방문처리
                    queue.Enqueue(movePos); // 다음 탐색 대상
                }
            }

            return -1;
        }
    }