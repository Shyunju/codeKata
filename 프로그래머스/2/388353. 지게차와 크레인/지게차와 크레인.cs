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
        
        //글자가 하나면 외벽 노출된 요소만 제거 = 포문을 돌며 좌우 상하가 범위 밖이거나 null인 요소 좌표 저장 후 제거
        //글자가 두개면 오든 요소를 제거 = 포문을 돌며 모든 요소 제거
        //최종적으로 남아있는 즉 널이 아닌 요소의 수 리턴
        
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
        int[] dirX = {0, 0, -1, 1};
        int[] dirY = {-1, 1, 0, 0};
        for(int i = 0; i < containers.GetLength(0); i++)
        {
            for(int j = 0; j < containers.GetLength(1); j++)
            {
                if(containers[i,j] == target)
                {
                    for(int k = 0; k < 4; k++)
                    {
                        if(i+dirX[k] < 0 || i+dirX[k] >= containers.GetLength(0) || j+dirY[k] < 0 || j+dirY[k] >= containers.GetLength(1)) //out of range
                        {
                            points.Add((i, j));
                            break;
                        }else if(containers[i+dirX[k],j+dirY[k]] == null)
                        {
                            points.Add((i, j));
                            break;
                        }
                    }
                }
            }            
        }
        foreach(var point in points)
        {
            containers[point.Item1, point.Item2] = null;
        }
        
    }
}