using System;

public class Solution
{
    public int[] solution(int m, int n, int startX, int startY, int[,] balls)
    {
        int[] answer = new int[balls.GetLength(0)];
        (int y, int x) start = (startY, startX);
        
        for (int i = 0; i < balls.GetLength(0); i++)
        {
            int posY = balls[i, 1];
            int posX = balls[i, 0];
            (int y, int x) move = (0, 0);
            int minDir = int.MaxValue;

            // 오른쪽 벽에 대한 대칭 좌표 ( y = 2m - y )
            if ((posX > start.x && posY == start.y) == false)
            {
                move.y = posY;
                move.x = 2 * m - posX;
                minDir = Math.Min(minDir, GetSquareDir(start, move));
            }
           // 위쪽 벽에 대한 대칭 좌표 ( x = 2n - x )
            if ((posY > start.y && posX == start.x) == false)
            {
                move.y = 2 * n - posY;
                move.x = posX;
                minDir = Math.Min(minDir, GetSquareDir(start, move));
            }
                // 아래쪽 벽에 대한 대칭 좌표 ( y *= -1 )
            if ((posY < start.y && posX == start.x) == false)
            {
                move.y = posY * -1;
                move.x = posX;
                minDir = Math.Min(minDir, GetSquareDir(start, move));
            }

            // 왼쪽 벽에 대한 대칭 좌표 ( x *= -1 )
            if ((posX < start.x && posY == start.y) == false)
            {
                move.y = posY;
                move.x = posX * -1;
                minDir = Math.Min(minDir, GetSquareDir(start, move));
            }
    
            answer[i] = minDir;
        }

        return answer;
    }

    // 두 점 사이의 거리의 제곱을 리턴하는 메서드
    public int GetSquareDir((int y, int x)p1, (int y, int x)p2)
    {
        int dirY = p1.y - p2.y;
        int dirX = p1.x - p2.x;

        return (dirY * dirY) + (dirX * dirX);
    }
}