using System;

public class Program
{
    static int[] dy = {1,0,-1,0};
    static int[] dx = {0,1,0,-1};

    static List<(int, int)> cctv;
    static int N;
    static int M;
    static int[,] board1 = new int[10,10];
    static int[,] board2 = new int[10,10];
    
    public static void Main(string[] args)
    {
        Program p = new Program();
        cctv = new List<(int, int)>();
        int answer = 0;
        string[] sl = Console.ReadLine().Split();
        N = int.Parse(sl[0]);
        M = int.Parse(sl[1]);
        for(int i =0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            for (int k = 0; k < input.Length; k++)
            {
                //입력값을 2차원배열에 넣음
                board1[i, k] = int.Parse(input[k].ToString()); 
                if(board1[i,k] != 0 && board1[i,k] != 6)
                    cctv.Add((i,k));
                if(board1[i,k] == 0)
                    answer++;
            }
            
        }
        for(int tmp = 0; tmp < (1 << (2 * cctv.Count)); tmp++)
        {
            for(int i = 0; i < N; i++)
            {
                for(int j= 0; j < M; j++)
                {
                    board2[i,j] = board1[i,j];
                }
            }
            int brute = tmp;
            for(int i = 0; i < cctv.Count; i++)
            {
                int dir = brute % 4;
                brute /= 4;
                int x = cctv[i].Item1;
                int y = cctv[i].Item2;
                
                if(board1[x,y] == 1)
                {
                    p.UPD(x, y, dir);
                }
                else if(board1[x,y] == 2)
                {
                    p.UPD(x,y, dir);
                    p.UPD(x,y, dir + 2);
                }
                else if(board1[x,y] == 3)
                {
                    p.UPD(x,y, dir);
                    p.UPD(x,y, dir+1);
                }
                else if(board1[x,y] == 4)
                {
                    p.UPD(x,y, dir);
                    p.UPD(x,y, dir+1);
                    p.UPD(x,y, dir+2);
                }
                else
                {
                    p.UPD(x,y, dir);
                    p.UPD(x,y, dir+1);
                    p.UPD(x,y, dir+2);
                    p.UPD(x,y, dir+3);
                }
            }
            int val = 0;
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    val += board2[i,j] == 0 ? 1 : 0;
                }
            }
            answer = Math.Min(answer, val);
        }
        Console.WriteLine(answer);
        
        
    }
    public bool OOB(int a, int b)
    {
        return a < 0 || a >= N || b < 0 || b >= M;
    }
    public void UPD(int x, int y, int dir)
    {
        dir %= 4;
        while(true)
        {
            x += dx[dir];
            y += dy[dir];
            if(OOB(x, y) || board2[x,y] == 6) return;
            if(board2[x,y] != 0) continue;
            board2[x,y] = 7;
        }
    }
}