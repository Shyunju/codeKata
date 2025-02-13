using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args){
        int num = int.Parse(Console.ReadLine());
        int lineCnt = 0, lineSum = 0, lineIdx = 0;
        
        while(num > lineSum){
            lineCnt++;
            lineSum += lineCnt;
        }
        lineIdx = num - (lineSum - lineCnt);
        
        if(lineCnt % 2 == 1)
            Console.WriteLine((lineCnt-lineIdx+1) + "/" +lineIdx);
        else
            Console.WriteLine(lineIdx + "/" + (lineCnt-lineIdx+1));
    }
}