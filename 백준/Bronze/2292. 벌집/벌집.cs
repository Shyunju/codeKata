using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args){
        double n = double.Parse(Console.ReadLine());
        
        if(n == 1)
            Console.Write(1);
        else{
            int start = 0;
            int gap = 1;
            int answer = 1;
            
            while(true){
                if(n >= (6* start + 2) && n <= (6 * (start + gap) +1)){
                    Console.Write(answer + 1);
                    break;
                }
                start += gap;
                gap++;
                answer++;
            }
        }
    }
}