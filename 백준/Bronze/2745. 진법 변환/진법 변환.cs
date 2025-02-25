using System.Numerics;

string[] s = Console.ReadLine().Split();
string N = s[0];
int B = int.Parse(s[1]);

BigInteger result = ConvertToDecimal(N, B);
Console.WriteLine(result);

static BigInteger ConvertToDecimal(string N, int B)
{
    BigInteger decimalValue = 0;

    for (int i = 0; i < N.Length; i++)
    {
        char currentChar = N[i];

        BigInteger digit;

        // 현재 문자가 숫자인 경우
        if (char.IsDigit(currentChar))
        {
            digit = currentChar - '0';
        }
        // 현재 문자가 알파벳인 경우
        else
        {
            digit = char.ToUpper(currentChar) - 'A' + 10;
        }

        // 현재 자릿수의 값을 10진법 결과에 누적
        decimalValue = decimalValue * B + digit;
    }

    return decimalValue; 

}