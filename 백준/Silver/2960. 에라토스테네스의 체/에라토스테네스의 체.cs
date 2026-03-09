using System;
public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        bool[] nums = new bool[n+1];
        
        nums[0] = true;
        nums[1] = true; 
        int answer = 0;
        
        for(int i = 2; i <= n; i++)
        {
            if(nums[i])    continue;
            nums[i] = true;
            answer++;
            if(answer == k)
            {
                Console.WriteLine(i);
                return;
            }
            for(int j = i * i; j <= n; j += i)
            {
                if(!nums[j])
                {
                    nums[j] = true;
                    answer++;
                    if(answer == k)
                    {
                        Console.WriteLine(j);
                        return;
                    }
                }
            }
        }
    }
}