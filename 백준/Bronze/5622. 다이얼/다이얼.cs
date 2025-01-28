using System;

class 다이얼
{
    static void Main()
    {
        string str = Console.ReadLine();
        Console.WriteLine(Test(str));
    }
        
    static int Test(string s)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case <= 'C':
                    sum += 3;
                    break;
                case <= 'F':
                    sum += 4;
                    break;
                case <= 'I':
                    sum += 5;
                    break;
                case <= 'L':
                    sum += 6;
                    break;
                case <= 'O':
                    sum += 7;
                    break;
                case <= 'S':
                    sum += 8;
                    break;
                case <= 'V':
                    sum += 9;
                    break;
                case <= 'Z':
                    sum += 10;
                    break;
            }
        }
        return sum;
    }
}