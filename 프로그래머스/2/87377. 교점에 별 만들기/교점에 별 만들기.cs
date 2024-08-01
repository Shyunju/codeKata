using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    struct Cordinate
    {
        public int x;
        public int y;

        public Cordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public string[] solution(int[,] line)
    {
        string[] answer = new string[] { };
        List<Cordinate> crossNode = new List<Cordinate>();
        int minX = int.MaxValue;
        int minY = int.MaxValue;
        int maxX = int.MinValue;
        int maxY = int.MinValue;

        // 1. n개 직선 배열에서 2개 조합
        for (int i = 0; i < line.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < line.GetLength(0); j++)
            {
                long a = line[i, 0];
                long b = line[i, 1];
                long e = line[i, 2];
                long c = line[j, 0];
                long d = line[j, 1];
                long f = line[j, 2];

                // 2. 평행한지 확인 후 계속
                long denominator = a * d - b * c;
                if (denominator == 0)
                    continue;

                long numeratorA = b * f - e * d;
                long numeratorB = e * c - a * f;

                // 3. 정수인지 체크하기
                if (numeratorA % denominator != 0 || numeratorB % denominator != 0)
                    continue;

                // 4.직선의 교점 구하기
                int x = (int)(numeratorA / denominator);
                int y = (int)(numeratorB / denominator);
                crossNode.Add(new Cordinate(x, y));

                // 5. 교점의 최대 x, y 최소 x, y 구하기
                minX = Math.Min(x, minX);
                minY = Math.Min(y, minY);
                maxX = Math.Max(x, maxX);
                maxY = Math.Max(y, maxY);
            }
        }

        // 6. 최대 최소를 바탕으로 배열 생성
        List<string> plotList = new List<string>();
        StringBuilder builder = new StringBuilder();
        for (int y = maxY; y > minY - 1; y--)
        {
            for (int x = minX; x < maxX + 1; x++)
            {
                // 7. 교점이 있으면 * 없으면 .
                char point = crossNode.Contains(new Cordinate(x, y)) ? '*' : '.';
                builder.Append(point);
            }
            plotList.Add(builder.ToString());
            builder.Clear();
        }

        answer = plotList.ToArray();
        return answer;
    }
}