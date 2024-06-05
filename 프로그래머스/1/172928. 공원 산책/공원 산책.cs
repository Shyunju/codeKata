using System;

public class Solution
{
    int maxX = 0;
    int maxY = 0;

    public int[] solution(string[] park, string[] routes)
    {
        maxX = park[0].Length;
        maxY = park.Length;

        int[] answer = new int[2];

        int x = 0;
        int y = 0;

        for (int i = 0; i < park.Length; i++)
        {
            int index = park[i].IndexOf("S");
            if (index != -1)
            {
                x = index;
                y = i;
                break;
            }
        }

        foreach (string route in routes)
        {
            string[] routeInfo = route.Split(" ");

            string dir = routeInfo[0];
            int movePos = int.Parse(routeInfo[1]);

            int nextY = y;
            int nextX = x;
            bool isCheck = true;

            for (int i = 0; i < movePos; i++)
            {
                switch (dir)
                {
                    case "N":
                        nextY--;
                        break;
                    case "S":
                        nextY++;
                        break;
                    case "W":
                        nextX--;
                        break;
                    case "E":
                        nextX++;
                        break;
                }

                if (IsOderCheck(park, nextY, nextX) == false)
                {
                    isCheck = false;
                    break;
                }
            }
            if (isCheck)
            {
                x = nextX;
                y = nextY;
            }
        }
        return new int[2] { y, x };
    }

    bool IsOderCheck(string[] park, int y, int x)
    {
        if (y < 0 || y >= maxY)
            return false;
        if (x < 0 || x >= maxX)
            return false;
        if (park[y][x] == 'X')
            return false;

        return true;
    }
}