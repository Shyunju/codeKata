using System;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //그냥 콘솔창 예쁘게 꾸미는 코드(심심해서 넣음)
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            //입력값 한줄 받아올 배열변수
            string[] input;
            //현재 확인중인 과목의 과목평점(A+등급등을 4.5로 변환한거) 담을 변수
            float gradeScore = 0f;
            //현재 확인중인 과목의 학점 담을 변수
            float currentCredit = 0f;
            //내가 수강한 과목의 총학점 담을 변수
            float totalCredit = 0f;

            //현재 확인중인 과목 학점 * 그 과목의 과목평점 결과들을 모두 합해서 넣을 변수
            float totalSumResult = 0f;

            //총 과목 20개니까 20번 반복
            for (int i = 0; i < 20; i++)
            {
                //input에 한줄씩 내 입력값 받아옴
                input = Console.ReadLine().Split();

                //만약 P과목이 아니라면 ConvertGradesToScores메소드 실행
                if (input[2] != "P")
                {
                    gradeScore = ConvertGradesToScores(input[2]);
                }
                //만약 P과목이라면 이번 반복문 건너뜀
                else
                {
                    continue;
                }

                //현재 확인중인 과목의 학점을 currentCredit 변수에 저장함
                currentCredit = float.Parse(input[1]);
                //과목총학점 변수에 현재 확인중인 과목 학점을 더해서 저장
                totalCredit += currentCredit;
                //과목별로 학점 × 과목평점의 값을 totalSumResult 변수에 저장함
                totalSumResult += currentCredit * gradeScore;
            }
            //과목별로 학점 × 과목평점 계산을 해서 합친값에 학점총합을 나눈값을 결과로 출력
            Console.WriteLine(totalSumResult / totalCredit);

        }

        //문자로 나타내진 내 등급을 과목평점으로 변환해주는 메소드
        private static float ConvertGradesToScores(string grade)
        {
            //임시변수 temp
            float temp = 0;
            //등급 앞글자에 따라서 점수가 나뉨(F일경우 0반환하고 바로 메소드 종료)
            switch (grade[0])
            {
                case 'F':
                    return 0.0f;
                case 'A':
                    temp += 4.0f;
                    break;
                case 'B':
                    temp += 3.0f;
                    break;
                case 'C':
                    temp += 2.0f;
                    break;
                case 'D':
                    temp += 1.0f;
                    break;
                default:
                    break;
            }

            //등급 뒷자리가 0인지 +인지에따라 점수 더해줌
            switch (grade[1])
            {
                case '+':
                    temp += 0.5f;
                    break;
                case '0':
                    //temp += 0.0f;
                    break;
            }
            //결과 반환
            return temp;
        }

    }
}