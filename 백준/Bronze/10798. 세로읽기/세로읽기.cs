using System;
using System.Text;
internal class Program
{
    static void Main(string[] args){
        string[] n = new string[5];
        for(int i = 0; i < 5; i++){
            string s = Console.ReadLine();
            s = s.PadRight(15);
            n[i] = s;
        }
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i<15; i++){
            for(int j = 0; j < 5; j++){
                if(n[j][i] == ' ')
                    continue;
                sb.Append(n[j][i]);
            }
        }
        Console.Write(sb.ToString());
    }
}