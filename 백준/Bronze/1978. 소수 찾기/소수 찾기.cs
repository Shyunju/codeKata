using System;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        string[] sl = s.Split();
        int cnt = 0;
        
        for(int i = 0; i < n; i++)
        {
            int num = int.Parse(sl[i]);
            if(num == 1)
                continue;
            for(int j =2; j <= num; j++)
            {
                if(j == num){
                    cnt++;
                    break;
                }
                    
                if(num % j == 0)
                {
                    break;
                }
                
            }
        }
        Console.WriteLine(cnt);
    }
}