using System;
using System.Text;
using System.Linq;

public class PermutationGenerator
{
    private static StringBuilder outputBuilder = new StringBuilder();
    
    private static int N;
    private static int M;

    public static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();
        if (string.IsNullOrEmpty(inputLine)) return;

        string[] tokens = inputLine.Split();
        
        // 입력 값이 2개가 아니거나, 숫자로 변환할 수 없으면 종료
        if (tokens.Length < 2 || !int.TryParse(tokens[0], out N) || !int.TryParse(tokens[1], out M))
        {
            return;
        }

        int[] resultArr = new int[M];
        bool[] isUsed = new bool[N + 1];

        PermutationGenerator generator = new PermutationGenerator();
        generator.BackTrack(0, resultArr, isUsed);
        
        Console.Write(outputBuilder.ToString());
    }
    
    public void BackTrack(int idx, int[] arr, bool[] isUsed)
    {
        if (idx == arr.Length)
        {
            outputBuilder.AppendLine(string.Join(" ", arr));
            return;
        }
        
        for (int i = 1; i <= N; i++) 
        {
            if (!isUsed[i])
            {
                arr[idx] = i;
                isUsed[i] = true;
                BackTrack(idx + 1, arr, isUsed);
                isUsed[i] = false;
            }
        }
    }
}