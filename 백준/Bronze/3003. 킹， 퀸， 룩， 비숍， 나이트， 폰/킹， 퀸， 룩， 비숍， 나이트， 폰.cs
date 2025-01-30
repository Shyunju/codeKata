//킹 1개, 퀸 1개, 룩 2개, 비숍 2개, 나이트 2개, 폰 8개로 
using System;

internal class Program
{
    static void Main(string[] args){
        int[] chess = {1, 1, 2, 2, 2, 8};
        int n = 0;
        string[] sl = Console.ReadLine().Split();
        for(int i = 0; i < chess.Length; i++){
            n = int.Parse(sl[i]);
            Console.Write(chess[i] - n + " ");
        }
    }
}