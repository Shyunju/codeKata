using System;
using System.Collections.Generic;
using System.Text;
internal class Program
{
    static void Main(string[] args){
        string s1 = Console.ReadLine();
        string[] sl1 = s1.Split();
        
        int n = int.Parse(sl1[0]);
        int x = int.Parse(sl1[1]);
        
        List<int> answer = new List<int>();
        
        string s2 = Console.ReadLine();
        string[] sl2 = s2.Split();
        
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