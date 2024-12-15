using System;

public class Solution {
    int N, answer = Int32.MaxValue;
    int[,] map;
    int[] rotationCount;
    int[] dx = {0,0,0,1,-1};
    int[] dy = {0,1,-1,0,0};

    public int solution(int[,] clockHands) {
        N = clockHands.GetLength(0);
        map = new int[N,N];
        rotationCount = new int[N];
        for (int i = 0; i < N; i++) 
        {
            for (int j = 0; j < N; j++)
            {
                map[i,j] = 4 - clockHands[i,j] == 4 ? 0 : 4 - clockHands[i,j];
            }
        }

        DFS(0);
        return answer;
    }

    // 첫번째 줄 0~N-1 번째 칼럼의 회전수 정하기
    public void DFS (int ind) {
        if (ind == N) 
        {
            int[,] mapClone = (int[,])map.Clone();
            int[] rotationCountClone = (int[])rotationCount.Clone();

            int totalRotationCount = 0;
            // 모든 row에 대해
            for (int i = 0; i < N; i++) 
            {
                //특정 row에 대해 시계 돌려줌
                for (int j = 0; j < N; j++) 
                {
                    totalRotationCount += rotationCountClone[j];
                    // 4방향 + 현재 위치 시계 돌려줌
                    for (int d = 0; d < 5; d++) 
                    {
                        int X = i + dx[d];
                        int Y = j + dy[d];
                        if (X < 0 || Y < 0 || X >= N || Y >= N) continue;
                        mapClone[X,Y] = mapClone[X,Y] - rotationCountClone[j] >= 0 ? mapClone[X,Y] - rotationCountClone[j] : mapClone[X,Y] - rotationCountClone[j] + 4;
                    }
                }

                // 다음 row가 돌려야할 횟수 (위에 행이 밑에 행한테 영향주므로)
                for (int j = 0; j < N; j++) rotationCountClone[j] = mapClone[i,j];  
            }

            // 마지막 열의 상태 판별하여 결과 계산
            for (int i = 0; i < N; i++) 
            {
                if (rotationCountClone[i] != 0) return;
            }
            answer = Math.Min(answer, totalRotationCount);
            return;
        }

        // 각 행에 대해 회전수 정하기 (0, 90, 180, 270) => 모든 경우 확인
        for (int i = 0; i < 4; i++) 
        {
            rotationCount[ind] = i;
            DFS(ind + 1);
        }
    }
}