using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args){
        var dic = new Dictionary<char, int>();
        string s= Console.ReadLine();
        string bigs = s.ToUpper();
        for(int i = 0; i < bigs.Length; i++){
            if(dic.ContainsKey(bigs[i])){
                dic[bigs[i]]++;
            }else{
                dic.Add(bigs[i], 1);
            }
        }
        int max = dic.Values.Max();
        int cnt = 0;
        string answer = "";
        foreach(KeyValuePair<char, int> item in dic){
            if(item.Value == max){
                ++cnt;
                answer = item.Key.ToString();
            }
            if(cnt >= 2){
                answer = "?";
                break;
            }
        }
        Console.Write(answer);
    }
}