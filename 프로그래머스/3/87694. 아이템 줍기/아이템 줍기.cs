using System;
using System.Collections.Generic;
public class Solution {
    public class Pos{
        public int y;
        public int x;
        public int count;
        
        public Pos(int y, int x, int count){
            this.y = y;
            this.x = x;
            this.count = count;
        }
    }
    public int solution(int[,] rectangle, int charX, int charY, int itemX, int itemY) {
        int answer = 0;
        var intArr = new int[102, 102];
        
        charY *= 2;
        charX *= 2;
        itemY *= 2;
        itemX *= 2;
        
        for(int i = 0; i < rectangle.GetLength(0); i++){
            int startY = rectangle[i,1] * 2;
            int startX = rectangle[i,0] * 2;
            int endY = rectangle[i,3] * 2;
            int endX = rectangle[i,2] * 2;
            
            for(int y = startY; y <= endY; y++){
                for(int x = startX; x <= endX; x++){
                    if( y == startY || y == endY || x == startX || x == endX){
                        if(intArr[y,x] != 2){
                            intArr[y,x] = 1;
                            continue;
                        }
                    }
                    intArr[y, x] = 2;
                }
            }
        }
        
        var q = new Queue<Pos>();
        q.Enqueue(new Pos(charY, charX, 0));
        
        int[] dirY = new int[4]{0, 0, 1, -1};
        int[] dirX = new int[4]{1, -1, 0, 0};
        
        while(q.Count > 0){
            Pos curPos = q.Dequeue();
            intArr[curPos.y, curPos.x] = 2;
            
            for(int i = 0; i < 4; i++){
                Pos movePos = new Pos(curPos.y + dirY[i], curPos.x + dirX[i], curPos.count +1);
                
                if(movePos.y == itemY && movePos.x == itemX){
                    answer = movePos.count / 2;
                    q.Clear();
                    break;
                }
                if(intArr[movePos.y, movePos.x] == 1)
                    q.Enqueue(movePos);
            }
        }
        return answer;
    }
}