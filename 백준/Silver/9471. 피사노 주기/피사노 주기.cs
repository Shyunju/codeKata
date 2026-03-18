using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 입력 속도를 위해 StringBuilder 사용
        StringBuilder sb = new StringBuilder();
        int P = int.Parse(Console.ReadLine());

        for (int t = 0; t < P; t++)
        {
            string[] input = Console.ReadLine().Split();
            int testCase = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int period = GetPisanoPeriod(M);
            sb.AppendLine($"{testCase} {period}");
        }
        Console.Write(sb.ToString());
    }

    static int GetPisanoPeriod(int M)
    {
        // M이 2 이상이라는 가정하에 (문제 조건 확인 필요)
        int prev = 0;
        int curr = 1;
        int i = 0;

        while (true)
        {
            i++;
            int next = (prev + curr) % M;
            prev = curr;
            curr = next;

            // 주기의 시작인 0, 1을 다시 만나면 종료
            if (prev == 0 && curr == 1)
                return i;
            
            // 안전 장치: 피사노 주기는 이론적으로 최대 6M (M=2*5^k 일 때)
            // 혹은 M^2 이내에 반드시 존재함
        }
    }
}