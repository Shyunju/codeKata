using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[2];
        
        int[] dy = new int[]{-1, 1, 0, 0};
        int[] dx = new int[]{0, 0, -1, 1};
        
        char[] direction = new char[]{'N', 'S', 'W', 'E'};
        
        int height = park.Length;
        int width = park[0].Length;
        
        for(int i = 0; i <height; i++){
            for(int j = 0; j < width; j++){
                if(park[i][j] == 'S'){
                    answer[0] = i;
                    answer[1] = j;
                }
            }
        }
        foreach(string i in routes){
            int dir = Array.IndexOf(direction, i[0]);
            int count = int.Parse(i[2].ToString());
            int y = answer[0];
            int x = answer[1];
            for(int j = 1; j <= count; j++){
                if(y + dy[dir] < 0 || y + dy[dir] >= height || x + dx[dir] < 0 || x + dx[dir] >= width){
                    y = answer[0];
                    x = answer[1];
                    break;
                }
                if(park[y + dy[dir]][x + dx[dir]] == 'X'){
                    y = answer[0];
                    x = answer[1];
                    break;
                }
                y += dy[dir];
                x += dx[dir];
            }
            answer[0] = y;
            answer[1] = x;
        }
        return answer;
    }
}