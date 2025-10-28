using System;
using System.Text;
using System.Linq;

public class PermutationGenerator
{
    // 결과를 한 번에 모아 출력하기 위한 StringBuilder
    private static StringBuilder outputBuilder = new StringBuilder();
    
    // N (전체 원소의 수)과 M (선택할 원소의 수)을 저장할 변수
    private static int N;
    private static int M;

    public static void Main(string[] args)
    {
        // 1. 입력 처리
        // 한 줄에서 N과 M을 입력받음
        string inputLine = Console.ReadLine();
        if (string.IsNullOrEmpty(inputLine)) return;

        string[] tokens = inputLine.Split();
        
        // 입력 값이 2개가 아니거나, 숫자로 변환할 수 없으면 종료
        if (tokens.Length < 2 || !int.TryParse(tokens[0], out N) || !int.TryParse(tokens[1], out M))
        {
            return;
        }

        // 2. 백트래킹을 위한 배열 초기화
        // arr: 현재까지 선택한 M개의 순열을 저장 (크기 M)
        int[] resultArr = new int[M];
        
        // isUsed: 1부터 N까지의 숫자가 사용되었는지 체크 (크기 N+1, 인덱스 0은 사용 안 함)
        bool[] isUsed = new bool[N + 1];

        // 3. 백트래킹 시작
        PermutationGenerator generator = new PermutationGenerator();
        generator.BackTrack(0, resultArr, isUsed);
        
        // 4. 결과 한 번에 출력
        Console.Write(outputBuilder.ToString());
    }
    
    /// <summary>
    /// 백트래킹을 사용하여 순열을 생성합니다.
    /// </summary>
    /// <param name="idx">현재 순열에서 채워야 할 인덱스</param>
    /// <param name="arr">생성 중인 순열 배열</param>
    /// <param name="isUsed">숫자 사용 여부 체크 배열</param>
    public void BackTrack(int idx, int[] arr, bool[] isUsed)
    {
        // 종료 조건: M개의 원소를 모두 채웠을 때
        if (idx == arr.Length)
        {
            // 현재 순열을 문자열로 변환하여 StringBuilder에 추가
            // string.Join(" ", arr)은 배열의 요소를 공백으로 구분하여 합쳐줍니다.
            outputBuilder.AppendLine(string.Join(" ", arr));
            return;
        }
        
        // 재귀 호출 부분: 1부터 N까지의 숫자 탐색
        // isUsed.Length는 N + 1 이므로, i는 1부터 N까지 순회합니다.
        for (int i = 1; i <= N; i++) 
        {
            // 가지치기: 현재 숫자가 사용되지 않았다면
            if (!isUsed[i])
            {
                // 1. 전진: 현재 숫자를 선택하고 사용 표시
                arr[idx] = i;
                isUsed[i] = true;
                
                // 2. 다음 인덱스 탐색
                BackTrack(idx + 1, arr, isUsed);
                
                // 3. 후퇴 (백트래킹): 사용 표시 해제
                isUsed[i] = false;
            }
        }
    }
}