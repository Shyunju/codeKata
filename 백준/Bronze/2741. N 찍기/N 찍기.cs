using System;
using System.Text;
public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int n = int.Parse(Console.ReadLine());
        StringBuilder allNum = new StringBuilder();

        for (int i=1; i<=n; i++)
        {
           allNum.AppendLine(i.ToString());
        }

        Console.WriteLine(allNum);
    }
}