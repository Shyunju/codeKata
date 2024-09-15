using System;

public class Solution
{
    public int solution(int[,] beginning, int[,] target){
        int answer = -1;

        // 각 인덱스에 대해 beginning == target ? 1 : -1 이 들어간 배열
        var intArrays = new int[target.GetLength(0), target.GetLength(1)];

        for (int i = 0; i < target.GetLength(0); i++)
            for (int j = 0; j < target.GetLength(1); j++)
                intArrays[i, j] = (beginning[i, j] == target[i, j]) ? 1 : -1;

        DFS(0, 0, intArrays, ref answer);

        return answer;
    }

    public void DFS(int currNum, int count, int[,] intArrays, ref int answer)
    {
        int index = currNum;

        // 모든 행과 열에 대한 연산을 마쳤다면
        if (index == intArrays.GetLength(0) + intArrays.GetLength(1))
        {
            foreach (int num in intArrays)
                if (num == -1)
                    return;

                // 목표상태에 도달한 경우라면
            if (answer == -1)
                answer = count;
            else
                answer = Math.Min(answer, count);

            return;
        }
            
        if (index >= intArrays.GetLength(0)) // 열 연산 (행 연산이 끝난 경우)
        {
            index -= intArrays.GetLength(0); // 인덱스 돌려놓기

            // 열을 뒤집은 경우
            for (int i = 0; i < intArrays.GetLength(0); i++)
                intArrays[i, index] *= -1;

            DFS(currNum + 1, count + 1, intArrays, ref answer);

            for (int i = 0; i < intArrays.GetLength(0); i++)
                intArrays[i, index] *= -1;

                // 뒤집지 않은 경우
            DFS(currNum + 1, count, intArrays, ref answer);
        }
        else // 행 연산
        {
            // 행을 뒤집은 경우
            for (int i = 0; i < intArrays.GetLength(1); i++)
                intArrays[index, i] *= -1;

            DFS(currNum + 1, count + 1, intArrays, ref answer);

            for (int i = 0; i < intArrays.GetLength(1); i++)
                intArrays[index, i] *= -1;

            // 뒤집지 않은 경우
            DFS(currNum + 1, count, intArrays, ref answer);
        }
    }
}