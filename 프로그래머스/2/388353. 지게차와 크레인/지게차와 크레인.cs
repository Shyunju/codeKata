using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[] storage, string[] requests) {
        char?[,] containers = new char?[storage.Length, storage[0].Length];
        
        for(int i = 0; i < containers.GetLength(0); i++)
        {
            for(int j= 0; j < containers.GetLength(1); j++)
            {
                containers[i,j] = storage[i][j];
            }
        }
        
        foreach(string request in requests)
        {
            char target = request[0];
            if(request.Length == 1)
            {
                DeleteAtSide(ref containers, target);
            }
            else if(request.Length == 2)
            {
                DeleteAll(ref containers, target);
            }
            
        }
        int count = containers.Cast<char?>().Count(c => c.HasValue);
        return count;
    }
    void DeleteAll(ref char?[,] containers, char target)
    {
         for(int i = 0; i < containers.GetLength(0); i++)
        {
            for(int j = 0; j < containers.GetLength(1); j++)
            {
                if(containers[i,j] == target)
                {
                    containers[i,j] = null;
                }
            }            
        }
    }
    
    void DeleteAtSide(ref char?[,] containers, char target)
    {
        List<(int, int)> points = new List<(int, int)>();
        for(int i = 0; i < containers.GetLength(0); i++)
        {
            for(int j = 0; j < containers.GetLength(1); j++)
            {
                if(containers[i,j] == target)
                {
                    if(BFS(i, j, ref containers))
                    {
                        points.Add((i,j));
                    }
                }
            }            
        }
        foreach(var point in points)
        {
            containers[point.Item1, point.Item2] = null;
        }        
    }
    private bool BFS(int startY, int startX, ref char?[,] containers)
    {
        int rows = containers.GetLength(0);
        int cols = containers.GetLength(1);
        bool[,] visited = new bool[rows, cols];
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((startY, startX));
        visited[startY, startX] = true;

        int[] dirY = { -1, 1, 0, 0 };
        int[] dirX = { 0, 0, -1, 1 };

        while (queue.Count > 0)
        {
            var (y, x) = queue.Dequeue();

            if (y < 0 || y >= rows || x < 0 || x >= cols)
            {
                return true;
            }

            for (int k = 0; k < 4; k++)
            {
                int newY = y + dirY[k];
                int newX = x + dirX[k];

                if (newY < 0 || newY >= rows || newX < 0 || newX >= cols)
                {
                    return true;
                }

                if (!visited[newY, newX] && containers[newY, newX] == null)
                {
                    visited[newY, newX] = true;
                    queue.Enqueue((newY, newX));
                }
            }
        }
        return false;
    }
}