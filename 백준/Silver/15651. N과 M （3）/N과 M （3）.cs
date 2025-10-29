using System;
using System.Text;
using System.Linq;

public class Program
{
    public static StringBuilder sb = new StringBuilder();
    public static int N;
    public static int M;
    public static void Main(string[] args)
    {
        Program p = new Program();
        string inputLine = Console.ReadLine();
        if (string.IsNullOrEmpty(inputLine)) return;

        string[] tokens = inputLine.Split();
        if (tokens.Length < 2 || !int.TryParse(tokens[0], out N) || !int.TryParse(tokens[1], out M))
        {
            return;
        }
        
        int[] arr = new int[M];
        p.BackTrack(0, arr);
        Console.Write(sb.ToString());
    }
    public void BackTrack(int idx, int[] arr)
    {
        if(idx == M)
        {
            sb.AppendLine(string.Join(" ", arr));
            return;
        }
        for(int i = 1; i <= N; i++)
        {
            arr[idx] = i;
            BackTrack(idx+1, arr);
        }
    }
}