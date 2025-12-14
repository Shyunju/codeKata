using System;

public class Program
{
    static int N;
    static int CNT = 0;
    public static void Main(string[] args)
    {
        Program p = new Program();
        bool[] isUsed1 = new bool[40];
        bool[] isUsed2 = new bool[40];
        bool[] isUsed3 = new bool[40];
        
        N = int.Parse(Console.ReadLine());
        p.NQueen(0, isUsed1, isUsed2, isUsed3);      
        Console.WriteLine(CNT);
    }
    public void NQueen(int cur, bool[] isUsed1, bool[] isUsed2, bool[] isUsed3)
    {
        if(cur == N)
        {
            CNT++;
            return;
        }
                    
        for(int i = 0; i < N; i++)
        {
            if(isUsed1[i] || isUsed2[i+cur] || isUsed3[cur-i+N-1])
                continue;
            isUsed1[i] = true;
            isUsed2[i+cur] = true;
            isUsed3[cur-i+N-1] = true;
            NQueen(cur+1, isUsed1, isUsed2, isUsed3);
            isUsed1[i] = false;
            isUsed2[i+cur] = false;
            isUsed3[cur-i+N-1] = false;
        }
    }
}