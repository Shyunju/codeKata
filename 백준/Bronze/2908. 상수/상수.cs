using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args){
        string[] sl = Console.ReadLine().Split(" ");
        string str = "";
        for(int i = 2; i >= 0; i--){
            if(sl[0][i] > sl[1][i]){
                str = sl[0];
                break;
            }else if(sl[0][i] == sl[1][i]){
                continue;
            }else{
                str = sl[1];
                break;
            }
        }
        string answer = new string(str.Reverse().ToArray());
        Console.Write(answer);
    }
}