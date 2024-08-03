using System;

    public class Solution
    {
        public class Pos
        {
            public int y;
            public int x;

            public Pos(int y, int x)
            {
                this.y = y;
                this.x = x;
            }
        }

        public int[] solution(int m, int n, int startX, int startY, int[,] balls)
        {
            int[] answer = new int[balls.GetLength(0)];
            Pos startPos = new Pos(startY, startX); // 시작점
            
            // 각 좌표 하나하나에 대해 최소 거리를 구함
            for (int i = 0; i < balls.GetLength(0); i++)
            {
                // 맞춰야 하는 공의 좌표
                int posY = balls[i, 1];
                int posX = balls[i, 0];
                Pos movePos;
                int minDir = int.MaxValue;

                // 오른쪽 벽에 대한 대칭 좌표 ( y = 2m - y )
                if ((posX > startPos.x && posY == startPos.y) == false)
                {
                    movePos = new Pos(posY, 2 * m - posX);
                    minDir = Math.Min(minDir, GetSquareDir(startPos, movePos));
                }

                // 위쪽 벽에 대한 대칭 좌표 ( x = 2n - x )
                if ((posY > startPos.y && posX == startPos.x) == false)
                {
                    movePos = new Pos(2 * n - posY, posX);
                    minDir = Math.Min(minDir, GetSquareDir(startPos, movePos));
                }

                // 아래쪽 벽에 대한 대칭 좌표 ( y *= -1 )
                if ((posY < startPos.y && posX == startPos.x) == false)
                {
                    movePos = new Pos(posY * -1, posX);
                    minDir = Math.Min(minDir, GetSquareDir(startPos, movePos));
                }

                // 왼쪽 벽에 대한 대칭 좌표 ( x *= -1 )
                if ((posX < startPos.x && posY == startPos.y) == false)
                {
                    movePos = new Pos(posY, posX * -1);
                    minDir = Math.Min(minDir, GetSquareDir(startPos, movePos));
                }

                answer[i] = minDir;
            }

            return answer;
        }

        // 두 점 사이의 거리의 제곱을 리턴하는 메서드
        public int GetSquareDir(Pos p1, Pos p2)
        {
            int dirY = p1.y - p2.y;
            int dirX = p1.x - p2.x;

            return (dirY * dirY) + (dirX * dirX);
        }
    }