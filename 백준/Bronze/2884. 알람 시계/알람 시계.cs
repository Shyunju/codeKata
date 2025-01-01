using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        string[] sl = s.Split();
        
        int hh = int.Parse(sl[0]);
        int mm = int.Parse(sl[1]);
        
       //45보다 크면 걍빼기 작으면 45에서 빼고 나머지 60에서 빼고 시간 -1
        if(mm >= 45)
            mm -= 45;
        else{
            int min = 45 - mm;
            mm = 60 - min;
            hh -= 1;
            if(hh < 0)
                hh = 23;
        }
        Console.WriteLine(hh + " " + mm);
    }
}