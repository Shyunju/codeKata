using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        //s의 좌표를 찾는다(새로운 맵을 만든다)
        int[,] map = new int[park.Length, park[0].Length];
        int y = 0;
        int x = 0;
        for(int i = 0; i < park.Length; i++){
            for(int j = 0; j < park[0].Length; j++){
                if(park[i][j] == 'S'){
                    y = i;
                    x = j;
                }else if(park[i][j] == 'X')
                    map[i,j] = 1;
            }
        }
        char[] dir = {'N', 'S', 'W', 'E'};
        int[] dy = {-1, 1, 0, 0};
        int[] dx = {0, 0, -1, 1};
        //명령을 가져온다
        foreach(string cmd in routes){
            int op = Array.IndexOf(dir, cmd[0]); //가능 방향
            int n = int.Parse(cmd[2].ToString()); //얼마나 가야하는가
            
            int nextY = y;
            int nextX = x;
            bool possible = true;
            
            for(int i = 0; i < n; i++){
                nextY += dy[op];
                nextX += dx[op];
                if(nextY < 0 || nextY >= map.GetLength(0) || nextX < 0 || nextX >= map.GetLength(1)){
                    possible = false;
                    break;
                }
                if(map[nextY, nextX] == 1){
                    possible = false;
                    break;
                }
            }
            if(possible){
                y = nextY;
                x = nextX;
            }
        }
        int[] answer = new int[2];
        answer[0] = y;
        answer[1] = x;
        return answer;
        //명령을 따라 움직이며 위치를 파악한다
        //불가능이라면 그냥 리턴, 가능하다면 결과를 갱신후 리턴
    }
}