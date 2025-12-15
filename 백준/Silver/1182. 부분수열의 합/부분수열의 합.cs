using System;

public class Program
{
    static int S;
    static int N;
    static int answer;
    public static void Main(string[] args)
    {
        Program p = new Program();
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        N = input[0];
        S = input[1];
        
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        p.BackTrack(arr, 0, 0);
        if(S == 0)
            answer--;
        Console.WriteLine(answer);
    }
    public void BackTrack(int[] arr, int idx, int sum)
    {
        if(idx == N)
        {
            if(sum == S) answer++;
            return;
        }
        BackTrack(arr, idx+1, sum);
        BackTrack(arr, idx+1, sum + arr[idx]);
    }
}