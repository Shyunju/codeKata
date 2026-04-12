using System;
using System.Collections.Generic;
using System.Text;
internal class Program
{
    static void Main(string[] args){
        string[] sl = Console.ReadLine().Split();
        
        int n = int.Parse(sl[0]);
        int x = int.Parse(sl[1]);
        
        List<int> answer = new List<int>();
        
        string[] sl2 = Console.ReadLine().Split();
        
        for(int i = 0; i< n; i++){
            int num = int.Parse(sl2[i]);
            if(num < x)
                answer.Add(num);
        }
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < answer.Count(); i++)
            sb.Append(answer[i] + " ");
        
        Console.Write(sb.ToString());
    }
}