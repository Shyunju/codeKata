using System;
using System.Text;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < n; i++){
            sb.Clear();
            string[] sl = Console.ReadLine().Split(" ");
            int m = int.Parse(sl[0]); //몇번씩
            for(int j = 0; j < sl[1].Length; j++){
                string s = sl[1][j].ToString();
                int cnt = 0;
                while(cnt < m){
                    sb.Append(s);
                    cnt++;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}