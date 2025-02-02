using System;
using System.Collections.Generic;
using System.Text;
internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;
        while( n > 0){
            n--;
            bool bc = false;
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);
            
            for(int i = 1; i < s.Length; i++){
                if(s[i-1] == s[i])    continue;
                else sb.Append(s[i]);
            }
            for(int i = 0; i < sb.Length; i++){
                for(int j = 1; j< sb.Length; j++){
                    if(sb[i] == sb[j] && i != j)
                        bc = true;
                }
            }
            if(!bc)
                cnt++;
        }
        Console.Write(cnt);
    }
}