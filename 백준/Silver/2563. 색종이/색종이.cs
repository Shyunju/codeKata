using System;

internal class Program
{
    static void Main(string[] args)
    {
        bool[,] white = new bool[101, 101];
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string[] black = Console.ReadLine().Split();
            int width = int.Parse(black[0]);
            int height = 100 - int.Parse(black[1]) - 10;
            
            for (int j = width; j < width + 10; j++)
            {
                for (int k = height; k < height + 10; k++)
                {
                    if (j >= 0 && j <= 100 && k >= 0 && k <= 100) // 범위 체크
                        white[k, j] = true;
                }
            }
        }

        int answer = 0;
        for (int i = 0; i <= 100; i++)
        {
            for (int j = 0; j <= 100; j++)
            {
                if (white[i, j])
                    answer++;
            }
        }

        Console.Write(answer);
    }
}
